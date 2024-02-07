using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Receiving_Party_WWS_DataType : INotifyPropertyChanged
	{
		private string payee_NameField;

		private string payee_Legal_NameField;

		private string payee_Preferred_NameField;

		private string payee_IDField;

		private string expense_Payee_Employee_NumberField;

		private string tax_IDField;

		private string corporate_Credit_Card_Account_NumberField;

		private string market_CodeField;

		private CountryObjectType country_ReferenceField;

		private Business_Entity_Alternate_Name_DataType[] payee_Alternate_NameField;

		private Address_Information_DataType[] address_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payee_Name
		{
			get
			{
				return this.payee_NameField;
			}
			set
			{
				this.payee_NameField = value;
				this.RaisePropertyChanged("Payee_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Payee_Legal_Name
		{
			get
			{
				return this.payee_Legal_NameField;
			}
			set
			{
				this.payee_Legal_NameField = value;
				this.RaisePropertyChanged("Payee_Legal_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Payee_Preferred_Name
		{
			get
			{
				return this.payee_Preferred_NameField;
			}
			set
			{
				this.payee_Preferred_NameField = value;
				this.RaisePropertyChanged("Payee_Preferred_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Payee_ID
		{
			get
			{
				return this.payee_IDField;
			}
			set
			{
				this.payee_IDField = value;
				this.RaisePropertyChanged("Payee_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Expense_Payee_Employee_Number
		{
			get
			{
				return this.expense_Payee_Employee_NumberField;
			}
			set
			{
				this.expense_Payee_Employee_NumberField = value;
				this.RaisePropertyChanged("Expense_Payee_Employee_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Tax_ID
		{
			get
			{
				return this.tax_IDField;
			}
			set
			{
				this.tax_IDField = value;
				this.RaisePropertyChanged("Tax_ID");
			}
		}

		[XmlElement(Order = 6)]
		public string Corporate_Credit_Card_Account_Number
		{
			get
			{
				return this.corporate_Credit_Card_Account_NumberField;
			}
			set
			{
				this.corporate_Credit_Card_Account_NumberField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Number");
			}
		}

		[XmlElement(Order = 7)]
		public string Market_Code
		{
			get
			{
				return this.market_CodeField;
			}
			set
			{
				this.market_CodeField = value;
				this.RaisePropertyChanged("Market_Code");
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

		[XmlElement("Payee_Alternate_Name", Order = 9)]
		public Business_Entity_Alternate_Name_DataType[] Payee_Alternate_Name
		{
			get
			{
				return this.payee_Alternate_NameField;
			}
			set
			{
				this.payee_Alternate_NameField = value;
				this.RaisePropertyChanged("Payee_Alternate_Name");
			}
		}

		[XmlElement("Address_Information_Data", Order = 10)]
		public Address_Information_DataType[] Address_Information_Data
		{
			get
			{
				return this.address_Information_DataField;
			}
			set
			{
				this.address_Information_DataField = value;
				this.RaisePropertyChanged("Address_Information_Data");
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
