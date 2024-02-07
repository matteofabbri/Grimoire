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
	public class Supplier_Invoice_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string invoice_NumberField;

		private Document_StatusObjectType invoice_Document_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private object itemField;

		private object item1Field;

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

		private decimal withholding_Tax_AmountField;

		private bool withholding_Tax_AmountFieldSpecified;

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

		private Supplier_Invoice_RequestObjectType supplier_Invoice_Request_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

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

		private decimal gross_Invoice_AmountField;

		private bool gross_Invoice_AmountFieldSpecified;

		private decimal total_Amount_RetainedField;

		private bool total_Amount_RetainedFieldSpecified;

		private decimal total_Amount_ReleasedField;

		private bool total_Amount_ReleasedFieldSpecified;

		private string retention_MemoField;

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

		private Taxable_Code_Application_DataType[] tax_Code_DataField;

		private Withholding_Tax_Code_Application_DataType[] withholding_Tax_Code_DataField;

		private Supplier_Invoice_Line_Replacement_DataType[] invoice_Line_Replacement_DataField;

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
		public Document_StatusObjectType Invoice_Document_Status_Reference
		{
			get
			{
				return this.invoice_Document_Status_ReferenceField;
			}
			set
			{
				this.invoice_Document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Document_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Contingent_Worker_Reference", typeof(Contingent_WorkerObjectType), Order = 7), XmlElement("Supplier_Reference", typeof(SupplierObjectType), Order = 7)]
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

		[XmlElement("Supplier_Connection_Reference", typeof(Supplier_ConnectionObjectType), Order = 8), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 8)]
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

		[XmlElement(Order = 24)]
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

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
		public Supplier_Invoice_RequestObjectType Supplier_Invoice_Request_Reference
		{
			get
			{
				return this.supplier_Invoice_Request_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Request_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 30)]
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

		[XmlElement(Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(DataType = "date", Order = 36)]
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

		[XmlElement(Order = 37)]
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

		[XmlElement(Order = 38)]
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

		[XmlElement(Order = 39)]
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

		[XmlElement(DataType = "date", Order = 40)]
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

		[XmlElement(Order = 41)]
		public decimal Gross_Invoice_Amount
		{
			get
			{
				return this.gross_Invoice_AmountField;
			}
			set
			{
				this.gross_Invoice_AmountField = value;
				this.RaisePropertyChanged("Gross_Invoice_Amount");
			}
		}

		[XmlIgnore]
		public bool Gross_Invoice_AmountSpecified
		{
			get
			{
				return this.gross_Invoice_AmountFieldSpecified;
			}
			set
			{
				this.gross_Invoice_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Gross_Invoice_AmountSpecified");
			}
		}

		[XmlElement(Order = 42)]
		public decimal Total_Amount_Retained
		{
			get
			{
				return this.total_Amount_RetainedField;
			}
			set
			{
				this.total_Amount_RetainedField = value;
				this.RaisePropertyChanged("Total_Amount_Retained");
			}
		}

		[XmlIgnore]
		public bool Total_Amount_RetainedSpecified
		{
			get
			{
				return this.total_Amount_RetainedFieldSpecified;
			}
			set
			{
				this.total_Amount_RetainedFieldSpecified = value;
				this.RaisePropertyChanged("Total_Amount_RetainedSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public decimal Total_Amount_Released
		{
			get
			{
				return this.total_Amount_ReleasedField;
			}
			set
			{
				this.total_Amount_ReleasedField = value;
				this.RaisePropertyChanged("Total_Amount_Released");
			}
		}

		[XmlIgnore]
		public bool Total_Amount_ReleasedSpecified
		{
			get
			{
				return this.total_Amount_ReleasedFieldSpecified;
			}
			set
			{
				this.total_Amount_ReleasedFieldSpecified = value;
				this.RaisePropertyChanged("Total_Amount_ReleasedSpecified");
			}
		}

		[XmlElement(Order = 44)]
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

		[XmlElement(Order = 45)]
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

		[XmlElement(DataType = "date", Order = 46)]
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

		[XmlElement(Order = 47)]
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

		[XmlElement(Order = 48)]
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

		[XmlElement(Order = 49)]
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

		[XmlElement(Order = 50)]
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

		[XmlElement(Order = 51)]
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

		[XmlElement("Default_Rate_Type_Reference", Order = 52)]
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

		[XmlElement(DataType = "date", Order = 53)]
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

		[XmlElement(Order = 54)]
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

		[XmlElement("Attachment_Data", Order = 55)]
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

		[XmlElement("Tax_Code_Data", Order = 56)]
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

		[XmlElement("Withholding_Tax_Code_Data", Order = 57)]
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

		[XmlElement("Invoice_Line_Replacement_Data", Order = 58)]
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

		[XmlElement("Retention_Release_Line_Data", Order = 59)]
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

		[XmlElement(Order = 60)]
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

		[XmlElement("Supplier_Invoice_Prepaid_Amortization_Schedule", Order = 61)]
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
