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
	public class ISIR_Transaction_Data_DataType : INotifyPropertyChanged
	{
		private string year_IndicatorField;

		private string student_Last_NameField;

		private string student_First_NameField;

		private string student_Middle_InitialField;

		private string student_Permanent_Mailing_AddressField;

		private string student_Permanent_CityField;

		private ISIR_Location_ContextObjectType student_Permanent_State_ReferenceField;

		private string student_Permanent_Zip_CodeField;

		private DateTime student_Date_of_BirthField;

		private bool student_Date_of_BirthFieldSpecified;

		private string student_Permanent_Phone_NumberField;

		private string student_Driver_License_NumberField;

		private ISIR_Location_ContextObjectType student_Driver_License_State_Code_ReferenceField;

		private string student_Email_AddressField;

		private Financial_Aid_Citizenship_StatusObjectType student_Citizenship_Status_ReferenceField;

		private decimal student_Alien_Registration_NumberField;

		private bool student_Alien_Registration_NumberFieldSpecified;

		private ISIR_Student_Marital_StatusObjectType student_Marital_Status_ReferenceField;

		private DateTime student_Marital_Status_DateField;

		private bool student_Marital_Status_DateFieldSpecified;

		private ISIR_Location_ContextObjectType student_State_of_Legal_Residence_ReferenceField;

		private ISIR_ResponseObjectType student_Legal_Resident_before_January_YYYY_ReferenceField;

		private DateTime student_Legal_Residence_DateField;

		private bool student_Legal_Residence_DateFieldSpecified;

		private Financial_Aid_GenderObjectType student_Gender_ReferenceField;

		private bool student_Selective_Service_RegistrationField;

		private bool student_Selective_Service_RegistrationFieldSpecified;

		private ISIR_Drug_Conviction_Affecting_EligibilityObjectType student_Drug_Conviction_Affecting_Eligibility_ReferenceField;

		private Financial_Aid_Highest_Grade_Level_CompletedObjectType parent_1_Highest_Grade_Level_Completed_ReferenceField;

		private Financial_Aid_Highest_Grade_Level_CompletedObjectType parent_2_Highest_Grade_Level_Completed_ReferenceField;

		private Financial_Aid_High_School_Diploma_or_EquivalentObjectType high_School_Diploma_or_Equivalent_ReferenceField;

		private string high_School_NameField;

		private string high_School_CityField;

		private ISIR_Location_ContextObjectType high_School_State_ReferenceField;

		private ISIR_ResponseObjectType first_Bachelors_degree_by_July_YYYY_ReferenceField;

		private Financial_Aid_Grade_Level_in_CollegeObjectType grade_Level_in_College_ReferenceField;

		private ISIR_Degree_or_CertificateObjectType degree_or_Certificate_ReferenceField;

		private ISIR_ResponseObjectType interested_in_receiving_Work_Study_ReferenceField;

		private ISIR_Tax_Return_StatusObjectType student_Tax_Return_Status_ReferenceField;

		private Financial_Aid_Type_of_Prior_Year_Tax_Form_UsedObjectType student_Type_of_Prior_Year_Tax_Form_Used_ReferenceField;

		private Financial_Aid_Tax_Return_Filing_StatusObjectType student_Tax_Return_Filing_Status_ReferenceField;

		private ISIR_ResponseObjectType student_Eligibility_to_file_1040A_or_1040EZ_ReferenceField;

		private decimal student_Adjusted_Gross_Income_from_IRS_FormField;

		private bool student_Adjusted_Gross_Income_from_IRS_FormFieldSpecified;

		private decimal student_Income_Tax_PaidField;

		private bool student_Income_Tax_PaidFieldSpecified;

		private decimal student_Exemptions_ClaimedField;

		private bool student_Exemptions_ClaimedFieldSpecified;

		private decimal student_Income_Earned_from_WorkField;

		private bool student_Income_Earned_from_WorkFieldSpecified;

		private decimal spouse_Income_Earned_from_WorkField;

		private bool spouse_Income_Earned_from_WorkFieldSpecified;

		private decimal student_Cash_Savings_and_CheckingField;

		private bool student_Cash_Savings_and_CheckingFieldSpecified;

		private decimal student_Investment_Net_WorthField;

		private bool student_Investment_Net_WorthFieldSpecified;

		private decimal student_Business_and_or_Investment_Farm_Net_WorthField;

		private bool student_Business_and_or_Investment_Farm_Net_WorthFieldSpecified;

		private decimal student_Educational_CreditsField;

		private bool student_Educational_CreditsFieldSpecified;

		private decimal student_Child_Support_PaidField;

		private bool student_Child_Support_PaidFieldSpecified;

		private decimal student_Need_Based_EmploymentField;

		private bool student_Need_Based_EmploymentFieldSpecified;

		private decimal student_Grant_Scholarship_AidField;

		private bool student_Grant_Scholarship_AidFieldSpecified;

		private decimal student_Combat_PayField;

		private bool student_Combat_PayFieldSpecified;

		private decimal student_Co_op_EarningsField;

		private bool student_Co_op_EarningsFieldSpecified;

		private decimal student_Pension_PaymentsField;

		private bool student_Pension_PaymentsFieldSpecified;

		private decimal student_IRA_PaymentsField;

		private bool student_IRA_PaymentsFieldSpecified;

		private decimal student_Child_Support_ReceivedField;

		private bool student_Child_Support_ReceivedFieldSpecified;

		private decimal student_Interest_IncomeField;

		private bool student_Interest_IncomeFieldSpecified;

		private decimal student_IRA_DistributionsField;

		private bool student_IRA_DistributionsFieldSpecified;

		private decimal student_Untaxed_PensionsField;

		private bool student_Untaxed_PensionsFieldSpecified;

		private decimal student_Military_Clergy_AllowancesField;

		private bool student_Military_Clergy_AllowancesFieldSpecified;

		private decimal student_Veterans_Noneducation_BenefitsField;

		private bool student_Veterans_Noneducation_BenefitsFieldSpecified;

		private decimal student_Other_Untaxed_IncomeField;

		private bool student_Other_Untaxed_IncomeFieldSpecified;

		private decimal student_Other_Nonreported_MoneyField;

		private bool student_Other_Nonreported_MoneyFieldSpecified;

		private ISIR_ResponseObjectType student_Born_Before_January_YYYY_ReferenceField;

		private ISIR_ResponseObjectType student_Married_ReferenceField;

		private ISIR_ResponseObjectType student_Working_on_Masters_or_Doctorate_Program_ReferenceField;

		private ISIR_ResponseObjectType student_on_Active_Duty_in_US_Armed_Forces_ReferenceField;

		private ISIR_ResponseObjectType student_Veteran_of_US_Armed_Forces_ReferenceField;

		private ISIR_ResponseObjectType student_Have_Children_they_Support_ReferenceField;

		private ISIR_ResponseObjectType student_Has_Legal_Dependents_Other_than_Children_or_Spouse_ReferenceField;

		private ISIR_ResponseObjectType student_Orphan_Ward_of_Court_or_Foster_Care_ReferenceField;

		private ISIR_ResponseObjectType student_Emancipated_Minor_ReferenceField;

		private ISIR_ResponseObjectType student_in_legal_guardianship_ReferenceField;

		private ISIR_ResponseObjectType student_Unaccompanied_youth_determined_by_school_district_liaison_ReferenceField;

		private ISIR_ResponseObjectType student_Unaccompanied_youth_determined_by_HUD_ReferenceField;

		private ISIR_ResponseObjectType student_At_risk_of_homelessness_ReferenceField;

		private ISIR_Parent_Marital_StatusObjectType parents_Marital_Status_ReferenceField;

		private DateTime parents_Marital_Status_DateField;

		private bool parents_Marital_Status_DateFieldSpecified;

		private string parent_1_Social_Security_NumberField;

		private string parent_1_Last_NameField;

		private string parent_1_First_Name_InitialField;

		private DateTime parent_1_Date_of_BirthField;

		private bool parent_1_Date_of_BirthFieldSpecified;

		private string parent_2_Social_Security_NumberField;

		private string parent_2_Last_NameField;

		private string parent_2_First_Name_InitialField;

		private DateTime parent_2_Date_of_BirthField;

		private bool parent_2_Date_of_BirthFieldSpecified;

		private string parents_Email_AddressField;

		private ISIR_Location_ContextObjectType parents_State_of_Legal_Residence_ReferenceField;

		private ISIR_ResponseObjectType parents_Legal_Residents_before_January_YYYY_ReferenceField;

		private DateTime parents_Legal_Residence_DateField;

		private bool parents_Legal_Residence_DateFieldSpecified;

		private decimal parents_Number_of_Family_MembersField;

		private bool parents_Number_of_Family_MembersFieldSpecified;

		private decimal parents_Number_in_College_Parents_ExcludedField;

		private bool parents_Number_in_College_Parents_ExcludedFieldSpecified;

		private ISIR_ResponseObjectType parent_Supplemental_Security_Income_Benefits_ReferenceField;

		private ISIR_ResponseObjectType parent_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField;

		private ISIR_ResponseObjectType[] parent_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField;

		private ISIR_ResponseObjectType parent_TANF_Benefits_ReferenceField;

		private ISIR_ResponseObjectType parent_WIC_Benefits_ReferenceField;

		private ISIR_Tax_Return_StatusObjectType parents_Tax_Return_Status_ReferenceField;

		private Financial_Aid_Type_of_Prior_Year_Tax_Form_UsedObjectType parents_Type_of_Prior_Year_Tax_Form_Used_ReferenceField;

		private Financial_Aid_Tax_Return_Filing_StatusObjectType parents_Tax_Return_Filing_Status_ReferenceField;

		private ISIR_ResponseObjectType parents_Eligible_to_file_1040A_or_1040EZ_ReferenceField;

		private ISIR_ResponseObjectType parent_Dislocated_Worker_ReferenceField;

		private decimal parents_Adjusted_Gross_Income_from_IRS_FormField;

		private bool parents_Adjusted_Gross_Income_from_IRS_FormFieldSpecified;

		private decimal parents_US_Income_Tax_PaidField;

		private bool parents_US_Income_Tax_PaidFieldSpecified;

		private decimal parents_Exemptions_ClaimedField;

		private bool parents_Exemptions_ClaimedFieldSpecified;

		private decimal parent_1_Income_Earned_from_WorkField;

		private bool parent_1_Income_Earned_from_WorkFieldSpecified;

		private decimal parent_2_Income_Earned_from_WorkField;

		private bool parent_2_Income_Earned_from_WorkFieldSpecified;

		private decimal parents_Cash_Savings_and_CheckingField;

		private bool parents_Cash_Savings_and_CheckingFieldSpecified;

		private decimal parents_Investment_Net_WorthField;

		private bool parents_Investment_Net_WorthFieldSpecified;

		private decimal parents_Business_and_or_Investment_Farm_Net_WorthField;

		private bool parents_Business_and_or_Investment_Farm_Net_WorthFieldSpecified;

		private decimal parents_Educational_CreditsField;

		private bool parents_Educational_CreditsFieldSpecified;

		private decimal parents_Child_Support_PaidField;

		private bool parents_Child_Support_PaidFieldSpecified;

		private decimal parents_Need_Based_EmploymentField;

		private bool parents_Need_Based_EmploymentFieldSpecified;

		private decimal parents_Grant_Scholarship_AidField;

		private bool parents_Grant_Scholarship_AidFieldSpecified;

		private decimal parents_Combat_PayField;

		private bool parents_Combat_PayFieldSpecified;

		private decimal parents_Co_op_EarningsField;

		private bool parents_Co_op_EarningsFieldSpecified;

		private decimal parents_Pension_PaymentsField;

		private bool parents_Pension_PaymentsFieldSpecified;

		private decimal parents_IRA_PaymentsField;

		private bool parents_IRA_PaymentsFieldSpecified;

		private decimal parents_Child_Support_ReceivedField;

		private bool parents_Child_Support_ReceivedFieldSpecified;

		private decimal parents_Interest_IncomeField;

		private bool parents_Interest_IncomeFieldSpecified;

		private decimal parents_IRA_DistributionsField;

		private bool parents_IRA_DistributionsFieldSpecified;

		private decimal parents_Untaxed_PensionsField;

		private bool parents_Untaxed_PensionsFieldSpecified;

		private decimal parents_Military_Clergy_AllowancesField;

		private bool parents_Military_Clergy_AllowancesFieldSpecified;

		private decimal parents_Veterans_Noneducation_BenefitsField;

		private bool parents_Veterans_Noneducation_BenefitsFieldSpecified;

		private decimal parents_Other_Untaxed_IncomeField;

		private bool parents_Other_Untaxed_IncomeFieldSpecified;

		private decimal student_Number_of_Family_MembersField;

		private bool student_Number_of_Family_MembersFieldSpecified;

		private decimal student_Number_in_CollegeField;

		private bool student_Number_in_CollegeFieldSpecified;

		private ISIR_ResponseObjectType student_Supplemental_Security_Income_Benefits_ReferenceField;

		private ISIR_ResponseObjectType student_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField;

		private ISIR_ResponseObjectType student_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField;

		private ISIR_ResponseObjectType student_TANF_Benefits_ReferenceField;

		private ISIR_ResponseObjectType student_WIC_Benefits_ReferenceField;

		private ISIR_ResponseObjectType student_Spouse_Dislocated_Worker_ReferenceField;

		private School_Code_Housing_PlanObjectType federal_School_Code_1_Housing_Plans_ReferenceField;

		private ISIR_Signed_ByObjectType signed_By_ReferenceField;

		private string preparer_Social_Security_NumberField;

		private string preparer_Employer_Identification_NumberField;

		private bool preparers_SignatureField;

		private bool preparers_SignatureFieldSpecified;

		private ISIR_Dependency_Override_IndicatorObjectType dependency_Override_Indicator_ReferenceField;

		private ISIR_AGI_and_FIT_Data_Field_FlagObjectType iRS_Student_Adjusted_Gross_Income_AGI_Data_Field_Flag_ReferenceField;

		private bool assumption_Override_1Field;

		private bool assumption_Override_1FieldSpecified;

		private bool assumption_Override_2Field;

		private bool assumption_Override_2FieldSpecified;

		private bool assumption_Override_3Field;

		private bool assumption_Override_3FieldSpecified;

		private bool assumption_Override_4Field;

		private bool assumption_Override_4FieldSpecified;

		private bool assumption_Override_5Field;

		private bool assumption_Override_5FieldSpecified;

		private bool assumption_Override_6Field;

		private bool assumption_Override_6FieldSpecified;

		private bool reject_Override_3Field;

		private bool reject_Override_3FieldSpecified;

		private bool reject_Override_12Field;

		private bool reject_Override_12FieldSpecified;

		private bool reject_Override_20Field;

		private bool reject_Override_20FieldSpecified;

		private bool reject_Override_AField;

		private bool reject_Override_AFieldSpecified;

		private bool reject_Override_BField;

		private bool reject_Override_BFieldSpecified;

		private bool reject_Override_CField;

		private bool reject_Override_CFieldSpecified;

		private bool reject_Override_GField;

		private bool reject_Override_GFieldSpecified;

		private bool reject_Override_JField;

		private bool reject_Override_JFieldSpecified;

		private bool reject_Override_KField;

		private bool reject_Override_KFieldSpecified;

		private bool reject_Override_NField;

		private bool reject_Override_NFieldSpecified;

		private bool reject_Override_WField;

		private bool reject_Override_WFieldSpecified;

		private bool reject_Override_21Field;

		private bool reject_Override_21FieldSpecified;

		private string student_Current_Social_Security_NumberField;

		private ISIR_Professional_Judgment_IndicatorObjectType professional_Judgment_Indicator_ReferenceField;

		private string dHS_Verification_NumberField;

		private IRS_Request_FlagObjectType parent_IRS_Request_Flag_ReferenceField;

		private IRS_Request_FlagObjectType student_IRS_Request_Flag_ReferenceField;

		private ISIR_Comment_CodeObjectType[] iSIR_Comment_Code_ReferenceField;

		private bool professional_Judgement_IndicatorField;

		private bool professional_Judgement_IndicatorFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Year_Indicator
		{
			get
			{
				return this.year_IndicatorField;
			}
			set
			{
				this.year_IndicatorField = value;
				this.RaisePropertyChanged("Year_Indicator");
			}
		}

		[XmlElement(Order = 1)]
		public string Student_Last_Name
		{
			get
			{
				return this.student_Last_NameField;
			}
			set
			{
				this.student_Last_NameField = value;
				this.RaisePropertyChanged("Student_Last_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Student_First_Name
		{
			get
			{
				return this.student_First_NameField;
			}
			set
			{
				this.student_First_NameField = value;
				this.RaisePropertyChanged("Student_First_Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Student_Middle_Initial
		{
			get
			{
				return this.student_Middle_InitialField;
			}
			set
			{
				this.student_Middle_InitialField = value;
				this.RaisePropertyChanged("Student_Middle_Initial");
			}
		}

		[XmlElement(Order = 4)]
		public string Student_Permanent_Mailing_Address
		{
			get
			{
				return this.student_Permanent_Mailing_AddressField;
			}
			set
			{
				this.student_Permanent_Mailing_AddressField = value;
				this.RaisePropertyChanged("Student_Permanent_Mailing_Address");
			}
		}

		[XmlElement(Order = 5)]
		public string Student_Permanent_City
		{
			get
			{
				return this.student_Permanent_CityField;
			}
			set
			{
				this.student_Permanent_CityField = value;
				this.RaisePropertyChanged("Student_Permanent_City");
			}
		}

		[XmlElement(Order = 6)]
		public ISIR_Location_ContextObjectType Student_Permanent_State_Reference
		{
			get
			{
				return this.student_Permanent_State_ReferenceField;
			}
			set
			{
				this.student_Permanent_State_ReferenceField = value;
				this.RaisePropertyChanged("Student_Permanent_State_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Student_Permanent_Zip_Code
		{
			get
			{
				return this.student_Permanent_Zip_CodeField;
			}
			set
			{
				this.student_Permanent_Zip_CodeField = value;
				this.RaisePropertyChanged("Student_Permanent_Zip_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Student_Date_of_Birth
		{
			get
			{
				return this.student_Date_of_BirthField;
			}
			set
			{
				this.student_Date_of_BirthField = value;
				this.RaisePropertyChanged("Student_Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Student_Date_of_BirthSpecified
		{
			get
			{
				return this.student_Date_of_BirthFieldSpecified;
			}
			set
			{
				this.student_Date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Student_Date_of_BirthSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Student_Permanent_Phone_Number
		{
			get
			{
				return this.student_Permanent_Phone_NumberField;
			}
			set
			{
				this.student_Permanent_Phone_NumberField = value;
				this.RaisePropertyChanged("Student_Permanent_Phone_Number");
			}
		}

		[XmlElement(Order = 10)]
		public string Student_Driver_License_Number
		{
			get
			{
				return this.student_Driver_License_NumberField;
			}
			set
			{
				this.student_Driver_License_NumberField = value;
				this.RaisePropertyChanged("Student_Driver_License_Number");
			}
		}

		[XmlElement(Order = 11)]
		public ISIR_Location_ContextObjectType Student_Driver_License_State_Code_Reference
		{
			get
			{
				return this.student_Driver_License_State_Code_ReferenceField;
			}
			set
			{
				this.student_Driver_License_State_Code_ReferenceField = value;
				this.RaisePropertyChanged("Student_Driver_License_State_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public string Student_Email_Address
		{
			get
			{
				return this.student_Email_AddressField;
			}
			set
			{
				this.student_Email_AddressField = value;
				this.RaisePropertyChanged("Student_Email_Address");
			}
		}

		[XmlElement(Order = 13)]
		public Financial_Aid_Citizenship_StatusObjectType Student_Citizenship_Status_Reference
		{
			get
			{
				return this.student_Citizenship_Status_ReferenceField;
			}
			set
			{
				this.student_Citizenship_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Citizenship_Status_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Student_Alien_Registration_Number
		{
			get
			{
				return this.student_Alien_Registration_NumberField;
			}
			set
			{
				this.student_Alien_Registration_NumberField = value;
				this.RaisePropertyChanged("Student_Alien_Registration_Number");
			}
		}

		[XmlIgnore]
		public bool Student_Alien_Registration_NumberSpecified
		{
			get
			{
				return this.student_Alien_Registration_NumberFieldSpecified;
			}
			set
			{
				this.student_Alien_Registration_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Student_Alien_Registration_NumberSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public ISIR_Student_Marital_StatusObjectType Student_Marital_Status_Reference
		{
			get
			{
				return this.student_Marital_Status_ReferenceField;
			}
			set
			{
				this.student_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Marital_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Student_Marital_Status_Date
		{
			get
			{
				return this.student_Marital_Status_DateField;
			}
			set
			{
				this.student_Marital_Status_DateField = value;
				this.RaisePropertyChanged("Student_Marital_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Marital_Status_DateSpecified
		{
			get
			{
				return this.student_Marital_Status_DateFieldSpecified;
			}
			set
			{
				this.student_Marital_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Marital_Status_DateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public ISIR_Location_ContextObjectType Student_State_of_Legal_Residence_Reference
		{
			get
			{
				return this.student_State_of_Legal_Residence_ReferenceField;
			}
			set
			{
				this.student_State_of_Legal_Residence_ReferenceField = value;
				this.RaisePropertyChanged("Student_State_of_Legal_Residence_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public ISIR_ResponseObjectType Student_Legal_Resident_before_January_YYYY_Reference
		{
			get
			{
				return this.student_Legal_Resident_before_January_YYYY_ReferenceField;
			}
			set
			{
				this.student_Legal_Resident_before_January_YYYY_ReferenceField = value;
				this.RaisePropertyChanged("Student_Legal_Resident_before_January_YYYY_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 19)]
		public DateTime Student_Legal_Residence_Date
		{
			get
			{
				return this.student_Legal_Residence_DateField;
			}
			set
			{
				this.student_Legal_Residence_DateField = value;
				this.RaisePropertyChanged("Student_Legal_Residence_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Legal_Residence_DateSpecified
		{
			get
			{
				return this.student_Legal_Residence_DateFieldSpecified;
			}
			set
			{
				this.student_Legal_Residence_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Legal_Residence_DateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Financial_Aid_GenderObjectType Student_Gender_Reference
		{
			get
			{
				return this.student_Gender_ReferenceField;
			}
			set
			{
				this.student_Gender_ReferenceField = value;
				this.RaisePropertyChanged("Student_Gender_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public bool Student_Selective_Service_Registration
		{
			get
			{
				return this.student_Selective_Service_RegistrationField;
			}
			set
			{
				this.student_Selective_Service_RegistrationField = value;
				this.RaisePropertyChanged("Student_Selective_Service_Registration");
			}
		}

		[XmlIgnore]
		public bool Student_Selective_Service_RegistrationSpecified
		{
			get
			{
				return this.student_Selective_Service_RegistrationFieldSpecified;
			}
			set
			{
				this.student_Selective_Service_RegistrationFieldSpecified = value;
				this.RaisePropertyChanged("Student_Selective_Service_RegistrationSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public ISIR_Drug_Conviction_Affecting_EligibilityObjectType Student_Drug_Conviction_Affecting_Eligibility_Reference
		{
			get
			{
				return this.student_Drug_Conviction_Affecting_Eligibility_ReferenceField;
			}
			set
			{
				this.student_Drug_Conviction_Affecting_Eligibility_ReferenceField = value;
				this.RaisePropertyChanged("Student_Drug_Conviction_Affecting_Eligibility_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Financial_Aid_Highest_Grade_Level_CompletedObjectType Parent_1_Highest_Grade_Level_Completed_Reference
		{
			get
			{
				return this.parent_1_Highest_Grade_Level_Completed_ReferenceField;
			}
			set
			{
				this.parent_1_Highest_Grade_Level_Completed_ReferenceField = value;
				this.RaisePropertyChanged("Parent_1_Highest_Grade_Level_Completed_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public Financial_Aid_Highest_Grade_Level_CompletedObjectType Parent_2_Highest_Grade_Level_Completed_Reference
		{
			get
			{
				return this.parent_2_Highest_Grade_Level_Completed_ReferenceField;
			}
			set
			{
				this.parent_2_Highest_Grade_Level_Completed_ReferenceField = value;
				this.RaisePropertyChanged("Parent_2_Highest_Grade_Level_Completed_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Financial_Aid_High_School_Diploma_or_EquivalentObjectType High_School_Diploma_or_Equivalent_Reference
		{
			get
			{
				return this.high_School_Diploma_or_Equivalent_ReferenceField;
			}
			set
			{
				this.high_School_Diploma_or_Equivalent_ReferenceField = value;
				this.RaisePropertyChanged("High_School_Diploma_or_Equivalent_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public string High_School_Name
		{
			get
			{
				return this.high_School_NameField;
			}
			set
			{
				this.high_School_NameField = value;
				this.RaisePropertyChanged("High_School_Name");
			}
		}

		[XmlElement(Order = 27)]
		public string High_School_City
		{
			get
			{
				return this.high_School_CityField;
			}
			set
			{
				this.high_School_CityField = value;
				this.RaisePropertyChanged("High_School_City");
			}
		}

		[XmlElement(Order = 28)]
		public ISIR_Location_ContextObjectType High_School_State_Reference
		{
			get
			{
				return this.high_School_State_ReferenceField;
			}
			set
			{
				this.high_School_State_ReferenceField = value;
				this.RaisePropertyChanged("High_School_State_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public ISIR_ResponseObjectType First_Bachelors_degree_by_July_YYYY_Reference
		{
			get
			{
				return this.first_Bachelors_degree_by_July_YYYY_ReferenceField;
			}
			set
			{
				this.first_Bachelors_degree_by_July_YYYY_ReferenceField = value;
				this.RaisePropertyChanged("First_Bachelors_degree_by_July_YYYY_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Financial_Aid_Grade_Level_in_CollegeObjectType Grade_Level_in_College_Reference
		{
			get
			{
				return this.grade_Level_in_College_ReferenceField;
			}
			set
			{
				this.grade_Level_in_College_ReferenceField = value;
				this.RaisePropertyChanged("Grade_Level_in_College_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public ISIR_Degree_or_CertificateObjectType Degree_or_Certificate_Reference
		{
			get
			{
				return this.degree_or_Certificate_ReferenceField;
			}
			set
			{
				this.degree_or_Certificate_ReferenceField = value;
				this.RaisePropertyChanged("Degree_or_Certificate_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public ISIR_ResponseObjectType Interested_in_receiving_Work_Study_Reference
		{
			get
			{
				return this.interested_in_receiving_Work_Study_ReferenceField;
			}
			set
			{
				this.interested_in_receiving_Work_Study_ReferenceField = value;
				this.RaisePropertyChanged("Interested_in_receiving_Work_Study_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public ISIR_Tax_Return_StatusObjectType Student_Tax_Return_Status_Reference
		{
			get
			{
				return this.student_Tax_Return_Status_ReferenceField;
			}
			set
			{
				this.student_Tax_Return_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tax_Return_Status_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public Financial_Aid_Type_of_Prior_Year_Tax_Form_UsedObjectType Student_Type_of_Prior_Year_Tax_Form_Used_Reference
		{
			get
			{
				return this.student_Type_of_Prior_Year_Tax_Form_Used_ReferenceField;
			}
			set
			{
				this.student_Type_of_Prior_Year_Tax_Form_Used_ReferenceField = value;
				this.RaisePropertyChanged("Student_Type_of_Prior_Year_Tax_Form_Used_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public Financial_Aid_Tax_Return_Filing_StatusObjectType Student_Tax_Return_Filing_Status_Reference
		{
			get
			{
				return this.student_Tax_Return_Filing_Status_ReferenceField;
			}
			set
			{
				this.student_Tax_Return_Filing_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tax_Return_Filing_Status_Reference");
			}
		}

		[XmlElement(Order = 36)]
		public ISIR_ResponseObjectType Student_Eligibility_to_file_1040A_or_1040EZ_Reference
		{
			get
			{
				return this.student_Eligibility_to_file_1040A_or_1040EZ_ReferenceField;
			}
			set
			{
				this.student_Eligibility_to_file_1040A_or_1040EZ_ReferenceField = value;
				this.RaisePropertyChanged("Student_Eligibility_to_file_1040A_or_1040EZ_Reference");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Student_Adjusted_Gross_Income_from_IRS_Form
		{
			get
			{
				return this.student_Adjusted_Gross_Income_from_IRS_FormField;
			}
			set
			{
				this.student_Adjusted_Gross_Income_from_IRS_FormField = value;
				this.RaisePropertyChanged("Student_Adjusted_Gross_Income_from_IRS_Form");
			}
		}

		[XmlIgnore]
		public bool Student_Adjusted_Gross_Income_from_IRS_FormSpecified
		{
			get
			{
				return this.student_Adjusted_Gross_Income_from_IRS_FormFieldSpecified;
			}
			set
			{
				this.student_Adjusted_Gross_Income_from_IRS_FormFieldSpecified = value;
				this.RaisePropertyChanged("Student_Adjusted_Gross_Income_from_IRS_FormSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public decimal Student_Income_Tax_Paid
		{
			get
			{
				return this.student_Income_Tax_PaidField;
			}
			set
			{
				this.student_Income_Tax_PaidField = value;
				this.RaisePropertyChanged("Student_Income_Tax_Paid");
			}
		}

		[XmlIgnore]
		public bool Student_Income_Tax_PaidSpecified
		{
			get
			{
				return this.student_Income_Tax_PaidFieldSpecified;
			}
			set
			{
				this.student_Income_Tax_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Student_Income_Tax_PaidSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public decimal Student_Exemptions_Claimed
		{
			get
			{
				return this.student_Exemptions_ClaimedField;
			}
			set
			{
				this.student_Exemptions_ClaimedField = value;
				this.RaisePropertyChanged("Student_Exemptions_Claimed");
			}
		}

		[XmlIgnore]
		public bool Student_Exemptions_ClaimedSpecified
		{
			get
			{
				return this.student_Exemptions_ClaimedFieldSpecified;
			}
			set
			{
				this.student_Exemptions_ClaimedFieldSpecified = value;
				this.RaisePropertyChanged("Student_Exemptions_ClaimedSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public decimal Student_Income_Earned_from_Work
		{
			get
			{
				return this.student_Income_Earned_from_WorkField;
			}
			set
			{
				this.student_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Student_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Student_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.student_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.student_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Student_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public decimal Spouse_Income_Earned_from_Work
		{
			get
			{
				return this.spouse_Income_Earned_from_WorkField;
			}
			set
			{
				this.spouse_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Spouse_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Spouse_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.spouse_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.spouse_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Spouse_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 42)]
		public decimal Student_Cash_Savings_and_Checking
		{
			get
			{
				return this.student_Cash_Savings_and_CheckingField;
			}
			set
			{
				this.student_Cash_Savings_and_CheckingField = value;
				this.RaisePropertyChanged("Student_Cash_Savings_and_Checking");
			}
		}

		[XmlIgnore]
		public bool Student_Cash_Savings_and_CheckingSpecified
		{
			get
			{
				return this.student_Cash_Savings_and_CheckingFieldSpecified;
			}
			set
			{
				this.student_Cash_Savings_and_CheckingFieldSpecified = value;
				this.RaisePropertyChanged("Student_Cash_Savings_and_CheckingSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public decimal Student_Investment_Net_Worth
		{
			get
			{
				return this.student_Investment_Net_WorthField;
			}
			set
			{
				this.student_Investment_Net_WorthField = value;
				this.RaisePropertyChanged("Student_Investment_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool Student_Investment_Net_WorthSpecified
		{
			get
			{
				return this.student_Investment_Net_WorthFieldSpecified;
			}
			set
			{
				this.student_Investment_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("Student_Investment_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 44)]
		public decimal Student_Business_and_or_Investment_Farm_Net_Worth
		{
			get
			{
				return this.student_Business_and_or_Investment_Farm_Net_WorthField;
			}
			set
			{
				this.student_Business_and_or_Investment_Farm_Net_WorthField = value;
				this.RaisePropertyChanged("Student_Business_and_or_Investment_Farm_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool Student_Business_and_or_Investment_Farm_Net_WorthSpecified
		{
			get
			{
				return this.student_Business_and_or_Investment_Farm_Net_WorthFieldSpecified;
			}
			set
			{
				this.student_Business_and_or_Investment_Farm_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("Student_Business_and_or_Investment_Farm_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public decimal Student_Educational_Credits
		{
			get
			{
				return this.student_Educational_CreditsField;
			}
			set
			{
				this.student_Educational_CreditsField = value;
				this.RaisePropertyChanged("Student_Educational_Credits");
			}
		}

		[XmlIgnore]
		public bool Student_Educational_CreditsSpecified
		{
			get
			{
				return this.student_Educational_CreditsFieldSpecified;
			}
			set
			{
				this.student_Educational_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Student_Educational_CreditsSpecified");
			}
		}

		[XmlElement(Order = 46)]
		public decimal Student_Child_Support_Paid
		{
			get
			{
				return this.student_Child_Support_PaidField;
			}
			set
			{
				this.student_Child_Support_PaidField = value;
				this.RaisePropertyChanged("Student_Child_Support_Paid");
			}
		}

		[XmlIgnore]
		public bool Student_Child_Support_PaidSpecified
		{
			get
			{
				return this.student_Child_Support_PaidFieldSpecified;
			}
			set
			{
				this.student_Child_Support_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Student_Child_Support_PaidSpecified");
			}
		}

		[XmlElement(Order = 47)]
		public decimal Student_Need_Based_Employment
		{
			get
			{
				return this.student_Need_Based_EmploymentField;
			}
			set
			{
				this.student_Need_Based_EmploymentField = value;
				this.RaisePropertyChanged("Student_Need_Based_Employment");
			}
		}

		[XmlIgnore]
		public bool Student_Need_Based_EmploymentSpecified
		{
			get
			{
				return this.student_Need_Based_EmploymentFieldSpecified;
			}
			set
			{
				this.student_Need_Based_EmploymentFieldSpecified = value;
				this.RaisePropertyChanged("Student_Need_Based_EmploymentSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public decimal Student_Grant_Scholarship_Aid
		{
			get
			{
				return this.student_Grant_Scholarship_AidField;
			}
			set
			{
				this.student_Grant_Scholarship_AidField = value;
				this.RaisePropertyChanged("Student_Grant_Scholarship_Aid");
			}
		}

		[XmlIgnore]
		public bool Student_Grant_Scholarship_AidSpecified
		{
			get
			{
				return this.student_Grant_Scholarship_AidFieldSpecified;
			}
			set
			{
				this.student_Grant_Scholarship_AidFieldSpecified = value;
				this.RaisePropertyChanged("Student_Grant_Scholarship_AidSpecified");
			}
		}

		[XmlElement(Order = 49)]
		public decimal Student_Combat_Pay
		{
			get
			{
				return this.student_Combat_PayField;
			}
			set
			{
				this.student_Combat_PayField = value;
				this.RaisePropertyChanged("Student_Combat_Pay");
			}
		}

		[XmlIgnore]
		public bool Student_Combat_PaySpecified
		{
			get
			{
				return this.student_Combat_PayFieldSpecified;
			}
			set
			{
				this.student_Combat_PayFieldSpecified = value;
				this.RaisePropertyChanged("Student_Combat_PaySpecified");
			}
		}

		[XmlElement(Order = 50)]
		public decimal Student_Co_op_Earnings
		{
			get
			{
				return this.student_Co_op_EarningsField;
			}
			set
			{
				this.student_Co_op_EarningsField = value;
				this.RaisePropertyChanged("Student_Co_op_Earnings");
			}
		}

		[XmlIgnore]
		public bool Student_Co_op_EarningsSpecified
		{
			get
			{
				return this.student_Co_op_EarningsFieldSpecified;
			}
			set
			{
				this.student_Co_op_EarningsFieldSpecified = value;
				this.RaisePropertyChanged("Student_Co_op_EarningsSpecified");
			}
		}

		[XmlElement(Order = 51)]
		public decimal Student_Pension_Payments
		{
			get
			{
				return this.student_Pension_PaymentsField;
			}
			set
			{
				this.student_Pension_PaymentsField = value;
				this.RaisePropertyChanged("Student_Pension_Payments");
			}
		}

		[XmlIgnore]
		public bool Student_Pension_PaymentsSpecified
		{
			get
			{
				return this.student_Pension_PaymentsFieldSpecified;
			}
			set
			{
				this.student_Pension_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Student_Pension_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 52)]
		public decimal Student_IRA_Payments
		{
			get
			{
				return this.student_IRA_PaymentsField;
			}
			set
			{
				this.student_IRA_PaymentsField = value;
				this.RaisePropertyChanged("Student_IRA_Payments");
			}
		}

		[XmlIgnore]
		public bool Student_IRA_PaymentsSpecified
		{
			get
			{
				return this.student_IRA_PaymentsFieldSpecified;
			}
			set
			{
				this.student_IRA_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Student_IRA_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 53)]
		public decimal Student_Child_Support_Received
		{
			get
			{
				return this.student_Child_Support_ReceivedField;
			}
			set
			{
				this.student_Child_Support_ReceivedField = value;
				this.RaisePropertyChanged("Student_Child_Support_Received");
			}
		}

		[XmlIgnore]
		public bool Student_Child_Support_ReceivedSpecified
		{
			get
			{
				return this.student_Child_Support_ReceivedFieldSpecified;
			}
			set
			{
				this.student_Child_Support_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Student_Child_Support_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 54)]
		public decimal Student_Interest_Income
		{
			get
			{
				return this.student_Interest_IncomeField;
			}
			set
			{
				this.student_Interest_IncomeField = value;
				this.RaisePropertyChanged("Student_Interest_Income");
			}
		}

		[XmlIgnore]
		public bool Student_Interest_IncomeSpecified
		{
			get
			{
				return this.student_Interest_IncomeFieldSpecified;
			}
			set
			{
				this.student_Interest_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("Student_Interest_IncomeSpecified");
			}
		}

		[XmlElement(Order = 55)]
		public decimal Student_IRA_Distributions
		{
			get
			{
				return this.student_IRA_DistributionsField;
			}
			set
			{
				this.student_IRA_DistributionsField = value;
				this.RaisePropertyChanged("Student_IRA_Distributions");
			}
		}

		[XmlIgnore]
		public bool Student_IRA_DistributionsSpecified
		{
			get
			{
				return this.student_IRA_DistributionsFieldSpecified;
			}
			set
			{
				this.student_IRA_DistributionsFieldSpecified = value;
				this.RaisePropertyChanged("Student_IRA_DistributionsSpecified");
			}
		}

		[XmlElement(Order = 56)]
		public decimal Student_Untaxed_Pensions
		{
			get
			{
				return this.student_Untaxed_PensionsField;
			}
			set
			{
				this.student_Untaxed_PensionsField = value;
				this.RaisePropertyChanged("Student_Untaxed_Pensions");
			}
		}

		[XmlIgnore]
		public bool Student_Untaxed_PensionsSpecified
		{
			get
			{
				return this.student_Untaxed_PensionsFieldSpecified;
			}
			set
			{
				this.student_Untaxed_PensionsFieldSpecified = value;
				this.RaisePropertyChanged("Student_Untaxed_PensionsSpecified");
			}
		}

		[XmlElement(Order = 57)]
		public decimal Student_Military_Clergy_Allowances
		{
			get
			{
				return this.student_Military_Clergy_AllowancesField;
			}
			set
			{
				this.student_Military_Clergy_AllowancesField = value;
				this.RaisePropertyChanged("Student_Military_Clergy_Allowances");
			}
		}

		[XmlIgnore]
		public bool Student_Military_Clergy_AllowancesSpecified
		{
			get
			{
				return this.student_Military_Clergy_AllowancesFieldSpecified;
			}
			set
			{
				this.student_Military_Clergy_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Student_Military_Clergy_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 58)]
		public decimal Student_Veterans_Noneducation_Benefits
		{
			get
			{
				return this.student_Veterans_Noneducation_BenefitsField;
			}
			set
			{
				this.student_Veterans_Noneducation_BenefitsField = value;
				this.RaisePropertyChanged("Student_Veterans_Noneducation_Benefits");
			}
		}

		[XmlIgnore]
		public bool Student_Veterans_Noneducation_BenefitsSpecified
		{
			get
			{
				return this.student_Veterans_Noneducation_BenefitsFieldSpecified;
			}
			set
			{
				this.student_Veterans_Noneducation_BenefitsFieldSpecified = value;
				this.RaisePropertyChanged("Student_Veterans_Noneducation_BenefitsSpecified");
			}
		}

		[XmlElement(Order = 59)]
		public decimal Student_Other_Untaxed_Income
		{
			get
			{
				return this.student_Other_Untaxed_IncomeField;
			}
			set
			{
				this.student_Other_Untaxed_IncomeField = value;
				this.RaisePropertyChanged("Student_Other_Untaxed_Income");
			}
		}

		[XmlIgnore]
		public bool Student_Other_Untaxed_IncomeSpecified
		{
			get
			{
				return this.student_Other_Untaxed_IncomeFieldSpecified;
			}
			set
			{
				this.student_Other_Untaxed_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("Student_Other_Untaxed_IncomeSpecified");
			}
		}

		[XmlElement(Order = 60)]
		public decimal Student_Other_Nonreported_Money
		{
			get
			{
				return this.student_Other_Nonreported_MoneyField;
			}
			set
			{
				this.student_Other_Nonreported_MoneyField = value;
				this.RaisePropertyChanged("Student_Other_Nonreported_Money");
			}
		}

		[XmlIgnore]
		public bool Student_Other_Nonreported_MoneySpecified
		{
			get
			{
				return this.student_Other_Nonreported_MoneyFieldSpecified;
			}
			set
			{
				this.student_Other_Nonreported_MoneyFieldSpecified = value;
				this.RaisePropertyChanged("Student_Other_Nonreported_MoneySpecified");
			}
		}

		[XmlElement(Order = 61)]
		public ISIR_ResponseObjectType Student_Born_Before_January_YYYY_Reference
		{
			get
			{
				return this.student_Born_Before_January_YYYY_ReferenceField;
			}
			set
			{
				this.student_Born_Before_January_YYYY_ReferenceField = value;
				this.RaisePropertyChanged("Student_Born_Before_January_YYYY_Reference");
			}
		}

		[XmlElement(Order = 62)]
		public ISIR_ResponseObjectType Student_Married_Reference
		{
			get
			{
				return this.student_Married_ReferenceField;
			}
			set
			{
				this.student_Married_ReferenceField = value;
				this.RaisePropertyChanged("Student_Married_Reference");
			}
		}

		[XmlElement(Order = 63)]
		public ISIR_ResponseObjectType Student_Working_on_Masters_or_Doctorate_Program_Reference
		{
			get
			{
				return this.student_Working_on_Masters_or_Doctorate_Program_ReferenceField;
			}
			set
			{
				this.student_Working_on_Masters_or_Doctorate_Program_ReferenceField = value;
				this.RaisePropertyChanged("Student_Working_on_Masters_or_Doctorate_Program_Reference");
			}
		}

		[XmlElement(Order = 64)]
		public ISIR_ResponseObjectType Student_on_Active_Duty_in_US_Armed_Forces_Reference
		{
			get
			{
				return this.student_on_Active_Duty_in_US_Armed_Forces_ReferenceField;
			}
			set
			{
				this.student_on_Active_Duty_in_US_Armed_Forces_ReferenceField = value;
				this.RaisePropertyChanged("Student_on_Active_Duty_in_US_Armed_Forces_Reference");
			}
		}

		[XmlElement(Order = 65)]
		public ISIR_ResponseObjectType Student_Veteran_of_US_Armed_Forces_Reference
		{
			get
			{
				return this.student_Veteran_of_US_Armed_Forces_ReferenceField;
			}
			set
			{
				this.student_Veteran_of_US_Armed_Forces_ReferenceField = value;
				this.RaisePropertyChanged("Student_Veteran_of_US_Armed_Forces_Reference");
			}
		}

		[XmlElement(Order = 66)]
		public ISIR_ResponseObjectType Student_Have_Children_they_Support_Reference
		{
			get
			{
				return this.student_Have_Children_they_Support_ReferenceField;
			}
			set
			{
				this.student_Have_Children_they_Support_ReferenceField = value;
				this.RaisePropertyChanged("Student_Have_Children_they_Support_Reference");
			}
		}

		[XmlElement(Order = 67)]
		public ISIR_ResponseObjectType Student_Has_Legal_Dependents_Other_than_Children_or_Spouse_Reference
		{
			get
			{
				return this.student_Has_Legal_Dependents_Other_than_Children_or_Spouse_ReferenceField;
			}
			set
			{
				this.student_Has_Legal_Dependents_Other_than_Children_or_Spouse_ReferenceField = value;
				this.RaisePropertyChanged("Student_Has_Legal_Dependents_Other_than_Children_or_Spouse_Reference");
			}
		}

		[XmlElement(Order = 68)]
		public ISIR_ResponseObjectType Student_Orphan_Ward_of_Court_or_Foster_Care_Reference
		{
			get
			{
				return this.student_Orphan_Ward_of_Court_or_Foster_Care_ReferenceField;
			}
			set
			{
				this.student_Orphan_Ward_of_Court_or_Foster_Care_ReferenceField = value;
				this.RaisePropertyChanged("Student_Orphan_Ward_of_Court_or_Foster_Care_Reference");
			}
		}

		[XmlElement(Order = 69)]
		public ISIR_ResponseObjectType Student_Emancipated_Minor_Reference
		{
			get
			{
				return this.student_Emancipated_Minor_ReferenceField;
			}
			set
			{
				this.student_Emancipated_Minor_ReferenceField = value;
				this.RaisePropertyChanged("Student_Emancipated_Minor_Reference");
			}
		}

		[XmlElement(Order = 70)]
		public ISIR_ResponseObjectType Student_in_legal_guardianship_Reference
		{
			get
			{
				return this.student_in_legal_guardianship_ReferenceField;
			}
			set
			{
				this.student_in_legal_guardianship_ReferenceField = value;
				this.RaisePropertyChanged("Student_in_legal_guardianship_Reference");
			}
		}

		[XmlElement(Order = 71)]
		public ISIR_ResponseObjectType Student_Unaccompanied_youth_determined_by_school_district_liaison_Reference
		{
			get
			{
				return this.student_Unaccompanied_youth_determined_by_school_district_liaison_ReferenceField;
			}
			set
			{
				this.student_Unaccompanied_youth_determined_by_school_district_liaison_ReferenceField = value;
				this.RaisePropertyChanged("Student_Unaccompanied_youth_determined_by_school_district_liaison_Reference");
			}
		}

		[XmlElement(Order = 72)]
		public ISIR_ResponseObjectType Student_Unaccompanied_youth_determined_by_HUD_Reference
		{
			get
			{
				return this.student_Unaccompanied_youth_determined_by_HUD_ReferenceField;
			}
			set
			{
				this.student_Unaccompanied_youth_determined_by_HUD_ReferenceField = value;
				this.RaisePropertyChanged("Student_Unaccompanied_youth_determined_by_HUD_Reference");
			}
		}

		[XmlElement(Order = 73)]
		public ISIR_ResponseObjectType Student_At_risk_of_homelessness_Reference
		{
			get
			{
				return this.student_At_risk_of_homelessness_ReferenceField;
			}
			set
			{
				this.student_At_risk_of_homelessness_ReferenceField = value;
				this.RaisePropertyChanged("Student_At_risk_of_homelessness_Reference");
			}
		}

		[XmlElement(Order = 74)]
		public ISIR_Parent_Marital_StatusObjectType Parents_Marital_Status_Reference
		{
			get
			{
				return this.parents_Marital_Status_ReferenceField;
			}
			set
			{
				this.parents_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Marital_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 75)]
		public DateTime Parents_Marital_Status_Date
		{
			get
			{
				return this.parents_Marital_Status_DateField;
			}
			set
			{
				this.parents_Marital_Status_DateField = value;
				this.RaisePropertyChanged("Parents_Marital_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Parents_Marital_Status_DateSpecified
		{
			get
			{
				return this.parents_Marital_Status_DateFieldSpecified;
			}
			set
			{
				this.parents_Marital_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Marital_Status_DateSpecified");
			}
		}

		[XmlElement(Order = 76)]
		public string Parent_1_Social_Security_Number
		{
			get
			{
				return this.parent_1_Social_Security_NumberField;
			}
			set
			{
				this.parent_1_Social_Security_NumberField = value;
				this.RaisePropertyChanged("Parent_1_Social_Security_Number");
			}
		}

		[XmlElement(Order = 77)]
		public string Parent_1_Last_Name
		{
			get
			{
				return this.parent_1_Last_NameField;
			}
			set
			{
				this.parent_1_Last_NameField = value;
				this.RaisePropertyChanged("Parent_1_Last_Name");
			}
		}

		[XmlElement(Order = 78)]
		public string Parent_1_First_Name_Initial
		{
			get
			{
				return this.parent_1_First_Name_InitialField;
			}
			set
			{
				this.parent_1_First_Name_InitialField = value;
				this.RaisePropertyChanged("Parent_1_First_Name_Initial");
			}
		}

		[XmlElement(DataType = "date", Order = 79)]
		public DateTime Parent_1_Date_of_Birth
		{
			get
			{
				return this.parent_1_Date_of_BirthField;
			}
			set
			{
				this.parent_1_Date_of_BirthField = value;
				this.RaisePropertyChanged("Parent_1_Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Parent_1_Date_of_BirthSpecified
		{
			get
			{
				return this.parent_1_Date_of_BirthFieldSpecified;
			}
			set
			{
				this.parent_1_Date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Parent_1_Date_of_BirthSpecified");
			}
		}

		[XmlElement(Order = 80)]
		public string Parent_2_Social_Security_Number
		{
			get
			{
				return this.parent_2_Social_Security_NumberField;
			}
			set
			{
				this.parent_2_Social_Security_NumberField = value;
				this.RaisePropertyChanged("Parent_2_Social_Security_Number");
			}
		}

		[XmlElement(Order = 81)]
		public string Parent_2_Last_Name
		{
			get
			{
				return this.parent_2_Last_NameField;
			}
			set
			{
				this.parent_2_Last_NameField = value;
				this.RaisePropertyChanged("Parent_2_Last_Name");
			}
		}

		[XmlElement(Order = 82)]
		public string Parent_2_First_Name_Initial
		{
			get
			{
				return this.parent_2_First_Name_InitialField;
			}
			set
			{
				this.parent_2_First_Name_InitialField = value;
				this.RaisePropertyChanged("Parent_2_First_Name_Initial");
			}
		}

		[XmlElement(DataType = "date", Order = 83)]
		public DateTime Parent_2_Date_of_Birth
		{
			get
			{
				return this.parent_2_Date_of_BirthField;
			}
			set
			{
				this.parent_2_Date_of_BirthField = value;
				this.RaisePropertyChanged("Parent_2_Date_of_Birth");
			}
		}

		[XmlIgnore]
		public bool Parent_2_Date_of_BirthSpecified
		{
			get
			{
				return this.parent_2_Date_of_BirthFieldSpecified;
			}
			set
			{
				this.parent_2_Date_of_BirthFieldSpecified = value;
				this.RaisePropertyChanged("Parent_2_Date_of_BirthSpecified");
			}
		}

		[XmlElement(Order = 84)]
		public string Parents_Email_Address
		{
			get
			{
				return this.parents_Email_AddressField;
			}
			set
			{
				this.parents_Email_AddressField = value;
				this.RaisePropertyChanged("Parents_Email_Address");
			}
		}

		[XmlElement(Order = 85)]
		public ISIR_Location_ContextObjectType Parents_State_of_Legal_Residence_Reference
		{
			get
			{
				return this.parents_State_of_Legal_Residence_ReferenceField;
			}
			set
			{
				this.parents_State_of_Legal_Residence_ReferenceField = value;
				this.RaisePropertyChanged("Parents_State_of_Legal_Residence_Reference");
			}
		}

		[XmlElement(Order = 86)]
		public ISIR_ResponseObjectType Parents_Legal_Residents_before_January_YYYY_Reference
		{
			get
			{
				return this.parents_Legal_Residents_before_January_YYYY_ReferenceField;
			}
			set
			{
				this.parents_Legal_Residents_before_January_YYYY_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Legal_Residents_before_January_YYYY_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 87)]
		public DateTime Parents_Legal_Residence_Date
		{
			get
			{
				return this.parents_Legal_Residence_DateField;
			}
			set
			{
				this.parents_Legal_Residence_DateField = value;
				this.RaisePropertyChanged("Parents_Legal_Residence_Date");
			}
		}

		[XmlIgnore]
		public bool Parents_Legal_Residence_DateSpecified
		{
			get
			{
				return this.parents_Legal_Residence_DateFieldSpecified;
			}
			set
			{
				this.parents_Legal_Residence_DateFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Legal_Residence_DateSpecified");
			}
		}

		[XmlElement(Order = 88)]
		public decimal Parents_Number_of_Family_Members
		{
			get
			{
				return this.parents_Number_of_Family_MembersField;
			}
			set
			{
				this.parents_Number_of_Family_MembersField = value;
				this.RaisePropertyChanged("Parents_Number_of_Family_Members");
			}
		}

		[XmlIgnore]
		public bool Parents_Number_of_Family_MembersSpecified
		{
			get
			{
				return this.parents_Number_of_Family_MembersFieldSpecified;
			}
			set
			{
				this.parents_Number_of_Family_MembersFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Number_of_Family_MembersSpecified");
			}
		}

		[XmlElement(Order = 89)]
		public decimal Parents_Number_in_College_Parents_Excluded
		{
			get
			{
				return this.parents_Number_in_College_Parents_ExcludedField;
			}
			set
			{
				this.parents_Number_in_College_Parents_ExcludedField = value;
				this.RaisePropertyChanged("Parents_Number_in_College_Parents_Excluded");
			}
		}

		[XmlIgnore]
		public bool Parents_Number_in_College_Parents_ExcludedSpecified
		{
			get
			{
				return this.parents_Number_in_College_Parents_ExcludedFieldSpecified;
			}
			set
			{
				this.parents_Number_in_College_Parents_ExcludedFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Number_in_College_Parents_ExcludedSpecified");
			}
		}

		[XmlElement(Order = 90)]
		public ISIR_ResponseObjectType Parent_Supplemental_Security_Income_Benefits_Reference
		{
			get
			{
				return this.parent_Supplemental_Security_Income_Benefits_ReferenceField;
			}
			set
			{
				this.parent_Supplemental_Security_Income_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Supplemental_Security_Income_Benefits_Reference");
			}
		}

		[XmlElement(Order = 91)]
		public ISIR_ResponseObjectType Parent_Supplemental_Nutrition_Assistance_Program_SNAP_Reference
		{
			get
			{
				return this.parent_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField;
			}
			set
			{
				this.parent_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Supplemental_Nutrition_Assistance_Program_SNAP_Reference");
			}
		}

		[XmlElement("Parent_Free_or_Reduced_Price_School_Lunch_Benefits_Reference", Order = 92)]
		public ISIR_ResponseObjectType[] Parent_Free_or_Reduced_Price_School_Lunch_Benefits_Reference
		{
			get
			{
				return this.parent_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField;
			}
			set
			{
				this.parent_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Free_or_Reduced_Price_School_Lunch_Benefits_Reference");
			}
		}

		[XmlElement(Order = 93)]
		public ISIR_ResponseObjectType Parent_TANF_Benefits_Reference
		{
			get
			{
				return this.parent_TANF_Benefits_ReferenceField;
			}
			set
			{
				this.parent_TANF_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Parent_TANF_Benefits_Reference");
			}
		}

		[XmlElement(Order = 94)]
		public ISIR_ResponseObjectType Parent_WIC_Benefits_Reference
		{
			get
			{
				return this.parent_WIC_Benefits_ReferenceField;
			}
			set
			{
				this.parent_WIC_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Parent_WIC_Benefits_Reference");
			}
		}

		[XmlElement(Order = 95)]
		public ISIR_Tax_Return_StatusObjectType Parents_Tax_Return_Status_Reference
		{
			get
			{
				return this.parents_Tax_Return_Status_ReferenceField;
			}
			set
			{
				this.parents_Tax_Return_Status_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Tax_Return_Status_Reference");
			}
		}

		[XmlElement(Order = 96)]
		public Financial_Aid_Type_of_Prior_Year_Tax_Form_UsedObjectType Parents_Type_of_Prior_Year_Tax_Form_Used_Reference
		{
			get
			{
				return this.parents_Type_of_Prior_Year_Tax_Form_Used_ReferenceField;
			}
			set
			{
				this.parents_Type_of_Prior_Year_Tax_Form_Used_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Type_of_Prior_Year_Tax_Form_Used_Reference");
			}
		}

		[XmlElement(Order = 97)]
		public Financial_Aid_Tax_Return_Filing_StatusObjectType Parents_Tax_Return_Filing_Status_Reference
		{
			get
			{
				return this.parents_Tax_Return_Filing_Status_ReferenceField;
			}
			set
			{
				this.parents_Tax_Return_Filing_Status_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Tax_Return_Filing_Status_Reference");
			}
		}

		[XmlElement(Order = 98)]
		public ISIR_ResponseObjectType Parents_Eligible_to_file_1040A_or_1040EZ_Reference
		{
			get
			{
				return this.parents_Eligible_to_file_1040A_or_1040EZ_ReferenceField;
			}
			set
			{
				this.parents_Eligible_to_file_1040A_or_1040EZ_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Eligible_to_file_1040A_or_1040EZ_Reference");
			}
		}

		[XmlElement(Order = 99)]
		public ISIR_ResponseObjectType Parent_Dislocated_Worker_Reference
		{
			get
			{
				return this.parent_Dislocated_Worker_ReferenceField;
			}
			set
			{
				this.parent_Dislocated_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Dislocated_Worker_Reference");
			}
		}

		[XmlElement(Order = 100)]
		public decimal Parents_Adjusted_Gross_Income_from_IRS_Form
		{
			get
			{
				return this.parents_Adjusted_Gross_Income_from_IRS_FormField;
			}
			set
			{
				this.parents_Adjusted_Gross_Income_from_IRS_FormField = value;
				this.RaisePropertyChanged("Parents_Adjusted_Gross_Income_from_IRS_Form");
			}
		}

		[XmlIgnore]
		public bool Parents_Adjusted_Gross_Income_from_IRS_FormSpecified
		{
			get
			{
				return this.parents_Adjusted_Gross_Income_from_IRS_FormFieldSpecified;
			}
			set
			{
				this.parents_Adjusted_Gross_Income_from_IRS_FormFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Adjusted_Gross_Income_from_IRS_FormSpecified");
			}
		}

		[XmlElement(Order = 101)]
		public decimal Parents_US_Income_Tax_Paid
		{
			get
			{
				return this.parents_US_Income_Tax_PaidField;
			}
			set
			{
				this.parents_US_Income_Tax_PaidField = value;
				this.RaisePropertyChanged("Parents_US_Income_Tax_Paid");
			}
		}

		[XmlIgnore]
		public bool Parents_US_Income_Tax_PaidSpecified
		{
			get
			{
				return this.parents_US_Income_Tax_PaidFieldSpecified;
			}
			set
			{
				this.parents_US_Income_Tax_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Parents_US_Income_Tax_PaidSpecified");
			}
		}

		[XmlElement(Order = 102)]
		public decimal Parents_Exemptions_Claimed
		{
			get
			{
				return this.parents_Exemptions_ClaimedField;
			}
			set
			{
				this.parents_Exemptions_ClaimedField = value;
				this.RaisePropertyChanged("Parents_Exemptions_Claimed");
			}
		}

		[XmlIgnore]
		public bool Parents_Exemptions_ClaimedSpecified
		{
			get
			{
				return this.parents_Exemptions_ClaimedFieldSpecified;
			}
			set
			{
				this.parents_Exemptions_ClaimedFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Exemptions_ClaimedSpecified");
			}
		}

		[XmlElement(Order = 103)]
		public decimal Parent_1_Income_Earned_from_Work
		{
			get
			{
				return this.parent_1_Income_Earned_from_WorkField;
			}
			set
			{
				this.parent_1_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Parent_1_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Parent_1_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.parent_1_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.parent_1_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Parent_1_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 104)]
		public decimal Parent_2_Income_Earned_from_Work
		{
			get
			{
				return this.parent_2_Income_Earned_from_WorkField;
			}
			set
			{
				this.parent_2_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Parent_2_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Parent_2_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.parent_2_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.parent_2_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Parent_2_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 105)]
		public decimal Parents_Cash_Savings_and_Checking
		{
			get
			{
				return this.parents_Cash_Savings_and_CheckingField;
			}
			set
			{
				this.parents_Cash_Savings_and_CheckingField = value;
				this.RaisePropertyChanged("Parents_Cash_Savings_and_Checking");
			}
		}

		[XmlIgnore]
		public bool Parents_Cash_Savings_and_CheckingSpecified
		{
			get
			{
				return this.parents_Cash_Savings_and_CheckingFieldSpecified;
			}
			set
			{
				this.parents_Cash_Savings_and_CheckingFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Cash_Savings_and_CheckingSpecified");
			}
		}

		[XmlElement(Order = 106)]
		public decimal Parents_Investment_Net_Worth
		{
			get
			{
				return this.parents_Investment_Net_WorthField;
			}
			set
			{
				this.parents_Investment_Net_WorthField = value;
				this.RaisePropertyChanged("Parents_Investment_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool Parents_Investment_Net_WorthSpecified
		{
			get
			{
				return this.parents_Investment_Net_WorthFieldSpecified;
			}
			set
			{
				this.parents_Investment_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Investment_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 107)]
		public decimal Parents_Business_and_or_Investment_Farm_Net_Worth
		{
			get
			{
				return this.parents_Business_and_or_Investment_Farm_Net_WorthField;
			}
			set
			{
				this.parents_Business_and_or_Investment_Farm_Net_WorthField = value;
				this.RaisePropertyChanged("Parents_Business_and_or_Investment_Farm_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool Parents_Business_and_or_Investment_Farm_Net_WorthSpecified
		{
			get
			{
				return this.parents_Business_and_or_Investment_Farm_Net_WorthFieldSpecified;
			}
			set
			{
				this.parents_Business_and_or_Investment_Farm_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Business_and_or_Investment_Farm_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 108)]
		public decimal Parents_Educational_Credits
		{
			get
			{
				return this.parents_Educational_CreditsField;
			}
			set
			{
				this.parents_Educational_CreditsField = value;
				this.RaisePropertyChanged("Parents_Educational_Credits");
			}
		}

		[XmlIgnore]
		public bool Parents_Educational_CreditsSpecified
		{
			get
			{
				return this.parents_Educational_CreditsFieldSpecified;
			}
			set
			{
				this.parents_Educational_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Educational_CreditsSpecified");
			}
		}

		[XmlElement(Order = 109)]
		public decimal Parents_Child_Support_Paid
		{
			get
			{
				return this.parents_Child_Support_PaidField;
			}
			set
			{
				this.parents_Child_Support_PaidField = value;
				this.RaisePropertyChanged("Parents_Child_Support_Paid");
			}
		}

		[XmlIgnore]
		public bool Parents_Child_Support_PaidSpecified
		{
			get
			{
				return this.parents_Child_Support_PaidFieldSpecified;
			}
			set
			{
				this.parents_Child_Support_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Child_Support_PaidSpecified");
			}
		}

		[XmlElement(Order = 110)]
		public decimal Parents_Need_Based_Employment
		{
			get
			{
				return this.parents_Need_Based_EmploymentField;
			}
			set
			{
				this.parents_Need_Based_EmploymentField = value;
				this.RaisePropertyChanged("Parents_Need_Based_Employment");
			}
		}

		[XmlIgnore]
		public bool Parents_Need_Based_EmploymentSpecified
		{
			get
			{
				return this.parents_Need_Based_EmploymentFieldSpecified;
			}
			set
			{
				this.parents_Need_Based_EmploymentFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Need_Based_EmploymentSpecified");
			}
		}

		[XmlElement(Order = 111)]
		public decimal Parents_Grant_Scholarship_Aid
		{
			get
			{
				return this.parents_Grant_Scholarship_AidField;
			}
			set
			{
				this.parents_Grant_Scholarship_AidField = value;
				this.RaisePropertyChanged("Parents_Grant_Scholarship_Aid");
			}
		}

		[XmlIgnore]
		public bool Parents_Grant_Scholarship_AidSpecified
		{
			get
			{
				return this.parents_Grant_Scholarship_AidFieldSpecified;
			}
			set
			{
				this.parents_Grant_Scholarship_AidFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Grant_Scholarship_AidSpecified");
			}
		}

		[XmlElement(Order = 112)]
		public decimal Parents_Combat_Pay
		{
			get
			{
				return this.parents_Combat_PayField;
			}
			set
			{
				this.parents_Combat_PayField = value;
				this.RaisePropertyChanged("Parents_Combat_Pay");
			}
		}

		[XmlIgnore]
		public bool Parents_Combat_PaySpecified
		{
			get
			{
				return this.parents_Combat_PayFieldSpecified;
			}
			set
			{
				this.parents_Combat_PayFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Combat_PaySpecified");
			}
		}

		[XmlElement(Order = 113)]
		public decimal Parents_Co_op_Earnings
		{
			get
			{
				return this.parents_Co_op_EarningsField;
			}
			set
			{
				this.parents_Co_op_EarningsField = value;
				this.RaisePropertyChanged("Parents_Co_op_Earnings");
			}
		}

		[XmlIgnore]
		public bool Parents_Co_op_EarningsSpecified
		{
			get
			{
				return this.parents_Co_op_EarningsFieldSpecified;
			}
			set
			{
				this.parents_Co_op_EarningsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Co_op_EarningsSpecified");
			}
		}

		[XmlElement(Order = 114)]
		public decimal Parents_Pension_Payments
		{
			get
			{
				return this.parents_Pension_PaymentsField;
			}
			set
			{
				this.parents_Pension_PaymentsField = value;
				this.RaisePropertyChanged("Parents_Pension_Payments");
			}
		}

		[XmlIgnore]
		public bool Parents_Pension_PaymentsSpecified
		{
			get
			{
				return this.parents_Pension_PaymentsFieldSpecified;
			}
			set
			{
				this.parents_Pension_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Pension_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 115)]
		public decimal Parents_IRA_Payments
		{
			get
			{
				return this.parents_IRA_PaymentsField;
			}
			set
			{
				this.parents_IRA_PaymentsField = value;
				this.RaisePropertyChanged("Parents_IRA_Payments");
			}
		}

		[XmlIgnore]
		public bool Parents_IRA_PaymentsSpecified
		{
			get
			{
				return this.parents_IRA_PaymentsFieldSpecified;
			}
			set
			{
				this.parents_IRA_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_IRA_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 116)]
		public decimal Parents_Child_Support_Received
		{
			get
			{
				return this.parents_Child_Support_ReceivedField;
			}
			set
			{
				this.parents_Child_Support_ReceivedField = value;
				this.RaisePropertyChanged("Parents_Child_Support_Received");
			}
		}

		[XmlIgnore]
		public bool Parents_Child_Support_ReceivedSpecified
		{
			get
			{
				return this.parents_Child_Support_ReceivedFieldSpecified;
			}
			set
			{
				this.parents_Child_Support_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Child_Support_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 117)]
		public decimal Parents_Interest_Income
		{
			get
			{
				return this.parents_Interest_IncomeField;
			}
			set
			{
				this.parents_Interest_IncomeField = value;
				this.RaisePropertyChanged("Parents_Interest_Income");
			}
		}

		[XmlIgnore]
		public bool Parents_Interest_IncomeSpecified
		{
			get
			{
				return this.parents_Interest_IncomeFieldSpecified;
			}
			set
			{
				this.parents_Interest_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Interest_IncomeSpecified");
			}
		}

		[XmlElement(Order = 118)]
		public decimal Parents_IRA_Distributions
		{
			get
			{
				return this.parents_IRA_DistributionsField;
			}
			set
			{
				this.parents_IRA_DistributionsField = value;
				this.RaisePropertyChanged("Parents_IRA_Distributions");
			}
		}

		[XmlIgnore]
		public bool Parents_IRA_DistributionsSpecified
		{
			get
			{
				return this.parents_IRA_DistributionsFieldSpecified;
			}
			set
			{
				this.parents_IRA_DistributionsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_IRA_DistributionsSpecified");
			}
		}

		[XmlElement(Order = 119)]
		public decimal Parents_Untaxed_Pensions
		{
			get
			{
				return this.parents_Untaxed_PensionsField;
			}
			set
			{
				this.parents_Untaxed_PensionsField = value;
				this.RaisePropertyChanged("Parents_Untaxed_Pensions");
			}
		}

		[XmlIgnore]
		public bool Parents_Untaxed_PensionsSpecified
		{
			get
			{
				return this.parents_Untaxed_PensionsFieldSpecified;
			}
			set
			{
				this.parents_Untaxed_PensionsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Untaxed_PensionsSpecified");
			}
		}

		[XmlElement(Order = 120)]
		public decimal Parents_Military_Clergy_Allowances
		{
			get
			{
				return this.parents_Military_Clergy_AllowancesField;
			}
			set
			{
				this.parents_Military_Clergy_AllowancesField = value;
				this.RaisePropertyChanged("Parents_Military_Clergy_Allowances");
			}
		}

		[XmlIgnore]
		public bool Parents_Military_Clergy_AllowancesSpecified
		{
			get
			{
				return this.parents_Military_Clergy_AllowancesFieldSpecified;
			}
			set
			{
				this.parents_Military_Clergy_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Military_Clergy_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 121)]
		public decimal Parents_Veterans_Noneducation_Benefits
		{
			get
			{
				return this.parents_Veterans_Noneducation_BenefitsField;
			}
			set
			{
				this.parents_Veterans_Noneducation_BenefitsField = value;
				this.RaisePropertyChanged("Parents_Veterans_Noneducation_Benefits");
			}
		}

		[XmlIgnore]
		public bool Parents_Veterans_Noneducation_BenefitsSpecified
		{
			get
			{
				return this.parents_Veterans_Noneducation_BenefitsFieldSpecified;
			}
			set
			{
				this.parents_Veterans_Noneducation_BenefitsFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Veterans_Noneducation_BenefitsSpecified");
			}
		}

		[XmlElement(Order = 122)]
		public decimal Parents_Other_Untaxed_Income
		{
			get
			{
				return this.parents_Other_Untaxed_IncomeField;
			}
			set
			{
				this.parents_Other_Untaxed_IncomeField = value;
				this.RaisePropertyChanged("Parents_Other_Untaxed_Income");
			}
		}

		[XmlIgnore]
		public bool Parents_Other_Untaxed_IncomeSpecified
		{
			get
			{
				return this.parents_Other_Untaxed_IncomeFieldSpecified;
			}
			set
			{
				this.parents_Other_Untaxed_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Other_Untaxed_IncomeSpecified");
			}
		}

		[XmlElement(Order = 123)]
		public decimal Student_Number_of_Family_Members
		{
			get
			{
				return this.student_Number_of_Family_MembersField;
			}
			set
			{
				this.student_Number_of_Family_MembersField = value;
				this.RaisePropertyChanged("Student_Number_of_Family_Members");
			}
		}

		[XmlIgnore]
		public bool Student_Number_of_Family_MembersSpecified
		{
			get
			{
				return this.student_Number_of_Family_MembersFieldSpecified;
			}
			set
			{
				this.student_Number_of_Family_MembersFieldSpecified = value;
				this.RaisePropertyChanged("Student_Number_of_Family_MembersSpecified");
			}
		}

		[XmlElement(Order = 124)]
		public decimal Student_Number_in_College
		{
			get
			{
				return this.student_Number_in_CollegeField;
			}
			set
			{
				this.student_Number_in_CollegeField = value;
				this.RaisePropertyChanged("Student_Number_in_College");
			}
		}

		[XmlIgnore]
		public bool Student_Number_in_CollegeSpecified
		{
			get
			{
				return this.student_Number_in_CollegeFieldSpecified;
			}
			set
			{
				this.student_Number_in_CollegeFieldSpecified = value;
				this.RaisePropertyChanged("Student_Number_in_CollegeSpecified");
			}
		}

		[XmlElement(Order = 125)]
		public ISIR_ResponseObjectType Student_Supplemental_Security_Income_Benefits_Reference
		{
			get
			{
				return this.student_Supplemental_Security_Income_Benefits_ReferenceField;
			}
			set
			{
				this.student_Supplemental_Security_Income_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Student_Supplemental_Security_Income_Benefits_Reference");
			}
		}

		[XmlElement(Order = 126)]
		public ISIR_ResponseObjectType Student_Supplemental_Nutrition_Assistance_Program_SNAP_Reference
		{
			get
			{
				return this.student_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField;
			}
			set
			{
				this.student_Supplemental_Nutrition_Assistance_Program_SNAP_ReferenceField = value;
				this.RaisePropertyChanged("Student_Supplemental_Nutrition_Assistance_Program_SNAP_Reference");
			}
		}

		[XmlElement(Order = 127)]
		public ISIR_ResponseObjectType Student_Free_or_Reduced_Price_School_Lunch_Benefits_Reference
		{
			get
			{
				return this.student_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField;
			}
			set
			{
				this.student_Free_or_Reduced_Price_School_Lunch_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Student_Free_or_Reduced_Price_School_Lunch_Benefits_Reference");
			}
		}

		[XmlElement(Order = 128)]
		public ISIR_ResponseObjectType Student_TANF_Benefits_Reference
		{
			get
			{
				return this.student_TANF_Benefits_ReferenceField;
			}
			set
			{
				this.student_TANF_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Student_TANF_Benefits_Reference");
			}
		}

		[XmlElement(Order = 129)]
		public ISIR_ResponseObjectType Student_WIC_Benefits_Reference
		{
			get
			{
				return this.student_WIC_Benefits_ReferenceField;
			}
			set
			{
				this.student_WIC_Benefits_ReferenceField = value;
				this.RaisePropertyChanged("Student_WIC_Benefits_Reference");
			}
		}

		[XmlElement(Order = 130)]
		public ISIR_ResponseObjectType Student_Spouse_Dislocated_Worker_Reference
		{
			get
			{
				return this.student_Spouse_Dislocated_Worker_ReferenceField;
			}
			set
			{
				this.student_Spouse_Dislocated_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Student_Spouse_Dislocated_Worker_Reference");
			}
		}

		[XmlElement(Order = 131)]
		public School_Code_Housing_PlanObjectType Federal_School_Code_1_Housing_Plans_Reference
		{
			get
			{
				return this.federal_School_Code_1_Housing_Plans_ReferenceField;
			}
			set
			{
				this.federal_School_Code_1_Housing_Plans_ReferenceField = value;
				this.RaisePropertyChanged("Federal_School_Code_1_Housing_Plans_Reference");
			}
		}

		[XmlElement(Order = 132)]
		public ISIR_Signed_ByObjectType Signed_By_Reference
		{
			get
			{
				return this.signed_By_ReferenceField;
			}
			set
			{
				this.signed_By_ReferenceField = value;
				this.RaisePropertyChanged("Signed_By_Reference");
			}
		}

		[XmlElement(Order = 133)]
		public string Preparer_Social_Security_Number
		{
			get
			{
				return this.preparer_Social_Security_NumberField;
			}
			set
			{
				this.preparer_Social_Security_NumberField = value;
				this.RaisePropertyChanged("Preparer_Social_Security_Number");
			}
		}

		[XmlElement(Order = 134)]
		public string Preparer_Employer_Identification_Number
		{
			get
			{
				return this.preparer_Employer_Identification_NumberField;
			}
			set
			{
				this.preparer_Employer_Identification_NumberField = value;
				this.RaisePropertyChanged("Preparer_Employer_Identification_Number");
			}
		}

		[XmlElement(Order = 135)]
		public bool Preparers_Signature
		{
			get
			{
				return this.preparers_SignatureField;
			}
			set
			{
				this.preparers_SignatureField = value;
				this.RaisePropertyChanged("Preparers_Signature");
			}
		}

		[XmlIgnore]
		public bool Preparers_SignatureSpecified
		{
			get
			{
				return this.preparers_SignatureFieldSpecified;
			}
			set
			{
				this.preparers_SignatureFieldSpecified = value;
				this.RaisePropertyChanged("Preparers_SignatureSpecified");
			}
		}

		[XmlElement(Order = 136)]
		public ISIR_Dependency_Override_IndicatorObjectType Dependency_Override_Indicator_Reference
		{
			get
			{
				return this.dependency_Override_Indicator_ReferenceField;
			}
			set
			{
				this.dependency_Override_Indicator_ReferenceField = value;
				this.RaisePropertyChanged("Dependency_Override_Indicator_Reference");
			}
		}

		[XmlElement(Order = 137)]
		public ISIR_AGI_and_FIT_Data_Field_FlagObjectType IRS_Student_Adjusted_Gross_Income_AGI_Data_Field_Flag_Reference
		{
			get
			{
				return this.iRS_Student_Adjusted_Gross_Income_AGI_Data_Field_Flag_ReferenceField;
			}
			set
			{
				this.iRS_Student_Adjusted_Gross_Income_AGI_Data_Field_Flag_ReferenceField = value;
				this.RaisePropertyChanged("IRS_Student_Adjusted_Gross_Income_AGI_Data_Field_Flag_Reference");
			}
		}

		[XmlElement(Order = 138)]
		public bool Assumption_Override_1
		{
			get
			{
				return this.assumption_Override_1Field;
			}
			set
			{
				this.assumption_Override_1Field = value;
				this.RaisePropertyChanged("Assumption_Override_1");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_1Specified
		{
			get
			{
				return this.assumption_Override_1FieldSpecified;
			}
			set
			{
				this.assumption_Override_1FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_1Specified");
			}
		}

		[XmlElement(Order = 139)]
		public bool Assumption_Override_2
		{
			get
			{
				return this.assumption_Override_2Field;
			}
			set
			{
				this.assumption_Override_2Field = value;
				this.RaisePropertyChanged("Assumption_Override_2");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_2Specified
		{
			get
			{
				return this.assumption_Override_2FieldSpecified;
			}
			set
			{
				this.assumption_Override_2FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_2Specified");
			}
		}

		[XmlElement(Order = 140)]
		public bool Assumption_Override_3
		{
			get
			{
				return this.assumption_Override_3Field;
			}
			set
			{
				this.assumption_Override_3Field = value;
				this.RaisePropertyChanged("Assumption_Override_3");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_3Specified
		{
			get
			{
				return this.assumption_Override_3FieldSpecified;
			}
			set
			{
				this.assumption_Override_3FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_3Specified");
			}
		}

		[XmlElement(Order = 141)]
		public bool Assumption_Override_4
		{
			get
			{
				return this.assumption_Override_4Field;
			}
			set
			{
				this.assumption_Override_4Field = value;
				this.RaisePropertyChanged("Assumption_Override_4");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_4Specified
		{
			get
			{
				return this.assumption_Override_4FieldSpecified;
			}
			set
			{
				this.assumption_Override_4FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_4Specified");
			}
		}

		[XmlElement(Order = 142)]
		public bool Assumption_Override_5
		{
			get
			{
				return this.assumption_Override_5Field;
			}
			set
			{
				this.assumption_Override_5Field = value;
				this.RaisePropertyChanged("Assumption_Override_5");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_5Specified
		{
			get
			{
				return this.assumption_Override_5FieldSpecified;
			}
			set
			{
				this.assumption_Override_5FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_5Specified");
			}
		}

		[XmlElement(Order = 143)]
		public bool Assumption_Override_6
		{
			get
			{
				return this.assumption_Override_6Field;
			}
			set
			{
				this.assumption_Override_6Field = value;
				this.RaisePropertyChanged("Assumption_Override_6");
			}
		}

		[XmlIgnore]
		public bool Assumption_Override_6Specified
		{
			get
			{
				return this.assumption_Override_6FieldSpecified;
			}
			set
			{
				this.assumption_Override_6FieldSpecified = value;
				this.RaisePropertyChanged("Assumption_Override_6Specified");
			}
		}

		[XmlElement(Order = 144)]
		public bool Reject_Override_3
		{
			get
			{
				return this.reject_Override_3Field;
			}
			set
			{
				this.reject_Override_3Field = value;
				this.RaisePropertyChanged("Reject_Override_3");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_3Specified
		{
			get
			{
				return this.reject_Override_3FieldSpecified;
			}
			set
			{
				this.reject_Override_3FieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_3Specified");
			}
		}

		[XmlElement(Order = 145)]
		public bool Reject_Override_12
		{
			get
			{
				return this.reject_Override_12Field;
			}
			set
			{
				this.reject_Override_12Field = value;
				this.RaisePropertyChanged("Reject_Override_12");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_12Specified
		{
			get
			{
				return this.reject_Override_12FieldSpecified;
			}
			set
			{
				this.reject_Override_12FieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_12Specified");
			}
		}

		[XmlElement(Order = 146)]
		public bool Reject_Override_20
		{
			get
			{
				return this.reject_Override_20Field;
			}
			set
			{
				this.reject_Override_20Field = value;
				this.RaisePropertyChanged("Reject_Override_20");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_20Specified
		{
			get
			{
				return this.reject_Override_20FieldSpecified;
			}
			set
			{
				this.reject_Override_20FieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_20Specified");
			}
		}

		[XmlElement(Order = 147)]
		public bool Reject_Override_A
		{
			get
			{
				return this.reject_Override_AField;
			}
			set
			{
				this.reject_Override_AField = value;
				this.RaisePropertyChanged("Reject_Override_A");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_ASpecified
		{
			get
			{
				return this.reject_Override_AFieldSpecified;
			}
			set
			{
				this.reject_Override_AFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_ASpecified");
			}
		}

		[XmlElement(Order = 148)]
		public bool Reject_Override_B
		{
			get
			{
				return this.reject_Override_BField;
			}
			set
			{
				this.reject_Override_BField = value;
				this.RaisePropertyChanged("Reject_Override_B");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_BSpecified
		{
			get
			{
				return this.reject_Override_BFieldSpecified;
			}
			set
			{
				this.reject_Override_BFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_BSpecified");
			}
		}

		[XmlElement(Order = 149)]
		public bool Reject_Override_C
		{
			get
			{
				return this.reject_Override_CField;
			}
			set
			{
				this.reject_Override_CField = value;
				this.RaisePropertyChanged("Reject_Override_C");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_CSpecified
		{
			get
			{
				return this.reject_Override_CFieldSpecified;
			}
			set
			{
				this.reject_Override_CFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_CSpecified");
			}
		}

		[XmlElement(Order = 150)]
		public bool Reject_Override_G
		{
			get
			{
				return this.reject_Override_GField;
			}
			set
			{
				this.reject_Override_GField = value;
				this.RaisePropertyChanged("Reject_Override_G");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_GSpecified
		{
			get
			{
				return this.reject_Override_GFieldSpecified;
			}
			set
			{
				this.reject_Override_GFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_GSpecified");
			}
		}

		[XmlElement(Order = 151)]
		public bool Reject_Override_J
		{
			get
			{
				return this.reject_Override_JField;
			}
			set
			{
				this.reject_Override_JField = value;
				this.RaisePropertyChanged("Reject_Override_J");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_JSpecified
		{
			get
			{
				return this.reject_Override_JFieldSpecified;
			}
			set
			{
				this.reject_Override_JFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_JSpecified");
			}
		}

		[XmlElement(Order = 152)]
		public bool Reject_Override_K
		{
			get
			{
				return this.reject_Override_KField;
			}
			set
			{
				this.reject_Override_KField = value;
				this.RaisePropertyChanged("Reject_Override_K");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_KSpecified
		{
			get
			{
				return this.reject_Override_KFieldSpecified;
			}
			set
			{
				this.reject_Override_KFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_KSpecified");
			}
		}

		[XmlElement(Order = 153)]
		public bool Reject_Override_N
		{
			get
			{
				return this.reject_Override_NField;
			}
			set
			{
				this.reject_Override_NField = value;
				this.RaisePropertyChanged("Reject_Override_N");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_NSpecified
		{
			get
			{
				return this.reject_Override_NFieldSpecified;
			}
			set
			{
				this.reject_Override_NFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_NSpecified");
			}
		}

		[XmlElement(Order = 154)]
		public bool Reject_Override_W
		{
			get
			{
				return this.reject_Override_WField;
			}
			set
			{
				this.reject_Override_WField = value;
				this.RaisePropertyChanged("Reject_Override_W");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_WSpecified
		{
			get
			{
				return this.reject_Override_WFieldSpecified;
			}
			set
			{
				this.reject_Override_WFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_WSpecified");
			}
		}

		[XmlElement(Order = 155)]
		public bool Reject_Override_21
		{
			get
			{
				return this.reject_Override_21Field;
			}
			set
			{
				this.reject_Override_21Field = value;
				this.RaisePropertyChanged("Reject_Override_21");
			}
		}

		[XmlIgnore]
		public bool Reject_Override_21Specified
		{
			get
			{
				return this.reject_Override_21FieldSpecified;
			}
			set
			{
				this.reject_Override_21FieldSpecified = value;
				this.RaisePropertyChanged("Reject_Override_21Specified");
			}
		}

		[XmlElement(Order = 156)]
		public string Student_Current_Social_Security_Number
		{
			get
			{
				return this.student_Current_Social_Security_NumberField;
			}
			set
			{
				this.student_Current_Social_Security_NumberField = value;
				this.RaisePropertyChanged("Student_Current_Social_Security_Number");
			}
		}

		[XmlElement(Order = 157)]
		public ISIR_Professional_Judgment_IndicatorObjectType Professional_Judgment_Indicator_Reference
		{
			get
			{
				return this.professional_Judgment_Indicator_ReferenceField;
			}
			set
			{
				this.professional_Judgment_Indicator_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Judgment_Indicator_Reference");
			}
		}

		[XmlElement(Order = 158)]
		public string DHS_Verification_Number
		{
			get
			{
				return this.dHS_Verification_NumberField;
			}
			set
			{
				this.dHS_Verification_NumberField = value;
				this.RaisePropertyChanged("DHS_Verification_Number");
			}
		}

		[XmlElement(Order = 159)]
		public IRS_Request_FlagObjectType Parent_IRS_Request_Flag_Reference
		{
			get
			{
				return this.parent_IRS_Request_Flag_ReferenceField;
			}
			set
			{
				this.parent_IRS_Request_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Parent_IRS_Request_Flag_Reference");
			}
		}

		[XmlElement(Order = 160)]
		public IRS_Request_FlagObjectType Student_IRS_Request_Flag_Reference
		{
			get
			{
				return this.student_IRS_Request_Flag_ReferenceField;
			}
			set
			{
				this.student_IRS_Request_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Student_IRS_Request_Flag_Reference");
			}
		}

		[XmlElement("ISIR_Comment_Code_Reference", Order = 161)]
		public ISIR_Comment_CodeObjectType[] ISIR_Comment_Code_Reference
		{
			get
			{
				return this.iSIR_Comment_Code_ReferenceField;
			}
			set
			{
				this.iSIR_Comment_Code_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_Comment_Code_Reference");
			}
		}

		[XmlElement(Order = 162)]
		public bool Professional_Judgement_Indicator
		{
			get
			{
				return this.professional_Judgement_IndicatorField;
			}
			set
			{
				this.professional_Judgement_IndicatorField = value;
				this.RaisePropertyChanged("Professional_Judgement_Indicator");
			}
		}

		[XmlIgnore]
		public bool Professional_Judgement_IndicatorSpecified
		{
			get
			{
				return this.professional_Judgement_IndicatorFieldSpecified;
			}
			set
			{
				this.professional_Judgement_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Professional_Judgement_IndicatorSpecified");
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
