using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class FTPS_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private string fTPS_AddressField;

		private string directoryField;

		private bool use_Passive_ModeField;

		private string user_IDField;

		private string passwordField;

		private bool use_Temp_FileField;

		private bool use_Temp_FileFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string FTPS_Address
		{
			get
			{
				return this.fTPS_AddressField;
			}
			set
			{
				this.fTPS_AddressField = value;
				this.RaisePropertyChanged("FTPS_Address");
			}
		}

		[XmlElement(Order = 1)]
		public string Directory
		{
			get
			{
				return this.directoryField;
			}
			set
			{
				this.directoryField = value;
				this.RaisePropertyChanged("Directory");
			}
		}

		[XmlElement(Order = 2)]
		public bool Use_Passive_Mode
		{
			get
			{
				return this.use_Passive_ModeField;
			}
			set
			{
				this.use_Passive_ModeField = value;
				this.RaisePropertyChanged("Use_Passive_Mode");
			}
		}

		[XmlElement(Order = 3)]
		public string User_ID
		{
			get
			{
				return this.user_IDField;
			}
			set
			{
				this.user_IDField = value;
				this.RaisePropertyChanged("User_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Password
		{
			get
			{
				return this.passwordField;
			}
			set
			{
				this.passwordField = value;
				this.RaisePropertyChanged("Password");
			}
		}

		[XmlElement(Order = 5)]
		public bool Use_Temp_File
		{
			get
			{
				return this.use_Temp_FileField;
			}
			set
			{
				this.use_Temp_FileField = value;
				this.RaisePropertyChanged("Use_Temp_File");
			}
		}

		[XmlIgnore]
		public bool Use_Temp_FileSpecified
		{
			get
			{
				return this.use_Temp_FileFieldSpecified;
			}
			set
			{
				this.use_Temp_FileFieldSpecified = value;
				this.RaisePropertyChanged("Use_Temp_FileSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
