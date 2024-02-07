using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspNetPageRaisePostbackEnter
    {
		public ulong ConnId { get; private set; }
		public dynamic ContextId { get; private set; }
		public uint Flags { get; private set; }
		public uint Level { get; private set; }

        public static IEnumerable<AspNetPageRaisePostbackEnter> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspNetPageRaisePostbackEnter> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspNetPageRaisePostbackEnter> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AspNetPageRaisePostbackEnter");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspNetPageRaisePostbackEnter
                {
                     ConnId = (ulong) (managementObject.Properties["ConnID"]?.Value ?? default(ulong)),
		 ContextId = (dynamic) (managementObject.Properties["ContextId"]?.Value ?? default(dynamic)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Level = (uint) (managementObject.Properties["Level"]?.Value ?? default(uint))
                };
        }
    }
}