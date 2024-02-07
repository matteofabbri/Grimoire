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
	public class Payroll_Payee_TD1_DataType : INotifyPropertyChanged
	{
		private Payroll_Payee_T1ObjectType payroll_Payee_TD1_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_As_OfField;

		private decimal basic_Personal_AmountField;

		private bool basic_Personal_AmountFieldSpecified;

		private decimal child_AmountField;

		private bool child_AmountFieldSpecified;

		private decimal age_AmountField;

		private bool age_AmountFieldSpecified;

		private decimal pension_Income_AmountField;

		private bool pension_Income_AmountFieldSpecified;

		private decimal tuition__Education_and_Textbook_AmountsField;

		private bool tuition__Education_and_Textbook_AmountsFieldSpecified;

		private decimal disability_AmountField;

		private bool disability_AmountFieldSpecified;

		private decimal spouse_or_Commonlaw_Partner_AmountField;

		private bool spouse_or_Commonlaw_Partner_AmountFieldSpecified;

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

		private bool total_Income_less_than_Total_Claim_AmountField;

		private bool total_Income_less_than_Total_Claim_AmountFieldSpecified;

		private bool more_than_One_Employer_or_Payer_at_the_Same_TimeField;

		private bool more_than_One_Employer_or_Payer_at_the_Same_TimeFieldSpecified;

		private decimal deduction_for_Living_in_a_Prescribed_ZoneField;

		private bool deduction_for_Living_in_a_Prescribed_ZoneFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private DateTime eSS_Electronic_Signature_ConfirmationField;

		private bool eSS_Electronic_Signature_ConfirmationFieldSpecified;

		private Unique_IdentifierObjectType payroll_Payee_Tax_Data_Event_ReferenceField;

		private DateTime last_UpdatedField;

		private bool last_UpdatedFieldSpecified;

		private WorkerObjectType last_Updated_By_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_Payee_T1ObjectType Payroll_Payee_TD1_Reference
		{
			get
			{
				return this.payroll_Payee_TD1_ReferenceField;
			}
			set
			{
				this.payroll_Payee_TD1_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_TD1_Reference");
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement("Spouse_or_Common-law_Partner_Amount", Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Amounts_Transferred_from_your_Spouse_or_Common-law_Partner", Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
		public bool More_than_One_Employer_or_Payer_at_the_Same_Time
		{
			get
			{
				return this.more_than_One_Employer_or_Payer_at_the_Same_TimeField;
			}
			set
			{
				this.more_than_One_Employer_or_Payer_at_the_Same_TimeField = value;
				this.RaisePropertyChanged("More_than_One_Employer_or_Payer_at_the_Same_Time");
			}
		}

		[XmlIgnore]
		public bool More_than_One_Employer_or_Payer_at_the_Same_TimeSpecified
		{
			get
			{
				return this.more_than_One_Employer_or_Payer_at_the_Same_TimeFieldSpecified;
			}
			set
			{
				this.more_than_One_Employer_or_Payer_at_the_Same_TimeFieldSpecified = value;
				this.RaisePropertyChanged("More_than_One_Employer_or_Payer_at_the_Same_TimeSpecified");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public DateTime ESS_Electronic_Signature_Confirmation
		{
			get
			{
				return this.eSS_Electronic_Signature_ConfirmationField;
			}
			set
			{
				this.eSS_Electronic_Signature_ConfirmationField = value;
				this.RaisePropertyChanged("ESS_Electronic_Signature_Confirmation");
			}
		}

		[XmlIgnore]
		public bool ESS_Electronic_Signature_ConfirmationSpecified
		{
			get
			{
				return this.eSS_Electronic_Signature_ConfirmationFieldSpecified;
			}
			set
			{
				this.eSS_Electronic_Signature_ConfirmationFieldSpecified = value;
				this.RaisePropertyChanged("ESS_Electronic_Signature_ConfirmationSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public Unique_IdentifierObjectType Payroll_Payee_Tax_Data_Event_Reference
		{
			get
			{
				return this.payroll_Payee_Tax_Data_Event_ReferenceField;
			}
			set
			{
				this.payroll_Payee_Tax_Data_Event_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Payee_Tax_Data_Event_Reference");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public WorkerObjectType Last_Updated_By_Reference
		{
			get
			{
				return this.last_Updated_By_ReferenceField;
			}
			set
			{
				this.last_Updated_By_ReferenceField = value;
				this.RaisePropertyChanged("Last_Updated_By_Reference");
			}
		}

		[XmlElement(Order = 24)]
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
