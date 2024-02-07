using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted
{
    /// <summary>
    /// </summary>
    public sealed class TcpIpPerformanceDiagnostics
    {
		public string Caption { get; private set; }
		public uint Deniedconnectorsendrequestsinlowpowermode { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint Pv4NbLsindicatedwithlowresourceflag { get; private set; }
		public uint Pv4NbLsindicatedwithoutprevalidation { get; private set; }
		public uint Pv4NbLsPersecindicatedwithlowresourceflag { get; private set; }
		public uint Pv4NbLsPersecindicatedwithoutprevalidation { get; private set; }
		public uint Pv4NbLsPersectreatedasnonprevalidated { get; private set; }
		public uint Pv4NbLstreatedasnonprevalidated { get; private set; }
		public uint Pv4OutboundNbLsnotprocessedviafastpath { get; private set; }
		public uint Pv4OutboundNbLsPersecnotprocessedviafastpath { get; private set; }
		public uint Pv6NbLsindicatedwithlowresourceflag { get; private set; }
		public uint Pv6NbLsindicatedwithoutprevalidation { get; private set; }
		public uint Pv6NbLsPersecindicatedwithlowresourceflag { get; private set; }
		public uint Pv6NbLsPersecindicatedwithoutprevalidation { get; private set; }
		public uint Pv6NbLsPersectreatedasnonprevalidated { get; private set; }
		public uint Pv6NbLstreatedasnonprevalidated { get; private set; }
		public uint Pv6OutboundNbLsnotprocessedviafastpath { get; private set; }
		public uint Pv6OutboundNbLsPersecnotprocessedviafastpath { get; private set; }
		public string Name { get; private set; }
		public uint TcPconnectrequestsfallenoffloopbackfastpath { get; private set; }
		public uint TcPconnectrequestsPersecfallenoffloopbackfastpath { get; private set; }
		public uint TcPinboundsegmentsnotprocessedviafastpath { get; private set; }
		public uint TcPinboundsegmentsPersecnotprocessedviafastpath { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<TcpIpPerformanceDiagnostics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<TcpIpPerformanceDiagnostics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<TcpIpPerformanceDiagnostics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_TCPIPCounters_TCPIPPerformanceDiagnostics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new TcpIpPerformanceDiagnostics
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Deniedconnectorsendrequestsinlowpowermode = (uint) (managementObject.Properties["Deniedconnectorsendrequestsinlowpowermode"]?.Value ?? default(uint)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Pv4NbLsindicatedwithlowresourceflag = (uint) (managementObject.Properties["IPv4NBLsindicatedwithlowresourceflag"]?.Value ?? default(uint)),
		 Pv4NbLsindicatedwithoutprevalidation = (uint) (managementObject.Properties["IPv4NBLsindicatedwithoutprevalidation"]?.Value ?? default(uint)),
		 Pv4NbLsPersecindicatedwithlowresourceflag = (uint) (managementObject.Properties["IPv4NBLsPersecindicatedwithlowresourceflag"]?.Value ?? default(uint)),
		 Pv4NbLsPersecindicatedwithoutprevalidation = (uint) (managementObject.Properties["IPv4NBLsPersecindicatedwithoutprevalidation"]?.Value ?? default(uint)),
		 Pv4NbLsPersectreatedasnonprevalidated = (uint) (managementObject.Properties["IPv4NBLsPersectreatedasnonprevalidated"]?.Value ?? default(uint)),
		 Pv4NbLstreatedasnonprevalidated = (uint) (managementObject.Properties["IPv4NBLstreatedasnonprevalidated"]?.Value ?? default(uint)),
		 Pv4OutboundNbLsnotprocessedviafastpath = (uint) (managementObject.Properties["IPv4outboundNBLsnotprocessedviafastpath"]?.Value ?? default(uint)),
		 Pv4OutboundNbLsPersecnotprocessedviafastpath = (uint) (managementObject.Properties["IPv4outboundNBLsPersecnotprocessedviafastpath"]?.Value ?? default(uint)),
		 Pv6NbLsindicatedwithlowresourceflag = (uint) (managementObject.Properties["IPv6NBLsindicatedwithlowresourceflag"]?.Value ?? default(uint)),
		 Pv6NbLsindicatedwithoutprevalidation = (uint) (managementObject.Properties["IPv6NBLsindicatedwithoutprevalidation"]?.Value ?? default(uint)),
		 Pv6NbLsPersecindicatedwithlowresourceflag = (uint) (managementObject.Properties["IPv6NBLsPersecindicatedwithlowresourceflag"]?.Value ?? default(uint)),
		 Pv6NbLsPersecindicatedwithoutprevalidation = (uint) (managementObject.Properties["IPv6NBLsPersecindicatedwithoutprevalidation"]?.Value ?? default(uint)),
		 Pv6NbLsPersectreatedasnonprevalidated = (uint) (managementObject.Properties["IPv6NBLsPersectreatedasnonprevalidated"]?.Value ?? default(uint)),
		 Pv6NbLstreatedasnonprevalidated = (uint) (managementObject.Properties["IPv6NBLstreatedasnonprevalidated"]?.Value ?? default(uint)),
		 Pv6OutboundNbLsnotprocessedviafastpath = (uint) (managementObject.Properties["IPv6outboundNBLsnotprocessedviafastpath"]?.Value ?? default(uint)),
		 Pv6OutboundNbLsPersecnotprocessedviafastpath = (uint) (managementObject.Properties["IPv6outboundNBLsPersecnotprocessedviafastpath"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 TcPconnectrequestsfallenoffloopbackfastpath = (uint) (managementObject.Properties["TCPconnectrequestsfallenoffloopbackfastpath"]?.Value ?? default(uint)),
		 TcPconnectrequestsPersecfallenoffloopbackfastpath = (uint) (managementObject.Properties["TCPconnectrequestsPersecfallenoffloopbackfastpath"]?.Value ?? default(uint)),
		 TcPinboundsegmentsnotprocessedviafastpath = (uint) (managementObject.Properties["TCPinboundsegmentsnotprocessedviafastpath"]?.Value ?? default(uint)),
		 TcPinboundsegmentsPersecnotprocessedviafastpath = (uint) (managementObject.Properties["TCPinboundsegmentsPersecnotprocessedviafastpath"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}