using System;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor.Windows.Jobs
{
    /// <summary>
    /// </summary>
    public sealed class Job
    {
		public string Caption { get; private set; }
		public string Description { get; private set; }
		public DateTime ElapsedTime { get; private set; }
		public DateTime InstallDate { get; private set; }
		public string JobStatus { get; private set; }
		public string Name { get; private set; }
		public string Notify { get; private set; }
		public string Owner { get; private set; }
		public uint Priority { get; private set; }
		public DateTime StartTime { get; private set; }
		public string Status { get; private set; }
		public DateTime TimeSubmitted { get; private set; }
		public DateTime UntilTime { get; private set; }

        public static IEnumerable<Job> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<Job> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<Job> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM CIM_Job");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new Job
                {
                     Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 ElapsedTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["ElapsedTime"]?.Value as string ?? "00010102000000.000000+060"),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 JobStatus = (string) (managementObject.Properties["JobStatus"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Notify = (string) (managementObject.Properties["Notify"]?.Value),
		 Owner = (string) (managementObject.Properties["Owner"]?.Value),
		 Priority = (uint) (managementObject.Properties["Priority"]?.Value ?? default(uint)),
		 StartTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["StartTime"]?.Value as string ?? "00010102000000.000000+060"),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 TimeSubmitted = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["TimeSubmitted"]?.Value as string ?? "00010102000000.000000+060"),
		 UntilTime = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["UntilTime"]?.Value as string ?? "00010102000000.000000+060")
                };
        }
    }
}