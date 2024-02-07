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
	public class Beginning_Balance_Translation_Amount_Line_DataType : INotifyPropertyChanged
	{
		private CurrencyObjectType currency_ReferenceField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Ledger_AccountObjectType alternate_Ledger_Account_ReferenceField;

		private Accounting_WorktagObjectType[] accounting_Worktags_ReferenceField;

		private Balancing_WorktagObjectType affiliate_Balancing_Worktag_ReferenceField;

		private decimal itemField;

		private ItemChoiceType3 itemElementNameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Accounting_Worktags_Reference", Order = 3)]
		public Accounting_WorktagObjectType[] Accounting_Worktags_Reference
		{
			get
			{
				return this.accounting_Worktags_ReferenceField;
			}
			set
			{
				this.accounting_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Worktags_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Balancing_WorktagObjectType Affiliate_Balancing_Worktag_Reference
		{
			get
			{
				return this.affiliate_Balancing_Worktag_ReferenceField;
			}
			set
			{
				this.affiliate_Balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Affiliate_Balancing_Worktag_Reference");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Translated_Credit_Amount", typeof(decimal), Order = 5), XmlElement("Translated_Debit_Amount", typeof(decimal), Order = 5)]
		public decimal Item
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

		[XmlElement(Order = 6), XmlIgnore]
		public ItemChoiceType3 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
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
