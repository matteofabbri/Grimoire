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
	public class Payroll_Payee_State_Election_for_State_and_LocalType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private bool married_Filing_Jointly_Optional_CalculationField;

		private bool married_Filing_Jointly_Optional_CalculationFieldSpecified;

		private Payroll_Withholding_StatusObjectType payroll_Withholding_Status_ReferenceField;

		private bool veteran_ExemptionField;

		private bool veteran_ExemptionFieldSpecified;

		private decimal exemption_for_Dependents_CompleteField;

		private bool exemption_for_Dependents_CompleteFieldSpecified;

		private decimal exemption_for_Dependents_Joint_CustodyField;

		private bool exemption_for_Dependents_Joint_CustodyFieldSpecified;

		private bool allowance_on_Special_DeductionField;

		private bool allowance_on_Special_DeductionFieldSpecified;

		private Payroll_Withholding_StatusObjectType new_Jersey_Rate_Table_ReferenceField;

		private decimal dependent_AllowanceField;

		private bool dependent_AllowanceFieldSpecified;

		private decimal number_of_AllowancesField;

		private bool number_of_AllowancesFieldSpecified;

		private Payroll_Constant_NumberObjectType number_of_Allowances_ReferenceField;

		private decimal estimated_DeductionsField;

		private bool estimated_DeductionsFieldSpecified;

		private decimal exemptionsField;

		private bool exemptionsFieldSpecified;

		private decimal withholding_ExemptionField;

		private bool withholding_ExemptionFieldSpecified;

		private bool employee_BlindField;

		private bool employee_BlindFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private decimal additional_PercentField;

		private bool additional_PercentFieldSpecified;

		private decimal reciprocity_Tax_Credit_AmountField;

		private bool reciprocity_Tax_Credit_AmountFieldSpecified;

		private bool xMLNAME_6AField;

		private bool xMLNAME_6AFieldSpecified;

		private bool xMLNAME_6BField;

		private bool xMLNAME_6BFieldSpecified;

		private bool xMLNAME_6CField;

		private bool xMLNAME_6CFieldSpecified;

		private bool xMLNAME_6DField;

		private bool xMLNAME_6DFieldSpecified;

		private bool certificate_of_NonResidenceField;

		private bool certificate_of_NonResidenceFieldSpecified;

		private bool certificate_of_ResidenceField;

		private bool certificate_of_ResidenceFieldSpecified;

		private bool lock_In_LetterField;

		private bool lock_In_LetterFieldSpecified;

		private decimal allocation_PercentField;

		private bool allocation_PercentFieldSpecified;

		private Payroll_Constant_PercentObjectType withholding_Percent_ReferenceField;

		private decimal pay_Period_AmountField;

		private bool pay_Period_AmountFieldSpecified;

		private bool spouse_IndicatorField;

		private bool spouse_IndicatorFieldSpecified;

		private bool fulltime_Student_IndicatorField;

		private bool fulltime_Student_IndicatorFieldSpecified;

		private bool head_of_HouseholdField;

		private bool head_of_HouseholdFieldSpecified;

		private decimal annual_Tax_CreditsField;

		private bool annual_Tax_CreditsFieldSpecified;

		private decimal additional_AllowanceField;

		private bool additional_AllowanceFieldSpecified;

		private decimal reduced_Withholding_AmountField;

		private bool reduced_Withholding_AmountFieldSpecified;

		private bool no_Wage_No_TaxField;

		private bool no_Wage_No_TaxFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private Unique_IdentifierObjectType exempt_Reason_ReferenceField;

		private bool withholding_SubstantiatedField;

		private bool withholding_SubstantiatedFieldSpecified;

		private bool inactivate_State_TaxField;

		private bool inactivate_State_TaxFieldSpecified;

		private bool mSRR_ExemptField;

		private bool mSRR_ExemptFieldSpecified;

		private bool entrepreneur_ExemptionField;

		private bool entrepreneur_ExemptionFieldSpecified;

		private Payroll_State_AuthorityObjectType domicile_State_ReferenceField;

		private decimal increase_or_Decrease_Withholding_AmountField;

		private bool increase_or_Decrease_Withholding_AmountFieldSpecified;

		private bool lower_Tax_Rate_or_Low_IncomeField;

		private bool lower_Tax_Rate_or_Low_IncomeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
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

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Married_Filing_Jointly_Optional_Calculation
		{
			get
			{
				return this.married_Filing_Jointly_Optional_CalculationField;
			}
			set
			{
				this.married_Filing_Jointly_Optional_CalculationField = value;
				this.RaisePropertyChanged("Married_Filing_Jointly_Optional_Calculation");
			}
		}

		[XmlIgnore]
		public bool Married_Filing_Jointly_Optional_CalculationSpecified
		{
			get
			{
				return this.married_Filing_Jointly_Optional_CalculationFieldSpecified;
			}
			set
			{
				this.married_Filing_Jointly_Optional_CalculationFieldSpecified = value;
				this.RaisePropertyChanged("Married_Filing_Jointly_Optional_CalculationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Withholding_StatusObjectType Payroll_Withholding_Status_Reference
		{
			get
			{
				return this.payroll_Withholding_Status_ReferenceField;
			}
			set
			{
				this.payroll_Withholding_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Withholding_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public bool Veteran_Exemption
		{
			get
			{
				return this.veteran_ExemptionField;
			}
			set
			{
				this.veteran_ExemptionField = value;
				this.RaisePropertyChanged("Veteran_Exemption");
			}
		}

		[XmlIgnore]
		public bool Veteran_ExemptionSpecified
		{
			get
			{
				return this.veteran_ExemptionFieldSpecified;
			}
			set
			{
				this.veteran_ExemptionFieldSpecified = value;
				this.RaisePropertyChanged("Veteran_ExemptionSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Exemption_for_Dependents_Complete
		{
			get
			{
				return this.exemption_for_Dependents_CompleteField;
			}
			set
			{
				this.exemption_for_Dependents_CompleteField = value;
				this.RaisePropertyChanged("Exemption_for_Dependents_Complete");
			}
		}

		[XmlIgnore]
		public bool Exemption_for_Dependents_CompleteSpecified
		{
			get
			{
				return this.exemption_for_Dependents_CompleteFieldSpecified;
			}
			set
			{
				this.exemption_for_Dependents_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Exemption_for_Dependents_CompleteSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Exemption_for_Dependents_Joint_Custody
		{
			get
			{
				return this.exemption_for_Dependents_Joint_CustodyField;
			}
			set
			{
				this.exemption_for_Dependents_Joint_CustodyField = value;
				this.RaisePropertyChanged("Exemption_for_Dependents_Joint_Custody");
			}
		}

		[XmlIgnore]
		public bool Exemption_for_Dependents_Joint_CustodySpecified
		{
			get
			{
				return this.exemption_for_Dependents_Joint_CustodyFieldSpecified;
			}
			set
			{
				this.exemption_for_Dependents_Joint_CustodyFieldSpecified = value;
				this.RaisePropertyChanged("Exemption_for_Dependents_Joint_CustodySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Allowance_on_Special_Deduction
		{
			get
			{
				return this.allowance_on_Special_DeductionField;
			}
			set
			{
				this.allowance_on_Special_DeductionField = value;
				this.RaisePropertyChanged("Allowance_on_Special_Deduction");
			}
		}

		[XmlIgnore]
		public bool Allowance_on_Special_DeductionSpecified
		{
			get
			{
				return this.allowance_on_Special_DeductionFieldSpecified;
			}
			set
			{
				this.allowance_on_Special_DeductionFieldSpecified = value;
				this.RaisePropertyChanged("Allowance_on_Special_DeductionSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Payroll_Withholding_StatusObjectType New_Jersey_Rate_Table_Reference
		{
			get
			{
				return this.new_Jersey_Rate_Table_ReferenceField;
			}
			set
			{
				this.new_Jersey_Rate_Table_ReferenceField = value;
				this.RaisePropertyChanged("New_Jersey_Rate_Table_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Dependent_Allowance
		{
			get
			{
				return this.dependent_AllowanceField;
			}
			set
			{
				this.dependent_AllowanceField = value;
				this.RaisePropertyChanged("Dependent_Allowance");
			}
		}

		[XmlIgnore]
		public bool Dependent_AllowanceSpecified
		{
			get
			{
				return this.dependent_AllowanceFieldSpecified;
			}
			set
			{
				this.dependent_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Number_of_Allowances
		{
			get
			{
				return this.number_of_AllowancesField;
			}
			set
			{
				this.number_of_AllowancesField = value;
				this.RaisePropertyChanged("Number_of_Allowances");
			}
		}

		[XmlIgnore]
		public bool Number_of_AllowancesSpecified
		{
			get
			{
				return this.number_of_AllowancesFieldSpecified;
			}
			set
			{
				this.number_of_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Constant_NumberObjectType Number_of_Allowances_Reference
		{
			get
			{
				return this.number_of_Allowances_ReferenceField;
			}
			set
			{
				this.number_of_Allowances_ReferenceField = value;
				this.RaisePropertyChanged("Number_of_Allowances_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Estimated_Deductions
		{
			get
			{
				return this.estimated_DeductionsField;
			}
			set
			{
				this.estimated_DeductionsField = value;
				this.RaisePropertyChanged("Estimated_Deductions");
			}
		}

		[XmlIgnore]
		public bool Estimated_DeductionsSpecified
		{
			get
			{
				return this.estimated_DeductionsFieldSpecified;
			}
			set
			{
				this.estimated_DeductionsFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_DeductionsSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Exemptions
		{
			get
			{
				return this.exemptionsField;
			}
			set
			{
				this.exemptionsField = value;
				this.RaisePropertyChanged("Exemptions");
			}
		}

		[XmlIgnore]
		public bool ExemptionsSpecified
		{
			get
			{
				return this.exemptionsFieldSpecified;
			}
			set
			{
				this.exemptionsFieldSpecified = value;
				this.RaisePropertyChanged("ExemptionsSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Withholding_Exemption
		{
			get
			{
				return this.withholding_ExemptionField;
			}
			set
			{
				this.withholding_ExemptionField = value;
				this.RaisePropertyChanged("Withholding_Exemption");
			}
		}

		[XmlIgnore]
		public bool Withholding_ExemptionSpecified
		{
			get
			{
				return this.withholding_ExemptionFieldSpecified;
			}
			set
			{
				this.withholding_ExemptionFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_ExemptionSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Employee_Blind
		{
			get
			{
				return this.employee_BlindField;
			}
			set
			{
				this.employee_BlindField = value;
				this.RaisePropertyChanged("Employee_Blind");
			}
		}

		[XmlIgnore]
		public bool Employee_BlindSpecified
		{
			get
			{
				return this.employee_BlindFieldSpecified;
			}
			set
			{
				this.employee_BlindFieldSpecified = value;
				this.RaisePropertyChanged("Employee_BlindSpecified");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public decimal Additional_Percent
		{
			get
			{
				return this.additional_PercentField;
			}
			set
			{
				this.additional_PercentField = value;
				this.RaisePropertyChanged("Additional_Percent");
			}
		}

		[XmlIgnore]
		public bool Additional_PercentSpecified
		{
			get
			{
				return this.additional_PercentFieldSpecified;
			}
			set
			{
				this.additional_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Additional_PercentSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Reciprocity_Tax_Credit_Amount
		{
			get
			{
				return this.reciprocity_Tax_Credit_AmountField;
			}
			set
			{
				this.reciprocity_Tax_Credit_AmountField = value;
				this.RaisePropertyChanged("Reciprocity_Tax_Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Reciprocity_Tax_Credit_AmountSpecified
		{
			get
			{
				return this.reciprocity_Tax_Credit_AmountFieldSpecified;
			}
			set
			{
				this.reciprocity_Tax_Credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Reciprocity_Tax_Credit_AmountSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool XMLNAME_6A
		{
			get
			{
				return this.xMLNAME_6AField;
			}
			set
			{
				this.xMLNAME_6AField = value;
				this.RaisePropertyChanged("XMLNAME_6A");
			}
		}

		[XmlIgnore]
		public bool XMLNAME_6ASpecified
		{
			get
			{
				return this.xMLNAME_6AFieldSpecified;
			}
			set
			{
				this.xMLNAME_6AFieldSpecified = value;
				this.RaisePropertyChanged("XMLNAME_6ASpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool XMLNAME_6B
		{
			get
			{
				return this.xMLNAME_6BField;
			}
			set
			{
				this.xMLNAME_6BField = value;
				this.RaisePropertyChanged("XMLNAME_6B");
			}
		}

		[XmlIgnore]
		public bool XMLNAME_6BSpecified
		{
			get
			{
				return this.xMLNAME_6BFieldSpecified;
			}
			set
			{
				this.xMLNAME_6BFieldSpecified = value;
				this.RaisePropertyChanged("XMLNAME_6BSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool XMLNAME_6C
		{
			get
			{
				return this.xMLNAME_6CField;
			}
			set
			{
				this.xMLNAME_6CField = value;
				this.RaisePropertyChanged("XMLNAME_6C");
			}
		}

		[XmlIgnore]
		public bool XMLNAME_6CSpecified
		{
			get
			{
				return this.xMLNAME_6CFieldSpecified;
			}
			set
			{
				this.xMLNAME_6CFieldSpecified = value;
				this.RaisePropertyChanged("XMLNAME_6CSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool XMLNAME_6D
		{
			get
			{
				return this.xMLNAME_6DField;
			}
			set
			{
				this.xMLNAME_6DField = value;
				this.RaisePropertyChanged("XMLNAME_6D");
			}
		}

		[XmlIgnore]
		public bool XMLNAME_6DSpecified
		{
			get
			{
				return this.xMLNAME_6DFieldSpecified;
			}
			set
			{
				this.xMLNAME_6DFieldSpecified = value;
				this.RaisePropertyChanged("XMLNAME_6DSpecified");
			}
		}

		[XmlElement("Certificate_of_Non-Residence", Order = 22)]
		public bool Certificate_of_NonResidence
		{
			get
			{
				return this.certificate_of_NonResidenceField;
			}
			set
			{
				this.certificate_of_NonResidenceField = value;
				this.RaisePropertyChanged("Certificate_of_NonResidence");
			}
		}

		[XmlIgnore]
		public bool Certificate_of_NonResidenceSpecified
		{
			get
			{
				return this.certificate_of_NonResidenceFieldSpecified;
			}
			set
			{
				this.certificate_of_NonResidenceFieldSpecified = value;
				this.RaisePropertyChanged("Certificate_of_NonResidenceSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Certificate_of_Residence
		{
			get
			{
				return this.certificate_of_ResidenceField;
			}
			set
			{
				this.certificate_of_ResidenceField = value;
				this.RaisePropertyChanged("Certificate_of_Residence");
			}
		}

		[XmlIgnore]
		public bool Certificate_of_ResidenceSpecified
		{
			get
			{
				return this.certificate_of_ResidenceFieldSpecified;
			}
			set
			{
				this.certificate_of_ResidenceFieldSpecified = value;
				this.RaisePropertyChanged("Certificate_of_ResidenceSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Lock_In_Letter
		{
			get
			{
				return this.lock_In_LetterField;
			}
			set
			{
				this.lock_In_LetterField = value;
				this.RaisePropertyChanged("Lock_In_Letter");
			}
		}

		[XmlIgnore]
		public bool Lock_In_LetterSpecified
		{
			get
			{
				return this.lock_In_LetterFieldSpecified;
			}
			set
			{
				this.lock_In_LetterFieldSpecified = value;
				this.RaisePropertyChanged("Lock_In_LetterSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Allocation_Percent
		{
			get
			{
				return this.allocation_PercentField;
			}
			set
			{
				this.allocation_PercentField = value;
				this.RaisePropertyChanged("Allocation_Percent");
			}
		}

		[XmlIgnore]
		public bool Allocation_PercentSpecified
		{
			get
			{
				return this.allocation_PercentFieldSpecified;
			}
			set
			{
				this.allocation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Allocation_PercentSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public Payroll_Constant_PercentObjectType Withholding_Percent_Reference
		{
			get
			{
				return this.withholding_Percent_ReferenceField;
			}
			set
			{
				this.withholding_Percent_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Percent_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public decimal Pay_Period_Amount
		{
			get
			{
				return this.pay_Period_AmountField;
			}
			set
			{
				this.pay_Period_AmountField = value;
				this.RaisePropertyChanged("Pay_Period_Amount");
			}
		}

		[XmlIgnore]
		public bool Pay_Period_AmountSpecified
		{
			get
			{
				return this.pay_Period_AmountFieldSpecified;
			}
			set
			{
				this.pay_Period_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Period_AmountSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public bool Spouse_Indicator
		{
			get
			{
				return this.spouse_IndicatorField;
			}
			set
			{
				this.spouse_IndicatorField = value;
				this.RaisePropertyChanged("Spouse_Indicator");
			}
		}

		[XmlIgnore]
		public bool Spouse_IndicatorSpecified
		{
			get
			{
				return this.spouse_IndicatorFieldSpecified;
			}
			set
			{
				this.spouse_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Spouse_IndicatorSpecified");
			}
		}

		[XmlElement("Full-time_Student_Indicator", Order = 29)]
		public bool Fulltime_Student_Indicator
		{
			get
			{
				return this.fulltime_Student_IndicatorField;
			}
			set
			{
				this.fulltime_Student_IndicatorField = value;
				this.RaisePropertyChanged("Fulltime_Student_Indicator");
			}
		}

		[XmlIgnore]
		public bool Fulltime_Student_IndicatorSpecified
		{
			get
			{
				return this.fulltime_Student_IndicatorFieldSpecified;
			}
			set
			{
				this.fulltime_Student_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Fulltime_Student_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Head_of_Household
		{
			get
			{
				return this.head_of_HouseholdField;
			}
			set
			{
				this.head_of_HouseholdField = value;
				this.RaisePropertyChanged("Head_of_Household");
			}
		}

		[XmlIgnore]
		public bool Head_of_HouseholdSpecified
		{
			get
			{
				return this.head_of_HouseholdFieldSpecified;
			}
			set
			{
				this.head_of_HouseholdFieldSpecified = value;
				this.RaisePropertyChanged("Head_of_HouseholdSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public decimal Annual_Tax_Credits
		{
			get
			{
				return this.annual_Tax_CreditsField;
			}
			set
			{
				this.annual_Tax_CreditsField = value;
				this.RaisePropertyChanged("Annual_Tax_Credits");
			}
		}

		[XmlIgnore]
		public bool Annual_Tax_CreditsSpecified
		{
			get
			{
				return this.annual_Tax_CreditsFieldSpecified;
			}
			set
			{
				this.annual_Tax_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Annual_Tax_CreditsSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public decimal Additional_Allowance
		{
			get
			{
				return this.additional_AllowanceField;
			}
			set
			{
				this.additional_AllowanceField = value;
				this.RaisePropertyChanged("Additional_Allowance");
			}
		}

		[XmlIgnore]
		public bool Additional_AllowanceSpecified
		{
			get
			{
				return this.additional_AllowanceFieldSpecified;
			}
			set
			{
				this.additional_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Additional_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public decimal Reduced_Withholding_Amount
		{
			get
			{
				return this.reduced_Withholding_AmountField;
			}
			set
			{
				this.reduced_Withholding_AmountField = value;
				this.RaisePropertyChanged("Reduced_Withholding_Amount");
			}
		}

		[XmlIgnore]
		public bool Reduced_Withholding_AmountSpecified
		{
			get
			{
				return this.reduced_Withholding_AmountFieldSpecified;
			}
			set
			{
				this.reduced_Withholding_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Reduced_Withholding_AmountSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public bool No_Wage_No_Tax
		{
			get
			{
				return this.no_Wage_No_TaxField;
			}
			set
			{
				this.no_Wage_No_TaxField = value;
				this.RaisePropertyChanged("No_Wage_No_Tax");
			}
		}

		[XmlIgnore]
		public bool No_Wage_No_TaxSpecified
		{
			get
			{
				return this.no_Wage_No_TaxFieldSpecified;
			}
			set
			{
				this.no_Wage_No_TaxFieldSpecified = value;
				this.RaisePropertyChanged("No_Wage_No_TaxSpecified");
			}
		}

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
		public Unique_IdentifierObjectType Exempt_Reason_Reference
		{
			get
			{
				return this.exempt_Reason_ReferenceField;
			}
			set
			{
				this.exempt_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Exempt_Reason_Reference");
			}
		}

		[XmlElement(Order = 37)]
		public bool Withholding_Substantiated
		{
			get
			{
				return this.withholding_SubstantiatedField;
			}
			set
			{
				this.withholding_SubstantiatedField = value;
				this.RaisePropertyChanged("Withholding_Substantiated");
			}
		}

		[XmlIgnore]
		public bool Withholding_SubstantiatedSpecified
		{
			get
			{
				return this.withholding_SubstantiatedFieldSpecified;
			}
			set
			{
				this.withholding_SubstantiatedFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_SubstantiatedSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool Inactivate_State_Tax
		{
			get
			{
				return this.inactivate_State_TaxField;
			}
			set
			{
				this.inactivate_State_TaxField = value;
				this.RaisePropertyChanged("Inactivate_State_Tax");
			}
		}

		[XmlIgnore]
		public bool Inactivate_State_TaxSpecified
		{
			get
			{
				return this.inactivate_State_TaxFieldSpecified;
			}
			set
			{
				this.inactivate_State_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Inactivate_State_TaxSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool MSRR_Exempt
		{
			get
			{
				return this.mSRR_ExemptField;
			}
			set
			{
				this.mSRR_ExemptField = value;
				this.RaisePropertyChanged("MSRR_Exempt");
			}
		}

		[XmlIgnore]
		public bool MSRR_ExemptSpecified
		{
			get
			{
				return this.mSRR_ExemptFieldSpecified;
			}
			set
			{
				this.mSRR_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("MSRR_ExemptSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Entrepreneur_Exemption
		{
			get
			{
				return this.entrepreneur_ExemptionField;
			}
			set
			{
				this.entrepreneur_ExemptionField = value;
				this.RaisePropertyChanged("Entrepreneur_Exemption");
			}
		}

		[XmlIgnore]
		public bool Entrepreneur_ExemptionSpecified
		{
			get
			{
				return this.entrepreneur_ExemptionFieldSpecified;
			}
			set
			{
				this.entrepreneur_ExemptionFieldSpecified = value;
				this.RaisePropertyChanged("Entrepreneur_ExemptionSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public Payroll_State_AuthorityObjectType Domicile_State_Reference
		{
			get
			{
				return this.domicile_State_ReferenceField;
			}
			set
			{
				this.domicile_State_ReferenceField = value;
				this.RaisePropertyChanged("Domicile_State_Reference");
			}
		}

		[XmlElement(Order = 42)]
		public decimal Increase_or_Decrease_Withholding_Amount
		{
			get
			{
				return this.increase_or_Decrease_Withholding_AmountField;
			}
			set
			{
				this.increase_or_Decrease_Withholding_AmountField = value;
				this.RaisePropertyChanged("Increase_or_Decrease_Withholding_Amount");
			}
		}

		[XmlIgnore]
		public bool Increase_or_Decrease_Withholding_AmountSpecified
		{
			get
			{
				return this.increase_or_Decrease_Withholding_AmountFieldSpecified;
			}
			set
			{
				this.increase_or_Decrease_Withholding_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Increase_or_Decrease_Withholding_AmountSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public bool Lower_Tax_Rate_or_Low_Income
		{
			get
			{
				return this.lower_Tax_Rate_or_Low_IncomeField;
			}
			set
			{
				this.lower_Tax_Rate_or_Low_IncomeField = value;
				this.RaisePropertyChanged("Lower_Tax_Rate_or_Low_Income");
			}
		}

		[XmlIgnore]
		public bool Lower_Tax_Rate_or_Low_IncomeSpecified
		{
			get
			{
				return this.lower_Tax_Rate_or_Low_IncomeFieldSpecified;
			}
			set
			{
				this.lower_Tax_Rate_or_Low_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("Lower_Tax_Rate_or_Low_IncomeSpecified");
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
