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
	public class Customer_Payment_for_Invoices_WWS_DataType : INotifyPropertyChanged
	{
		private string customer_Payment_for_Invoices_Reference_IDField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType payment_Currency_ReferenceField;

		private DateTime payment_DateField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string payment_StatusField;

		private string payment_Application_StatusField;

		private string payment_NumberField;

		private decimal payment_AmountField;

		private Billable_EntityObjectType remitfrom_Customer_ReferenceField;

		private string check_NumberField;

		private string payment_MemoField;

		private bool ready_to_AutoApplyField;

		private bool ready_to_AutoApplyFieldSpecified;

		private CurrencyObjectType invoice_Currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private DateTime currency_Rate_Date_OverrideField;

		private bool currency_Rate_Date_OverrideFieldSpecified;

		private decimal currency_Rate_Manual_Override_ReferenceField;

		private bool currency_Rate_Manual_Override_ReferenceFieldSpecified;

		private string electronic_File_InformationField;

		private Customer_DepositObjectType customer_Deposit_ReferenceField;

		private bool do_Not_Apply_Payment_to_Invoices_on_HoldField;

		private bool do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified;

		private bool show_Only_Matched_Invoices_when_ApplyingField;

		private bool show_Only_Matched_Invoices_when_ApplyingFieldSpecified;

		private Customer_Payment_Remittance_Advice_WWS_DataType[] customer_Payment_Remittance_Advice_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Payment_for_Invoices_Reference_ID
		{
			get
			{
				return this.customer_Payment_for_Invoices_Reference_IDField;
			}
			set
			{
				this.customer_Payment_for_Invoices_Reference_IDField = value;
				this.RaisePropertyChanged("Customer_Payment_for_Invoices_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Payment_Currency_Reference
		{
			get
			{
				return this.payment_Currency_ReferenceField;
			}
			set
			{
				this.payment_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Currency_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlElement(Order = 5)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Payment_Status
		{
			get
			{
				return this.payment_StatusField;
			}
			set
			{
				this.payment_StatusField = value;
				this.RaisePropertyChanged("Payment_Status");
			}
		}

		[XmlElement(Order = 7)]
		public string Payment_Application_Status
		{
			get
			{
				return this.payment_Application_StatusField;
			}
			set
			{
				this.payment_Application_StatusField = value;
				this.RaisePropertyChanged("Payment_Application_Status");
			}
		}

		[XmlElement(Order = 8)]
		public string Payment_Number
		{
			get
			{
				return this.payment_NumberField;
			}
			set
			{
				this.payment_NumberField = value;
				this.RaisePropertyChanged("Payment_Number");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Payment_Amount
		{
			get
			{
				return this.payment_AmountField;
			}
			set
			{
				this.payment_AmountField = value;
				this.RaisePropertyChanged("Payment_Amount");
			}
		}

		[XmlElement("Remit-from_Customer_Reference", Order = 10)]
		public Billable_EntityObjectType Remitfrom_Customer_Reference
		{
			get
			{
				return this.remitfrom_Customer_ReferenceField;
			}
			set
			{
				this.remitfrom_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Remitfrom_Customer_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Check_Number
		{
			get
			{
				return this.check_NumberField;
			}
			set
			{
				this.check_NumberField = value;
				this.RaisePropertyChanged("Check_Number");
			}
		}

		[XmlElement(Order = 12)]
		public string Payment_Memo
		{
			get
			{
				return this.payment_MemoField;
			}
			set
			{
				this.payment_MemoField = value;
				this.RaisePropertyChanged("Payment_Memo");
			}
		}

		[XmlElement("Ready_to_Auto-Apply", Order = 13)]
		public bool Ready_to_AutoApply
		{
			get
			{
				return this.ready_to_AutoApplyField;
			}
			set
			{
				this.ready_to_AutoApplyField = value;
				this.RaisePropertyChanged("Ready_to_AutoApply");
			}
		}

		[XmlIgnore]
		public bool Ready_to_AutoApplySpecified
		{
			get
			{
				return this.ready_to_AutoApplyFieldSpecified;
			}
			set
			{
				this.ready_to_AutoApplyFieldSpecified = value;
				this.RaisePropertyChanged("Ready_to_AutoApplySpecified");
			}
		}

		[XmlElement(Order = 14)]
		public CurrencyObjectType Invoice_Currency_Reference
		{
			get
			{
				return this.invoice_Currency_ReferenceField;
			}
			set
			{
				this.invoice_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Currency_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Currency_Rate_Date_Override
		{
			get
			{
				return this.currency_Rate_Date_OverrideField;
			}
			set
			{
				this.currency_Rate_Date_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Date_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Date_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Date_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Date_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Date_OverrideSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Currency_Rate_Manual_Override_Reference
		{
			get
			{
				return this.currency_Rate_Manual_Override_ReferenceField;
			}
			set
			{
				this.currency_Rate_Manual_Override_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_Override_Reference");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Manual_Override_ReferenceSpecified
		{
			get
			{
				return this.currency_Rate_Manual_Override_ReferenceFieldSpecified;
			}
			set
			{
				this.currency_Rate_Manual_Override_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_Override_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public string Electronic_File_Information
		{
			get
			{
				return this.electronic_File_InformationField;
			}
			set
			{
				this.electronic_File_InformationField = value;
				this.RaisePropertyChanged("Electronic_File_Information");
			}
		}

		[XmlElement(Order = 19)]
		public Customer_DepositObjectType Customer_Deposit_Reference
		{
			get
			{
				return this.customer_Deposit_ReferenceField;
			}
			set
			{
				this.customer_Deposit_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Deposit_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public bool Do_Not_Apply_Payment_to_Invoices_on_Hold
		{
			get
			{
				return this.do_Not_Apply_Payment_to_Invoices_on_HoldField;
			}
			set
			{
				this.do_Not_Apply_Payment_to_Invoices_on_HoldField = value;
				this.RaisePropertyChanged("Do_Not_Apply_Payment_to_Invoices_on_Hold");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Apply_Payment_to_Invoices_on_HoldSpecified
		{
			get
			{
				return this.do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified;
			}
			set
			{
				this.do_Not_Apply_Payment_to_Invoices_on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Apply_Payment_to_Invoices_on_HoldSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Show_Only_Matched_Invoices_when_Applying
		{
			get
			{
				return this.show_Only_Matched_Invoices_when_ApplyingField;
			}
			set
			{
				this.show_Only_Matched_Invoices_when_ApplyingField = value;
				this.RaisePropertyChanged("Show_Only_Matched_Invoices_when_Applying");
			}
		}

		[XmlIgnore]
		public bool Show_Only_Matched_Invoices_when_ApplyingSpecified
		{
			get
			{
				return this.show_Only_Matched_Invoices_when_ApplyingFieldSpecified;
			}
			set
			{
				this.show_Only_Matched_Invoices_when_ApplyingFieldSpecified = value;
				this.RaisePropertyChanged("Show_Only_Matched_Invoices_when_ApplyingSpecified");
			}
		}

		[XmlElement("Customer_Payment_Remittance_Advice_Data", Order = 22)]
		public Customer_Payment_Remittance_Advice_WWS_DataType[] Customer_Payment_Remittance_Advice_Data
		{
			get
			{
				return this.customer_Payment_Remittance_Advice_DataField;
			}
			set
			{
				this.customer_Payment_Remittance_Advice_DataField = value;
				this.RaisePropertyChanged("Customer_Payment_Remittance_Advice_Data");
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
