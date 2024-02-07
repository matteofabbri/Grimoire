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
	public class Intermediary_Bank_Account_WWS_DataType : INotifyPropertyChanged
	{
		private string intermediary_Bank_OrderField;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string bank_Account_NicknameField;

		private Bank_Account_TypeObjectType bank_Account_Type_ReferenceField;

		private string bank_NameField;

		private string routing_Transit_NumberField;

		private string branch_IDField;

		private string branch_NameField;

		private string bank_Account_NumberField;

		private string check_DigitField;

		private string bank_Account_NameField;

		private string roll_NumberField;

		private string iBANField;

		private string sWIFT_Bank_Identification_CodeField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string bank_InstructionsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Intermediary_Bank_Order
		{
			get
			{
				return this.intermediary_Bank_OrderField;
			}
			set
			{
				this.intermediary_Bank_OrderField = value;
				this.RaisePropertyChanged("Intermediary_Bank_Order");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Bank_Account_TypeObjectType Bank_Account_Type_Reference
		{
			get
			{
				return this.bank_Account_Type_ReferenceField;
			}
			set
			{
				this.bank_Account_Type_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
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
		public string Branch_ID
		{
			get
			{
				return this.branch_IDField;
			}
			set
			{
				this.branch_IDField = value;
				this.RaisePropertyChanged("Branch_ID");
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
		public string Bank_Account_Number
		{
			get
			{
				return this.bank_Account_NumberField;
			}
			set
			{
				this.bank_Account_NumberField = value;
				this.RaisePropertyChanged("Bank_Account_Number");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public string SWIFT_Bank_Identification_Code
		{
			get
			{
				return this.sWIFT_Bank_Identification_CodeField;
			}
			set
			{
				this.sWIFT_Bank_Identification_CodeField = value;
				this.RaisePropertyChanged("SWIFT_Bank_Identification_Code");
			}
		}

		[XmlElement(Order = 15)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public string Bank_Instructions
		{
			get
			{
				return this.bank_InstructionsField;
			}
			set
			{
				this.bank_InstructionsField = value;
				this.RaisePropertyChanged("Bank_Instructions");
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
