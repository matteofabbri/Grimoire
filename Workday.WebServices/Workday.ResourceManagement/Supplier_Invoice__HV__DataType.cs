using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Supplier_Invoice__HV__DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string invoice_NumberField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private object itemField;

		private Supplier_ConnectionObjectType supplier_Connection_ReferenceField;

		private bool use_Default_Supplier_ConnectionField;

		private bool use_Default_Supplier_ConnectionFieldSpecified;

		private Tax_OptionObjectType tax_Option_ReferenceField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_CodeObjectType default_Withholding_Tax_Code_ReferenceField;

		private DateTime invoice_DateField;

		private bool invoice_DateFieldSpecified;

		private DateTime due_Date_OverrideField;

		private bool due_Date_OverrideFieldSpecified;

		private DateTime accounting_Date_OverrideField;

		private bool accounting_Date_OverrideFieldSpecified;

		private DateTime budget_DateField;

		private bool budget_DateFieldSpecified;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal control_Amount_TotalField;

		private bool control_Amount_TotalFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal other_ChargesField;

		private bool other_ChargesFieldSpecified;

		private bool supplier_Document_ReceivedField;

		private bool supplier_Document_ReceivedFieldSpecified;

		private string supplier_Reference_NumberField;

		private string external_PO_NumberField;

		private Supplier_Contract_BaseObjectType supplier_Contract_ReferenceField;

		private string document_LinkField;

		private string memoField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType override_Payment_Type_ReferenceField;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private bool prepaidField;

		private bool prepaidFieldSpecified;

		private Prepaid_Amortization_TypeObjectType prepayment_Release_Type_ReferenceField;

		private DateTime release_DateField;

		private bool release_DateFieldSpecified;

		private Frequency_BehaviorObjectType frequency_ReferenceField;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private bool use_Invoice_DateField;

		private bool use_Invoice_DateFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private string retention_MemoField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private DateTime currency_Rate_Date_OverrideField;

		private bool currency_Rate_Date_OverrideFieldSpecified;

		private decimal currency_Rate_Manual_OverrideField;

		private bool currency_Rate_Manual_OverrideFieldSpecified;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Taxable_Code_Application_DataType[] tax_Code_DataField;

		private Supplier_Invoice_Line_Replacement__HV__DataType[] invoice_Line_Replacement_DataField;

		private Supplier_Invoice_Retention_Release_Line_WWS_DataType[] retention_Release_Line_DataField;

		private Supplier_Invoice_Intercompany_Sub_ProcessType supplier_Invoice_Intercompany_Sub_ProcessField;

		private Supplier_Invoice_Prepaid_Amortization_Schedule_WWS_DataType[] supplier_Invoice_Prepaid_Amortization_ScheduleField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_ID
		{
			get
			{
				return this.supplier_Invoice_IDField;
			}
			set
			{
				this.supplier_Invoice_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_ID");
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

		[XmlElement(Order = 3)]
		public string Invoice_Number
		{
			get
			{
				return this.invoice_NumberField;
			}
			set
			{
				this.invoice_NumberField = value;
				this.RaisePropertyChanged("Invoice_Number");
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

		[XmlElement("Contingent_Worker_Reference", typeof(Contingent_WorkerObjectType), Order = 6), XmlElement("Supplier_Reference", typeof(SupplierObjectType), Order = 6)]
		public object Item
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

		[XmlElement(Order = 7)]
		public Supplier_ConnectionObjectType Supplier_Connection_Reference
		{
			get
			{
				return this.supplier_Connection_ReferenceField;
			}
			set
			{
				this.supplier_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Connection_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Use_Default_Supplier_Connection
		{
			get
			{
				return this.use_Default_Supplier_ConnectionField;
			}
			set
			{
				this.use_Default_Supplier_ConnectionField = value;
				this.RaisePropertyChanged("Use_Default_Supplier_Connection");
			}
		}

		[XmlIgnore]
		public bool Use_Default_Supplier_ConnectionSpecified
		{
			get
			{
				return this.use_Default_Supplier_ConnectionFieldSpecified;
			}
			set
			{
				this.use_Default_Supplier_ConnectionFieldSpecified = value;
				this.RaisePropertyChanged("Use_Default_Supplier_ConnectionSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Tax_OptionObjectType Tax_Option_Reference
		{
			get
			{
				return this.tax_Option_ReferenceField;
			}
			set
			{
				this.tax_Option_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Option_Reference");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 10)]
		public Unique_IdentifierObjectType ShipTo_Address_Reference
		{
			get
			{
				return this.shipTo_Address_ReferenceField;
			}
			set
			{
				this.shipTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Address_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Tax_CodeObjectType Default_Withholding_Tax_Code_Reference
		{
			get
			{
				return this.default_Withholding_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Withholding_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Withholding_Tax_Code_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Invoice_Date
		{
			get
			{
				return this.invoice_DateField;
			}
			set
			{
				this.invoice_DateField = value;
				this.RaisePropertyChanged("Invoice_Date");
			}
		}

		[XmlIgnore]
		public bool Invoice_DateSpecified
		{
			get
			{
				return this.invoice_DateFieldSpecified;
			}
			set
			{
				this.invoice_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Due_Date_Override
		{
			get
			{
				return this.due_Date_OverrideField;
			}
			set
			{
				this.due_Date_OverrideField = value;
				this.RaisePropertyChanged("Due_Date_Override");
			}
		}

		[XmlIgnore]
		public bool Due_Date_OverrideSpecified
		{
			get
			{
				return this.due_Date_OverrideFieldSpecified;
			}
			set
			{
				this.due_Date_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Due_Date_OverrideSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Accounting_Date_Override
		{
			get
			{
				return this.accounting_Date_OverrideField;
			}
			set
			{
				this.accounting_Date_OverrideField = value;
				this.RaisePropertyChanged("Accounting_Date_Override");
			}
		}

		[XmlIgnore]
		public bool Accounting_Date_OverrideSpecified
		{
			get
			{
				return this.accounting_Date_OverrideFieldSpecified;
			}
			set
			{
				this.accounting_Date_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_Date_OverrideSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Budget_Date
		{
			get
			{
				return this.budget_DateField;
			}
			set
			{
				this.budget_DateField = value;
				this.RaisePropertyChanged("Budget_Date");
			}
		}

		[XmlIgnore]
		public bool Budget_DateSpecified
		{
			get
			{
				return this.budget_DateFieldSpecified;
			}
			set
			{
				this.budget_DateFieldSpecified = value;
				this.RaisePropertyChanged("Budget_DateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Control_Amount_Total
		{
			get
			{
				return this.control_Amount_TotalField;
			}
			set
			{
				this.control_Amount_TotalField = value;
				this.RaisePropertyChanged("Control_Amount_Total");
			}
		}

		[XmlIgnore]
		public bool Control_Amount_TotalSpecified
		{
			get
			{
				return this.control_Amount_TotalFieldSpecified;
			}
			set
			{
				this.control_Amount_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Control_Amount_TotalSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Tax_Amount
		{
			get
			{
				return this.tax_AmountField;
			}
			set
			{
				this.tax_AmountField = value;
				this.RaisePropertyChanged("Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Tax_AmountSpecified
		{
			get
			{
				return this.tax_AmountFieldSpecified;
			}
			set
			{
				this.tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Freight_Amount
		{
			get
			{
				return this.freight_AmountField;
			}
			set
			{
				this.freight_AmountField = value;
				this.RaisePropertyChanged("Freight_Amount");
			}
		}

		[XmlIgnore]
		public bool Freight_AmountSpecified
		{
			get
			{
				return this.freight_AmountFieldSpecified;
			}
			set
			{
				this.freight_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Freight_AmountSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Other_Charges
		{
			get
			{
				return this.other_ChargesField;
			}
			set
			{
				this.other_ChargesField = value;
				this.RaisePropertyChanged("Other_Charges");
			}
		}

		[XmlIgnore]
		public bool Other_ChargesSpecified
		{
			get
			{
				return this.other_ChargesFieldSpecified;
			}
			set
			{
				this.other_ChargesFieldSpecified = value;
				this.RaisePropertyChanged("Other_ChargesSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Supplier_Document_Received
		{
			get
			{
				return this.supplier_Document_ReceivedField;
			}
			set
			{
				this.supplier_Document_ReceivedField = value;
				this.RaisePropertyChanged("Supplier_Document_Received");
			}
		}

		[XmlIgnore]
		public bool Supplier_Document_ReceivedSpecified
		{
			get
			{
				return this.supplier_Document_ReceivedFieldSpecified;
			}
			set
			{
				this.supplier_Document_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Supplier_Document_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public string Supplier_Reference_Number
		{
			get
			{
				return this.supplier_Reference_NumberField;
			}
			set
			{
				this.supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Reference_Number");
			}
		}

		[XmlElement(Order = 24)]
		public string External_PO_Number
		{
			get
			{
				return this.external_PO_NumberField;
			}
			set
			{
				this.external_PO_NumberField = value;
				this.RaisePropertyChanged("External_PO_Number");
			}
		}

		[XmlElement(Order = 25)]
		public Supplier_Contract_BaseObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public string Document_Link
		{
			get
			{
				return this.document_LinkField;
			}
			set
			{
				this.document_LinkField = value;
				this.RaisePropertyChanged("Document_Link");
			}
		}

		[XmlElement(Order = 27)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 28)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public Payment_TypeObjectType Override_Payment_Type_Reference
		{
			get
			{
				return this.override_Payment_Type_ReferenceField;
			}
			set
			{
				this.override_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Override_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Payment_Handling_InstructionObjectType Handling_Code_Reference
		{
			get
			{
				return this.handling_Code_ReferenceField;
			}
			set
			{
				this.handling_Code_ReferenceField = value;
				this.RaisePropertyChanged("Handling_Code_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public bool Prepaid
		{
			get
			{
				return this.prepaidField;
			}
			set
			{
				this.prepaidField = value;
				this.RaisePropertyChanged("Prepaid");
			}
		}

		[XmlIgnore]
		public bool PrepaidSpecified
		{
			get
			{
				return this.prepaidFieldSpecified;
			}
			set
			{
				this.prepaidFieldSpecified = value;
				this.RaisePropertyChanged("PrepaidSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public Prepaid_Amortization_TypeObjectType Prepayment_Release_Type_Reference
		{
			get
			{
				return this.prepayment_Release_Type_ReferenceField;
			}
			set
			{
				this.prepayment_Release_Type_ReferenceField = value;
				this.RaisePropertyChanged("Prepayment_Release_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 33)]
		public DateTime Release_Date
		{
			get
			{
				return this.release_DateField;
			}
			set
			{
				this.release_DateField = value;
				this.RaisePropertyChanged("Release_Date");
			}
		}

		[XmlIgnore]
		public bool Release_DateSpecified
		{
			get
			{
				return this.release_DateFieldSpecified;
			}
			set
			{
				this.release_DateFieldSpecified = value;
				this.RaisePropertyChanged("Release_DateSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public Frequency_BehaviorObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public decimal Number_of_Installments
		{
			get
			{
				return this.number_of_InstallmentsField;
			}
			set
			{
				this.number_of_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Installments");
			}
		}

		[XmlIgnore]
		public bool Number_of_InstallmentsSpecified
		{
			get
			{
				return this.number_of_InstallmentsFieldSpecified;
			}
			set
			{
				this.number_of_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public bool Use_Invoice_Date
		{
			get
			{
				return this.use_Invoice_DateField;
			}
			set
			{
				this.use_Invoice_DateField = value;
				this.RaisePropertyChanged("Use_Invoice_Date");
			}
		}

		[XmlIgnore]
		public bool Use_Invoice_DateSpecified
		{
			get
			{
				return this.use_Invoice_DateFieldSpecified;
			}
			set
			{
				this.use_Invoice_DateFieldSpecified = value;
				this.RaisePropertyChanged("Use_Invoice_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 37)]
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

		[XmlElement(Order = 38)]
		public string Retention_Memo
		{
			get
			{
				return this.retention_MemoField;
			}
			set
			{
				this.retention_MemoField = value;
				this.RaisePropertyChanged("Retention_Memo");
			}
		}

		[XmlElement(Order = 39)]
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

		[XmlElement(DataType = "date", Order = 40)]
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

		[XmlElement(Order = 41)]
		public decimal Currency_Rate_Manual_Override
		{
			get
			{
				return this.currency_Rate_Manual_OverrideField;
			}
			set
			{
				this.currency_Rate_Manual_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Manual_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Manual_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Manual_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_OverrideSpecified");
			}
		}

		[XmlElement("Attachment_Data", Order = 42)]
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

		[XmlElement("Tax_Code_Data", Order = 43)]
		public Taxable_Code_Application_DataType[] Tax_Code_Data
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

		[XmlElement("Invoice_Line_Replacement_Data", Order = 44)]
		public Supplier_Invoice_Line_Replacement__HV__DataType[] Invoice_Line_Replacement_Data
		{
			get
			{
				return this.invoice_Line_Replacement_DataField;
			}
			set
			{
				this.invoice_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Invoice_Line_Replacement_Data");
			}
		}

		[XmlElement("Retention_Release_Line_Data", Order = 45)]
		public Supplier_Invoice_Retention_Release_Line_WWS_DataType[] Retention_Release_Line_Data
		{
			get
			{
				return this.retention_Release_Line_DataField;
			}
			set
			{
				this.retention_Release_Line_DataField = value;
				this.RaisePropertyChanged("Retention_Release_Line_Data");
			}
		}

		[XmlElement(Order = 46)]
		public Supplier_Invoice_Intercompany_Sub_ProcessType Supplier_Invoice_Intercompany_Sub_Process
		{
			get
			{
				return this.supplier_Invoice_Intercompany_Sub_ProcessField;
			}
			set
			{
				this.supplier_Invoice_Intercompany_Sub_ProcessField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Intercompany_Sub_Process");
			}
		}

		[XmlElement("Supplier_Invoice_Prepaid_Amortization_Schedule", Order = 47)]
		public Supplier_Invoice_Prepaid_Amortization_Schedule_WWS_DataType[] Supplier_Invoice_Prepaid_Amortization_Schedule
		{
			get
			{
				return this.supplier_Invoice_Prepaid_Amortization_ScheduleField;
			}
			set
			{
				this.supplier_Invoice_Prepaid_Amortization_ScheduleField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Prepaid_Amortization_Schedule");
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
