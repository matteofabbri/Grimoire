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
	public class Customer_Invoice_Line__HV__DataType : INotifyPropertyChanged
	{
		private Customer_Invoice_Line_AbstractObjectType customer_Invoice_Line_ReferenceField;

		private string customer_Invoice_Line_Reference_IDField;

		private string line_OrderField;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Sales_ItemObjectType sales_Item_ReferenceField;

		private Revenue_CategoryObjectType revenue_Category_ReferenceField;

		private string line_Item_DescriptionField;

		private CustomerObjectType ship_To_Customer_ReferenceField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private Address_Information_DataType[] ship_To_Address_DataField;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_CodeObjectType withholding_Tax_Code_ReferenceField;

		private Receivable_Contract_Line_AbstractObjectType customer_Contract_Line_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantity_2Field;

		private bool quantity_2FieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_2_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private ProjectObjectType billable_Project_ReferenceField;

		private Project_Plan_PhaseObjectType project_Plan_Phase_ReferenceField;

		private Project_Plan_TaskObjectType project_Plan_Task_ReferenceField;

		private bool deferred_RevenueField;

		private bool deferred_RevenueFieldSpecified;

		private Revenue_Recognition_Schedule_TemplateObjectType revenue_Recognition_Schedule_Template_ReferenceField;

		private string memoField;

		private decimal analytical_AmountField;

		private bool analytical_AmountFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		private decimal calculated_Tax_AmountField;

		private bool calculated_Tax_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Invoice_Line_AbstractObjectType Customer_Invoice_Line_Reference
		{
			get
			{
				return this.customer_Invoice_Line_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Customer_Invoice_Line_Reference_ID
		{
			get
			{
				return this.customer_Invoice_Line_Reference_IDField;
			}
			set
			{
				this.customer_Invoice_Line_Reference_IDField = value;
				this.RaisePropertyChanged("Customer_Invoice_Line_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Intercompany_Affiliate_Reference
		{
			get
			{
				return this.intercompany_Affiliate_ReferenceField;
			}
			set
			{
				this.intercompany_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Affiliate_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Sales_ItemObjectType Sales_Item_Reference
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
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
			}
		}

		[XmlElement(Order = 7)]
		public CustomerObjectType Ship_To_Customer_Reference
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Ship_To_Address_Data", Order = 9)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public Receivable_Contract_Line_AbstractObjectType Customer_Contract_Line_Reference
		{
			get
			{
				return this.customer_Contract_Line_ReferenceField;
			}
			set
			{
				this.customer_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 21)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public ProjectObjectType Billable_Project_Reference
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

		[XmlElement(Order = 24)]
		public Project_Plan_PhaseObjectType Project_Plan_Phase_Reference
		{
			get
			{
				return this.project_Plan_Phase_ReferenceField;
			}
			set
			{
				this.project_Plan_Phase_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Phase_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Project_Plan_TaskObjectType Project_Plan_Task_Reference
		{
			get
			{
				return this.project_Plan_Task_ReferenceField;
			}
			set
			{
				this.project_Plan_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Task_Reference");
			}
		}

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
		public decimal Analytical_Amount
		{
			get
			{
				return this.analytical_AmountField;
			}
			set
			{
				this.analytical_AmountField = value;
				this.RaisePropertyChanged("Analytical_Amount");
			}
		}

		[XmlIgnore]
		public bool Analytical_AmountSpecified
		{
			get
			{
				return this.analytical_AmountFieldSpecified;
			}
			set
			{
				this.analytical_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Analytical_AmountSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 30)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
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

		[XmlElement(Order = 31)]
		public decimal Calculated_Tax_Amount
		{
			get
			{
				return this.calculated_Tax_AmountField;
			}
			set
			{
				this.calculated_Tax_AmountField = value;
				this.RaisePropertyChanged("Calculated_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Calculated_Tax_AmountSpecified
		{
			get
			{
				return this.calculated_Tax_AmountFieldSpecified;
			}
			set
			{
				this.calculated_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Calculated_Tax_AmountSpecified");
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
