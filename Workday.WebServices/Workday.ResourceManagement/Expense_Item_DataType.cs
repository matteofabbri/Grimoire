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
	public class Expense_Item_DataType : INotifyPropertyChanged
	{
		private string expense_Item_IDField;

		private string item_NameField;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private string item_DescriptionField;

		private string synonyms_and_KeywordsField;

		private bool per_Diem_ExpenseField;

		private bool per_Diem_ExpenseFieldSpecified;

		private decimal item_Unit_PriceField;

		private bool item_Unit_PriceFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string instructional_TextField;

		private Expense_Policy_GroupObjectType[] expense_Policy_Group_ReferenceField;

		private Expense_Item_GroupObjectType[] expense_Item_Group_ReferenceField;

		private Job_ProfileObjectType[] job_Profile_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private bool travel_JournalField;

		private bool travel_JournalFieldSpecified;

		private Expense_ItemObjectType travel_Journal_Item_ReferenceField;

		private bool quantity_and_Per_Unit_Amount_Not_EnterableField;

		private bool quantity_and_Per_Unit_Amount_Not_EnterableFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool fixed_ExpenseField;

		private bool fixed_ExpenseFieldSpecified;

		private bool maximum_ExpenseField;

		private bool maximum_ExpenseFieldSpecified;

		private bool allow_OverageField;

		private bool allow_OverageFieldSpecified;

		private bool based_on_Allowance_PlanField;

		private bool based_on_Allowance_PlanFieldSpecified;

		private bool memo_RequiredField;

		private bool memo_RequiredFieldSpecified;

		private bool display_Arrival_Date_before_Departure_DateField;

		private bool display_Arrival_Date_before_Departure_DateFieldSpecified;

		private Expense_Item_Attribute_and_Type_Subedit_Web_ServiceType[] expense_Item_Attribute_DataField;

		private Expense_AccumulatorObjectType expense_Accumulator_ReferenceField;

		private Expense_Rate_TableObjectType expense_Rate_Table_ReferenceField;

		private bool enable_Rate_Tables_for_Spend_AuthorizationsField;

		private bool enable_Rate_Tables_for_Spend_AuthorizationsFieldSpecified;

		private Expense_Adjustment_Calculation_Method_DataType[] expense_Adjustment_Calculation_Method_DataField;

		private Hotel_Itemization_Mapping_DataType[] hotel_Itemization_Mapping_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Expense_Item_ID
		{
			get
			{
				return this.expense_Item_IDField;
			}
			set
			{
				this.expense_Item_IDField = value;
				this.RaisePropertyChanged("Expense_Item_ID");
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
		public string Synonyms_and_Keywords
		{
			get
			{
				return this.synonyms_and_KeywordsField;
			}
			set
			{
				this.synonyms_and_KeywordsField = value;
				this.RaisePropertyChanged("Synonyms_and_Keywords");
			}
		}

		[XmlElement(Order = 5)]
		public bool Per_Diem_Expense
		{
			get
			{
				return this.per_Diem_ExpenseField;
			}
			set
			{
				this.per_Diem_ExpenseField = value;
				this.RaisePropertyChanged("Per_Diem_Expense");
			}
		}

		[XmlIgnore]
		public bool Per_Diem_ExpenseSpecified
		{
			get
			{
				return this.per_Diem_ExpenseFieldSpecified;
			}
			set
			{
				this.per_Diem_ExpenseFieldSpecified = value;
				this.RaisePropertyChanged("Per_Diem_ExpenseSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public string Instructional_Text
		{
			get
			{
				return this.instructional_TextField;
			}
			set
			{
				this.instructional_TextField = value;
				this.RaisePropertyChanged("Instructional_Text");
			}
		}

		[XmlElement("Expense_Policy_Group_Reference", Order = 9)]
		public Expense_Policy_GroupObjectType[] Expense_Policy_Group_Reference
		{
			get
			{
				return this.expense_Policy_Group_ReferenceField;
			}
			set
			{
				this.expense_Policy_Group_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Policy_Group_Reference");
			}
		}

		[XmlElement("Expense_Item_Group_Reference", Order = 10)]
		public Expense_Item_GroupObjectType[] Expense_Item_Group_Reference
		{
			get
			{
				return this.expense_Item_Group_ReferenceField;
			}
			set
			{
				this.expense_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Group_Reference");
			}
		}

		[XmlElement("Job_Profile_Reference", Order = 11)]
		public Job_ProfileObjectType[] Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Travel_Journal
		{
			get
			{
				return this.travel_JournalField;
			}
			set
			{
				this.travel_JournalField = value;
				this.RaisePropertyChanged("Travel_Journal");
			}
		}

		[XmlIgnore]
		public bool Travel_JournalSpecified
		{
			get
			{
				return this.travel_JournalFieldSpecified;
			}
			set
			{
				this.travel_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Travel_JournalSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Expense_ItemObjectType Travel_Journal_Item_Reference
		{
			get
			{
				return this.travel_Journal_Item_ReferenceField;
			}
			set
			{
				this.travel_Journal_Item_ReferenceField = value;
				this.RaisePropertyChanged("Travel_Journal_Item_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public bool Quantity_and_Per_Unit_Amount_Not_Enterable
		{
			get
			{
				return this.quantity_and_Per_Unit_Amount_Not_EnterableField;
			}
			set
			{
				this.quantity_and_Per_Unit_Amount_Not_EnterableField = value;
				this.RaisePropertyChanged("Quantity_and_Per_Unit_Amount_Not_Enterable");
			}
		}

		[XmlIgnore]
		public bool Quantity_and_Per_Unit_Amount_Not_EnterableSpecified
		{
			get
			{
				return this.quantity_and_Per_Unit_Amount_Not_EnterableFieldSpecified;
			}
			set
			{
				this.quantity_and_Per_Unit_Amount_Not_EnterableFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_and_Per_Unit_Amount_Not_EnterableSpecified");
			}
		}

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public bool Fixed_Expense
		{
			get
			{
				return this.fixed_ExpenseField;
			}
			set
			{
				this.fixed_ExpenseField = value;
				this.RaisePropertyChanged("Fixed_Expense");
			}
		}

		[XmlIgnore]
		public bool Fixed_ExpenseSpecified
		{
			get
			{
				return this.fixed_ExpenseFieldSpecified;
			}
			set
			{
				this.fixed_ExpenseFieldSpecified = value;
				this.RaisePropertyChanged("Fixed_ExpenseSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Maximum_Expense
		{
			get
			{
				return this.maximum_ExpenseField;
			}
			set
			{
				this.maximum_ExpenseField = value;
				this.RaisePropertyChanged("Maximum_Expense");
			}
		}

		[XmlIgnore]
		public bool Maximum_ExpenseSpecified
		{
			get
			{
				return this.maximum_ExpenseFieldSpecified;
			}
			set
			{
				this.maximum_ExpenseFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_ExpenseSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Allow_Overage
		{
			get
			{
				return this.allow_OverageField;
			}
			set
			{
				this.allow_OverageField = value;
				this.RaisePropertyChanged("Allow_Overage");
			}
		}

		[XmlIgnore]
		public bool Allow_OverageSpecified
		{
			get
			{
				return this.allow_OverageFieldSpecified;
			}
			set
			{
				this.allow_OverageFieldSpecified = value;
				this.RaisePropertyChanged("Allow_OverageSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Based_on_Allowance_Plan
		{
			get
			{
				return this.based_on_Allowance_PlanField;
			}
			set
			{
				this.based_on_Allowance_PlanField = value;
				this.RaisePropertyChanged("Based_on_Allowance_Plan");
			}
		}

		[XmlIgnore]
		public bool Based_on_Allowance_PlanSpecified
		{
			get
			{
				return this.based_on_Allowance_PlanFieldSpecified;
			}
			set
			{
				this.based_on_Allowance_PlanFieldSpecified = value;
				this.RaisePropertyChanged("Based_on_Allowance_PlanSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Memo_Required
		{
			get
			{
				return this.memo_RequiredField;
			}
			set
			{
				this.memo_RequiredField = value;
				this.RaisePropertyChanged("Memo_Required");
			}
		}

		[XmlIgnore]
		public bool Memo_RequiredSpecified
		{
			get
			{
				return this.memo_RequiredFieldSpecified;
			}
			set
			{
				this.memo_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Memo_RequiredSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Display_Arrival_Date_before_Departure_Date
		{
			get
			{
				return this.display_Arrival_Date_before_Departure_DateField;
			}
			set
			{
				this.display_Arrival_Date_before_Departure_DateField = value;
				this.RaisePropertyChanged("Display_Arrival_Date_before_Departure_Date");
			}
		}

		[XmlIgnore]
		public bool Display_Arrival_Date_before_Departure_DateSpecified
		{
			get
			{
				return this.display_Arrival_Date_before_Departure_DateFieldSpecified;
			}
			set
			{
				this.display_Arrival_Date_before_Departure_DateFieldSpecified = value;
				this.RaisePropertyChanged("Display_Arrival_Date_before_Departure_DateSpecified");
			}
		}

		[XmlElement("Expense_Item_Attribute_Data", Order = 24)]
		public Expense_Item_Attribute_and_Type_Subedit_Web_ServiceType[] Expense_Item_Attribute_Data
		{
			get
			{
				return this.expense_Item_Attribute_DataField;
			}
			set
			{
				this.expense_Item_Attribute_DataField = value;
				this.RaisePropertyChanged("Expense_Item_Attribute_Data");
			}
		}

		[XmlElement(Order = 25)]
		public Expense_AccumulatorObjectType Expense_Accumulator_Reference
		{
			get
			{
				return this.expense_Accumulator_ReferenceField;
			}
			set
			{
				this.expense_Accumulator_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Accumulator_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Expense_Rate_TableObjectType Expense_Rate_Table_Reference
		{
			get
			{
				return this.expense_Rate_Table_ReferenceField;
			}
			set
			{
				this.expense_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Rate_Table_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public bool Enable_Rate_Tables_for_Spend_Authorizations
		{
			get
			{
				return this.enable_Rate_Tables_for_Spend_AuthorizationsField;
			}
			set
			{
				this.enable_Rate_Tables_for_Spend_AuthorizationsField = value;
				this.RaisePropertyChanged("Enable_Rate_Tables_for_Spend_Authorizations");
			}
		}

		[XmlIgnore]
		public bool Enable_Rate_Tables_for_Spend_AuthorizationsSpecified
		{
			get
			{
				return this.enable_Rate_Tables_for_Spend_AuthorizationsFieldSpecified;
			}
			set
			{
				this.enable_Rate_Tables_for_Spend_AuthorizationsFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Rate_Tables_for_Spend_AuthorizationsSpecified");
			}
		}

		[XmlElement("Expense_Adjustment_Calculation_Method_Data", Order = 28)]
		public Expense_Adjustment_Calculation_Method_DataType[] Expense_Adjustment_Calculation_Method_Data
		{
			get
			{
				return this.expense_Adjustment_Calculation_Method_DataField;
			}
			set
			{
				this.expense_Adjustment_Calculation_Method_DataField = value;
				this.RaisePropertyChanged("Expense_Adjustment_Calculation_Method_Data");
			}
		}

		[XmlElement("Hotel_Itemization_Mapping_Data", Order = 29)]
		public Hotel_Itemization_Mapping_DataType[] Hotel_Itemization_Mapping_Data
		{
			get
			{
				return this.hotel_Itemization_Mapping_DataField;
			}
			set
			{
				this.hotel_Itemization_Mapping_DataField = value;
				this.RaisePropertyChanged("Hotel_Itemization_Mapping_Data");
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
