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
	public class Inventory_Return_Order_Line_Data_WSType : INotifyPropertyChanged
	{
		private Inventory_Return_LineObjectType inventory_Return_Line_ReferenceField;

		private Unique_IdentifierObjectType inventory_Transaction_ReferenceField;

		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal return_QuantityField;

		private bool return_QuantityFieldSpecified;

		private Inventory_Adjustment_ReasonObjectType inventory_Return_Reason_ReferenceField;

		private Document_StatusObjectType inventory_Document_Status_ReferenceField;

		private string memoField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Return_LineObjectType Inventory_Return_Line_Reference
		{
			get
			{
				return this.inventory_Return_Line_ReferenceField;
			}
			set
			{
				this.inventory_Return_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Inventory_Transaction_Reference
		{
			get
			{
				return this.inventory_Transaction_ReferenceField;
			}
			set
			{
				this.inventory_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_ItemObjectType Inventory_Item_Reference
		{
			get
			{
				return this.inventory_Item_ReferenceField;
			}
			set
			{
				this.inventory_Item_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Item_LotObjectType Item_Lot_Reference
		{
			get
			{
				return this.item_Lot_ReferenceField;
			}
			set
			{
				this.item_Lot_ReferenceField = value;
				this.RaisePropertyChanged("Item_Lot_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Return_Quantity
		{
			get
			{
				return this.return_QuantityField;
			}
			set
			{
				this.return_QuantityField = value;
				this.RaisePropertyChanged("Return_Quantity");
			}
		}

		[XmlIgnore]
		public bool Return_QuantitySpecified
		{
			get
			{
				return this.return_QuantityFieldSpecified;
			}
			set
			{
				this.return_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Return_QuantitySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Inventory_Adjustment_ReasonObjectType Inventory_Return_Reason_Reference
		{
			get
			{
				return this.inventory_Return_Reason_ReferenceField;
			}
			set
			{
				this.inventory_Return_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Reason_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Document_StatusObjectType Inventory_Document_Status_Reference
		{
			get
			{
				return this.inventory_Document_Status_ReferenceField;
			}
			set
			{
				this.inventory_Document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Document_Status_Reference");
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

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 9)]
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

		[XmlElement("Item_Tag_Reference", Order = 10)]
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
