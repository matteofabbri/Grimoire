using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware
{
    /// <summary>
    /// </summary>
    public sealed class DeviceConnection
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public uint NegotiatedDataWidth { get; private set; }
		public ulong NegotiatedSpeed { get; private set; }

        public static IEnumerable<DeviceConnection> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<DeviceConnection> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<DeviceConnection> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_DeviceConnection");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new DeviceConnection
                {
                     Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string)),
		 NegotiatedDataWidth = (uint) (managementObject.Properties["NegotiatedDataWidth"]?.Value ?? default(uint)),
		 NegotiatedSpeed = (ulong) (managementObject.Properties["NegotiatedSpeed"]?.Value ?? default(ulong))
                };
        }
    }
}