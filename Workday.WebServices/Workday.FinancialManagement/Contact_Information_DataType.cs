using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Contact_Information_DataType : INotifyPropertyChanged
	{
		private Address_Information_DataType[] address_DataField;

		private Phone_Information_DataType[] phone_DataField;

		private Email_Address_Information_DataType[] email_Address_DataField;

		private Instant_Messenger_Information_DataType[] instant_Messenger_DataField;

		private Web_address_Information_DataType[] web_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Address_Data", Order = 0)]
		public Address_Information_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
			}
		}

		[XmlElement("Phone_Data", Order = 1)]
		public Phone_Information_DataType[] Phone_Data
		{
			get
			{
				return this.phone_DataField;
			}
			set
			{
				this.phone_DataField = value;
				this.RaisePropertyChanged("Phone_Data");
			}
		}

		[XmlElement("Email_Address_Data", Order = 2)]
		public Email_Address_Information_DataType[] Email_Address_Data
		{
			get
			{
				return this.email_Address_DataField;
			}
			set
			{
				this.email_Address_DataField = value;
				this.RaisePropertyChanged("Email_Address_Data");
			}
		}

		[XmlElement("Instant_Messenger_Data", Order = 3)]
		public Instant_Messenger_Information_DataType[] Instant_Messenger_Data
		{
			get
			{
				return this.instant_Messenger_DataField;
			}
			set
			{
				this.instant_Messenger_DataField = value;
				this.RaisePropertyChanged("Instant_Messenger_Data");
			}
		}

		[XmlElement("Web_Address_Data", Order = 4)]
		public Web_address_Information_DataType[] Web_Address_Data
		{
			get
			{
				return this.web_Address_DataField;
			}
			set
			{
				this.web_Address_DataField = value;
				this.RaisePropertyChanged("Web_Address_Data");
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
