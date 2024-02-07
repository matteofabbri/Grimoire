﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2009-2011 Michael Möller <mmoeller@openhardwaremonitor.org>
	
*/

using System;
using System.Linq;

namespace HardwareProviders.Board.LPC
{
    internal class W836XX : ISuperIO
    {
        // Consts 
        private const ushort WINBOND_VENDOR_ID = 0x5CA3;
        private const byte HIGH_BYTE = 0x80;

        // Hardware Monitor
        private const byte ADDRESS_REGISTER_OFFSET = 0x05;
        private const byte DATA_REGISTER_OFFSET = 0x06;

        // Hardware Monitor Registers
        private const byte VOLTAGE_VBAT_REG = 0x51;
        private const byte BANK_SELECT_REGISTER = 0x4E;
        private const byte VENDOR_ID_REGISTER = 0x4F;
        private const byte TEMPERATURE_SOURCE_SELECT_REG = 0x49;

        private readonly ushort address;

        private readonly byte[] FAN_BIT_REG =
            {0x47, 0x4B, 0x4C, 0x59, 0x5D};

        private readonly byte[] FAN_DIV_BIT0 = {36, 38, 30, 8, 10};
        private readonly byte[] FAN_DIV_BIT1 = {37, 39, 31, 9, 11};
        private readonly byte[] FAN_DIV_BIT2 = {5, 6, 7, 23, 15};

        private readonly byte[] FAN_TACHO_BANK =
            {0, 0, 0, 0, 5};

        private readonly byte[] FAN_TACHO_REG =
            {0x28, 0x29, 0x2A, 0x3F, 0x53};

        private readonly bool[] peciTemperature = new bool[0];
        private readonly byte revision;
        private readonly byte[] TEMPERATURE_BANK = {1, 2, 0};

        private readonly byte[] TEMPERATURE_REG = {0x50, 0x50, 0x27};
        private readonly byte[] voltageBank = new byte[0];
        private readonly float voltageGain = 0.008f;
        private readonly byte[] voltageRegister = new byte[0];

        public W836XX(Chip chip, byte revision, ushort address)
        {
            this.address = address;
            this.revision = revision;
            Chip = chip;

            if (!IsWinbondVendor())
                return;

            Temperatures = new float?[3];
            peciTemperature = new bool[3];
            switch (chip)
            {
                case Chip.W83667HG:
                case Chip.W83667HGB:
                    // note temperature sensor registers that read PECI
                    var flag = ReadByte(0, TEMPERATURE_SOURCE_SELECT_REG);
                    peciTemperature[0] = (flag & 0x04) != 0;
                    peciTemperature[1] = (flag & 0x40) != 0;
                    peciTemperature[2] = false;
                    break;
                case Chip.W83627DHG:
                case Chip.W83627DHGP:
                    // note temperature sensor registers that read PECI
                    var sel = ReadByte(0, TEMPERATURE_SOURCE_SELECT_REG);
                    peciTemperature[0] = (sel & 0x07) != 0;
                    peciTemperature[1] = (sel & 0x70) != 0;
                    peciTemperature[2] = false;
                    break;
                default:
                    // no PECI support
                    peciTemperature[0] = false;
                    peciTemperature[1] = false;
                    peciTemperature[2] = false;
                    break;
            }

            switch (chip)
            {
                case Chip.W83627EHF:
                    Voltages = new float?[10];
                    voltageRegister = new byte[]
                    {
                        0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x50, 0x51, 0x52
                    };
                    voltageBank = new byte[] {0, 0, 0, 0, 0, 0, 0, 5, 5, 5};
                    voltageGain = 0.008f;
                    Fans = new float?[5];
                    break;
                case Chip.W83627DHG:
                case Chip.W83627DHGP:
                case Chip.W83667HG:
                case Chip.W83667HGB:
                    Voltages = new float?[9];
                    voltageRegister = new byte[]
                    {
                        0x20, 0x21, 0x22, 0x23, 0x24, 0x25, 0x26, 0x50, 0x51
                    };
                    voltageBank = new byte[] {0, 0, 0, 0, 0, 0, 0, 5, 5};
                    voltageGain = 0.008f;
                    Fans = new float?[5];
                    break;
                case Chip.W83627HF:
                case Chip.W83627THF:
                case Chip.W83687THF:
                    Voltages = new float?[7];
                    voltageRegister = new byte[]
                    {
                        0x20, 0x21, 0x22, 0x23, 0x24, 0x50, 0x51
                    };
                    voltageBank = new byte[] {0, 0, 0, 0, 0, 5, 5};
                    voltageGain = 0.016f;
                    Fans = new float?[3];
                    break;
            }
        }

        public byte? ReadGPIO(int index)
        {
            return null;
        }

        public void WriteGPIO(int index, byte value)
        {
        }

        public void SetControl(int index, byte? value)
        {
        }

        public Chip Chip { get; }

        public float?[] Voltages { get; } = new float?[0];

        public float?[] Temperatures { get; } = new float?[0];

        public float?[] Fans { get; } = new float?[0];

        public float?[] Controls { get; } = new float?[0];

        public void Update()
        {
            if (!Ring0.WaitIsaBusMutex(10))
                return;

            for (var i = 0; i < Voltages.Length; i++)
                if (voltageRegister[i] != VOLTAGE_VBAT_REG)
                {
                    // two special VCore measurement modes for W83627THF
                    float fvalue;
                    if ((Chip == Chip.W83627HF || Chip == Chip.W83627THF ||
                         Chip == Chip.W83687THF) && i == 0)
                    {
                        var vrmConfiguration = ReadByte(0, 0x18);
                        int value = ReadByte(voltageBank[i], voltageRegister[i]);
                        if ((vrmConfiguration & 0x01) == 0)
                            fvalue = 0.016f * value; // VRM8 formula
                        else
                            fvalue = 0.00488f * value + 0.69f; // VRM9 formula
                    }
                    else
                    {
                        int value = ReadByte(voltageBank[i], voltageRegister[i]);
                        fvalue = voltageGain * value;
                    }

                    if (fvalue > 0)
                        Voltages[i] = fvalue;
                    else
                        Voltages[i] = null;
                }
                else
                {
                    // Battery voltage
                    var valid = (ReadByte(0, 0x5D) & 0x01) > 0;
                    if (valid)
                        Voltages[i] = voltageGain * ReadByte(5, VOLTAGE_VBAT_REG);
                    else
                        Voltages[i] = null;
                }

            for (var i = 0; i < Temperatures.Length; i++)
            {
                var value = (sbyte) ReadByte(TEMPERATURE_BANK[i],
                                TEMPERATURE_REG[i]) << 1;
                if (TEMPERATURE_BANK[i] > 0)
                    value |= ReadByte(TEMPERATURE_BANK[i],
                                 (byte) (TEMPERATURE_REG[i] + 1)) >> 7;

                var temperature = value / 2.0f;
                if (temperature <= 125 && temperature >= -55 && !peciTemperature[i])
                    Temperatures[i] = temperature;
                else
                    Temperatures[i] = null;
            }

            ulong bits = FAN_BIT_REG.Aggregate<byte, ulong>(0, (current, t) => (current << 8) | ReadByte(0, t));
            var newBits = bits;
            for (var i = 0; i < Fans.Length; i++)
            {
                int count = ReadByte(FAN_TACHO_BANK[i], FAN_TACHO_REG[i]);

                // assemble fan divisor
                var divisorBits = (int) (
                    (((bits >> FAN_DIV_BIT2[i]) & 1) << 2) |
                    (((bits >> FAN_DIV_BIT1[i]) & 1) << 1) |
                    ((bits >> FAN_DIV_BIT0[i]) & 1));
                var divisor = 1 << divisorBits;

                var value = count < 0xff ? 1.35e6f / (count * divisor) : 0;
                Fans[i] = value;

                // update fan divisor
                if (count > 192 && divisorBits < 7)
                    divisorBits++;
                if (count < 96 && divisorBits > 0)
                    divisorBits--;

                newBits = SetBit(newBits, FAN_DIV_BIT2[i], (divisorBits >> 2) & 1);
                newBits = SetBit(newBits, FAN_DIV_BIT1[i], (divisorBits >> 1) & 1);
                newBits = SetBit(newBits, FAN_DIV_BIT0[i], divisorBits & 1);
            }

            // write new fan divisors 
            for (var i = FAN_BIT_REG.Length - 1; i >= 0; i--)
            {
                var oldByte = (byte) (bits & 0xFF);
                var newByte = (byte) (newBits & 0xFF);
                bits = bits >> 8;
                newBits = newBits >> 8;
                if (oldByte != newByte)
                    WriteByte(0, FAN_BIT_REG[i], newByte);
            }

            Ring0.ReleaseIsaBusMutex();
        }

        private byte ReadByte(byte bank, byte register)
        {
            Ring0.WriteIoPort(
                (ushort) (address + ADDRESS_REGISTER_OFFSET), BANK_SELECT_REGISTER);
            Ring0.WriteIoPort(
                (ushort) (address + DATA_REGISTER_OFFSET), bank);
            Ring0.WriteIoPort(
                (ushort) (address + ADDRESS_REGISTER_OFFSET), register);
            return Ring0.ReadIoPort(
                (ushort) (address + DATA_REGISTER_OFFSET));
        }

        private void WriteByte(byte bank, byte register, byte value)
        {
            Ring0.WriteIoPort(
                (ushort) (address + ADDRESS_REGISTER_OFFSET), BANK_SELECT_REGISTER);
            Ring0.WriteIoPort(
                (ushort) (address + DATA_REGISTER_OFFSET), bank);
            Ring0.WriteIoPort(
                (ushort) (address + ADDRESS_REGISTER_OFFSET), register);
            Ring0.WriteIoPort(
                (ushort) (address + DATA_REGISTER_OFFSET), value);
        }

        private bool IsWinbondVendor()
        {
            var vendorId =
                (ushort) ((ReadByte(HIGH_BYTE, VENDOR_ID_REGISTER) << 8) |
                          ReadByte(0, VENDOR_ID_REGISTER));
            return vendorId == WINBOND_VENDOR_ID;
        }

        private static ulong SetBit(ulong target, int bit, int value)
        {
            if ((value & 1) != value)
                throw new ArgumentException("Value must be one bit only.");

            if (bit < 0 || bit > 63)
                throw new ArgumentException("Bit out of range.");

            var mask = (ulong) 1 << bit;
            return value > 0 ? target | mask : target & ~mask;
        }
    }
}