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
	public class Email_Transport_Protocol_DataType : INotifyPropertyChanged
	{
		private string to_Email_AddressField;

		private string cc_Internet_Email_AddressField;

		private string bcc_Internet_Email_AddressField;

		private string from_Internet_Email_AddressField;

		private string email_SubjectField;

		private string email_TextField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string To_Email_Address
		{
			get
			{
				return this.to_Email_AddressField;
			}
			set
			{
				this.to_Email_AddressField = value;
				this.RaisePropertyChanged("To_Email_Address");
			}
		}

		[XmlElement(Order = 1)]
		public string Cc_Internet_Email_Address
		{
			get
			{
				return this.cc_Internet_Email_AddressField;
			}
			set
			{
				this.cc_Internet_Email_AddressField = value;
				this.RaisePropertyChanged("Cc_Internet_Email_Address");
			}
		}

		[XmlElement(Order = 2)]
		public string Bcc_Internet_Email_Address
		{
			get
			{
				return this.bcc_Internet_Email_AddressField;
			}
			set
			{
				this.bcc_Internet_Email_AddressField = value;
				this.RaisePropertyChanged("Bcc_Internet_Email_Address");
			}
		}

		[XmlElement(Order = 3)]
		public string From_Internet_Email_Address
		{
			get
			{
				return this.from_Internet_Email_AddressField;
			}
			set
			{
				this.from_Internet_Email_AddressField = value;
				this.RaisePropertyChanged("From_Internet_Email_Address");
			}
		}

		[XmlElement(Order = 4)]
		public string Email_Subject
		{
			get
			{
				return this.email_SubjectField;
			}
			set
			{
				this.email_SubjectField = value;
				this.RaisePropertyChanged("Email_Subject");
			}
		}

		[XmlElement(Order = 5)]
		public string Email_Text
		{
			get
			{
				return this.email_TextField;
			}
			set
			{
				this.email_TextField = value;
				this.RaisePropertyChanged("Email_Text");
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
