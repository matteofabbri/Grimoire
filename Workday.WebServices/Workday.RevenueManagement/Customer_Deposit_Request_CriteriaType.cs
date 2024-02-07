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
	public class Customer_Deposit_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] company_ReferenceField;

		private CustomerObjectType[] customers_ReferenceField;

		private CustomerObjectType[] customer_Hierarchy_ReferenceField;

		private Business_Entity_Status_ValueObjectType[] customer_Status_ReferenceField;

		private Financial_AccountObjectType[] bank_Account_ReferenceField;

		private DateTime payment_Deposit_Date_On_or_AfterField;

		private bool payment_Deposit_Date_On_or_AfterFieldSpecified;

		private DateTime payment_Deposit_Date_On_or_BeforeField;

		private bool payment_Deposit_Date_On_or_BeforeFieldSpecified;

		private string deposit_Reference_NumberField;

		private Document_StatusObjectType[] deposit_Status_ReferenceField;

		private Reconciliation_StatusObjectType[] reconciliation_Status_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

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

		[XmlElement("Customers_Reference", Order = 1)]
		public CustomerObjectType[] Customers_Reference
		{
			get
			{
				return this.customers_ReferenceField;
			}
			set
			{
				this.customers_ReferenceField = value;
				this.RaisePropertyChanged("Customers_Reference");
			}
		}

		[XmlElement("Customer_Hierarchy_Reference", Order = 2)]
		public CustomerObjectType[] Customer_Hierarchy_Reference
		{
			get
			{
				return this.customer_Hierarchy_ReferenceField;
			}
			set
			{
				this.customer_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Hierarchy_Reference");
			}
		}

		[XmlElement("Customer_Status_Reference", Order = 3)]
		public Business_Entity_Status_ValueObjectType[] Customer_Status_Reference
		{
			get
			{
				return this.customer_Status_ReferenceField;
			}
			set
			{
				this.customer_Status_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Status_Reference");
			}
		}

		[XmlElement("Bank_Account_Reference", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Payment_Deposit_Date_On_or_After
		{
			get
			{
				return this.payment_Deposit_Date_On_or_AfterField;
			}
			set
			{
				this.payment_Deposit_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Payment_Deposit_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Payment_Deposit_Date_On_or_AfterSpecified
		{
			get
			{
				return this.payment_Deposit_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.payment_Deposit_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Deposit_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Payment_Deposit_Date_On_or_Before
		{
			get
			{
				return this.payment_Deposit_Date_On_or_BeforeField;
			}
			set
			{
				this.payment_Deposit_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Payment_Deposit_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Payment_Deposit_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.payment_Deposit_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.payment_Deposit_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Deposit_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Deposit_Status_Reference", Order = 8)]
		public Document_StatusObjectType[] Deposit_Status_Reference
		{
			get
			{
				return this.deposit_Status_ReferenceField;
			}
			set
			{
				this.deposit_Status_ReferenceField = value;
				this.RaisePropertyChanged("Deposit_Status_Reference");
			}
		}

		[XmlElement("Reconciliation_Status_Reference", Order = 9)]
		public Reconciliation_StatusObjectType[] Reconciliation_Status_Reference
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

		[XmlElement("Worker_Reference", Order = 10)]
		public WorkerObjectType[] Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
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
