using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows
{
    /// <summary>
    /// </summary>
    public sealed class WinSat
    {
		public float CpuScore { get; private set; }
		public float D3DScore { get; private set; }
		public float DiskScore { get; private set; }
		public float GraphicsScore { get; private set; }
		public float MemoryScore { get; private set; }
		public string TimeTaken { get; private set; }
		public uint WinSatAssessmentState { get; private set; }
		public float WinSprLevel { get; private set; }

        public static IEnumerable<WinSat> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<WinSat> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<WinSat> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_WinSAT");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new WinSat
                {
                     CpuScore = (float) (managementObject.Properties["CPUScore"]?.Value ?? default(float)),
		 D3DScore = (float) (managementObject.Properties["D3DScore"]?.Value ?? default(float)),
		 DiskScore = (float) (managementObject.Properties["DiskScore"]?.Value ?? default(float)),
		 GraphicsScore = (float) (managementObject.Properties["GraphicsScore"]?.Value ?? default(float)),
		 MemoryScore = (float) (managementObject.Properties["MemoryScore"]?.Value ?? default(float)),
		 TimeTaken = (string) (managementObject.Properties["TimeTaken"]?.Value),
		 WinSatAssessmentState = (uint) (managementObject.Properties["WinSATAssessmentState"]?.Value ?? default(uint)),
		 WinSprLevel = (float) (managementObject.Properties["WinSPRLevel"]?.Value ?? default(float))
                };
        }
    }
}