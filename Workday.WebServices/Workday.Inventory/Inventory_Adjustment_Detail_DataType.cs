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
	public class Inventory_Adjustment_Detail_DataType : INotifyPropertyChanged
	{
		private LocationObjectType stocking_Location_ReferenceField;

		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal quantityField;

		private Inventory_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Stocking_Location_Reference
		{
			get
			{
				return this.stocking_Location_ReferenceField;
			}
			set
			{
				this.stocking_Location_ReferenceField = value;
				this.RaisePropertyChanged("Stocking_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Inventory_Adjustment_ReasonObjectType Adjustment_Reason_Reference
		{
			get
			{
				return this.adjustment_Reason_ReferenceField;
			}
			set
			{
				this.adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reason_Reference");
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
