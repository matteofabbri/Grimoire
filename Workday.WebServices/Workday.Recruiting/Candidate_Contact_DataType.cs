using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Contact_DataType : INotifyPropertyChanged
	{
		private string phone_NumberField;

		private string email_AddressField;

		private Candidate_Websites_DataType[] website_DataField;

		private Candidate_Location_DataType location_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Phone_Number
		{
			get
			{
				return this.phone_NumberField;
			}
			set
			{
				this.phone_NumberField = value;
				this.RaisePropertyChanged("Phone_Number");
			}
		}

		[XmlElement(Order = 1)]
		public string Email_Address
		{
			get
			{
				return this.email_AddressField;
			}
			set
			{
				this.email_AddressField = value;
				this.RaisePropertyChanged("Email_Address");
			}
		}

		[XmlElement("Website_Data", Order = 2)]
		public Candidate_Websites_DataType[] Website_Data
		{
			get
			{
				return this.website_DataField;
			}
			set
			{
				this.website_DataField = value;
				this.RaisePropertyChanged("Website_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Candidate_Location_DataType Location_Data
		{
			get
			{
				return this.location_DataField;
			}
			set
			{
				this.location_DataField = value;
				this.RaisePropertyChanged("Location_Data");
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
