using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspNetStartHandler
    {
		public ulong ConnId { get; private set; }
		public dynamic ContextId { get; private set; }
		public string EventName { get; private set; }
		public uint Flags { get; private set; }
		public string HandlerName { get; private set; }
		public uint Level { get; private set; }

        public static IEnumerable<AspNetStartHandler> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspNetStartHandler> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspNetStartHandler> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AspNetStartHandler");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspNetStartHandler
                {
                     ConnId = (ulong) (managementObject.Properties["ConnID"]?.Value ?? default(ulong)),
		 ContextId = (dynamic) (managementObject.Properties["ContextId"]?.Value ?? default(dynamic)),
		 EventName = (string) (managementObject.Properties["EventName"]?.Value ?? default(string)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 HandlerName = (string) (managementObject.Properties["HandlerName"]?.Value ?? default(string)),
		 Level = (uint) (managementObject.Properties["Level"]?.Value ?? default(uint))
                };
        }
    }
}