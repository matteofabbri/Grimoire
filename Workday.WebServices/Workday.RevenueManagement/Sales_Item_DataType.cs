using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Sales_Item_DataType : INotifyPropertyChanged
	{
		private string sales_Item_IDField;

		private string item_NameField;

		private string alternate_NameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool worktag_OnlyField;

		private bool worktag_OnlyFieldSpecified;

		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private string item_DescriptionField;

		private string item_IdentifierField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_2_ReferenceField;

		private bool enable_Bulk_Quantity_PricingField;

		private bool enable_Bulk_Quantity_PricingFieldSpecified;

		private decimal item_Unit_PriceField;

		private bool item_Unit_PriceFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal uOM_Priced_at_Quantities_ofField;

		private bool uOM_Priced_at_Quantities_ofFieldSpecified;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Sales_Item_GroupObjectType[] sales_Item_Group_ReferenceField;

		private Project_TemplateObjectType project_Template_ReferenceField;

		private bool deferred_RevenueField;

		private bool deferred_RevenueFieldSpecified;

		private Revenue_Recognition_Schedule_TemplateObjectType revenue_Recognition_Schedule_Template_ReferenceField;

		private Schedule_Distribution_MethodObjectType revenue_Recognition_Method_ReferenceField;

		private decimal vSOE_PriceField;

		private bool vSOE_PriceFieldSpecified;

		private decimal third_Party_EvidenceField;

		private bool third_Party_EvidenceFieldSpecified;

		private decimal estimated_Selling_PriceField;

		private bool estimated_Selling_PriceFieldSpecified;

		private Contract_Line_TypeObjectType price_Type_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] related_Worktags_DataField;

		private Purchase_ItemObjectType maps_to_Purchase_Item_ReferenceField;

		private bool is_a_BundleField;

		private bool is_a_BundleFieldSpecified;

		private Sales_ItemObjectType[] sales_Item_To_Include_In_Bundle_ReferenceField;

		private Sales_ItemObjectType[] sales_Item_Bundle_ReferenceField;

		private bool fulfillment_RequiredField;

		private bool fulfillment_RequiredFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Sales_Item_ID
		{
			get
			{
				return this.sales_Item_IDField;
			}
			set
			{
				this.sales_Item_IDField = value;
				this.RaisePropertyChanged("Sales_Item_ID");
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
		public string Alternate_Name
		{
			get
			{
				return this.alternate_NameField;
			}
			set
			{
				this.alternate_NameField = value;
				this.RaisePropertyChanged("Alternate_Name");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public bool Worktag_Only
		{
			get
			{
				return this.worktag_OnlyField;
			}
			set
			{
				this.worktag_OnlyField = value;
				this.RaisePropertyChanged("Worktag_Only");
			}
		}

		[XmlIgnore]
		public bool Worktag_OnlySpecified
		{
			get
			{
				return this.worktag_OnlyFieldSpecified;
			}
			set
			{
				this.worktag_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Worktag_OnlySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Revenue_CategoryObjectType Revenue_Category_Reference
		{
			get
			{
				return this.revenue_Category_ReferenceField;
			}
			set
			{
				this.revenue_Category_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Unit_of_MeasureObjectType Unit_of_Measure_2_Reference
		{
			get
			{
				return this.unit_of_Measure_2_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_2_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_2_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Enable_Bulk_Quantity_Pricing
		{
			get
			{
				return this.enable_Bulk_Quantity_PricingField;
			}
			set
			{
				this.enable_Bulk_Quantity_PricingField = value;
				this.RaisePropertyChanged("Enable_Bulk_Quantity_Pricing");
			}
		}

		[XmlIgnore]
		public bool Enable_Bulk_Quantity_PricingSpecified
		{
			get
			{
				return this.enable_Bulk_Quantity_PricingFieldSpecified;
			}
			set
			{
				this.enable_Bulk_Quantity_PricingFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Bulk_Quantity_PricingSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public decimal UOM_Priced_at_Quantities_of
		{
			get
			{
				return this.uOM_Priced_at_Quantities_ofField;
			}
			set
			{
				this.uOM_Priced_at_Quantities_ofField = value;
				this.RaisePropertyChanged("UOM_Priced_at_Quantities_of");
			}
		}

		[XmlIgnore]
		public bool UOM_Priced_at_Quantities_ofSpecified
		{
			get
			{
				return this.uOM_Priced_at_Quantities_ofFieldSpecified;
			}
			set
			{
				this.uOM_Priced_at_Quantities_ofFieldSpecified = value;
				this.RaisePropertyChanged("UOM_Priced_at_Quantities_ofSpecified");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement("Sales_Item_Group_Reference", Order = 15)]
		public Sales_Item_GroupObjectType[] Sales_Item_Group_Reference
		{
			get
			{
				return this.sales_Item_Group_ReferenceField;
			}
			set
			{
				this.sales_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Group_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Project_TemplateObjectType Project_Template_Reference
		{
			get
			{
				return this.project_Template_ReferenceField;
			}
			set
			{
				this.project_Template_ReferenceField = value;
				this.RaisePropertyChanged("Project_Template_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public bool Deferred_Revenue
		{
			get
			{
				return this.deferred_RevenueField;
			}
			set
			{
				this.deferred_RevenueField = value;
				this.RaisePropertyChanged("Deferred_Revenue");
			}
		}

		[XmlIgnore]
		public bool Deferred_RevenueSpecified
		{
			get
			{
				return this.deferred_RevenueFieldSpecified;
			}
			set
			{
				this.deferred_RevenueFieldSpecified = value;
				this.RaisePropertyChanged("Deferred_RevenueSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public Revenue_Recognition_Schedule_TemplateObjectType Revenue_Recognition_Schedule_Template_Reference
		{
			get
			{
				return this.revenue_Recognition_Schedule_Template_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Schedule_Template_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Schedule_Template_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Schedule_Distribution_MethodObjectType Revenue_Recognition_Method_Reference
		{
			get
			{
				return this.revenue_Recognition_Method_ReferenceField;
			}
			set
			{
				this.revenue_Recognition_Method_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Method_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public decimal VSOE_Price
		{
			get
			{
				return this.vSOE_PriceField;
			}
			set
			{
				this.vSOE_PriceField = value;
				this.RaisePropertyChanged("VSOE_Price");
			}
		}

		[XmlIgnore]
		public bool VSOE_PriceSpecified
		{
			get
			{
				return this.vSOE_PriceFieldSpecified;
			}
			set
			{
				this.vSOE_PriceFieldSpecified = value;
				this.RaisePropertyChanged("VSOE_PriceSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Third_Party_Evidence
		{
			get
			{
				return this.third_Party_EvidenceField;
			}
			set
			{
				this.third_Party_EvidenceField = value;
				this.RaisePropertyChanged("Third_Party_Evidence");
			}
		}

		[XmlIgnore]
		public bool Third_Party_EvidenceSpecified
		{
			get
			{
				return this.third_Party_EvidenceFieldSpecified;
			}
			set
			{
				this.third_Party_EvidenceFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_EvidenceSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Estimated_Selling_Price
		{
			get
			{
				return this.estimated_Selling_PriceField;
			}
			set
			{
				this.estimated_Selling_PriceField = value;
				this.RaisePropertyChanged("Estimated_Selling_Price");
			}
		}

		[XmlIgnore]
		public bool Estimated_Selling_PriceSpecified
		{
			get
			{
				return this.estimated_Selling_PriceFieldSpecified;
			}
			set
			{
				this.estimated_Selling_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_Selling_PriceSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public Contract_Line_TypeObjectType Price_Type_Reference
		{
			get
			{
				return this.price_Type_ReferenceField;
			}
			set
			{
				this.price_Type_ReferenceField = value;
				this.RaisePropertyChanged("Price_Type_Reference");
			}
		}

		[XmlArray(Order = 24), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
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

		[XmlElement(Order = 25)]
		public Purchase_ItemObjectType Maps_to_Purchase_Item_Reference
		{
			get
			{
				return this.maps_to_Purchase_Item_ReferenceField;
			}
			set
			{
				this.maps_to_Purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Maps_to_Purchase_Item_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public bool Is_a_Bundle
		{
			get
			{
				return this.is_a_BundleField;
			}
			set
			{
				this.is_a_BundleField = value;
				this.RaisePropertyChanged("Is_a_Bundle");
			}
		}

		[XmlIgnore]
		public bool Is_a_BundleSpecified
		{
			get
			{
				return this.is_a_BundleFieldSpecified;
			}
			set
			{
				this.is_a_BundleFieldSpecified = value;
				this.RaisePropertyChanged("Is_a_BundleSpecified");
			}
		}

		[XmlElement("Sales_Item_To_Include_In_Bundle_Reference", Order = 27)]
		public Sales_ItemObjectType[] Sales_Item_To_Include_In_Bundle_Reference
		{
			get
			{
				return this.sales_Item_To_Include_In_Bundle_ReferenceField;
			}
			set
			{
				this.sales_Item_To_Include_In_Bundle_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_To_Include_In_Bundle_Reference");
			}
		}

		[XmlElement("Sales_Item_Bundle_Reference", Order = 28)]
		public Sales_ItemObjectType[] Sales_Item_Bundle_Reference
		{
			get
			{
				return this.sales_Item_Bundle_ReferenceField;
			}
			set
			{
				this.sales_Item_Bundle_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Bundle_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public bool Fulfillment_Required
		{
			get
			{
				return this.fulfillment_RequiredField;
			}
			set
			{
				this.fulfillment_RequiredField = value;
				this.RaisePropertyChanged("Fulfillment_Required");
			}
		}

		[XmlIgnore]
		public bool Fulfillment_RequiredSpecified
		{
			get
			{
				return this.fulfillment_RequiredFieldSpecified;
			}
			set
			{
				this.fulfillment_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Fulfillment_RequiredSpecified");
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
