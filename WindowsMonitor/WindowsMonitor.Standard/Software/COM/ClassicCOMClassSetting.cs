using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Software.COM
{
    /// <summary>
    /// </summary>
    public sealed class ClassicComClassSetting
    {
		public string AppId { get; private set; }
		public string AutoConvertToClsid { get; private set; }
		public string AutoTreatAsClsid { get; private set; }
		public string Caption { get; private set; }
		public string ComponentId { get; private set; }
		public bool Control { get; private set; }
		public string DefaultIcon { get; private set; }
		public string Description { get; private set; }
		public string InprocHandler { get; private set; }
		public string InprocHandler32 { get; private set; }
		public string InprocServer { get; private set; }
		public string InprocServer32 { get; private set; }
		public bool Insertable { get; private set; }
		public bool JavaClass { get; private set; }
		public string LocalServer { get; private set; }
		public string LocalServer32 { get; private set; }
		public string LongDisplayName { get; private set; }
		public string ProgId { get; private set; }
		public string SettingId { get; private set; }
		public string ShortDisplayName { get; private set; }
		public string ThreadingModel { get; private set; }
		public string ToolBoxBitmap32 { get; private set; }
		public string TreatAsClsid { get; private set; }
		public string TypeLibraryId { get; private set; }
		public string Version { get; private set; }
		public string VersionIndependentProgId { get; private set; }

        public static IEnumerable<ClassicComClassSetting> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ClassicComClassSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ClassicComClassSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ClassicCOMClassSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ClassicComClassSetting
                {
                     AppId = (string) (managementObject.Properties["AppID"]?.Value),
		 AutoConvertToClsid = (string) (managementObject.Properties["AutoConvertToClsid"]?.Value),
		 AutoTreatAsClsid = (string) (managementObject.Properties["AutoTreatAsClsid"]?.Value),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 ComponentId = (string) (managementObject.Properties["ComponentId"]?.Value),
		 Control = (bool) (managementObject.Properties["Control"]?.Value ?? default(bool)),
		 DefaultIcon = (string) (managementObject.Properties["DefaultIcon"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 InprocHandler = (string) (managementObject.Properties["InprocHandler"]?.Value),
		 InprocHandler32 = (string) (managementObject.Properties["InprocHandler32"]?.Value),
		 InprocServer = (string) (managementObject.Properties["InprocServer"]?.Value),
		 InprocServer32 = (string) (managementObject.Properties["InprocServer32"]?.Value),
		 Insertable = (bool) (managementObject.Properties["Insertable"]?.Value ?? default(bool)),
		 JavaClass = (bool) (managementObject.Properties["JavaClass"]?.Value ?? default(bool)),
		 LocalServer = (string) (managementObject.Properties["LocalServer"]?.Value),
		 LocalServer32 = (string) (managementObject.Properties["LocalServer32"]?.Value),
		 LongDisplayName = (string) (managementObject.Properties["LongDisplayName"]?.Value),
		 ProgId = (string) (managementObject.Properties["ProgId"]?.Value),
		 SettingId = (string) (managementObject.Properties["SettingID"]?.Value),
		 ShortDisplayName = (string) (managementObject.Properties["ShortDisplayName"]?.Value),
		 ThreadingModel = (string) (managementObject.Properties["ThreadingModel"]?.Value),
		 ToolBoxBitmap32 = (string) (managementObject.Properties["ToolBoxBitmap32"]?.Value),
		 TreatAsClsid = (string) (managementObject.Properties["TreatAsClsid"]?.Value),
		 TypeLibraryId = (string) (managementObject.Properties["TypeLibraryId"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 VersionIndependentProgId = (string) (managementObject.Properties["VersionIndependentProgId"]?.Value)
                };
        }
    }
}