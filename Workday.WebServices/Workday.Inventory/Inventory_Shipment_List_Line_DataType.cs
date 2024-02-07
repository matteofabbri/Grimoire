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
	public class Inventory_Shipment_List_Line_DataType : INotifyPropertyChanged
	{
		private ImageObjectType image_ReferenceField;

		private Purchase_ItemObjectType item_Descriptor_ReferenceField;

		private string line_Item_DescriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private Item_SerialObjectType[] serial_Number_ReferenceField;

		private Unique_IdentifierObjectType inventory_Location_Quantity_ReferenceField;

		private Purchase_ItemObjectType item_Requested_ReferenceField;

		private string memoField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		private Inventory_Pick_List_LineObjectType inventory_Picking_List_Line_ReferenceField;

		private Spend_CategoryObjectType accounting_Category_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private decimal ship_List_Line_NumberField;

		private bool ship_List_Line_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ImageObjectType Image_Reference
		{
			get
			{
				return this.image_ReferenceField;
			}
			set
			{
				this.image_ReferenceField = value;
				this.RaisePropertyChanged("Image_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Purchase_ItemObjectType Item_Descriptor_Reference
		{
			get
			{
				return this.item_Descriptor_ReferenceField;
			}
			set
			{
				this.item_Descriptor_ReferenceField = value;
				this.RaisePropertyChanged("Item_Descriptor_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement("Serial_Number_Reference", Order = 6)]
		public Item_SerialObjectType[] Serial_Number_Reference
		{
			get
			{
				return this.serial_Number_ReferenceField;
			}
			set
			{
				this.serial_Number_ReferenceField = value;
				this.RaisePropertyChanged("Serial_Number_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Inventory_Location_Quantity_Reference
		{
			get
			{
				return this.inventory_Location_Quantity_ReferenceField;
			}
			set
			{
				this.inventory_Location_Quantity_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Quantity_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Purchase_ItemObjectType Item_Requested_Reference
		{
			get
			{
				return this.item_Requested_ReferenceField;
			}
			set
			{
				this.item_Requested_ReferenceField = value;
				this.RaisePropertyChanged("Item_Requested_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 10)]
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

		[XmlElement("Item_Tag_Reference", Order = 11)]
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

		[XmlElement(Order = 12)]
		public Inventory_Pick_List_LineObjectType Inventory_Picking_List_Line_Reference
		{
			get
			{
				return this.inventory_Picking_List_Line_ReferenceField;
			}
			set
			{
				this.inventory_Picking_List_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Picking_List_Line_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Spend_CategoryObjectType Accounting_Category_Reference
		{
			get
			{
				return this.accounting_Category_ReferenceField;
			}
			set
			{
				this.accounting_Category_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Category_Reference");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public decimal Ship_List_Line_Number
		{
			get
			{
				return this.ship_List_Line_NumberField;
			}
			set
			{
				this.ship_List_Line_NumberField = value;
				this.RaisePropertyChanged("Ship_List_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Ship_List_Line_NumberSpecified
		{
			get
			{
				return this.ship_List_Line_NumberFieldSpecified;
			}
			set
			{
				this.ship_List_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Ship_List_Line_NumberSpecified");
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
