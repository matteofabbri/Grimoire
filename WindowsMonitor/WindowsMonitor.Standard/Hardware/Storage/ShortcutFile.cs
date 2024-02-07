using System;
using System.Collections;
using System.Collections.Generic;
using System.Management;

namespace WindowsMonitor
{
    /// <summary>
    /// </summary>
    public sealed class ShortcutFile
    {
		public uint AccessMask { get; private set; }
		public bool Archive { get; private set; }
		public string Caption { get; private set; }
		public bool Compressed { get; private set; }
		public string CompressionMethod { get; private set; }
		public string CreationClassName { get; private set; }
		public DateTime CreationDate { get; private set; }
		public string CsCreationClassName { get; private set; }
		public string CsName { get; private set; }
		public string Description { get; private set; }
		public string Drive { get; private set; }
		public string EightDotThreeFileName { get; private set; }
		public bool Encrypted { get; private set; }
		public string EncryptionMethod { get; private set; }
		public string Extension { get; private set; }
		public string FileName { get; private set; }
		public ulong FileSize { get; private set; }
		public string FileType { get; private set; }
		public string FsCreationClassName { get; private set; }
		public string FsName { get; private set; }
		public bool Hidden { get; private set; }
		public DateTime InstallDate { get; private set; }
		public ulong InUseCount { get; private set; }
		public DateTime LastAccessed { get; private set; }
		public DateTime LastModified { get; private set; }
		public string Manufacturer { get; private set; }
		public string Name { get; private set; }
		public string Path { get; private set; }
		public bool Readable { get; private set; }
		public string Status { get; private set; }
		public bool System { get; private set; }
		public string Target { get; private set; }
		public string Version { get; private set; }
		public bool Writeable { get; private set; }

        public static IEnumerable<ShortcutFile> Retrieve(string remote, string username, string password)
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

        public static IEnumerable<ShortcutFile> Retrieve()
        {
            var managementScope = new ManagementScope(new ManagementPath("root\\cimv2"));
            return Retrieve(managementScope);
        }

        public static IEnumerable<ShortcutFile> Retrieve(ManagementScope managementScope)
        {
            var objectQuery = new ObjectQuery("SELECT * FROM Win32_ShortcutFile");
            var objectSearcher = new ManagementObjectSearcher(managementScope, objectQuery);
            var objectCollection = objectSearcher.Get();

            foreach (ManagementObject managementObject in objectCollection)
                yield return new ShortcutFile
                {
                     AccessMask = (uint) (managementObject.Properties["AccessMask"]?.Value ?? default(uint)),
		 Archive = (bool) (managementObject.Properties["Archive"]?.Value ?? default(bool)),
		 Caption = (string) (managementObject.Properties["Caption"]?.Value),
		 Compressed = (bool) (managementObject.Properties["Compressed"]?.Value ?? default(bool)),
		 CompressionMethod = (string) (managementObject.Properties["CompressionMethod"]?.Value),
		 CreationClassName = (string) (managementObject.Properties["CreationClassName"]?.Value),
		 CreationDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["CreationDate"]?.Value as string ?? "00010102000000.000000+060"),
		 CsCreationClassName = (string) (managementObject.Properties["CSCreationClassName"]?.Value),
		 CsName = (string) (managementObject.Properties["CSName"]?.Value),
		 Description = (string) (managementObject.Properties["Description"]?.Value),
		 Drive = (string) (managementObject.Properties["Drive"]?.Value),
		 EightDotThreeFileName = (string) (managementObject.Properties["EightDotThreeFileName"]?.Value),
		 Encrypted = (bool) (managementObject.Properties["Encrypted"]?.Value ?? default(bool)),
		 EncryptionMethod = (string) (managementObject.Properties["EncryptionMethod"]?.Value),
		 Extension = (string) (managementObject.Properties["Extension"]?.Value),
		 FileName = (string) (managementObject.Properties["FileName"]?.Value),
		 FileSize = (ulong) (managementObject.Properties["FileSize"]?.Value ?? default(ulong)),
		 FileType = (string) (managementObject.Properties["FileType"]?.Value),
		 FsCreationClassName = (string) (managementObject.Properties["FSCreationClassName"]?.Value),
		 FsName = (string) (managementObject.Properties["FSName"]?.Value),
		 Hidden = (bool) (managementObject.Properties["Hidden"]?.Value ?? default(bool)),
		 InstallDate = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["InstallDate"]?.Value as string ?? "00010102000000.000000+060"),
		 InUseCount = (ulong) (managementObject.Properties["InUseCount"]?.Value ?? default(ulong)),
		 LastAccessed = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastAccessed"]?.Value as string ?? "00010102000000.000000+060"),
		 LastModified = ManagementDateTimeConverter.ToDateTime (managementObject.Properties["LastModified"]?.Value as string ?? "00010102000000.000000+060"),
		 Manufacturer = (string) (managementObject.Properties["Manufacturer"]?.Value),
		 Name = (string) (managementObject.Properties["Name"]?.Value),
		 Path = (string) (managementObject.Properties["Path"]?.Value),
		 Readable = (bool) (managementObject.Properties["Readable"]?.Value ?? default(bool)),
		 Status = (string) (managementObject.Properties["Status"]?.Value),
		 System = (bool) (managementObject.Properties["System"]?.Value ?? default(bool)),
		 Target = (string) (managementObject.Properties["Target"]?.Value),
		 Version = (string) (managementObject.Properties["Version"]?.Value),
		 Writeable = (bool) (managementObject.Properties["Writeable"]?.Value ?? default(bool))
                };
        }
    }
}