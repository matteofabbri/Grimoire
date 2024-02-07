using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.IdentityManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workday_Account_Signon_DataType : INotifyPropertyChanged
	{
		private DateTime signon_DateTimeField;

		private bool signon_DateTimeFieldSpecified;

		private string user_NameField;

		private bool successfulField;

		private bool successfulFieldSpecified;

		private bool failed_SignonField;

		private bool failed_SignonFieldSpecified;

		private bool invalid_CredentialsField;

		private bool invalid_CredentialsFieldSpecified;

		private bool password_ChangedField;

		private bool password_ChangedFieldSpecified;

		private bool forgotten_Password_Reset_RequestField;

		private bool forgotten_Password_Reset_RequestFieldSpecified;

		private string authentication_Failure_MessageField;

		private string signon_IP_AddressField;

		private DateTime signoff_DateTimeField;

		private bool signoff_DateTimeFieldSpecified;

		private string authentication_ChannelField;

		private string authentication_TypeField;

		private System_AccountObjectType workday_Account_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Signon_DateTime
		{
			get
			{
				return this.signon_DateTimeField;
			}
			set
			{
				this.signon_DateTimeField = value;
				this.RaisePropertyChanged("Signon_DateTime");
			}
		}

		[XmlIgnore]
		public bool Signon_DateTimeSpecified
		{
			get
			{
				return this.signon_DateTimeFieldSpecified;
			}
			set
			{
				this.signon_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Signon_DateTimeSpecified");
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
		public bool Successful
		{
			get
			{
				return this.successfulField;
			}
			set
			{
				this.successfulField = value;
				this.RaisePropertyChanged("Successful");
			}
		}

		[XmlIgnore]
		public bool SuccessfulSpecified
		{
			get
			{
				return this.successfulFieldSpecified;
			}
			set
			{
				this.successfulFieldSpecified = value;
				this.RaisePropertyChanged("SuccessfulSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Failed_Signon
		{
			get
			{
				return this.failed_SignonField;
			}
			set
			{
				this.failed_SignonField = value;
				this.RaisePropertyChanged("Failed_Signon");
			}
		}

		[XmlIgnore]
		public bool Failed_SignonSpecified
		{
			get
			{
				return this.failed_SignonFieldSpecified;
			}
			set
			{
				this.failed_SignonFieldSpecified = value;
				this.RaisePropertyChanged("Failed_SignonSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Invalid_Credentials
		{
			get
			{
				return this.invalid_CredentialsField;
			}
			set
			{
				this.invalid_CredentialsField = value;
				this.RaisePropertyChanged("Invalid_Credentials");
			}
		}

		[XmlIgnore]
		public bool Invalid_CredentialsSpecified
		{
			get
			{
				return this.invalid_CredentialsFieldSpecified;
			}
			set
			{
				this.invalid_CredentialsFieldSpecified = value;
				this.RaisePropertyChanged("Invalid_CredentialsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Password_Changed
		{
			get
			{
				return this.password_ChangedField;
			}
			set
			{
				this.password_ChangedField = value;
				this.RaisePropertyChanged("Password_Changed");
			}
		}

		[XmlIgnore]
		public bool Password_ChangedSpecified
		{
			get
			{
				return this.password_ChangedFieldSpecified;
			}
			set
			{
				this.password_ChangedFieldSpecified = value;
				this.RaisePropertyChanged("Password_ChangedSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Forgotten_Password_Reset_Request
		{
			get
			{
				return this.forgotten_Password_Reset_RequestField;
			}
			set
			{
				this.forgotten_Password_Reset_RequestField = value;
				this.RaisePropertyChanged("Forgotten_Password_Reset_Request");
			}
		}

		[XmlIgnore]
		public bool Forgotten_Password_Reset_RequestSpecified
		{
			get
			{
				return this.forgotten_Password_Reset_RequestFieldSpecified;
			}
			set
			{
				this.forgotten_Password_Reset_RequestFieldSpecified = value;
				this.RaisePropertyChanged("Forgotten_Password_Reset_RequestSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Authentication_Failure_Message
		{
			get
			{
				return this.authentication_Failure_MessageField;
			}
			set
			{
				this.authentication_Failure_MessageField = value;
				this.RaisePropertyChanged("Authentication_Failure_Message");
			}
		}

		[XmlElement(Order = 8)]
		public string Signon_IP_Address
		{
			get
			{
				return this.signon_IP_AddressField;
			}
			set
			{
				this.signon_IP_AddressField = value;
				this.RaisePropertyChanged("Signon_IP_Address");
			}
		}

		[XmlElement(Order = 9)]
		public DateTime Signoff_DateTime
		{
			get
			{
				return this.signoff_DateTimeField;
			}
			set
			{
				this.signoff_DateTimeField = value;
				this.RaisePropertyChanged("Signoff_DateTime");
			}
		}

		[XmlIgnore]
		public bool Signoff_DateTimeSpecified
		{
			get
			{
				return this.signoff_DateTimeFieldSpecified;
			}
			set
			{
				this.signoff_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Signoff_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Authentication_Channel
		{
			get
			{
				return this.authentication_ChannelField;
			}
			set
			{
				this.authentication_ChannelField = value;
				this.RaisePropertyChanged("Authentication_Channel");
			}
		}

		[XmlElement(Order = 11)]
		public string Authentication_Type
		{
			get
			{
				return this.authentication_TypeField;
			}
			set
			{
				this.authentication_TypeField = value;
				this.RaisePropertyChanged("Authentication_Type");
			}
		}

		[XmlElement(Order = 12)]
		public System_AccountObjectType Workday_Account_Reference
		{
			get
			{
				return this.workday_Account_ReferenceField;
			}
			set
			{
				this.workday_Account_ReferenceField = value;
				this.RaisePropertyChanged("Workday_Account_Reference");
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
