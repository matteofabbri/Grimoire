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
	public class Corporate_Credit_Card_Account_DataType : INotifyPropertyChanged
	{
		private string corporate_Credit_Card_Account_IDField;

		private string corporate_Credit_Card_Account_NameField;

		private Financial_InstitutionObjectType financial_Institution_ReferenceField;

		private Credit_Card_TypeObjectType credit_Card_Type_ReferenceField;

		private Credit_Card_Account_Usage_IndicatorObjectType usage_ReferenceField;

		private Corporate_Payment_ResponsibilityObjectType corporate_Payment_Responsibility_ReferenceField;

		private Expense_ItemObjectType[] expense_Item_ReferenceField;

		private bool electronic_Load_OnlyField;

		private bool electronic_Load_OnlyFieldSpecified;

		private bool allow_Negative_Reimbursable_TotalField;

		private bool allow_Negative_Reimbursable_TotalFieldSpecified;

		private bool pay_Unapproved_Credit_Card_TransactionsField;

		private bool pay_Unapproved_Credit_Card_TransactionsFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Accounting_WorktagObjectType[] optional_Balancing_Worktags_ReferenceField;

		private bool is_InactiveField;

		private bool is_InactiveFieldSpecified;

		private bool only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerField;

		private bool only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerFieldSpecified;

		private bool selfservice_Users_Can_t_Close_TransactionsField;

		private bool selfservice_Users_Can_t_Close_TransactionsFieldSpecified;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private bool produce_Remittance_FileField;

		private bool produce_Remittance_FileFieldSpecified;

		private string market_CodeField;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType billing_Currency_ReferenceField;

		private Integration_System__Audited_ObjectType integration_System_ReferenceField;

		private Contact_Information_DataType contact_DataField;

		private Settlement_Account_WWS_DataType[] settlement_Account_DataField;

		private Business_Entity_Alternate_Name_DataType[] alternate_Name_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Corporate_Credit_Card_Account_ID
		{
			get
			{
				return this.corporate_Credit_Card_Account_IDField;
			}
			set
			{
				this.corporate_Credit_Card_Account_IDField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Corporate_Credit_Card_Account_Name
		{
			get
			{
				return this.corporate_Credit_Card_Account_NameField;
			}
			set
			{
				this.corporate_Credit_Card_Account_NameField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Financial_InstitutionObjectType Financial_Institution_Reference
		{
			get
			{
				return this.financial_Institution_ReferenceField;
			}
			set
			{
				this.financial_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Credit_Card_TypeObjectType Credit_Card_Type_Reference
		{
			get
			{
				return this.credit_Card_Type_ReferenceField;
			}
			set
			{
				this.credit_Card_Type_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Credit_Card_Account_Usage_IndicatorObjectType Usage_Reference
		{
			get
			{
				return this.usage_ReferenceField;
			}
			set
			{
				this.usage_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Corporate_Payment_ResponsibilityObjectType Corporate_Payment_Responsibility_Reference
		{
			get
			{
				return this.corporate_Payment_Responsibility_ReferenceField;
			}
			set
			{
				this.corporate_Payment_Responsibility_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Payment_Responsibility_Reference");
			}
		}

		[XmlElement("Expense_Item_Reference", Order = 6)]
		public Expense_ItemObjectType[] Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Electronic_Load_Only
		{
			get
			{
				return this.electronic_Load_OnlyField;
			}
			set
			{
				this.electronic_Load_OnlyField = value;
				this.RaisePropertyChanged("Electronic_Load_Only");
			}
		}

		[XmlIgnore]
		public bool Electronic_Load_OnlySpecified
		{
			get
			{
				return this.electronic_Load_OnlyFieldSpecified;
			}
			set
			{
				this.electronic_Load_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Electronic_Load_OnlySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Allow_Negative_Reimbursable_Total
		{
			get
			{
				return this.allow_Negative_Reimbursable_TotalField;
			}
			set
			{
				this.allow_Negative_Reimbursable_TotalField = value;
				this.RaisePropertyChanged("Allow_Negative_Reimbursable_Total");
			}
		}

		[XmlIgnore]
		public bool Allow_Negative_Reimbursable_TotalSpecified
		{
			get
			{
				return this.allow_Negative_Reimbursable_TotalFieldSpecified;
			}
			set
			{
				this.allow_Negative_Reimbursable_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Negative_Reimbursable_TotalSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Pay_Unapproved_Credit_Card_Transactions
		{
			get
			{
				return this.pay_Unapproved_Credit_Card_TransactionsField;
			}
			set
			{
				this.pay_Unapproved_Credit_Card_TransactionsField = value;
				this.RaisePropertyChanged("Pay_Unapproved_Credit_Card_Transactions");
			}
		}

		[XmlIgnore]
		public bool Pay_Unapproved_Credit_Card_TransactionsSpecified
		{
			get
			{
				return this.pay_Unapproved_Credit_Card_TransactionsFieldSpecified;
			}
			set
			{
				this.pay_Unapproved_Credit_Card_TransactionsFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Unapproved_Credit_Card_TransactionsSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Balancing_WorktagObjectType Balancing_Worktag_Reference
		{
			get
			{
				return this.balancing_Worktag_ReferenceField;
			}
			set
			{
				this.balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Optional_Balancing_Worktags_Reference", Order = 13)]
		public Accounting_WorktagObjectType[] Optional_Balancing_Worktags_Reference
		{
			get
			{
				return this.optional_Balancing_Worktags_ReferenceField;
			}
			set
			{
				this.optional_Balancing_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Balancing_Worktags_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Is_Inactive
		{
			get
			{
				return this.is_InactiveField;
			}
			set
			{
				this.is_InactiveField = value;
				this.RaisePropertyChanged("Is_Inactive");
			}
		}

		[XmlIgnore]
		public bool Is_InactiveSpecified
		{
			get
			{
				return this.is_InactiveFieldSpecified;
			}
			set
			{
				this.is_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Is_InactiveSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Only_pay_Transactions_from_Expense_Reports_already_paid_to_Worker
		{
			get
			{
				return this.only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerField;
			}
			set
			{
				this.only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerField = value;
				this.RaisePropertyChanged("Only_pay_Transactions_from_Expense_Reports_already_paid_to_Worker");
			}
		}

		[XmlIgnore]
		public bool Only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerSpecified
		{
			get
			{
				return this.only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerFieldSpecified;
			}
			set
			{
				this.only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerFieldSpecified = value;
				this.RaisePropertyChanged("Only_pay_Transactions_from_Expense_Reports_already_paid_to_WorkerSpecified");
			}
		}

		[XmlElement("Self-service_Users_Can_t_Close_Transactions", Order = 16)]
		public bool Selfservice_Users_Can_t_Close_Transactions
		{
			get
			{
				return this.selfservice_Users_Can_t_Close_TransactionsField;
			}
			set
			{
				this.selfservice_Users_Can_t_Close_TransactionsField = value;
				this.RaisePropertyChanged("Selfservice_Users_Can_t_Close_Transactions");
			}
		}

		[XmlIgnore]
		public bool Selfservice_Users_Can_t_Close_TransactionsSpecified
		{
			get
			{
				return this.selfservice_Users_Can_t_Close_TransactionsFieldSpecified;
			}
			set
			{
				this.selfservice_Users_Can_t_Close_TransactionsFieldSpecified = value;
				this.RaisePropertyChanged("Selfservice_Users_Can_t_Close_TransactionsSpecified");
			}
		}

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public bool Produce_Remittance_File
		{
			get
			{
				return this.produce_Remittance_FileField;
			}
			set
			{
				this.produce_Remittance_FileField = value;
				this.RaisePropertyChanged("Produce_Remittance_File");
			}
		}

		[XmlIgnore]
		public bool Produce_Remittance_FileSpecified
		{
			get
			{
				return this.produce_Remittance_FileFieldSpecified;
			}
			set
			{
				this.produce_Remittance_FileFieldSpecified = value;
				this.RaisePropertyChanged("Produce_Remittance_FileSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public string Market_Code
		{
			get
			{
				return this.market_CodeField;
			}
			set
			{
				this.market_CodeField = value;
				this.RaisePropertyChanged("Market_Code");
			}
		}

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
		public CurrencyObjectType Billing_Currency_Reference
		{
			get
			{
				return this.billing_Currency_ReferenceField;
			}
			set
			{
				this.billing_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Currency_Reference");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public Contact_Information_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement("Settlement_Account_Data", Order = 24)]
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

		[XmlElement("Alternate_Name_Data", Order = 25)]
		public Business_Entity_Alternate_Name_DataType[] Alternate_Name_Data
		{
			get
			{
				return this.alternate_Name_DataField;
			}
			set
			{
				this.alternate_Name_DataField = value;
				this.RaisePropertyChanged("Alternate_Name_Data");
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
