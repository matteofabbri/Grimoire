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
	public class Item_Request_Line_DataType : INotifyPropertyChanged
	{
		private Item_Requisition_LineObjectType requisition_Goods_Line_ReferenceField;

		private string goods_Requisition_Line_IDField;

		private Procurement_ItemObjectType item_ReferenceField;

		private string item_IdentifierField;

		private string item_DescriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Requisition_SourceObjectType fulfillment_Source_ReferenceField;

		private LocationObjectType inventory_Site_Location_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private bool rFQ_RequiredField;

		private bool rFQ_RequiredFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool source_This_LineField;

		private bool source_This_LineFieldSpecified;

		private Purchase_Order_LineObjectType[] purchase_Order_Line_ReferenceField;

		private bool mark_Purchase_Order_As_IssuedField;

		private bool mark_Purchase_Order_As_IssuedFieldSpecified;

		private Business_Document_Line_Split_DataType[] goods_Requisition_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Item_Requisition_LineObjectType Requisition_Goods_Line_Reference
		{
			get
			{
				return this.requisition_Goods_Line_ReferenceField;
			}
			set
			{
				this.requisition_Goods_Line_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Goods_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Goods_Requisition_Line_ID
		{
			get
			{
				return this.goods_Requisition_Line_IDField;
			}
			set
			{
				this.goods_Requisition_Line_IDField = value;
				this.RaisePropertyChanged("Goods_Requisition_Line_ID");
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
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Requisition_SourceObjectType Fulfillment_Source_Reference
		{
			get
			{
				return this.fulfillment_Source_ReferenceField;
			}
			set
			{
				this.fulfillment_Source_ReferenceField = value;
				this.RaisePropertyChanged("Fulfillment_Source_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public LocationObjectType Inventory_Site_Location_Reference
		{
			get
			{
				return this.inventory_Site_Location_ReferenceField;
			}
			set
			{
				this.inventory_Site_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Location_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool RFQ_Required
		{
			get
			{
				return this.rFQ_RequiredField;
			}
			set
			{
				this.rFQ_RequiredField = value;
				this.RaisePropertyChanged("RFQ_Required");
			}
		}

		[XmlIgnore]
		public bool RFQ_RequiredSpecified
		{
			get
			{
				return this.rFQ_RequiredFieldSpecified;
			}
			set
			{
				this.rFQ_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_RequiredSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Requested_Delivery_Date
		{
			get
			{
				return this.requested_Delivery_DateField;
			}
			set
			{
				this.requested_Delivery_DateField = value;
				this.RaisePropertyChanged("Requested_Delivery_Date");
			}
		}

		[XmlIgnore]
		public bool Requested_Delivery_DateSpecified
		{
			get
			{
				return this.requested_Delivery_DateFieldSpecified;
			}
			set
			{
				this.requested_Delivery_DateFieldSpecified = value;
				this.RaisePropertyChanged("Requested_Delivery_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Worktags_Reference", Order = 20)]
		public Accounting_WorktagObjectType[] Worktags_Reference
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

		[XmlElement(Order = 21)]
		public bool Source_This_Line
		{
			get
			{
				return this.source_This_LineField;
			}
			set
			{
				this.source_This_LineField = value;
				this.RaisePropertyChanged("Source_This_Line");
			}
		}

		[XmlIgnore]
		public bool Source_This_LineSpecified
		{
			get
			{
				return this.source_This_LineFieldSpecified;
			}
			set
			{
				this.source_This_LineFieldSpecified = value;
				this.RaisePropertyChanged("Source_This_LineSpecified");
			}
		}

		[XmlElement("Purchase_Order_Line_Reference", Order = 22)]
		public Purchase_Order_LineObjectType[] Purchase_Order_Line_Reference
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

		[XmlElement(Order = 23)]
		public bool Mark_Purchase_Order_As_Issued
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedField;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedField = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_Issued");
			}
		}

		[XmlIgnore]
		public bool Mark_Purchase_Order_As_IssuedSpecified
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedFieldSpecified;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedFieldSpecified = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_IssuedSpecified");
			}
		}

		[XmlElement("Goods_Requisition_Line_Split_Data", Order = 24)]
		public Business_Document_Line_Split_DataType[] Goods_Requisition_Line_Split_Data
		{
			get
			{
				return this.goods_Requisition_Line_Split_DataField;
			}
			set
			{
				this.goods_Requisition_Line_Split_DataField = value;
				this.RaisePropertyChanged("Goods_Requisition_Line_Split_Data");
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
