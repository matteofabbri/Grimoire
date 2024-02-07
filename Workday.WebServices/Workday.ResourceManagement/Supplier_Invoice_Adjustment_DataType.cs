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
	public class Supplier_Invoice_Adjustment_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Adjustment_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string invoice_NumberField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private object itemField;

		private object item1Field;

		private bool increase_LiabilityField;

		private bool increase_LiabilityFieldSpecified;

		private Invoice_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private DateTime adjustment_DateField;

		private bool adjustment_DateFieldSpecified;

		private DateTime due_Date_OverrideField;

		private bool due_Date_OverrideFieldSpecified;

		private DateTime accounting_Date_OverrideField;

		private bool accounting_Date_OverrideFieldSpecified;

		private DateTime budget_DateField;

		private bool budget_DateFieldSpecified;

		private Tax_OptionObjectType tax_Option_ReferenceField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_CodeObjectType default_Withholding_Tax_Code_ReferenceField;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal withholding_Tax_AmountField;

		private bool withholding_Tax_AmountFieldSpecified;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal other_ChargesField;

		private bool other_ChargesFieldSpecified;

		private Supplier_InvoiceObjectType original_Invoice_ReferenceField;

		private string original_Invoice_Supplier_Reference_NumberField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType override_Payment_Type_ReferenceField;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private bool supplier_Document_ReceivedField;

		private bool supplier_Document_ReceivedFieldSpecified;

		private string supplier_Reference_NumberField;

		private string external_PO_NumberField;

		private Supplier_Contract_BaseObjectType supplier_Contract_ReferenceField;

		private string document_LinkField;

		private string document_MemoField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private DateTime currency_Rate_Date_OverrideField;

		private bool currency_Rate_Date_OverrideFieldSpecified;

		private decimal currency_Rate_Manual_OverrideField;

		private bool currency_Rate_Manual_OverrideFieldSpecified;

		private decimal document_Currency_Conversion_RateField;

		private bool document_Currency_Conversion_RateFieldSpecified;

		private bool rate_OverrideField;

		private bool rate_OverrideFieldSpecified;

		private decimal currency_Rate_Lookup_OverrideField;

		private bool currency_Rate_Lookup_OverrideFieldSpecified;

		private decimal manual_Override_PercentField;

		private bool manual_Override_PercentFieldSpecified;

		private Currency_Rate_TypeObjectType[] default_Rate_Type_ReferenceField;

		private DateTime rate_Basis_DateField;

		private bool rate_Basis_DateFieldSpecified;

		private decimal default_Currency_RateField;

		private bool default_Currency_RateFieldSpecified;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Supplier_Invoice_Line_Replacement_DataType[] invoice_Line_Replacement_DataField;

		private Taxable_Code_Application_DataType[] tax_Code_DataField;

		private Withholding_Tax_Code_Application_DataType[] withholding_Tax_Code_DataField;

		private Supplier_Invoice_Intercompany_Sub_ProcessType supplier_Invoice_Intercompany_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Adjustment_ID
		{
			get
			{
				return this.supplier_Invoice_Adjustment_IDField;
			}
			set
			{
				this.supplier_Invoice_Adjustment_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Adjustment_ID");
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

		[XmlElement("Supplier_Connection_Reference", typeof(Supplier_ConnectionObjectType), Order = 7), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 7)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 8)]
		public bool Increase_Liability
		{
			get
			{
				return this.increase_LiabilityField;
			}
			set
			{
				this.increase_LiabilityField = value;
				this.RaisePropertyChanged("Increase_Liability");
			}
		}

		[XmlIgnore]
		public bool Increase_LiabilitySpecified
		{
			get
			{
				return this.increase_LiabilityFieldSpecified;
			}
			set
			{
				this.increase_LiabilityFieldSpecified = value;
				this.RaisePropertyChanged("Increase_LiabilitySpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Invoice_Adjustment_ReasonObjectType Adjustment_Reason_Reference
		{
			get
			{
				return this.adjustment_Reason_ReferenceField;
			}
			set
			{
				this.adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Adjustment_Date
		{
			get
			{
				return this.adjustment_DateField;
			}
			set
			{
				this.adjustment_DateField = value;
				this.RaisePropertyChanged("Adjustment_Date");
			}
		}

		[XmlIgnore]
		public bool Adjustment_DateSpecified
		{
			get
			{
				return this.adjustment_DateFieldSpecified;
			}
			set
			{
				this.adjustment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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
		public decimal Withholding_Tax_Amount
		{
			get
			{
				return this.withholding_Tax_AmountField;
			}
			set
			{
				this.withholding_Tax_AmountField = value;
				this.RaisePropertyChanged("Withholding_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Withholding_Tax_AmountSpecified
		{
			get
			{
				return this.withholding_Tax_AmountFieldSpecified;
			}
			set
			{
				this.withholding_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public Supplier_InvoiceObjectType Original_Invoice_Reference
		{
			get
			{
				return this.original_Invoice_ReferenceField;
			}
			set
			{
				this.original_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Original_Invoice_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public string Original_Invoice_Supplier_Reference_Number
		{
			get
			{
				return this.original_Invoice_Supplier_Reference_NumberField;
			}
			set
			{
				this.original_Invoice_Supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Original_Invoice_Supplier_Reference_Number");
			}
		}

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
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

		[XmlElement(Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
		public string Document_Memo
		{
			get
			{
				return this.document_MemoField;
			}
			set
			{
				this.document_MemoField = value;
				this.RaisePropertyChanged("Document_Memo");
			}
		}

		[XmlElement(Order = 35)]
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

		[XmlElement(DataType = "date", Order = 36)]
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

		[XmlElement(Order = 37)]
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

		[XmlElement(Order = 38)]
		public decimal Document_Currency_Conversion_Rate
		{
			get
			{
				return this.document_Currency_Conversion_RateField;
			}
			set
			{
				this.document_Currency_Conversion_RateField = value;
				this.RaisePropertyChanged("Document_Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool Document_Currency_Conversion_RateSpecified
		{
			get
			{
				return this.document_Currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.document_Currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("Document_Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool Rate_Override
		{
			get
			{
				return this.rate_OverrideField;
			}
			set
			{
				this.rate_OverrideField = value;
				this.RaisePropertyChanged("Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Rate_OverrideSpecified
		{
			get
			{
				return this.rate_OverrideFieldSpecified;
			}
			set
			{
				this.rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public decimal Currency_Rate_Lookup_Override
		{
			get
			{
				return this.currency_Rate_Lookup_OverrideField;
			}
			set
			{
				this.currency_Rate_Lookup_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Lookup_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Lookup_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Lookup_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Lookup_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Lookup_OverrideSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public decimal Manual_Override_Percent
		{
			get
			{
				return this.manual_Override_PercentField;
			}
			set
			{
				this.manual_Override_PercentField = value;
				this.RaisePropertyChanged("Manual_Override_Percent");
			}
		}

		[XmlIgnore]
		public bool Manual_Override_PercentSpecified
		{
			get
			{
				return this.manual_Override_PercentFieldSpecified;
			}
			set
			{
				this.manual_Override_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Manual_Override_PercentSpecified");
			}
		}

		[XmlElement("Default_Rate_Type_Reference", Order = 42)]
		public Currency_Rate_TypeObjectType[] Default_Rate_Type_Reference
		{
			get
			{
				return this.default_Rate_Type_ReferenceField;
			}
			set
			{
				this.default_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Rate_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 43)]
		public DateTime Rate_Basis_Date
		{
			get
			{
				return this.rate_Basis_DateField;
			}
			set
			{
				this.rate_Basis_DateField = value;
				this.RaisePropertyChanged("Rate_Basis_Date");
			}
		}

		[XmlIgnore]
		public bool Rate_Basis_DateSpecified
		{
			get
			{
				return this.rate_Basis_DateFieldSpecified;
			}
			set
			{
				this.rate_Basis_DateFieldSpecified = value;
				this.RaisePropertyChanged("Rate_Basis_DateSpecified");
			}
		}

		[XmlElement(Order = 44)]
		public decimal Default_Currency_Rate
		{
			get
			{
				return this.default_Currency_RateField;
			}
			set
			{
				this.default_Currency_RateField = value;
				this.RaisePropertyChanged("Default_Currency_Rate");
			}
		}

		[XmlIgnore]
		public bool Default_Currency_RateSpecified
		{
			get
			{
				return this.default_Currency_RateFieldSpecified;
			}
			set
			{
				this.default_Currency_RateFieldSpecified = value;
				this.RaisePropertyChanged("Default_Currency_RateSpecified");
			}
		}

		[XmlElement("Attachment_Data", Order = 45)]
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

		[XmlElement("Invoice_Line_Replacement_Data", Order = 46)]
		public Supplier_Invoice_Line_Replacement_DataType[] Invoice_Line_Replacement_Data
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

		[XmlElement("Tax_Code_Data", Order = 47)]
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

		[XmlElement("Withholding_Tax_Code_Data", Order = 48)]
		public Withholding_Tax_Code_Application_DataType[] Withholding_Tax_Code_Data
		{
			get
			{
				return this.withholding_Tax_Code_DataField;
			}
			set
			{
				this.withholding_Tax_Code_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Data");
			}
		}

		[XmlElement(Order = 49)]
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
