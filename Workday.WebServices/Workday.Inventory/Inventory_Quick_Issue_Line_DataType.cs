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
	public class Inventory_Quick_Issue_Line_DataType : INotifyPropertyChanged
	{
		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal quantityField;

		private Item_Serial_Line_DataType[] item_Serial_Line_DataField;

		private string memoField;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

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
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
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

		[XmlElement("Item_Serial_Line_Data", Order = 5)]
		public Item_Serial_Line_DataType[] Item_Serial_Line_Data
		{
			get
			{
				return this.item_Serial_Line_DataField;
			}
			set
			{
				this.item_Serial_Line_DataField = value;
				this.RaisePropertyChanged("Item_Serial_Line_Data");
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

		[XmlElement("Worktags_Reference", Order = 7)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
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
