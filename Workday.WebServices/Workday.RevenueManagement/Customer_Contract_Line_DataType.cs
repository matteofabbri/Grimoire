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
	public class Customer_Contract_Line_DataType : INotifyPropertyChanged
	{
		private Receivable_Contract_Line_AbstractObjectType receivable_Contract_Line_ReferenceField;

		private string receivable_Contract_Line_Reference_IDField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private CompanyObjectType line_Company_ReferenceField;

		private Customer_Contract_LineObjectType[] bundled_Revenue_Only_Contract_Line_ReferenceField;

		private Customer_Contract_LineObjectType billing_Only_Customer_Contract_Line_ReferenceField;

		private decimal bundle_Line_NumberField;

		private bool bundle_Line_NumberFieldSpecified;

		private Item_DescriptorObjectType sales_Item_ReferenceField;

		private Accounting_CategoryObjectType revenue_Category_ReferenceField;

		private Contract_Line_TypeObjectType contract_Line_Type_ReferenceField;

		private Customer_Contract_LineObjectType alternate_Customer_Contract_Line_ReferenceField;

		private Customer_Contract_LineObjectType original_Customer_Contract_Line_ReferenceField;

		private Project_AbstractObjectType billable_Project_ReferenceField;

		private Project_Transaction_SourceObjectType[] project_Transaction_Source_ReferenceField;

		private Contract_Rate_SheetObjectType contract_Rate_Sheet_ReferenceField;

		private Usage_Billing_RateObjectType usage_Billing_Rate_ReferenceField;

		private DateTime customer_Contract_Line_Start_DateField;

		private bool customer_Contract_Line_Start_DateFieldSpecified;

		private DateTime customer_Contract_Line_End_DateField;

		private bool customer_Contract_Line_End_DateFieldSpecified;

		private string contract_Line_DescriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantity_2Field;

		private bool quantity_2FieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_2_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal number_of_InstallmentsField;

		private bool number_of_InstallmentsFieldSpecified;

		private decimal regular_Installment_AmountField;

		private bool regular_Installment_AmountFieldSpecified;

		private decimal first_Installment_AmountField;

		private bool first_Installment_AmountFieldSpecified;

		private decimal last_Installment_AmountField;

		private bool last_Installment_AmountFieldSpecified;

		private Frequency_BehaviorObjectType frequency_Behavior_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private bool recalculate_FV_Unit_PriceField;

		private bool recalculate_FV_Unit_PriceFieldSpecified;

		private decimal fair_Value_Unit_PriceField;

		private bool fair_Value_Unit_PriceFieldSpecified;

		private decimal fair_Value_Extended_AmountField;

		private bool fair_Value_Extended_AmountFieldSpecified;

		private decimal list_Unit_PriceField;

		private bool list_Unit_PriceFieldSpecified;

		private decimal list_Extended_AmountField;

		private bool list_Extended_AmountFieldSpecified;

		private bool exclude_From_CalculationField;

		private bool exclude_From_CalculationFieldSpecified;

		private decimal range_LowField;

		private bool range_LowFieldSpecified;

		private decimal range_HighField;

		private bool range_HighFieldSpecified;

		private decimal midRangeField;

		private bool midRangeFieldSpecified;

		private decimal relative_Selling_Price_AllocationField;

		private bool relative_Selling_Price_AllocationFieldSpecified;

		private bool renewableField;

		private bool renewableFieldSpecified;

		private bool new_BusinessField;

		private bool new_BusinessFieldSpecified;

		private bool deferred_RevenueField;

		private bool deferred_RevenueFieldSpecified;

		private Revenue_Recognition_Schedule_TemplateObjectType revenue_Recognition_Schedule_Template_ReferenceField;

		private decimal customer_Contract_Line_Revenue_Override_AmountField;

		private bool customer_Contract_Line_Revenue_Override_AmountFieldSpecified;

		private decimal allocation_PercentageField;

		private bool allocation_PercentageFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] default_Worktags_ReferenceField;

		private string line_Item_Description_OverrideField;

		private string line_Invoice_MemoField;

		private string line_Invoice_Memo_OverrideField;

		private CustomerObjectType[] ship_To_Customer_ReferenceField;

		private Address_ReferenceObjectType[] ship_To_Address_ReferenceField;

		private Address_Information_DataType[] ship_To_Address_DataField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_CodeObjectType withholding_Tax_Code_ReferenceField;

		private DateTime billing_Schedule_From_DateField;

		private bool billing_Schedule_From_DateFieldSpecified;

		private DateTime billing_Schedule_To_DateField;

		private bool billing_Schedule_To_DateFieldSpecified;

		private string line_Billing_NotesField;

		private string revenue_Recognition_Line_NotesField;

		private Document_StatusObjectType document_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Receivable_Contract_Line_AbstractObjectType Receivable_Contract_Line_Reference
		{
			get
			{
				return this.receivable_Contract_Line_ReferenceField;
			}
			set
			{
				this.receivable_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Receivable_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Receivable_Contract_Line_Reference_ID
		{
			get
			{
				return this.receivable_Contract_Line_Reference_IDField;
			}
			set
			{
				this.receivable_Contract_Line_Reference_IDField = value;
				this.RaisePropertyChanged("Receivable_Contract_Line_Reference_ID");
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
		public CompanyObjectType Line_Company_Reference
		{
			get
			{
				return this.line_Company_ReferenceField;
			}
			set
			{
				this.line_Company_ReferenceField = value;
				this.RaisePropertyChanged("Line_Company_Reference");
			}
		}

		[XmlElement("Bundled_Revenue_Only_Contract_Line_Reference", Order = 4)]
		public Customer_Contract_LineObjectType[] Bundled_Revenue_Only_Contract_Line_Reference
		{
			get
			{
				return this.bundled_Revenue_Only_Contract_Line_ReferenceField;
			}
			set
			{
				this.bundled_Revenue_Only_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Bundled_Revenue_Only_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Customer_Contract_LineObjectType Billing_Only_Customer_Contract_Line_Reference
		{
			get
			{
				return this.billing_Only_Customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.billing_Only_Customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Only_Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Bundle_Line_Number
		{
			get
			{
				return this.bundle_Line_NumberField;
			}
			set
			{
				this.bundle_Line_NumberField = value;
				this.RaisePropertyChanged("Bundle_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Bundle_Line_NumberSpecified
		{
			get
			{
				return this.bundle_Line_NumberFieldSpecified;
			}
			set
			{
				this.bundle_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Bundle_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Item_DescriptorObjectType Sales_Item_Reference
		{
			get
			{
				return this.sales_Item_ReferenceField;
			}
			set
			{
				this.sales_Item_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Accounting_CategoryObjectType Revenue_Category_Reference
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

		[XmlElement(Order = 9)]
		public Contract_Line_TypeObjectType Contract_Line_Type_Reference
		{
			get
			{
				return this.contract_Line_Type_ReferenceField;
			}
			set
			{
				this.contract_Line_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Type_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Customer_Contract_LineObjectType Alternate_Customer_Contract_Line_Reference
		{
			get
			{
				return this.alternate_Customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.alternate_Customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Customer_Contract_LineObjectType Original_Customer_Contract_Line_Reference
		{
			get
			{
				return this.original_Customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.original_Customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Original_Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Project_AbstractObjectType Billable_Project_Reference
		{
			get
			{
				return this.billable_Project_ReferenceField;
			}
			set
			{
				this.billable_Project_ReferenceField = value;
				this.RaisePropertyChanged("Billable_Project_Reference");
			}
		}

		[XmlElement("Project_Transaction_Source_Reference", Order = 13)]
		public Project_Transaction_SourceObjectType[] Project_Transaction_Source_Reference
		{
			get
			{
				return this.project_Transaction_Source_ReferenceField;
			}
			set
			{
				this.project_Transaction_Source_ReferenceField = value;
				this.RaisePropertyChanged("Project_Transaction_Source_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Contract_Rate_SheetObjectType Contract_Rate_Sheet_Reference
		{
			get
			{
				return this.contract_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.contract_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Rate_Sheet_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Usage_Billing_RateObjectType Usage_Billing_Rate_Reference
		{
			get
			{
				return this.usage_Billing_Rate_ReferenceField;
			}
			set
			{
				this.usage_Billing_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Customer_Contract_Line_Start_Date
		{
			get
			{
				return this.customer_Contract_Line_Start_DateField;
			}
			set
			{
				this.customer_Contract_Line_Start_DateField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Customer_Contract_Line_Start_DateSpecified
		{
			get
			{
				return this.customer_Contract_Line_Start_DateFieldSpecified;
			}
			set
			{
				this.customer_Contract_Line_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime Customer_Contract_Line_End_Date
		{
			get
			{
				return this.customer_Contract_Line_End_DateField;
			}
			set
			{
				this.customer_Contract_Line_End_DateField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_End_Date");
			}
		}

		[XmlIgnore]
		public bool Customer_Contract_Line_End_DateSpecified
		{
			get
			{
				return this.customer_Contract_Line_End_DateFieldSpecified;
			}
			set
			{
				this.customer_Contract_Line_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Contract_Line_End_DateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public string Contract_Line_Description
		{
			get
			{
				return this.contract_Line_DescriptionField;
			}
			set
			{
				this.contract_Line_DescriptionField = value;
				this.RaisePropertyChanged("Contract_Line_Description");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
		public decimal Quantity_2
		{
			get
			{
				return this.quantity_2Field;
			}
			set
			{
				this.quantity_2Field = value;
				this.RaisePropertyChanged("Quantity_2");
			}
		}

		[XmlIgnore]
		public bool Quantity_2Specified
		{
			get
			{
				return this.quantity_2FieldSpecified;
			}
			set
			{
				this.quantity_2FieldSpecified = value;
				this.RaisePropertyChanged("Quantity_2Specified");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
		public decimal Number_of_Installments
		{
			get
			{
				return this.number_of_InstallmentsField;
			}
			set
			{
				this.number_of_InstallmentsField = value;
				this.RaisePropertyChanged("Number_of_Installments");
			}
		}

		[XmlIgnore]
		public bool Number_of_InstallmentsSpecified
		{
			get
			{
				return this.number_of_InstallmentsFieldSpecified;
			}
			set
			{
				this.number_of_InstallmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_InstallmentsSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Regular_Installment_Amount
		{
			get
			{
				return this.regular_Installment_AmountField;
			}
			set
			{
				this.regular_Installment_AmountField = value;
				this.RaisePropertyChanged("Regular_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool Regular_Installment_AmountSpecified
		{
			get
			{
				return this.regular_Installment_AmountFieldSpecified;
			}
			set
			{
				this.regular_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Regular_Installment_AmountSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public decimal First_Installment_Amount
		{
			get
			{
				return this.first_Installment_AmountField;
			}
			set
			{
				this.first_Installment_AmountField = value;
				this.RaisePropertyChanged("First_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool First_Installment_AmountSpecified
		{
			get
			{
				return this.first_Installment_AmountFieldSpecified;
			}
			set
			{
				this.first_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("First_Installment_AmountSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public decimal Last_Installment_Amount
		{
			get
			{
				return this.last_Installment_AmountField;
			}
			set
			{
				this.last_Installment_AmountField = value;
				this.RaisePropertyChanged("Last_Installment_Amount");
			}
		}

		[XmlIgnore]
		public bool Last_Installment_AmountSpecified
		{
			get
			{
				return this.last_Installment_AmountFieldSpecified;
			}
			set
			{
				this.last_Installment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Last_Installment_AmountSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public Frequency_BehaviorObjectType Frequency_Behavior_Reference
		{
			get
			{
				return this.frequency_Behavior_ReferenceField;
			}
			set
			{
				this.frequency_Behavior_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Behavior_Reference");
			}
		}

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
		public bool Recalculate_FV_Unit_Price
		{
			get
			{
				return this.recalculate_FV_Unit_PriceField;
			}
			set
			{
				this.recalculate_FV_Unit_PriceField = value;
				this.RaisePropertyChanged("Recalculate_FV_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Recalculate_FV_Unit_PriceSpecified
		{
			get
			{
				return this.recalculate_FV_Unit_PriceFieldSpecified;
			}
			set
			{
				this.recalculate_FV_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Recalculate_FV_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal Fair_Value_Unit_Price
		{
			get
			{
				return this.fair_Value_Unit_PriceField;
			}
			set
			{
				this.fair_Value_Unit_PriceField = value;
				this.RaisePropertyChanged("Fair_Value_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Fair_Value_Unit_PriceSpecified
		{
			get
			{
				return this.fair_Value_Unit_PriceFieldSpecified;
			}
			set
			{
				this.fair_Value_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Value_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Fair_Value_Extended_Amount
		{
			get
			{
				return this.fair_Value_Extended_AmountField;
			}
			set
			{
				this.fair_Value_Extended_AmountField = value;
				this.RaisePropertyChanged("Fair_Value_Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Fair_Value_Extended_AmountSpecified
		{
			get
			{
				return this.fair_Value_Extended_AmountFieldSpecified;
			}
			set
			{
				this.fair_Value_Extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Value_Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public decimal List_Unit_Price
		{
			get
			{
				return this.list_Unit_PriceField;
			}
			set
			{
				this.list_Unit_PriceField = value;
				this.RaisePropertyChanged("List_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool List_Unit_PriceSpecified
		{
			get
			{
				return this.list_Unit_PriceFieldSpecified;
			}
			set
			{
				this.list_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("List_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public decimal List_Extended_Amount
		{
			get
			{
				return this.list_Extended_AmountField;
			}
			set
			{
				this.list_Extended_AmountField = value;
				this.RaisePropertyChanged("List_Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool List_Extended_AmountSpecified
		{
			get
			{
				return this.list_Extended_AmountFieldSpecified;
			}
			set
			{
				this.list_Extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("List_Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public bool Exclude_From_Calculation
		{
			get
			{
				return this.exclude_From_CalculationField;
			}
			set
			{
				this.exclude_From_CalculationField = value;
				this.RaisePropertyChanged("Exclude_From_Calculation");
			}
		}

		[XmlIgnore]
		public bool Exclude_From_CalculationSpecified
		{
			get
			{
				return this.exclude_From_CalculationFieldSpecified;
			}
			set
			{
				this.exclude_From_CalculationFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_From_CalculationSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public decimal Range_Low
		{
			get
			{
				return this.range_LowField;
			}
			set
			{
				this.range_LowField = value;
				this.RaisePropertyChanged("Range_Low");
			}
		}

		[XmlIgnore]
		public bool Range_LowSpecified
		{
			get
			{
				return this.range_LowFieldSpecified;
			}
			set
			{
				this.range_LowFieldSpecified = value;
				this.RaisePropertyChanged("Range_LowSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Range_High
		{
			get
			{
				return this.range_HighField;
			}
			set
			{
				this.range_HighField = value;
				this.RaisePropertyChanged("Range_High");
			}
		}

		[XmlIgnore]
		public bool Range_HighSpecified
		{
			get
			{
				return this.range_HighFieldSpecified;
			}
			set
			{
				this.range_HighFieldSpecified = value;
				this.RaisePropertyChanged("Range_HighSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public decimal MidRange
		{
			get
			{
				return this.midRangeField;
			}
			set
			{
				this.midRangeField = value;
				this.RaisePropertyChanged("MidRange");
			}
		}

		[XmlIgnore]
		public bool MidRangeSpecified
		{
			get
			{
				return this.midRangeFieldSpecified;
			}
			set
			{
				this.midRangeFieldSpecified = value;
				this.RaisePropertyChanged("MidRangeSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public decimal Relative_Selling_Price_Allocation
		{
			get
			{
				return this.relative_Selling_Price_AllocationField;
			}
			set
			{
				this.relative_Selling_Price_AllocationField = value;
				this.RaisePropertyChanged("Relative_Selling_Price_Allocation");
			}
		}

		[XmlIgnore]
		public bool Relative_Selling_Price_AllocationSpecified
		{
			get
			{
				return this.relative_Selling_Price_AllocationFieldSpecified;
			}
			set
			{
				this.relative_Selling_Price_AllocationFieldSpecified = value;
				this.RaisePropertyChanged("Relative_Selling_Price_AllocationSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Renewable
		{
			get
			{
				return this.renewableField;
			}
			set
			{
				this.renewableField = value;
				this.RaisePropertyChanged("Renewable");
			}
		}

		[XmlIgnore]
		public bool RenewableSpecified
		{
			get
			{
				return this.renewableFieldSpecified;
			}
			set
			{
				this.renewableFieldSpecified = value;
				this.RaisePropertyChanged("RenewableSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public bool New_Business
		{
			get
			{
				return this.new_BusinessField;
			}
			set
			{
				this.new_BusinessField = value;
				this.RaisePropertyChanged("New_Business");
			}
		}

		[XmlIgnore]
		public bool New_BusinessSpecified
		{
			get
			{
				return this.new_BusinessFieldSpecified;
			}
			set
			{
				this.new_BusinessFieldSpecified = value;
				this.RaisePropertyChanged("New_BusinessSpecified");
			}
		}

		[XmlElement(Order = 42)]
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

		[XmlElement(Order = 43)]
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

		[XmlElement(Order = 44)]
		public decimal Customer_Contract_Line_Revenue_Override_Amount
		{
			get
			{
				return this.customer_Contract_Line_Revenue_Override_AmountField;
			}
			set
			{
				this.customer_Contract_Line_Revenue_Override_AmountField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Revenue_Override_Amount");
			}
		}

		[XmlIgnore]
		public bool Customer_Contract_Line_Revenue_Override_AmountSpecified
		{
			get
			{
				return this.customer_Contract_Line_Revenue_Override_AmountFieldSpecified;
			}
			set
			{
				this.customer_Contract_Line_Revenue_Override_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Revenue_Override_AmountSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public decimal Allocation_Percentage
		{
			get
			{
				return this.allocation_PercentageField;
			}
			set
			{
				this.allocation_PercentageField = value;
				this.RaisePropertyChanged("Allocation_Percentage");
			}
		}

		[XmlIgnore]
		public bool Allocation_PercentageSpecified
		{
			get
			{
				return this.allocation_PercentageFieldSpecified;
			}
			set
			{
				this.allocation_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Allocation_PercentageSpecified");
			}
		}

		[XmlElement("Default_Worktags_Reference", Order = 46)]
		public Audited_Accounting_WorktagObjectType[] Default_Worktags_Reference
		{
			get
			{
				return this.default_Worktags_ReferenceField;
			}
			set
			{
				this.default_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Default_Worktags_Reference");
			}
		}

		[XmlElement(Order = 47)]
		public string Line_Item_Description_Override
		{
			get
			{
				return this.line_Item_Description_OverrideField;
			}
			set
			{
				this.line_Item_Description_OverrideField = value;
				this.RaisePropertyChanged("Line_Item_Description_Override");
			}
		}

		[XmlElement(Order = 48)]
		public string Line_Invoice_Memo
		{
			get
			{
				return this.line_Invoice_MemoField;
			}
			set
			{
				this.line_Invoice_MemoField = value;
				this.RaisePropertyChanged("Line_Invoice_Memo");
			}
		}

		[XmlElement(Order = 49)]
		public string Line_Invoice_Memo_Override
		{
			get
			{
				return this.line_Invoice_Memo_OverrideField;
			}
			set
			{
				this.line_Invoice_Memo_OverrideField = value;
				this.RaisePropertyChanged("Line_Invoice_Memo_Override");
			}
		}

		[XmlElement("Ship_To_Customer_Reference", Order = 50)]
		public CustomerObjectType[] Ship_To_Customer_Reference
		{
			get
			{
				return this.ship_To_Customer_ReferenceField;
			}
			set
			{
				this.ship_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Customer_Reference");
			}
		}

		[XmlElement("Ship_To_Address_Reference", Order = 51)]
		public Address_ReferenceObjectType[] Ship_To_Address_Reference
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

		[XmlElement("Ship_To_Address_Data", Order = 52)]
		public Address_Information_DataType[] Ship_To_Address_Data
		{
			get
			{
				return this.ship_To_Address_DataField;
			}
			set
			{
				this.ship_To_Address_DataField = value;
				this.RaisePropertyChanged("Ship_To_Address_Data");
			}
		}

		[XmlElement(Order = 53)]
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

		[XmlElement(Order = 54)]
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

		[XmlElement(Order = 55)]
		public Tax_CodeObjectType Withholding_Tax_Code_Reference
		{
			get
			{
				return this.withholding_Tax_Code_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 56)]
		public DateTime Billing_Schedule_From_Date
		{
			get
			{
				return this.billing_Schedule_From_DateField;
			}
			set
			{
				this.billing_Schedule_From_DateField = value;
				this.RaisePropertyChanged("Billing_Schedule_From_Date");
			}
		}

		[XmlIgnore]
		public bool Billing_Schedule_From_DateSpecified
		{
			get
			{
				return this.billing_Schedule_From_DateFieldSpecified;
			}
			set
			{
				this.billing_Schedule_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Billing_Schedule_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 57)]
		public DateTime Billing_Schedule_To_Date
		{
			get
			{
				return this.billing_Schedule_To_DateField;
			}
			set
			{
				this.billing_Schedule_To_DateField = value;
				this.RaisePropertyChanged("Billing_Schedule_To_Date");
			}
		}

		[XmlIgnore]
		public bool Billing_Schedule_To_DateSpecified
		{
			get
			{
				return this.billing_Schedule_To_DateFieldSpecified;
			}
			set
			{
				this.billing_Schedule_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Billing_Schedule_To_DateSpecified");
			}
		}

		[XmlElement(Order = 58)]
		public string Line_Billing_Notes
		{
			get
			{
				return this.line_Billing_NotesField;
			}
			set
			{
				this.line_Billing_NotesField = value;
				this.RaisePropertyChanged("Line_Billing_Notes");
			}
		}

		[XmlElement(Order = 59)]
		public string Revenue_Recognition_Line_Notes
		{
			get
			{
				return this.revenue_Recognition_Line_NotesField;
			}
			set
			{
				this.revenue_Recognition_Line_NotesField = value;
				this.RaisePropertyChanged("Revenue_Recognition_Line_Notes");
			}
		}

		[XmlElement(Order = 60)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
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
