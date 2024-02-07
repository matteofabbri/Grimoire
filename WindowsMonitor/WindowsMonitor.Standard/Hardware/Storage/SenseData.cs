using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.MSStorageDriver
{
    /// <summary>
    /// </summary>
    public sealed class SenseData
    {
		public byte AdditionalSenseCode { get; private set; }
		public byte AdditionalSenseCodeQualifier { get; private set; }
		public byte AdditionalSenseLength { get; private set; }
		public byte[] CommandSpecificInformation { get; private set; }
		public bool EndOfMedia { get; private set; }
		public byte ErrorCode { get; private set; }
		public byte FieldReplaceableUnitCode { get; private set; }
		public bool FileMark { get; private set; }
		public bool IncorrectLength { get; private set; }
		public byte[] Information { get; private set; }
		public bool Reserved { get; private set; }
		public byte SegmentNumber { get; private set; }
		public byte SenseKey { get; private set; }
		public byte[] SenseKeySpecific { get; private set; }
		public bool Valid { get; private set; }

        public static IEnumerable<SenseData> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\wmi"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<SenseData> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SenseData> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSStorageDriver_SenseData");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SenseData
                {
                     AdditionalSenseCode = (byte) (managementObject.Properties["additionalSenseCode"]?.Value ?? default(byte)),
		 AdditionalSenseCodeQualifier = (byte) (managementObject.Properties["additionalSenseCodeQualifier"]?.Value ?? default(byte)),
		 AdditionalSenseLength = (byte) (managementObject.Properties["additionalSenseLength"]?.Value ?? default(byte)),
		 CommandSpecificInformation = (byte[]) (managementObject.Properties["commandSpecificInformation"]?.Value ?? new byte[0]),
		 EndOfMedia = (bool) (managementObject.Properties["endOfMedia"]?.Value ?? default(bool)),
		 ErrorCode = (byte) (managementObject.Properties["errorCode"]?.Value ?? default(byte)),
		 FieldReplaceableUnitCode = (byte) (managementObject.Properties["fieldReplaceableUnitCode"]?.Value ?? default(byte)),
		 FileMark = (bool) (managementObject.Properties["fileMark"]?.Value ?? default(bool)),
		 IncorrectLength = (bool) (managementObject.Properties["incorrectLength"]?.Value ?? default(bool)),
		 Information = (byte[]) (managementObject.Properties["information"]?.Value ?? new byte[0]),
		 Reserved = (bool) (managementObject.Properties["reserved"]?.Value ?? default(bool)),
		 SegmentNumber = (byte) (managementObject.Properties["segmentNumber"]?.Value ?? default(byte)),
		 SenseKey = (byte) (managementObject.Properties["senseKey"]?.Value ?? default(byte)),
		 SenseKeySpecific = (byte[]) (managementObject.Properties["senseKeySpecific"]?.Value ?? new byte[0]),
		 Valid = (bool) (managementObject.Properties["valid"]?.Value ?? default(bool))
                };
        }
    }
}