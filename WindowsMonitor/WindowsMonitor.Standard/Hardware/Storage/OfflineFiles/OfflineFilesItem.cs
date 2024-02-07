using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Hardware.Storage.OfflineFiles
{
    /// <summary>
    /// </summary>
    public sealed class OfflineFilesItem
    {
		public dynamic ChangeInfo { get; private set; }
		public dynamic ConnectionInfo { get; private set; }
		public dynamic DirtyInfo { get; private set; }
		public bool Encrypted { get; private set; }
		public dynamic FileSysInfo { get; private set; }
		public string ItemName { get; private set; }
		public string ItemPath { get; private set; }
		public uint ItemType { get; private set; }
		public string ParentItemPath { get; private set; }
		public dynamic PinInfo { get; private set; }
		public bool Sparse { get; private set; }
		public dynamic SuspendInfo { get; private set; }

        public static IEnumerable<OfflineFilesItem> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<OfflineFilesItem> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<OfflineFilesItem> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_OfflineFilesItem");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new OfflineFilesItem
                {
                     ChangeInfo = (dynamic) (managementObject.Properties["ChangeInfo"]?.Value ?? default(dynamic)),
		 ConnectionInfo = (dynamic) (managementObject.Properties["ConnectionInfo"]?.Value ?? default(dynamic)),
		 DirtyInfo = (dynamic) (managementObject.Properties["DirtyInfo"]?.Value ?? default(dynamic)),
		 Encrypted = (bool) (managementObject.Properties["Encrypted"]?.Value ?? default(bool)),
		 FileSysInfo = (dynamic) (managementObject.Properties["FileSysInfo"]?.Value ?? default(dynamic)),
		 ItemName = (string) (managementObject.Properties["ItemName"]?.Value),
		 ItemPath = (string) (managementObject.Properties["ItemPath"]?.Value),
		 ItemType = (uint) (managementObject.Properties["ItemType"]?.Value ?? default(uint)),
		 ParentItemPath = (string) (managementObject.Properties["ParentItemPath"]?.Value),
		 PinInfo = (dynamic) (managementObject.Properties["PinInfo"]?.Value ?? default(dynamic)),
		 Sparse = (bool) (managementObject.Properties["Sparse"]?.Value ?? default(bool)),
		 SuspendInfo = (dynamic) (managementObject.Properties["SuspendInfo"]?.Value ?? default(dynamic))
                };
        }
    }
}