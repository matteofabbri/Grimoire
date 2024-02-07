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
	public class Effort_Certification_Type_DataType : INotifyPropertyChanged
	{
		private string effort_Certification_Type_IDField;

		private string effort_Certification_Type_NameField;

		private string effort_Certification_Type_DescriptionField;

		private Accounting_Worktag_TypeObjectType[] group_By_ReferenceField;

		private Accounting_Worktag_TypeObjectType subtotal_By_Accounting_Worktag_Type_ReferenceField;

		private Accounting_Worktag_Aggregation_DimensionObjectType hierarchy_ReferenceField;

		private Effort_Certifying_TextObjectType effort_Certifying_Text_ReferenceField;

		private bool display_Compensation_AmountsField;

		private bool display_Compensation_AmountsFieldSpecified;

		private bool use_Full_WorktagsField;

		private bool use_Full_WorktagsFieldSpecified;

		private Effort_Certification_SurveyObjectType survey_ReferenceField;

		private Effort_Certification_Eligibility_RuleObjectType employee_Eligibility_Rule_ReferenceField;

		private Pay_Component_Group__All_ObjectType pay_Component_Group_ReferenceField;

		private Payroll_Costed_Actuals_Filter_DataType[] payroll_Actuals_Costed_To_SelectionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Effort_Certification_Type_ID
		{
			get
			{
				return this.effort_Certification_Type_IDField;
			}
			set
			{
				this.effort_Certification_Type_IDField = value;
				this.RaisePropertyChanged("Effort_Certification_Type_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Effort_Certification_Type_Name
		{
			get
			{
				return this.effort_Certification_Type_NameField;
			}
			set
			{
				this.effort_Certification_Type_NameField = value;
				this.RaisePropertyChanged("Effort_Certification_Type_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Effort_Certification_Type_Description
		{
			get
			{
				return this.effort_Certification_Type_DescriptionField;
			}
			set
			{
				this.effort_Certification_Type_DescriptionField = value;
				this.RaisePropertyChanged("Effort_Certification_Type_Description");
			}
		}

		[XmlElement("Group_By_Reference", Order = 3)]
		public Accounting_Worktag_TypeObjectType[] Group_By_Reference
		{
			get
			{
				return this.group_By_ReferenceField;
			}
			set
			{
				this.group_By_ReferenceField = value;
				this.RaisePropertyChanged("Group_By_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Accounting_Worktag_TypeObjectType Subtotal_By_Accounting_Worktag_Type_Reference
		{
			get
			{
				return this.subtotal_By_Accounting_Worktag_Type_ReferenceField;
			}
			set
			{
				this.subtotal_By_Accounting_Worktag_Type_ReferenceField = value;
				this.RaisePropertyChanged("Subtotal_By_Accounting_Worktag_Type_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Accounting_Worktag_Aggregation_DimensionObjectType Hierarchy_Reference
		{
			get
			{
				return this.hierarchy_ReferenceField;
			}
			set
			{
				this.hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Effort_Certifying_TextObjectType Effort_Certifying_Text_Reference
		{
			get
			{
				return this.effort_Certifying_Text_ReferenceField;
			}
			set
			{
				this.effort_Certifying_Text_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certifying_Text_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public bool Display_Compensation_Amounts
		{
			get
			{
				return this.display_Compensation_AmountsField;
			}
			set
			{
				this.display_Compensation_AmountsField = value;
				this.RaisePropertyChanged("Display_Compensation_Amounts");
			}
		}

		[XmlIgnore]
		public bool Display_Compensation_AmountsSpecified
		{
			get
			{
				return this.display_Compensation_AmountsFieldSpecified;
			}
			set
			{
				this.display_Compensation_AmountsFieldSpecified = value;
				this.RaisePropertyChanged("Display_Compensation_AmountsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Use_Full_Worktags
		{
			get
			{
				return this.use_Full_WorktagsField;
			}
			set
			{
				this.use_Full_WorktagsField = value;
				this.RaisePropertyChanged("Use_Full_Worktags");
			}
		}

		[XmlIgnore]
		public bool Use_Full_WorktagsSpecified
		{
			get
			{
				return this.use_Full_WorktagsFieldSpecified;
			}
			set
			{
				this.use_Full_WorktagsFieldSpecified = value;
				this.RaisePropertyChanged("Use_Full_WorktagsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Effort_Certification_SurveyObjectType Survey_Reference
		{
			get
			{
				return this.survey_ReferenceField;
			}
			set
			{
				this.survey_ReferenceField = value;
				this.RaisePropertyChanged("Survey_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Effort_Certification_Eligibility_RuleObjectType Employee_Eligibility_Rule_Reference
		{
			get
			{
				return this.employee_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.employee_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Pay_Component_Group__All_ObjectType Pay_Component_Group_Reference
		{
			get
			{
				return this.pay_Component_Group_ReferenceField;
			}
			set
			{
				this.pay_Component_Group_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Component_Group_Reference");
			}
		}

		[XmlElement("Payroll_Actuals_Costed_To_Selection", Order = 12)]
		public Payroll_Costed_Actuals_Filter_DataType[] Payroll_Actuals_Costed_To_Selection
		{
			get
			{
				return this.payroll_Actuals_Costed_To_SelectionField;
			}
			set
			{
				this.payroll_Actuals_Costed_To_SelectionField = value;
				this.RaisePropertyChanged("Payroll_Actuals_Costed_To_Selection");
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
