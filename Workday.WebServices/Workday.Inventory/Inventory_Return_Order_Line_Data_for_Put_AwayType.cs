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
	public class Inventory_Return_Order_Line_Data_for_Put_AwayType : INotifyPropertyChanged
	{
		private Inventory_Return_LineObjectType inventory_Return_Line_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private LocationObjectType stocking_Location_ReferenceField;

		private decimal disposal_QuantityField;

		private bool disposal_QuantityFieldSpecified;

		private Inventory_Adjustment_ReasonObjectType inventory_Adjustment_Reason_ReferenceField;

		private string memoField;

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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Disposal_Quantity
		{
			get
			{
				return this.disposal_QuantityField;
			}
			set
			{
				this.disposal_QuantityField = value;
				this.RaisePropertyChanged("Disposal_Quantity");
			}
		}

		[XmlIgnore]
		public bool Disposal_QuantitySpecified
		{
			get
			{
				return this.disposal_QuantityFieldSpecified;
			}
			set
			{
				this.disposal_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Disposal_QuantitySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Inventory_Adjustment_ReasonObjectType Inventory_Adjustment_Reason_Reference
		{
			get
			{
				return this.inventory_Adjustment_Reason_ReferenceField;
			}
			set
			{
				this.inventory_Adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Adjustment_Reason_Reference");
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
