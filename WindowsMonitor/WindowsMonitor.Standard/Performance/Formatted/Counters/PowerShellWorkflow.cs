using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Performance.Formatted.Counters
{
    /// <summary>
    /// </summary>
    public sealed class PowerShellWorkflow
    {
		public uint ActivityHostManagerhostprocessespoolsize { get; private set; }
		public uint ActivityHostManagerNumberofbusyhostprocesses { get; private set; }
		public uint ActivityHostManagerNumberofcreatedhostprocesses { get; private set; }
		public uint ActivityHostManagerNumberofdisposedhostprocesses { get; private set; }
		public uint ActivityHostManagerNumberoffailedrequestsinqueue { get; private set; }
		public uint ActivityHostManagerNumberoffailedrequestsPersec { get; private set; }
		public uint ActivityHostManagerNumberofincomingrequestsPersec { get; private set; }
		public uint ActivityHostManagerNumberofpendingrequestsinqueue { get; private set; }
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public ulong FrequencyObject { get; private set; }
		public ulong FrequencyPerfTime { get; private set; }
		public ulong FrequencySys100Ns { get; private set; }
		public string Name { get; private set; }
		public uint Numberoffailedworkflowjobs { get; private set; }
		public uint NumberoffailedworkflowjobsPersec { get; private set; }
		public uint Numberofresumedworkflowjobs { get; private set; }
		public uint NumberofresumedworkflowjobsPersec { get; private set; }
		public uint Numberofrunningworkflowjobs { get; private set; }
		public uint NumberofrunningworkflowjobsPersec { get; private set; }
		public uint Numberofstoppedworkflowjobs { get; private set; }
		public uint NumberofstoppedworkflowjobsPersec { get; private set; }
		public uint Numberofsucceededworkflowjobs { get; private set; }
		public uint NumberofsucceededworkflowjobsPersec { get; private set; }
		public uint Numberofsuspendedworkflowjobs { get; private set; }
		public uint NumberofsuspendedworkflowjobsPersec { get; private set; }
		public uint Numberofterminatedworkflowjobs { get; private set; }
		public uint NumberofterminatedworkflowjobsPersec { get; private set; }
		public uint Numberofwaitingworkflowjobs { get; private set; }
		public uint PowerShellRemotingNumberofconnectionsclosedreopened { get; private set; }
		public uint PowerShellRemotingNumberofcreatedconnections { get; private set; }
		public uint PowerShellRemotingNumberofdisposedconnections { get; private set; }
		public uint PowerShellRemotingNumberofforcedtowaitrequestsinqueue { get; private set; }
		public uint PowerShellRemotingNumberofpendingrequestsinqueue { get; private set; }
		public uint PowerShellRemotingNumberofrequestsbeingserviced { get; private set; }
		public ulong TimestampObject { get; private set; }
		public ulong TimestampPerfTime { get; private set; }
		public ulong TimestampSys100Ns { get; private set; }

        public static IEnumerable<PowerShellWorkflow> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<PowerShellWorkflow> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<PowerShellWorkflow> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_PerfFormattedData_Counters_PowerShellWorkflow");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new PowerShellWorkflow
                {
                     ActivityHostManagerhostprocessespoolsize = (uint) (managementObject.Properties["ActivityHostManagerhostprocessespoolsize"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberofbusyhostprocesses = (uint) (managementObject.Properties["ActivityHostManagerNumberofbusyhostprocesses"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberofcreatedhostprocesses = (uint) (managementObject.Properties["ActivityHostManagerNumberofcreatedhostprocesses"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberofdisposedhostprocesses = (uint) (managementObject.Properties["ActivityHostManagerNumberofdisposedhostprocesses"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberoffailedrequestsinqueue = (uint) (managementObject.Properties["ActivityHostManagerNumberoffailedrequestsinqueue"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberoffailedrequestsPersec = (uint) (managementObject.Properties["ActivityHostManagerNumberoffailedrequestsPersec"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberofincomingrequestsPersec = (uint) (managementObject.Properties["ActivityHostManagerNumberofincomingrequestsPersec"]?.Value ?? default(uint)),
		 ActivityHostManagerNumberofpendingrequestsinqueue = (uint) (managementObject.Properties["ActivityHostManagerNumberofpendingrequestsinqueue"]?.Value ?? default(uint)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 FrequencyObject = (ulong) (managementObject.Properties["Frequency_Object"]?.Value ?? default(ulong)),
		 FrequencyPerfTime = (ulong) (managementObject.Properties["Frequency_PerfTime"]?.Value ?? default(ulong)),
		 FrequencySys100Ns = (ulong) (managementObject.Properties["Frequency_Sys100NS"]?.Value ?? default(ulong)),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Numberoffailedworkflowjobs = (uint) (managementObject.Properties["Numberoffailedworkflowjobs"]?.Value ?? default(uint)),
		 NumberoffailedworkflowjobsPersec = (uint) (managementObject.Properties["NumberoffailedworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofresumedworkflowjobs = (uint) (managementObject.Properties["Numberofresumedworkflowjobs"]?.Value ?? default(uint)),
		 NumberofresumedworkflowjobsPersec = (uint) (managementObject.Properties["NumberofresumedworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofrunningworkflowjobs = (uint) (managementObject.Properties["Numberofrunningworkflowjobs"]?.Value ?? default(uint)),
		 NumberofrunningworkflowjobsPersec = (uint) (managementObject.Properties["NumberofrunningworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofstoppedworkflowjobs = (uint) (managementObject.Properties["Numberofstoppedworkflowjobs"]?.Value ?? default(uint)),
		 NumberofstoppedworkflowjobsPersec = (uint) (managementObject.Properties["NumberofstoppedworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofsucceededworkflowjobs = (uint) (managementObject.Properties["Numberofsucceededworkflowjobs"]?.Value ?? default(uint)),
		 NumberofsucceededworkflowjobsPersec = (uint) (managementObject.Properties["NumberofsucceededworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofsuspendedworkflowjobs = (uint) (managementObject.Properties["Numberofsuspendedworkflowjobs"]?.Value ?? default(uint)),
		 NumberofsuspendedworkflowjobsPersec = (uint) (managementObject.Properties["NumberofsuspendedworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofterminatedworkflowjobs = (uint) (managementObject.Properties["Numberofterminatedworkflowjobs"]?.Value ?? default(uint)),
		 NumberofterminatedworkflowjobsPersec = (uint) (managementObject.Properties["NumberofterminatedworkflowjobsPersec"]?.Value ?? default(uint)),
		 Numberofwaitingworkflowjobs = (uint) (managementObject.Properties["Numberofwaitingworkflowjobs"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofconnectionsclosedreopened = (uint) (managementObject.Properties["PowerShellRemotingNumberofconnectionsclosedreopened"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofcreatedconnections = (uint) (managementObject.Properties["PowerShellRemotingNumberofcreatedconnections"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofdisposedconnections = (uint) (managementObject.Properties["PowerShellRemotingNumberofdisposedconnections"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofforcedtowaitrequestsinqueue = (uint) (managementObject.Properties["PowerShellRemotingNumberofforcedtowaitrequestsinqueue"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofpendingrequestsinqueue = (uint) (managementObject.Properties["PowerShellRemotingNumberofpendingrequestsinqueue"]?.Value ?? default(uint)),
		 PowerShellRemotingNumberofrequestsbeingserviced = (uint) (managementObject.Properties["PowerShellRemotingNumberofrequestsbeingserviced"]?.Value ?? default(uint)),
		 TimestampObject = (ulong) (managementObject.Properties["Timestamp_Object"]?.Value ?? default(ulong)),
		 TimestampPerfTime = (ulong) (managementObject.Properties["Timestamp_PerfTime"]?.Value ?? default(ulong)),
		 TimestampSys100Ns = (ulong) (managementObject.Properties["Timestamp_Sys100NS"]?.Value ?? default(ulong))
                };
        }
    }
}