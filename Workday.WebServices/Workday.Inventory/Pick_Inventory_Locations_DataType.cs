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
	public class Pick_Inventory_Locations_DataType : INotifyPropertyChanged
	{
		private Inventory_Pick_List_LineObjectType inventory_Picking_List_Line_ReferenceField;

		private bool item_SubstituteField;

		private bool item_SubstituteFieldSpecified;

		private Purchase_ItemObjectType item_ReferenceField;

		private string descriptionField;

		private LocationObjectType inventory_Location_ReferenceField;

		private Item_LotObjectType lot_ReferenceField;

		private decimal quantity_AvailableField;

		private bool quantity_AvailableFieldSpecified;

		private decimal quantity_PickedField;

		private bool quantity_PickedFieldSpecified;

		private decimal pick_List_Line_NumberField;

		private bool pick_List_Line_NumberFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public bool Item_Substitute
		{
			get
			{
				return this.item_SubstituteField;
			}
			set
			{
				this.item_SubstituteField = value;
				this.RaisePropertyChanged("Item_Substitute");
			}
		}

		[XmlIgnore]
		public bool Item_SubstituteSpecified
		{
			get
			{
				return this.item_SubstituteFieldSpecified;
			}
			set
			{
				this.item_SubstituteFieldSpecified = value;
				this.RaisePropertyChanged("Item_SubstituteSpecified");
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
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 4)]
		public LocationObjectType Inventory_Location_Reference
		{
			get
			{
				return this.inventory_Location_ReferenceField;
			}
			set
			{
				this.inventory_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Item_LotObjectType Lot_Reference
		{
			get
			{
				return this.lot_ReferenceField;
			}
			set
			{
				this.lot_ReferenceField = value;
				this.RaisePropertyChanged("Lot_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Quantity_Available
		{
			get
			{
				return this.quantity_AvailableField;
			}
			set
			{
				this.quantity_AvailableField = value;
				this.RaisePropertyChanged("Quantity_Available");
			}
		}

		[XmlIgnore]
		public bool Quantity_AvailableSpecified
		{
			get
			{
				return this.quantity_AvailableFieldSpecified;
			}
			set
			{
				this.quantity_AvailableFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_AvailableSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Quantity_Picked
		{
			get
			{
				return this.quantity_PickedField;
			}
			set
			{
				this.quantity_PickedField = value;
				this.RaisePropertyChanged("Quantity_Picked");
			}
		}

		[XmlIgnore]
		public bool Quantity_PickedSpecified
		{
			get
			{
				return this.quantity_PickedFieldSpecified;
			}
			set
			{
				this.quantity_PickedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_PickedSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Pick_List_Line_Number
		{
			get
			{
				return this.pick_List_Line_NumberField;
			}
			set
			{
				this.pick_List_Line_NumberField = value;
				this.RaisePropertyChanged("Pick_List_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Pick_List_Line_NumberSpecified
		{
			get
			{
				return this.pick_List_Line_NumberFieldSpecified;
			}
			set
			{
				this.pick_List_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Pick_List_Line_NumberSpecified");
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
