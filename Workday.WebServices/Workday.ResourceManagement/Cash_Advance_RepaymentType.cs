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
	public class Cash_Advance_RepaymentType : INotifyPropertyChanged
	{
		private Cash_Advance_RepaymentObjectType cash_Advance_Repayment_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Spend_AuthorizationObjectType spend_Authorization_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime repayment_DateField;

		private bool repayment_DateFieldSpecified;

		private decimal repayment_AmountField;

		private bool repayment_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string repayment_ReferenceField;

		private string memoField;

		private string credit_to_Expense_Advance_AccountField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private string currency_Exchange_Gain__Loss__to_RecordField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Cash_Advance_RepaymentObjectType Cash_Advance_Repayment_Reference
		{
			get
			{
				return this.cash_Advance_Repayment_ReferenceField;
			}
			set
			{
				this.cash_Advance_Repayment_ReferenceField = value;
				this.RaisePropertyChanged("Cash_Advance_Repayment_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Spend_AuthorizationObjectType Spend_Authorization_Reference
		{
			get
			{
				return this.spend_Authorization_ReferenceField;
			}
			set
			{
				this.spend_Authorization_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Authorization_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public WorkerObjectType Worker_Reference
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Repayment_Date
		{
			get
			{
				return this.repayment_DateField;
			}
			set
			{
				this.repayment_DateField = value;
				this.RaisePropertyChanged("Repayment_Date");
			}
		}

		[XmlIgnore]
		public bool Repayment_DateSpecified
		{
			get
			{
				return this.repayment_DateFieldSpecified;
			}
			set
			{
				this.repayment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Repayment_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Repayment_Amount
		{
			get
			{
				return this.repayment_AmountField;
			}
			set
			{
				this.repayment_AmountField = value;
				this.RaisePropertyChanged("Repayment_Amount");
			}
		}

		[XmlIgnore]
		public bool Repayment_AmountSpecified
		{
			get
			{
				return this.repayment_AmountFieldSpecified;
			}
			set
			{
				this.repayment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Repayment_AmountSpecified");
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public string Repayment_Reference
		{
			get
			{
				return this.repayment_ReferenceField;
			}
			set
			{
				this.repayment_ReferenceField = value;
				this.RaisePropertyChanged("Repayment_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Credit_to_Expense_Advance_Account
		{
			get
			{
				return this.credit_to_Expense_Advance_AccountField;
			}
			set
			{
				this.credit_to_Expense_Advance_AccountField = value;
				this.RaisePropertyChanged("Credit_to_Expense_Advance_Account");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public string Currency_Exchange_Gain__Loss__to_Record
		{
			get
			{
				return this.currency_Exchange_Gain__Loss__to_RecordField;
			}
			set
			{
				this.currency_Exchange_Gain__Loss__to_RecordField = value;
				this.RaisePropertyChanged("Currency_Exchange_Gain__Loss__to_Record");
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
