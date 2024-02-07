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
	public class Supplier_DataType : INotifyPropertyChanged
	{
		private string supplier_IDField;

		private string supplier_Reference_IDField;

		private string supplier_NameField;

		private bool worktag_OnlyField;

		private bool worktag_OnlyFieldSpecified;

		private OrganizationObjectType[] restricted_To_Companies_ReferenceField;

		private Document_StatusObjectType approval_Status_ReferenceField;

		private bool submitField;

		private bool submitFieldSpecified;

		private object itemField;

		private Tax_Authority_Form_TypeObjectType tax_Authority_Form_Type_ReferenceField;

		private bool iRS_1099_SupplierField;

		private bool iRS_1099_SupplierFieldSpecified;

		private bool report_1099_with_ParentField;

		private bool report_1099_with_ParentFieldSpecified;

		private Tax_ID_DataType[] tax_ID_DataField;

		private Tax_Status_DataType[] tax_StatusField;

		private Supplier_CategoryObjectType supplier_Category_ReferenceField;

		private Supplier_GroupObjectType[] supplier_Group_ReferenceField;

		private DateTime tax_Document_DateField;

		private bool tax_Document_DateFieldSpecified;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Tax_CodeObjectType default_Withholding_Tax_Code_ReferenceField;

		private bool fATCAField;

		private bool fATCAFieldSpecified;

		private DateTime certificate_of_Insurance_DateField;

		private bool certificate_of_Insurance_DateFieldSpecified;

		private string customer_Account_NumberField;

		private string dUNS_NumberField;

		private bool invoice_Any_SupplierField;

		private bool invoice_Any_SupplierFieldSpecified;

		private bool enable_Global_Location_NumberField;

		private bool enable_Global_Location_NumberFieldSpecified;

		private bool disable_Change_OrderField;

		private bool disable_Change_OrderFieldSpecified;

		private Purchase_Order_Issue_OptionObjectType purchase_Order_Issue_Option_ReferenceField;

		private Supplier_LinkObjectType multiSupplier_Supplier_Link_for_PO_Issue_ReferenceField;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private bool acknowledgement_ExpectedField;

		private bool acknowledgement_ExpectedFieldSpecified;

		private bool enable_ASNField;

		private bool enable_ASNFieldSpecified;

		private decimal aSN_Due_In_DaysField;

		private bool aSN_Due_In_DaysFieldSpecified;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType[] payment_Types_Accepted_ReferenceField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private Worker_Credit_CardObjectType procurement_Credit_Card_ReferenceField;

		private SupplierObjectType[] included_Children_ReferenceField;

		private SupplierObjectType[] proposed_Children_ReferenceField;

		private Business_Entity_WWS_DataType business_Entity_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private bool do_not_pay_during_Bank_Account_updatesField;

		private bool do_not_pay_during_Bank_Account_updatesFieldSpecified;

		private Supplier_Status_DataType[] supplier_Status_DataField;

		private Proposed_Supplier_Status_DataType proposed_Supplier_Status_DataField;

		private bool always_Separate_PaymentsField;

		private bool always_Separate_PaymentsFieldSpecified;

		private object item1Field;

		private Item1ChoiceType item1ElementNameField;

		private CurrencyObjectType currency_ReferenceField;

		private CurrencyObjectType[] accepted_Currencies_ReferenceField;

		private bool mBE_WMBE_BusinessField;

		private bool mBE_WMBE_BusinessFieldSpecified;

		private DateTime certification_Expiration_DateField;

		private bool certification_Expiration_DateFieldSpecified;

		private string certificate_NumberField;

		private string certified_byField;

		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private bool do_Not_Reimburse_Contingent_Worker_Expense_ReportsField;

		private bool do_Not_Reimburse_Contingent_Worker_Expense_ReportsFieldSpecified;

		private Business_Entity_Alternate_Name_DataType[] business_Entity_Alternate_Name_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Note_WWS_DataType[] note_DataField;

		private Spend_Category_or_HierarchyObjectType[] spend_Category_or_Hierarchy_ReferenceField;

		private Areas_Changed_WWS_DataType areas_ChangedField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_ID
		{
			get
			{
				return this.supplier_IDField;
			}
			set
			{
				this.supplier_IDField = value;
				this.RaisePropertyChanged("Supplier_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Supplier_Reference_ID
		{
			get
			{
				return this.supplier_Reference_IDField;
			}
			set
			{
				this.supplier_Reference_IDField = value;
				this.RaisePropertyChanged("Supplier_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Supplier_Name
		{
			get
			{
				return this.supplier_NameField;
			}
			set
			{
				this.supplier_NameField = value;
				this.RaisePropertyChanged("Supplier_Name");
			}
		}

		[XmlElement(Order = 3)]
		public bool Worktag_Only
		{
			get
			{
				return this.worktag_OnlyField;
			}
			set
			{
				this.worktag_OnlyField = value;
				this.RaisePropertyChanged("Worktag_Only");
			}
		}

		[XmlIgnore]
		public bool Worktag_OnlySpecified
		{
			get
			{
				return this.worktag_OnlyFieldSpecified;
			}
			set
			{
				this.worktag_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Worktag_OnlySpecified");
			}
		}

		[XmlElement("Restricted_To_Companies_Reference", Order = 4)]
		public OrganizationObjectType[] Restricted_To_Companies_Reference
		{
			get
			{
				return this.restricted_To_Companies_ReferenceField;
			}
			set
			{
				this.restricted_To_Companies_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_To_Companies_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Document_StatusObjectType Approval_Status_Reference
		{
			get
			{
				return this.approval_Status_ReferenceField;
			}
			set
			{
				this.approval_Status_ReferenceField = value;
				this.RaisePropertyChanged("Approval_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Create_Supplier_from_Customer_Reference", typeof(Billable_EntityObjectType), Order = 7), XmlElement("Create_Supplier_from_Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 7), XmlElement("Create_Supplier_from_Investor_Reference", typeof(InvestorObjectType), Order = 7), XmlElement("Create_Supplier_from_Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 7)]
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

		[XmlElement(Order = 8)]
		public Tax_Authority_Form_TypeObjectType Tax_Authority_Form_Type_Reference
		{
			get
			{
				return this.tax_Authority_Form_Type_ReferenceField;
			}
			set
			{
				this.tax_Authority_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Form_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool IRS_1099_Supplier
		{
			get
			{
				return this.iRS_1099_SupplierField;
			}
			set
			{
				this.iRS_1099_SupplierField = value;
				this.RaisePropertyChanged("IRS_1099_Supplier");
			}
		}

		[XmlIgnore]
		public bool IRS_1099_SupplierSpecified
		{
			get
			{
				return this.iRS_1099_SupplierFieldSpecified;
			}
			set
			{
				this.iRS_1099_SupplierFieldSpecified = value;
				this.RaisePropertyChanged("IRS_1099_SupplierSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Report_1099_with_Parent
		{
			get
			{
				return this.report_1099_with_ParentField;
			}
			set
			{
				this.report_1099_with_ParentField = value;
				this.RaisePropertyChanged("Report_1099_with_Parent");
			}
		}

		[XmlIgnore]
		public bool Report_1099_with_ParentSpecified
		{
			get
			{
				return this.report_1099_with_ParentFieldSpecified;
			}
			set
			{
				this.report_1099_with_ParentFieldSpecified = value;
				this.RaisePropertyChanged("Report_1099_with_ParentSpecified");
			}
		}

		[XmlElement("Tax_ID_Data", Order = 11)]
		public Tax_ID_DataType[] Tax_ID_Data
		{
			get
			{
				return this.tax_ID_DataField;
			}
			set
			{
				this.tax_ID_DataField = value;
				this.RaisePropertyChanged("Tax_ID_Data");
			}
		}

		[XmlElement("Tax_Status", Order = 12)]
		public Tax_Status_DataType[] Tax_Status
		{
			get
			{
				return this.tax_StatusField;
			}
			set
			{
				this.tax_StatusField = value;
				this.RaisePropertyChanged("Tax_Status");
			}
		}

		[XmlElement(Order = 13)]
		public Supplier_CategoryObjectType Supplier_Category_Reference
		{
			get
			{
				return this.supplier_Category_ReferenceField;
			}
			set
			{
				this.supplier_Category_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Category_Reference");
			}
		}

		[XmlElement("Supplier_Group_Reference", Order = 14)]
		public Supplier_GroupObjectType[] Supplier_Group_Reference
		{
			get
			{
				return this.supplier_Group_ReferenceField;
			}
			set
			{
				this.supplier_Group_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Group_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Tax_Document_Date
		{
			get
			{
				return this.tax_Document_DateField;
			}
			set
			{
				this.tax_Document_DateField = value;
				this.RaisePropertyChanged("Tax_Document_Date");
			}
		}

		[XmlIgnore]
		public bool Tax_Document_DateSpecified
		{
			get
			{
				return this.tax_Document_DateFieldSpecified;
			}
			set
			{
				this.tax_Document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Document_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public Tax_CodeObjectType Default_Tax_Code_Reference
		{
			get
			{
				return this.default_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Code_Reference");
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
		public bool FATCA
		{
			get
			{
				return this.fATCAField;
			}
			set
			{
				this.fATCAField = value;
				this.RaisePropertyChanged("FATCA");
			}
		}

		[XmlIgnore]
		public bool FATCASpecified
		{
			get
			{
				return this.fATCAFieldSpecified;
			}
			set
			{
				this.fATCAFieldSpecified = value;
				this.RaisePropertyChanged("FATCASpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 19)]
		public DateTime Certificate_of_Insurance_Date
		{
			get
			{
				return this.certificate_of_Insurance_DateField;
			}
			set
			{
				this.certificate_of_Insurance_DateField = value;
				this.RaisePropertyChanged("Certificate_of_Insurance_Date");
			}
		}

		[XmlIgnore]
		public bool Certificate_of_Insurance_DateSpecified
		{
			get
			{
				return this.certificate_of_Insurance_DateFieldSpecified;
			}
			set
			{
				this.certificate_of_Insurance_DateFieldSpecified = value;
				this.RaisePropertyChanged("Certificate_of_Insurance_DateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public string Customer_Account_Number
		{
			get
			{
				return this.customer_Account_NumberField;
			}
			set
			{
				this.customer_Account_NumberField = value;
				this.RaisePropertyChanged("Customer_Account_Number");
			}
		}

		[XmlElement(Order = 21)]
		public string DUNS_Number
		{
			get
			{
				return this.dUNS_NumberField;
			}
			set
			{
				this.dUNS_NumberField = value;
				this.RaisePropertyChanged("DUNS_Number");
			}
		}

		[XmlElement(Order = 22)]
		public bool Invoice_Any_Supplier
		{
			get
			{
				return this.invoice_Any_SupplierField;
			}
			set
			{
				this.invoice_Any_SupplierField = value;
				this.RaisePropertyChanged("Invoice_Any_Supplier");
			}
		}

		[XmlIgnore]
		public bool Invoice_Any_SupplierSpecified
		{
			get
			{
				return this.invoice_Any_SupplierFieldSpecified;
			}
			set
			{
				this.invoice_Any_SupplierFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Any_SupplierSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Enable_Global_Location_Number
		{
			get
			{
				return this.enable_Global_Location_NumberField;
			}
			set
			{
				this.enable_Global_Location_NumberField = value;
				this.RaisePropertyChanged("Enable_Global_Location_Number");
			}
		}

		[XmlIgnore]
		public bool Enable_Global_Location_NumberSpecified
		{
			get
			{
				return this.enable_Global_Location_NumberFieldSpecified;
			}
			set
			{
				this.enable_Global_Location_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Global_Location_NumberSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Disable_Change_Order
		{
			get
			{
				return this.disable_Change_OrderField;
			}
			set
			{
				this.disable_Change_OrderField = value;
				this.RaisePropertyChanged("Disable_Change_Order");
			}
		}

		[XmlIgnore]
		public bool Disable_Change_OrderSpecified
		{
			get
			{
				return this.disable_Change_OrderFieldSpecified;
			}
			set
			{
				this.disable_Change_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Disable_Change_OrderSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public Purchase_Order_Issue_OptionObjectType Purchase_Order_Issue_Option_Reference
		{
			get
			{
				return this.purchase_Order_Issue_Option_ReferenceField;
			}
			set
			{
				this.purchase_Order_Issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Issue_Option_Reference");
			}
		}

		[XmlElement("Multi-Supplier_Supplier_Link_for_PO_Issue_Reference", Order = 26)]
		public Supplier_LinkObjectType MultiSupplier_Supplier_Link_for_PO_Issue_Reference
		{
			get
			{
				return this.multiSupplier_Supplier_Link_for_PO_Issue_ReferenceField;
			}
			set
			{
				this.multiSupplier_Supplier_Link_for_PO_Issue_ReferenceField = value;
				this.RaisePropertyChanged("MultiSupplier_Supplier_Link_for_PO_Issue_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public Shipping_TermsObjectType Shipping_Terms_Reference
		{
			get
			{
				return this.shipping_Terms_ReferenceField;
			}
			set
			{
				this.shipping_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Terms_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public Shipping_MethodObjectType Shipping_Method_Reference
		{
			get
			{
				return this.shipping_Method_ReferenceField;
			}
			set
			{
				this.shipping_Method_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Method_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public bool Acknowledgement_Expected
		{
			get
			{
				return this.acknowledgement_ExpectedField;
			}
			set
			{
				this.acknowledgement_ExpectedField = value;
				this.RaisePropertyChanged("Acknowledgement_Expected");
			}
		}

		[XmlIgnore]
		public bool Acknowledgement_ExpectedSpecified
		{
			get
			{
				return this.acknowledgement_ExpectedFieldSpecified;
			}
			set
			{
				this.acknowledgement_ExpectedFieldSpecified = value;
				this.RaisePropertyChanged("Acknowledgement_ExpectedSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Enable_ASN
		{
			get
			{
				return this.enable_ASNField;
			}
			set
			{
				this.enable_ASNField = value;
				this.RaisePropertyChanged("Enable_ASN");
			}
		}

		[XmlIgnore]
		public bool Enable_ASNSpecified
		{
			get
			{
				return this.enable_ASNFieldSpecified;
			}
			set
			{
				this.enable_ASNFieldSpecified = value;
				this.RaisePropertyChanged("Enable_ASNSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal ASN_Due_In_Days
		{
			get
			{
				return this.aSN_Due_In_DaysField;
			}
			set
			{
				this.aSN_Due_In_DaysField = value;
				this.RaisePropertyChanged("ASN_Due_In_Days");
			}
		}

		[XmlIgnore]
		public bool ASN_Due_In_DaysSpecified
		{
			get
			{
				return this.aSN_Due_In_DaysFieldSpecified;
			}
			set
			{
				this.aSN_Due_In_DaysFieldSpecified = value;
				this.RaisePropertyChanged("ASN_Due_In_DaysSpecified");
			}
		}

		[XmlElement(Order = 32)]
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

		[XmlElement("Payment_Types_Accepted_Reference", Order = 33)]
		public Payment_TypeObjectType[] Payment_Types_Accepted_Reference
		{
			get
			{
				return this.payment_Types_Accepted_ReferenceField;
			}
			set
			{
				this.payment_Types_Accepted_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Types_Accepted_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public Payment_TypeObjectType Default_Payment_Type_Reference
		{
			get
			{
				return this.default_Payment_Type_ReferenceField;
			}
			set
			{
				this.default_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public Worker_Credit_CardObjectType Procurement_Credit_Card_Reference
		{
			get
			{
				return this.procurement_Credit_Card_ReferenceField;
			}
			set
			{
				this.procurement_Credit_Card_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Credit_Card_Reference");
			}
		}

		[XmlElement("Included_Children_Reference", Order = 36)]
		public SupplierObjectType[] Included_Children_Reference
		{
			get
			{
				return this.included_Children_ReferenceField;
			}
			set
			{
				this.included_Children_ReferenceField = value;
				this.RaisePropertyChanged("Included_Children_Reference");
			}
		}

		[XmlElement("Proposed_Children_Reference", Order = 37)]
		public SupplierObjectType[] Proposed_Children_Reference
		{
			get
			{
				return this.proposed_Children_ReferenceField;
			}
			set
			{
				this.proposed_Children_ReferenceField = value;
				this.RaisePropertyChanged("Proposed_Children_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public Business_Entity_WWS_DataType Business_Entity_Data
		{
			get
			{
				return this.business_Entity_DataField;
			}
			set
			{
				this.business_Entity_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Data");
			}
		}

		[XmlElement("Settlement_Account_Data", Order = 39)]
		public Settlement_Account_WWS_DataType[] Settlement_Account_Data
		{
			get
			{
				return this.settlement_Account_DataField;
			}
			set
			{
				this.settlement_Account_DataField = value;
				this.RaisePropertyChanged("Settlement_Account_Data");
			}
		}

		[XmlElement(Order = 40)]
		public bool Do_not_pay_during_Bank_Account_updates
		{
			get
			{
				return this.do_not_pay_during_Bank_Account_updatesField;
			}
			set
			{
				this.do_not_pay_during_Bank_Account_updatesField = value;
				this.RaisePropertyChanged("Do_not_pay_during_Bank_Account_updates");
			}
		}

		[XmlIgnore]
		public bool Do_not_pay_during_Bank_Account_updatesSpecified
		{
			get
			{
				return this.do_not_pay_during_Bank_Account_updatesFieldSpecified;
			}
			set
			{
				this.do_not_pay_during_Bank_Account_updatesFieldSpecified = value;
				this.RaisePropertyChanged("Do_not_pay_during_Bank_Account_updatesSpecified");
			}
		}

		[XmlElement("Supplier_Status_Data", Order = 41)]
		public Supplier_Status_DataType[] Supplier_Status_Data
		{
			get
			{
				return this.supplier_Status_DataField;
			}
			set
			{
				this.supplier_Status_DataField = value;
				this.RaisePropertyChanged("Supplier_Status_Data");
			}
		}

		[XmlElement(Order = 42)]
		public Proposed_Supplier_Status_DataType Proposed_Supplier_Status_Data
		{
			get
			{
				return this.proposed_Supplier_Status_DataField;
			}
			set
			{
				this.proposed_Supplier_Status_DataField = value;
				this.RaisePropertyChanged("Proposed_Supplier_Status_Data");
			}
		}

		[XmlElement(Order = 43)]
		public bool Always_Separate_Payments
		{
			get
			{
				return this.always_Separate_PaymentsField;
			}
			set
			{
				this.always_Separate_PaymentsField = value;
				this.RaisePropertyChanged("Always_Separate_Payments");
			}
		}

		[XmlIgnore]
		public bool Always_Separate_PaymentsSpecified
		{
			get
			{
				return this.always_Separate_PaymentsFieldSpecified;
			}
			set
			{
				this.always_Separate_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Always_Separate_PaymentsSpecified");
			}
		}

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Text_for_Default_Supplier_Payment_Memo", typeof(string), Order = 44), XmlElement("Use_Invoice_Memo_as_Default_Supplier_Payment_Memo", typeof(bool), Order = 44), XmlElement("Use_Supplier_Connection_Memo", typeof(bool), Order = 44), XmlElement("Use_Supplier_Reference_as_Default_Supplier_Payment_Memo", typeof(bool), Order = 44)]
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

		[XmlElement(Order = 45), XmlIgnore]
		public Item1ChoiceType Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
			}
		}

		[XmlElement(Order = 46)]
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

		[XmlElement("Accepted_Currencies_Reference", Order = 47)]
		public CurrencyObjectType[] Accepted_Currencies_Reference
		{
			get
			{
				return this.accepted_Currencies_ReferenceField;
			}
			set
			{
				this.accepted_Currencies_ReferenceField = value;
				this.RaisePropertyChanged("Accepted_Currencies_Reference");
			}
		}

		[XmlElement(Order = 48)]
		public bool MBE_WMBE_Business
		{
			get
			{
				return this.mBE_WMBE_BusinessField;
			}
			set
			{
				this.mBE_WMBE_BusinessField = value;
				this.RaisePropertyChanged("MBE_WMBE_Business");
			}
		}

		[XmlIgnore]
		public bool MBE_WMBE_BusinessSpecified
		{
			get
			{
				return this.mBE_WMBE_BusinessFieldSpecified;
			}
			set
			{
				this.mBE_WMBE_BusinessFieldSpecified = value;
				this.RaisePropertyChanged("MBE_WMBE_BusinessSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 49)]
		public DateTime Certification_Expiration_Date
		{
			get
			{
				return this.certification_Expiration_DateField;
			}
			set
			{
				this.certification_Expiration_DateField = value;
				this.RaisePropertyChanged("Certification_Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Certification_Expiration_DateSpecified
		{
			get
			{
				return this.certification_Expiration_DateFieldSpecified;
			}
			set
			{
				this.certification_Expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Certification_Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 50)]
		public string Certificate_Number
		{
			get
			{
				return this.certificate_NumberField;
			}
			set
			{
				this.certificate_NumberField = value;
				this.RaisePropertyChanged("Certificate_Number");
			}
		}

		[XmlElement(Order = 51)]
		public string Certified_by
		{
			get
			{
				return this.certified_byField;
			}
			set
			{
				this.certified_byField = value;
				this.RaisePropertyChanged("Certified_by");
			}
		}

		[XmlElement(Order = 52)]
		public Integration_System__Audited_ObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 53)]
		public bool Do_Not_Reimburse_Contingent_Worker_Expense_Reports
		{
			get
			{
				return this.do_Not_Reimburse_Contingent_Worker_Expense_ReportsField;
			}
			set
			{
				this.do_Not_Reimburse_Contingent_Worker_Expense_ReportsField = value;
				this.RaisePropertyChanged("Do_Not_Reimburse_Contingent_Worker_Expense_Reports");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Reimburse_Contingent_Worker_Expense_ReportsSpecified
		{
			get
			{
				return this.do_Not_Reimburse_Contingent_Worker_Expense_ReportsFieldSpecified;
			}
			set
			{
				this.do_Not_Reimburse_Contingent_Worker_Expense_ReportsFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Reimburse_Contingent_Worker_Expense_ReportsSpecified");
			}
		}

		[XmlElement("Business_Entity_Alternate_Name_Data", Order = 54)]
		public Business_Entity_Alternate_Name_DataType[] Business_Entity_Alternate_Name_Data
		{
			get
			{
				return this.business_Entity_Alternate_Name_DataField;
			}
			set
			{
				this.business_Entity_Alternate_Name_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Alternate_Name_Data");
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

		[XmlElement("Spend_Category_or_Hierarchy_Reference", Order = 57)]
		public Spend_Category_or_HierarchyObjectType[] Spend_Category_or_Hierarchy_Reference
		{
			get
			{
				return this.spend_Category_or_Hierarchy_ReferenceField;
			}
			set
			{
				this.spend_Category_or_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_or_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 58)]
		public Areas_Changed_WWS_DataType Areas_Changed
		{
			get
			{
				return this.areas_ChangedField;
			}
			set
			{
				this.areas_ChangedField = value;
				this.RaisePropertyChanged("Areas_Changed");
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
