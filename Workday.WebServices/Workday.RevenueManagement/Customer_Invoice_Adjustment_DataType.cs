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
	public class Customer_Invoice_Adjustment_DataType : INotifyPropertyChanged
	{
		private string customer_Invoice_Adjustment_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string invoice_NumberField;

		private CompanyObjectType company_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private Billable_EntityObjectType sold_To_Customer_ReferenceField;

		private bool populate_with_Default_Bill_To_ContactsField;

		private bool populate_with_Default_Bill_To_ContactsFieldSpecified;

		private Business_Entity_ContactObjectType[] bill_To_Contact_ReferenceField;

		private Address_ReferenceObjectType bill_To_Address_ReferenceField;

		private Address_Information_DataType[] bill_To_Address_DataField;

		private CustomerObjectType ship_To_Customer_ReferenceField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private Address_DataType[] ship_To_Address_DataField;

		private ProjectObjectType billable_Project_ReferenceField;

		private Invoice_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private bool increase_Amount_DueField;

		private bool increase_Amount_DueFieldSpecified;

		private Customer_InvoiceObjectType original_Customer_Invoice_ReferenceField;

		private bool autoApply_Adjustment_to_InvoiceField;

		private bool autoApply_Adjustment_to_InvoiceFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime adjustment_DateField;

		private bool adjustment_DateFieldSpecified;

		private DateTime accounting_DateField;

		private bool accounting_DateFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private DateTime due_Date_OverrideField;

		private bool due_Date_OverrideFieldSpecified;

		private DateTime collection_DateField;

		private bool collection_DateFieldSpecified;

		private decimal payment_Amount_PromisedField;

		private bool payment_Amount_PromisedFieldSpecified;

		private Collection_CodeObjectType collection_Reason_ReferenceField;

		private DateTime followup_DateField;

		private bool followup_DateFieldSpecified;

		private DateTime dispute_DateField;

		private bool dispute_DateFieldSpecified;

		private decimal dispute_AmountField;

		private bool dispute_AmountFieldSpecified;

		private Dispute_ReasonObjectType[] dispute_Reason_ReferenceField;

		private decimal control_Amount_TotalField;

		private bool control_Amount_TotalFieldSpecified;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private string payment_StatusField;

		private string document_StatusField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Customer_Invoice_TypeObjectType customer_Invoice_Type_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Unique_IdentifierObjectType company_Tax_ID_ReferenceField;

		private Unique_IdentifierObjectType customer_Tax_ID_ReferenceField;

		private string customer_PO_NumberField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private bool include_Customer_WorktagsField;

		private bool include_Customer_WorktagsFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string document_LinkField;

		private string memoField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private DateTime currency_Rate_Date_OverrideField;

		private bool currency_Rate_Date_OverrideFieldSpecified;

		private decimal currency_Rate_Manual_Override_ReferenceField;

		private bool currency_Rate_Manual_Override_ReferenceFieldSpecified;

		private string tax_Calculation_DetailsField;

		private SEPA_MandateObjectType sEPA_Mandate_ReferenceField;

		private DateTime prenotification_Sent_DateField;

		private bool prenotification_Sent_DateFieldSpecified;

		private Customer_Invoice_Line_WWS_DataType[] customer_Invoice_Line_Replacement_DataField;

		private Taxable_Code_Application_NO_INPUT_DataType[] tax_Code_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Note_WWS_DataType[] note_DataField;

		private Customer_Invoice_Intercompany_Sub_ProcessType customer_Invoice_Intercompany_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Invoice_Adjustment_ID
		{
			get
			{
				return this.customer_Invoice_Adjustment_IDField;
			}
			set
			{
				this.customer_Invoice_Adjustment_IDField = value;
				this.RaisePropertyChanged("Customer_Invoice_Adjustment_ID");
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

		[XmlElement(Order = 6)]
		public Billable_EntityObjectType Sold_To_Customer_Reference
		{
			get
			{
				return this.sold_To_Customer_ReferenceField;
			}
			set
			{
				this.sold_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Sold_To_Customer_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Populate_with_Default_Bill_To_Contacts
		{
			get
			{
				return this.populate_with_Default_Bill_To_ContactsField;
			}
			set
			{
				this.populate_with_Default_Bill_To_ContactsField = value;
				this.RaisePropertyChanged("Populate_with_Default_Bill_To_Contacts");
			}
		}

		[XmlIgnore]
		public bool Populate_with_Default_Bill_To_ContactsSpecified
		{
			get
			{
				return this.populate_with_Default_Bill_To_ContactsFieldSpecified;
			}
			set
			{
				this.populate_with_Default_Bill_To_ContactsFieldSpecified = value;
				this.RaisePropertyChanged("Populate_with_Default_Bill_To_ContactsSpecified");
			}
		}

		[XmlElement("Bill_To_Contact_Reference", Order = 8)]
		public Business_Entity_ContactObjectType[] Bill_To_Contact_Reference
		{
			get
			{
				return this.bill_To_Contact_ReferenceField;
			}
			set
			{
				this.bill_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Address_ReferenceObjectType Bill_To_Address_Reference
		{
			get
			{
				return this.bill_To_Address_ReferenceField;
			}
			set
			{
				this.bill_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Address_Reference");
			}
		}

		[XmlArray(Order = 10), XmlArrayItem("Bill-To_Address_Data", typeof(Address_Information_DataType), IsNullable = false)]
		public Address_Information_DataType[] Bill_To_Address_Data
		{
			get
			{
				return this.bill_To_Address_DataField;
			}
			set
			{
				this.bill_To_Address_DataField = value;
				this.RaisePropertyChanged("Bill_To_Address_Data");
			}
		}

		[XmlElement(Order = 11)]
		public CustomerObjectType Ship_To_Customer_Reference
		{
			get
			{
				return this.ship_To_Customer_ReferenceField;
			}
			set
			{
				this.ship_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Customer_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement("Ship_To_Address_Data", Order = 13)]
		public Address_DataType[] Ship_To_Address_Data
		{
			get
			{
				return this.ship_To_Address_DataField;
			}
			set
			{
				this.ship_To_Address_DataField = value;
				this.RaisePropertyChanged("Ship_To_Address_Data");
			}
		}

		[XmlElement(Order = 14)]
		public ProjectObjectType Billable_Project_Reference
		{
			get
			{
				return this.billable_Project_ReferenceField;
			}
			set
			{
				this.billable_Project_ReferenceField = value;
				this.RaisePropertyChanged("Billable_Project_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public bool Increase_Amount_Due
		{
			get
			{
				return this.increase_Amount_DueField;
			}
			set
			{
				this.increase_Amount_DueField = value;
				this.RaisePropertyChanged("Increase_Amount_Due");
			}
		}

		[XmlIgnore]
		public bool Increase_Amount_DueSpecified
		{
			get
			{
				return this.increase_Amount_DueFieldSpecified;
			}
			set
			{
				this.increase_Amount_DueFieldSpecified = value;
				this.RaisePropertyChanged("Increase_Amount_DueSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Customer_InvoiceObjectType Original_Customer_Invoice_Reference
		{
			get
			{
				return this.original_Customer_Invoice_ReferenceField;
			}
			set
			{
				this.original_Customer_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Original_Customer_Invoice_Reference");
			}
		}

		[XmlElement("Auto-Apply_Adjustment_to_Invoice", Order = 18)]
		public bool AutoApply_Adjustment_to_Invoice
		{
			get
			{
				return this.autoApply_Adjustment_to_InvoiceField;
			}
			set
			{
				this.autoApply_Adjustment_to_InvoiceField = value;
				this.RaisePropertyChanged("AutoApply_Adjustment_to_Invoice");
			}
		}

		[XmlIgnore]
		public bool AutoApply_Adjustment_to_InvoiceSpecified
		{
			get
			{
				return this.autoApply_Adjustment_to_InvoiceFieldSpecified;
			}
			set
			{
				this.autoApply_Adjustment_to_InvoiceFieldSpecified = value;
				this.RaisePropertyChanged("AutoApply_Adjustment_to_InvoiceSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(DataType = "date", Order = 20)]
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

		[XmlElement(DataType = "date", Order = 21)]
		public DateTime Accounting_Date
		{
			get
			{
				return this.accounting_DateField;
			}
			set
			{
				this.accounting_DateField = value;
				this.RaisePropertyChanged("Accounting_Date");
			}
		}

		[XmlIgnore]
		public bool Accounting_DateSpecified
		{
			get
			{
				return this.accounting_DateFieldSpecified;
			}
			set
			{
				this.accounting_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
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

		[XmlElement(DataType = "date", Order = 23)]
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

		[XmlElement(DataType = "date", Order = 24)]
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

		[XmlElement(DataType = "date", Order = 25)]
		public DateTime Collection_Date
		{
			get
			{
				return this.collection_DateField;
			}
			set
			{
				this.collection_DateField = value;
				this.RaisePropertyChanged("Collection_Date");
			}
		}

		[XmlIgnore]
		public bool Collection_DateSpecified
		{
			get
			{
				return this.collection_DateFieldSpecified;
			}
			set
			{
				this.collection_DateFieldSpecified = value;
				this.RaisePropertyChanged("Collection_DateSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public decimal Payment_Amount_Promised
		{
			get
			{
				return this.payment_Amount_PromisedField;
			}
			set
			{
				this.payment_Amount_PromisedField = value;
				this.RaisePropertyChanged("Payment_Amount_Promised");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_PromisedSpecified
		{
			get
			{
				return this.payment_Amount_PromisedFieldSpecified;
			}
			set
			{
				this.payment_Amount_PromisedFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_PromisedSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public Collection_CodeObjectType Collection_Reason_Reference
		{
			get
			{
				return this.collection_Reason_ReferenceField;
			}
			set
			{
				this.collection_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Collection_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 28)]
		public DateTime Followup_Date
		{
			get
			{
				return this.followup_DateField;
			}
			set
			{
				this.followup_DateField = value;
				this.RaisePropertyChanged("Followup_Date");
			}
		}

		[XmlIgnore]
		public bool Followup_DateSpecified
		{
			get
			{
				return this.followup_DateFieldSpecified;
			}
			set
			{
				this.followup_DateFieldSpecified = value;
				this.RaisePropertyChanged("Followup_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 29)]
		public DateTime Dispute_Date
		{
			get
			{
				return this.dispute_DateField;
			}
			set
			{
				this.dispute_DateField = value;
				this.RaisePropertyChanged("Dispute_Date");
			}
		}

		[XmlIgnore]
		public bool Dispute_DateSpecified
		{
			get
			{
				return this.dispute_DateFieldSpecified;
			}
			set
			{
				this.dispute_DateFieldSpecified = value;
				this.RaisePropertyChanged("Dispute_DateSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public decimal Dispute_Amount
		{
			get
			{
				return this.dispute_AmountField;
			}
			set
			{
				this.dispute_AmountField = value;
				this.RaisePropertyChanged("Dispute_Amount");
			}
		}

		[XmlIgnore]
		public bool Dispute_AmountSpecified
		{
			get
			{
				return this.dispute_AmountFieldSpecified;
			}
			set
			{
				this.dispute_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Dispute_AmountSpecified");
			}
		}

		[XmlElement("Dispute_Reason_Reference", Order = 31)]
		public Dispute_ReasonObjectType[] Dispute_Reason_Reference
		{
			get
			{
				return this.dispute_Reason_ReferenceField;
			}
			set
			{
				this.dispute_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Dispute_Reason_Reference");
			}
		}

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
		public string Document_Status
		{
			get
			{
				return this.document_StatusField;
			}
			set
			{
				this.document_StatusField = value;
				this.RaisePropertyChanged("Document_Status");
			}
		}

		[XmlElement(Order = 36)]
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

		[XmlElement(Order = 37)]
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

		[XmlElement(Order = 38)]
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

		[XmlElement(Order = 39)]
		public Unique_IdentifierObjectType Company_Tax_ID_Reference
		{
			get
			{
				return this.company_Tax_ID_ReferenceField;
			}
			set
			{
				this.company_Tax_ID_ReferenceField = value;
				this.RaisePropertyChanged("Company_Tax_ID_Reference");
			}
		}

		[XmlElement(Order = 40)]
		public Unique_IdentifierObjectType Customer_Tax_ID_Reference
		{
			get
			{
				return this.customer_Tax_ID_ReferenceField;
			}
			set
			{
				this.customer_Tax_ID_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Tax_ID_Reference");
			}
		}

		[XmlElement(Order = 41)]
		public string Customer_PO_Number
		{
			get
			{
				return this.customer_PO_NumberField;
			}
			set
			{
				this.customer_PO_NumberField = value;
				this.RaisePropertyChanged("Customer_PO_Number");
			}
		}

		[XmlElement(Order = 42)]
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

		[XmlElement(Order = 43)]
		public bool Include_Customer_Worktags
		{
			get
			{
				return this.include_Customer_WorktagsField;
			}
			set
			{
				this.include_Customer_WorktagsField = value;
				this.RaisePropertyChanged("Include_Customer_Worktags");
			}
		}

		[XmlIgnore]
		public bool Include_Customer_WorktagsSpecified
		{
			get
			{
				return this.include_Customer_WorktagsFieldSpecified;
			}
			set
			{
				this.include_Customer_WorktagsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Customer_WorktagsSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 44)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 45)]
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

		[XmlElement(Order = 46)]
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

		[XmlElement(Order = 47)]
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

		[XmlElement(DataType = "date", Order = 48)]
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

		[XmlElement(Order = 49)]
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

		[XmlElement(Order = 50)]
		public string Tax_Calculation_Details
		{
			get
			{
				return this.tax_Calculation_DetailsField;
			}
			set
			{
				this.tax_Calculation_DetailsField = value;
				this.RaisePropertyChanged("Tax_Calculation_Details");
			}
		}

		[XmlElement(Order = 51)]
		public SEPA_MandateObjectType SEPA_Mandate_Reference
		{
			get
			{
				return this.sEPA_Mandate_ReferenceField;
			}
			set
			{
				this.sEPA_Mandate_ReferenceField = value;
				this.RaisePropertyChanged("SEPA_Mandate_Reference");
			}
		}

		[XmlElement("Pre-notification_Sent_Date", DataType = "date", Order = 52)]
		public DateTime Prenotification_Sent_Date
		{
			get
			{
				return this.prenotification_Sent_DateField;
			}
			set
			{
				this.prenotification_Sent_DateField = value;
				this.RaisePropertyChanged("Prenotification_Sent_Date");
			}
		}

		[XmlIgnore]
		public bool Prenotification_Sent_DateSpecified
		{
			get
			{
				return this.prenotification_Sent_DateFieldSpecified;
			}
			set
			{
				this.prenotification_Sent_DateFieldSpecified = value;
				this.RaisePropertyChanged("Prenotification_Sent_DateSpecified");
			}
		}

		[XmlElement("Customer_Invoice_Line_Replacement_Data", Order = 53)]
		public Customer_Invoice_Line_WWS_DataType[] Customer_Invoice_Line_Replacement_Data
		{
			get
			{
				return this.customer_Invoice_Line_Replacement_DataField;
			}
			set
			{
				this.customer_Invoice_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Customer_Invoice_Line_Replacement_Data");
			}
		}

		[XmlElement("Tax_Code_Data", Order = 54)]
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

		[XmlElement("Note_Data", Order = 56)]
		public Note_WWS_DataType[] Note_Data
		{
			get
			{
				return this.note_DataField;
			}
			set
			{
				this.note_DataField = value;
				this.RaisePropertyChanged("Note_Data");
			}
		}

		[XmlElement(Order = 57)]
		public Customer_Invoice_Intercompany_Sub_ProcessType Customer_Invoice_Intercompany_Sub_Process
		{
			get
			{
				return this.customer_Invoice_Intercompany_Sub_ProcessField;
			}
			set
			{
				this.customer_Invoice_Intercompany_Sub_ProcessField = value;
				this.RaisePropertyChanged("Customer_Invoice_Intercompany_Sub_Process");
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
