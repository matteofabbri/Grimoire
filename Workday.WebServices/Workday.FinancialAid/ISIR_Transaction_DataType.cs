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
	public class ISIR_Transaction_DataType : INotifyPropertyChanged
	{
		private string idField;

		private decimal transaction_NumberField;

		private bool transaction_NumberFieldSpecified;

		private Financial_Aid_Award_YearObjectType financial_Aid_Award_Year_ReferenceField;

		private Academic_Curricular_DivisionObjectType academic_Unit_ReferenceField;

		private Financial_Aid_School_CodeObjectType federal_School_Code_ReferenceField;

		private Expected_Family_Contribution_StatusObjectType expected_Family_Contribution_Status_ReferenceField;

		private DateTime date_Application_CompletedField;

		private bool date_Application_CompletedFieldSpecified;

		private Financial_Aid_Dependency_StatusObjectType student_Dependency_Status_ReferenceField;

		private ISIR_IRS_Display_FlagObjectType student_IRS_Display_Flag_ReferenceField;

		private Financial_Aid_ISIR_Data_Source_and_Type_CodeObjectType transaction_Data_Source_and_Type_Code_ReferenceField;

		private string original_Name_IDField;

		private string original_SSNField;

		private Unique_IdentifierObjectType current_Transaction_Data_ReferenceField;

		private Unique_IdentifierObjectType original_Transaction_Data_ReferenceField;

		private ISIR_Transaction_StatusObjectType iSIR_Transaction_Status_ReferenceField;

		private ISIR_EFC_Change_FlagObjectType eFC_Change_Flag_ReferenceField;

		private ISIR_Address_Only_Change_FlagObjectType address_Only_Change_Flag_ReferenceField;

		private Financial_Aid_ISIR_Data_Source_and_Type_CodeObjectType application_Data_Source_Type_Code_ReferenceField;

		private ISIR_IRS_Display_FlagObjectType parent_IRS_Display_Flag_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private ISIR_AGI_and_FIT_Data_Field_FlagObjectType iRS_Parent_FIT_Data_Field_Flag_ReferenceField;

		private ISIR_ResponseObjectType student_Asset_Threshold_Exceeded_ReferenceField;

		private string high_School_CodeField;

		private bool cPS_Pushed_ISIR_FlagField;

		private bool cPS_Pushed_ISIR_FlagFieldSpecified;

		private ISIR_AGI_and_FIT_Data_Field_FlagObjectType iRS_Parent_AGI_Data_Field_Flag_ReferenceField;

		private ISIR_ResponseObjectType parent_Asset_Threshold_Exceeded_ReferenceField;

		private DateTime application_Receipt_DateField;

		private bool application_Receipt_DateFieldSpecified;

		private ISIR_AGI_and_FIT_Data_Field_FlagObjectType iRS_Student_Federal_Income_Tax_FIT_Data_Field_Flag_ReferenceField;

		private decimal correction_Applied_against_Transaction_NumberField;

		private bool correction_Applied_against_Transaction_NumberFieldSpecified;

		private string electronic_Transaction_Indicator_Destination_NumberField;

		private DateTime transaction_Receipt_DateField;

		private bool transaction_Receipt_DateFieldSpecified;

		private ISIR_Special_Circumstance_FlagObjectType special_Circumstance_Flag_ReferenceField;

		private string fAA_Federal_School_CodeField;

		private ISIR_Name_or_SSN_Change_FlagObjectType student_Last_Name_SSN_Change_Flag_ReferenceField;

		private bool reject_Status_Change_FlagField;

		private bool reject_Status_Change_FlagFieldSpecified;

		private bool sAR_C_Change_FlagField;

		private bool sAR_C_Change_FlagFieldSpecified;

		private Verification_Selection_Change_FlagObjectType verification_Selection_Change_Flag_ReferenceField;

		private decimal compute_NumberField;

		private bool compute_NumberFieldSpecified;

		private ISIR_Source_of_CorrectionObjectType source_of_Correction_ReferenceField;

		private bool duplicate_SSN_IndicatorField;

		private bool duplicate_SSN_IndicatorFieldSpecified;

		private bool graduate_FlagField;

		private bool graduate_FlagFieldSpecified;

		private bool pell_Grant_Eligibility_FlagField;

		private bool pell_Grant_Eligibility_FlagFieldSpecified;

		private DateTime transaction_Processed_DateField;

		private bool transaction_Processed_DateFieldSpecified;

		private ISIR_Processed_Record_TypeObjectType processed_Record_Type_ReferenceField;

		private ISIR_Reject_Reason_CodeObjectType[] reject_Reason_Code_ReferenceField;

		private decimal reprocessed_Reason_CodeField;

		private bool reprocessed_Reason_CodeFieldSpecified;

		private bool sAR_C_FlagField;

		private bool sAR_C_FlagFieldSpecified;

		private bool automatic_Zero_EFC_IndicatorField;

		private bool automatic_Zero_EFC_IndicatorFieldSpecified;

		private bool simplified_Needs_TestField;

		private bool simplified_Needs_TestFieldSpecified;

		private ISIR_Calculated_Tax_Status_by_CPSObjectType parents_Calculated_Prior_Year_Tax_Status_ReferenceField;

		private ISIR_Calculated_Tax_Status_by_CPSObjectType student_Calculated_Prior_Year_Tax_Status_ReferenceField;

		private decimal student_Additional_Financial_Information_Total_Calculated_by_CPSField;

		private bool student_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified;

		private decimal student_Untaxed_Income_Total_Calculated_by_CPSField;

		private bool student_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified;

		private decimal parents_Additional_Financial_Information_Total_Calculated_by_CPSField;

		private bool parents_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified;

		private decimal parents_Untaxed_Income_Total_Calculated_by_CPSField;

		private bool parents_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified;

		private bool high_School_FlagField;

		private bool high_School_FlagFieldSpecified;

		private Financial_Aid_Citizenship_StatusObjectType assumed_Citizenship_ReferenceField;

		private ISIR_Student_Marital_StatusObjectType assumed_Student_Marital_Status_ReferenceField;

		private decimal assumed_Student_AGIField;

		private bool assumed_Student_AGIFieldSpecified;

		private decimal assumed_Student_US_Tax_PaidField;

		private bool assumed_Student_US_Tax_PaidFieldSpecified;

		private decimal assumed_Student_Income_from_WorkField;

		private bool assumed_Student_Income_from_WorkFieldSpecified;

		private decimal assumed_Spouse_Income_from_WorkField;

		private bool assumed_Spouse_Income_from_WorkFieldSpecified;

		private decimal assumed_Student_Additional_Financial_Information_TotalField;

		private bool assumed_Student_Additional_Financial_Information_TotalFieldSpecified;

		private decimal assumed_Student_Number_in_FamilyField;

		private bool assumed_Student_Number_in_FamilyFieldSpecified;

		private decimal assumed_Student_Number_in_CollegeField;

		private bool assumed_Student_Number_in_CollegeFieldSpecified;

		private decimal assumed_Parents_Number_in_FamilyField;

		private bool assumed_Parents_Number_in_FamilyFieldSpecified;

		private decimal assumed_Parents_Number_in_CollegeField;

		private bool assumed_Parents_Number_in_CollegeFieldSpecified;

		private decimal assumed_Parents_AGIField;

		private bool assumed_Parents_AGIFieldSpecified;

		private decimal assumed_Parents_US_Tax_PaidField;

		private bool assumed_Parents_US_Tax_PaidFieldSpecified;

		private decimal assumed_Parents_Additional_Financial_Information_TotalField;

		private bool assumed_Parents_Additional_Financial_Information_TotalFieldSpecified;

		private decimal assumed_Parent_1_Income_Earned_from_WorkField;

		private bool assumed_Parent_1_Income_Earned_from_WorkFieldSpecified;

		private decimal secondary_EFCField;

		private bool secondary_EFCFieldSpecified;

		private decimal assumed_Parent_2_Income_Earned_from_WorkField;

		private bool assumed_Parent_2_Income_Earned_from_WorkFieldSpecified;

		private decimal signature_Reject_EFC_CalculatedField;

		private bool signature_Reject_EFC_CalculatedFieldSpecified;

		private ISIR_EFC_TypeObjectType primary_EFC_Type_ReferenceField;

		private ISIR_EFC_TypeObjectType secondary_EFC_Type_ReferenceField;

		private decimal primary_EFCField;

		private bool primary_EFCFieldSpecified;

		private ISIR_Parent_Marital_StatusObjectType assumed_Parents_Marital_Status_ReferenceField;

		private ISIR_ResponseObjectType assumed_Date_of_Birth_Prior_ReferenceField;

		private ISIR_ResponseObjectType assumed_Student_is_Married_Remarried_ReferenceField;

		private ISIR_ResponseObjectType assumed_Have_Children_You_Support_ReferenceField;

		private ISIR_ResponseObjectType assumed_Have_Other_Legal_Dependents_ReferenceField;

		private ISIR_ResponseObjectType assumed_Homeless_Youth_School_Determined_ReferenceField;

		private ISIR_ResponseObjectType assumed_Homeless_Youth_HUD_Determined_ReferenceField;

		private ISIR_ResponseObjectType assumed_At_Risk_of_Homelessness_ReferenceField;

		private ISIR_ResponseObjectType assumed_Student_Asset_Threshold_Exceeded_ReferenceField;

		private ISIR_ResponseObjectType assumed_Parent_1_SSN_ReferenceField;

		private ISIR_ResponseObjectType assumed_Parent_2_SSN_ReferenceField;

		private ISIR_ResponseObjectType assumed_Parents_Asset_Threshold_Exceeded_ReferenceField;

		private decimal primary_Alternate_Month_1Field;

		private bool primary_Alternate_Month_1FieldSpecified;

		private decimal primary_Alternate_Month_2Field;

		private bool primary_Alternate_Month_2FieldSpecified;

		private decimal primary_Alternate_Month_3Field;

		private bool primary_Alternate_Month_3FieldSpecified;

		private decimal primary_Alternate_Month_4Field;

		private bool primary_Alternate_Month_4FieldSpecified;

		private decimal primary_Alternate_Month_5Field;

		private bool primary_Alternate_Month_5FieldSpecified;

		private decimal primary_Alternate_Month_6Field;

		private bool primary_Alternate_Month_6FieldSpecified;

		private decimal primary_Alternate_Month_7Field;

		private bool primary_Alternate_Month_7FieldSpecified;

		private decimal primary_Alternate_Month_8Field;

		private bool primary_Alternate_Month_8FieldSpecified;

		private decimal primary_Alternate_Month_10Field;

		private bool primary_Alternate_Month_10FieldSpecified;

		private decimal primary_Alternate_Month_11Field;

		private bool primary_Alternate_Month_11FieldSpecified;

		private decimal primary_Alternate_Month_12Field;

		private bool primary_Alternate_Month_12FieldSpecified;

		private decimal secondary_Alternate_Month_1Field;

		private bool secondary_Alternate_Month_1FieldSpecified;

		private decimal secondary_Alternate_Month_2Field;

		private bool secondary_Alternate_Month_2FieldSpecified;

		private decimal secondary_Alternate_Month_3Field;

		private bool secondary_Alternate_Month_3FieldSpecified;

		private decimal secondary_Alternate_Month_4Field;

		private bool secondary_Alternate_Month_4FieldSpecified;

		private decimal secondary_Alternate_Month_5Field;

		private bool secondary_Alternate_Month_5FieldSpecified;

		private decimal secondary_Alternate_Month_6Field;

		private bool secondary_Alternate_Month_6FieldSpecified;

		private decimal secondary_Alternate_Month_7Field;

		private bool secondary_Alternate_Month_7FieldSpecified;

		private decimal secondary_Alternate_Month_8Field;

		private bool secondary_Alternate_Month_8FieldSpecified;

		private decimal secondary_Alternate_Month_10Field;

		private bool secondary_Alternate_Month_10FieldSpecified;

		private decimal secondary_Alternate_Month_11Field;

		private bool secondary_Alternate_Month_11FieldSpecified;

		private decimal secondary_Alternate_Month_12Field;

		private bool secondary_Alternate_Month_12FieldSpecified;

		private decimal tI_Total_IncomeField;

		private bool tI_Total_IncomeFieldSpecified;

		private decimal aTI_Allowances_Against_Total_IncomeField;

		private bool aTI_Allowances_Against_Total_IncomeFieldSpecified;

		private decimal sTX_State_and_Other_Tax_AllowanceField;

		private bool sTX_State_and_Other_Tax_AllowanceFieldSpecified;

		private decimal eA_Employment_AllowanceField;

		private bool eA_Employment_AllowanceFieldSpecified;

		private decimal iPA_Income_Protection_AllowanceField;

		private bool iPA_Income_Protection_AllowanceFieldSpecified;

		private decimal aI_Available_IncomeField;

		private bool aI_Available_IncomeFieldSpecified;

		private decimal cAI_Contribution_from_Available_IncomeField;

		private bool cAI_Contribution_from_Available_IncomeFieldSpecified;

		private decimal dNW_Discretionary_Net_WorthField;

		private bool dNW_Discretionary_Net_WorthFieldSpecified;

		private decimal nW_Net_WorthField;

		private bool nW_Net_WorthFieldSpecified;

		private decimal aPA_Asset_Protection_AllowanceField;

		private bool aPA_Asset_Protection_AllowanceFieldSpecified;

		private decimal pCA_Parents_Contribution_from_AssetsField;

		private bool pCA_Parents_Contribution_from_AssetsFieldSpecified;

		private decimal aAI_Adjusted_Available_IncomeField;

		private bool aAI_Adjusted_Available_IncomeFieldSpecified;

		private decimal tSC_Total_Student_ContributionField;

		private bool tSC_Total_Student_ContributionFieldSpecified;

		private decimal tPC_Total_Parents_ContributionField;

		private bool tPC_Total_Parents_ContributionFieldSpecified;

		private decimal pC_Parents_ContributionField;

		private bool pC_Parents_ContributionFieldSpecified;

		private decimal sTI_Student_Total_IncomeField;

		private bool sTI_Student_Total_IncomeFieldSpecified;

		private decimal sATI_Student_Allowance_Against_Total_IncomeField;

		private bool sATI_Student_Allowance_Against_Total_IncomeFieldSpecified;

		private decimal sIC_Dependent_Student_Income_ContributionField;

		private bool sIC_Dependent_Student_Income_ContributionFieldSpecified;

		private decimal sDNW_Student_Discretionary_Net_WorthField;

		private bool sDNW_Student_Discretionary_Net_WorthFieldSpecified;

		private decimal sCA_Student_Contribution_from_AssetsField;

		private bool sCA_Student_Contribution_from_AssetsFieldSpecified;

		private decimal fTI_FISAP_TotalField;

		private bool fTI_FISAP_TotalFieldSpecified;

		private decimal sEC_TI_Secondary_Total_IncomeField;

		private bool sEC_TI_Secondary_Total_IncomeFieldSpecified;

		private decimal sEC_ATI_Secondary_Allowances_Against_Total_IncomeField;

		private bool sEC_ATI_Secondary_Allowances_Against_Total_IncomeFieldSpecified;

		private decimal sEC_STX_Secondary_State_Tax_AllowanceField;

		private bool sEC_STX_Secondary_State_Tax_AllowanceFieldSpecified;

		private decimal sEC_EA_Secondary_Employment_AllowanceField;

		private bool sEC_EA_Secondary_Employment_AllowanceFieldSpecified;

		private decimal sEC_IPA_Secondary_Income_Protection_AllowanceField;

		private bool sEC_IPA_Secondary_Income_Protection_AllowanceFieldSpecified;

		private decimal sEC_AI_Secondary_Available_IncomeField;

		private bool sEC_AI_Secondary_Available_IncomeFieldSpecified;

		private decimal sEC_CAI_Secondary_Contribution_From_Available_IncomeField;

		private bool sEC_CAI_Secondary_Contribution_From_Available_IncomeFieldSpecified;

		private decimal sEC_DNW_Secondary_Discretionary_Net_WorthField;

		private bool sEC_DNW_Secondary_Discretionary_Net_WorthFieldSpecified;

		private decimal sEC_NW_Secondary_Net_WorthField;

		private bool sEC_NW_Secondary_Net_WorthFieldSpecified;

		private decimal sEC_APA_Secondary_Asset_Protection_AllowanceField;

		private bool sEC_APA_Secondary_Asset_Protection_AllowanceFieldSpecified;

		private decimal sEC_PCA_Secondary_Parents_Contribution_from_AssetsField;

		private bool sEC_PCA_Secondary_Parents_Contribution_from_AssetsFieldSpecified;

		private decimal sEC_AAI_Secondary_Adjusted_Available_IncomeField;

		private bool sEC_AAI_Secondary_Adjusted_Available_IncomeFieldSpecified;

		private decimal sEC_TSC_Secondary_Total_Student_ContributionField;

		private bool sEC_TSC_Secondary_Total_Student_ContributionFieldSpecified;

		private decimal sEC_TPC_Secondary_Total_Parents_ContributionField;

		private bool sEC_TPC_Secondary_Total_Parents_ContributionFieldSpecified;

		private decimal sEC_PC_Secondary_Parents_ContributionField;

		private bool sEC_PC_Secondary_Parents_ContributionFieldSpecified;

		private decimal sEC_STI_Secondary_Student_Total_IncomeField;

		private bool sEC_STI_Secondary_Student_Total_IncomeFieldSpecified;

		private decimal sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeField;

		private bool sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeFieldSpecified;

		private decimal sEC_SIC_Secondary_Student_Dependent_Income_ContributionField;

		private bool sEC_SIC_Secondary_Student_Dependent_Income_ContributionFieldSpecified;

		private decimal sEC_SDNW_Secondary_Student_Discretionary_Net_WorthField;

		private bool sEC_SDNW_Secondary_Student_Discretionary_Net_WorthFieldSpecified;

		private decimal sEC_SCA_Secondary_Student_Contribution_from_AssetsField;

		private bool sEC_SCA_Secondary_Student_Contribution_from_AssetsFieldSpecified;

		private decimal sEC_FTI_Secondary_FISAP_Total_IncomeField;

		private bool sEC_FTI_Secondary_FISAP_Total_IncomeFieldSpecified;

		private ISIR_DHS_Match_FlagObjectType dHS_Match_Flag_ReferenceField;

		private ISIR_Secondary_DHS_Match_FlagObjectType secondary_DHS_Match_Flag_ReferenceField;

		private ISIR_NSLDS_Match_FlagObjectType nSLDS_Match_Flag_ReferenceField;

		private ISIR_NSLDS_Post_Screening_Reason_CodeObjectType[] nSLDS_Postscreening_Reason_Code_ReferenceField;

		private ISIR_SSN_Match_FlagObjectType parent_1_SSN_Match_Flag_ReferenceField;

		private ISIR_SSN_Match_FlagObjectType parent_2_SSN_Match_Flag_ReferenceField;

		private ISIR_Selective_Service_FlagObjectType selective_Service_Match_Flag_ReferenceField;

		private ISIR_Selective_Service_FlagObjectType selective_Service_Registration_Flag_ReferenceField;

		private ISIR_SSA_Citizenship_FlagObjectType sSA_Citizenship_Flag_ReferenceField;

		private ISIR_SSN_Match_FlagObjectType student_SSN_Match_Flag_ReferenceField;

		private ISIR_VA_Match_FlagObjectType vA_Match_Flag_ReferenceField;

		private bool dOD_Match_FlagField;

		private bool dOD_Match_FlagFieldSpecified;

		private DateTime dOD_Parent_Date_of_DeathField;

		private bool dOD_Parent_Date_of_DeathFieldSpecified;

		private ISIR_Electronic_Federal_School_Code_IndicatorObjectType electronic_Federal_School_Code_Indicator_ReferenceField;

		private Financial_Aid_ISIR_Electronic_Transaction_Indicator_FlagObjectType eTI_Flag_ReferenceField;

		private ISIR_Federal_Verification_Tracking_FlagObjectType federal_Verification_Tracking_Flag_ReferenceField;

		private Student_is_Selected_for_VerificationObjectType student_Is_Selected_For_Verification_ReferenceField;

		private NSLDS_Transaction_DataType[] nSLDS_Transaction_DataField;

		private ISIR_Transaction_Data_DataType[] iSIR_Transaction_Data_DataField;

		private ISIR_Student_DataType[] iSIR_Student_DataField;

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

		[XmlElement(Order = 1)]
		public decimal Transaction_Number
		{
			get
			{
				return this.transaction_NumberField;
			}
			set
			{
				this.transaction_NumberField = value;
				this.RaisePropertyChanged("Transaction_Number");
			}
		}

		[XmlIgnore]
		public bool Transaction_NumberSpecified
		{
			get
			{
				return this.transaction_NumberFieldSpecified;
			}
			set
			{
				this.transaction_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Financial_Aid_Award_YearObjectType Financial_Aid_Award_Year_Reference
		{
			get
			{
				return this.financial_Aid_Award_Year_ReferenceField;
			}
			set
			{
				this.financial_Aid_Award_Year_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Award_Year_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_Curricular_DivisionObjectType Academic_Unit_Reference
		{
			get
			{
				return this.academic_Unit_ReferenceField;
			}
			set
			{
				this.academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Unit_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Financial_Aid_School_CodeObjectType Federal_School_Code_Reference
		{
			get
			{
				return this.federal_School_Code_ReferenceField;
			}
			set
			{
				this.federal_School_Code_ReferenceField = value;
				this.RaisePropertyChanged("Federal_School_Code_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Expected_Family_Contribution_StatusObjectType Expected_Family_Contribution_Status_Reference
		{
			get
			{
				return this.expected_Family_Contribution_Status_ReferenceField;
			}
			set
			{
				this.expected_Family_Contribution_Status_ReferenceField = value;
				this.RaisePropertyChanged("Expected_Family_Contribution_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Date_Application_Completed
		{
			get
			{
				return this.date_Application_CompletedField;
			}
			set
			{
				this.date_Application_CompletedField = value;
				this.RaisePropertyChanged("Date_Application_Completed");
			}
		}

		[XmlIgnore]
		public bool Date_Application_CompletedSpecified
		{
			get
			{
				return this.date_Application_CompletedFieldSpecified;
			}
			set
			{
				this.date_Application_CompletedFieldSpecified = value;
				this.RaisePropertyChanged("Date_Application_CompletedSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Financial_Aid_Dependency_StatusObjectType Student_Dependency_Status_Reference
		{
			get
			{
				return this.student_Dependency_Status_ReferenceField;
			}
			set
			{
				this.student_Dependency_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Dependency_Status_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public ISIR_IRS_Display_FlagObjectType Student_IRS_Display_Flag_Reference
		{
			get
			{
				return this.student_IRS_Display_Flag_ReferenceField;
			}
			set
			{
				this.student_IRS_Display_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Student_IRS_Display_Flag_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Financial_Aid_ISIR_Data_Source_and_Type_CodeObjectType Transaction_Data_Source_and_Type_Code_Reference
		{
			get
			{
				return this.transaction_Data_Source_and_Type_Code_ReferenceField;
			}
			set
			{
				this.transaction_Data_Source_and_Type_Code_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Data_Source_and_Type_Code_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Original_Name_ID
		{
			get
			{
				return this.original_Name_IDField;
			}
			set
			{
				this.original_Name_IDField = value;
				this.RaisePropertyChanged("Original_Name_ID");
			}
		}

		[XmlElement(Order = 11)]
		public string Original_SSN
		{
			get
			{
				return this.original_SSNField;
			}
			set
			{
				this.original_SSNField = value;
				this.RaisePropertyChanged("Original_SSN");
			}
		}

		[XmlElement(Order = 12)]
		public Unique_IdentifierObjectType Current_Transaction_Data_Reference
		{
			get
			{
				return this.current_Transaction_Data_ReferenceField;
			}
			set
			{
				this.current_Transaction_Data_ReferenceField = value;
				this.RaisePropertyChanged("Current_Transaction_Data_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Unique_IdentifierObjectType Original_Transaction_Data_Reference
		{
			get
			{
				return this.original_Transaction_Data_ReferenceField;
			}
			set
			{
				this.original_Transaction_Data_ReferenceField = value;
				this.RaisePropertyChanged("Original_Transaction_Data_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public ISIR_Transaction_StatusObjectType ISIR_Transaction_Status_Reference
		{
			get
			{
				return this.iSIR_Transaction_Status_ReferenceField;
			}
			set
			{
				this.iSIR_Transaction_Status_ReferenceField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Status_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public ISIR_EFC_Change_FlagObjectType EFC_Change_Flag_Reference
		{
			get
			{
				return this.eFC_Change_Flag_ReferenceField;
			}
			set
			{
				this.eFC_Change_Flag_ReferenceField = value;
				this.RaisePropertyChanged("EFC_Change_Flag_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public ISIR_Address_Only_Change_FlagObjectType Address_Only_Change_Flag_Reference
		{
			get
			{
				return this.address_Only_Change_Flag_ReferenceField;
			}
			set
			{
				this.address_Only_Change_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Address_Only_Change_Flag_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Financial_Aid_ISIR_Data_Source_and_Type_CodeObjectType Application_Data_Source_Type_Code_Reference
		{
			get
			{
				return this.application_Data_Source_Type_Code_ReferenceField;
			}
			set
			{
				this.application_Data_Source_Type_Code_ReferenceField = value;
				this.RaisePropertyChanged("Application_Data_Source_Type_Code_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public ISIR_IRS_Display_FlagObjectType Parent_IRS_Display_Flag_Reference
		{
			get
			{
				return this.parent_IRS_Display_Flag_ReferenceField;
			}
			set
			{
				this.parent_IRS_Display_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Parent_IRS_Display_Flag_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public ISIR_AGI_and_FIT_Data_Field_FlagObjectType IRS_Parent_FIT_Data_Field_Flag_Reference
		{
			get
			{
				return this.iRS_Parent_FIT_Data_Field_Flag_ReferenceField;
			}
			set
			{
				this.iRS_Parent_FIT_Data_Field_Flag_ReferenceField = value;
				this.RaisePropertyChanged("IRS_Parent_FIT_Data_Field_Flag_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public ISIR_ResponseObjectType Student_Asset_Threshold_Exceeded_Reference
		{
			get
			{
				return this.student_Asset_Threshold_Exceeded_ReferenceField;
			}
			set
			{
				this.student_Asset_Threshold_Exceeded_ReferenceField = value;
				this.RaisePropertyChanged("Student_Asset_Threshold_Exceeded_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public string High_School_Code
		{
			get
			{
				return this.high_School_CodeField;
			}
			set
			{
				this.high_School_CodeField = value;
				this.RaisePropertyChanged("High_School_Code");
			}
		}

		[XmlElement(Order = 23)]
		public bool CPS_Pushed_ISIR_Flag
		{
			get
			{
				return this.cPS_Pushed_ISIR_FlagField;
			}
			set
			{
				this.cPS_Pushed_ISIR_FlagField = value;
				this.RaisePropertyChanged("CPS_Pushed_ISIR_Flag");
			}
		}

		[XmlIgnore]
		public bool CPS_Pushed_ISIR_FlagSpecified
		{
			get
			{
				return this.cPS_Pushed_ISIR_FlagFieldSpecified;
			}
			set
			{
				this.cPS_Pushed_ISIR_FlagFieldSpecified = value;
				this.RaisePropertyChanged("CPS_Pushed_ISIR_FlagSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public ISIR_AGI_and_FIT_Data_Field_FlagObjectType IRS_Parent_AGI_Data_Field_Flag_Reference
		{
			get
			{
				return this.iRS_Parent_AGI_Data_Field_Flag_ReferenceField;
			}
			set
			{
				this.iRS_Parent_AGI_Data_Field_Flag_ReferenceField = value;
				this.RaisePropertyChanged("IRS_Parent_AGI_Data_Field_Flag_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public ISIR_ResponseObjectType Parent_Asset_Threshold_Exceeded_Reference
		{
			get
			{
				return this.parent_Asset_Threshold_Exceeded_ReferenceField;
			}
			set
			{
				this.parent_Asset_Threshold_Exceeded_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Asset_Threshold_Exceeded_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 26)]
		public DateTime Application_Receipt_Date
		{
			get
			{
				return this.application_Receipt_DateField;
			}
			set
			{
				this.application_Receipt_DateField = value;
				this.RaisePropertyChanged("Application_Receipt_Date");
			}
		}

		[XmlIgnore]
		public bool Application_Receipt_DateSpecified
		{
			get
			{
				return this.application_Receipt_DateFieldSpecified;
			}
			set
			{
				this.application_Receipt_DateFieldSpecified = value;
				this.RaisePropertyChanged("Application_Receipt_DateSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public ISIR_AGI_and_FIT_Data_Field_FlagObjectType IRS_Student_Federal_Income_Tax_FIT_Data_Field_Flag_Reference
		{
			get
			{
				return this.iRS_Student_Federal_Income_Tax_FIT_Data_Field_Flag_ReferenceField;
			}
			set
			{
				this.iRS_Student_Federal_Income_Tax_FIT_Data_Field_Flag_ReferenceField = value;
				this.RaisePropertyChanged("IRS_Student_Federal_Income_Tax_FIT_Data_Field_Flag_Reference");
			}
		}

		[XmlElement(Order = 28)]
		public decimal Correction_Applied_against_Transaction_Number
		{
			get
			{
				return this.correction_Applied_against_Transaction_NumberField;
			}
			set
			{
				this.correction_Applied_against_Transaction_NumberField = value;
				this.RaisePropertyChanged("Correction_Applied_against_Transaction_Number");
			}
		}

		[XmlIgnore]
		public bool Correction_Applied_against_Transaction_NumberSpecified
		{
			get
			{
				return this.correction_Applied_against_Transaction_NumberFieldSpecified;
			}
			set
			{
				this.correction_Applied_against_Transaction_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Correction_Applied_against_Transaction_NumberSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public string Electronic_Transaction_Indicator_Destination_Number
		{
			get
			{
				return this.electronic_Transaction_Indicator_Destination_NumberField;
			}
			set
			{
				this.electronic_Transaction_Indicator_Destination_NumberField = value;
				this.RaisePropertyChanged("Electronic_Transaction_Indicator_Destination_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 30)]
		public DateTime Transaction_Receipt_Date
		{
			get
			{
				return this.transaction_Receipt_DateField;
			}
			set
			{
				this.transaction_Receipt_DateField = value;
				this.RaisePropertyChanged("Transaction_Receipt_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Receipt_DateSpecified
		{
			get
			{
				return this.transaction_Receipt_DateFieldSpecified;
			}
			set
			{
				this.transaction_Receipt_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Receipt_DateSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public ISIR_Special_Circumstance_FlagObjectType Special_Circumstance_Flag_Reference
		{
			get
			{
				return this.special_Circumstance_Flag_ReferenceField;
			}
			set
			{
				this.special_Circumstance_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Special_Circumstance_Flag_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public string FAA_Federal_School_Code
		{
			get
			{
				return this.fAA_Federal_School_CodeField;
			}
			set
			{
				this.fAA_Federal_School_CodeField = value;
				this.RaisePropertyChanged("FAA_Federal_School_Code");
			}
		}

		[XmlElement(Order = 33)]
		public ISIR_Name_or_SSN_Change_FlagObjectType Student_Last_Name_SSN_Change_Flag_Reference
		{
			get
			{
				return this.student_Last_Name_SSN_Change_Flag_ReferenceField;
			}
			set
			{
				this.student_Last_Name_SSN_Change_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Student_Last_Name_SSN_Change_Flag_Reference");
			}
		}

		[XmlElement(Order = 34)]
		public bool Reject_Status_Change_Flag
		{
			get
			{
				return this.reject_Status_Change_FlagField;
			}
			set
			{
				this.reject_Status_Change_FlagField = value;
				this.RaisePropertyChanged("Reject_Status_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool Reject_Status_Change_FlagSpecified
		{
			get
			{
				return this.reject_Status_Change_FlagFieldSpecified;
			}
			set
			{
				this.reject_Status_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Reject_Status_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public bool SAR_C_Change_Flag
		{
			get
			{
				return this.sAR_C_Change_FlagField;
			}
			set
			{
				this.sAR_C_Change_FlagField = value;
				this.RaisePropertyChanged("SAR_C_Change_Flag");
			}
		}

		[XmlIgnore]
		public bool SAR_C_Change_FlagSpecified
		{
			get
			{
				return this.sAR_C_Change_FlagFieldSpecified;
			}
			set
			{
				this.sAR_C_Change_FlagFieldSpecified = value;
				this.RaisePropertyChanged("SAR_C_Change_FlagSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public Verification_Selection_Change_FlagObjectType Verification_Selection_Change_Flag_Reference
		{
			get
			{
				return this.verification_Selection_Change_Flag_ReferenceField;
			}
			set
			{
				this.verification_Selection_Change_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Verification_Selection_Change_Flag_Reference");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Compute_Number
		{
			get
			{
				return this.compute_NumberField;
			}
			set
			{
				this.compute_NumberField = value;
				this.RaisePropertyChanged("Compute_Number");
			}
		}

		[XmlIgnore]
		public bool Compute_NumberSpecified
		{
			get
			{
				return this.compute_NumberFieldSpecified;
			}
			set
			{
				this.compute_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Compute_NumberSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public ISIR_Source_of_CorrectionObjectType Source_of_Correction_Reference
		{
			get
			{
				return this.source_of_Correction_ReferenceField;
			}
			set
			{
				this.source_of_Correction_ReferenceField = value;
				this.RaisePropertyChanged("Source_of_Correction_Reference");
			}
		}

		[XmlElement(Order = 39)]
		public bool Duplicate_SSN_Indicator
		{
			get
			{
				return this.duplicate_SSN_IndicatorField;
			}
			set
			{
				this.duplicate_SSN_IndicatorField = value;
				this.RaisePropertyChanged("Duplicate_SSN_Indicator");
			}
		}

		[XmlIgnore]
		public bool Duplicate_SSN_IndicatorSpecified
		{
			get
			{
				return this.duplicate_SSN_IndicatorFieldSpecified;
			}
			set
			{
				this.duplicate_SSN_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Duplicate_SSN_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Graduate_Flag
		{
			get
			{
				return this.graduate_FlagField;
			}
			set
			{
				this.graduate_FlagField = value;
				this.RaisePropertyChanged("Graduate_Flag");
			}
		}

		[XmlIgnore]
		public bool Graduate_FlagSpecified
		{
			get
			{
				return this.graduate_FlagFieldSpecified;
			}
			set
			{
				this.graduate_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Graduate_FlagSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public bool Pell_Grant_Eligibility_Flag
		{
			get
			{
				return this.pell_Grant_Eligibility_FlagField;
			}
			set
			{
				this.pell_Grant_Eligibility_FlagField = value;
				this.RaisePropertyChanged("Pell_Grant_Eligibility_Flag");
			}
		}

		[XmlIgnore]
		public bool Pell_Grant_Eligibility_FlagSpecified
		{
			get
			{
				return this.pell_Grant_Eligibility_FlagFieldSpecified;
			}
			set
			{
				this.pell_Grant_Eligibility_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Pell_Grant_Eligibility_FlagSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 42)]
		public DateTime Transaction_Processed_Date
		{
			get
			{
				return this.transaction_Processed_DateField;
			}
			set
			{
				this.transaction_Processed_DateField = value;
				this.RaisePropertyChanged("Transaction_Processed_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Processed_DateSpecified
		{
			get
			{
				return this.transaction_Processed_DateFieldSpecified;
			}
			set
			{
				this.transaction_Processed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Processed_DateSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public ISIR_Processed_Record_TypeObjectType Processed_Record_Type_Reference
		{
			get
			{
				return this.processed_Record_Type_ReferenceField;
			}
			set
			{
				this.processed_Record_Type_ReferenceField = value;
				this.RaisePropertyChanged("Processed_Record_Type_Reference");
			}
		}

		[XmlElement("Reject_Reason_Code_Reference", Order = 44)]
		public ISIR_Reject_Reason_CodeObjectType[] Reject_Reason_Code_Reference
		{
			get
			{
				return this.reject_Reason_Code_ReferenceField;
			}
			set
			{
				this.reject_Reason_Code_ReferenceField = value;
				this.RaisePropertyChanged("Reject_Reason_Code_Reference");
			}
		}

		[XmlElement(Order = 45)]
		public decimal Reprocessed_Reason_Code
		{
			get
			{
				return this.reprocessed_Reason_CodeField;
			}
			set
			{
				this.reprocessed_Reason_CodeField = value;
				this.RaisePropertyChanged("Reprocessed_Reason_Code");
			}
		}

		[XmlIgnore]
		public bool Reprocessed_Reason_CodeSpecified
		{
			get
			{
				return this.reprocessed_Reason_CodeFieldSpecified;
			}
			set
			{
				this.reprocessed_Reason_CodeFieldSpecified = value;
				this.RaisePropertyChanged("Reprocessed_Reason_CodeSpecified");
			}
		}

		[XmlElement(Order = 46)]
		public bool SAR_C_Flag
		{
			get
			{
				return this.sAR_C_FlagField;
			}
			set
			{
				this.sAR_C_FlagField = value;
				this.RaisePropertyChanged("SAR_C_Flag");
			}
		}

		[XmlIgnore]
		public bool SAR_C_FlagSpecified
		{
			get
			{
				return this.sAR_C_FlagFieldSpecified;
			}
			set
			{
				this.sAR_C_FlagFieldSpecified = value;
				this.RaisePropertyChanged("SAR_C_FlagSpecified");
			}
		}

		[XmlElement(Order = 47)]
		public bool Automatic_Zero_EFC_Indicator
		{
			get
			{
				return this.automatic_Zero_EFC_IndicatorField;
			}
			set
			{
				this.automatic_Zero_EFC_IndicatorField = value;
				this.RaisePropertyChanged("Automatic_Zero_EFC_Indicator");
			}
		}

		[XmlIgnore]
		public bool Automatic_Zero_EFC_IndicatorSpecified
		{
			get
			{
				return this.automatic_Zero_EFC_IndicatorFieldSpecified;
			}
			set
			{
				this.automatic_Zero_EFC_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Automatic_Zero_EFC_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public bool Simplified_Needs_Test
		{
			get
			{
				return this.simplified_Needs_TestField;
			}
			set
			{
				this.simplified_Needs_TestField = value;
				this.RaisePropertyChanged("Simplified_Needs_Test");
			}
		}

		[XmlIgnore]
		public bool Simplified_Needs_TestSpecified
		{
			get
			{
				return this.simplified_Needs_TestFieldSpecified;
			}
			set
			{
				this.simplified_Needs_TestFieldSpecified = value;
				this.RaisePropertyChanged("Simplified_Needs_TestSpecified");
			}
		}

		[XmlElement(Order = 49)]
		public ISIR_Calculated_Tax_Status_by_CPSObjectType Parents_Calculated_Prior_Year_Tax_Status_Reference
		{
			get
			{
				return this.parents_Calculated_Prior_Year_Tax_Status_ReferenceField;
			}
			set
			{
				this.parents_Calculated_Prior_Year_Tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Parents_Calculated_Prior_Year_Tax_Status_Reference");
			}
		}

		[XmlElement(Order = 50)]
		public ISIR_Calculated_Tax_Status_by_CPSObjectType Student_Calculated_Prior_Year_Tax_Status_Reference
		{
			get
			{
				return this.student_Calculated_Prior_Year_Tax_Status_ReferenceField;
			}
			set
			{
				this.student_Calculated_Prior_Year_Tax_Status_ReferenceField = value;
				this.RaisePropertyChanged("Student_Calculated_Prior_Year_Tax_Status_Reference");
			}
		}

		[XmlElement(Order = 51)]
		public decimal Student_Additional_Financial_Information_Total_Calculated_by_CPS
		{
			get
			{
				return this.student_Additional_Financial_Information_Total_Calculated_by_CPSField;
			}
			set
			{
				this.student_Additional_Financial_Information_Total_Calculated_by_CPSField = value;
				this.RaisePropertyChanged("Student_Additional_Financial_Information_Total_Calculated_by_CPS");
			}
		}

		[XmlIgnore]
		public bool Student_Additional_Financial_Information_Total_Calculated_by_CPSSpecified
		{
			get
			{
				return this.student_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified;
			}
			set
			{
				this.student_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified = value;
				this.RaisePropertyChanged("Student_Additional_Financial_Information_Total_Calculated_by_CPSSpecified");
			}
		}

		[XmlElement(Order = 52)]
		public decimal Student_Untaxed_Income_Total_Calculated_by_CPS
		{
			get
			{
				return this.student_Untaxed_Income_Total_Calculated_by_CPSField;
			}
			set
			{
				this.student_Untaxed_Income_Total_Calculated_by_CPSField = value;
				this.RaisePropertyChanged("Student_Untaxed_Income_Total_Calculated_by_CPS");
			}
		}

		[XmlIgnore]
		public bool Student_Untaxed_Income_Total_Calculated_by_CPSSpecified
		{
			get
			{
				return this.student_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified;
			}
			set
			{
				this.student_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified = value;
				this.RaisePropertyChanged("Student_Untaxed_Income_Total_Calculated_by_CPSSpecified");
			}
		}

		[XmlElement(Order = 53)]
		public decimal Parents_Additional_Financial_Information_Total_Calculated_by_CPS
		{
			get
			{
				return this.parents_Additional_Financial_Information_Total_Calculated_by_CPSField;
			}
			set
			{
				this.parents_Additional_Financial_Information_Total_Calculated_by_CPSField = value;
				this.RaisePropertyChanged("Parents_Additional_Financial_Information_Total_Calculated_by_CPS");
			}
		}

		[XmlIgnore]
		public bool Parents_Additional_Financial_Information_Total_Calculated_by_CPSSpecified
		{
			get
			{
				return this.parents_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified;
			}
			set
			{
				this.parents_Additional_Financial_Information_Total_Calculated_by_CPSFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Additional_Financial_Information_Total_Calculated_by_CPSSpecified");
			}
		}

		[XmlElement(Order = 54)]
		public decimal Parents_Untaxed_Income_Total_Calculated_by_CPS
		{
			get
			{
				return this.parents_Untaxed_Income_Total_Calculated_by_CPSField;
			}
			set
			{
				this.parents_Untaxed_Income_Total_Calculated_by_CPSField = value;
				this.RaisePropertyChanged("Parents_Untaxed_Income_Total_Calculated_by_CPS");
			}
		}

		[XmlIgnore]
		public bool Parents_Untaxed_Income_Total_Calculated_by_CPSSpecified
		{
			get
			{
				return this.parents_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified;
			}
			set
			{
				this.parents_Untaxed_Income_Total_Calculated_by_CPSFieldSpecified = value;
				this.RaisePropertyChanged("Parents_Untaxed_Income_Total_Calculated_by_CPSSpecified");
			}
		}

		[XmlElement(Order = 55)]
		public bool High_School_Flag
		{
			get
			{
				return this.high_School_FlagField;
			}
			set
			{
				this.high_School_FlagField = value;
				this.RaisePropertyChanged("High_School_Flag");
			}
		}

		[XmlIgnore]
		public bool High_School_FlagSpecified
		{
			get
			{
				return this.high_School_FlagFieldSpecified;
			}
			set
			{
				this.high_School_FlagFieldSpecified = value;
				this.RaisePropertyChanged("High_School_FlagSpecified");
			}
		}

		[XmlElement(Order = 56)]
		public Financial_Aid_Citizenship_StatusObjectType Assumed_Citizenship_Reference
		{
			get
			{
				return this.assumed_Citizenship_ReferenceField;
			}
			set
			{
				this.assumed_Citizenship_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Citizenship_Reference");
			}
		}

		[XmlElement(Order = 57)]
		public ISIR_Student_Marital_StatusObjectType Assumed_Student_Marital_Status_Reference
		{
			get
			{
				return this.assumed_Student_Marital_Status_ReferenceField;
			}
			set
			{
				this.assumed_Student_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Student_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 58)]
		public decimal Assumed_Student_AGI
		{
			get
			{
				return this.assumed_Student_AGIField;
			}
			set
			{
				this.assumed_Student_AGIField = value;
				this.RaisePropertyChanged("Assumed_Student_AGI");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_AGISpecified
		{
			get
			{
				return this.assumed_Student_AGIFieldSpecified;
			}
			set
			{
				this.assumed_Student_AGIFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_AGISpecified");
			}
		}

		[XmlElement(Order = 59)]
		public decimal Assumed_Student_US_Tax_Paid
		{
			get
			{
				return this.assumed_Student_US_Tax_PaidField;
			}
			set
			{
				this.assumed_Student_US_Tax_PaidField = value;
				this.RaisePropertyChanged("Assumed_Student_US_Tax_Paid");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_US_Tax_PaidSpecified
		{
			get
			{
				return this.assumed_Student_US_Tax_PaidFieldSpecified;
			}
			set
			{
				this.assumed_Student_US_Tax_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_US_Tax_PaidSpecified");
			}
		}

		[XmlElement(Order = 60)]
		public decimal Assumed_Student_Income_from_Work
		{
			get
			{
				return this.assumed_Student_Income_from_WorkField;
			}
			set
			{
				this.assumed_Student_Income_from_WorkField = value;
				this.RaisePropertyChanged("Assumed_Student_Income_from_Work");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_Income_from_WorkSpecified
		{
			get
			{
				return this.assumed_Student_Income_from_WorkFieldSpecified;
			}
			set
			{
				this.assumed_Student_Income_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_Income_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 61)]
		public decimal Assumed_Spouse_Income_from_Work
		{
			get
			{
				return this.assumed_Spouse_Income_from_WorkField;
			}
			set
			{
				this.assumed_Spouse_Income_from_WorkField = value;
				this.RaisePropertyChanged("Assumed_Spouse_Income_from_Work");
			}
		}

		[XmlIgnore]
		public bool Assumed_Spouse_Income_from_WorkSpecified
		{
			get
			{
				return this.assumed_Spouse_Income_from_WorkFieldSpecified;
			}
			set
			{
				this.assumed_Spouse_Income_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Spouse_Income_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 62)]
		public decimal Assumed_Student_Additional_Financial_Information_Total
		{
			get
			{
				return this.assumed_Student_Additional_Financial_Information_TotalField;
			}
			set
			{
				this.assumed_Student_Additional_Financial_Information_TotalField = value;
				this.RaisePropertyChanged("Assumed_Student_Additional_Financial_Information_Total");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_Additional_Financial_Information_TotalSpecified
		{
			get
			{
				return this.assumed_Student_Additional_Financial_Information_TotalFieldSpecified;
			}
			set
			{
				this.assumed_Student_Additional_Financial_Information_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_Additional_Financial_Information_TotalSpecified");
			}
		}

		[XmlElement(Order = 63)]
		public decimal Assumed_Student_Number_in_Family
		{
			get
			{
				return this.assumed_Student_Number_in_FamilyField;
			}
			set
			{
				this.assumed_Student_Number_in_FamilyField = value;
				this.RaisePropertyChanged("Assumed_Student_Number_in_Family");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_Number_in_FamilySpecified
		{
			get
			{
				return this.assumed_Student_Number_in_FamilyFieldSpecified;
			}
			set
			{
				this.assumed_Student_Number_in_FamilyFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_Number_in_FamilySpecified");
			}
		}

		[XmlElement(Order = 64)]
		public decimal Assumed_Student_Number_in_College
		{
			get
			{
				return this.assumed_Student_Number_in_CollegeField;
			}
			set
			{
				this.assumed_Student_Number_in_CollegeField = value;
				this.RaisePropertyChanged("Assumed_Student_Number_in_College");
			}
		}

		[XmlIgnore]
		public bool Assumed_Student_Number_in_CollegeSpecified
		{
			get
			{
				return this.assumed_Student_Number_in_CollegeFieldSpecified;
			}
			set
			{
				this.assumed_Student_Number_in_CollegeFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Student_Number_in_CollegeSpecified");
			}
		}

		[XmlElement(Order = 65)]
		public decimal Assumed_Parents_Number_in_Family
		{
			get
			{
				return this.assumed_Parents_Number_in_FamilyField;
			}
			set
			{
				this.assumed_Parents_Number_in_FamilyField = value;
				this.RaisePropertyChanged("Assumed_Parents_Number_in_Family");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parents_Number_in_FamilySpecified
		{
			get
			{
				return this.assumed_Parents_Number_in_FamilyFieldSpecified;
			}
			set
			{
				this.assumed_Parents_Number_in_FamilyFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parents_Number_in_FamilySpecified");
			}
		}

		[XmlElement(Order = 66)]
		public decimal Assumed_Parents_Number_in_College
		{
			get
			{
				return this.assumed_Parents_Number_in_CollegeField;
			}
			set
			{
				this.assumed_Parents_Number_in_CollegeField = value;
				this.RaisePropertyChanged("Assumed_Parents_Number_in_College");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parents_Number_in_CollegeSpecified
		{
			get
			{
				return this.assumed_Parents_Number_in_CollegeFieldSpecified;
			}
			set
			{
				this.assumed_Parents_Number_in_CollegeFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parents_Number_in_CollegeSpecified");
			}
		}

		[XmlElement(Order = 67)]
		public decimal Assumed_Parents_AGI
		{
			get
			{
				return this.assumed_Parents_AGIField;
			}
			set
			{
				this.assumed_Parents_AGIField = value;
				this.RaisePropertyChanged("Assumed_Parents_AGI");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parents_AGISpecified
		{
			get
			{
				return this.assumed_Parents_AGIFieldSpecified;
			}
			set
			{
				this.assumed_Parents_AGIFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parents_AGISpecified");
			}
		}

		[XmlElement(Order = 68)]
		public decimal Assumed_Parents_US_Tax_Paid
		{
			get
			{
				return this.assumed_Parents_US_Tax_PaidField;
			}
			set
			{
				this.assumed_Parents_US_Tax_PaidField = value;
				this.RaisePropertyChanged("Assumed_Parents_US_Tax_Paid");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parents_US_Tax_PaidSpecified
		{
			get
			{
				return this.assumed_Parents_US_Tax_PaidFieldSpecified;
			}
			set
			{
				this.assumed_Parents_US_Tax_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parents_US_Tax_PaidSpecified");
			}
		}

		[XmlElement(Order = 69)]
		public decimal Assumed_Parents_Additional_Financial_Information_Total
		{
			get
			{
				return this.assumed_Parents_Additional_Financial_Information_TotalField;
			}
			set
			{
				this.assumed_Parents_Additional_Financial_Information_TotalField = value;
				this.RaisePropertyChanged("Assumed_Parents_Additional_Financial_Information_Total");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parents_Additional_Financial_Information_TotalSpecified
		{
			get
			{
				return this.assumed_Parents_Additional_Financial_Information_TotalFieldSpecified;
			}
			set
			{
				this.assumed_Parents_Additional_Financial_Information_TotalFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parents_Additional_Financial_Information_TotalSpecified");
			}
		}

		[XmlElement(Order = 70)]
		public decimal Assumed_Parent_1_Income_Earned_from_Work
		{
			get
			{
				return this.assumed_Parent_1_Income_Earned_from_WorkField;
			}
			set
			{
				this.assumed_Parent_1_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Assumed_Parent_1_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parent_1_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.assumed_Parent_1_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.assumed_Parent_1_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parent_1_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 71)]
		public decimal Secondary_EFC
		{
			get
			{
				return this.secondary_EFCField;
			}
			set
			{
				this.secondary_EFCField = value;
				this.RaisePropertyChanged("Secondary_EFC");
			}
		}

		[XmlIgnore]
		public bool Secondary_EFCSpecified
		{
			get
			{
				return this.secondary_EFCFieldSpecified;
			}
			set
			{
				this.secondary_EFCFieldSpecified = value;
				this.RaisePropertyChanged("Secondary_EFCSpecified");
			}
		}

		[XmlElement(Order = 72)]
		public decimal Assumed_Parent_2_Income_Earned_from_Work
		{
			get
			{
				return this.assumed_Parent_2_Income_Earned_from_WorkField;
			}
			set
			{
				this.assumed_Parent_2_Income_Earned_from_WorkField = value;
				this.RaisePropertyChanged("Assumed_Parent_2_Income_Earned_from_Work");
			}
		}

		[XmlIgnore]
		public bool Assumed_Parent_2_Income_Earned_from_WorkSpecified
		{
			get
			{
				return this.assumed_Parent_2_Income_Earned_from_WorkFieldSpecified;
			}
			set
			{
				this.assumed_Parent_2_Income_Earned_from_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Assumed_Parent_2_Income_Earned_from_WorkSpecified");
			}
		}

		[XmlElement(Order = 73)]
		public decimal Signature_Reject_EFC_Calculated
		{
			get
			{
				return this.signature_Reject_EFC_CalculatedField;
			}
			set
			{
				this.signature_Reject_EFC_CalculatedField = value;
				this.RaisePropertyChanged("Signature_Reject_EFC_Calculated");
			}
		}

		[XmlIgnore]
		public bool Signature_Reject_EFC_CalculatedSpecified
		{
			get
			{
				return this.signature_Reject_EFC_CalculatedFieldSpecified;
			}
			set
			{
				this.signature_Reject_EFC_CalculatedFieldSpecified = value;
				this.RaisePropertyChanged("Signature_Reject_EFC_CalculatedSpecified");
			}
		}

		[XmlElement(Order = 74)]
		public ISIR_EFC_TypeObjectType Primary_EFC_Type_Reference
		{
			get
			{
				return this.primary_EFC_Type_ReferenceField;
			}
			set
			{
				this.primary_EFC_Type_ReferenceField = value;
				this.RaisePropertyChanged("Primary_EFC_Type_Reference");
			}
		}

		[XmlElement(Order = 75)]
		public ISIR_EFC_TypeObjectType Secondary_EFC_Type_Reference
		{
			get
			{
				return this.secondary_EFC_Type_ReferenceField;
			}
			set
			{
				this.secondary_EFC_Type_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_EFC_Type_Reference");
			}
		}

		[XmlElement(Order = 76)]
		public decimal Primary_EFC
		{
			get
			{
				return this.primary_EFCField;
			}
			set
			{
				this.primary_EFCField = value;
				this.RaisePropertyChanged("Primary_EFC");
			}
		}

		[XmlIgnore]
		public bool Primary_EFCSpecified
		{
			get
			{
				return this.primary_EFCFieldSpecified;
			}
			set
			{
				this.primary_EFCFieldSpecified = value;
				this.RaisePropertyChanged("Primary_EFCSpecified");
			}
		}

		[XmlElement(Order = 77)]
		public ISIR_Parent_Marital_StatusObjectType Assumed_Parents_Marital_Status_Reference
		{
			get
			{
				return this.assumed_Parents_Marital_Status_ReferenceField;
			}
			set
			{
				this.assumed_Parents_Marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Parents_Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 78)]
		public ISIR_ResponseObjectType Assumed_Date_of_Birth_Prior_Reference
		{
			get
			{
				return this.assumed_Date_of_Birth_Prior_ReferenceField;
			}
			set
			{
				this.assumed_Date_of_Birth_Prior_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Date_of_Birth_Prior_Reference");
			}
		}

		[XmlElement(Order = 79)]
		public ISIR_ResponseObjectType Assumed_Student_is_Married_Remarried_Reference
		{
			get
			{
				return this.assumed_Student_is_Married_Remarried_ReferenceField;
			}
			set
			{
				this.assumed_Student_is_Married_Remarried_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Student_is_Married_Remarried_Reference");
			}
		}

		[XmlElement(Order = 80)]
		public ISIR_ResponseObjectType Assumed_Have_Children_You_Support_Reference
		{
			get
			{
				return this.assumed_Have_Children_You_Support_ReferenceField;
			}
			set
			{
				this.assumed_Have_Children_You_Support_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Have_Children_You_Support_Reference");
			}
		}

		[XmlElement(Order = 81)]
		public ISIR_ResponseObjectType Assumed_Have_Other_Legal_Dependents_Reference
		{
			get
			{
				return this.assumed_Have_Other_Legal_Dependents_ReferenceField;
			}
			set
			{
				this.assumed_Have_Other_Legal_Dependents_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Have_Other_Legal_Dependents_Reference");
			}
		}

		[XmlElement(Order = 82)]
		public ISIR_ResponseObjectType Assumed_Homeless_Youth_School_Determined_Reference
		{
			get
			{
				return this.assumed_Homeless_Youth_School_Determined_ReferenceField;
			}
			set
			{
				this.assumed_Homeless_Youth_School_Determined_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Homeless_Youth_School_Determined_Reference");
			}
		}

		[XmlElement(Order = 83)]
		public ISIR_ResponseObjectType Assumed_Homeless_Youth_HUD_Determined_Reference
		{
			get
			{
				return this.assumed_Homeless_Youth_HUD_Determined_ReferenceField;
			}
			set
			{
				this.assumed_Homeless_Youth_HUD_Determined_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Homeless_Youth_HUD_Determined_Reference");
			}
		}

		[XmlElement(Order = 84)]
		public ISIR_ResponseObjectType Assumed_At_Risk_of_Homelessness_Reference
		{
			get
			{
				return this.assumed_At_Risk_of_Homelessness_ReferenceField;
			}
			set
			{
				this.assumed_At_Risk_of_Homelessness_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_At_Risk_of_Homelessness_Reference");
			}
		}

		[XmlElement(Order = 85)]
		public ISIR_ResponseObjectType Assumed_Student_Asset_Threshold_Exceeded_Reference
		{
			get
			{
				return this.assumed_Student_Asset_Threshold_Exceeded_ReferenceField;
			}
			set
			{
				this.assumed_Student_Asset_Threshold_Exceeded_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Student_Asset_Threshold_Exceeded_Reference");
			}
		}

		[XmlElement(Order = 86)]
		public ISIR_ResponseObjectType Assumed_Parent_1_SSN_Reference
		{
			get
			{
				return this.assumed_Parent_1_SSN_ReferenceField;
			}
			set
			{
				this.assumed_Parent_1_SSN_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Parent_1_SSN_Reference");
			}
		}

		[XmlElement(Order = 87)]
		public ISIR_ResponseObjectType Assumed_Parent_2_SSN_Reference
		{
			get
			{
				return this.assumed_Parent_2_SSN_ReferenceField;
			}
			set
			{
				this.assumed_Parent_2_SSN_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Parent_2_SSN_Reference");
			}
		}

		[XmlElement(Order = 88)]
		public ISIR_ResponseObjectType Assumed_Parents_Asset_Threshold_Exceeded_Reference
		{
			get
			{
				return this.assumed_Parents_Asset_Threshold_Exceeded_ReferenceField;
			}
			set
			{
				this.assumed_Parents_Asset_Threshold_Exceeded_ReferenceField = value;
				this.RaisePropertyChanged("Assumed_Parents_Asset_Threshold_Exceeded_Reference");
			}
		}

		[XmlElement(Order = 89)]
		public decimal Primary_Alternate_Month_1
		{
			get
			{
				return this.primary_Alternate_Month_1Field;
			}
			set
			{
				this.primary_Alternate_Month_1Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_1");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_1Specified
		{
			get
			{
				return this.primary_Alternate_Month_1FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_1FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_1Specified");
			}
		}

		[XmlElement(Order = 90)]
		public decimal Primary_Alternate_Month_2
		{
			get
			{
				return this.primary_Alternate_Month_2Field;
			}
			set
			{
				this.primary_Alternate_Month_2Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_2");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_2Specified
		{
			get
			{
				return this.primary_Alternate_Month_2FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_2FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_2Specified");
			}
		}

		[XmlElement(Order = 91)]
		public decimal Primary_Alternate_Month_3
		{
			get
			{
				return this.primary_Alternate_Month_3Field;
			}
			set
			{
				this.primary_Alternate_Month_3Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_3");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_3Specified
		{
			get
			{
				return this.primary_Alternate_Month_3FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_3FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_3Specified");
			}
		}

		[XmlElement(Order = 92)]
		public decimal Primary_Alternate_Month_4
		{
			get
			{
				return this.primary_Alternate_Month_4Field;
			}
			set
			{
				this.primary_Alternate_Month_4Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_4");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_4Specified
		{
			get
			{
				return this.primary_Alternate_Month_4FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_4FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_4Specified");
			}
		}

		[XmlElement(Order = 93)]
		public decimal Primary_Alternate_Month_5
		{
			get
			{
				return this.primary_Alternate_Month_5Field;
			}
			set
			{
				this.primary_Alternate_Month_5Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_5");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_5Specified
		{
			get
			{
				return this.primary_Alternate_Month_5FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_5FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_5Specified");
			}
		}

		[XmlElement(Order = 94)]
		public decimal Primary_Alternate_Month_6
		{
			get
			{
				return this.primary_Alternate_Month_6Field;
			}
			set
			{
				this.primary_Alternate_Month_6Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_6");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_6Specified
		{
			get
			{
				return this.primary_Alternate_Month_6FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_6FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_6Specified");
			}
		}

		[XmlElement(Order = 95)]
		public decimal Primary_Alternate_Month_7
		{
			get
			{
				return this.primary_Alternate_Month_7Field;
			}
			set
			{
				this.primary_Alternate_Month_7Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_7");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_7Specified
		{
			get
			{
				return this.primary_Alternate_Month_7FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_7FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_7Specified");
			}
		}

		[XmlElement(Order = 96)]
		public decimal Primary_Alternate_Month_8
		{
			get
			{
				return this.primary_Alternate_Month_8Field;
			}
			set
			{
				this.primary_Alternate_Month_8Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_8");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_8Specified
		{
			get
			{
				return this.primary_Alternate_Month_8FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_8FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_8Specified");
			}
		}

		[XmlElement(Order = 97)]
		public decimal Primary_Alternate_Month_10
		{
			get
			{
				return this.primary_Alternate_Month_10Field;
			}
			set
			{
				this.primary_Alternate_Month_10Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_10");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_10Specified
		{
			get
			{
				return this.primary_Alternate_Month_10FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_10FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_10Specified");
			}
		}

		[XmlElement(Order = 98)]
		public decimal Primary_Alternate_Month_11
		{
			get
			{
				return this.primary_Alternate_Month_11Field;
			}
			set
			{
				this.primary_Alternate_Month_11Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_11");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_11Specified
		{
			get
			{
				return this.primary_Alternate_Month_11FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_11FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_11Specified");
			}
		}

		[XmlElement(Order = 99)]
		public decimal Primary_Alternate_Month_12
		{
			get
			{
				return this.primary_Alternate_Month_12Field;
			}
			set
			{
				this.primary_Alternate_Month_12Field = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_12");
			}
		}

		[XmlIgnore]
		public bool Primary_Alternate_Month_12Specified
		{
			get
			{
				return this.primary_Alternate_Month_12FieldSpecified;
			}
			set
			{
				this.primary_Alternate_Month_12FieldSpecified = value;
				this.RaisePropertyChanged("Primary_Alternate_Month_12Specified");
			}
		}

		[XmlElement(Order = 100)]
		public decimal Secondary_Alternate_Month_1
		{
			get
			{
				return this.secondary_Alternate_Month_1Field;
			}
			set
			{
				this.secondary_Alternate_Month_1Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_1");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_1Specified
		{
			get
			{
				return this.secondary_Alternate_Month_1FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_1FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_1Specified");
			}
		}

		[XmlElement(Order = 101)]
		public decimal Secondary_Alternate_Month_2
		{
			get
			{
				return this.secondary_Alternate_Month_2Field;
			}
			set
			{
				this.secondary_Alternate_Month_2Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_2");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_2Specified
		{
			get
			{
				return this.secondary_Alternate_Month_2FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_2FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_2Specified");
			}
		}

		[XmlElement(Order = 102)]
		public decimal Secondary_Alternate_Month_3
		{
			get
			{
				return this.secondary_Alternate_Month_3Field;
			}
			set
			{
				this.secondary_Alternate_Month_3Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_3");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_3Specified
		{
			get
			{
				return this.secondary_Alternate_Month_3FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_3FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_3Specified");
			}
		}

		[XmlElement(Order = 103)]
		public decimal Secondary_Alternate_Month_4
		{
			get
			{
				return this.secondary_Alternate_Month_4Field;
			}
			set
			{
				this.secondary_Alternate_Month_4Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_4");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_4Specified
		{
			get
			{
				return this.secondary_Alternate_Month_4FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_4FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_4Specified");
			}
		}

		[XmlElement(Order = 104)]
		public decimal Secondary_Alternate_Month_5
		{
			get
			{
				return this.secondary_Alternate_Month_5Field;
			}
			set
			{
				this.secondary_Alternate_Month_5Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_5");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_5Specified
		{
			get
			{
				return this.secondary_Alternate_Month_5FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_5FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_5Specified");
			}
		}

		[XmlElement(Order = 105)]
		public decimal Secondary_Alternate_Month_6
		{
			get
			{
				return this.secondary_Alternate_Month_6Field;
			}
			set
			{
				this.secondary_Alternate_Month_6Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_6");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_6Specified
		{
			get
			{
				return this.secondary_Alternate_Month_6FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_6FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_6Specified");
			}
		}

		[XmlElement(Order = 106)]
		public decimal Secondary_Alternate_Month_7
		{
			get
			{
				return this.secondary_Alternate_Month_7Field;
			}
			set
			{
				this.secondary_Alternate_Month_7Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_7");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_7Specified
		{
			get
			{
				return this.secondary_Alternate_Month_7FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_7FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_7Specified");
			}
		}

		[XmlElement(Order = 107)]
		public decimal Secondary_Alternate_Month_8
		{
			get
			{
				return this.secondary_Alternate_Month_8Field;
			}
			set
			{
				this.secondary_Alternate_Month_8Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_8");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_8Specified
		{
			get
			{
				return this.secondary_Alternate_Month_8FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_8FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_8Specified");
			}
		}

		[XmlElement(Order = 108)]
		public decimal Secondary_Alternate_Month_10
		{
			get
			{
				return this.secondary_Alternate_Month_10Field;
			}
			set
			{
				this.secondary_Alternate_Month_10Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_10");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_10Specified
		{
			get
			{
				return this.secondary_Alternate_Month_10FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_10FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_10Specified");
			}
		}

		[XmlElement(Order = 109)]
		public decimal Secondary_Alternate_Month_11
		{
			get
			{
				return this.secondary_Alternate_Month_11Field;
			}
			set
			{
				this.secondary_Alternate_Month_11Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_11");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_11Specified
		{
			get
			{
				return this.secondary_Alternate_Month_11FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_11FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_11Specified");
			}
		}

		[XmlElement(Order = 110)]
		public decimal Secondary_Alternate_Month_12
		{
			get
			{
				return this.secondary_Alternate_Month_12Field;
			}
			set
			{
				this.secondary_Alternate_Month_12Field = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_12");
			}
		}

		[XmlIgnore]
		public bool Secondary_Alternate_Month_12Specified
		{
			get
			{
				return this.secondary_Alternate_Month_12FieldSpecified;
			}
			set
			{
				this.secondary_Alternate_Month_12FieldSpecified = value;
				this.RaisePropertyChanged("Secondary_Alternate_Month_12Specified");
			}
		}

		[XmlElement(Order = 111)]
		public decimal TI_Total_Income
		{
			get
			{
				return this.tI_Total_IncomeField;
			}
			set
			{
				this.tI_Total_IncomeField = value;
				this.RaisePropertyChanged("TI_Total_Income");
			}
		}

		[XmlIgnore]
		public bool TI_Total_IncomeSpecified
		{
			get
			{
				return this.tI_Total_IncomeFieldSpecified;
			}
			set
			{
				this.tI_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("TI_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 112)]
		public decimal ATI_Allowances_Against_Total_Income
		{
			get
			{
				return this.aTI_Allowances_Against_Total_IncomeField;
			}
			set
			{
				this.aTI_Allowances_Against_Total_IncomeField = value;
				this.RaisePropertyChanged("ATI_Allowances_Against_Total_Income");
			}
		}

		[XmlIgnore]
		public bool ATI_Allowances_Against_Total_IncomeSpecified
		{
			get
			{
				return this.aTI_Allowances_Against_Total_IncomeFieldSpecified;
			}
			set
			{
				this.aTI_Allowances_Against_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("ATI_Allowances_Against_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 113)]
		public decimal STX_State_and_Other_Tax_Allowance
		{
			get
			{
				return this.sTX_State_and_Other_Tax_AllowanceField;
			}
			set
			{
				this.sTX_State_and_Other_Tax_AllowanceField = value;
				this.RaisePropertyChanged("STX_State_and_Other_Tax_Allowance");
			}
		}

		[XmlIgnore]
		public bool STX_State_and_Other_Tax_AllowanceSpecified
		{
			get
			{
				return this.sTX_State_and_Other_Tax_AllowanceFieldSpecified;
			}
			set
			{
				this.sTX_State_and_Other_Tax_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("STX_State_and_Other_Tax_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 114)]
		public decimal EA_Employment_Allowance
		{
			get
			{
				return this.eA_Employment_AllowanceField;
			}
			set
			{
				this.eA_Employment_AllowanceField = value;
				this.RaisePropertyChanged("EA_Employment_Allowance");
			}
		}

		[XmlIgnore]
		public bool EA_Employment_AllowanceSpecified
		{
			get
			{
				return this.eA_Employment_AllowanceFieldSpecified;
			}
			set
			{
				this.eA_Employment_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("EA_Employment_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 115)]
		public decimal IPA_Income_Protection_Allowance
		{
			get
			{
				return this.iPA_Income_Protection_AllowanceField;
			}
			set
			{
				this.iPA_Income_Protection_AllowanceField = value;
				this.RaisePropertyChanged("IPA_Income_Protection_Allowance");
			}
		}

		[XmlIgnore]
		public bool IPA_Income_Protection_AllowanceSpecified
		{
			get
			{
				return this.iPA_Income_Protection_AllowanceFieldSpecified;
			}
			set
			{
				this.iPA_Income_Protection_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("IPA_Income_Protection_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 116)]
		public decimal AI_Available_Income
		{
			get
			{
				return this.aI_Available_IncomeField;
			}
			set
			{
				this.aI_Available_IncomeField = value;
				this.RaisePropertyChanged("AI_Available_Income");
			}
		}

		[XmlIgnore]
		public bool AI_Available_IncomeSpecified
		{
			get
			{
				return this.aI_Available_IncomeFieldSpecified;
			}
			set
			{
				this.aI_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("AI_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 117)]
		public decimal CAI_Contribution_from_Available_Income
		{
			get
			{
				return this.cAI_Contribution_from_Available_IncomeField;
			}
			set
			{
				this.cAI_Contribution_from_Available_IncomeField = value;
				this.RaisePropertyChanged("CAI_Contribution_from_Available_Income");
			}
		}

		[XmlIgnore]
		public bool CAI_Contribution_from_Available_IncomeSpecified
		{
			get
			{
				return this.cAI_Contribution_from_Available_IncomeFieldSpecified;
			}
			set
			{
				this.cAI_Contribution_from_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("CAI_Contribution_from_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 118)]
		public decimal DNW_Discretionary_Net_Worth
		{
			get
			{
				return this.dNW_Discretionary_Net_WorthField;
			}
			set
			{
				this.dNW_Discretionary_Net_WorthField = value;
				this.RaisePropertyChanged("DNW_Discretionary_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool DNW_Discretionary_Net_WorthSpecified
		{
			get
			{
				return this.dNW_Discretionary_Net_WorthFieldSpecified;
			}
			set
			{
				this.dNW_Discretionary_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("DNW_Discretionary_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 119)]
		public decimal NW_Net_Worth
		{
			get
			{
				return this.nW_Net_WorthField;
			}
			set
			{
				this.nW_Net_WorthField = value;
				this.RaisePropertyChanged("NW_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool NW_Net_WorthSpecified
		{
			get
			{
				return this.nW_Net_WorthFieldSpecified;
			}
			set
			{
				this.nW_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("NW_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 120)]
		public decimal APA_Asset_Protection_Allowance
		{
			get
			{
				return this.aPA_Asset_Protection_AllowanceField;
			}
			set
			{
				this.aPA_Asset_Protection_AllowanceField = value;
				this.RaisePropertyChanged("APA_Asset_Protection_Allowance");
			}
		}

		[XmlIgnore]
		public bool APA_Asset_Protection_AllowanceSpecified
		{
			get
			{
				return this.aPA_Asset_Protection_AllowanceFieldSpecified;
			}
			set
			{
				this.aPA_Asset_Protection_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("APA_Asset_Protection_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 121)]
		public decimal PCA_Parents_Contribution_from_Assets
		{
			get
			{
				return this.pCA_Parents_Contribution_from_AssetsField;
			}
			set
			{
				this.pCA_Parents_Contribution_from_AssetsField = value;
				this.RaisePropertyChanged("PCA_Parents_Contribution_from_Assets");
			}
		}

		[XmlIgnore]
		public bool PCA_Parents_Contribution_from_AssetsSpecified
		{
			get
			{
				return this.pCA_Parents_Contribution_from_AssetsFieldSpecified;
			}
			set
			{
				this.pCA_Parents_Contribution_from_AssetsFieldSpecified = value;
				this.RaisePropertyChanged("PCA_Parents_Contribution_from_AssetsSpecified");
			}
		}

		[XmlElement(Order = 122)]
		public decimal AAI_Adjusted_Available_Income
		{
			get
			{
				return this.aAI_Adjusted_Available_IncomeField;
			}
			set
			{
				this.aAI_Adjusted_Available_IncomeField = value;
				this.RaisePropertyChanged("AAI_Adjusted_Available_Income");
			}
		}

		[XmlIgnore]
		public bool AAI_Adjusted_Available_IncomeSpecified
		{
			get
			{
				return this.aAI_Adjusted_Available_IncomeFieldSpecified;
			}
			set
			{
				this.aAI_Adjusted_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("AAI_Adjusted_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 123)]
		public decimal TSC_Total_Student_Contribution
		{
			get
			{
				return this.tSC_Total_Student_ContributionField;
			}
			set
			{
				this.tSC_Total_Student_ContributionField = value;
				this.RaisePropertyChanged("TSC_Total_Student_Contribution");
			}
		}

		[XmlIgnore]
		public bool TSC_Total_Student_ContributionSpecified
		{
			get
			{
				return this.tSC_Total_Student_ContributionFieldSpecified;
			}
			set
			{
				this.tSC_Total_Student_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("TSC_Total_Student_ContributionSpecified");
			}
		}

		[XmlElement(Order = 124)]
		public decimal TPC_Total_Parents_Contribution
		{
			get
			{
				return this.tPC_Total_Parents_ContributionField;
			}
			set
			{
				this.tPC_Total_Parents_ContributionField = value;
				this.RaisePropertyChanged("TPC_Total_Parents_Contribution");
			}
		}

		[XmlIgnore]
		public bool TPC_Total_Parents_ContributionSpecified
		{
			get
			{
				return this.tPC_Total_Parents_ContributionFieldSpecified;
			}
			set
			{
				this.tPC_Total_Parents_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("TPC_Total_Parents_ContributionSpecified");
			}
		}

		[XmlElement(Order = 125)]
		public decimal PC_Parents_Contribution
		{
			get
			{
				return this.pC_Parents_ContributionField;
			}
			set
			{
				this.pC_Parents_ContributionField = value;
				this.RaisePropertyChanged("PC_Parents_Contribution");
			}
		}

		[XmlIgnore]
		public bool PC_Parents_ContributionSpecified
		{
			get
			{
				return this.pC_Parents_ContributionFieldSpecified;
			}
			set
			{
				this.pC_Parents_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("PC_Parents_ContributionSpecified");
			}
		}

		[XmlElement(Order = 126)]
		public decimal STI_Student_Total_Income
		{
			get
			{
				return this.sTI_Student_Total_IncomeField;
			}
			set
			{
				this.sTI_Student_Total_IncomeField = value;
				this.RaisePropertyChanged("STI_Student_Total_Income");
			}
		}

		[XmlIgnore]
		public bool STI_Student_Total_IncomeSpecified
		{
			get
			{
				return this.sTI_Student_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sTI_Student_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("STI_Student_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 127)]
		public decimal SATI_Student_Allowance_Against_Total_Income
		{
			get
			{
				return this.sATI_Student_Allowance_Against_Total_IncomeField;
			}
			set
			{
				this.sATI_Student_Allowance_Against_Total_IncomeField = value;
				this.RaisePropertyChanged("SATI_Student_Allowance_Against_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SATI_Student_Allowance_Against_Total_IncomeSpecified
		{
			get
			{
				return this.sATI_Student_Allowance_Against_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sATI_Student_Allowance_Against_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SATI_Student_Allowance_Against_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 128)]
		public decimal SIC_Dependent_Student_Income_Contribution
		{
			get
			{
				return this.sIC_Dependent_Student_Income_ContributionField;
			}
			set
			{
				this.sIC_Dependent_Student_Income_ContributionField = value;
				this.RaisePropertyChanged("SIC_Dependent_Student_Income_Contribution");
			}
		}

		[XmlIgnore]
		public bool SIC_Dependent_Student_Income_ContributionSpecified
		{
			get
			{
				return this.sIC_Dependent_Student_Income_ContributionFieldSpecified;
			}
			set
			{
				this.sIC_Dependent_Student_Income_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("SIC_Dependent_Student_Income_ContributionSpecified");
			}
		}

		[XmlElement(Order = 129)]
		public decimal SDNW_Student_Discretionary_Net_Worth
		{
			get
			{
				return this.sDNW_Student_Discretionary_Net_WorthField;
			}
			set
			{
				this.sDNW_Student_Discretionary_Net_WorthField = value;
				this.RaisePropertyChanged("SDNW_Student_Discretionary_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool SDNW_Student_Discretionary_Net_WorthSpecified
		{
			get
			{
				return this.sDNW_Student_Discretionary_Net_WorthFieldSpecified;
			}
			set
			{
				this.sDNW_Student_Discretionary_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("SDNW_Student_Discretionary_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 130)]
		public decimal SCA_Student_Contribution_from_Assets
		{
			get
			{
				return this.sCA_Student_Contribution_from_AssetsField;
			}
			set
			{
				this.sCA_Student_Contribution_from_AssetsField = value;
				this.RaisePropertyChanged("SCA_Student_Contribution_from_Assets");
			}
		}

		[XmlIgnore]
		public bool SCA_Student_Contribution_from_AssetsSpecified
		{
			get
			{
				return this.sCA_Student_Contribution_from_AssetsFieldSpecified;
			}
			set
			{
				this.sCA_Student_Contribution_from_AssetsFieldSpecified = value;
				this.RaisePropertyChanged("SCA_Student_Contribution_from_AssetsSpecified");
			}
		}

		[XmlElement(Order = 131)]
		public decimal FTI_FISAP_Total
		{
			get
			{
				return this.fTI_FISAP_TotalField;
			}
			set
			{
				this.fTI_FISAP_TotalField = value;
				this.RaisePropertyChanged("FTI_FISAP_Total");
			}
		}

		[XmlIgnore]
		public bool FTI_FISAP_TotalSpecified
		{
			get
			{
				return this.fTI_FISAP_TotalFieldSpecified;
			}
			set
			{
				this.fTI_FISAP_TotalFieldSpecified = value;
				this.RaisePropertyChanged("FTI_FISAP_TotalSpecified");
			}
		}

		[XmlElement(Order = 132)]
		public decimal SEC_TI_Secondary_Total_Income
		{
			get
			{
				return this.sEC_TI_Secondary_Total_IncomeField;
			}
			set
			{
				this.sEC_TI_Secondary_Total_IncomeField = value;
				this.RaisePropertyChanged("SEC_TI_Secondary_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_TI_Secondary_Total_IncomeSpecified
		{
			get
			{
				return this.sEC_TI_Secondary_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_TI_Secondary_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_TI_Secondary_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 133)]
		public decimal SEC_ATI_Secondary_Allowances_Against_Total_Income
		{
			get
			{
				return this.sEC_ATI_Secondary_Allowances_Against_Total_IncomeField;
			}
			set
			{
				this.sEC_ATI_Secondary_Allowances_Against_Total_IncomeField = value;
				this.RaisePropertyChanged("SEC_ATI_Secondary_Allowances_Against_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_ATI_Secondary_Allowances_Against_Total_IncomeSpecified
		{
			get
			{
				return this.sEC_ATI_Secondary_Allowances_Against_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_ATI_Secondary_Allowances_Against_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_ATI_Secondary_Allowances_Against_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 134)]
		public decimal SEC_STX_Secondary_State_Tax_Allowance
		{
			get
			{
				return this.sEC_STX_Secondary_State_Tax_AllowanceField;
			}
			set
			{
				this.sEC_STX_Secondary_State_Tax_AllowanceField = value;
				this.RaisePropertyChanged("SEC_STX_Secondary_State_Tax_Allowance");
			}
		}

		[XmlIgnore]
		public bool SEC_STX_Secondary_State_Tax_AllowanceSpecified
		{
			get
			{
				return this.sEC_STX_Secondary_State_Tax_AllowanceFieldSpecified;
			}
			set
			{
				this.sEC_STX_Secondary_State_Tax_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("SEC_STX_Secondary_State_Tax_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 135)]
		public decimal SEC_EA_Secondary_Employment_Allowance
		{
			get
			{
				return this.sEC_EA_Secondary_Employment_AllowanceField;
			}
			set
			{
				this.sEC_EA_Secondary_Employment_AllowanceField = value;
				this.RaisePropertyChanged("SEC_EA_Secondary_Employment_Allowance");
			}
		}

		[XmlIgnore]
		public bool SEC_EA_Secondary_Employment_AllowanceSpecified
		{
			get
			{
				return this.sEC_EA_Secondary_Employment_AllowanceFieldSpecified;
			}
			set
			{
				this.sEC_EA_Secondary_Employment_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("SEC_EA_Secondary_Employment_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 136)]
		public decimal SEC_IPA_Secondary_Income_Protection_Allowance
		{
			get
			{
				return this.sEC_IPA_Secondary_Income_Protection_AllowanceField;
			}
			set
			{
				this.sEC_IPA_Secondary_Income_Protection_AllowanceField = value;
				this.RaisePropertyChanged("SEC_IPA_Secondary_Income_Protection_Allowance");
			}
		}

		[XmlIgnore]
		public bool SEC_IPA_Secondary_Income_Protection_AllowanceSpecified
		{
			get
			{
				return this.sEC_IPA_Secondary_Income_Protection_AllowanceFieldSpecified;
			}
			set
			{
				this.sEC_IPA_Secondary_Income_Protection_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("SEC_IPA_Secondary_Income_Protection_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 137)]
		public decimal SEC_AI_Secondary_Available_Income
		{
			get
			{
				return this.sEC_AI_Secondary_Available_IncomeField;
			}
			set
			{
				this.sEC_AI_Secondary_Available_IncomeField = value;
				this.RaisePropertyChanged("SEC_AI_Secondary_Available_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_AI_Secondary_Available_IncomeSpecified
		{
			get
			{
				return this.sEC_AI_Secondary_Available_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_AI_Secondary_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_AI_Secondary_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 138)]
		public decimal SEC_CAI_Secondary_Contribution_From_Available_Income
		{
			get
			{
				return this.sEC_CAI_Secondary_Contribution_From_Available_IncomeField;
			}
			set
			{
				this.sEC_CAI_Secondary_Contribution_From_Available_IncomeField = value;
				this.RaisePropertyChanged("SEC_CAI_Secondary_Contribution_From_Available_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_CAI_Secondary_Contribution_From_Available_IncomeSpecified
		{
			get
			{
				return this.sEC_CAI_Secondary_Contribution_From_Available_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_CAI_Secondary_Contribution_From_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_CAI_Secondary_Contribution_From_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 139)]
		public decimal SEC_DNW_Secondary_Discretionary_Net_Worth
		{
			get
			{
				return this.sEC_DNW_Secondary_Discretionary_Net_WorthField;
			}
			set
			{
				this.sEC_DNW_Secondary_Discretionary_Net_WorthField = value;
				this.RaisePropertyChanged("SEC_DNW_Secondary_Discretionary_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool SEC_DNW_Secondary_Discretionary_Net_WorthSpecified
		{
			get
			{
				return this.sEC_DNW_Secondary_Discretionary_Net_WorthFieldSpecified;
			}
			set
			{
				this.sEC_DNW_Secondary_Discretionary_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("SEC_DNW_Secondary_Discretionary_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 140)]
		public decimal SEC_NW_Secondary_Net_Worth
		{
			get
			{
				return this.sEC_NW_Secondary_Net_WorthField;
			}
			set
			{
				this.sEC_NW_Secondary_Net_WorthField = value;
				this.RaisePropertyChanged("SEC_NW_Secondary_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool SEC_NW_Secondary_Net_WorthSpecified
		{
			get
			{
				return this.sEC_NW_Secondary_Net_WorthFieldSpecified;
			}
			set
			{
				this.sEC_NW_Secondary_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("SEC_NW_Secondary_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 141)]
		public decimal SEC_APA_Secondary_Asset_Protection_Allowance
		{
			get
			{
				return this.sEC_APA_Secondary_Asset_Protection_AllowanceField;
			}
			set
			{
				this.sEC_APA_Secondary_Asset_Protection_AllowanceField = value;
				this.RaisePropertyChanged("SEC_APA_Secondary_Asset_Protection_Allowance");
			}
		}

		[XmlIgnore]
		public bool SEC_APA_Secondary_Asset_Protection_AllowanceSpecified
		{
			get
			{
				return this.sEC_APA_Secondary_Asset_Protection_AllowanceFieldSpecified;
			}
			set
			{
				this.sEC_APA_Secondary_Asset_Protection_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("SEC_APA_Secondary_Asset_Protection_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 142)]
		public decimal SEC_PCA_Secondary_Parents_Contribution_from_Assets
		{
			get
			{
				return this.sEC_PCA_Secondary_Parents_Contribution_from_AssetsField;
			}
			set
			{
				this.sEC_PCA_Secondary_Parents_Contribution_from_AssetsField = value;
				this.RaisePropertyChanged("SEC_PCA_Secondary_Parents_Contribution_from_Assets");
			}
		}

		[XmlIgnore]
		public bool SEC_PCA_Secondary_Parents_Contribution_from_AssetsSpecified
		{
			get
			{
				return this.sEC_PCA_Secondary_Parents_Contribution_from_AssetsFieldSpecified;
			}
			set
			{
				this.sEC_PCA_Secondary_Parents_Contribution_from_AssetsFieldSpecified = value;
				this.RaisePropertyChanged("SEC_PCA_Secondary_Parents_Contribution_from_AssetsSpecified");
			}
		}

		[XmlElement(Order = 143)]
		public decimal SEC_AAI_Secondary_Adjusted_Available_Income
		{
			get
			{
				return this.sEC_AAI_Secondary_Adjusted_Available_IncomeField;
			}
			set
			{
				this.sEC_AAI_Secondary_Adjusted_Available_IncomeField = value;
				this.RaisePropertyChanged("SEC_AAI_Secondary_Adjusted_Available_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_AAI_Secondary_Adjusted_Available_IncomeSpecified
		{
			get
			{
				return this.sEC_AAI_Secondary_Adjusted_Available_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_AAI_Secondary_Adjusted_Available_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_AAI_Secondary_Adjusted_Available_IncomeSpecified");
			}
		}

		[XmlElement(Order = 144)]
		public decimal SEC_TSC_Secondary_Total_Student_Contribution
		{
			get
			{
				return this.sEC_TSC_Secondary_Total_Student_ContributionField;
			}
			set
			{
				this.sEC_TSC_Secondary_Total_Student_ContributionField = value;
				this.RaisePropertyChanged("SEC_TSC_Secondary_Total_Student_Contribution");
			}
		}

		[XmlIgnore]
		public bool SEC_TSC_Secondary_Total_Student_ContributionSpecified
		{
			get
			{
				return this.sEC_TSC_Secondary_Total_Student_ContributionFieldSpecified;
			}
			set
			{
				this.sEC_TSC_Secondary_Total_Student_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("SEC_TSC_Secondary_Total_Student_ContributionSpecified");
			}
		}

		[XmlElement(Order = 145)]
		public decimal SEC_TPC_Secondary_Total_Parents_Contribution
		{
			get
			{
				return this.sEC_TPC_Secondary_Total_Parents_ContributionField;
			}
			set
			{
				this.sEC_TPC_Secondary_Total_Parents_ContributionField = value;
				this.RaisePropertyChanged("SEC_TPC_Secondary_Total_Parents_Contribution");
			}
		}

		[XmlIgnore]
		public bool SEC_TPC_Secondary_Total_Parents_ContributionSpecified
		{
			get
			{
				return this.sEC_TPC_Secondary_Total_Parents_ContributionFieldSpecified;
			}
			set
			{
				this.sEC_TPC_Secondary_Total_Parents_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("SEC_TPC_Secondary_Total_Parents_ContributionSpecified");
			}
		}

		[XmlElement(Order = 146)]
		public decimal SEC_PC_Secondary_Parents_Contribution
		{
			get
			{
				return this.sEC_PC_Secondary_Parents_ContributionField;
			}
			set
			{
				this.sEC_PC_Secondary_Parents_ContributionField = value;
				this.RaisePropertyChanged("SEC_PC_Secondary_Parents_Contribution");
			}
		}

		[XmlIgnore]
		public bool SEC_PC_Secondary_Parents_ContributionSpecified
		{
			get
			{
				return this.sEC_PC_Secondary_Parents_ContributionFieldSpecified;
			}
			set
			{
				this.sEC_PC_Secondary_Parents_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("SEC_PC_Secondary_Parents_ContributionSpecified");
			}
		}

		[XmlElement(Order = 147)]
		public decimal SEC_STI_Secondary_Student_Total_Income
		{
			get
			{
				return this.sEC_STI_Secondary_Student_Total_IncomeField;
			}
			set
			{
				this.sEC_STI_Secondary_Student_Total_IncomeField = value;
				this.RaisePropertyChanged("SEC_STI_Secondary_Student_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_STI_Secondary_Student_Total_IncomeSpecified
		{
			get
			{
				return this.sEC_STI_Secondary_Student_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_STI_Secondary_Student_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_STI_Secondary_Student_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 148)]
		public decimal SEC_SATI_Secondary_Student_Allowance_Against_Total_Income
		{
			get
			{
				return this.sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeField;
			}
			set
			{
				this.sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeField = value;
				this.RaisePropertyChanged("SEC_SATI_Secondary_Student_Allowance_Against_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeSpecified
		{
			get
			{
				return this.sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_SATI_Secondary_Student_Allowance_Against_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 149)]
		public decimal SEC_SIC_Secondary_Student_Dependent_Income_Contribution
		{
			get
			{
				return this.sEC_SIC_Secondary_Student_Dependent_Income_ContributionField;
			}
			set
			{
				this.sEC_SIC_Secondary_Student_Dependent_Income_ContributionField = value;
				this.RaisePropertyChanged("SEC_SIC_Secondary_Student_Dependent_Income_Contribution");
			}
		}

		[XmlIgnore]
		public bool SEC_SIC_Secondary_Student_Dependent_Income_ContributionSpecified
		{
			get
			{
				return this.sEC_SIC_Secondary_Student_Dependent_Income_ContributionFieldSpecified;
			}
			set
			{
				this.sEC_SIC_Secondary_Student_Dependent_Income_ContributionFieldSpecified = value;
				this.RaisePropertyChanged("SEC_SIC_Secondary_Student_Dependent_Income_ContributionSpecified");
			}
		}

		[XmlElement(Order = 150)]
		public decimal SEC_SDNW_Secondary_Student_Discretionary_Net_Worth
		{
			get
			{
				return this.sEC_SDNW_Secondary_Student_Discretionary_Net_WorthField;
			}
			set
			{
				this.sEC_SDNW_Secondary_Student_Discretionary_Net_WorthField = value;
				this.RaisePropertyChanged("SEC_SDNW_Secondary_Student_Discretionary_Net_Worth");
			}
		}

		[XmlIgnore]
		public bool SEC_SDNW_Secondary_Student_Discretionary_Net_WorthSpecified
		{
			get
			{
				return this.sEC_SDNW_Secondary_Student_Discretionary_Net_WorthFieldSpecified;
			}
			set
			{
				this.sEC_SDNW_Secondary_Student_Discretionary_Net_WorthFieldSpecified = value;
				this.RaisePropertyChanged("SEC_SDNW_Secondary_Student_Discretionary_Net_WorthSpecified");
			}
		}

		[XmlElement(Order = 151)]
		public decimal SEC_SCA_Secondary_Student_Contribution_from_Assets
		{
			get
			{
				return this.sEC_SCA_Secondary_Student_Contribution_from_AssetsField;
			}
			set
			{
				this.sEC_SCA_Secondary_Student_Contribution_from_AssetsField = value;
				this.RaisePropertyChanged("SEC_SCA_Secondary_Student_Contribution_from_Assets");
			}
		}

		[XmlIgnore]
		public bool SEC_SCA_Secondary_Student_Contribution_from_AssetsSpecified
		{
			get
			{
				return this.sEC_SCA_Secondary_Student_Contribution_from_AssetsFieldSpecified;
			}
			set
			{
				this.sEC_SCA_Secondary_Student_Contribution_from_AssetsFieldSpecified = value;
				this.RaisePropertyChanged("SEC_SCA_Secondary_Student_Contribution_from_AssetsSpecified");
			}
		}

		[XmlElement(Order = 152)]
		public decimal SEC_FTI_Secondary_FISAP_Total_Income
		{
			get
			{
				return this.sEC_FTI_Secondary_FISAP_Total_IncomeField;
			}
			set
			{
				this.sEC_FTI_Secondary_FISAP_Total_IncomeField = value;
				this.RaisePropertyChanged("SEC_FTI_Secondary_FISAP_Total_Income");
			}
		}

		[XmlIgnore]
		public bool SEC_FTI_Secondary_FISAP_Total_IncomeSpecified
		{
			get
			{
				return this.sEC_FTI_Secondary_FISAP_Total_IncomeFieldSpecified;
			}
			set
			{
				this.sEC_FTI_Secondary_FISAP_Total_IncomeFieldSpecified = value;
				this.RaisePropertyChanged("SEC_FTI_Secondary_FISAP_Total_IncomeSpecified");
			}
		}

		[XmlElement(Order = 153)]
		public ISIR_DHS_Match_FlagObjectType DHS_Match_Flag_Reference
		{
			get
			{
				return this.dHS_Match_Flag_ReferenceField;
			}
			set
			{
				this.dHS_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("DHS_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 154)]
		public ISIR_Secondary_DHS_Match_FlagObjectType Secondary_DHS_Match_Flag_Reference
		{
			get
			{
				return this.secondary_DHS_Match_Flag_ReferenceField;
			}
			set
			{
				this.secondary_DHS_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Secondary_DHS_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 155)]
		public ISIR_NSLDS_Match_FlagObjectType NSLDS_Match_Flag_Reference
		{
			get
			{
				return this.nSLDS_Match_Flag_ReferenceField;
			}
			set
			{
				this.nSLDS_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("NSLDS_Match_Flag_Reference");
			}
		}

		[XmlElement("NSLDS_Postscreening_Reason_Code_Reference", Order = 156)]
		public ISIR_NSLDS_Post_Screening_Reason_CodeObjectType[] NSLDS_Postscreening_Reason_Code_Reference
		{
			get
			{
				return this.nSLDS_Postscreening_Reason_Code_ReferenceField;
			}
			set
			{
				this.nSLDS_Postscreening_Reason_Code_ReferenceField = value;
				this.RaisePropertyChanged("NSLDS_Postscreening_Reason_Code_Reference");
			}
		}

		[XmlElement(Order = 157)]
		public ISIR_SSN_Match_FlagObjectType Parent_1_SSN_Match_Flag_Reference
		{
			get
			{
				return this.parent_1_SSN_Match_Flag_ReferenceField;
			}
			set
			{
				this.parent_1_SSN_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Parent_1_SSN_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 158)]
		public ISIR_SSN_Match_FlagObjectType Parent_2_SSN_Match_Flag_Reference
		{
			get
			{
				return this.parent_2_SSN_Match_Flag_ReferenceField;
			}
			set
			{
				this.parent_2_SSN_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Parent_2_SSN_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 159)]
		public ISIR_Selective_Service_FlagObjectType Selective_Service_Match_Flag_Reference
		{
			get
			{
				return this.selective_Service_Match_Flag_ReferenceField;
			}
			set
			{
				this.selective_Service_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Selective_Service_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 160)]
		public ISIR_Selective_Service_FlagObjectType Selective_Service_Registration_Flag_Reference
		{
			get
			{
				return this.selective_Service_Registration_Flag_ReferenceField;
			}
			set
			{
				this.selective_Service_Registration_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Selective_Service_Registration_Flag_Reference");
			}
		}

		[XmlElement(Order = 161)]
		public ISIR_SSA_Citizenship_FlagObjectType SSA_Citizenship_Flag_Reference
		{
			get
			{
				return this.sSA_Citizenship_Flag_ReferenceField;
			}
			set
			{
				this.sSA_Citizenship_Flag_ReferenceField = value;
				this.RaisePropertyChanged("SSA_Citizenship_Flag_Reference");
			}
		}

		[XmlElement(Order = 162)]
		public ISIR_SSN_Match_FlagObjectType Student_SSN_Match_Flag_Reference
		{
			get
			{
				return this.student_SSN_Match_Flag_ReferenceField;
			}
			set
			{
				this.student_SSN_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Student_SSN_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 163)]
		public ISIR_VA_Match_FlagObjectType VA_Match_Flag_Reference
		{
			get
			{
				return this.vA_Match_Flag_ReferenceField;
			}
			set
			{
				this.vA_Match_Flag_ReferenceField = value;
				this.RaisePropertyChanged("VA_Match_Flag_Reference");
			}
		}

		[XmlElement(Order = 164)]
		public bool DOD_Match_Flag
		{
			get
			{
				return this.dOD_Match_FlagField;
			}
			set
			{
				this.dOD_Match_FlagField = value;
				this.RaisePropertyChanged("DOD_Match_Flag");
			}
		}

		[XmlIgnore]
		public bool DOD_Match_FlagSpecified
		{
			get
			{
				return this.dOD_Match_FlagFieldSpecified;
			}
			set
			{
				this.dOD_Match_FlagFieldSpecified = value;
				this.RaisePropertyChanged("DOD_Match_FlagSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 165)]
		public DateTime DOD_Parent_Date_of_Death
		{
			get
			{
				return this.dOD_Parent_Date_of_DeathField;
			}
			set
			{
				this.dOD_Parent_Date_of_DeathField = value;
				this.RaisePropertyChanged("DOD_Parent_Date_of_Death");
			}
		}

		[XmlIgnore]
		public bool DOD_Parent_Date_of_DeathSpecified
		{
			get
			{
				return this.dOD_Parent_Date_of_DeathFieldSpecified;
			}
			set
			{
				this.dOD_Parent_Date_of_DeathFieldSpecified = value;
				this.RaisePropertyChanged("DOD_Parent_Date_of_DeathSpecified");
			}
		}

		[XmlElement(Order = 166)]
		public ISIR_Electronic_Federal_School_Code_IndicatorObjectType Electronic_Federal_School_Code_Indicator_Reference
		{
			get
			{
				return this.electronic_Federal_School_Code_Indicator_ReferenceField;
			}
			set
			{
				this.electronic_Federal_School_Code_Indicator_ReferenceField = value;
				this.RaisePropertyChanged("Electronic_Federal_School_Code_Indicator_Reference");
			}
		}

		[XmlElement(Order = 167)]
		public Financial_Aid_ISIR_Electronic_Transaction_Indicator_FlagObjectType ETI_Flag_Reference
		{
			get
			{
				return this.eTI_Flag_ReferenceField;
			}
			set
			{
				this.eTI_Flag_ReferenceField = value;
				this.RaisePropertyChanged("ETI_Flag_Reference");
			}
		}

		[XmlElement(Order = 168)]
		public ISIR_Federal_Verification_Tracking_FlagObjectType Federal_Verification_Tracking_Flag_Reference
		{
			get
			{
				return this.federal_Verification_Tracking_Flag_ReferenceField;
			}
			set
			{
				this.federal_Verification_Tracking_Flag_ReferenceField = value;
				this.RaisePropertyChanged("Federal_Verification_Tracking_Flag_Reference");
			}
		}

		[XmlElement(Order = 169)]
		public Student_is_Selected_for_VerificationObjectType Student_Is_Selected_For_Verification_Reference
		{
			get
			{
				return this.student_Is_Selected_For_Verification_ReferenceField;
			}
			set
			{
				this.student_Is_Selected_For_Verification_ReferenceField = value;
				this.RaisePropertyChanged("Student_Is_Selected_For_Verification_Reference");
			}
		}

		[XmlElement("NSLDS_Transaction_Data", Order = 170)]
		public NSLDS_Transaction_DataType[] NSLDS_Transaction_Data
		{
			get
			{
				return this.nSLDS_Transaction_DataField;
			}
			set
			{
				this.nSLDS_Transaction_DataField = value;
				this.RaisePropertyChanged("NSLDS_Transaction_Data");
			}
		}

		[XmlElement("ISIR_Transaction_Data_Data", Order = 171)]
		public ISIR_Transaction_Data_DataType[] ISIR_Transaction_Data_Data
		{
			get
			{
				return this.iSIR_Transaction_Data_DataField;
			}
			set
			{
				this.iSIR_Transaction_Data_DataField = value;
				this.RaisePropertyChanged("ISIR_Transaction_Data_Data");
			}
		}

		[XmlElement("ISIR_Student_Data", Order = 172)]
		public ISIR_Student_DataType[] ISIR_Student_Data
		{
			get
			{
				return this.iSIR_Student_DataField;
			}
			set
			{
				this.iSIR_Student_DataField = value;
				this.RaisePropertyChanged("ISIR_Student_Data");
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
