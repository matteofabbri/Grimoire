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
	public class Contact_DataType : INotifyPropertyChanged
	{
		private Internet_Email_Address_DataType[] internet_Email_Address_DataField;

		private Phone_Number_DataType[] phone_Number_DataField;

		private Address_DataType[] address_DataField;

		private Web_Address_DataType[] web_Address_DataField;

		private Instant_Messenger_DataType[] instant_Messenger_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Internet_Email_Address_Data", Order = 0)]
		public Internet_Email_Address_DataType[] Internet_Email_Address_Data
		{
			get
			{
				return this.internet_Email_Address_DataField;
			}
			set
			{
				this.internet_Email_Address_DataField = value;
				this.RaisePropertyChanged("Internet_Email_Address_Data");
			}
		}

		[XmlElement("Phone_Number_Data", Order = 1)]
		public Phone_Number_DataType[] Phone_Number_Data
		{
			get
			{
				return this.phone_Number_DataField;
			}
			set
			{
				this.phone_Number_DataField = value;
				this.RaisePropertyChanged("Phone_Number_Data");
			}
		}

		[XmlElement("Address_Data", Order = 2)]
		public Address_DataType[] Address_Data
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

		[XmlElement("Web_Address_Data", Order = 3)]
		public Web_Address_DataType[] Web_Address_Data
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

		[XmlElement("Instant_Messenger_Data", Order = 4)]
		public Instant_Messenger_DataType[] Instant_Messenger_Data
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
