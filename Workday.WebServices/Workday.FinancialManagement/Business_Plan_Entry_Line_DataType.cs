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
	public class Business_Plan_Entry_Line_DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Ledger_Account_SummaryObjectType ledger_Account_Summary_ReferenceField;

		private decimal debit_AmountField;

		private bool debit_AmountFieldSpecified;

		private decimal credit_AmountField;

		private bool credit_AmountFieldSpecified;

		private string line_MemoField;

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
		public Ledger_AccountObjectType Ledger_Account_Reference
		{
			get
			{
				return this.ledger_Account_ReferenceField;
			}
			set
			{
				this.ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_Account_SummaryObjectType Ledger_Account_Summary_Reference
		{
			get
			{
				return this.ledger_Account_Summary_ReferenceField;
			}
			set
			{
				this.ledger_Account_Summary_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Summary_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Debit_Amount
		{
			get
			{
				return this.debit_AmountField;
			}
			set
			{
				this.debit_AmountField = value;
				this.RaisePropertyChanged("Debit_Amount");
			}
		}

		[XmlIgnore]
		public bool Debit_AmountSpecified
		{
			get
			{
				return this.debit_AmountFieldSpecified;
			}
			set
			{
				this.debit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Debit_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Credit_Amount
		{
			get
			{
				return this.credit_AmountField;
			}
			set
			{
				this.credit_AmountField = value;
				this.RaisePropertyChanged("Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Credit_AmountSpecified
		{
			get
			{
				return this.credit_AmountFieldSpecified;
			}
			set
			{
				this.credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Credit_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Line_Memo
		{
			get
			{
				return this.line_MemoField;
			}
			set
			{
				this.line_MemoField = value;
				this.RaisePropertyChanged("Line_Memo");
			}
		}

		[XmlElement("Accounting_Worktag_Reference", Order = 6)]
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
