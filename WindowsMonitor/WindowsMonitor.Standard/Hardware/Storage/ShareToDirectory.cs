using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ShareToDirectory
    {
		public string Share { get; private set; }
		public string SharedElement { get; private set; }

        public static IEnumerable<ShareToDirectory> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ShareToDirectory> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ShareToDirectory> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ShareToDirectory");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
            {
                var retrieve = new ShareToDirectory();
                retrieve.Share = (string) (managementObject.Properties["Share"]?.Value ?? default(string));
                retrieve.SharedElement = (string) (managementObject.Properties["SharedElement"]?.Value ?? default(string));
                yield return retrieve;
            }
        }
    }
}