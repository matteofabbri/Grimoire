using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspNetWebEventDeliverStart
    {
		public ulong ConnId { get; private set; }
		public dynamic ContextId { get; private set; }
		public string EventGroupName { get; private set; }
		public uint Flags { get; private set; }
		public uint Level { get; private set; }
		public string ProviderName { get; private set; }
		public string RuleName { get; private set; }

        public static IEnumerable<AspNetWebEventDeliverStart> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspNetWebEventDeliverStart> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspNetWebEventDeliverStart> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AspNetWebEventDeliverStart");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspNetWebEventDeliverStart
                {
                     ConnId = (ulong) (managementObject.Properties["ConnID"]?.Value ?? default(ulong)),
		 ContextId = (dynamic) (managementObject.Properties["ContextId"]?.Value ?? default(dynamic)),
		 EventGroupName = (string) (managementObject.Properties["EventGroupName"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Level = (uint) (managementObject.Properties["Level"]?.Value ?? default(uint)),
		 ProviderName = (string) (managementObject.Properties["ProviderName"]?.Value ?? default(string)),
		 RuleName = (string) (managementObject.Properties["RuleName"]?.Value ?? default(string))
                };
        }
    }
}