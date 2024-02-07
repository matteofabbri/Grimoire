using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class SupportAccess
    {
		public string CommunicationInfo { get; private set; }
		public ushort CommunicationMode { get; private set; }
		public string Description { get; private set; }
		public string Locale { get; private set; }
		public string SupportAccessId { get; private set; }

        public static IEnumerable<SupportAccess> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<SupportAccess> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<SupportAccess> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_SupportAccess");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new SupportAccess
                {
                     CommunicationInfo = (string) (managementObject.Properties["CommunicationInfo"]?.Value),
		 CommunicationMode = (ushort) (managementObject.Properties["CommunicationMode"]?.Value ?? default(ushort)),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Locale = (string) (managementObject.Properties["Locale"]?.Value),
		 SupportAccessId = (string) (managementObject.Properties["SupportAccessId"]?.Value)
                };
        }
    }
}