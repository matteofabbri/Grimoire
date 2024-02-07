using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class General_Payment_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private Financial_AccountObjectType[] bank_Account_ReferenceField;

		private Payment_CategoryObjectType[] payment_Category_ReferenceField;

		private PayeeObjectType[] payee_ReferenceField;

		private HierarchyObjectType[] payee_Hierarchy_ReferenceField;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private Payment_StatusObjectType[] payment_Status_ReferenceField;

		private Business_Entity_Status_ValueObjectType[] customer_Supplier_Status_ReferenceField;

		private CurrencyObjectType[] currency_ReferenceField;

		private DateTime payment_Date_on_Date_Or_AfterField;

		private bool payment_Date_on_Date_Or_AfterFieldSpecified;

		private DateTime payment_Date_on_Date_Or_BeforeField;

		private bool payment_Date_on_Date_Or_BeforeFieldSpecified;

		private string transaction_Reference_NumberField;

		private Unique_IdentifierObjectType[] settlement_Run_ReferenceField;

		private string settlement_Run_NumberField;

		private string settlement_Run_NameField;

		private WorkerObjectType[] created_by_Worker_ReferenceField;

		private decimal payment_Amount_Equal_ToField;

		private bool payment_Amount_Equal_ToFieldSpecified;

		private decimal payment_Amount_Greater_ThanField;

		private bool payment_Amount_Greater_ThanFieldSpecified;

		private decimal payment_Amount_Less_ThanField;

		private bool payment_Amount_Less_ThanFieldSpecified;

		private Unique_IdentifierObjectType[] expense_Payee_Type_ReferenceField;

		private bool transaction_Is_IntercompanyField;

		private bool transaction_Is_IntercompanyFieldSpecified;

		private CompanyObjectType[] company_Receiving_Payment_ReferenceField;

		private PeriodObjectType[] periods_ReferenceField;

		private Pay_Run_Group_SelectionObjectType[] pay_Run_Groups_and_or_Pay_Groups_ReferenceField;

		private string eFT_Payment_IDField;

		private Reconciliation_StatusObjectType reconciliation_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", Order = 0)]
		public OrganizationObjectType[] Company_Reference
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

		[XmlElement("Bank_Account_Reference", Order = 1)]
		public Financial_AccountObjectType[] Bank_Account_Reference
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

		[XmlElement("Payment_Category_Reference", Order = 2)]
		public Payment_CategoryObjectType[] Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
			}
		}

		[XmlElement("Payee_Reference", Order = 3)]
		public PayeeObjectType[] Payee_Reference
		{
			get
			{
				return this.payee_ReferenceField;
			}
			set
			{
				this.payee_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Reference");
			}
		}

		[XmlElement("Payee_Hierarchy_Reference", Order = 4)]
		public HierarchyObjectType[] Payee_Hierarchy_Reference
		{
			get
			{
				return this.payee_Hierarchy_ReferenceField;
			}
			set
			{
				this.payee_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Hierarchy_Reference");
			}
		}

		[XmlElement("Payment_Type_Reference", Order = 5)]
		public Payment_TypeObjectType[] Payment_Type_Reference
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

		[XmlElement("Payment_Status_Reference", Order = 6)]
		public Payment_StatusObjectType[] Payment_Status_Reference
		{
			get
			{
				return this.payment_Status_ReferenceField;
			}
			set
			{
				this.payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Status_Reference");
			}
		}

		[XmlElement("Customer_Supplier_Status_Reference", Order = 7)]
		public Business_Entity_Status_ValueObjectType[] Customer_Supplier_Status_Reference
		{
			get
			{
				return this.customer_Supplier_Status_ReferenceField;
			}
			set
			{
				this.customer_Supplier_Status_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Supplier_Status_Reference");
			}
		}

		[XmlElement("Currency_Reference", Order = 8)]
		public CurrencyObjectType[] Currency_Reference
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

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Payment_Date_on_Date_Or_After
		{
			get
			{
				return this.payment_Date_on_Date_Or_AfterField;
			}
			set
			{
				this.payment_Date_on_Date_Or_AfterField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_After");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_Or_AfterSpecified
		{
			get
			{
				return this.payment_Date_on_Date_Or_AfterFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_Or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Payment_Date_on_Date_Or_Before
		{
			get
			{
				return this.payment_Date_on_Date_Or_BeforeField;
			}
			set
			{
				this.payment_Date_on_Date_Or_BeforeField = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_Before");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_on_Date_Or_BeforeSpecified
		{
			get
			{
				return this.payment_Date_on_Date_Or_BeforeFieldSpecified;
			}
			set
			{
				this.payment_Date_on_Date_Or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_on_Date_Or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public string Transaction_Reference_Number
		{
			get
			{
				return this.transaction_Reference_NumberField;
			}
			set
			{
				this.transaction_Reference_NumberField = value;
				this.RaisePropertyChanged("Transaction_Reference_Number");
			}
		}

		[XmlElement("Settlement_Run_Reference", Order = 12)]
		public Unique_IdentifierObjectType[] Settlement_Run_Reference
		{
			get
			{
				return this.settlement_Run_ReferenceField;
			}
			set
			{
				this.settlement_Run_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_Run_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public string Settlement_Run_Number
		{
			get
			{
				return this.settlement_Run_NumberField;
			}
			set
			{
				this.settlement_Run_NumberField = value;
				this.RaisePropertyChanged("Settlement_Run_Number");
			}
		}

		[XmlElement(Order = 14)]
		public string Settlement_Run_Name
		{
			get
			{
				return this.settlement_Run_NameField;
			}
			set
			{
				this.settlement_Run_NameField = value;
				this.RaisePropertyChanged("Settlement_Run_Name");
			}
		}

		[XmlElement("Created_by_Worker_Reference", Order = 15)]
		public WorkerObjectType[] Created_by_Worker_Reference
		{
			get
			{
				return this.created_by_Worker_ReferenceField;
			}
			set
			{
				this.created_by_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Created_by_Worker_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Payment_Amount_Equal_To
		{
			get
			{
				return this.payment_Amount_Equal_ToField;
			}
			set
			{
				this.payment_Amount_Equal_ToField = value;
				this.RaisePropertyChanged("Payment_Amount_Equal_To");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_Equal_ToSpecified
		{
			get
			{
				return this.payment_Amount_Equal_ToFieldSpecified;
			}
			set
			{
				this.payment_Amount_Equal_ToFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_Equal_ToSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Payment_Amount_Greater_Than
		{
			get
			{
				return this.payment_Amount_Greater_ThanField;
			}
			set
			{
				this.payment_Amount_Greater_ThanField = value;
				this.RaisePropertyChanged("Payment_Amount_Greater_Than");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_Greater_ThanSpecified
		{
			get
			{
				return this.payment_Amount_Greater_ThanFieldSpecified;
			}
			set
			{
				this.payment_Amount_Greater_ThanFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_Greater_ThanSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Payment_Amount_Less_Than
		{
			get
			{
				return this.payment_Amount_Less_ThanField;
			}
			set
			{
				this.payment_Amount_Less_ThanField = value;
				this.RaisePropertyChanged("Payment_Amount_Less_Than");
			}
		}

		[XmlIgnore]
		public bool Payment_Amount_Less_ThanSpecified
		{
			get
			{
				return this.payment_Amount_Less_ThanFieldSpecified;
			}
			set
			{
				this.payment_Amount_Less_ThanFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Amount_Less_ThanSpecified");
			}
		}

		[XmlElement("Expense_Payee_Type_Reference", Order = 19)]
		public Unique_IdentifierObjectType[] Expense_Payee_Type_Reference
		{
			get
			{
				return this.expense_Payee_Type_ReferenceField;
			}
			set
			{
				this.expense_Payee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Type_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public bool Transaction_Is_Intercompany
		{
			get
			{
				return this.transaction_Is_IntercompanyField;
			}
			set
			{
				this.transaction_Is_IntercompanyField = value;
				this.RaisePropertyChanged("Transaction_Is_Intercompany");
			}
		}

		[XmlIgnore]
		public bool Transaction_Is_IntercompanySpecified
		{
			get
			{
				return this.transaction_Is_IntercompanyFieldSpecified;
			}
			set
			{
				this.transaction_Is_IntercompanyFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Is_IntercompanySpecified");
			}
		}

		[XmlElement("Company_Receiving_Payment_Reference", Order = 21)]
		public CompanyObjectType[] Company_Receiving_Payment_Reference
		{
			get
			{
				return this.company_Receiving_Payment_ReferenceField;
			}
			set
			{
				this.company_Receiving_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Company_Receiving_Payment_Reference");
			}
		}

		[XmlElement("Periods_Reference", Order = 22)]
		public PeriodObjectType[] Periods_Reference
		{
			get
			{
				return this.periods_ReferenceField;
			}
			set
			{
				this.periods_ReferenceField = value;
				this.RaisePropertyChanged("Periods_Reference");
			}
		}

		[XmlElement("Pay_Run_Groups_and_or_Pay_Groups_Reference", Order = 23)]
		public Pay_Run_Group_SelectionObjectType[] Pay_Run_Groups_and_or_Pay_Groups_Reference
		{
			get
			{
				return this.pay_Run_Groups_and_or_Pay_Groups_ReferenceField;
			}
			set
			{
				this.pay_Run_Groups_and_or_Pay_Groups_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Run_Groups_and_or_Pay_Groups_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public string EFT_Payment_ID
		{
			get
			{
				return this.eFT_Payment_IDField;
			}
			set
			{
				this.eFT_Payment_IDField = value;
				this.RaisePropertyChanged("EFT_Payment_ID");
			}
		}

		[XmlElement(Order = 25)]
		public Reconciliation_StatusObjectType Reconciliation_Status_Reference
		{
			get
			{
				return this.reconciliation_Status_ReferenceField;
			}
			set
			{
				this.reconciliation_Status_ReferenceField = value;
				this.RaisePropertyChanged("Reconciliation_Status_Reference");
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
