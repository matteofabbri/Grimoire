using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class SmSvcHost3000
    {
		public string Caption { get; private set; }
		public uint ConnectionsAcceptedovernetpipe { get; private set; }
		public uint ConnectionsAcceptedovernettcp { get; private set; }
		public uint ConnectionsDispatchedovernetpipe { get; private set; }
		public uint ConnectionsDispatchedovernettcp { get; private set; }
		public string Description { get; private set; }
		public uint DispatchFailuresovernetpipe { get; private set; }
		public uint DispatchFailuresovernettcp { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint ProtocolFailuresovernetpipe { get; private set; }
		public uint ProtocolFailuresovernettcp { get; private set; }
		public uint RegistrationsActivefornetpipe { get; private set; }
		public uint RegistrationsActivefornettcp { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint UrisRegisteredfornetpipe { get; private set; }
		public uint UrisRegisteredfornettcp { get; private set; }
		public uint UrisUnregisteredfornetpipe { get; private set; }
		public uint UrisUnregisteredfornettcp { get; private set; }

        public static IEnumerable<SmSvcHost3000> Retrieve(string remote, string username, string password)
        {
            var options = new ConnectionOptions
            {
                Impersonation = ImpersonationLevel.Impersonate,
                Username = username,
                Password = password
            };

            var managementScope = new ManagementScope(new ManagementPath($"\\\\{remote}\\root\\cimv2"), options);
            managementScope.Connect();

            return Retrieve(managementScope);
        }

        public static IEnumerable<SmSvcHost3000> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SmSvcHost3000> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_SMSvcHost3000_SMSvcHost3000");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SmSvcHost3000
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ConnectionsAcceptedovernetpipe = (uint) (managementObject.Properties["ConnectionsAcceptedovernetpipe"]?.Value ?? default(uint)),
		 ConnectionsAcceptedovernettcp = (uint) (managementObject.Properties["ConnectionsAcceptedovernettcp"]?.Value ?? default(uint)),
		 ConnectionsDispatchedovernetpipe = (uint) (managementObject.Properties["ConnectionsDispatchedovernetpipe"]?.Value ?? default(uint)),
		 ConnectionsDispatchedovernettcp = (uint) (managementObject.Properties["ConnectionsDispatchedovernettcp"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 DispatchFailuresovernetpipe = (uint) (managementObject.Properties["DispatchFailuresovernetpipe"]?.Value ?? default(uint)),
		 DispatchFailuresovernettcp = (uint) (managementObject.Properties["DispatchFailuresovernettcp"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 ProtocolFailuresovernetpipe = (uint) (managementObject.Properties["ProtocolFailuresovernetpipe"]?.Value ?? default(uint)),
		 ProtocolFailuresovernettcp = (uint) (managementObject.Properties["ProtocolFailuresovernettcp"]?.Value ?? default(uint)),
		 RegistrationsActivefornetpipe = (uint) (managementObject.Properties["RegistrationsActivefornetpipe"]?.Value ?? default(uint)),
		 RegistrationsActivefornettcp = (uint) (managementObject.Properties["RegistrationsActivefornettcp"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 UrisRegisteredfornetpipe = (uint) (managementObject.Properties["UrisRegisteredfornetpipe"]?.Value ?? default(uint)),
		 UrisRegisteredfornettcp = (uint) (managementObject.Properties["UrisRegisteredfornettcp"]?.Value ?? default(uint)),
		 UrisUnregisteredfornetpipe = (uint) (managementObject.Properties["UrisUnregisteredfornetpipe"]?.Value ?? default(uint)),
		 UrisUnregisteredfornettcp = (uint) (managementObject.Properties["UrisUnregisteredfornettcp"]?.Value ?? default(uint))
                };
        }
    }
}