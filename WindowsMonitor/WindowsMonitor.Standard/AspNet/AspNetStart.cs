using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.AspNet
{
    /// <summary>
    /// </summary>
    public sealed class AspNetStart
    {
		public ulong ConnId { get; private set; }
		public dynamic ContextId { get; private set; }
		public uint Flags { get; private set; }
		public uint Level { get; private set; }
		public string Method { get; private set; }
		public string Path { get; private set; }
		public string QueryString { get; private set; }

        public static IEnumerable<AspNetStart> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<AspNetStart> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<AspNetStart> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM AspNetStart");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new AspNetStart
                {
                     ConnId = (ulong) (managementObject.Properties["ConnID"]?.Value ?? default(ulong)),
		 ContextId = (dynamic) (managementObject.Properties["ContextId"]?.Value ?? default(dynamic)),
		 Flags = (uint) (managementObject.Properties["Flags"]?.Value ?? default(uint)),
		 Level = (uint) (managementObject.Properties["Level"]?.Value ?? default(uint)),
		 Method = (string) (managementObject.Properties["Method"]?.Value ?? default(string)),
		 Path = (string) (managementObject.Properties["Path"]?.Value ?? default(string)),
		 QueryString = (string) (managementObject.Properties["QueryString"]?.Value ?? default(string))
                };
        }
    }
}