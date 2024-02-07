using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class RemoteFxGraphics
    {
		public uint AverageEncodingTime { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public uint FrameQuality { get; private set; }
		public uint FramesSkippedPerSecondInsufficientClientResources { get; private set; }
		public uint FramesSkippedPerSecondInsufficientNetworkResources { get; private set; }
		public uint FramesSkippedPerSecondInsufficientServerResources { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public uint GraphicsCompressionratio { get; private set; }
		public uint InputFramesPerSecond { get; private set; }
		public string Name { get; private set; }
		public uint OutputFramesPerSecond { get; private set; }
		public uint SourceFramesPerSecond { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<RemoteFxGraphics> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RemoteFxGraphics> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RemoteFxGraphics> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_RemoteFXGraphics");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RemoteFxGraphics
                {
                     AverageEncodingTime = (uint) (managementObject.Properties["AverageEncodingTime"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrameQuality = (uint) (managementObject.Properties["FrameQuality"]?.Value ?? default(uint)),
		 FramesSkippedPerSecondInsufficientClientResources = (uint) (managementObject.Properties["FramesSkippedPerSecondInsufficientClientResources"]?.Value ?? default(uint)),
		 FramesSkippedPerSecondInsufficientNetworkResources = (uint) (managementObject.Properties["FramesSkippedPerSecondInsufficientNetworkResources"]?.Value ?? default(uint)),
		 FramesSkippedPerSecondInsufficientServerResources = (uint) (managementObject.Properties["FramesSkippedPerSecondInsufficientServerResources"]?.Value ?? default(uint)),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 GraphicsCompressionratio = (uint) (managementObject.Properties["GraphicsCompressionratio"]?.Value ?? default(uint)),
		 InputFramesPerSecond = (uint) (managementObject.Properties["InputFramesPerSecond"]?.Value ?? default(uint)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 OutputFramesPerSecond = (uint) (managementObject.Properties["OutputFramesPerSecond"]?.Value ?? default(uint)),
		 SourceFramesPerSecond = (uint) (managementObject.Properties["SourceFramesPerSecond"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}