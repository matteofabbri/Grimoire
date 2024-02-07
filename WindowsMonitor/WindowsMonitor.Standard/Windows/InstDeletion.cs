using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class InstDeletion
    {
		public string[] CorrelatedIndications { get; private set; }
		public string IndicationFilterName { get; private set; }
		public string IndicationIdentifier { get; private set; }
		public DateTime IndicationTime { get; private set; }
		public string OtherSeverity { get; private set; }
		public ushort PerceivedSeverity { get; private set; }
		public string SequenceContext { get; private set; }
		public long SequenceNumber { get; private set; }
		public dynamic SourceInstance { get; private set; }
		public string SourceInstanceHost { get; private set; }
		public string SourceInstanceModelPath { get; private set; }

        public static IEnumerable<InstDeletion> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<InstDeletion> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<InstDeletion> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_InstDeletion");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new InstDeletion
                {
                     CorrelatedIndications = (string[]) (managementObject.Properties["CorrelatedIndications"]?.Value ?? new string[0]),
		 IndicationFilterName = (string) (managementObject.Properties["IndicationFilterName"]?.Value),
		 IndicationIdentifier = (string) (managementObject.Properties["IndicationIdentifier"]?.Value),
		 IndicationTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["IndicationTime"]?.Value as string ?? "00010102000000.000000+060"),
		 OtherSeverity = (string) (managementObject.Properties["OtherSeverity"]?.Value),
		 PerceivedSeverity = (ushort) (managementObject.Properties["PerceivedSeverity"]?.Value ?? default(ushort)),
		 SequenceContext = (string) (managementObject.Properties["SequenceContext"]?.Value),
		 SequenceNumber = (long) (managementObject.Properties["SequenceNumber"]?.Value ?? default(long)),
		 SourceInstance = (dynamic) (managementObject.Properties["SourceInstance"]?.Value ?? default(dynamic)),
		 SourceInstanceHost = (string) (managementObject.Properties["SourceInstanceHost"]?.Value),
		 SourceInstanceModelPath = (string) (managementObject.Properties["SourceInstanceModelPath"]?.Value)
                };
        }
    }
}