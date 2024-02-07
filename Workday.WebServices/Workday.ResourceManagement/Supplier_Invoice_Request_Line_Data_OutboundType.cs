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
	public class Supplier_Invoice_Request_Line_Data_OutboundType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Request_Line_IDField;

		private string line_OrderField;

		private Supplier_Invoice_Request_LineObjectType supplier_Invoice_Request_Line_ReferenceField;

		private string line_TypeField;

		private Item_DescriptorObjectType purchase_Item_ReferenceField;

		private string item_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string memoField;

		private bool billableField;

		private bool billableFieldSpecified;

		private Supplier_Invoice_Request_Line_Split_Data_OutboundType[] supplier_Invoice_Request_Line_Splits_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Request_Line_ID
		{
			get
			{
				return this.supplier_Invoice_Request_Line_IDField;
			}
			set
			{
				this.supplier_Invoice_Request_Line_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Supplier_Invoice_Request_LineObjectType Supplier_Invoice_Request_Line_Reference
		{
			get
			{
				return this.supplier_Invoice_Request_Line_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Request_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Line_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Line_Type
		{
			get
			{
				return this.line_TypeField;
			}
			set
			{
				this.line_TypeField = value;
				this.RaisePropertyChanged("Line_Type");
			}
		}

		[XmlElement(Order = 4)]
		public Item_DescriptorObjectType Purchase_Item_Reference
		{
			get
			{
				return this.purchase_Item_ReferenceField;
			}
			set
			{
				this.purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 6)]
		public Accounting_CategoryObjectType Spend_Category_Reference
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement("Supplier_Invoice_Request_Line_Splits_Data", Order = 13)]
		public Supplier_Invoice_Request_Line_Split_Data_OutboundType[] Supplier_Invoice_Request_Line_Splits_Data
		{
			get
			{
				return this.supplier_Invoice_Request_Line_Splits_DataField;
			}
			set
			{
				this.supplier_Invoice_Request_Line_Splits_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Line_Splits_Data");
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
