using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Spend_Category_DataType : INotifyPropertyChanged
	{
		private string resource_Category_IDField;

		private string resource_Category_NameField;

		private Unique_IdentifierObjectType[] spend_Category_Usage_ReferenceField;

		private bool procurement_UsageField;

		private bool procurement_UsageFieldSpecified;

		private bool expense_UsageField;

		private bool expense_UsageFieldSpecified;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private bool allocate_FreightField;

		private bool allocate_FreightFieldSpecified;

		private bool allocate_Other_ChargesField;

		private bool allocate_Other_ChargesFieldSpecified;

		private bool track_ItemsField;

		private bool track_ItemsFieldSpecified;

		private bool stock_ItemsField;

		private bool stock_ItemsFieldSpecified;

		private Unit_of_Measure_SetObjectType default_Unit_of_Measure_Set_ReferenceField;

		private Accounting_TreatmentObjectType inventory_Accounting_Treatment_ReferenceField;

		private Item_Identifier_TypeObjectType[] item_Identifier_Type_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private Depreciation_ProfileObjectType depreciation_Profile_ReferenceField;

		private UNSPSC_Code_RangeType[] uNSPSC_Code_RangeField;

		private Asset_TypeObjectType asset_Type_ReferenceField;

		private Asset_ClassObjectType asset_Class_ReferenceField;

		private bool intangible_ReferenceField;

		private bool intangible_ReferenceFieldSpecified;

		private bool leaseField;

		private bool leaseFieldSpecified;

		private string commodity_CodeField;

		private string descriptionField;

		private Spend_Category_or_Hierarchy_Display_OptionObjectType spend_Category_Display_Option_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Requisition_SourceObjectType requisition_Fulfillment_Source_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private Revenue_CategoryObjectType maps_to_Revenue_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Category_ID
		{
			get
			{
				return this.resource_Category_IDField;
			}
			set
			{
				this.resource_Category_IDField = value;
				this.RaisePropertyChanged("Resource_Category_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Resource_Category_Name
		{
			get
			{
				return this.resource_Category_NameField;
			}
			set
			{
				this.resource_Category_NameField = value;
				this.RaisePropertyChanged("Resource_Category_Name");
			}
		}

		[XmlElement("Spend_Category_Usage_Reference", Order = 2)]
		public Unique_IdentifierObjectType[] Spend_Category_Usage_Reference
		{
			get
			{
				return this.spend_Category_Usage_ReferenceField;
			}
			set
			{
				this.spend_Category_Usage_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Usage_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Procurement_Usage
		{
			get
			{
				return this.procurement_UsageField;
			}
			set
			{
				this.procurement_UsageField = value;
				this.RaisePropertyChanged("Procurement_Usage");
			}
		}

		[XmlIgnore]
		public bool Procurement_UsageSpecified
		{
			get
			{
				return this.procurement_UsageFieldSpecified;
			}
			set
			{
				this.procurement_UsageFieldSpecified = value;
				this.RaisePropertyChanged("Procurement_UsageSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Expense_Usage
		{
			get
			{
				return this.expense_UsageField;
			}
			set
			{
				this.expense_UsageField = value;
				this.RaisePropertyChanged("Expense_Usage");
			}
		}

		[XmlIgnore]
		public bool Expense_UsageSpecified
		{
			get
			{
				return this.expense_UsageFieldSpecified;
			}
			set
			{
				this.expense_UsageFieldSpecified = value;
				this.RaisePropertyChanged("Expense_UsageSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public bool Allocate_Freight
		{
			get
			{
				return this.allocate_FreightField;
			}
			set
			{
				this.allocate_FreightField = value;
				this.RaisePropertyChanged("Allocate_Freight");
			}
		}

		[XmlIgnore]
		public bool Allocate_FreightSpecified
		{
			get
			{
				return this.allocate_FreightFieldSpecified;
			}
			set
			{
				this.allocate_FreightFieldSpecified = value;
				this.RaisePropertyChanged("Allocate_FreightSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Allocate_Other_Charges
		{
			get
			{
				return this.allocate_Other_ChargesField;
			}
			set
			{
				this.allocate_Other_ChargesField = value;
				this.RaisePropertyChanged("Allocate_Other_Charges");
			}
		}

		[XmlIgnore]
		public bool Allocate_Other_ChargesSpecified
		{
			get
			{
				return this.allocate_Other_ChargesFieldSpecified;
			}
			set
			{
				this.allocate_Other_ChargesFieldSpecified = value;
				this.RaisePropertyChanged("Allocate_Other_ChargesSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Track_Items
		{
			get
			{
				return this.track_ItemsField;
			}
			set
			{
				this.track_ItemsField = value;
				this.RaisePropertyChanged("Track_Items");
			}
		}

		[XmlIgnore]
		public bool Track_ItemsSpecified
		{
			get
			{
				return this.track_ItemsFieldSpecified;
			}
			set
			{
				this.track_ItemsFieldSpecified = value;
				this.RaisePropertyChanged("Track_ItemsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Stock_Items
		{
			get
			{
				return this.stock_ItemsField;
			}
			set
			{
				this.stock_ItemsField = value;
				this.RaisePropertyChanged("Stock_Items");
			}
		}

		[XmlIgnore]
		public bool Stock_ItemsSpecified
		{
			get
			{
				return this.stock_ItemsFieldSpecified;
			}
			set
			{
				this.stock_ItemsFieldSpecified = value;
				this.RaisePropertyChanged("Stock_ItemsSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Unit_of_Measure_SetObjectType Default_Unit_of_Measure_Set_Reference
		{
			get
			{
				return this.default_Unit_of_Measure_Set_ReferenceField;
			}
			set
			{
				this.default_Unit_of_Measure_Set_ReferenceField = value;
				this.RaisePropertyChanged("Default_Unit_of_Measure_Set_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Accounting_TreatmentObjectType Inventory_Accounting_Treatment_Reference
		{
			get
			{
				return this.inventory_Accounting_Treatment_ReferenceField;
			}
			set
			{
				this.inventory_Accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Accounting_Treatment_Reference");
			}
		}

		[XmlElement("Item_Identifier_Type_Reference", Order = 12)]
		public Item_Identifier_TypeObjectType[] Item_Identifier_Type_Reference
		{
			get
			{
				return this.item_Identifier_Type_ReferenceField;
			}
			set
			{
				this.item_Identifier_Type_ReferenceField = value;
				this.RaisePropertyChanged("Item_Identifier_Type_Reference");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public Depreciation_ProfileObjectType Depreciation_Profile_Reference
		{
			get
			{
				return this.depreciation_Profile_ReferenceField;
			}
			set
			{
				this.depreciation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Profile_Reference");
			}
		}

		[XmlElement("UNSPSC_Code_Range", Order = 15)]
		public UNSPSC_Code_RangeType[] UNSPSC_Code_Range
		{
			get
			{
				return this.uNSPSC_Code_RangeField;
			}
			set
			{
				this.uNSPSC_Code_RangeField = value;
				this.RaisePropertyChanged("UNSPSC_Code_Range");
			}
		}

		[XmlElement(Order = 16)]
		public Asset_TypeObjectType Asset_Type_Reference
		{
			get
			{
				return this.asset_Type_ReferenceField;
			}
			set
			{
				this.asset_Type_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Type_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Asset_ClassObjectType Asset_Class_Reference
		{
			get
			{
				return this.asset_Class_ReferenceField;
			}
			set
			{
				this.asset_Class_ReferenceField = value;
				this.RaisePropertyChanged("Asset_Class_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public bool Intangible_Reference
		{
			get
			{
				return this.intangible_ReferenceField;
			}
			set
			{
				this.intangible_ReferenceField = value;
				this.RaisePropertyChanged("Intangible_Reference");
			}
		}

		[XmlIgnore]
		public bool Intangible_ReferenceSpecified
		{
			get
			{
				return this.intangible_ReferenceFieldSpecified;
			}
			set
			{
				this.intangible_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Intangible_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Lease
		{
			get
			{
				return this.leaseField;
			}
			set
			{
				this.leaseField = value;
				this.RaisePropertyChanged("Lease");
			}
		}

		[XmlIgnore]
		public bool LeaseSpecified
		{
			get
			{
				return this.leaseFieldSpecified;
			}
			set
			{
				this.leaseFieldSpecified = value;
				this.RaisePropertyChanged("LeaseSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public string Commodity_Code
		{
			get
			{
				return this.commodity_CodeField;
			}
			set
			{
				this.commodity_CodeField = value;
				this.RaisePropertyChanged("Commodity_Code");
			}
		}

		[XmlElement(Order = 21)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 22)]
		public Spend_Category_or_Hierarchy_Display_OptionObjectType Spend_Category_Display_Option_Reference
		{
			get
			{
				return this.spend_Category_Display_Option_ReferenceField;
			}
			set
			{
				this.spend_Category_Display_Option_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Display_Option_Reference");
			}
		}

		[XmlElement(Order = 23)]
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

		[XmlArray(Order = 25), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
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

		[XmlElement(Order = 26)]
		public Revenue_CategoryObjectType Maps_to_Revenue_Category_Reference
		{
			get
			{
				return this.maps_to_Revenue_Category_ReferenceField;
			}
			set
			{
				this.maps_to_Revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Maps_to_Revenue_Category_Reference");
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
