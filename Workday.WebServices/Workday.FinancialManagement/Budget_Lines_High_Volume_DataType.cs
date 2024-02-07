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
	public class Budget_Lines_High_Volume_DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private CompanyObjectType company_ReferenceField;

		private decimal yearField;

		private bool yearFieldSpecified;

		private Fiscal_Time_IntervalObjectType fiscal_Time_Interval_ReferenceField;

		private Financial_Report_GroupObjectType ledger_Account_or_Ledger_Account_Summary_ReferenceField;

		private CurrencyObjectType budget_Currency_ReferenceField;

		private decimal budget_Debit_AmountField;

		private bool budget_Debit_AmountFieldSpecified;

		private decimal budget_Credit_AmountField;

		private bool budget_Credit_AmountFieldSpecified;

		private string memoField;

		private Accounting_Worktag_and_Aggregation_DimensionObjectType[] accounting_Worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
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
		public decimal Year
		{
			get
			{
				return this.yearField;
			}
			set
			{
				this.yearField = value;
				this.RaisePropertyChanged("Year");
			}
		}

		[XmlIgnore]
		public bool YearSpecified
		{
			get
			{
				return this.yearFieldSpecified;
			}
			set
			{
				this.yearFieldSpecified = value;
				this.RaisePropertyChanged("YearSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Financial_Report_GroupObjectType Ledger_Account_or_Ledger_Account_Summary_Reference
		{
			get
			{
				return this.ledger_Account_or_Ledger_Account_Summary_ReferenceField;
			}
			set
			{
				this.ledger_Account_or_Ledger_Account_Summary_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_or_Ledger_Account_Summary_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Accounting_Worktag_Reference", Order = 9)]
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
