/*
 
  This Source Code Form is subject to the terms of the Mozilla Public
  License, v. 2.0. If a copy of the MPL was not distributed with this
  file, You can obtain one at http://mozilla.org/MPL/2.0/.
 
  Copyright (C) 2011-2013 Michael Möller <mmoeller@openhardwaremonitor.org>
  Copyright (C) 2011 Roland Reinl <roland-reinl@gmx.de>
	
*/

namespace HardwareProviders.HDD
{
    /// <summary>
    ///     Localization class for SMART attribute names.
    /// </summary>
    internal static class SmartNames
    {
        public const string AirflowTemperature = "Airflow Temperature";

        public const string Temperature = "Temperature";

        public const string RetiredBlockCount = "Retired Block Count";

        public const string ProgramFailCount = "Program Fail Count";

        public const string EraseFailCount = "Erase Fail Count";

        public const string UnexpectedPowerLossCount = "Unexpected Power Loss Count";

        public const string WearRangeDelta = "Wear Range Delta";

        public const string AlternativeProgramFailCount = "Alternative Program Fail Count";

        public const string AlternativeEraseFailCount = "Alternative Erase Fail Count";

        public const string UnrecoverableEcc = "Unrecoverable ECC";

        public const string ReallocationEventCount = "Reallocation Event Count";

        public const string RemainingLife = "Remaining Life";

        public const string AvailableReservedSpace = "Available Reserved Space";

        public const string CalibrationRetryCount = "Calibration Retry Count";

        public const string CommandTimeout = "Command Timeout";

        public const string CurrentPendingSectorCount = "Current Pending Sector Count";

        public const string DataAddressMarkErrors = "Data Address Mark errors";

        public const string DiskShift = "Disk Shift";

        public const string DriveTemperature = "Drive Temperature";

        public const string EmergencyRetractCycleCount = "Emergency Retract Cycle Count";

        public const string EndToEndError = "End-to-End error";

        public const string EnduranceRemaining = "Endurance Remaining";

        public const string FlyingHeight = "Flying Height";

        public const string FreeFallProtection = "Free Fall Protection";

        public const string GmrHeadAmplitude = "GMR Head Amplitude";

        public const string GSenseErrorRate = "G-sense Error Rate";

        public const string HardwareEccRecovered = "Hardware ECC Recovered";

        public const string HeadFlyingHours = "Head Flying Hours";

        public const string HeadStability = "Head Stability";

        public const string HighFlyWrites = "High Fly Writes";

        public const string InducedOpVibrationDetection = "Induced Op-Vibration Detection";

        public const string LoadedHours = "Loaded Hours";

        public const string LoadFriction = "Load Friction";

        public const string LoadInTime = "Load 'In'-time";

        public const string LoadUnloadCycleCount = "Load/Unload Cycle Count";

        public const string LoadUnloadCycleCountFujitsu = "Load/Unload Cycle Count (Fujitus)";

        public const string LoadUnloadRetryCount = "Load/Unload Retry Count";

        public const string MediaWearoutIndicator = "Media Wearout Indicator";

        public const string MultiZoneErrorRate = "Multi-Zone Error Rate";

        public const string OfflineSeekPerformance = "Offline Seek Performance";

        public const string PowerCycleCount = "Power Cycle Count";

        public const string PowerOffRetractCycle = "Power-Off Retract Cycle";

        public const string PowerOnHours = "Power-On Hours (POH)";

        public const string ReadChannelMargin = "Read Channel Margin";

        public const string ReadErrorRate = "Read Error Rate";

        public const string ReadErrorRetryRate = "Read Error Retry Rate";

        public const string ReallocatedSectorsCount = "Reallocated Sectors Count";

        public const string ReportedUncorrectableErrors = "Reported Uncorrectable Errors";

        public const string RunOutCancel = "Run Out Cancel";

        public const string SataDownshiftErrorCount = "SATA Downshift Error Count";

        public const string SeekErrorRate = "Seek Error Rate";

        public const string SeekTimePerformance = "Seek Time Performance";

        public const string ShockDuringWrite = "Shock During Write";

        public const string SoftEccCorrection = "Soft ECC Correction";

        public const string SoftReadErrorRate = "Soft Read Error Rate";

        public const string SpinBuzz = "Spin Buzz";

        public const string SpinHighCurrent = "Spin High Current";

        public const string SpinRetryCount = "Spin Retry Count";

        public const string SpinUpTime = "Spin-Up Time";

        public const string StartStopCount = "Start/Stop Count";

        public const string TaCounterDetected = "TA Counter Detected";

        public const string TemperatureDifferenceFrom100 = "Temperature Difference from 100";

        public const string ThermalAsperityRate = "Thermal Asperity Rate (TAR)";

        public const string ThroughputPerformance = "Throughput Performance";

        public const string TorqueAmplificationCount = "Torque Amplification Count";

        public const string TotalLbasRead = "Total LBAs Read";

        public const string TotalLbasWritten = "Total LBAs Written";

        public const string TransferErrorRate = "Transfer Error Rate";

        public const string UltraDmaCrcErrorCount = "UltraDMA CRC Error Count";

        public const string UncorrectableSectorCount = "Uncorrectable Sector Count";

        public const string Unknown = "Unknown";

        public const string VibrationDuringWrite = "Vibration During Write";

        public const string WriteErrorRate = "Write Error Rate";

        public const string RecalibrationRetries = "Recalibration Retries";

        public const string LoadCycleCount = "Load Cycle Count";

        public const string AlternativeGSenseErrorRate = "Alternative G-Sense Error Rate";

        public const string InitialBadBlockCount = "Initial Bad Block Count";

        public const string ProgramFailure = "Program Failure";

        public const string EraseFailure = "Erase Failure";

        public const string ReadFailure = "Read Failure";

        public const string SectorsRead = "Sectors Read";

        public const string SectorsWritten = "Sectors Written";

        public const string ReadCommands = "Read Commands";

        public const string WriteCommands = "Write Commands";

        public const string BitErrors = "Bit Errors";

        public const string CorrectedErrors = "Corrected Errors";

        public const string BadBlockFullFlag = "Bad Block Full Flag";

        public const string MaxCellCycles = "Max Cell Cycles";

        public const string MinErase = "Min Erase";

        public const string MaxErase = "Max Erase";

        public const string AverageEraseCount = "Average Erase Count";

        public const string UnknownUnique = "Unknown Unique";

        public const string SataErrorCountCrc = "SATA Error Count CRC";

        public const string SataErrorCountHandshake = "SATA Error Count Handshake";

        public const string UnsafeShutdownCount = "Unsafe Shutdown Count";

        public const string HostWrites = "Host Writes";

        public const string HostReads = "Host Reads";

        public const string MediaWearOutIndicator = "Media Wear Out Indicator";

        public const string ProgramFailCountChip = "Program Fail Count (Chip)";

        public const string EraseFailCountChip = "Erase Fail Count (Chip)";

        public const string WearLevelingCount = "Wear Leveling Count";

        public const string UsedReservedBlockCountChip = "Used Reserved Block Count (Chip)";

        public const string UsedReservedBlockCountTotal = "Used Reserved Block Count (Total)";

        public const string ProgramFailCountTotal = "Program Fail Count (Total)";

        public const string EraseFailCountTotal = "Erase Fail Count (Total)";

        public const string RuntimeBadBlockTotal = "Runtime Bad Block Total";

        public const string UncorrectableErrorCount = "Uncorrectable Error Count";

        public const string TemperatureExceedCount = "Temperature Exceed Count";

        public const string ECCRate = "ECC Rate";

        public const string OffLineUncorrectableErrorCount = "Off-Line Uncorrectable Error Count";

        public const string CRCErrorCount = "CRC Error Count";

        public const string SupercapStatus = "Supercap Status";

        public const string ExceptionModeStatus = "Exception Mode Status";

        public const string ControllerWritesToNAND = "Controller Writes to NAND";

        public const string HostWritesToController = "Host Writes to Controller";

        public const string RawReadErrorRate = "Raw Read Error Rate";

        public const string NewFailingBlockCount = "New Failing Block Count";

        public const string Non4kAlignedAccess = "Non-4k Aligned Access";

        public const string FactoryBadBlockCount = "Factory Bad Block Count";

        public const string PowerRecoveryCount = "Power Recovery Count";
    }
}