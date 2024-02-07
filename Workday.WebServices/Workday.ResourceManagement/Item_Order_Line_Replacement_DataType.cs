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
	public class Item_Order_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private Procurement_ItemObjectType item_ReferenceField;

		private string goods_Purchase_Order_Line_IDField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private string item_DescriptionField;

		private Supplier_Contract_LineObjectType supplier_Contract_Line_ReferenceField;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private decimal quantityField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Delivery_TypeObjectType delivery_Type_ReferenceField;

		private bool prepaidField;

		private bool prepaidFieldSpecified;

		private bool retentionField;

		private bool retentionFieldSpecified;

		private DateTime requested_Delivery_DateField;

		private bool requested_Delivery_DateFieldSpecified;

		private string memoField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private string ship_To_Global_Location_NumberField;

		private string ship_To_Location_IdentifierField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string deliver_To_Location_GLNField;

		private string deliver_To_Location_Location_IdentifierField;

		private Requisition_LineObjectType[] requisition_Line_ReferenceField;

		private LocationObjectType storage_Location_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Business_Document_Line_Split_DataType[] goods_Purchase_Order_Line_Split_DataField;

		private Alternate_Item_Identifiers_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Goods_Purchase_Order_Line_ID
		{
			get
			{
				return this.goods_Purchase_Order_Line_IDField;
			}
			set
			{
				this.goods_Purchase_Order_Line_IDField = value;
				this.RaisePropertyChanged("Goods_Purchase_Order_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
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
		public Supplier_Contract_LineObjectType Supplier_Contract_Line_Reference
		{
			get
			{
				return this.supplier_Contract_Line_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Spend_CategoryObjectType Resource_Category_Reference
		{
			get
			{
				return this.resource_Category_ReferenceField;
			}
			set
			{
				this.resource_Category_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Delivery_TypeObjectType Delivery_Type_Reference
		{
			get
			{
				return this.delivery_Type_ReferenceField;
			}
			set
			{
				this.delivery_Type_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Type_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Prepaid
		{
			get
			{
				return this.prepaidField;
			}
			set
			{
				this.prepaidField = value;
				this.RaisePropertyChanged("Prepaid");
			}
		}

		[XmlIgnore]
		public bool PrepaidSpecified
		{
			get
			{
				return this.prepaidFieldSpecified;
			}
			set
			{
				this.prepaidFieldSpecified = value;
				this.RaisePropertyChanged("PrepaidSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Retention
		{
			get
			{
				return this.retentionField;
			}
			set
			{
				this.retentionField = value;
				this.RaisePropertyChanged("Retention");
			}
		}

		[XmlIgnore]
		public bool RetentionSpecified
		{
			get
			{
				return this.retentionFieldSpecified;
			}
			set
			{
				this.retentionFieldSpecified = value;
				this.RaisePropertyChanged("RetentionSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public string Ship_To_Global_Location_Number
		{
			get
			{
				return this.ship_To_Global_Location_NumberField;
			}
			set
			{
				this.ship_To_Global_Location_NumberField = value;
				this.RaisePropertyChanged("Ship_To_Global_Location_Number");
			}
		}

		[XmlElement(Order = 20)]
		public string Ship_To_Location_Identifier
		{
			get
			{
				return this.ship_To_Location_IdentifierField;
			}
			set
			{
				this.ship_To_Location_IdentifierField = value;
				this.RaisePropertyChanged("Ship_To_Location_Identifier");
			}
		}

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public string Deliver_To_Location_GLN
		{
			get
			{
				return this.deliver_To_Location_GLNField;
			}
			set
			{
				this.deliver_To_Location_GLNField = value;
				this.RaisePropertyChanged("Deliver_To_Location_GLN");
			}
		}

		[XmlElement(Order = 24)]
		public string Deliver_To_Location_Location_Identifier
		{
			get
			{
				return this.deliver_To_Location_Location_IdentifierField;
			}
			set
			{
				this.deliver_To_Location_Location_IdentifierField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Location_Identifier");
			}
		}

		[XmlElement("Requisition_Line_Reference", Order = 25)]
		public Requisition_LineObjectType[] Requisition_Line_Reference
		{
			get
			{
				return this.requisition_Line_ReferenceField;
			}
			set
			{
				this.requisition_Line_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Line_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public LocationObjectType Storage_Location_Reference
		{
			get
			{
				return this.storage_Location_ReferenceField;
			}
			set
			{
				this.storage_Location_ReferenceField = value;
				this.RaisePropertyChanged("Storage_Location_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 27)]
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

		[XmlElement("Goods_Purchase_Order_Line_Split_Data", Order = 28)]
		public Business_Document_Line_Split_DataType[] Goods_Purchase_Order_Line_Split_Data
		{
			get
			{
				return this.goods_Purchase_Order_Line_Split_DataField;
			}
			set
			{
				this.goods_Purchase_Order_Line_Split_DataField = value;
				this.RaisePropertyChanged("Goods_Purchase_Order_Line_Split_Data");
			}
		}

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 29)]
		public Alternate_Item_Identifiers_DataType[] Alternate_Item_Identifiers_Data
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

		[XmlElement("Item_Tag_Reference", Order = 30)]
		public Item_TagObjectType[] Item_Tag_Reference
		{
			get
			{
				return this.item_Tag_ReferenceField;
			}
			set
			{
				this.item_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Item_Tag_Reference");
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
