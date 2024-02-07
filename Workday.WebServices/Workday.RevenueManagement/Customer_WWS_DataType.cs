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
	public class Customer_WWS_DataType : INotifyPropertyChanged
	{
		private string customer_IDField;

		private string customer_Reference_IDField;

		private string customer_NameField;

		private bool worktag_OnlyField;

		private bool worktag_OnlyFieldSpecified;

		private object itemField;

		private Customer_CategoryObjectType customer_Category_ReferenceField;

		private Customer_GroupObjectType[] customer_Group_ReferenceField;

		private LocaleObjectType customer_Preferred_Locale_ReferenceField;

		private User_LanguageObjectType customer_Preferred_Language_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType default_Payment_Type_ReferenceField;

		private string dUNS_NumberField;

		private CurrencyObjectType credit_Limit_Currency_ReferenceField;

		private decimal credit_LimitField;

		private bool credit_LimitFieldSpecified;

		private decimal hierarchy_Credit_LimitField;

		private bool hierarchy_Credit_LimitFieldSpecified;

		private DateTime credit_Verification_DateField;

		private bool credit_Verification_DateFieldSpecified;

		private decimal commercial_Credit_ScoreField;

		private bool commercial_Credit_ScoreFieldSpecified;

		private DateTime commercial_Credit_Score_DateField;

		private bool commercial_Credit_Score_DateFieldSpecified;

		private string commercial_Credit_Score_NoteField;

		private decimal composite_Risk_ScoreField;

		private bool composite_Risk_ScoreFieldSpecified;

		private DateTime composite_Risk_DateField;

		private bool composite_Risk_DateFieldSpecified;

		private string composite_Risk_NoteField;

		private decimal customer_Satisfaction_ScoreField;

		private bool customer_Satisfaction_ScoreFieldSpecified;

		private DateTime customer_Satisfaction_DateField;

		private bool customer_Satisfaction_DateFieldSpecified;

		private string customer_Satisfaction_NoteField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_ID_DataType[] tax_ID_DataField;

		private LockboxObjectType[] lockbox_ReferenceField;

		private CustomerObjectType[] included_Children_ReferenceField;

		private Customer_Security_SegmentObjectType[] customer_Security_Segment_ReferenceField;

		private Customer_Business_Entity_WWS_DataType business_Entity_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private Customer_Credit_Card_Profile_WWS_DataType[] credit_Card_DataField;

		private Customer_Status_DataType[] customer_Status_DataField;

		private bool always_Separate_PaymentsField;

		private bool always_Separate_PaymentsFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private CurrencyObjectType[] accepted_Currencies_ReferenceField;

		private CustomerObjectType remitfrom_Customer_ReferenceField;

		private Delivery_MethodObjectType[] invoice_Delivery_Method_ReferenceField;

		private Customer_Document_Email_Recipient_OptionObjectType[] invoice_Notification_Email_Recipients_ReferenceField;

		private Delivery_MethodObjectType[] statement_Delivery_Method_ReferenceField;

		private Customer_Document_Email_Recipient_OptionObjectType[] statement_Notification_Email_Recipients_ReferenceField;

		private Delivery_MethodObjectType[] dunning_Delivery_Method_ReferenceField;

		private Customer_Document_Email_Recipient_OptionObjectType[] dunning_Letter_Notification_Email_Recipients_ReferenceField;

		private bool mandate_RequiredField;

		private bool mandate_RequiredFieldSpecified;

		private Payment_TypeObjectType direct_Debit_Payment_Type_ReferenceField;

		private SEPA_MandateObjectType default_Mandate_ReferenceField;

		private Business_Entity_Alternate_Name_DataType[] business_Entity_Alternate_Name_DataField;

		private Tax_Status_DataType[] tax_Status_DataField;

		private Financials_Attachment_DataType[] business_Entity_Attachment_DataField;

		private Note_WWS_DataType[] note_DataField;

		private DateTime followup_DateField;

		private bool followup_DateFieldSpecified;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_ID
		{
			get
			{
				return this.customer_IDField;
			}
			set
			{
				this.customer_IDField = value;
				this.RaisePropertyChanged("Customer_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Reference_ID
		{
			get
			{
				return this.customer_Reference_IDField;
			}
			set
			{
				this.customer_Reference_IDField = value;
				this.RaisePropertyChanged("Customer_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Customer_Name
		{
			get
			{
				return this.customer_NameField;
			}
			set
			{
				this.customer_NameField = value;
				this.RaisePropertyChanged("Customer_Name");
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

		[XmlElement("Create_Customer_from_Financial_Institution_Reference", typeof(Financial_InstitutionObjectType), Order = 4), XmlElement("Create_Customer_from_Investor_Reference", typeof(InvestorObjectType), Order = 4), XmlElement("Create_Customer_from_Supplier_Reference", typeof(SupplierObjectType), Order = 4), XmlElement("Create_Customer_from_Tax_Authority_Reference", typeof(Tax_AuthorityObjectType), Order = 4)]
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

		[XmlElement(Order = 5)]
		public Customer_CategoryObjectType Customer_Category_Reference
		{
			get
			{
				return this.customer_Category_ReferenceField;
			}
			set
			{
				this.customer_Category_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Category_Reference");
			}
		}

		[XmlElement("Customer_Group_Reference", Order = 6)]
		public Customer_GroupObjectType[] Customer_Group_Reference
		{
			get
			{
				return this.customer_Group_ReferenceField;
			}
			set
			{
				this.customer_Group_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Group_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public LocaleObjectType Customer_Preferred_Locale_Reference
		{
			get
			{
				return this.customer_Preferred_Locale_ReferenceField;
			}
			set
			{
				this.customer_Preferred_Locale_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Preferred_Locale_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public User_LanguageObjectType Customer_Preferred_Language_Reference
		{
			get
			{
				return this.customer_Preferred_Language_ReferenceField;
			}
			set
			{
				this.customer_Preferred_Language_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Preferred_Language_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public CurrencyObjectType Credit_Limit_Currency_Reference
		{
			get
			{
				return this.credit_Limit_Currency_ReferenceField;
			}
			set
			{
				this.credit_Limit_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Limit_Currency_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Credit_Limit
		{
			get
			{
				return this.credit_LimitField;
			}
			set
			{
				this.credit_LimitField = value;
				this.RaisePropertyChanged("Credit_Limit");
			}
		}

		[XmlIgnore]
		public bool Credit_LimitSpecified
		{
			get
			{
				return this.credit_LimitFieldSpecified;
			}
			set
			{
				this.credit_LimitFieldSpecified = value;
				this.RaisePropertyChanged("Credit_LimitSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Hierarchy_Credit_Limit
		{
			get
			{
				return this.hierarchy_Credit_LimitField;
			}
			set
			{
				this.hierarchy_Credit_LimitField = value;
				this.RaisePropertyChanged("Hierarchy_Credit_Limit");
			}
		}

		[XmlIgnore]
		public bool Hierarchy_Credit_LimitSpecified
		{
			get
			{
				return this.hierarchy_Credit_LimitFieldSpecified;
			}
			set
			{
				this.hierarchy_Credit_LimitFieldSpecified = value;
				this.RaisePropertyChanged("Hierarchy_Credit_LimitSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Credit_Verification_Date
		{
			get
			{
				return this.credit_Verification_DateField;
			}
			set
			{
				this.credit_Verification_DateField = value;
				this.RaisePropertyChanged("Credit_Verification_Date");
			}
		}

		[XmlIgnore]
		public bool Credit_Verification_DateSpecified
		{
			get
			{
				return this.credit_Verification_DateFieldSpecified;
			}
			set
			{
				this.credit_Verification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Verification_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Commercial_Credit_Score
		{
			get
			{
				return this.commercial_Credit_ScoreField;
			}
			set
			{
				this.commercial_Credit_ScoreField = value;
				this.RaisePropertyChanged("Commercial_Credit_Score");
			}
		}

		[XmlIgnore]
		public bool Commercial_Credit_ScoreSpecified
		{
			get
			{
				return this.commercial_Credit_ScoreFieldSpecified;
			}
			set
			{
				this.commercial_Credit_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Commercial_Credit_ScoreSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime Commercial_Credit_Score_Date
		{
			get
			{
				return this.commercial_Credit_Score_DateField;
			}
			set
			{
				this.commercial_Credit_Score_DateField = value;
				this.RaisePropertyChanged("Commercial_Credit_Score_Date");
			}
		}

		[XmlIgnore]
		public bool Commercial_Credit_Score_DateSpecified
		{
			get
			{
				return this.commercial_Credit_Score_DateFieldSpecified;
			}
			set
			{
				this.commercial_Credit_Score_DateFieldSpecified = value;
				this.RaisePropertyChanged("Commercial_Credit_Score_DateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public string Commercial_Credit_Score_Note
		{
			get
			{
				return this.commercial_Credit_Score_NoteField;
			}
			set
			{
				this.commercial_Credit_Score_NoteField = value;
				this.RaisePropertyChanged("Commercial_Credit_Score_Note");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Composite_Risk_Score
		{
			get
			{
				return this.composite_Risk_ScoreField;
			}
			set
			{
				this.composite_Risk_ScoreField = value;
				this.RaisePropertyChanged("Composite_Risk_Score");
			}
		}

		[XmlIgnore]
		public bool Composite_Risk_ScoreSpecified
		{
			get
			{
				return this.composite_Risk_ScoreFieldSpecified;
			}
			set
			{
				this.composite_Risk_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Composite_Risk_ScoreSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Composite_Risk_Date
		{
			get
			{
				return this.composite_Risk_DateField;
			}
			set
			{
				this.composite_Risk_DateField = value;
				this.RaisePropertyChanged("Composite_Risk_Date");
			}
		}

		[XmlIgnore]
		public bool Composite_Risk_DateSpecified
		{
			get
			{
				return this.composite_Risk_DateFieldSpecified;
			}
			set
			{
				this.composite_Risk_DateFieldSpecified = value;
				this.RaisePropertyChanged("Composite_Risk_DateSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public string Composite_Risk_Note
		{
			get
			{
				return this.composite_Risk_NoteField;
			}
			set
			{
				this.composite_Risk_NoteField = value;
				this.RaisePropertyChanged("Composite_Risk_Note");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Customer_Satisfaction_Score
		{
			get
			{
				return this.customer_Satisfaction_ScoreField;
			}
			set
			{
				this.customer_Satisfaction_ScoreField = value;
				this.RaisePropertyChanged("Customer_Satisfaction_Score");
			}
		}

		[XmlIgnore]
		public bool Customer_Satisfaction_ScoreSpecified
		{
			get
			{
				return this.customer_Satisfaction_ScoreFieldSpecified;
			}
			set
			{
				this.customer_Satisfaction_ScoreFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Satisfaction_ScoreSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 23)]
		public DateTime Customer_Satisfaction_Date
		{
			get
			{
				return this.customer_Satisfaction_DateField;
			}
			set
			{
				this.customer_Satisfaction_DateField = value;
				this.RaisePropertyChanged("Customer_Satisfaction_Date");
			}
		}

		[XmlIgnore]
		public bool Customer_Satisfaction_DateSpecified
		{
			get
			{
				return this.customer_Satisfaction_DateFieldSpecified;
			}
			set
			{
				this.customer_Satisfaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Satisfaction_DateSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public string Customer_Satisfaction_Note
		{
			get
			{
				return this.customer_Satisfaction_NoteField;
			}
			set
			{
				this.customer_Satisfaction_NoteField = value;
				this.RaisePropertyChanged("Customer_Satisfaction_Note");
			}
		}

		[XmlElement(Order = 25)]
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

		[XmlElement("Tax_ID_Data", Order = 26)]
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

		[XmlElement("Lockbox_Reference", Order = 27)]
		public LockboxObjectType[] Lockbox_Reference
		{
			get
			{
				return this.lockbox_ReferenceField;
			}
			set
			{
				this.lockbox_ReferenceField = value;
				this.RaisePropertyChanged("Lockbox_Reference");
			}
		}

		[XmlElement("Included_Children_Reference", Order = 28)]
		public CustomerObjectType[] Included_Children_Reference
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

		[XmlElement("Customer_Security_Segment_Reference", Order = 29)]
		public Customer_Security_SegmentObjectType[] Customer_Security_Segment_Reference
		{
			get
			{
				return this.customer_Security_Segment_ReferenceField;
			}
			set
			{
				this.customer_Security_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Security_Segment_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Customer_Business_Entity_WWS_DataType Business_Entity_Data
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

		[XmlElement("Settlement_Account_Data", Order = 31)]
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

		[XmlElement("Credit_Card_Data", Order = 32)]
		public Customer_Credit_Card_Profile_WWS_DataType[] Credit_Card_Data
		{
			get
			{
				return this.credit_Card_DataField;
			}
			set
			{
				this.credit_Card_DataField = value;
				this.RaisePropertyChanged("Credit_Card_Data");
			}
		}

		[XmlElement("Customer_Status_Data", Order = 33)]
		public Customer_Status_DataType[] Customer_Status_Data
		{
			get
			{
				return this.customer_Status_DataField;
			}
			set
			{
				this.customer_Status_DataField = value;
				this.RaisePropertyChanged("Customer_Status_Data");
			}
		}

		[XmlElement(Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement("Accepted_Currencies_Reference", Order = 36)]
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

		[XmlElement("Remit-from_Customer_Reference", Order = 37)]
		public CustomerObjectType Remitfrom_Customer_Reference
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

		[XmlElement("Invoice_Delivery_Method_Reference", Order = 38)]
		public Delivery_MethodObjectType[] Invoice_Delivery_Method_Reference
		{
			get
			{
				return this.invoice_Delivery_Method_ReferenceField;
			}
			set
			{
				this.invoice_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Delivery_Method_Reference");
			}
		}

		[XmlElement("Invoice_Notification_Email_Recipients_Reference", Order = 39)]
		public Customer_Document_Email_Recipient_OptionObjectType[] Invoice_Notification_Email_Recipients_Reference
		{
			get
			{
				return this.invoice_Notification_Email_Recipients_ReferenceField;
			}
			set
			{
				this.invoice_Notification_Email_Recipients_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Notification_Email_Recipients_Reference");
			}
		}

		[XmlElement("Statement_Delivery_Method_Reference", Order = 40)]
		public Delivery_MethodObjectType[] Statement_Delivery_Method_Reference
		{
			get
			{
				return this.statement_Delivery_Method_ReferenceField;
			}
			set
			{
				this.statement_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Statement_Delivery_Method_Reference");
			}
		}

		[XmlElement("Statement_Notification_Email_Recipients_Reference", Order = 41)]
		public Customer_Document_Email_Recipient_OptionObjectType[] Statement_Notification_Email_Recipients_Reference
		{
			get
			{
				return this.statement_Notification_Email_Recipients_ReferenceField;
			}
			set
			{
				this.statement_Notification_Email_Recipients_ReferenceField = value;
				this.RaisePropertyChanged("Statement_Notification_Email_Recipients_Reference");
			}
		}

		[XmlElement("Dunning_Delivery_Method_Reference", Order = 42)]
		public Delivery_MethodObjectType[] Dunning_Delivery_Method_Reference
		{
			get
			{
				return this.dunning_Delivery_Method_ReferenceField;
			}
			set
			{
				this.dunning_Delivery_Method_ReferenceField = value;
				this.RaisePropertyChanged("Dunning_Delivery_Method_Reference");
			}
		}

		[XmlElement("Dunning_Letter_Notification_Email_Recipients_Reference", Order = 43)]
		public Customer_Document_Email_Recipient_OptionObjectType[] Dunning_Letter_Notification_Email_Recipients_Reference
		{
			get
			{
				return this.dunning_Letter_Notification_Email_Recipients_ReferenceField;
			}
			set
			{
				this.dunning_Letter_Notification_Email_Recipients_ReferenceField = value;
				this.RaisePropertyChanged("Dunning_Letter_Notification_Email_Recipients_Reference");
			}
		}

		[XmlElement(Order = 44)]
		public bool Mandate_Required
		{
			get
			{
				return this.mandate_RequiredField;
			}
			set
			{
				this.mandate_RequiredField = value;
				this.RaisePropertyChanged("Mandate_Required");
			}
		}

		[XmlIgnore]
		public bool Mandate_RequiredSpecified
		{
			get
			{
				return this.mandate_RequiredFieldSpecified;
			}
			set
			{
				this.mandate_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Mandate_RequiredSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public Payment_TypeObjectType Direct_Debit_Payment_Type_Reference
		{
			get
			{
				return this.direct_Debit_Payment_Type_ReferenceField;
			}
			set
			{
				this.direct_Debit_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Direct_Debit_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 46)]
		public SEPA_MandateObjectType Default_Mandate_Reference
		{
			get
			{
				return this.default_Mandate_ReferenceField;
			}
			set
			{
				this.default_Mandate_ReferenceField = value;
				this.RaisePropertyChanged("Default_Mandate_Reference");
			}
		}

		[XmlElement("Business_Entity_Alternate_Name_Data", Order = 47)]
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

		[XmlElement("Tax_Status_Data", Order = 48)]
		public Tax_Status_DataType[] Tax_Status_Data
		{
			get
			{
				return this.tax_Status_DataField;
			}
			set
			{
				this.tax_Status_DataField = value;
				this.RaisePropertyChanged("Tax_Status_Data");
			}
		}

		[XmlElement("Business_Entity_Attachment_Data", Order = 49)]
		public Financials_Attachment_DataType[] Business_Entity_Attachment_Data
		{
			get
			{
				return this.business_Entity_Attachment_DataField;
			}
			set
			{
				this.business_Entity_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Entity_Attachment_Data");
			}
		}

		[XmlElement("Note_Data", Order = 50)]
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

		[XmlElement(DataType = "date", Order = 51)]
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

		[XmlArray(Order = 52), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
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
