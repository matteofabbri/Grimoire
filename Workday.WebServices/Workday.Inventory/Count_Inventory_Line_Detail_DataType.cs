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
	public class Count_Inventory_Line_Detail_DataType : INotifyPropertyChanged
	{
		private decimal line_NumberField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal counted_QuantityField;

		private bool counted_QuantityFieldSpecified;

		private bool zero_On_HandField;

		private bool zero_On_HandFieldSpecified;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
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

		[XmlElement(Order = 3)]
		public decimal Counted_Quantity
		{
			get
			{
				return this.counted_QuantityField;
			}
			set
			{
				this.counted_QuantityField = value;
				this.RaisePropertyChanged("Counted_Quantity");
			}
		}

		[XmlIgnore]
		public bool Counted_QuantitySpecified
		{
			get
			{
				return this.counted_QuantityFieldSpecified;
			}
			set
			{
				this.counted_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Counted_QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Zero_On_Hand
		{
			get
			{
				return this.zero_On_HandField;
			}
			set
			{
				this.zero_On_HandField = value;
				this.RaisePropertyChanged("Zero_On_Hand");
			}
		}

		[XmlIgnore]
		public bool Zero_On_HandSpecified
		{
			get
			{
				return this.zero_On_HandFieldSpecified;
			}
			set
			{
				this.zero_On_HandFieldSpecified = value;
				this.RaisePropertyChanged("Zero_On_HandSpecified");
			}
		}

		[XmlElement(Order = 5)]
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
