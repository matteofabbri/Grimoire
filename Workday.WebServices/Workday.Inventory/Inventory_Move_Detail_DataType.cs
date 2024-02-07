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
	public class Inventory_Move_Detail_DataType : INotifyPropertyChanged
	{
		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Unit_of_MeasureObjectType to_Unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private LocationObjectType to_Location_ReferenceField;

		private decimal quantityField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Unit_of_MeasureObjectType To_Unit_of_Measure_Reference
		{
			get
			{
				return this.to_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.to_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("To_Unit_of_Measure_Reference");
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
		public LocationObjectType To_Location_Reference
		{
			get
			{
				return this.to_Location_ReferenceField;
			}
			set
			{
				this.to_Location_ReferenceField = value;
				this.RaisePropertyChanged("To_Location_Reference");
			}
		}

		[XmlElement(Order = 5)]
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
