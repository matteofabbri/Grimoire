using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Network
{
    /// <summary>
    /// </summary>
    public sealed class Ip4PersistedRouteTable
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public string Destination { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string Mask { get; private set; }
		public int Metric1 { get; private set; }
		public string Name { get; private set; }
		public string NextHop { get; private set; }
		public string Status { get; private set; }

        public static IEnumerable<Ip4PersistedRouteTable> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Ip4PersistedRouteTable> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Ip4PersistedRouteTable> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_IP4PersistedRouteTable");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Ip4PersistedRouteTable
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Destination = (string) (managementObject.Properties["Destination"]?.Value),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 Mask = (string) (managementObject.Properties["Mask"]?.Value),
		 Metric1 = (int) (managementObject.Properties["Metric1"]?.Value ?? default(int)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NextHop = (string) (managementObject.Properties["NextHop"]?.Value),
		 Status = (string) (managementObject.Properties["Status"]?.Value)
                };
        }
    }
}