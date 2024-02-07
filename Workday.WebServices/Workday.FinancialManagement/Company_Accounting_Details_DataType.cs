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
	public class Company_Accounting_Details_DataType : INotifyPropertyChanged
	{
		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private Fiscal_ScheduleObjectType fiscal_Schedule_ReferenceField;

		private Fiscal_ScheduleObjectType[] alternate_Fiscal_Schedule_ReferenceField;

		private Account_SetObjectType account_Set_ReferenceField;

		private Account_SetObjectType alternate_Account_Set_ReferenceField;

		private Account_SetObjectType default_Account_Set_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Account_Control_Rule_SetObjectType account_Control_Rule_Set_ReferenceField;

		private Account_Posting_Rule_SetObjectType account_Posting_Rule_Set_ReferenceField;

		private Account_Translation_Rule_SetObjectType account_Translation_Rule_Set_ReferenceField;

		private bool itemField;

		private ItemChoiceType2 itemElementNameField;

		private BookObjectType default_Reporting_Book_ReferenceField;

		private Average_Daily_Balance_RuleObjectType average_Daily_Balance_Rule_ReferenceField;

		private DateTime average_Daily_Balance_Start_DateField;

		private bool average_Daily_Balance_Start_DateFieldSpecified;

		private Tax_OptionObjectType procurement_Tax_Option_ReferenceField;

		private bool use_Third_Party_Tax_ServiceField;

		private bool use_Third_Party_Tax_ServiceFieldSpecified;

		private string tax_Service_NameField;

		private bool allow_Invoice_Accounting_in_ArrearsField;

		private bool allow_Invoice_Accounting_in_ArrearsFieldSpecified;

		private Operational_Transaction_Type_for_Period_CloseObjectType[] allow_Accounting_in_Arrears_ReferenceField;

		private bool accounting_Date_RequiredField;

		private bool accounting_Date_RequiredFieldSpecified;

		private CurrencyObjectType[] translation_Currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Override_Reference
		{
			get
			{
				return this.currency_Rate_Type_Override_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_Override_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Override_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Fiscal_ScheduleObjectType Fiscal_Schedule_Reference
		{
			get
			{
				return this.fiscal_Schedule_ReferenceField;
			}
			set
			{
				this.fiscal_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Schedule_Reference");
			}
		}

		[XmlElement("Alternate_Fiscal_Schedule_Reference", Order = 2)]
		public Fiscal_ScheduleObjectType[] Alternate_Fiscal_Schedule_Reference
		{
			get
			{
				return this.alternate_Fiscal_Schedule_ReferenceField;
			}
			set
			{
				this.alternate_Fiscal_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Fiscal_Schedule_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Account_SetObjectType Account_Set_Reference
		{
			get
			{
				return this.account_Set_ReferenceField;
			}
			set
			{
				this.account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Set_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Account_SetObjectType Alternate_Account_Set_Reference
		{
			get
			{
				return this.alternate_Account_Set_ReferenceField;
			}
			set
			{
				this.alternate_Account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Account_SetObjectType Default_Account_Set_Reference
		{
			get
			{
				return this.default_Account_Set_ReferenceField;
			}
			set
			{
				this.default_Account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Default_Account_Set_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Account_Control_Rule_SetObjectType Account_Control_Rule_Set_Reference
		{
			get
			{
				return this.account_Control_Rule_Set_ReferenceField;
			}
			set
			{
				this.account_Control_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Control_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Account_Posting_Rule_SetObjectType Account_Posting_Rule_Set_Reference
		{
			get
			{
				return this.account_Posting_Rule_Set_ReferenceField;
			}
			set
			{
				this.account_Posting_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Posting_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Account_Translation_Rule_SetObjectType Account_Translation_Rule_Set_Reference
		{
			get
			{
				return this.account_Translation_Rule_Set_ReferenceField;
			}
			set
			{
				this.account_Translation_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Translation_Rule_Set_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Keep_Debit_Credit_and_Reverse_Sign", typeof(bool), Order = 10), XmlElement("Reverse_Debit_Credit", typeof(bool), Order = 10)]
		public bool Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 11), XmlIgnore]
		public ItemChoiceType2 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 12)]
		public BookObjectType Default_Reporting_Book_Reference
		{
			get
			{
				return this.default_Reporting_Book_ReferenceField;
			}
			set
			{
				this.default_Reporting_Book_ReferenceField = value;
				this.RaisePropertyChanged("Default_Reporting_Book_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Average_Daily_Balance_RuleObjectType Average_Daily_Balance_Rule_Reference
		{
			get
			{
				return this.average_Daily_Balance_Rule_ReferenceField;
			}
			set
			{
				this.average_Daily_Balance_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Average_Daily_Balance_Rule_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Average_Daily_Balance_Start_Date
		{
			get
			{
				return this.average_Daily_Balance_Start_DateField;
			}
			set
			{
				this.average_Daily_Balance_Start_DateField = value;
				this.RaisePropertyChanged("Average_Daily_Balance_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Average_Daily_Balance_Start_DateSpecified
		{
			get
			{
				return this.average_Daily_Balance_Start_DateFieldSpecified;
			}
			set
			{
				this.average_Daily_Balance_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Average_Daily_Balance_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Tax_OptionObjectType Procurement_Tax_Option_Reference
		{
			get
			{
				return this.procurement_Tax_Option_ReferenceField;
			}
			set
			{
				this.procurement_Tax_Option_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Tax_Option_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public bool Use_Third_Party_Tax_Service
		{
			get
			{
				return this.use_Third_Party_Tax_ServiceField;
			}
			set
			{
				this.use_Third_Party_Tax_ServiceField = value;
				this.RaisePropertyChanged("Use_Third_Party_Tax_Service");
			}
		}

		[XmlIgnore]
		public bool Use_Third_Party_Tax_ServiceSpecified
		{
			get
			{
				return this.use_Third_Party_Tax_ServiceFieldSpecified;
			}
			set
			{
				this.use_Third_Party_Tax_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Use_Third_Party_Tax_ServiceSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public string Tax_Service_Name
		{
			get
			{
				return this.tax_Service_NameField;
			}
			set
			{
				this.tax_Service_NameField = value;
				this.RaisePropertyChanged("Tax_Service_Name");
			}
		}

		[XmlElement(Order = 18)]
		public bool Allow_Invoice_Accounting_in_Arrears
		{
			get
			{
				return this.allow_Invoice_Accounting_in_ArrearsField;
			}
			set
			{
				this.allow_Invoice_Accounting_in_ArrearsField = value;
				this.RaisePropertyChanged("Allow_Invoice_Accounting_in_Arrears");
			}
		}

		[XmlIgnore]
		public bool Allow_Invoice_Accounting_in_ArrearsSpecified
		{
			get
			{
				return this.allow_Invoice_Accounting_in_ArrearsFieldSpecified;
			}
			set
			{
				this.allow_Invoice_Accounting_in_ArrearsFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Invoice_Accounting_in_ArrearsSpecified");
			}
		}

		[XmlElement("Allow_Accounting_in_Arrears_Reference", Order = 19)]
		public Operational_Transaction_Type_for_Period_CloseObjectType[] Allow_Accounting_in_Arrears_Reference
		{
			get
			{
				return this.allow_Accounting_in_Arrears_ReferenceField;
			}
			set
			{
				this.allow_Accounting_in_Arrears_ReferenceField = value;
				this.RaisePropertyChanged("Allow_Accounting_in_Arrears_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public bool Accounting_Date_Required
		{
			get
			{
				return this.accounting_Date_RequiredField;
			}
			set
			{
				this.accounting_Date_RequiredField = value;
				this.RaisePropertyChanged("Accounting_Date_Required");
			}
		}

		[XmlIgnore]
		public bool Accounting_Date_RequiredSpecified
		{
			get
			{
				return this.accounting_Date_RequiredFieldSpecified;
			}
			set
			{
				this.accounting_Date_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_Date_RequiredSpecified");
			}
		}

		[XmlElement("Translation_Currency_Reference", Order = 21)]
		public CurrencyObjectType[] Translation_Currency_Reference
		{
			get
			{
				return this.translation_Currency_ReferenceField;
			}
			set
			{
				this.translation_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Translation_Currency_Reference");
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
