using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Receiving_Party_Bank_DataType : INotifyPropertyChanged
	{
		private string bank_Account_NicknameField;

		private string account_NumberField;

		private string masked_Account_NumberField;

		private string account_TypeField;

		private string bank_NameField;

		private string iBANField;

		private string bank_ID_NumberField;

		private string bICField;

		private string branch_NameField;

		private string branch_ID_NumberField;

		private CountryObjectType country_ReferenceField;

		private InstanceObjectType currency_ReferenceField;

		private string bank_Account_NameField;

		private string check_DigitField;

		private string roll_NumberField;

		private string bank_InstructionsField;

		private Intermediary_Bank_Account_WWS_DataType[] intermediary_Bank_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Masked_Account_Number
		{
			get
			{
				return this.masked_Account_NumberField;
			}
			set
			{
				this.masked_Account_NumberField = value;
				this.RaisePropertyChanged("Masked_Account_Number");
			}
		}

		[XmlElement(Order = 3)]
		public string Account_Type
		{
			get
			{
				return this.account_TypeField;
			}
			set
			{
				this.account_TypeField = value;
				this.RaisePropertyChanged("Account_Type");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 7)]
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
		public InstanceObjectType Currency_Reference
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

		[XmlElement(Order = 15)]
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

		[XmlElement("Intermediary_Bank_Data", Order = 16)]
		public Intermediary_Bank_Account_WWS_DataType[] Intermediary_Bank_Data
		{
			get
			{
				return this.intermediary_Bank_DataField;
			}
			set
			{
				this.intermediary_Bank_DataField = value;
				this.RaisePropertyChanged("Intermediary_Bank_Data");
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
