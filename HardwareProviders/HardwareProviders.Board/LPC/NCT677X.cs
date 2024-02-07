﻿/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2010-2015 Michael Möller <mmoeller@openhardwaremonitor.org>
	Copyright (C) 2015 Dawid Gan <deveee@gmail.com>

*/

using System;

namespace HardwareProviders.Board.LPC
{
    internal class NCT677X : ISuperIO
    {
        // Hardware Monitor
        private const uint ADDRESS_REGISTER_OFFSET = 0x05;
        private const uint DATA_REGISTER_OFFSET = 0x06;
        private const byte BANK_SELECT_REGISTER = 0x4E;

        // Consts 
        private const ushort NUVOTON_VENDOR_ID = 0x5CA3;

        private readonly ushort?[] alternateTemperatureRegister;

        private readonly ushort[] FAN_CONTROL_MODE_REG;
        private readonly ushort[] FAN_PWM_COMMAND_REG;

        private readonly ushort[] FAN_PWM_OUT_REG;

        private readonly ushort fanRpmBaseRegister;
        private readonly byte[] initialFanControlMode = new byte[6];
        private readonly byte[] initialFanPwmCommand = new byte[6];

        private readonly bool isNuvotonVendor;
        private readonly LPCPort lpcPort;
        private readonly int minFanRPM;

        private readonly ushort port;

        private readonly bool[] restoreDefaultFanControlRequired = new bool[6];
        private readonly byte revision;
        private readonly int[] temperatureHalfBit;
        private readonly ushort[] temperatureHalfRegister;

        private readonly ushort[] temperatureRegister;
        private readonly ushort[] temperatureSourceRegister;

        private readonly byte[] temperaturesSource;
        private readonly ushort vBatMonitorControlRegister;

        // Hardware Monitor Registers    
        private readonly ushort VENDOR_ID_HIGH_REGISTER;
        private readonly ushort VENDOR_ID_LOW_REGISTER;

        private readonly ushort[] voltageRegisters;

        private readonly ushort voltageVBatRegister;

        public NCT677X(Chip chip, byte revision, ushort port, LPCPort lpcPort)
        {
            Chip = chip;
            this.revision = revision;
            this.port = port;
            this.lpcPort = lpcPort;

            if (chip == Chip.NCT610X)
            {
                VENDOR_ID_HIGH_REGISTER = 0x80FE;
                VENDOR_ID_LOW_REGISTER = 0x00FE;

                FAN_PWM_OUT_REG = new ushort[] {0x04A, 0x04B, 0x04C};
                FAN_PWM_COMMAND_REG = new ushort[] {0x119, 0x129, 0x139};
                FAN_CONTROL_MODE_REG = new ushort[] {0x113, 0x123, 0x133};

                vBatMonitorControlRegister = 0x0318;
            }
            else
            {
                VENDOR_ID_HIGH_REGISTER = 0x804F;
                VENDOR_ID_LOW_REGISTER = 0x004F;

                FAN_PWM_OUT_REG = new ushort[]
                {
                    0x001, 0x003, 0x011, 0x013, 0x015, 0x017
                };
                FAN_PWM_COMMAND_REG = new ushort[]
                {
                    0x109, 0x209, 0x309, 0x809, 0x909, 0xA09
                };
                FAN_CONTROL_MODE_REG = new ushort[]
                {
                    0x102, 0x202, 0x302, 0x802, 0x902, 0xA02
                };

                vBatMonitorControlRegister = 0x005D;
            }

            isNuvotonVendor = IsNuvotonVendor();

            if (!isNuvotonVendor)
                return;

            switch (chip)
            {
                case Chip.NCT6771F:
                case Chip.NCT6776F:
                    if (chip == Chip.NCT6771F)
                    {
                        Fans = new float?[4];

                        // min value RPM value with 16-bit fan counter
                        minFanRPM = (int) (1.35e6 / 0xFFFF);

                        temperaturesSource = new[]
                        {
                            (byte) SourceNCT6771F.PECI_0,
                            (byte) SourceNCT6771F.CPUTIN,
                            (byte) SourceNCT6771F.AUXTIN,
                            (byte) SourceNCT6771F.SYSTIN
                        };
                    }
                    else
                    {
                        Fans = new float?[5];

                        // min value RPM value with 13-bit fan counter
                        minFanRPM = (int) (1.35e6 / 0x1FFF);

                        temperaturesSource = new[]
                        {
                            (byte) SourceNCT6776F.PECI_0,
                            (byte) SourceNCT6776F.CPUTIN,
                            (byte) SourceNCT6776F.AUXTIN,
                            (byte) SourceNCT6776F.SYSTIN
                        };
                    }

                    fanRpmBaseRegister = 0x656;

                    Controls = new float?[3];

                    Voltages = new float?[9];
                    voltageRegisters = new ushort[]
                        {0x020, 0x021, 0x022, 0x023, 0x024, 0x025, 0x026, 0x550, 0x551};
                    voltageVBatRegister = 0x551;

                    Temperatures = new float?[4];
                    temperatureRegister = new ushort[]
                        {0x027, 0x073, 0x075, 0x077, 0x150, 0x250, 0x62B, 0x62C, 0x62D};
                    temperatureHalfRegister = new ushort[]
                        {0, 0x074, 0x076, 0x078, 0x151, 0x251, 0x62E, 0x62E, 0x62E};
                    temperatureHalfBit = new[]
                        {-1, 7, 7, 7, 7, 7, 0, 1, 2};
                    temperatureSourceRegister = new ushort[]
                        {0x621, 0x100, 0x200, 0x300, 0x622, 0x623, 0x624, 0x625, 0x626};

                    alternateTemperatureRegister = new ushort?[]
                        {null, null, null, null};
                    break;

                case Chip.NCT6779D:
                case Chip.NCT6791D:
                case Chip.NCT6792D:
                case Chip.NCT6793D:
                case Chip.NCT6795D:
                case Chip.NCT6796D:
                    if (chip == Chip.NCT6779D)
                    {
                        Fans = new float?[5];
                        Controls = new float?[5];
                    }
                    else
                    {
                        Fans = new float?[6];
                        Controls = new float?[6];
                    }

                    fanRpmBaseRegister = 0x4C0;

                    // min value RPM value with 13-bit fan counter
                    minFanRPM = (int) (1.35e6 / 0x1FFF);

                    Voltages = new float?[15];
                    voltageRegisters = new ushort[]
                    {
                        0x480, 0x481, 0x482, 0x483, 0x484, 0x485, 0x486, 0x487, 0x488,
                        0x489, 0x48A, 0x48B, 0x48C, 0x48D, 0x48E
                    };
                    voltageVBatRegister = 0x488;

                    Temperatures = new float?[7];
                    temperaturesSource = new[]
                    {
                        (byte) SourceNCT67XXD.PECI_0,
                        (byte) SourceNCT67XXD.CPUTIN,
                        (byte) SourceNCT67XXD.SYSTIN,
                        (byte) SourceNCT67XXD.AUXTIN0,
                        (byte) SourceNCT67XXD.AUXTIN1,
                        (byte) SourceNCT67XXD.AUXTIN2,
                        (byte) SourceNCT67XXD.AUXTIN3
                    };

                    temperatureRegister = new ushort[]
                        {0x027, 0x073, 0x075, 0x077, 0x079, 0x07B, 0x150};
                    temperatureHalfRegister = new ushort[]
                        {0, 0x074, 0x076, 0x078, 0x07A, 0x07C, 0x151};
                    temperatureHalfBit = new[]
                        {-1, 7, 7, 7, 7, 7, 7};
                    temperatureSourceRegister = new ushort[]
                        {0x621, 0x100, 0x200, 0x300, 0x800, 0x900, 0x622};

                    alternateTemperatureRegister = new ushort?[]
                        {null, 0x491, 0x490, 0x492, 0x493, 0x494, 0x495};

                    break;
                case Chip.NCT610X:

                    Fans = new float?[3];
                    Controls = new float?[3];

                    fanRpmBaseRegister = 0x030;

                    // min value RPM value with 13-bit fan counter
                    minFanRPM = (int) (1.35e6 / 0x1FFF);

                    Voltages = new float?[9];
                    voltageRegisters = new ushort[]
                        {0x300, 0x301, 0x302, 0x303, 0x304, 0x305, 0x307, 0x308, 0x309};
                    voltageVBatRegister = 0x308;

                    Temperatures = new float?[4];
                    temperaturesSource = new[]
                    {
                        (byte) SourceNCT610X.PECI_0,
                        (byte) SourceNCT610X.SYSTIN,
                        (byte) SourceNCT610X.CPUTIN,
                        (byte) SourceNCT610X.AUXTIN
                    };

                    temperatureRegister = new ushort[]
                        {0x027, 0x018, 0x019, 0x01A};
                    temperatureHalfRegister = new ushort[]
                        {0, 0x01B, 0x11B, 0x21B};
                    temperatureHalfBit = new[]
                        {-1, 7, 7, 7};
                    temperatureSourceRegister = new ushort[]
                        {0x621, 0x100, 0x200, 0x300};

                    alternateTemperatureRegister = new ushort?[]
                        {null, 0x018, 0x019, 0x01A};

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
            if (!isNuvotonVendor)
                return;

            if (index < 0 || index >= Controls.Length)
                throw new ArgumentOutOfRangeException(nameof(index));

            if (!Ring0.WaitIsaBusMutex(10))
                return;

            if (value.HasValue)
            {
                SaveDefaultFanControl(index);

                // set manual mode
                WriteByte(FAN_CONTROL_MODE_REG[index], 0);

                // set output value
                WriteByte(FAN_PWM_COMMAND_REG[index], value.Value);
            }
            else
            {
                RestoreDefaultFanControl(index);
            }

            Ring0.ReleaseIsaBusMutex();
        }

        public Chip Chip { get; }

        public float?[] Voltages { get; } = new float?[0];

        public float?[] Temperatures { get; } = new float?[0];

        public float?[] Fans { get; } = new float?[0];

        public float?[] Controls { get; } = new float?[0];

        public void Update()
        {
            if (!isNuvotonVendor)
                return;

            if (!Ring0.WaitIsaBusMutex(10))
                return;

            DisableIOSpaceLock();

            for (var i = 0; i < Voltages.Length; i++)
            {
                var value = 0.008f * ReadByte(voltageRegisters[i]);
                var valid = value > 0;

                // check if battery voltage monitor is enabled
                if (valid && voltageRegisters[i] == voltageVBatRegister)
                    valid = (ReadByte(vBatMonitorControlRegister) & 0x01) > 0;

                Voltages[i] = valid ? value : (float?) null;
            }

            var temperatureSourceMask = 0;
            for (var i = temperatureRegister.Length - 1; i >= 0; i--)
            {
                var value = (sbyte) ReadByte(temperatureRegister[i]) << 1;
                if (temperatureHalfBit[i] > 0)
                    value |= (ReadByte(temperatureHalfRegister[i]) >>
                              temperatureHalfBit[i]) & 0x1;

                var source = ReadByte(temperatureSourceRegister[i]);
                temperatureSourceMask |= 1 << source;

                float? temperature = 0.5f * value;
                if (temperature > 125 || temperature < -55)
                    temperature = null;

                for (var j = 0; j < Temperatures.Length; j++)
                    if (temperaturesSource[j] == source)
                        Temperatures[j] = temperature;
            }

            for (var i = 0; i < alternateTemperatureRegister.Length; i++)
            {
                if (!alternateTemperatureRegister[i].HasValue)
                    continue;

                if ((temperatureSourceMask & (1 << temperaturesSource[i])) > 0)
                    continue;

                float? temperature = (sbyte)
                    ReadByte(alternateTemperatureRegister[i].Value);

                if (temperature > 125 || temperature < -55)
                    temperature = null;

                Temperatures[i] = temperature;
            }

            for (var i = 0; i < Fans.Length; i++)
            {
                var high = ReadByte((ushort) (fanRpmBaseRegister + (i << 1)));
                var low = ReadByte((ushort) (fanRpmBaseRegister + (i << 1) + 1));
                var value = (high << 8) | low;

                Fans[i] = value > minFanRPM ? value : 0;
            }

            for (var i = 0; i < Controls.Length; i++)
            {
                int value = ReadByte(FAN_PWM_OUT_REG[i]);
                Controls[i] = value / 2.55f;
            }

            Ring0.ReleaseIsaBusMutex();
        }

        private byte ReadByte(ushort address)
        {
            var bank = (byte) (address >> 8);
            var register = (byte) (address & 0xFF);
            Ring0.WriteIoPort(port + ADDRESS_REGISTER_OFFSET, BANK_SELECT_REGISTER);
            Ring0.WriteIoPort(port + DATA_REGISTER_OFFSET, bank);
            Ring0.WriteIoPort(port + ADDRESS_REGISTER_OFFSET, register);
            return Ring0.ReadIoPort(port + DATA_REGISTER_OFFSET);
        }

        private void WriteByte(ushort address, byte value)
        {
            var bank = (byte) (address >> 8);
            var register = (byte) (address & 0xFF);
            Ring0.WriteIoPort(port + ADDRESS_REGISTER_OFFSET, BANK_SELECT_REGISTER);
            Ring0.WriteIoPort(port + DATA_REGISTER_OFFSET, bank);
            Ring0.WriteIoPort(port + ADDRESS_REGISTER_OFFSET, register);
            Ring0.WriteIoPort(port + DATA_REGISTER_OFFSET, value);
        }

        private bool IsNuvotonVendor()
        {
            return ((ReadByte(VENDOR_ID_HIGH_REGISTER) << 8) |
                    ReadByte(VENDOR_ID_LOW_REGISTER)) == NUVOTON_VENDOR_ID;
        }


        private void SaveDefaultFanControl(int index)
        {
            if (!restoreDefaultFanControlRequired[index])
            {
                initialFanControlMode[index] = ReadByte(FAN_CONTROL_MODE_REG[index]);
                initialFanPwmCommand[index] = ReadByte(FAN_PWM_COMMAND_REG[index]);
                restoreDefaultFanControlRequired[index] = true;
            }
        }

        private void RestoreDefaultFanControl(int index)
        {
            if (restoreDefaultFanControlRequired[index])
            {
                WriteByte(FAN_CONTROL_MODE_REG[index], initialFanControlMode[index]);
                WriteByte(FAN_PWM_COMMAND_REG[index], initialFanPwmCommand[index]);
                restoreDefaultFanControlRequired[index] = false;
            }
        }

        private void DisableIOSpaceLock()
        {
            if (Chip != Chip.NCT6791D && Chip != Chip.NCT6796D && Chip != Chip.NCT6793D && Chip != Chip.NCT6795D)
                return;

            // the lock is disabled already if the vendor ID can be read
            if (IsNuvotonVendor())
                return;

            lpcPort.WinbondNuvotonFintekEnter();
            lpcPort.NuvotonDisableIOSpaceLock();
            lpcPort.WinbondNuvotonFintekExit();
        }

        private enum SourceNCT6771F : byte
        {
            SYSTIN = 1,
            CPUTIN = 2,
            AUXTIN = 3,
            SMBUSMASTER = 4,
            PECI_0 = 5,
            PECI_1 = 6,
            PECI_2 = 7,
            PECI_3 = 8,
            PECI_4 = 9,
            PECI_5 = 10,
            PECI_6 = 11,
            PECI_7 = 12,
            PCH_CHIP_CPU_MAX_TEMP = 13,
            PCH_CHIP_TEMP = 14,
            PCH_CPU_TEMP = 15,
            PCH_MCH_TEMP = 16,
            PCH_DIM0_TEMP = 17,
            PCH_DIM1_TEMP = 18,
            PCH_DIM2_TEMP = 19,
            PCH_DIM3_TEMP = 20
        }

        private enum SourceNCT6776F : byte
        {
            SYSTIN = 1,
            CPUTIN = 2,
            AUXTIN = 3,
            SMBUSMASTER_0 = 4,
            SMBUSMASTER_1 = 5,
            SMBUSMASTER_2 = 6,
            SMBUSMASTER_3 = 7,
            SMBUSMASTER_4 = 8,
            SMBUSMASTER_5 = 9,
            SMBUSMASTER_6 = 10,
            SMBUSMASTER_7 = 11,
            PECI_0 = 12,
            PECI_1 = 13,
            PCH_CHIP_CPU_MAX_TEMP = 14,
            PCH_CHIP_TEMP = 15,
            PCH_CPU_TEMP = 16,
            PCH_MCH_TEMP = 17,
            PCH_DIM0_TEMP = 18,
            PCH_DIM1_TEMP = 19,
            PCH_DIM2_TEMP = 20,
            PCH_DIM3_TEMP = 21,
            BYTE_TEMP = 22
        }

        private enum SourceNCT67XXD : byte
        {
            SYSTIN = 1,
            CPUTIN = 2,
            AUXTIN0 = 3,
            AUXTIN1 = 4,
            AUXTIN2 = 5,
            AUXTIN3 = 6,
            SMBUSMASTER_0 = 8,
            SMBUSMASTER_1 = 9,
            SMBUSMASTER_2 = 10,
            SMBUSMASTER_3 = 11,
            SMBUSMASTER_4 = 12,
            SMBUSMASTER_5 = 13,
            SMBUSMASTER_6 = 14,
            SMBUSMASTER_7 = 15,
            PECI_0 = 16,
            PECI_1 = 17,
            PCH_CHIP_CPU_MAX_TEMP = 18,
            PCH_CHIP_TEMP = 19,
            PCH_CPU_TEMP = 20,
            PCH_MCH_TEMP = 21,
            PCH_DIM0_TEMP = 22,
            PCH_DIM1_TEMP = 23,
            PCH_DIM2_TEMP = 24,
            PCH_DIM3_TEMP = 25,
            BYTE_TEMP = 26
        }

        private enum SourceNCT610X : byte
        {
            SYSTIN = 1,
            CPUTIN = 2,
            AUXTIN = 3,
            SMBUSMASTER_0 = 4,
            SMBUSMASTER_1 = 5,
            SMBUSMASTER_2 = 6,
            SMBUSMASTER_3 = 7,
            SMBUSMASTER_4 = 8,
            SMBUSMASTER_5 = 9,
            SMBUSMASTER_6 = 10,
            SMBUSMASTER_7 = 11,
            PECI_0 = 12,
            PECI_1 = 13,
            PCH_CHIP_CPU_MAX_TEMP = 14,
            PCH_CHIP_TEMP = 15,
            PCH_CPU_TEMP = 16,
            PCH_MCH_TEMP = 17,
            PCH_DIM0_TEMP = 18,
            PCH_DIM1_TEMP = 19,
            PCH_DIM2_TEMP = 20,
            PCH_DIM3_TEMP = 21,
            BYTE_TEMP = 22
        }
    }
}