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
	public class Spend_Authorization_Line_DataType : INotifyPropertyChanged
	{
		private Item_DescriptorObjectType expense_Item_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private bool billableField;

		private bool billableFieldSpecified;

		private bool cash_Advance_RequestedField;

		private bool cash_Advance_RequestedFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private string memoField;

		private DateTime budget_DateField;

		private bool budget_DateFieldSpecified;

		private Expense_Report_Line_Detail_DataType expense_Item_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Item_DescriptorObjectType Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Billable
		{
			get
			{
				return this.billableField;
			}
			set
			{
				this.billableField = value;
				this.RaisePropertyChanged("Billable");
			}
		}

		[XmlIgnore]
		public bool BillableSpecified
		{
			get
			{
				return this.billableFieldSpecified;
			}
			set
			{
				this.billableFieldSpecified = value;
				this.RaisePropertyChanged("BillableSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Cash_Advance_Requested
		{
			get
			{
				return this.cash_Advance_RequestedField;
			}
			set
			{
				this.cash_Advance_RequestedField = value;
				this.RaisePropertyChanged("Cash_Advance_Requested");
			}
		}

		[XmlIgnore]
		public bool Cash_Advance_RequestedSpecified
		{
			get
			{
				return this.cash_Advance_RequestedFieldSpecified;
			}
			set
			{
				this.cash_Advance_RequestedFieldSpecified = value;
				this.RaisePropertyChanged("Cash_Advance_RequestedSpecified");
			}
		}

		[XmlElement("Worktag_Reference", Order = 5)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
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

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Budget_Date
		{
			get
			{
				return this.budget_DateField;
			}
			set
			{
				this.budget_DateField = value;
				this.RaisePropertyChanged("Budget_Date");
			}
		}

		[XmlIgnore]
		public bool Budget_DateSpecified
		{
			get
			{
				return this.budget_DateFieldSpecified;
			}
			set
			{
				this.budget_DateFieldSpecified = value;
				this.RaisePropertyChanged("Budget_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Expense_Report_Line_Detail_DataType Expense_Item_Details_Data
		{
			get
			{
				return this.expense_Item_Details_DataField;
			}
			set
			{
				this.expense_Item_Details_DataField = value;
				this.RaisePropertyChanged("Expense_Item_Details_Data");
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
