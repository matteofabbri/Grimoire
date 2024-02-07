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
	public class Unidentified_Signon_DataType : INotifyPropertyChanged
	{
		private DateTime signon_DateTimeField;

		private bool signon_DateTimeFieldSpecified;

		private string user_NameField;

		private string proxy_User_NameField;

		private string authentication_Failure_MessageField;

		private string signon_IP_AddressField;

		private string authentication_TypeField;

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
		public string Proxy_User_Name
		{
			get
			{
				return this.proxy_User_NameField;
			}
			set
			{
				this.proxy_User_NameField = value;
				this.RaisePropertyChanged("Proxy_User_Name");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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
