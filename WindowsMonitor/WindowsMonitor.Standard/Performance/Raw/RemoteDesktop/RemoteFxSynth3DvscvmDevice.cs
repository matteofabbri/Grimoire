using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Raw.RemoteDesktop
{
    /// <summary>
    /// </summary>
    public sealed class RemoteFxSynth3DvscvmDevice
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint NumberofconnectedVmTchannels { get; private set; }
		public uint NumberofcreatedVmTchannels { get; private set; }
		public uint NumberofdisconnectedVmTchannels { get; private set; }
		public uint NumberofRdvgMrestartednotifications { get; private set; }
		public uint NumberofwaitingVmTchannels { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }
		public uint TotalnumberofcreatedVmTchannels { get; private set; }

        public static IEnumerable<RemoteFxSynth3DvscvmDevice> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<RemoteFxSynth3DvscvmDevice> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<RemoteFxSynth3DvscvmDevice> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfRawData_MicrosoftWindowsRemoteDesktopServicesRemoteFXSynth3dvsc_RemoteFXSynth3DVSCVMDevice");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new RemoteFxSynth3DvscvmDevice
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 NumberofconnectedVmTchannels = (uint) (managementObject.Properties["NumberofconnectedVMTchannels"]?.Value ?? default(uint)),
		 NumberofcreatedVmTchannels = (uint) (managementObject.Properties["NumberofcreatedVMTchannels"]?.Value ?? default(uint)),
		 NumberofdisconnectedVmTchannels = (uint) (managementObject.Properties["NumberofdisconnectedVMTchannels"]?.Value ?? default(uint)),
		 NumberofRdvgMrestartednotifications = (uint) (managementObject.Properties["NumberofRDVGMrestartednotifications"]?.Value ?? default(uint)),
		 NumberofwaitingVmTchannels = (uint) (managementObject.Properties["NumberofwaitingVMTchannels"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong)),
		 TotalnumberofcreatedVmTchannels = (uint) (managementObject.Properties["TotalnumberofcreatedVMTchannels"]?.Value ?? default(uint))
                };
        }
    }
}