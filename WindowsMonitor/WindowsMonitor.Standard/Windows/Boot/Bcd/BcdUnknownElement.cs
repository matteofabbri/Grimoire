using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdUnknownElement
    {
		public uint ActualType { get; private set; }
		public string ObjectId { get; private set; }
		public string StoreFilePath { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<BcdUnknownElement> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdUnknownElement> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdUnknownElement> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdUnknownElement");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdUnknownElement
                {
                     ActualType = (uint) (managementObject.Properties["ActualType"]?.Value ?? default(uint)),
		 ObjectId = (string) (managementObject.Properties["ObjectId"]?.Value ?? default(string)),
		 StoreFilePath = (string) (managementObject.Properties["StoreFilePath"]?.Value ?? default(string)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}