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
	public class Award_Contract_Amendment_Line_DataType : INotifyPropertyChanged
	{
		private Receivable_Contract_Line_AbstractObjectType receivable_Contract_Line_ReferenceField;

		private string receivable_Contract_Line_Reference_IDField;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Accounting_CategoryObjectType revenue_Category_ReferenceField;

		private Award_Lifecycle_StatusObjectType award_Lifecycle_Status_ReferenceField;

		private Spend_RestrictionObjectType[] spend_Restriction_ReferenceField;

		private Contract_Line_TypeObjectType line_Type_ReferenceField;

		private string line_Item_DescriptionField;

		private bool deferred_RevenueField;

		private bool deferred_RevenueFieldSpecified;

		private Document_StatusObjectType line_Status_ReferenceField;

		private bool primary_GrantField;

		private bool primary_GrantFieldSpecified;

		private GrantObjectType grant_ReferenceField;

		private decimal line_AmountField;

		private bool line_AmountFieldSpecified;

		private Facilities_and_Admin_Rate_AgreementObjectType rate_Agreement_ReferenceField;

		private Facilities_and_Admin_Cost_Rate_TypeObjectType cost_Rate_Type_ReferenceField;

		private Facilities_and_Admin_ExceptionObjectType exception_ReferenceField;

		private Facilities_and_Admin_Revenue_Allocation_ProfileObjectType revenue_Allocation_Profile_ReferenceField;

		private Basis_Limit_Edit_DataType basis_Limit_DataField;

		private DateTime award_Amendment_Line_Start_DateField;

		private bool award_Amendment_Line_Start_DateFieldSpecified;

		private DateTime award_Amendment_End_DateField;

		private bool award_Amendment_End_DateFieldSpecified;

		private string award_Amendment_Line_DescriptionField;

		private string line_Invoice_Memo_OverrideField;

		private Audited_Accounting_WorktagObjectType[] default_Worktags_ReferenceField;

		private Payroll_LimitObjectType award_Line_Salary_Cap_ReferenceField;

		private Payroll_Limit_SnapshotObjectType award_Line_Salary_Cap_Override_ReferenceField;

		private SupplierObjectType subrecipient_ReferenceField;

		private string federal_Award_ID_NumberField;

		private string line_Billing_NotesField;

		private string revenue_Recognition_Line_NotesField;

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

		[XmlElement(Order = 5)]
		public Award_Lifecycle_StatusObjectType Award_Lifecycle_Status_Reference
		{
			get
			{
				return this.award_Lifecycle_Status_ReferenceField;
			}
			set
			{
				this.award_Lifecycle_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Reference");
			}
		}

		[XmlElement("Spend_Restriction_Reference", Order = 6)]
		public Spend_RestrictionObjectType[] Spend_Restriction_Reference
		{
			get
			{
				return this.spend_Restriction_ReferenceField;
			}
			set
			{
				this.spend_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Restriction_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Contract_Line_TypeObjectType Line_Type_Reference
		{
			get
			{
				return this.line_Type_ReferenceField;
			}
			set
			{
				this.line_Type_ReferenceField = value;
				this.RaisePropertyChanged("Line_Type_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Document_StatusObjectType Line_Status_Reference
		{
			get
			{
				return this.line_Status_ReferenceField;
			}
			set
			{
				this.line_Status_ReferenceField = value;
				this.RaisePropertyChanged("Line_Status_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool Primary_Grant
		{
			get
			{
				return this.primary_GrantField;
			}
			set
			{
				this.primary_GrantField = value;
				this.RaisePropertyChanged("Primary_Grant");
			}
		}

		[XmlIgnore]
		public bool Primary_GrantSpecified
		{
			get
			{
				return this.primary_GrantFieldSpecified;
			}
			set
			{
				this.primary_GrantFieldSpecified = value;
				this.RaisePropertyChanged("Primary_GrantSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public GrantObjectType Grant_Reference
		{
			get
			{
				return this.grant_ReferenceField;
			}
			set
			{
				this.grant_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Line_Amount
		{
			get
			{
				return this.line_AmountField;
			}
			set
			{
				this.line_AmountField = value;
				this.RaisePropertyChanged("Line_Amount");
			}
		}

		[XmlIgnore]
		public bool Line_AmountSpecified
		{
			get
			{
				return this.line_AmountFieldSpecified;
			}
			set
			{
				this.line_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Line_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public Facilities_and_Admin_Rate_AgreementObjectType Rate_Agreement_Reference
		{
			get
			{
				return this.rate_Agreement_ReferenceField;
			}
			set
			{
				this.rate_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Rate_Agreement_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Facilities_and_Admin_Cost_Rate_TypeObjectType Cost_Rate_Type_Reference
		{
			get
			{
				return this.cost_Rate_Type_ReferenceField;
			}
			set
			{
				this.cost_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Facilities_and_Admin_ExceptionObjectType Exception_Reference
		{
			get
			{
				return this.exception_ReferenceField;
			}
			set
			{
				this.exception_ReferenceField = value;
				this.RaisePropertyChanged("Exception_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Facilities_and_Admin_Revenue_Allocation_ProfileObjectType Revenue_Allocation_Profile_Reference
		{
			get
			{
				return this.revenue_Allocation_Profile_ReferenceField;
			}
			set
			{
				this.revenue_Allocation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Revenue_Allocation_Profile_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Basis_Limit_Edit_DataType Basis_Limit_Data
		{
			get
			{
				return this.basis_Limit_DataField;
			}
			set
			{
				this.basis_Limit_DataField = value;
				this.RaisePropertyChanged("Basis_Limit_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 19)]
		public DateTime Award_Amendment_Line_Start_Date
		{
			get
			{
				return this.award_Amendment_Line_Start_DateField;
			}
			set
			{
				this.award_Amendment_Line_Start_DateField = value;
				this.RaisePropertyChanged("Award_Amendment_Line_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Amendment_Line_Start_DateSpecified
		{
			get
			{
				return this.award_Amendment_Line_Start_DateFieldSpecified;
			}
			set
			{
				this.award_Amendment_Line_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Amendment_Line_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Award_Amendment_End_Date
		{
			get
			{
				return this.award_Amendment_End_DateField;
			}
			set
			{
				this.award_Amendment_End_DateField = value;
				this.RaisePropertyChanged("Award_Amendment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Award_Amendment_End_DateSpecified
		{
			get
			{
				return this.award_Amendment_End_DateFieldSpecified;
			}
			set
			{
				this.award_Amendment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Award_Amendment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public string Award_Amendment_Line_Description
		{
			get
			{
				return this.award_Amendment_Line_DescriptionField;
			}
			set
			{
				this.award_Amendment_Line_DescriptionField = value;
				this.RaisePropertyChanged("Award_Amendment_Line_Description");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement("Default_Worktags_Reference", Order = 23)]
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

		[XmlElement(Order = 24)]
		public Payroll_LimitObjectType Award_Line_Salary_Cap_Reference
		{
			get
			{
				return this.award_Line_Salary_Cap_ReferenceField;
			}
			set
			{
				this.award_Line_Salary_Cap_ReferenceField = value;
				this.RaisePropertyChanged("Award_Line_Salary_Cap_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Payroll_Limit_SnapshotObjectType Award_Line_Salary_Cap_Override_Reference
		{
			get
			{
				return this.award_Line_Salary_Cap_Override_ReferenceField;
			}
			set
			{
				this.award_Line_Salary_Cap_Override_ReferenceField = value;
				this.RaisePropertyChanged("Award_Line_Salary_Cap_Override_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public SupplierObjectType Subrecipient_Reference
		{
			get
			{
				return this.subrecipient_ReferenceField;
			}
			set
			{
				this.subrecipient_ReferenceField = value;
				this.RaisePropertyChanged("Subrecipient_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string Federal_Award_ID_Number
		{
			get
			{
				return this.federal_Award_ID_NumberField;
			}
			set
			{
				this.federal_Award_ID_NumberField = value;
				this.RaisePropertyChanged("Federal_Award_ID_Number");
			}
		}

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
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
