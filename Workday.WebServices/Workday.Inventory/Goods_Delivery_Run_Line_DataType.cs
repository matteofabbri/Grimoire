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
	public class Goods_Delivery_Run_Line_DataType : INotifyPropertyChanged
	{
		private Goods_Delivery_Run_LineObjectType goods_Delivery_Run_Line_ReferenceField;

		private decimal goods_Delivery_Run_Line_NumberField;

		private bool goods_Delivery_Run_Line_NumberFieldSpecified;

		private decimal quantity_AcceptedField;

		private bool quantity_AcceptedFieldSpecified;

		private Inventory_Adjustment_ReasonObjectType delivery_Reason_ReferenceField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_Delivery_Run_LineObjectType Goods_Delivery_Run_Line_Reference
		{
			get
			{
				return this.goods_Delivery_Run_Line_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Run_Line_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Goods_Delivery_Run_Line_Number
		{
			get
			{
				return this.goods_Delivery_Run_Line_NumberField;
			}
			set
			{
				this.goods_Delivery_Run_Line_NumberField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Goods_Delivery_Run_Line_NumberSpecified
		{
			get
			{
				return this.goods_Delivery_Run_Line_NumberFieldSpecified;
			}
			set
			{
				this.goods_Delivery_Run_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Quantity_Accepted
		{
			get
			{
				return this.quantity_AcceptedField;
			}
			set
			{
				this.quantity_AcceptedField = value;
				this.RaisePropertyChanged("Quantity_Accepted");
			}
		}

		[XmlIgnore]
		public bool Quantity_AcceptedSpecified
		{
			get
			{
				return this.quantity_AcceptedFieldSpecified;
			}
			set
			{
				this.quantity_AcceptedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_AcceptedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Inventory_Adjustment_ReasonObjectType Delivery_Reason_Reference
		{
			get
			{
				return this.delivery_Reason_ReferenceField;
			}
			set
			{
				this.delivery_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Reason_Reference");
			}
		}

		[XmlElement(Order = 4)]
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
