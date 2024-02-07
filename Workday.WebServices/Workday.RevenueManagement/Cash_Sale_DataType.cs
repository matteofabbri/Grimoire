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
	public class Cash_Sale_DataType : INotifyPropertyChanged
	{
		private string cash_Sale_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private string cash_Sale_NumberField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private DateTime cash_Sale_DateField;

		private Customer_Invoice_TypeObjectType customer_Invoice_Type_ReferenceField;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string check_NumberField;

		private bool record_DepositField;

		private bool record_DepositFieldSpecified;

		private Financial_AccountObjectType bank_Account_ReferenceField;

		private string deposit_Reference_NumberField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private decimal currency_Rate_OverrideField;

		private bool currency_Rate_OverrideFieldSpecified;

		private string payment_MemoField;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private Customer_Invoice_Line_WWS_DataType[] cash_Sale_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Taxable_Code_Application_NO_INPUT_DataType[] tax_Code_DataField;

		private Cash_Sale_Intercompany_Sub_ProcessType cash_Sale_Intercompany_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Cash_Sale_ID
		{
			get
			{
				return this.cash_Sale_IDField;
			}
			set
			{
				this.cash_Sale_IDField = value;
				this.RaisePropertyChanged("Cash_Sale_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Cash_Sale_Number
		{
			get
			{
				return this.cash_Sale_NumberField;
			}
			set
			{
				this.cash_Sale_NumberField = value;
				this.RaisePropertyChanged("Cash_Sale_Number");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Billable_EntityObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Cash_Sale_Date
		{
			get
			{
				return this.cash_Sale_DateField;
			}
			set
			{
				this.cash_Sale_DateField = value;
				this.RaisePropertyChanged("Cash_Sale_Date");
			}
		}

		[XmlElement(Order = 9)]
		public Customer_Invoice_TypeObjectType Customer_Invoice_Type_Reference
		{
			get
			{
				return this.customer_Invoice_Type_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Type_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Record_Deposit
		{
			get
			{
				return this.record_DepositField;
			}
			set
			{
				this.record_DepositField = value;
				this.RaisePropertyChanged("Record_Deposit");
			}
		}

		[XmlIgnore]
		public bool Record_DepositSpecified
		{
			get
			{
				return this.record_DepositFieldSpecified;
			}
			set
			{
				this.record_DepositFieldSpecified = value;
				this.RaisePropertyChanged("Record_DepositSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Financial_AccountObjectType Bank_Account_Reference
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

		[XmlElement(Order = 16)]
		public string Deposit_Reference_Number
		{
			get
			{
				return this.deposit_Reference_NumberField;
			}
			set
			{
				this.deposit_Reference_NumberField = value;
				this.RaisePropertyChanged("Deposit_Reference_Number");
			}
		}

		[XmlElement(Order = 17)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Currency_Rate_Override
		{
			get
			{
				return this.currency_Rate_OverrideField;
			}
			set
			{
				this.currency_Rate_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public decimal Control_Total_Amount
		{
			get
			{
				return this.control_Total_AmountField;
			}
			set
			{
				this.control_Total_AmountField = value;
				this.RaisePropertyChanged("Control_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Control_Total_AmountSpecified
		{
			get
			{
				return this.control_Total_AmountFieldSpecified;
			}
			set
			{
				this.control_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Control_Total_AmountSpecified");
			}
		}

		[XmlElement("Cash_Sale_Line_Replacement_Data", Order = 21)]
		public Customer_Invoice_Line_WWS_DataType[] Cash_Sale_Line_Replacement_Data
		{
			get
			{
				return this.cash_Sale_Line_Replacement_DataField;
			}
			set
			{
				this.cash_Sale_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Cash_Sale_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 22)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Tax_Code_Data", Order = 23)]
		public Taxable_Code_Application_NO_INPUT_DataType[] Tax_Code_Data
		{
			get
			{
				return this.tax_Code_DataField;
			}
			set
			{
				this.tax_Code_DataField = value;
				this.RaisePropertyChanged("Tax_Code_Data");
			}
		}

		[XmlElement(Order = 24)]
		public Cash_Sale_Intercompany_Sub_ProcessType Cash_Sale_Intercompany_Sub_Process
		{
			get
			{
				return this.cash_Sale_Intercompany_Sub_ProcessField;
			}
			set
			{
				this.cash_Sale_Intercompany_Sub_ProcessField = value;
				this.RaisePropertyChanged("Cash_Sale_Intercompany_Sub_Process");
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
