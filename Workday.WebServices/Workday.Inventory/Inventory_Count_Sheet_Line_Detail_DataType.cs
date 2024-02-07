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
	public class Inventory_Count_Sheet_Line_Detail_DataType : INotifyPropertyChanged
	{
		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private decimal quantity_On_HandField;

		private bool quantity_On_HandFieldSpecified;

		private DateTime quantity_On_Hand_As_OfField;

		private bool quantity_On_Hand_As_OfFieldSpecified;

		private decimal quantity_CountedField;

		private bool quantity_CountedFieldSpecified;

		private bool zero_On_HandField;

		private bool zero_On_HandFieldSpecified;

		private string memoField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

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

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
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

		[XmlElement(Order = 4)]
		public DateTime Quantity_On_Hand_As_Of
		{
			get
			{
				return this.quantity_On_Hand_As_OfField;
			}
			set
			{
				this.quantity_On_Hand_As_OfField = value;
				this.RaisePropertyChanged("Quantity_On_Hand_As_Of");
			}
		}

		[XmlIgnore]
		public bool Quantity_On_Hand_As_OfSpecified
		{
			get
			{
				return this.quantity_On_Hand_As_OfFieldSpecified;
			}
			set
			{
				this.quantity_On_Hand_As_OfFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_On_Hand_As_OfSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Quantity_Counted
		{
			get
			{
				return this.quantity_CountedField;
			}
			set
			{
				this.quantity_CountedField = value;
				this.RaisePropertyChanged("Quantity_Counted");
			}
		}

		[XmlIgnore]
		public bool Quantity_CountedSpecified
		{
			get
			{
				return this.quantity_CountedFieldSpecified;
			}
			set
			{
				this.quantity_CountedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_CountedSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 8)]
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
