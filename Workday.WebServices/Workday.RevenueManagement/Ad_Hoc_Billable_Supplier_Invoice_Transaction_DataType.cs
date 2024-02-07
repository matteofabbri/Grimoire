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
	public class Ad_Hoc_Billable_Supplier_Invoice_Transaction_DataType : INotifyPropertyChanged
	{
		private ProjectObjectType billable_Project_ReferenceField;

		private Document_StatusObjectType billing_Status_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Item_DescriptorObjectType item_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_AmountField;

		private bool unit_AmountFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ProjectObjectType Billable_Project_Reference
		{
			get
			{
				return this.billable_Project_ReferenceField;
			}
			set
			{
				this.billable_Project_ReferenceField = value;
				this.RaisePropertyChanged("Billable_Project_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Billing_Status_Reference
		{
			get
			{
				return this.billing_Status_ReferenceField;
			}
			set
			{
				this.billing_Status_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Item_DescriptorObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Unit_Amount
		{
			get
			{
				return this.unit_AmountField;
			}
			set
			{
				this.unit_AmountField = value;
				this.RaisePropertyChanged("Unit_Amount");
			}
		}

		[XmlIgnore]
		public bool Unit_AmountSpecified
		{
			get
			{
				return this.unit_AmountFieldSpecified;
			}
			set
			{
				this.unit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Unit_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement("Worktags_Reference", Order = 10)]
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

		[XmlElement(Order = 11)]
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
