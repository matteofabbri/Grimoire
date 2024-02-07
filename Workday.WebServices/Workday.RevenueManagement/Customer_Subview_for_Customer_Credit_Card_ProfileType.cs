using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Subview_for_Customer_Credit_Card_ProfileType : INotifyPropertyChanged
	{
		private string customer_IDField;

		private string customer_NameField;

		private Address_Information_DataType[] bill_To_Address_InformationField;

		private string address_Line_1Field;

		private string address_Line_2Field;

		private string cityField;

		private Country_RegionObjectType country_Region_ReferenceField;

		private string postal_CodeField;

		private CountryObjectType country_ReferenceField;

		private string full_Phone_NumberField;

		private string email_AddressField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_ID
		{
			get
			{
				return this.customer_IDField;
			}
			set
			{
				this.customer_IDField = value;
				this.RaisePropertyChanged("Customer_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Name
		{
			get
			{
				return this.customer_NameField;
			}
			set
			{
				this.customer_NameField = value;
				this.RaisePropertyChanged("Customer_Name");
			}
		}

		[XmlElement("Bill_To_Address_Information", Order = 2)]
		public Address_Information_DataType[] Bill_To_Address_Information
		{
			get
			{
				return this.bill_To_Address_InformationField;
			}
			set
			{
				this.bill_To_Address_InformationField = value;
				this.RaisePropertyChanged("Bill_To_Address_Information");
			}
		}

		[XmlElement(Order = 3)]
		public string Address_Line_1
		{
			get
			{
				return this.address_Line_1Field;
			}
			set
			{
				this.address_Line_1Field = value;
				this.RaisePropertyChanged("Address_Line_1");
			}
		}

		[XmlElement(Order = 4)]
		public string Address_Line_2
		{
			get
			{
				return this.address_Line_2Field;
			}
			set
			{
				this.address_Line_2Field = value;
				this.RaisePropertyChanged("Address_Line_2");
			}
		}

		[XmlElement(Order = 5)]
		public string City
		{
			get
			{
				return this.cityField;
			}
			set
			{
				this.cityField = value;
				this.RaisePropertyChanged("City");
			}
		}

		[XmlElement(Order = 6)]
		public Country_RegionObjectType Country_Region_Reference
		{
			get
			{
				return this.country_Region_ReferenceField;
			}
			set
			{
				this.country_Region_ReferenceField = value;
				this.RaisePropertyChanged("Country_Region_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Postal_Code
		{
			get
			{
				return this.postal_CodeField;
			}
			set
			{
				this.postal_CodeField = value;
				this.RaisePropertyChanged("Postal_Code");
			}
		}

		[XmlElement(Order = 8)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string Full_Phone_Number
		{
			get
			{
				return this.full_Phone_NumberField;
			}
			set
			{
				this.full_Phone_NumberField = value;
				this.RaisePropertyChanged("Full_Phone_Number");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
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
