using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class ProcessStartup
    {
		public uint CreateFlags { get; private set; }
		public string[] EnvironmentVariables { get; private set; }
		public ushort ErrorMode { get; private set; }
		public uint FillAttribute { get; private set; }
		public uint PriorityClass { get; private set; }
		public ushort ShowWindow { get; private set; }
		public string Title { get; private set; }
		public string WinstationDesktop { get; private set; }
		public uint X { get; private set; }
		public uint XCountChars { get; private set; }
		public uint XSize { get; private set; }
		public uint Y { get; private set; }
		public uint YCountChars { get; private set; }
		public uint YSize { get; private set; }

        public static IEnumerable<ProcessStartup> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ProcessStartup> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ProcessStartup> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ProcessStartup");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ProcessStartup
                {
                     CreateFlags = (uint) (managementObject.Properties["CreateFlags"]?.Value ?? default(uint)),
		 EnvironmentVariables = (string[]) (managementObject.Properties["EnvironmentVariables"]?.Value ?? new string[0]),
		 ErrorMode = (ushort) (managementObject.Properties["ErrorMode"]?.Value ?? default(ushort)),
		 FillAttribute = (uint) (managementObject.Properties["FillAttribute"]?.Value ?? default(uint)),
		 PriorityClass = (uint) (managementObject.Properties["PriorityClass"]?.Value ?? default(uint)),
		 ShowWindow = (ushort) (managementObject.Properties["ShowWindow"]?.Value ?? default(ushort)),
		 Title = (string) (managementObject.Properties["Title"]?.Value),
		 WinstationDesktop = (string) (managementObject.Properties["WinstationDesktop"]?.Value),
		 X = (uint) (managementObject.Properties["X"]?.Value ?? default(uint)),
		 XCountChars = (uint) (managementObject.Properties["XCountChars"]?.Value ?? default(uint)),
		 XSize = (uint) (managementObject.Properties["XSize"]?.Value ?? default(uint)),
		 Y = (uint) (managementObject.Properties["Y"]?.Value ?? default(uint)),
		 YCountChars = (uint) (managementObject.Properties["YCountChars"]?.Value ?? default(uint)),
		 YSize = (uint) (managementObject.Properties["YSize"]?.Value ?? default(uint))
                };
        }
    }
}