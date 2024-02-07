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
	public class Ad_Hoc_Goods_Delivery_Line_DataType : INotifyPropertyChanged
	{
		private Goods_Delivery_LineObjectType goods_Delivery_Line_ReferenceField;

		private decimal goods_Delivery_Line_NumberField;

		private bool goods_Delivery_Line_NumberFieldSpecified;

		private Procurement_ItemObjectType item_ReferenceField;

		private string line_Item_DescriptionField;

		private decimal quantityField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private bool signature_RequiredField;

		private bool signature_RequiredFieldSpecified;

		private string line_MemoField;

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
		public Procurement_ItemObjectType Item_Reference
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
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
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

		[XmlElement(Order = 6)]
		public bool Signature_Required
		{
			get
			{
				return this.signature_RequiredField;
			}
			set
			{
				this.signature_RequiredField = value;
				this.RaisePropertyChanged("Signature_Required");
			}
		}

		[XmlIgnore]
		public bool Signature_RequiredSpecified
		{
			get
			{
				return this.signature_RequiredFieldSpecified;
			}
			set
			{
				this.signature_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Signature_RequiredSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Line_Memo
		{
			get
			{
				return this.line_MemoField;
			}
			set
			{
				this.line_MemoField = value;
				this.RaisePropertyChanged("Line_Memo");
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
