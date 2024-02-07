using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class PO_Acknowledgement_Line_DataType : INotifyPropertyChanged
	{
		private PO_Acknowledgement_LineObjectType pO_Acknowledgement_Line_ReferenceField;

		private string purchase_Order_Acknowledgement_Line_IDField;

		private Purchase_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private PO_Acknowledgement_StatusObjectType pO_Acknowledgement_Status_for_POA_Line_ReferenceField;

		private string pO_Acknowledgement_Line_DescriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private string memoField;

		private decimal backordered_QuantityField;

		private bool backordered_QuantityFieldSpecified;

		private DateTime backorder_DateField;

		private bool backorder_DateFieldSpecified;

		private Line_Alternate_Item_Attribute_Value_Data_InboundType[] alternate_Item_Identifier_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public PO_Acknowledgement_LineObjectType PO_Acknowledgement_Line_Reference
		{
			get
			{
				return this.pO_Acknowledgement_Line_ReferenceField;
			}
			set
			{
				this.pO_Acknowledgement_Line_ReferenceField = value;
				this.RaisePropertyChanged("PO_Acknowledgement_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Purchase_Order_Acknowledgement_Line_ID
		{
			get
			{
				return this.purchase_Order_Acknowledgement_Line_IDField;
			}
			set
			{
				this.purchase_Order_Acknowledgement_Line_IDField = value;
				this.RaisePropertyChanged("Purchase_Order_Acknowledgement_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_Order_LineObjectType Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public PO_Acknowledgement_StatusObjectType PO_Acknowledgement_Status_for_POA_Line_Reference
		{
			get
			{
				return this.pO_Acknowledgement_Status_for_POA_Line_ReferenceField;
			}
			set
			{
				this.pO_Acknowledgement_Status_for_POA_Line_ReferenceField = value;
				this.RaisePropertyChanged("PO_Acknowledgement_Status_for_POA_Line_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string PO_Acknowledgement_Line_Description
		{
			get
			{
				return this.pO_Acknowledgement_Line_DescriptionField;
			}
			set
			{
				this.pO_Acknowledgement_Line_DescriptionField = value;
				this.RaisePropertyChanged("PO_Acknowledgement_Line_Description");
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Backordered_Quantity
		{
			get
			{
				return this.backordered_QuantityField;
			}
			set
			{
				this.backordered_QuantityField = value;
				this.RaisePropertyChanged("Backordered_Quantity");
			}
		}

		[XmlIgnore]
		public bool Backordered_QuantitySpecified
		{
			get
			{
				return this.backordered_QuantityFieldSpecified;
			}
			set
			{
				this.backordered_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Backordered_QuantitySpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Backorder_Date
		{
			get
			{
				return this.backorder_DateField;
			}
			set
			{
				this.backorder_DateField = value;
				this.RaisePropertyChanged("Backorder_Date");
			}
		}

		[XmlIgnore]
		public bool Backorder_DateSpecified
		{
			get
			{
				return this.backorder_DateFieldSpecified;
			}
			set
			{
				this.backorder_DateFieldSpecified = value;
				this.RaisePropertyChanged("Backorder_DateSpecified");
			}
		}

		[XmlElement("Alternate_Item_Identifier_Data", Order = 11)]
		public Line_Alternate_Item_Attribute_Value_Data_InboundType[] Alternate_Item_Identifier_Data
		{
			get
			{
				return this.alternate_Item_Identifier_DataField;
			}
			set
			{
				this.alternate_Item_Identifier_DataField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifier_Data");
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
