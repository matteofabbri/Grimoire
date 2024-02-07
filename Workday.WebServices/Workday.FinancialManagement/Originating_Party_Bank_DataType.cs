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
	public class Originating_Party_Bank_DataType : INotifyPropertyChanged
	{
		private Bank_AccountObjectType[] bank_Account_ReferenceField;

		private string account_NicknameField;

		private string account_NumberField;

		private string account_Type_CodeField;

		private Financial_InstitutionObjectType financial_Institution_ReferenceField;

		private string iBANField;

		private string routing_Transit_NumberField;

		private string bank_Identification_CodeField;

		private string branch_NameField;

		private string branch_ID_NumberField;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string bank_Account_NameField;

		private string check_DigitField;

		private string roll_NumberField;

		private Address_Information_DataType[] bank_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Bank_Account_Reference", Order = 0)]
		public Bank_AccountObjectType[] Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Account_Nickname
		{
			get
			{
				return this.account_NicknameField;
			}
			set
			{
				this.account_NicknameField = value;
				this.RaisePropertyChanged("Account_Nickname");
			}
		}

		[XmlElement(Order = 2)]
		public string Account_Number
		{
			get
			{
				return this.account_NumberField;
			}
			set
			{
				this.account_NumberField = value;
				this.RaisePropertyChanged("Account_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Account_Type_Code
		{
			get
			{
				return this.account_Type_CodeField;
			}
			set
			{
				this.account_Type_CodeField = value;
				this.RaisePropertyChanged("Account_Type_Code");
			}
		}

		[XmlElement(Order = 4)]
		public Financial_InstitutionObjectType Financial_Institution_Reference
		{
			get
			{
				return this.financial_Institution_ReferenceField;
			}
			set
			{
				this.financial_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string IBAN
		{
			get
			{
				return this.iBANField;
			}
			set
			{
				this.iBANField = value;
				this.RaisePropertyChanged("IBAN");
			}
		}

		[XmlElement(Order = 6)]
		public string Routing_Transit_Number
		{
			get
			{
				return this.routing_Transit_NumberField;
			}
			set
			{
				this.routing_Transit_NumberField = value;
				this.RaisePropertyChanged("Routing_Transit_Number");
			}
		}

		[XmlElement(Order = 7)]
		public string Bank_Identification_Code
		{
			get
			{
				return this.bank_Identification_CodeField;
			}
			set
			{
				this.bank_Identification_CodeField = value;
				this.RaisePropertyChanged("Bank_Identification_Code");
			}
		}

		[XmlElement(Order = 8)]
		public string Branch_Name
		{
			get
			{
				return this.branch_NameField;
			}
			set
			{
				this.branch_NameField = value;
				this.RaisePropertyChanged("Branch_Name");
			}
		}

		[XmlElement(Order = 9)]
		public string Branch_ID_Number
		{
			get
			{
				return this.branch_ID_NumberField;
			}
			set
			{
				this.branch_ID_NumberField = value;
				this.RaisePropertyChanged("Branch_ID_Number");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 12)]
		public string Bank_Account_Name
		{
			get
			{
				return this.bank_Account_NameField;
			}
			set
			{
				this.bank_Account_NameField = value;
				this.RaisePropertyChanged("Bank_Account_Name");
			}
		}

		[XmlElement(Order = 13)]
		public string Check_Digit
		{
			get
			{
				return this.check_DigitField;
			}
			set
			{
				this.check_DigitField = value;
				this.RaisePropertyChanged("Check_Digit");
			}
		}

		[XmlElement(Order = 14)]
		public string Roll_Number
		{
			get
			{
				return this.roll_NumberField;
			}
			set
			{
				this.roll_NumberField = value;
				this.RaisePropertyChanged("Roll_Number");
			}
		}

		[XmlElement("Bank_Address_Data", Order = 15)]
		public Address_Information_DataType[] Bank_Address_Data
		{
			get
			{
				return this.bank_Address_DataField;
			}
			set
			{
				this.bank_Address_DataField = value;
				this.RaisePropertyChanged("Bank_Address_Data");
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
