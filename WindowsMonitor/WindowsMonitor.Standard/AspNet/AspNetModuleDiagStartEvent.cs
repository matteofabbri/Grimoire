using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspNetModuleDiagStartEvent
    {
		public dynamic ContextId { get; private set; }
		public uint Flags { get; private set; }
		public uint Level { get; private set; }
		public string TraceWriteMsg { get; private set; }
		public string Uri { get; private set; }

        public static IEnumerable<AspNetModuleDiagStartEvent> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspNetModuleDiagStartEvent> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspNetModuleDiagStartEvent> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AspNetModuleDiagStartEvent");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspNetModuleDiagStartEvent
                {
                     ContextId = (dynamic) (managementObject.Properties["ContextId"]?.Value ?? default(dynamic)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Level = (uint) (managementObject.Properties["Level"]?.Value ?? default(uint)),
		 TraceWriteMsg = (string) (managementObject.Properties["TraceWriteMsg"]?.Value ?? default(string)),
		 Uri = (string) (managementObject.Properties["Uri"]?.Value ?? default(string))
                };
        }
    }
}