using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.ISCSI.Initiator
{
    /// <summary>
    /// </summary>
    public sealed class IscsiInitiatorPortal
    {
		public string Address { get; private set; }
		public uint Index { get; private set; }
		public ushort Port { get; private set; }
		public string SymbolicName { get; private set; }

        public static IEnumerable<IscsiInitiatorPortal> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<IscsiInitiatorPortal> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\wmi"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<IscsiInitiatorPortal> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM MSiSCSIInitiator_Portal");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new IscsiInitiatorPortal
                {
                     Address = (string) (managementObject.Properties["Address"]?.Value ?? default(string)),
		 Index = (uint) (managementObject.Properties["Index"]?.Value ?? default(uint)),
		 Port = (ushort) (managementObject.Properties["Port"]?.Value ?? default(ushort)),
		 SymbolicName = (string) (managementObject.Properties["SymbolicName"]?.Value ?? default(string))
                };
        }
    }
}