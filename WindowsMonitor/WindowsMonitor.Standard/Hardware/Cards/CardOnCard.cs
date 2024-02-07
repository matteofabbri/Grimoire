using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Cards
{
    /// <summary>
    /// </summary>
    public sealed class CardOnCard
    {
		public string GroupComponent { get; private set; }
		public string LocationWithinContainer { get; private set; }
		public string MountOrSlotDescription { get; private set; }
		public string PartComponent { get; private set; }

        public static IEnumerable<CardOnCard> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<CardOnCard> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<CardOnCard> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_CardOnCard");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new CardOnCard
                {
                     GroupComponent = (string) (managementObject.Properties["GroupComponent"]?.Value ?? default(string)),
		 LocationWithinContainer = (string) (managementObject.Properties["LocationWithinContainer"]?.Value),
		 MountOrSlotDescription = (string) (managementObject.Properties["MountOrSlotDescription"]?.Value),
		 PartComponent = (string) (managementObject.Properties["PartComponent"]?.Value ?? default(string))
                };
        }
    }
}