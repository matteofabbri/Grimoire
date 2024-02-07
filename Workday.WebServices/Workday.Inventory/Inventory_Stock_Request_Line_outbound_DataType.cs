using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Stock_Request_Line_outbound_DataType : INotifyPropertyChanged
	{
		private Inventory_Stock_Request_LineObjectType inventory_Stock_Request_Line_ReferenceField;

		private decimal stock_Request_Line_NumberField;

		private bool stock_Request_Line_NumberFieldSpecified;

		private Purchase_ItemObjectType item_ReferenceField;

		private string item_DescriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal requested_QuantityField;

		private bool requested_QuantityFieldSpecified;

		private decimal picked_QuantityField;

		private bool picked_QuantityFieldSpecified;

		private decimal quantity_ShippedField;

		private bool quantity_ShippedFieldSpecified;

		private bool is_In_TransitField;

		private bool is_In_TransitFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private DateTime fulfillment_DateField;

		private bool fulfillment_DateFieldSpecified;

		private Business_Document_LineObjectType[] all_Allocated_to_Fulfillment_Document_Lines_ReferenceField;

		private Document_StatusObjectType line_Status_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string line_MemoField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Stock_Request_LineObjectType Inventory_Stock_Request_Line_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Line_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Stock_Request_Line_Number
		{
			get
			{
				return this.stock_Request_Line_NumberField;
			}
			set
			{
				this.stock_Request_Line_NumberField = value;
				this.RaisePropertyChanged("Stock_Request_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Stock_Request_Line_NumberSpecified
		{
			get
			{
				return this.stock_Request_Line_NumberFieldSpecified;
			}
			set
			{
				this.stock_Request_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Stock_Request_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_ItemObjectType Item_Reference
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Requested_Quantity
		{
			get
			{
				return this.requested_QuantityField;
			}
			set
			{
				this.requested_QuantityField = value;
				this.RaisePropertyChanged("Requested_Quantity");
			}
		}

		[XmlIgnore]
		public bool Requested_QuantitySpecified
		{
			get
			{
				return this.requested_QuantityFieldSpecified;
			}
			set
			{
				this.requested_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Requested_QuantitySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Picked_Quantity
		{
			get
			{
				return this.picked_QuantityField;
			}
			set
			{
				this.picked_QuantityField = value;
				this.RaisePropertyChanged("Picked_Quantity");
			}
		}

		[XmlIgnore]
		public bool Picked_QuantitySpecified
		{
			get
			{
				return this.picked_QuantityFieldSpecified;
			}
			set
			{
				this.picked_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Picked_QuantitySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Quantity_Shipped
		{
			get
			{
				return this.quantity_ShippedField;
			}
			set
			{
				this.quantity_ShippedField = value;
				this.RaisePropertyChanged("Quantity_Shipped");
			}
		}

		[XmlIgnore]
		public bool Quantity_ShippedSpecified
		{
			get
			{
				return this.quantity_ShippedFieldSpecified;
			}
			set
			{
				this.quantity_ShippedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_ShippedSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Is_In_Transit
		{
			get
			{
				return this.is_In_TransitField;
			}
			set
			{
				this.is_In_TransitField = value;
				this.RaisePropertyChanged("Is_In_Transit");
			}
		}

		[XmlIgnore]
		public bool Is_In_TransitSpecified
		{
			get
			{
				return this.is_In_TransitFieldSpecified;
			}
			set
			{
				this.is_In_TransitFieldSpecified = value;
				this.RaisePropertyChanged("Is_In_TransitSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Fulfillment_Date
		{
			get
			{
				return this.fulfillment_DateField;
			}
			set
			{
				this.fulfillment_DateField = value;
				this.RaisePropertyChanged("Fulfillment_Date");
			}
		}

		[XmlIgnore]
		public bool Fulfillment_DateSpecified
		{
			get
			{
				return this.fulfillment_DateFieldSpecified;
			}
			set
			{
				this.fulfillment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Fulfillment_DateSpecified");
			}
		}

		[XmlElement("All_Allocated_to_Fulfillment_Document_Lines_Reference", Order = 13)]
		public Business_Document_LineObjectType[] All_Allocated_to_Fulfillment_Document_Lines_Reference
		{
			get
			{
				return this.all_Allocated_to_Fulfillment_Document_Lines_ReferenceField;
			}
			set
			{
				this.all_Allocated_to_Fulfillment_Document_Lines_ReferenceField = value;
				this.RaisePropertyChanged("All_Allocated_to_Fulfillment_Document_Lines_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Document_StatusObjectType Line_Status_Reference
		{
			get
			{
				return this.line_Status_ReferenceField;
			}
			set
			{
				this.line_Status_ReferenceField = value;
				this.RaisePropertyChanged("Line_Status_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 17)]
		public Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] Alternate_Item_Identifiers_Data
		{
			get
			{
				return this.alternate_Item_Identifiers_DataField;
			}
			set
			{
				this.alternate_Item_Identifiers_DataField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifiers_Data");
			}
		}

		[XmlElement("Item_Tag_Reference", Order = 18)]
		public Item_TagObjectType[] Item_Tag_Reference
		{
			get
			{
				return this.item_Tag_ReferenceField;
			}
			set
			{
				this.item_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Item_Tag_Reference");
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
