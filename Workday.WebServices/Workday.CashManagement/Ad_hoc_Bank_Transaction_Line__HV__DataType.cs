using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ad_hoc_Bank_Transaction_Line__HV__DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Ledger_AccountObjectType alternate_Ledger_Account_ReferenceField;

		private decimal line_AmountField;

		private string line_MemoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_Affiliate_ReferenceField;

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
		public CompanyObjectType Intercompany_Affiliate_Reference
		{
			get
			{
				return this.intercompany_Affiliate_ReferenceField;
			}
			set
			{
				this.intercompany_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Affiliate_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Spend_CategoryObjectType Resource_Category_Reference
		{
			get
			{
				return this.resource_Category_ReferenceField;
			}
			set
			{
				this.resource_Category_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Category_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Revenue_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Ledger_AccountObjectType Alternate_Ledger_Account_Reference
		{
			get
			{
				return this.alternate_Ledger_Account_ReferenceField;
			}
			set
			{
				this.alternate_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Ledger_Account_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Line_Amount
		{
			get
			{
				return this.line_AmountField;
			}
			set
			{
				this.line_AmountField = value;
				this.RaisePropertyChanged("Line_Amount");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Worktags_Reference", Order = 8)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Balancing_WorktagObjectType Balancing_Worktag_Affiliate_Reference
		{
			get
			{
				return this.balancing_Worktag_Affiliate_ReferenceField;
			}
			set
			{
				this.balancing_Worktag_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Balancing_Worktag_Affiliate_Reference");
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
