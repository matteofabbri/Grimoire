using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ScriptingStandardConsumerSetting
    {
        public string Caption { get; private set; }
        public string Description { get; private set; }
        public uint MaximumScripts { get; private set; }
        public string SettingId { get; private set; }
        public uint Timeout { get; private set; }

        public static IEnumerable<ScriptingStandardConsumerSetting> Retrieve(string remote, string username,
            string password)
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

        public static IEnumerable<ScriptingStandardConsumerSetting> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ScriptingStandardConsumerSetting> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM ScriptingStandardConsumerSetting");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ScriptingStandardConsumerSetting
                {
                    Caption = (string) managementObject.Properties["Caption"]?.Value,
                    Description = (string) managementObject.Properties["Description"]?.Value,
                    MaximumScripts = (uint) (managementObject.Properties["MaximumScripts"]?.Value ?? default(uint)),
                    SettingId = (string) managementObject.Properties["SettingID"]?.Value,
                    Timeout = (uint) (managementObject.Properties["Timeout"]?.Value ?? default(uint))
                };
        }
    }
}