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
	public class Customer_Contract_DataType : INotifyPropertyChanged
	{
		private string customer_Contract_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private bool multiple_Element_Revenue_AllocationField;

		private bool multiple_Element_Revenue_AllocationFieldSpecified;

		private bool no_Allocation_ThresholdField;

		private bool no_Allocation_ThresholdFieldSpecified;

		private decimal lower_Range_PercentageField;

		private bool lower_Range_PercentageFieldSpecified;

		private decimal upper_Range_PercentageField;

		private bool upper_Range_PercentageFieldSpecified;

		private Sales_Item_Fair_Value_Price_ListObjectType sales_Item_Fair_Value_Price_List_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Billable_EntityObjectType sold_To_Customer_ReferenceField;

		private CustomerObjectType ship_To_Customer_ReferenceField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private Address_Information_DataType[] ship_To_Address_DataField;

		private Customer_Contract_TypeObjectType customer_Contract_Type_ReferenceField;

		private string contract_NameField;

		private decimal versionField;

		private bool versionFieldSpecified;

		private string customer_Contract_NumberField;

		private string contract_DescriptionField;

		private Billable_EntityObjectType bill_To_Customer_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Customer_ContractObjectType related_Customer_Contract_ReferenceField;

		private Customer_Contract_AbstractObjectType[] linked_Customer_Contracts_ReferenceField;

		private Customer_ContractObjectType master_Customer_Contract_ReferenceField;

		private Customer_ContractObjectType original_Customer_Contract_ReferenceField;

		private Customer_Contract_AlternateObjectType alternate_Customer_Contract_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private DateTime customer_Contract_Effective_DateField;

		private bool customer_Contract_Effective_DateFieldSpecified;

		private DateTime contract_Signed_DateField;

		private bool contract_Signed_DateFieldSpecified;

		private string pO_NumberField;

		private WorkerObjectType salesperson_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] default_Worktags_ReferenceField;

		private decimal current_Contract_AmountField;

		private bool current_Contract_AmountFieldSpecified;

		private string contract_NotesField;

		private string billing_NotesField;

		private Billing_Schedule_TemplateObjectType transaction_Billing_Schedule_Template_ReferenceField;

		private Billing_Schedule_TemplateObjectType installment_Billing_Schedule_Template_ReferenceField;

		private DateTime billing_Schedule_From_DateField;

		private bool billing_Schedule_From_DateFieldSpecified;

		private DateTime billing_Schedule_To_DateField;

		private bool billing_Schedule_To_DateFieldSpecified;

		private Customer_Contract_Line_DataType[] customer_Contract_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Contract_ID
		{
			get
			{
				return this.customer_Contract_IDField;
			}
			set
			{
				this.customer_Contract_IDField = value;
				this.RaisePropertyChanged("Customer_Contract_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Multiple_Element_Revenue_Allocation
		{
			get
			{
				return this.multiple_Element_Revenue_AllocationField;
			}
			set
			{
				this.multiple_Element_Revenue_AllocationField = value;
				this.RaisePropertyChanged("Multiple_Element_Revenue_Allocation");
			}
		}

		[XmlIgnore]
		public bool Multiple_Element_Revenue_AllocationSpecified
		{
			get
			{
				return this.multiple_Element_Revenue_AllocationFieldSpecified;
			}
			set
			{
				this.multiple_Element_Revenue_AllocationFieldSpecified = value;
				this.RaisePropertyChanged("Multiple_Element_Revenue_AllocationSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool No_Allocation_Threshold
		{
			get
			{
				return this.no_Allocation_ThresholdField;
			}
			set
			{
				this.no_Allocation_ThresholdField = value;
				this.RaisePropertyChanged("No_Allocation_Threshold");
			}
		}

		[XmlIgnore]
		public bool No_Allocation_ThresholdSpecified
		{
			get
			{
				return this.no_Allocation_ThresholdFieldSpecified;
			}
			set
			{
				this.no_Allocation_ThresholdFieldSpecified = value;
				this.RaisePropertyChanged("No_Allocation_ThresholdSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Lower_Range_Percentage
		{
			get
			{
				return this.lower_Range_PercentageField;
			}
			set
			{
				this.lower_Range_PercentageField = value;
				this.RaisePropertyChanged("Lower_Range_Percentage");
			}
		}

		[XmlIgnore]
		public bool Lower_Range_PercentageSpecified
		{
			get
			{
				return this.lower_Range_PercentageFieldSpecified;
			}
			set
			{
				this.lower_Range_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Lower_Range_PercentageSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Upper_Range_Percentage
		{
			get
			{
				return this.upper_Range_PercentageField;
			}
			set
			{
				this.upper_Range_PercentageField = value;
				this.RaisePropertyChanged("Upper_Range_Percentage");
			}
		}

		[XmlIgnore]
		public bool Upper_Range_PercentageSpecified
		{
			get
			{
				return this.upper_Range_PercentageFieldSpecified;
			}
			set
			{
				this.upper_Range_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Upper_Range_PercentageSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Sales_Item_Fair_Value_Price_ListObjectType Sales_Item_Fair_Value_Price_List_Reference
		{
			get
			{
				return this.sales_Item_Fair_Value_Price_List_ReferenceField;
			}
			set
			{
				this.sales_Item_Fair_Value_Price_List_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Fair_Value_Price_List_Reference");
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
		public Billable_EntityObjectType Sold_To_Customer_Reference
		{
			get
			{
				return this.sold_To_Customer_ReferenceField;
			}
			set
			{
				this.sold_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Sold_To_Customer_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement("Ship_To_Address_Data", Order = 13)]
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

		[XmlElement(Order = 14)]
		public Customer_Contract_TypeObjectType Customer_Contract_Type_Reference
		{
			get
			{
				return this.customer_Contract_Type_ReferenceField;
			}
			set
			{
				this.customer_Contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Type_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public string Contract_Name
		{
			get
			{
				return this.contract_NameField;
			}
			set
			{
				this.contract_NameField = value;
				this.RaisePropertyChanged("Contract_Name");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("Version");
			}
		}

		[XmlIgnore]
		public bool VersionSpecified
		{
			get
			{
				return this.versionFieldSpecified;
			}
			set
			{
				this.versionFieldSpecified = value;
				this.RaisePropertyChanged("VersionSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public string Customer_Contract_Number
		{
			get
			{
				return this.customer_Contract_NumberField;
			}
			set
			{
				this.customer_Contract_NumberField = value;
				this.RaisePropertyChanged("Customer_Contract_Number");
			}
		}

		[XmlElement(Order = 18)]
		public string Contract_Description
		{
			get
			{
				return this.contract_DescriptionField;
			}
			set
			{
				this.contract_DescriptionField = value;
				this.RaisePropertyChanged("Contract_Description");
			}
		}

		[XmlElement(Order = 19)]
		public Billable_EntityObjectType Bill_To_Customer_Reference
		{
			get
			{
				return this.bill_To_Customer_ReferenceField;
			}
			set
			{
				this.bill_To_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Customer_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Tax_CodeObjectType Default_Tax_Code_Reference
		{
			get
			{
				return this.default_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Customer_ContractObjectType Related_Customer_Contract_Reference
		{
			get
			{
				return this.related_Customer_Contract_ReferenceField;
			}
			set
			{
				this.related_Customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Related_Customer_Contract_Reference");
			}
		}

		[XmlElement("Linked_Customer_Contracts_Reference", Order = 24)]
		public Customer_Contract_AbstractObjectType[] Linked_Customer_Contracts_Reference
		{
			get
			{
				return this.linked_Customer_Contracts_ReferenceField;
			}
			set
			{
				this.linked_Customer_Contracts_ReferenceField = value;
				this.RaisePropertyChanged("Linked_Customer_Contracts_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Customer_ContractObjectType Master_Customer_Contract_Reference
		{
			get
			{
				return this.master_Customer_Contract_ReferenceField;
			}
			set
			{
				this.master_Customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Master_Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Customer_ContractObjectType Original_Customer_Contract_Reference
		{
			get
			{
				return this.original_Customer_Contract_ReferenceField;
			}
			set
			{
				this.original_Customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Original_Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public Customer_Contract_AlternateObjectType Alternate_Customer_Contract_Reference
		{
			get
			{
				return this.alternate_Customer_Contract_ReferenceField;
			}
			set
			{
				this.alternate_Customer_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Customer_Contract_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 29)]
		public DateTime Customer_Contract_Effective_Date
		{
			get
			{
				return this.customer_Contract_Effective_DateField;
			}
			set
			{
				this.customer_Contract_Effective_DateField = value;
				this.RaisePropertyChanged("Customer_Contract_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Customer_Contract_Effective_DateSpecified
		{
			get
			{
				return this.customer_Contract_Effective_DateFieldSpecified;
			}
			set
			{
				this.customer_Contract_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Customer_Contract_Effective_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 30)]
		public DateTime Contract_Signed_Date
		{
			get
			{
				return this.contract_Signed_DateField;
			}
			set
			{
				this.contract_Signed_DateField = value;
				this.RaisePropertyChanged("Contract_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Signed_DateSpecified
		{
			get
			{
				return this.contract_Signed_DateFieldSpecified;
			}
			set
			{
				this.contract_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Signed_DateSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public string PO_Number
		{
			get
			{
				return this.pO_NumberField;
			}
			set
			{
				this.pO_NumberField = value;
				this.RaisePropertyChanged("PO_Number");
			}
		}

		[XmlElement(Order = 32)]
		public WorkerObjectType Salesperson_Reference
		{
			get
			{
				return this.salesperson_ReferenceField;
			}
			set
			{
				this.salesperson_ReferenceField = value;
				this.RaisePropertyChanged("Salesperson_Reference");
			}
		}

		[XmlElement("Default_Worktags_Reference", Order = 33)]
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

		[XmlElement(Order = 34)]
		public decimal Current_Contract_Amount
		{
			get
			{
				return this.current_Contract_AmountField;
			}
			set
			{
				this.current_Contract_AmountField = value;
				this.RaisePropertyChanged("Current_Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Current_Contract_AmountSpecified
		{
			get
			{
				return this.current_Contract_AmountFieldSpecified;
			}
			set
			{
				this.current_Contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Current_Contract_AmountSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public string Contract_Notes
		{
			get
			{
				return this.contract_NotesField;
			}
			set
			{
				this.contract_NotesField = value;
				this.RaisePropertyChanged("Contract_Notes");
			}
		}

		[XmlElement(Order = 36)]
		public string Billing_Notes
		{
			get
			{
				return this.billing_NotesField;
			}
			set
			{
				this.billing_NotesField = value;
				this.RaisePropertyChanged("Billing_Notes");
			}
		}

		[XmlElement(Order = 37)]
		public Billing_Schedule_TemplateObjectType Transaction_Billing_Schedule_Template_Reference
		{
			get
			{
				return this.transaction_Billing_Schedule_Template_ReferenceField;
			}
			set
			{
				this.transaction_Billing_Schedule_Template_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Billing_Schedule_Template_Reference");
			}
		}

		[XmlElement(Order = 38)]
		public Billing_Schedule_TemplateObjectType Installment_Billing_Schedule_Template_Reference
		{
			get
			{
				return this.installment_Billing_Schedule_Template_ReferenceField;
			}
			set
			{
				this.installment_Billing_Schedule_Template_ReferenceField = value;
				this.RaisePropertyChanged("Installment_Billing_Schedule_Template_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 39)]
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

		[XmlElement(DataType = "date", Order = 40)]
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

		[XmlElement("Customer_Contract_Line_Replacement_Data", Order = 41)]
		public Customer_Contract_Line_DataType[] Customer_Contract_Line_Replacement_Data
		{
			get
			{
				return this.customer_Contract_Line_Replacement_DataField;
			}
			set
			{
				this.customer_Contract_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Customer_Contract_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 42)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
