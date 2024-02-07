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
	public class Capture_Goods_Delivery_Run_Line_Outbound_DataType : INotifyPropertyChanged
	{
		private Goods_Delivery_Run_LineObjectType goods_Delivery_Run_Line_ReferenceField;

		private decimal goods_Delivery_Run_Line_NumberField;

		private bool goods_Delivery_Run_Line_NumberFieldSpecified;

		private Item_DescriptorObjectType item_ReferenceField;

		private string item_DescriptionField;

		private decimal requested_QuantityField;

		private bool requested_QuantityFieldSpecified;

		private decimal quantity_Out_for_DeliveryField;

		private bool quantity_Out_for_DeliveryFieldSpecified;

		private decimal quantity_AcceptedField;

		private bool quantity_AcceptedFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Inventory_Adjustment_ReasonObjectType adjustment_Reason_ReferenceField;

		private bool exception_ConditionField;

		private bool exception_ConditionFieldSpecified;

		private string line_MemoField;

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
		public decimal Requested_Quantity
		{
			get
			{
				return this.requested_QuantityField;
			}
			set
			{
				this.requested_QuantityField = value;
				this.RaisePropertyChanged("Requested_Quantity");
			}
		}

		[XmlIgnore]
		public bool Requested_QuantitySpecified
		{
			get
			{
				return this.requested_QuantityFieldSpecified;
			}
			set
			{
				this.requested_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Requested_QuantitySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Quantity_Out_for_Delivery
		{
			get
			{
				return this.quantity_Out_for_DeliveryField;
			}
			set
			{
				this.quantity_Out_for_DeliveryField = value;
				this.RaisePropertyChanged("Quantity_Out_for_Delivery");
			}
		}

		[XmlIgnore]
		public bool Quantity_Out_for_DeliverySpecified
		{
			get
			{
				return this.quantity_Out_for_DeliveryFieldSpecified;
			}
			set
			{
				this.quantity_Out_for_DeliveryFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_Out_for_DeliverySpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Inventory_Adjustment_ReasonObjectType Adjustment_Reason_Reference
		{
			get
			{
				return this.adjustment_Reason_ReferenceField;
			}
			set
			{
				this.adjustment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Adjustment_Reason_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Exception_Condition
		{
			get
			{
				return this.exception_ConditionField;
			}
			set
			{
				this.exception_ConditionField = value;
				this.RaisePropertyChanged("Exception_Condition");
			}
		}

		[XmlIgnore]
		public bool Exception_ConditionSpecified
		{
			get
			{
				return this.exception_ConditionFieldSpecified;
			}
			set
			{
				this.exception_ConditionFieldSpecified = value;
				this.RaisePropertyChanged("Exception_ConditionSpecified");
			}
		}

		[XmlElement(Order = 10)]
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
