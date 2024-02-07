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
	public class Settlement_Account_WWS_DataType : INotifyPropertyChanged
	{
		private string settlement_Bank_Account_IDField;

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

		private Payment_TypeObjectType[] accepts_Payment_Types_ReferenceField;

		private Payment_TypeObjectType[] payment_Types_ReferenceField;

		private bool for_Supplier_Connections_OnlyField;

		private bool for_Supplier_Connections_OnlyFieldSpecified;

		private bool requires_PrenoteField;

		private bool requires_PrenoteFieldSpecified;

		private Payment_TypeObjectType payment_Type_Prenote_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string bank_InstructionsField;

		private Intermediary_Bank_Account_WWS_DataType[] intermediary_Bank_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Settlement_Bank_Account_ID
		{
			get
			{
				return this.settlement_Bank_Account_IDField;
			}
			set
			{
				this.settlement_Bank_Account_IDField = value;
				this.RaisePropertyChanged("Settlement_Bank_Account_ID");
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

		[XmlElement("Accepts_Payment_Types_Reference", Order = 15)]
		public Payment_TypeObjectType[] Accepts_Payment_Types_Reference
		{
			get
			{
				return this.accepts_Payment_Types_ReferenceField;
			}
			set
			{
				this.accepts_Payment_Types_ReferenceField = value;
				this.RaisePropertyChanged("Accepts_Payment_Types_Reference");
			}
		}

		[XmlElement("Payment_Types_Reference", Order = 16)]
		public Payment_TypeObjectType[] Payment_Types_Reference
		{
			get
			{
				return this.payment_Types_ReferenceField;
			}
			set
			{
				this.payment_Types_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Types_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public bool For_Supplier_Connections_Only
		{
			get
			{
				return this.for_Supplier_Connections_OnlyField;
			}
			set
			{
				this.for_Supplier_Connections_OnlyField = value;
				this.RaisePropertyChanged("For_Supplier_Connections_Only");
			}
		}

		[XmlIgnore]
		public bool For_Supplier_Connections_OnlySpecified
		{
			get
			{
				return this.for_Supplier_Connections_OnlyFieldSpecified;
			}
			set
			{
				this.for_Supplier_Connections_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("For_Supplier_Connections_OnlySpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Requires_Prenote
		{
			get
			{
				return this.requires_PrenoteField;
			}
			set
			{
				this.requires_PrenoteField = value;
				this.RaisePropertyChanged("Requires_Prenote");
			}
		}

		[XmlIgnore]
		public bool Requires_PrenoteSpecified
		{
			get
			{
				return this.requires_PrenoteFieldSpecified;
			}
			set
			{
				this.requires_PrenoteFieldSpecified = value;
				this.RaisePropertyChanged("Requires_PrenoteSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public Payment_TypeObjectType Payment_Type_Prenote_Reference
		{
			get
			{
				return this.payment_Type_Prenote_ReferenceField;
			}
			set
			{
				this.payment_Type_Prenote_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Prenote_Reference");
			}
		}

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
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

		[XmlElement("Intermediary_Bank_Data", Order = 22)]
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
