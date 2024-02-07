using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class Trustee
    {
		public string Domain { get; private set; }
		public string Name { get; private set; }
		public byte[] Sid { get; private set; }
		public uint SidLength { get; private set; }
		public string SidString { get; private set; }
		public ulong TimeCreated { get; private set; }

        public static IEnumerable<Trustee> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Trustee> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Trustee> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_Trustee");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Trustee
                {
                     Domain = (string) (managementObject.Properties["Domain"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Sid = (byte[]) (managementObject.Properties["SID"]?.Value ?? new byte[0]),
		 SidLength = (uint) (managementObject.Properties["SidLength"]?.Value ?? default(uint)),
		 SidString = (string) (managementObject.Properties["SIDString"]?.Value),
		 TimeCreated = (ulong) (managementObject.Properties["TIME_CREATED"]?.Value ?? default(ulong))
                };
        }
    }
}