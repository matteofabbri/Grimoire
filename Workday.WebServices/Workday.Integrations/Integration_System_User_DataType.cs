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
	public class Integration_System_User_DataType : INotifyPropertyChanged
	{
		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private string user_NameField;

		private string passwordField;

		private bool require_New_Password_At_Next_Sign_InField;

		private bool require_New_Password_At_Next_Sign_InFieldSpecified;

		private decimal session_Timeout_MinutesField;

		private bool session_Timeout_MinutesFieldSpecified;

		private Web_Service_Security_Configuration_DataType[] web_Service_Security_Configuration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_System__Audited_ObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string User_Name
		{
			get
			{
				return this.user_NameField;
			}
			set
			{
				this.user_NameField = value;
				this.RaisePropertyChanged("User_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public bool Require_New_Password_At_Next_Sign_In
		{
			get
			{
				return this.require_New_Password_At_Next_Sign_InField;
			}
			set
			{
				this.require_New_Password_At_Next_Sign_InField = value;
				this.RaisePropertyChanged("Require_New_Password_At_Next_Sign_In");
			}
		}

		[XmlIgnore]
		public bool Require_New_Password_At_Next_Sign_InSpecified
		{
			get
			{
				return this.require_New_Password_At_Next_Sign_InFieldSpecified;
			}
			set
			{
				this.require_New_Password_At_Next_Sign_InFieldSpecified = value;
				this.RaisePropertyChanged("Require_New_Password_At_Next_Sign_InSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Session_Timeout_Minutes
		{
			get
			{
				return this.session_Timeout_MinutesField;
			}
			set
			{
				this.session_Timeout_MinutesField = value;
				this.RaisePropertyChanged("Session_Timeout_Minutes");
			}
		}

		[XmlIgnore]
		public bool Session_Timeout_MinutesSpecified
		{
			get
			{
				return this.session_Timeout_MinutesFieldSpecified;
			}
			set
			{
				this.session_Timeout_MinutesFieldSpecified = value;
				this.RaisePropertyChanged("Session_Timeout_MinutesSpecified");
			}
		}

		[XmlElement("Web_Service_Security_Configuration_Data", Order = 5)]
		public Web_Service_Security_Configuration_DataType[] Web_Service_Security_Configuration_Data
		{
			get
			{
				return this.web_Service_Security_Configuration_DataField;
			}
			set
			{
				this.web_Service_Security_Configuration_DataField = value;
				this.RaisePropertyChanged("Web_Service_Security_Configuration_Data");
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
