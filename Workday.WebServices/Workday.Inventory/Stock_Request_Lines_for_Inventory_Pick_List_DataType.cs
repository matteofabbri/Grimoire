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
	public class Stock_Request_Lines_for_Inventory_Pick_List_DataType : INotifyPropertyChanged
	{
		private Inventory_Stock_Request_LineObjectType inventory_Stock_Request_Line_ReferenceField;

		private DateTime fulfillment_DateField;

		private bool fulfillment_DateFieldSpecified;

		private Purchase_ItemObjectType item_ReferenceField;

		private Item_DescriptorObjectType item_Descriptor_ReferenceField;

		private string line_Item_DescriptionField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantity_RequestedField;

		private bool quantity_RequestedFieldSpecified;

		private decimal quantity_ShippedField;

		private bool quantity_ShippedFieldSpecified;

		private decimal total_Quantity_PickedField;

		private bool total_Quantity_PickedFieldSpecified;

		private string line_MemoField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		private Pick_Inventory_Locations_DataType[] pick_Inventory_Locations_LinesField;

		private Inventory_Fulfillment_Line_AbstractObjectType[] business_Document_Lines_ReferenceField;

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

		[XmlElement(DataType = "date", Order = 1)]
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
		public Item_DescriptorObjectType Item_Descriptor_Reference
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

		[XmlElement(Order = 4)]
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
		public decimal Quantity_Requested
		{
			get
			{
				return this.quantity_RequestedField;
			}
			set
			{
				this.quantity_RequestedField = value;
				this.RaisePropertyChanged("Quantity_Requested");
			}
		}

		[XmlIgnore]
		public bool Quantity_RequestedSpecified
		{
			get
			{
				return this.quantity_RequestedFieldSpecified;
			}
			set
			{
				this.quantity_RequestedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_RequestedSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public decimal Total_Quantity_Picked
		{
			get
			{
				return this.total_Quantity_PickedField;
			}
			set
			{
				this.total_Quantity_PickedField = value;
				this.RaisePropertyChanged("Total_Quantity_Picked");
			}
		}

		[XmlIgnore]
		public bool Total_Quantity_PickedSpecified
		{
			get
			{
				return this.total_Quantity_PickedFieldSpecified;
			}
			set
			{
				this.total_Quantity_PickedFieldSpecified = value;
				this.RaisePropertyChanged("Total_Quantity_PickedSpecified");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement("Pick_Inventory_Locations_Lines", Order = 12)]
		public Pick_Inventory_Locations_DataType[] Pick_Inventory_Locations_Lines
		{
			get
			{
				return this.pick_Inventory_Locations_LinesField;
			}
			set
			{
				this.pick_Inventory_Locations_LinesField = value;
				this.RaisePropertyChanged("Pick_Inventory_Locations_Lines");
			}
		}

		[XmlElement("Business_Document_Lines_Reference", Order = 13)]
		public Inventory_Fulfillment_Line_AbstractObjectType[] Business_Document_Lines_Reference
		{
			get
			{
				return this.business_Document_Lines_ReferenceField;
			}
			set
			{
				this.business_Document_Lines_ReferenceField = value;
				this.RaisePropertyChanged("Business_Document_Lines_Reference");
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
