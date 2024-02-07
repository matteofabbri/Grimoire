using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Bank_Account_WWS_DataType : INotifyPropertyChanged
	{
		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string bank_Account_NicknameField;

		private string bank_Account_NameField;

		private string account_NumberField;

		private string roll_NumberField;

		private string account_Type_CodeField;

		private Bank_Account_TypeObjectType account_Type_ReferenceField;

		private string bank_NameField;

		private string iBANField;

		private string bank_ID_NumberField;

		private string bICField;

		private string branch_NameField;

		private string branch_ID_NumberField;

		private string check_DigitField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Bank_Account_Nickname
		{
			get
			{
				return this.bank_Account_NicknameField;
			}
			set
			{
				this.bank_Account_NicknameField = value;
				this.RaisePropertyChanged("Bank_Account_Nickname");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Bank_Account_TypeObjectType Account_Type_Reference
		{
			get
			{
				return this.account_Type_ReferenceField;
			}
			set
			{
				this.account_Type_ReferenceField = value;
				this.RaisePropertyChanged("Account_Type_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Bank_Name
		{
			get
			{
				return this.bank_NameField;
			}
			set
			{
				this.bank_NameField = value;
				this.RaisePropertyChanged("Bank_Name");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Bank_ID_Number
		{
			get
			{
				return this.bank_ID_NumberField;
			}
			set
			{
				this.bank_ID_NumberField = value;
				this.RaisePropertyChanged("Bank_ID_Number");
			}
		}

		[XmlElement(Order = 11)]
		public string BIC
		{
			get
			{
				return this.bICField;
			}
			set
			{
				this.bICField = value;
				this.RaisePropertyChanged("BIC");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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
