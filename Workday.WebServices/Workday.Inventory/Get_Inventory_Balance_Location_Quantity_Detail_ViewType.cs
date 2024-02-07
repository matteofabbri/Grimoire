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
	public class Get_Inventory_Balance_Location_Quantity_Detail_ViewType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType inventory_Location_Quantity_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal quantity_On_HandField;

		private bool quantity_On_HandFieldSpecified;

		private decimal total_Allocated_Pick_QuantityField;

		private bool total_Allocated_Pick_QuantityFieldSpecified;

		private decimal quantity_AvailableField;

		private bool quantity_AvailableFieldSpecified;

		private Unit_of_MeasureObjectType location_Quantity_Unit_of_Measure_ReferenceField;

		private decimal base_Quantity_On_HandField;

		private bool base_Quantity_On_HandFieldSpecified;

		private Unit_of_MeasureObjectType base_Unit_of_Measure_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Quantity_On_Hand
		{
			get
			{
				return this.quantity_On_HandField;
			}
			set
			{
				this.quantity_On_HandField = value;
				this.RaisePropertyChanged("Quantity_On_Hand");
			}
		}

		[XmlIgnore]
		public bool Quantity_On_HandSpecified
		{
			get
			{
				return this.quantity_On_HandFieldSpecified;
			}
			set
			{
				this.quantity_On_HandFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_On_HandSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Total_Allocated_Pick_Quantity
		{
			get
			{
				return this.total_Allocated_Pick_QuantityField;
			}
			set
			{
				this.total_Allocated_Pick_QuantityField = value;
				this.RaisePropertyChanged("Total_Allocated_Pick_Quantity");
			}
		}

		[XmlIgnore]
		public bool Total_Allocated_Pick_QuantitySpecified
		{
			get
			{
				return this.total_Allocated_Pick_QuantityFieldSpecified;
			}
			set
			{
				this.total_Allocated_Pick_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Total_Allocated_Pick_QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Unit_of_MeasureObjectType Location_Quantity_Unit_of_Measure_Reference
		{
			get
			{
				return this.location_Quantity_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.location_Quantity_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Location_Quantity_Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Base_Quantity_On_Hand
		{
			get
			{
				return this.base_Quantity_On_HandField;
			}
			set
			{
				this.base_Quantity_On_HandField = value;
				this.RaisePropertyChanged("Base_Quantity_On_Hand");
			}
		}

		[XmlIgnore]
		public bool Base_Quantity_On_HandSpecified
		{
			get
			{
				return this.base_Quantity_On_HandFieldSpecified;
			}
			set
			{
				this.base_Quantity_On_HandFieldSpecified = value;
				this.RaisePropertyChanged("Base_Quantity_On_HandSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Unit_of_MeasureObjectType Base_Unit_of_Measure_Reference
		{
			get
			{
				return this.base_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.base_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Base_Unit_of_Measure_Reference");
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
