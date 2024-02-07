using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software
{
    /// <summary>
    /// </summary>
    public sealed class InstalledProgramFramework
    {
		public string FrameworkName { get; private set; }
		public string FrameworkPublisher { get; private set; }
		public string FrameworkVersion { get; private set; }
		public string FrameworkVersionActual { get; private set; }
		public bool IsPrivate { get; private set; }
		public string ProgramId { get; private set; }

        public static IEnumerable<InstalledProgramFramework> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<InstalledProgramFramework> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<InstalledProgramFramework> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_InstalledProgramFramework");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new InstalledProgramFramework
                {
                     FrameworkName = (string) (managementObject.Properties["FrameworkName"]?.Value),
		 FrameworkPublisher = (string) (managementObject.Properties["FrameworkPublisher"]?.Value),
		 FrameworkVersion = (string) (managementObject.Properties["FrameworkVersion"]?.Value),
		 FrameworkVersionActual = (string) (managementObject.Properties["FrameworkVersionActual"]?.Value),
		 IsPrivate = (bool) (managementObject.Properties["IsPrivate"]?.Value ?? default(bool)),
		 ProgramId = (string) (managementObject.Properties["ProgramId"]?.Value)
                };
        }
    }
}