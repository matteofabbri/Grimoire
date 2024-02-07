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
	public class Position_Budget_Line_Replacement__HV__DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private Ledger_AccountObjectType compensation_Account_ReferenceField;

		private Ledger_AccountObjectType fringe_Account_ReferenceField;

		private decimal compensation_AmountField;

		private bool compensation_AmountFieldSpecified;

		private decimal fringe_AmountField;

		private bool fringe_AmountFieldSpecified;

		private Accounting_WorktagObjectType[] accounting_Worktag_ReferenceField;

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
		public Ledger_AccountObjectType Compensation_Account_Reference
		{
			get
			{
				return this.compensation_Account_ReferenceField;
			}
			set
			{
				this.compensation_Account_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Account_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_AccountObjectType Fringe_Account_Reference
		{
			get
			{
				return this.fringe_Account_ReferenceField;
			}
			set
			{
				this.fringe_Account_ReferenceField = value;
				this.RaisePropertyChanged("Fringe_Account_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Compensation_Amount
		{
			get
			{
				return this.compensation_AmountField;
			}
			set
			{
				this.compensation_AmountField = value;
				this.RaisePropertyChanged("Compensation_Amount");
			}
		}

		[XmlIgnore]
		public bool Compensation_AmountSpecified
		{
			get
			{
				return this.compensation_AmountFieldSpecified;
			}
			set
			{
				this.compensation_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Compensation_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Fringe_Amount
		{
			get
			{
				return this.fringe_AmountField;
			}
			set
			{
				this.fringe_AmountField = value;
				this.RaisePropertyChanged("Fringe_Amount");
			}
		}

		[XmlIgnore]
		public bool Fringe_AmountSpecified
		{
			get
			{
				return this.fringe_AmountFieldSpecified;
			}
			set
			{
				this.fringe_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Fringe_AmountSpecified");
			}
		}

		[XmlElement("Accounting_Worktag_Reference", Order = 5)]
		public Accounting_WorktagObjectType[] Accounting_Worktag_Reference
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
