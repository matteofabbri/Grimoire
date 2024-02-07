using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Boot.Bcd
{
    /// <summary>
    /// </summary>
    public sealed class BcdObjectElement
    {
		public string Id { get; private set; }
		public string ObjectId { get; private set; }
		public string StoreFilePath { get; private set; }
		public uint Type { get; private set; }

        public static IEnumerable<BcdObjectElement> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BcdObjectElement> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BcdObjectElement> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM BcdObjectElement");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BcdObjectElement
                {
                     Id = (string) (managementObject.Properties["Id"]?.Value ?? default(string)),
		 ObjectId = (string) (managementObject.Properties["ObjectId"]?.Value ?? default(string)),
		 StoreFilePath = (string) (managementObject.Properties["StoreFilePath"]?.Value ?? default(string)),
		 Type = (uint) (managementObject.Properties["Type"]?.Value ?? default(uint))
                };
        }
    }
}