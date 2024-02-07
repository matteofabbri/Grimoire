using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Budget_Amendment_Entry_High_Volume_DataType : INotifyPropertyChanged
	{
		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType[] accounting_Worktag_ReferenceField;

		private object itemField;

		private CurrencyObjectType budget_Currency_ReferenceField;

		private decimal budget_Debit_AmountField;

		private bool budget_Debit_AmountFieldSpecified;

		private decimal budget_Credit_AmountField;

		private bool budget_Credit_AmountFieldSpecified;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Fiscal_Time_IntervalObjectType Fiscal_Time_Interval_Reference
		{
			get
			{
				return this.fiscal_Time_Interval_ReferenceField;
			}
			set
			{
				this.fiscal_Time_Interval_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Time_Interval_Reference");
			}
		}

		[XmlElement("Accounting_Worktag_Reference", Order = 1)]
		public Accounting_Worktag_and_Aggregation_DimensionObjectType[] Accounting_Worktag_Reference
		{
			get
			{
				return this.accounting_Worktag_ReferenceField;
			}
			set
			{
				this.accounting_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Worktag_Reference");
			}
		}

		[XmlElement("Ledger_Account_Reference", typeof(Ledger_AccountObjectType), Order = 2), XmlElement("Ledger_Account_Summary_Reference", typeof(Ledger_Account_SummaryObjectType), Order = 2)]
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

		[XmlElement(Order = 3)]
		public CurrencyObjectType Budget_Currency_Reference
		{
			get
			{
				return this.budget_Currency_ReferenceField;
			}
			set
			{
				this.budget_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Budget_Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Budget_Debit_Amount
		{
			get
			{
				return this.budget_Debit_AmountField;
			}
			set
			{
				this.budget_Debit_AmountField = value;
				this.RaisePropertyChanged("Budget_Debit_Amount");
			}
		}

		[XmlIgnore]
		public bool Budget_Debit_AmountSpecified
		{
			get
			{
				return this.budget_Debit_AmountFieldSpecified;
			}
			set
			{
				this.budget_Debit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Budget_Debit_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Budget_Credit_Amount
		{
			get
			{
				return this.budget_Credit_AmountField;
			}
			set
			{
				this.budget_Credit_AmountField = value;
				this.RaisePropertyChanged("Budget_Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Budget_Credit_AmountSpecified
		{
			get
			{
				return this.budget_Credit_AmountFieldSpecified;
			}
			set
			{
				this.budget_Credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Budget_Credit_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
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
