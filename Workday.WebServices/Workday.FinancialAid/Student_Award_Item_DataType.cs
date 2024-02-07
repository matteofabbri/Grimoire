using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Award_Item_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime effective_DateField;

		private Has_Academic_Curricular_Division_DataType[] has_Academic_Curricular_Division_DataField;

		private string nameField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private CountryObjectType country_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Student_Award_TypeObjectType type_ReferenceField;

		private Loan_FeeObjectType[] loan_Fee_ReferenceField;

		private Loan_Fee_Deduction_MethodObjectType loan_Fee_Deduction_Method_ReferenceField;

		private Student_Award_SourceObjectType source_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Related_Worktags_by_Worktag_Type_DataType[] student_Award_Item_Related_WorktagsField;

		private Student_Award_Need_MethodObjectType need_Method_ReferenceField;

		private Student_Award_Federal_Program_IDObjectType federal_Program_ID_ReferenceField;

		private Student_Award_IPEDS_MappingObjectType iPEDS_Mapping_ReferenceField;

		private Student_Award_StatusObjectType student_Award_Status_ReferenceField;

		private Student_Allowable_ActionObjectType[] student_Allowable_Action_ReferenceField;

		private bool display_AwardField;

		private bool display_AwardFieldSpecified;

		private bool do_Not_RecalculateField;

		private bool do_Not_RecalculateFieldSpecified;

		private bool lockField;

		private bool lockFieldSpecified;

		private bool manual_OverrideField;

		private bool manual_OverrideFieldSpecified;

		private Student_Hold__All_ObjectType[] student_Holds_ReferenceField;

		private CalculationObjectType award_Eligibility_Calculation_ReferenceField;

		private CalculationObjectType amount_Calculation_ReferenceField;

		private Frequency_of_Award_AmountObjectType frequency_of_Award_Amount_ReferenceField;

		private Student_Award_Item_Limit_DataType[] student_Award_Item_Limit_Data_ReferenceField;

		private Fiscal_LimitObjectType[] fiscal_Limit_ReferenceField;

		private bool disbursableField;

		private bool disbursableFieldSpecified;

		private CalculationObjectType disbursement_Eligibility_Calculation_ReferenceField;

		private Student_Disbursement_ScheduleObjectType student_Reusable_Schedule_Definition_ReferenceField;

		private bool anticipated_AidField;

		private bool anticipated_AidFieldSpecified;

		private Anticipated_Payment_Display_RuleObjectType anticipated_Payment_Display_Rule_ReferenceField;

		private Student_Precedence_GroupObjectType student_Precedence_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlElement("Has_Academic_Curricular_Division_Data", Order = 2)]
		public Has_Academic_Curricular_Division_DataType[] Has_Academic_Curricular_Division_Data
		{
			get
			{
				return this.has_Academic_Curricular_Division_DataField;
			}
			set
			{
				this.has_Academic_Curricular_Division_DataField = value;
				this.RaisePropertyChanged("Has_Academic_Curricular_Division_Data");
			}
		}

		[XmlElement(Order = 3)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Student_Award_TypeObjectType Type_Reference
		{
			get
			{
				return this.type_ReferenceField;
			}
			set
			{
				this.type_ReferenceField = value;
				this.RaisePropertyChanged("Type_Reference");
			}
		}

		[XmlElement("Loan_Fee_Reference", Order = 8)]
		public Loan_FeeObjectType[] Loan_Fee_Reference
		{
			get
			{
				return this.loan_Fee_ReferenceField;
			}
			set
			{
				this.loan_Fee_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Fee_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Loan_Fee_Deduction_MethodObjectType Loan_Fee_Deduction_Method_Reference
		{
			get
			{
				return this.loan_Fee_Deduction_Method_ReferenceField;
			}
			set
			{
				this.loan_Fee_Deduction_Method_ReferenceField = value;
				this.RaisePropertyChanged("Loan_Fee_Deduction_Method_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Student_Award_SourceObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlArray(Order = 12), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Student_Award_Item_Related_Worktags
		{
			get
			{
				return this.student_Award_Item_Related_WorktagsField;
			}
			set
			{
				this.student_Award_Item_Related_WorktagsField = value;
				this.RaisePropertyChanged("Student_Award_Item_Related_Worktags");
			}
		}

		[XmlElement(Order = 13)]
		public Student_Award_Need_MethodObjectType Need_Method_Reference
		{
			get
			{
				return this.need_Method_ReferenceField;
			}
			set
			{
				this.need_Method_ReferenceField = value;
				this.RaisePropertyChanged("Need_Method_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Student_Award_Federal_Program_IDObjectType Federal_Program_ID_Reference
		{
			get
			{
				return this.federal_Program_ID_ReferenceField;
			}
			set
			{
				this.federal_Program_ID_ReferenceField = value;
				this.RaisePropertyChanged("Federal_Program_ID_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Student_Award_IPEDS_MappingObjectType IPEDS_Mapping_Reference
		{
			get
			{
				return this.iPEDS_Mapping_ReferenceField;
			}
			set
			{
				this.iPEDS_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("IPEDS_Mapping_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Student_Award_StatusObjectType Student_Award_Status_Reference
		{
			get
			{
				return this.student_Award_Status_ReferenceField;
			}
			set
			{
				this.student_Award_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Status_Reference");
			}
		}

		[XmlElement("Student_Allowable_Action_Reference", Order = 17)]
		public Student_Allowable_ActionObjectType[] Student_Allowable_Action_Reference
		{
			get
			{
				return this.student_Allowable_Action_ReferenceField;
			}
			set
			{
				this.student_Allowable_Action_ReferenceField = value;
				this.RaisePropertyChanged("Student_Allowable_Action_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public bool Display_Award
		{
			get
			{
				return this.display_AwardField;
			}
			set
			{
				this.display_AwardField = value;
				this.RaisePropertyChanged("Display_Award");
			}
		}

		[XmlIgnore]
		public bool Display_AwardSpecified
		{
			get
			{
				return this.display_AwardFieldSpecified;
			}
			set
			{
				this.display_AwardFieldSpecified = value;
				this.RaisePropertyChanged("Display_AwardSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Do_Not_Recalculate
		{
			get
			{
				return this.do_Not_RecalculateField;
			}
			set
			{
				this.do_Not_RecalculateField = value;
				this.RaisePropertyChanged("Do_Not_Recalculate");
			}
		}

		[XmlIgnore]
		public bool Do_Not_RecalculateSpecified
		{
			get
			{
				return this.do_Not_RecalculateFieldSpecified;
			}
			set
			{
				this.do_Not_RecalculateFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_RecalculateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Lock
		{
			get
			{
				return this.lockField;
			}
			set
			{
				this.lockField = value;
				this.RaisePropertyChanged("Lock");
			}
		}

		[XmlIgnore]
		public bool LockSpecified
		{
			get
			{
				return this.lockFieldSpecified;
			}
			set
			{
				this.lockFieldSpecified = value;
				this.RaisePropertyChanged("LockSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Manual_Override
		{
			get
			{
				return this.manual_OverrideField;
			}
			set
			{
				this.manual_OverrideField = value;
				this.RaisePropertyChanged("Manual_Override");
			}
		}

		[XmlIgnore]
		public bool Manual_OverrideSpecified
		{
			get
			{
				return this.manual_OverrideFieldSpecified;
			}
			set
			{
				this.manual_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Manual_OverrideSpecified");
			}
		}

		[XmlElement("Student_Holds_Reference", Order = 22)]
		public Student_Hold__All_ObjectType[] Student_Holds_Reference
		{
			get
			{
				return this.student_Holds_ReferenceField;
			}
			set
			{
				this.student_Holds_ReferenceField = value;
				this.RaisePropertyChanged("Student_Holds_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public CalculationObjectType Award_Eligibility_Calculation_Reference
		{
			get
			{
				return this.award_Eligibility_Calculation_ReferenceField;
			}
			set
			{
				this.award_Eligibility_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Award_Eligibility_Calculation_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public CalculationObjectType Amount_Calculation_Reference
		{
			get
			{
				return this.amount_Calculation_ReferenceField;
			}
			set
			{
				this.amount_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Amount_Calculation_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Frequency_of_Award_AmountObjectType Frequency_of_Award_Amount_Reference
		{
			get
			{
				return this.frequency_of_Award_Amount_ReferenceField;
			}
			set
			{
				this.frequency_of_Award_Amount_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_of_Award_Amount_Reference");
			}
		}

		[XmlElement("Student_Award_Item_Limit_Data_Reference", Order = 26)]
		public Student_Award_Item_Limit_DataType[] Student_Award_Item_Limit_Data_Reference
		{
			get
			{
				return this.student_Award_Item_Limit_Data_ReferenceField;
			}
			set
			{
				this.student_Award_Item_Limit_Data_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Item_Limit_Data_Reference");
			}
		}

		[XmlElement("Fiscal_Limit_Reference", Order = 27)]
		public Fiscal_LimitObjectType[] Fiscal_Limit_Reference
		{
			get
			{
				return this.fiscal_Limit_ReferenceField;
			}
			set
			{
				this.fiscal_Limit_ReferenceField = value;
				this.RaisePropertyChanged("Fiscal_Limit_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public bool Disbursable
		{
			get
			{
				return this.disbursableField;
			}
			set
			{
				this.disbursableField = value;
				this.RaisePropertyChanged("Disbursable");
			}
		}

		[XmlIgnore]
		public bool DisbursableSpecified
		{
			get
			{
				return this.disbursableFieldSpecified;
			}
			set
			{
				this.disbursableFieldSpecified = value;
				this.RaisePropertyChanged("DisbursableSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public CalculationObjectType Disbursement_Eligibility_Calculation_Reference
		{
			get
			{
				return this.disbursement_Eligibility_Calculation_ReferenceField;
			}
			set
			{
				this.disbursement_Eligibility_Calculation_ReferenceField = value;
				this.RaisePropertyChanged("Disbursement_Eligibility_Calculation_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Student_Disbursement_ScheduleObjectType Student_Reusable_Schedule_Definition_Reference
		{
			get
			{
				return this.student_Reusable_Schedule_Definition_ReferenceField;
			}
			set
			{
				this.student_Reusable_Schedule_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reusable_Schedule_Definition_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public bool Anticipated_Aid
		{
			get
			{
				return this.anticipated_AidField;
			}
			set
			{
				this.anticipated_AidField = value;
				this.RaisePropertyChanged("Anticipated_Aid");
			}
		}

		[XmlIgnore]
		public bool Anticipated_AidSpecified
		{
			get
			{
				return this.anticipated_AidFieldSpecified;
			}
			set
			{
				this.anticipated_AidFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_AidSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public Anticipated_Payment_Display_RuleObjectType Anticipated_Payment_Display_Rule_Reference
		{
			get
			{
				return this.anticipated_Payment_Display_Rule_ReferenceField;
			}
			set
			{
				this.anticipated_Payment_Display_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Anticipated_Payment_Display_Rule_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public Student_Precedence_GroupObjectType Student_Precedence_Group_Reference
		{
			get
			{
				return this.student_Precedence_Group_ReferenceField;
			}
			set
			{
				this.student_Precedence_Group_ReferenceField = value;
				this.RaisePropertyChanged("Student_Precedence_Group_Reference");
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
