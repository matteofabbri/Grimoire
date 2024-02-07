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
	public class Inventory_Pick_Stock_Request_Line_WWS_DataType : INotifyPropertyChanged
	{
		private Inventory_Stock_Request_LineObjectType stock_Request_Line_ReferenceField;

		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Inventory_Pick_Locations_WWS_DataType[] inventory_Pick_Locations_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Stock_Request_LineObjectType Stock_Request_Line_Reference
		{
			get
			{
				return this.stock_Request_Line_ReferenceField;
			}
			set
			{
				this.stock_Request_Line_ReferenceField = value;
				this.RaisePropertyChanged("Stock_Request_Line_Reference");
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

		[XmlElement("Inventory_Pick_Locations_Data", Order = 3)]
		public Inventory_Pick_Locations_WWS_DataType[] Inventory_Pick_Locations_Data
		{
			get
			{
				return this.inventory_Pick_Locations_DataField;
			}
			set
			{
				this.inventory_Pick_Locations_DataField = value;
				this.RaisePropertyChanged("Inventory_Pick_Locations_Data");
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
