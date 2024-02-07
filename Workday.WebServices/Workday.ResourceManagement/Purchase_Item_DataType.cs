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
	public class Purchase_Item_DataType : INotifyPropertyChanged
	{
		private string purchase_Item_IDField;

		private string item_NameField;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private string item_DescriptionField;

		private string item_IdentifierField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal conversion_FactorField;

		private bool conversion_FactorFieldSpecified;

		private decimal item_Unit_PriceField;

		private bool item_Unit_PriceFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private bool default_as_Service_RequestField;

		private bool default_as_Service_RequestFieldSpecified;

		private Purchase_Item_GroupObjectType[] purchase_Item_Group_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private Unit_of_Measure_SetObjectType unit_of_Measure_Set_ReferenceField;

		private bool item_Units_of_MeasureField;

		private bool item_Units_of_MeasureFieldSpecified;

		private Unit_of_MeasureObjectType base_Unit_of_Measure_ReferenceField;

		private Unit_of_MeasureObjectType default_Stocking_Unit_of_Measure_ReferenceField;

		private bool lot_ControlField;

		private bool lot_ControlFieldSpecified;

		private bool ship_Serial_ControlField;

		private bool ship_Serial_ControlFieldSpecified;

		private bool is_Manufacturer_RequiredField;

		private bool is_Manufacturer_RequiredFieldSpecified;

		private bool use_Item_Manufacturers_OnlyField;

		private bool use_Item_Manufacturers_OnlyFieldSpecified;

		private bool is_Expiration_Date_RequiredField;

		private bool is_Expiration_Date_RequiredFieldSpecified;

		private Requisition_SourceObjectType requisition_Fulfillment_Source_ReferenceField;

		private Alternate_Item_Identifiers_DataType[] alternate_Item_Identifiers_DataField;

		private Purchase_Item_Unit_of_Measure_DataType[] purchase_Item_Unit_of_Measure_DataField;

		private Item_Inventory_Attributes_DataType[] item_Inventory_Attributes_DataField;

		private Item_Substitute_DataType[] item_Substitute_DataField;

		private Sales_ItemObjectType maps_To_Sales_Item_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Purchase_Item_ID
		{
			get
			{
				return this.purchase_Item_IDField;
			}
			set
			{
				this.purchase_Item_IDField = value;
				this.RaisePropertyChanged("Purchase_Item_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Item_Name
		{
			get
			{
				return this.item_NameField;
			}
			set
			{
				this.item_NameField = value;
				this.RaisePropertyChanged("Item_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Item_Tag_Reference", Order = 5)]
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

		[XmlElement(Order = 8)]
		public decimal Item_Unit_Price
		{
			get
			{
				return this.item_Unit_PriceField;
			}
			set
			{
				this.item_Unit_PriceField = value;
				this.RaisePropertyChanged("Item_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Item_Unit_PriceSpecified
		{
			get
			{
				return this.item_Unit_PriceFieldSpecified;
			}
			set
			{
				this.item_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Item_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public Accounting_TreatmentObjectType Accounting_Treatment_Reference
		{
			get
			{
				return this.accounting_Treatment_ReferenceField;
			}
			set
			{
				this.accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Treatment_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public bool Default_as_Service_Request
		{
			get
			{
				return this.default_as_Service_RequestField;
			}
			set
			{
				this.default_as_Service_RequestField = value;
				this.RaisePropertyChanged("Default_as_Service_Request");
			}
		}

		[XmlIgnore]
		public bool Default_as_Service_RequestSpecified
		{
			get
			{
				return this.default_as_Service_RequestFieldSpecified;
			}
			set
			{
				this.default_as_Service_RequestFieldSpecified = value;
				this.RaisePropertyChanged("Default_as_Service_RequestSpecified");
			}
		}

		[XmlElement("Purchase_Item_Group_Reference", Order = 13)]
		public Purchase_Item_GroupObjectType[] Purchase_Item_Group_Reference
		{
			get
			{
				return this.purchase_Item_Group_ReferenceField;
			}
			set
			{
				this.purchase_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Group_Reference");
			}
		}

		[XmlArray(Order = 14), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Related_Worktags_Data
		{
			get
			{
				return this.related_Worktags_DataField;
			}
			set
			{
				this.related_Worktags_DataField = value;
				this.RaisePropertyChanged("Related_Worktags_Data");
			}
		}

		[XmlElement(Order = 15)]
		public Unit_of_Measure_SetObjectType Unit_of_Measure_Set_Reference
		{
			get
			{
				return this.unit_of_Measure_Set_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_Set_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Set_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public bool Item_Units_of_Measure
		{
			get
			{
				return this.item_Units_of_MeasureField;
			}
			set
			{
				this.item_Units_of_MeasureField = value;
				this.RaisePropertyChanged("Item_Units_of_Measure");
			}
		}

		[XmlIgnore]
		public bool Item_Units_of_MeasureSpecified
		{
			get
			{
				return this.item_Units_of_MeasureFieldSpecified;
			}
			set
			{
				this.item_Units_of_MeasureFieldSpecified = value;
				this.RaisePropertyChanged("Item_Units_of_MeasureSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public Unit_of_MeasureObjectType Base_Unit_of_Measure_Reference
		{
			get
			{
				return this.base_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.base_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Base_Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Unit_of_MeasureObjectType Default_Stocking_Unit_of_Measure_Reference
		{
			get
			{
				return this.default_Stocking_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.default_Stocking_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Default_Stocking_Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public bool Lot_Control
		{
			get
			{
				return this.lot_ControlField;
			}
			set
			{
				this.lot_ControlField = value;
				this.RaisePropertyChanged("Lot_Control");
			}
		}

		[XmlIgnore]
		public bool Lot_ControlSpecified
		{
			get
			{
				return this.lot_ControlFieldSpecified;
			}
			set
			{
				this.lot_ControlFieldSpecified = value;
				this.RaisePropertyChanged("Lot_ControlSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Ship_Serial_Control
		{
			get
			{
				return this.ship_Serial_ControlField;
			}
			set
			{
				this.ship_Serial_ControlField = value;
				this.RaisePropertyChanged("Ship_Serial_Control");
			}
		}

		[XmlIgnore]
		public bool Ship_Serial_ControlSpecified
		{
			get
			{
				return this.ship_Serial_ControlFieldSpecified;
			}
			set
			{
				this.ship_Serial_ControlFieldSpecified = value;
				this.RaisePropertyChanged("Ship_Serial_ControlSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Is_Manufacturer_Required
		{
			get
			{
				return this.is_Manufacturer_RequiredField;
			}
			set
			{
				this.is_Manufacturer_RequiredField = value;
				this.RaisePropertyChanged("Is_Manufacturer_Required");
			}
		}

		[XmlIgnore]
		public bool Is_Manufacturer_RequiredSpecified
		{
			get
			{
				return this.is_Manufacturer_RequiredFieldSpecified;
			}
			set
			{
				this.is_Manufacturer_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Is_Manufacturer_RequiredSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Use_Item_Manufacturers_Only
		{
			get
			{
				return this.use_Item_Manufacturers_OnlyField;
			}
			set
			{
				this.use_Item_Manufacturers_OnlyField = value;
				this.RaisePropertyChanged("Use_Item_Manufacturers_Only");
			}
		}

		[XmlIgnore]
		public bool Use_Item_Manufacturers_OnlySpecified
		{
			get
			{
				return this.use_Item_Manufacturers_OnlyFieldSpecified;
			}
			set
			{
				this.use_Item_Manufacturers_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Use_Item_Manufacturers_OnlySpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Is_Expiration_Date_Required
		{
			get
			{
				return this.is_Expiration_Date_RequiredField;
			}
			set
			{
				this.is_Expiration_Date_RequiredField = value;
				this.RaisePropertyChanged("Is_Expiration_Date_Required");
			}
		}

		[XmlIgnore]
		public bool Is_Expiration_Date_RequiredSpecified
		{
			get
			{
				return this.is_Expiration_Date_RequiredFieldSpecified;
			}
			set
			{
				this.is_Expiration_Date_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Is_Expiration_Date_RequiredSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public Requisition_SourceObjectType Requisition_Fulfillment_Source_Reference
		{
			get
			{
				return this.requisition_Fulfillment_Source_ReferenceField;
			}
			set
			{
				this.requisition_Fulfillment_Source_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Fulfillment_Source_Reference");
			}
		}

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 25)]
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

		[XmlElement("Purchase_Item_Unit_of_Measure_Data", Order = 26)]
		public Purchase_Item_Unit_of_Measure_DataType[] Purchase_Item_Unit_of_Measure_Data
		{
			get
			{
				return this.purchase_Item_Unit_of_Measure_DataField;
			}
			set
			{
				this.purchase_Item_Unit_of_Measure_DataField = value;
				this.RaisePropertyChanged("Purchase_Item_Unit_of_Measure_Data");
			}
		}

		[XmlElement("Item_Inventory_Attributes_Data", Order = 27)]
		public Item_Inventory_Attributes_DataType[] Item_Inventory_Attributes_Data
		{
			get
			{
				return this.item_Inventory_Attributes_DataField;
			}
			set
			{
				this.item_Inventory_Attributes_DataField = value;
				this.RaisePropertyChanged("Item_Inventory_Attributes_Data");
			}
		}

		[XmlElement("Item_Substitute_Data", Order = 28)]
		public Item_Substitute_DataType[] Item_Substitute_Data
		{
			get
			{
				return this.item_Substitute_DataField;
			}
			set
			{
				this.item_Substitute_DataField = value;
				this.RaisePropertyChanged("Item_Substitute_Data");
			}
		}

		[XmlElement(Order = 29)]
		public Sales_ItemObjectType Maps_To_Sales_Item_Reference
		{
			get
			{
				return this.maps_To_Sales_Item_ReferenceField;
			}
			set
			{
				this.maps_To_Sales_Item_ReferenceField = value;
				this.RaisePropertyChanged("Maps_To_Sales_Item_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
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
