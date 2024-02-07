using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Payee_PT1_DataType : INotifyPropertyChanged
	{
		private Payroll_Payee_PT1ObjectType payroll_Payee_PT1_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private Payroll_State_AuthorityObjectType payroll_State_Authority_ReferenceField;

		private decimal basic_Personal_AmountField;

		private bool basic_Personal_AmountFieldSpecified;

		private decimal child_AmountField;

		private bool child_AmountFieldSpecified;

		private decimal age_AmountField;

		private bool age_AmountFieldSpecified;

		private decimal senior_Supplementary_Amount_for_WithholdingField;

		private bool senior_Supplementary_Amount_for_WithholdingFieldSpecified;

		private decimal amount_for_Workers_65_or_OlderField;

		private bool amount_for_Workers_65_or_OlderFieldSpecified;

		private decimal pension_Income_AmountField;

		private bool pension_Income_AmountFieldSpecified;

		private decimal tuition__Education_and_Textbook_AmountsField;

		private bool tuition__Education_and_Textbook_AmountsFieldSpecified;

		private decimal disability_AmountField;

		private bool disability_AmountFieldSpecified;

		private decimal spouse_or_Commonlaw_Partner_AmountField;

		private bool spouse_or_Commonlaw_Partner_AmountFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private decimal deduction_for_Living_in_a_Prescribed_ZoneField;

		private bool deduction_for_Living_in_a_Prescribed_ZoneFieldSpecified;

		private decimal amount_for_an_Eligible_DependantField;

		private bool amount_for_an_Eligible_DependantFieldSpecified;

		private decimal caregiver_AmountField;

		private bool caregiver_AmountFieldSpecified;

		private decimal amount_for_Infirm_Dependants_Age_18_or_OlderField;

		private bool amount_for_Infirm_Dependants_Age_18_or_OlderFieldSpecified;

		private decimal amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerField;

		private bool amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerFieldSpecified;

		private decimal amounts_Transferred_from_a_DependantField;

		private bool amounts_Transferred_from_a_DependantFieldSpecified;

		private decimal manitoba_Family_Tax_Benefit_AmountField;

		private bool manitoba_Family_Tax_Benefit_AmountFieldSpecified;

		private bool total_Income_less_than_Total_Claim_AmountField;

		private bool total_Income_less_than_Total_Claim_AmountFieldSpecified;

		private bool more_than_One_Employer_ReferenceField;

		private bool more_than_One_Employer_ReferenceFieldSpecified;

		private decimal dependents_Under_Age_19Field;

		private bool dependents_Under_Age_19FieldSpecified;

		private decimal disabled_DependentsField;

		private bool disabled_DependentsFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private bool exempt_from_Health_ContributionField;

		private bool exempt_from_Health_ContributionFieldSpecified;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_PT1ObjectType Payroll_Payee_PT1_Reference
		{
			get
			{
				return this.payroll_Payee_PT1_ReferenceField;
			}
			set
			{
				this.payroll_Payee_PT1_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_PT1_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Effective_As_Of
		{
			get
			{
				return this.effective_As_OfField;
			}
			set
			{
				this.effective_As_OfField = value;
				this.RaisePropertyChanged("Effective_As_Of");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_State_AuthorityObjectType Payroll_State_Authority_Reference
		{
			get
			{
				return this.payroll_State_Authority_ReferenceField;
			}
			set
			{
				this.payroll_State_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_State_Authority_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Basic_Personal_Amount
		{
			get
			{
				return this.basic_Personal_AmountField;
			}
			set
			{
				this.basic_Personal_AmountField = value;
				this.RaisePropertyChanged("Basic_Personal_Amount");
			}
		}

		[XmlIgnore]
		public bool Basic_Personal_AmountSpecified
		{
			get
			{
				return this.basic_Personal_AmountFieldSpecified;
			}
			set
			{
				this.basic_Personal_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Basic_Personal_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Child_Amount
		{
			get
			{
				return this.child_AmountField;
			}
			set
			{
				this.child_AmountField = value;
				this.RaisePropertyChanged("Child_Amount");
			}
		}

		[XmlIgnore]
		public bool Child_AmountSpecified
		{
			get
			{
				return this.child_AmountFieldSpecified;
			}
			set
			{
				this.child_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Child_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Age_Amount
		{
			get
			{
				return this.age_AmountField;
			}
			set
			{
				this.age_AmountField = value;
				this.RaisePropertyChanged("Age_Amount");
			}
		}

		[XmlIgnore]
		public bool Age_AmountSpecified
		{
			get
			{
				return this.age_AmountFieldSpecified;
			}
			set
			{
				this.age_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Age_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Senior_Supplementary_Amount_for_Withholding
		{
			get
			{
				return this.senior_Supplementary_Amount_for_WithholdingField;
			}
			set
			{
				this.senior_Supplementary_Amount_for_WithholdingField = value;
				this.RaisePropertyChanged("Senior_Supplementary_Amount_for_Withholding");
			}
		}

		[XmlIgnore]
		public bool Senior_Supplementary_Amount_for_WithholdingSpecified
		{
			get
			{
				return this.senior_Supplementary_Amount_for_WithholdingFieldSpecified;
			}
			set
			{
				this.senior_Supplementary_Amount_for_WithholdingFieldSpecified = value;
				this.RaisePropertyChanged("Senior_Supplementary_Amount_for_WithholdingSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Amount_for_Workers_65_or_Older
		{
			get
			{
				return this.amount_for_Workers_65_or_OlderField;
			}
			set
			{
				this.amount_for_Workers_65_or_OlderField = value;
				this.RaisePropertyChanged("Amount_for_Workers_65_or_Older");
			}
		}

		[XmlIgnore]
		public bool Amount_for_Workers_65_or_OlderSpecified
		{
			get
			{
				return this.amount_for_Workers_65_or_OlderFieldSpecified;
			}
			set
			{
				this.amount_for_Workers_65_or_OlderFieldSpecified = value;
				this.RaisePropertyChanged("Amount_for_Workers_65_or_OlderSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Pension_Income_Amount
		{
			get
			{
				return this.pension_Income_AmountField;
			}
			set
			{
				this.pension_Income_AmountField = value;
				this.RaisePropertyChanged("Pension_Income_Amount");
			}
		}

		[XmlIgnore]
		public bool Pension_Income_AmountSpecified
		{
			get
			{
				return this.pension_Income_AmountFieldSpecified;
			}
			set
			{
				this.pension_Income_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pension_Income_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Tuition__Education_and_Textbook_Amounts
		{
			get
			{
				return this.tuition__Education_and_Textbook_AmountsField;
			}
			set
			{
				this.tuition__Education_and_Textbook_AmountsField = value;
				this.RaisePropertyChanged("Tuition__Education_and_Textbook_Amounts");
			}
		}

		[XmlIgnore]
		public bool Tuition__Education_and_Textbook_AmountsSpecified
		{
			get
			{
				return this.tuition__Education_and_Textbook_AmountsFieldSpecified;
			}
			set
			{
				this.tuition__Education_and_Textbook_AmountsFieldSpecified = value;
				this.RaisePropertyChanged("Tuition__Education_and_Textbook_AmountsSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Disability_Amount
		{
			get
			{
				return this.disability_AmountField;
			}
			set
			{
				this.disability_AmountField = value;
				this.RaisePropertyChanged("Disability_Amount");
			}
		}

		[XmlIgnore]
		public bool Disability_AmountSpecified
		{
			get
			{
				return this.disability_AmountFieldSpecified;
			}
			set
			{
				this.disability_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Disability_AmountSpecified");
			}
		}

		[XmlElement("Spouse_or_Common-law_Partner_Amount", Order = 13)]
		public decimal Spouse_or_Commonlaw_Partner_Amount
		{
			get
			{
				return this.spouse_or_Commonlaw_Partner_AmountField;
			}
			set
			{
				this.spouse_or_Commonlaw_Partner_AmountField = value;
				this.RaisePropertyChanged("Spouse_or_Commonlaw_Partner_Amount");
			}
		}

		[XmlIgnore]
		public bool Spouse_or_Commonlaw_Partner_AmountSpecified
		{
			get
			{
				return this.spouse_or_Commonlaw_Partner_AmountFieldSpecified;
			}
			set
			{
				this.spouse_or_Commonlaw_Partner_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Spouse_or_Commonlaw_Partner_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Additional_Amount
		{
			get
			{
				return this.additional_AmountField;
			}
			set
			{
				this.additional_AmountField = value;
				this.RaisePropertyChanged("Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_AmountSpecified
		{
			get
			{
				return this.additional_AmountFieldSpecified;
			}
			set
			{
				this.additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Deduction_for_Living_in_a_Prescribed_Zone
		{
			get
			{
				return this.deduction_for_Living_in_a_Prescribed_ZoneField;
			}
			set
			{
				this.deduction_for_Living_in_a_Prescribed_ZoneField = value;
				this.RaisePropertyChanged("Deduction_for_Living_in_a_Prescribed_Zone");
			}
		}

		[XmlIgnore]
		public bool Deduction_for_Living_in_a_Prescribed_ZoneSpecified
		{
			get
			{
				return this.deduction_for_Living_in_a_Prescribed_ZoneFieldSpecified;
			}
			set
			{
				this.deduction_for_Living_in_a_Prescribed_ZoneFieldSpecified = value;
				this.RaisePropertyChanged("Deduction_for_Living_in_a_Prescribed_ZoneSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Amount_for_an_Eligible_Dependant
		{
			get
			{
				return this.amount_for_an_Eligible_DependantField;
			}
			set
			{
				this.amount_for_an_Eligible_DependantField = value;
				this.RaisePropertyChanged("Amount_for_an_Eligible_Dependant");
			}
		}

		[XmlIgnore]
		public bool Amount_for_an_Eligible_DependantSpecified
		{
			get
			{
				return this.amount_for_an_Eligible_DependantFieldSpecified;
			}
			set
			{
				this.amount_for_an_Eligible_DependantFieldSpecified = value;
				this.RaisePropertyChanged("Amount_for_an_Eligible_DependantSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Caregiver_Amount
		{
			get
			{
				return this.caregiver_AmountField;
			}
			set
			{
				this.caregiver_AmountField = value;
				this.RaisePropertyChanged("Caregiver_Amount");
			}
		}

		[XmlIgnore]
		public bool Caregiver_AmountSpecified
		{
			get
			{
				return this.caregiver_AmountFieldSpecified;
			}
			set
			{
				this.caregiver_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Caregiver_AmountSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Amount_for_Infirm_Dependants_Age_18_or_Older
		{
			get
			{
				return this.amount_for_Infirm_Dependants_Age_18_or_OlderField;
			}
			set
			{
				this.amount_for_Infirm_Dependants_Age_18_or_OlderField = value;
				this.RaisePropertyChanged("Amount_for_Infirm_Dependants_Age_18_or_Older");
			}
		}

		[XmlIgnore]
		public bool Amount_for_Infirm_Dependants_Age_18_or_OlderSpecified
		{
			get
			{
				return this.amount_for_Infirm_Dependants_Age_18_or_OlderFieldSpecified;
			}
			set
			{
				this.amount_for_Infirm_Dependants_Age_18_or_OlderFieldSpecified = value;
				this.RaisePropertyChanged("Amount_for_Infirm_Dependants_Age_18_or_OlderSpecified");
			}
		}

		[XmlElement("Amounts_Transferred_from_your_Spouse_or_Common-law_Partner", Order = 19)]
		public decimal Amounts_Transferred_from_your_Spouse_or_Commonlaw_Partner
		{
			get
			{
				return this.amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerField;
			}
			set
			{
				this.amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerField = value;
				this.RaisePropertyChanged("Amounts_Transferred_from_your_Spouse_or_Commonlaw_Partner");
			}
		}

		[XmlIgnore]
		public bool Amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerSpecified
		{
			get
			{
				return this.amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerFieldSpecified;
			}
			set
			{
				this.amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerFieldSpecified = value;
				this.RaisePropertyChanged("Amounts_Transferred_from_your_Spouse_or_Commonlaw_PartnerSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Amounts_Transferred_from_a_Dependant
		{
			get
			{
				return this.amounts_Transferred_from_a_DependantField;
			}
			set
			{
				this.amounts_Transferred_from_a_DependantField = value;
				this.RaisePropertyChanged("Amounts_Transferred_from_a_Dependant");
			}
		}

		[XmlIgnore]
		public bool Amounts_Transferred_from_a_DependantSpecified
		{
			get
			{
				return this.amounts_Transferred_from_a_DependantFieldSpecified;
			}
			set
			{
				this.amounts_Transferred_from_a_DependantFieldSpecified = value;
				this.RaisePropertyChanged("Amounts_Transferred_from_a_DependantSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Manitoba_Family_Tax_Benefit_Amount
		{
			get
			{
				return this.manitoba_Family_Tax_Benefit_AmountField;
			}
			set
			{
				this.manitoba_Family_Tax_Benefit_AmountField = value;
				this.RaisePropertyChanged("Manitoba_Family_Tax_Benefit_Amount");
			}
		}

		[XmlIgnore]
		public bool Manitoba_Family_Tax_Benefit_AmountSpecified
		{
			get
			{
				return this.manitoba_Family_Tax_Benefit_AmountFieldSpecified;
			}
			set
			{
				this.manitoba_Family_Tax_Benefit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Manitoba_Family_Tax_Benefit_AmountSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Total_Income_less_than_Total_Claim_Amount
		{
			get
			{
				return this.total_Income_less_than_Total_Claim_AmountField;
			}
			set
			{
				this.total_Income_less_than_Total_Claim_AmountField = value;
				this.RaisePropertyChanged("Total_Income_less_than_Total_Claim_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Income_less_than_Total_Claim_AmountSpecified
		{
			get
			{
				return this.total_Income_less_than_Total_Claim_AmountFieldSpecified;
			}
			set
			{
				this.total_Income_less_than_Total_Claim_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Income_less_than_Total_Claim_AmountSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool More_than_One_Employer_Reference
		{
			get
			{
				return this.more_than_One_Employer_ReferenceField;
			}
			set
			{
				this.more_than_One_Employer_ReferenceField = value;
				this.RaisePropertyChanged("More_than_One_Employer_Reference");
			}
		}

		[XmlIgnore]
		public bool More_than_One_Employer_ReferenceSpecified
		{
			get
			{
				return this.more_than_One_Employer_ReferenceFieldSpecified;
			}
			set
			{
				this.more_than_One_Employer_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("More_than_One_Employer_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Dependents_Under_Age_19
		{
			get
			{
				return this.dependents_Under_Age_19Field;
			}
			set
			{
				this.dependents_Under_Age_19Field = value;
				this.RaisePropertyChanged("Dependents_Under_Age_19");
			}
		}

		[XmlIgnore]
		public bool Dependents_Under_Age_19Specified
		{
			get
			{
				return this.dependents_Under_Age_19FieldSpecified;
			}
			set
			{
				this.dependents_Under_Age_19FieldSpecified = value;
				this.RaisePropertyChanged("Dependents_Under_Age_19Specified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Disabled_Dependents
		{
			get
			{
				return this.disabled_DependentsField;
			}
			set
			{
				this.disabled_DependentsField = value;
				this.RaisePropertyChanged("Disabled_Dependents");
			}
		}

		[XmlIgnore]
		public bool Disabled_DependentsSpecified
		{
			get
			{
				return this.disabled_DependentsFieldSpecified;
			}
			set
			{
				this.disabled_DependentsFieldSpecified = value;
				this.RaisePropertyChanged("Disabled_DependentsSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public bool Exempt
		{
			get
			{
				return this.exemptField;
			}
			set
			{
				this.exemptField = value;
				this.RaisePropertyChanged("Exempt");
			}
		}

		[XmlIgnore]
		public bool ExemptSpecified
		{
			get
			{
				return this.exemptFieldSpecified;
			}
			set
			{
				this.exemptFieldSpecified = value;
				this.RaisePropertyChanged("ExemptSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Exempt_from_Health_Contribution
		{
			get
			{
				return this.exempt_from_Health_ContributionField;
			}
			set
			{
				this.exempt_from_Health_ContributionField = value;
				this.RaisePropertyChanged("Exempt_from_Health_Contribution");
			}
		}

		[XmlIgnore]
		public bool Exempt_from_Health_ContributionSpecified
		{
			get
			{
				return this.exempt_from_Health_ContributionFieldSpecified;
			}
			set
			{
				this.exempt_from_Health_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_from_Health_ContributionSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public DateTime Last_Updated
		{
			get
			{
				return this.last_UpdatedField;
			}
			set
			{
				this.last_UpdatedField = value;
				this.RaisePropertyChanged("Last_Updated");
			}
		}

		[XmlIgnore]
		public bool Last_UpdatedSpecified
		{
			get
			{
				return this.last_UpdatedFieldSpecified;
			}
			set
			{
				this.last_UpdatedFieldSpecified = value;
				this.RaisePropertyChanged("Last_UpdatedSpecified");
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
