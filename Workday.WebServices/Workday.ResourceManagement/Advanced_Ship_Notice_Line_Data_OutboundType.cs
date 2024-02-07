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
	public class Advanced_Ship_Notice_Line_Data_OutboundType : INotifyPropertyChanged
	{
		private string advanced_Ship_Notice_Line_IDField;

		private Advanced_Ship_Notice_LineObjectType advanced_Ship_Notice_Line_ReferenceField;

		private Purchase_ItemObjectType item_ReferenceField;

		private string item_IdentifierField;

		private string item_DescriptionField;

		private Purchase_ItemObjectType purchase_Item_ReferenceField;

		private string shipment_Line_ReferenceField;

		private Unit_of_MeasureObjectType shipped_Unit_of_Measure_ReferenceField;

		private decimal shipped_Unit_CostField;

		private bool shipped_Unit_CostFieldSpecified;

		private decimal conversion_FactorField;

		private bool conversion_FactorFieldSpecified;

		private decimal shipped_QuantityField;

		private bool shipped_QuantityFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string memoField;

		private Item_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private Line_Alternate_Item_Attribute_Value_Data_OutboundType[] alternate_Item_Identifier_DataField;

		private ASN_Line_Lot_Information_Data_OutboundType[] lot_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Advanced_Ship_Notice_Line_ID
		{
			get
			{
				return this.advanced_Ship_Notice_Line_IDField;
			}
			set
			{
				this.advanced_Ship_Notice_Line_IDField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Advanced_Ship_Notice_LineObjectType Advanced_Ship_Notice_Line_Reference
		{
			get
			{
				return this.advanced_Ship_Notice_Line_ReferenceField;
			}
			set
			{
				this.advanced_Ship_Notice_Line_ReferenceField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Line_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_ItemObjectType Item_Reference
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
		public string Item_Identifier
		{
			get
			{
				return this.item_IdentifierField;
			}
			set
			{
				this.item_IdentifierField = value;
				this.RaisePropertyChanged("Item_Identifier");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Purchase_ItemObjectType Purchase_Item_Reference
		{
			get
			{
				return this.purchase_Item_ReferenceField;
			}
			set
			{
				this.purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Shipment_Line_Reference
		{
			get
			{
				return this.shipment_Line_ReferenceField;
			}
			set
			{
				this.shipment_Line_ReferenceField = value;
				this.RaisePropertyChanged("Shipment_Line_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Unit_of_MeasureObjectType Shipped_Unit_of_Measure_Reference
		{
			get
			{
				return this.shipped_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.shipped_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Shipped_Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Shipped_Unit_Cost
		{
			get
			{
				return this.shipped_Unit_CostField;
			}
			set
			{
				this.shipped_Unit_CostField = value;
				this.RaisePropertyChanged("Shipped_Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Shipped_Unit_CostSpecified
		{
			get
			{
				return this.shipped_Unit_CostFieldSpecified;
			}
			set
			{
				this.shipped_Unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Shipped_Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Conversion_Factor
		{
			get
			{
				return this.conversion_FactorField;
			}
			set
			{
				this.conversion_FactorField = value;
				this.RaisePropertyChanged("Conversion_Factor");
			}
		}

		[XmlIgnore]
		public bool Conversion_FactorSpecified
		{
			get
			{
				return this.conversion_FactorFieldSpecified;
			}
			set
			{
				this.conversion_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Conversion_FactorSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Shipped_Quantity
		{
			get
			{
				return this.shipped_QuantityField;
			}
			set
			{
				this.shipped_QuantityField = value;
				this.RaisePropertyChanged("Shipped_Quantity");
			}
		}

		[XmlIgnore]
		public bool Shipped_QuantitySpecified
		{
			get
			{
				return this.shipped_QuantityFieldSpecified;
			}
			set
			{
				this.shipped_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Shipped_QuantitySpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public LocationObjectType Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public Item_Order_LineObjectType Purchase_Order_Line_Reference
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

		[XmlElement("Alternate_Item_Identifier_Data", Order = 15)]
		public Line_Alternate_Item_Attribute_Value_Data_OutboundType[] Alternate_Item_Identifier_Data
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

		[XmlElement("Lot_Information_Data", Order = 16)]
		public ASN_Line_Lot_Information_Data_OutboundType[] Lot_Information_Data
		{
			get
			{
				return this.lot_Information_DataField;
			}
			set
			{
				this.lot_Information_DataField = value;
				this.RaisePropertyChanged("Lot_Information_Data");
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
