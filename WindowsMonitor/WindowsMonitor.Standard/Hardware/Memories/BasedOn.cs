using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Memories
{
    /// <summary>
    /// </summary>
    public sealed class BasedOn
    {
		public string Antecedent { get; private set; }
		public string Dependent { get; private set; }
		public ulong EndingAddress { get; private set; }
		public ulong StartingAddress { get; private set; }

        public static IEnumerable<BasedOn> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<BasedOn> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<BasedOn> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_BasedOn");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new BasedOn
                {
                     Antecedent = (string) (managementObject.Properties["Antecedent"]?.Value ?? default(string)),
		 Dependent = (string) (managementObject.Properties["Dependent"]?.Value ?? default(string)),
		 EndingAddress = (ulong) (managementObject.Properties["EndingAddress"]?.Value ?? default(ulong)),
		 StartingAddress = (ulong) (managementObject.Properties["StartingAddress"]?.Value ?? default(ulong))
                };
        }
    }
}