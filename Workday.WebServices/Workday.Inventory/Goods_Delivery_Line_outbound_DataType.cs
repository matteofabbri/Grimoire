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
	public class Goods_Delivery_Line_outbound_DataType : INotifyPropertyChanged
	{
		private Goods_Delivery_LineObjectType goods_Delivery_Line_ReferenceField;

		private decimal goods_Delivery_Line_NumberField;

		private bool goods_Delivery_Line_NumberFieldSpecified;

		private Item_DescriptorObjectType item_ReferenceField;

		private string item_DescriptionField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_Delivery_LineObjectType Goods_Delivery_Line_Reference
		{
			get
			{
				return this.goods_Delivery_Line_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Line_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Goods_Delivery_Line_Number
		{
			get
			{
				return this.goods_Delivery_Line_NumberField;
			}
			set
			{
				this.goods_Delivery_Line_NumberField = value;
				this.RaisePropertyChanged("Goods_Delivery_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Goods_Delivery_Line_NumberSpecified
		{
			get
			{
				return this.goods_Delivery_Line_NumberFieldSpecified;
			}
			set
			{
				this.goods_Delivery_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Goods_Delivery_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Item_DescriptorObjectType Item_Reference
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
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 4)]
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
