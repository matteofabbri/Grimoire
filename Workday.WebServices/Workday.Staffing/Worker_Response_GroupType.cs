using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Personal_InformationField;

		private bool include_Personal_InformationFieldSpecified;

		private bool include_Additional_JobsField;

		private bool include_Additional_JobsFieldSpecified;

		private bool include_Employment_InformationField;

		private bool include_Employment_InformationFieldSpecified;

		private bool include_CompensationField;

		private bool include_CompensationFieldSpecified;

		private bool include_OrganizationsField;

		private bool include_OrganizationsFieldSpecified;

		private bool exclude_Organization_Support_Role_DataField;

		private bool exclude_Organization_Support_Role_DataFieldSpecified;

		private bool exclude_Location_HierarchiesField;

		private bool exclude_Location_HierarchiesFieldSpecified;

		private bool exclude_Cost_CentersField;

		private bool exclude_Cost_CentersFieldSpecified;

		private bool exclude_Cost_Center_HierarchiesField;

		private bool exclude_Cost_Center_HierarchiesFieldSpecified;

		private bool exclude_CompaniesField;

		private bool exclude_CompaniesFieldSpecified;

		private bool exclude_Company_HierarchiesField;

		private bool exclude_Company_HierarchiesFieldSpecified;

		private bool exclude_Matrix_OrganizationsField;

		private bool exclude_Matrix_OrganizationsFieldSpecified;

		private bool exclude_Pay_GroupsField;

		private bool exclude_Pay_GroupsFieldSpecified;

		private bool exclude_RegionsField;

		private bool exclude_RegionsFieldSpecified;

		private bool exclude_Region_HierarchiesField;

		private bool exclude_Region_HierarchiesFieldSpecified;

		private bool exclude_Supervisory_OrganizationsField;

		private bool exclude_Supervisory_OrganizationsFieldSpecified;

		private bool exclude_TeamsField;

		private bool exclude_TeamsFieldSpecified;

		private bool exclude_Custom_OrganizationsField;

		private bool exclude_Custom_OrganizationsFieldSpecified;

		private bool include_RolesField;

		private bool include_RolesFieldSpecified;

		private bool include_Management_Chain_DataField;

		private bool include_Management_Chain_DataFieldSpecified;

		private bool include_Multiple_Managers_in_Management_Chain_DataField;

		private bool include_Multiple_Managers_in_Management_Chain_DataFieldSpecified;

		private bool include_Benefit_EnrollmentsField;

		private bool include_Benefit_EnrollmentsFieldSpecified;

		private bool include_Benefit_EligibilityField;

		private bool include_Benefit_EligibilityFieldSpecified;

		private bool include_Related_PersonsField;

		private bool include_Related_PersonsFieldSpecified;

		private bool include_QualificationsField;

		private bool include_QualificationsFieldSpecified;

		private bool include_Employee_ReviewField;

		private bool include_Employee_ReviewFieldSpecified;

		private bool include_GoalsField;

		private bool include_GoalsFieldSpecified;

		private bool include_Development_ItemsField;

		private bool include_Development_ItemsFieldSpecified;

		private bool include_SkillsField;

		private bool include_SkillsFieldSpecified;

		private bool include_PhotoField;

		private bool include_PhotoFieldSpecified;

		private bool include_Worker_DocumentsField;

		private bool include_Worker_DocumentsFieldSpecified;

		private bool include_Transaction_Log_DataField;

		private bool include_Transaction_Log_DataFieldSpecified;

		private bool include_Subevents_for_Corrected_TransactionField;

		private bool include_Subevents_for_Corrected_TransactionFieldSpecified;

		private bool include_Subevents_for_Rescinded_TransactionField;

		private bool include_Subevents_for_Rescinded_TransactionFieldSpecified;

		private bool include_Succession_ProfileField;

		private bool include_Succession_ProfileFieldSpecified;

		private bool include_Talent_AssessmentField;

		private bool include_Talent_AssessmentFieldSpecified;

		private bool include_Employee_Contract_DataField;

		private bool include_Employee_Contract_DataFieldSpecified;

		private bool include_Collective_Agreement_DataField;

		private bool include_Collective_Agreement_DataFieldSpecified;

		private bool include_Probation_Period_DataField;

		private bool include_Probation_Period_DataFieldSpecified;

		private bool include_Extended_Employee_Contract_DetailsField;

		private bool include_Extended_Employee_Contract_DetailsFieldSpecified;

		private bool include_Feedback_ReceivedField;

		private bool include_Feedback_ReceivedFieldSpecified;

		private bool include_User_AccountField;

		private bool include_User_AccountFieldSpecified;

		private bool include_CareerField;

		private bool include_CareerFieldSpecified;

		private bool include_Account_ProvisioningField;

		private bool include_Account_ProvisioningFieldSpecified;

		private bool include_Background_Check_DataField;

		private bool include_Background_Check_DataFieldSpecified;

		private bool include_Contingent_Worker_Tax_Authority_Form_InformationField;

		private bool include_Contingent_Worker_Tax_Authority_Form_InformationFieldSpecified;

		private bool exclude_FundsField;

		private bool exclude_FundsFieldSpecified;

		private bool exclude_Fund_HierarchiesField;

		private bool exclude_Fund_HierarchiesFieldSpecified;

		private bool exclude_GrantsField;

		private bool exclude_GrantsFieldSpecified;

		private bool exclude_Grant_HierarchiesField;

		private bool exclude_Grant_HierarchiesFieldSpecified;

		private bool exclude_Business_UnitsField;

		private bool exclude_Business_UnitsFieldSpecified;

		private bool exclude_Business_Unit_HierarchiesField;

		private bool exclude_Business_Unit_HierarchiesFieldSpecified;

		private bool exclude_ProgramsField;

		private bool exclude_ProgramsFieldSpecified;

		private bool exclude_Program_HierarchiesField;

		private bool exclude_Program_HierarchiesFieldSpecified;

		private bool exclude_GiftsField;

		private bool exclude_GiftsFieldSpecified;

		private bool exclude_Gift_HierarchiesField;

		private bool exclude_Gift_HierarchiesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Personal_Information
		{
			get
			{
				return this.include_Personal_InformationField;
			}
			set
			{
				this.include_Personal_InformationField = value;
				this.RaisePropertyChanged("Include_Personal_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Personal_InformationSpecified
		{
			get
			{
				return this.include_Personal_InformationFieldSpecified;
			}
			set
			{
				this.include_Personal_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Personal_InformationSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Additional_Jobs
		{
			get
			{
				return this.include_Additional_JobsField;
			}
			set
			{
				this.include_Additional_JobsField = value;
				this.RaisePropertyChanged("Include_Additional_Jobs");
			}
		}

		[XmlIgnore]
		public bool Include_Additional_JobsSpecified
		{
			get
			{
				return this.include_Additional_JobsFieldSpecified;
			}
			set
			{
				this.include_Additional_JobsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Additional_JobsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Employment_Information
		{
			get
			{
				return this.include_Employment_InformationField;
			}
			set
			{
				this.include_Employment_InformationField = value;
				this.RaisePropertyChanged("Include_Employment_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Employment_InformationSpecified
		{
			get
			{
				return this.include_Employment_InformationFieldSpecified;
			}
			set
			{
				this.include_Employment_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Employment_InformationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Compensation
		{
			get
			{
				return this.include_CompensationField;
			}
			set
			{
				this.include_CompensationField = value;
				this.RaisePropertyChanged("Include_Compensation");
			}
		}

		[XmlIgnore]
		public bool Include_CompensationSpecified
		{
			get
			{
				return this.include_CompensationFieldSpecified;
			}
			set
			{
				this.include_CompensationFieldSpecified = value;
				this.RaisePropertyChanged("Include_CompensationSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Organizations
		{
			get
			{
				return this.include_OrganizationsField;
			}
			set
			{
				this.include_OrganizationsField = value;
				this.RaisePropertyChanged("Include_Organizations");
			}
		}

		[XmlIgnore]
		public bool Include_OrganizationsSpecified
		{
			get
			{
				return this.include_OrganizationsFieldSpecified;
			}
			set
			{
				this.include_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Exclude_Organization_Support_Role_Data
		{
			get
			{
				return this.exclude_Organization_Support_Role_DataField;
			}
			set
			{
				this.exclude_Organization_Support_Role_DataField = value;
				this.RaisePropertyChanged("Exclude_Organization_Support_Role_Data");
			}
		}

		[XmlIgnore]
		public bool Exclude_Organization_Support_Role_DataSpecified
		{
			get
			{
				return this.exclude_Organization_Support_Role_DataFieldSpecified;
			}
			set
			{
				this.exclude_Organization_Support_Role_DataFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Organization_Support_Role_DataSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Exclude_Location_Hierarchies
		{
			get
			{
				return this.exclude_Location_HierarchiesField;
			}
			set
			{
				this.exclude_Location_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Location_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Location_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Location_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Location_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Location_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Exclude_Cost_Centers
		{
			get
			{
				return this.exclude_Cost_CentersField;
			}
			set
			{
				this.exclude_Cost_CentersField = value;
				this.RaisePropertyChanged("Exclude_Cost_Centers");
			}
		}

		[XmlIgnore]
		public bool Exclude_Cost_CentersSpecified
		{
			get
			{
				return this.exclude_Cost_CentersFieldSpecified;
			}
			set
			{
				this.exclude_Cost_CentersFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Cost_CentersSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Exclude_Cost_Center_Hierarchies
		{
			get
			{
				return this.exclude_Cost_Center_HierarchiesField;
			}
			set
			{
				this.exclude_Cost_Center_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Cost_Center_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Cost_Center_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Cost_Center_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Cost_Center_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Cost_Center_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Exclude_Companies
		{
			get
			{
				return this.exclude_CompaniesField;
			}
			set
			{
				this.exclude_CompaniesField = value;
				this.RaisePropertyChanged("Exclude_Companies");
			}
		}

		[XmlIgnore]
		public bool Exclude_CompaniesSpecified
		{
			get
			{
				return this.exclude_CompaniesFieldSpecified;
			}
			set
			{
				this.exclude_CompaniesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_CompaniesSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Exclude_Company_Hierarchies
		{
			get
			{
				return this.exclude_Company_HierarchiesField;
			}
			set
			{
				this.exclude_Company_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Company_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Company_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Company_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Company_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Company_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Exclude_Matrix_Organizations
		{
			get
			{
				return this.exclude_Matrix_OrganizationsField;
			}
			set
			{
				this.exclude_Matrix_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Matrix_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Matrix_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Matrix_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Matrix_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Matrix_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Exclude_Pay_Groups
		{
			get
			{
				return this.exclude_Pay_GroupsField;
			}
			set
			{
				this.exclude_Pay_GroupsField = value;
				this.RaisePropertyChanged("Exclude_Pay_Groups");
			}
		}

		[XmlIgnore]
		public bool Exclude_Pay_GroupsSpecified
		{
			get
			{
				return this.exclude_Pay_GroupsFieldSpecified;
			}
			set
			{
				this.exclude_Pay_GroupsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Pay_GroupsSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Exclude_Regions
		{
			get
			{
				return this.exclude_RegionsField;
			}
			set
			{
				this.exclude_RegionsField = value;
				this.RaisePropertyChanged("Exclude_Regions");
			}
		}

		[XmlIgnore]
		public bool Exclude_RegionsSpecified
		{
			get
			{
				return this.exclude_RegionsFieldSpecified;
			}
			set
			{
				this.exclude_RegionsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_RegionsSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Exclude_Region_Hierarchies
		{
			get
			{
				return this.exclude_Region_HierarchiesField;
			}
			set
			{
				this.exclude_Region_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Region_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Region_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Region_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Region_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Region_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Exclude_Supervisory_Organizations
		{
			get
			{
				return this.exclude_Supervisory_OrganizationsField;
			}
			set
			{
				this.exclude_Supervisory_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Supervisory_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Supervisory_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Supervisory_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Supervisory_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Supervisory_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Exclude_Teams
		{
			get
			{
				return this.exclude_TeamsField;
			}
			set
			{
				this.exclude_TeamsField = value;
				this.RaisePropertyChanged("Exclude_Teams");
			}
		}

		[XmlIgnore]
		public bool Exclude_TeamsSpecified
		{
			get
			{
				return this.exclude_TeamsFieldSpecified;
			}
			set
			{
				this.exclude_TeamsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_TeamsSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Exclude_Custom_Organizations
		{
			get
			{
				return this.exclude_Custom_OrganizationsField;
			}
			set
			{
				this.exclude_Custom_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Custom_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Custom_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Custom_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Custom_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Custom_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Include_Roles
		{
			get
			{
				return this.include_RolesField;
			}
			set
			{
				this.include_RolesField = value;
				this.RaisePropertyChanged("Include_Roles");
			}
		}

		[XmlIgnore]
		public bool Include_RolesSpecified
		{
			get
			{
				return this.include_RolesFieldSpecified;
			}
			set
			{
				this.include_RolesFieldSpecified = value;
				this.RaisePropertyChanged("Include_RolesSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Include_Management_Chain_Data
		{
			get
			{
				return this.include_Management_Chain_DataField;
			}
			set
			{
				this.include_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Include_Management_Chain_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Management_Chain_DataSpecified
		{
			get
			{
				return this.include_Management_Chain_DataFieldSpecified;
			}
			set
			{
				this.include_Management_Chain_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Management_Chain_DataSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Include_Multiple_Managers_in_Management_Chain_Data
		{
			get
			{
				return this.include_Multiple_Managers_in_Management_Chain_DataField;
			}
			set
			{
				this.include_Multiple_Managers_in_Management_Chain_DataField = value;
				this.RaisePropertyChanged("Include_Multiple_Managers_in_Management_Chain_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Multiple_Managers_in_Management_Chain_DataSpecified
		{
			get
			{
				return this.include_Multiple_Managers_in_Management_Chain_DataFieldSpecified;
			}
			set
			{
				this.include_Multiple_Managers_in_Management_Chain_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Multiple_Managers_in_Management_Chain_DataSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Include_Benefit_Enrollments
		{
			get
			{
				return this.include_Benefit_EnrollmentsField;
			}
			set
			{
				this.include_Benefit_EnrollmentsField = value;
				this.RaisePropertyChanged("Include_Benefit_Enrollments");
			}
		}

		[XmlIgnore]
		public bool Include_Benefit_EnrollmentsSpecified
		{
			get
			{
				return this.include_Benefit_EnrollmentsFieldSpecified;
			}
			set
			{
				this.include_Benefit_EnrollmentsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Benefit_EnrollmentsSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Include_Benefit_Eligibility
		{
			get
			{
				return this.include_Benefit_EligibilityField;
			}
			set
			{
				this.include_Benefit_EligibilityField = value;
				this.RaisePropertyChanged("Include_Benefit_Eligibility");
			}
		}

		[XmlIgnore]
		public bool Include_Benefit_EligibilitySpecified
		{
			get
			{
				return this.include_Benefit_EligibilityFieldSpecified;
			}
			set
			{
				this.include_Benefit_EligibilityFieldSpecified = value;
				this.RaisePropertyChanged("Include_Benefit_EligibilitySpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Include_Related_Persons
		{
			get
			{
				return this.include_Related_PersonsField;
			}
			set
			{
				this.include_Related_PersonsField = value;
				this.RaisePropertyChanged("Include_Related_Persons");
			}
		}

		[XmlIgnore]
		public bool Include_Related_PersonsSpecified
		{
			get
			{
				return this.include_Related_PersonsFieldSpecified;
			}
			set
			{
				this.include_Related_PersonsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Related_PersonsSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public bool Include_Qualifications
		{
			get
			{
				return this.include_QualificationsField;
			}
			set
			{
				this.include_QualificationsField = value;
				this.RaisePropertyChanged("Include_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_QualificationsSpecified
		{
			get
			{
				return this.include_QualificationsFieldSpecified;
			}
			set
			{
				this.include_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 26)]
		public bool Include_Employee_Review
		{
			get
			{
				return this.include_Employee_ReviewField;
			}
			set
			{
				this.include_Employee_ReviewField = value;
				this.RaisePropertyChanged("Include_Employee_Review");
			}
		}

		[XmlIgnore]
		public bool Include_Employee_ReviewSpecified
		{
			get
			{
				return this.include_Employee_ReviewFieldSpecified;
			}
			set
			{
				this.include_Employee_ReviewFieldSpecified = value;
				this.RaisePropertyChanged("Include_Employee_ReviewSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Include_Goals
		{
			get
			{
				return this.include_GoalsField;
			}
			set
			{
				this.include_GoalsField = value;
				this.RaisePropertyChanged("Include_Goals");
			}
		}

		[XmlIgnore]
		public bool Include_GoalsSpecified
		{
			get
			{
				return this.include_GoalsFieldSpecified;
			}
			set
			{
				this.include_GoalsFieldSpecified = value;
				this.RaisePropertyChanged("Include_GoalsSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public bool Include_Development_Items
		{
			get
			{
				return this.include_Development_ItemsField;
			}
			set
			{
				this.include_Development_ItemsField = value;
				this.RaisePropertyChanged("Include_Development_Items");
			}
		}

		[XmlIgnore]
		public bool Include_Development_ItemsSpecified
		{
			get
			{
				return this.include_Development_ItemsFieldSpecified;
			}
			set
			{
				this.include_Development_ItemsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Development_ItemsSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public bool Include_Skills
		{
			get
			{
				return this.include_SkillsField;
			}
			set
			{
				this.include_SkillsField = value;
				this.RaisePropertyChanged("Include_Skills");
			}
		}

		[XmlIgnore]
		public bool Include_SkillsSpecified
		{
			get
			{
				return this.include_SkillsFieldSpecified;
			}
			set
			{
				this.include_SkillsFieldSpecified = value;
				this.RaisePropertyChanged("Include_SkillsSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Include_Photo
		{
			get
			{
				return this.include_PhotoField;
			}
			set
			{
				this.include_PhotoField = value;
				this.RaisePropertyChanged("Include_Photo");
			}
		}

		[XmlIgnore]
		public bool Include_PhotoSpecified
		{
			get
			{
				return this.include_PhotoFieldSpecified;
			}
			set
			{
				this.include_PhotoFieldSpecified = value;
				this.RaisePropertyChanged("Include_PhotoSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public bool Include_Worker_Documents
		{
			get
			{
				return this.include_Worker_DocumentsField;
			}
			set
			{
				this.include_Worker_DocumentsField = value;
				this.RaisePropertyChanged("Include_Worker_Documents");
			}
		}

		[XmlIgnore]
		public bool Include_Worker_DocumentsSpecified
		{
			get
			{
				return this.include_Worker_DocumentsFieldSpecified;
			}
			set
			{
				this.include_Worker_DocumentsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Worker_DocumentsSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public bool Include_Transaction_Log_Data
		{
			get
			{
				return this.include_Transaction_Log_DataField;
			}
			set
			{
				this.include_Transaction_Log_DataField = value;
				this.RaisePropertyChanged("Include_Transaction_Log_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Transaction_Log_DataSpecified
		{
			get
			{
				return this.include_Transaction_Log_DataFieldSpecified;
			}
			set
			{
				this.include_Transaction_Log_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Transaction_Log_DataSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public bool Include_Subevents_for_Corrected_Transaction
		{
			get
			{
				return this.include_Subevents_for_Corrected_TransactionField;
			}
			set
			{
				this.include_Subevents_for_Corrected_TransactionField = value;
				this.RaisePropertyChanged("Include_Subevents_for_Corrected_Transaction");
			}
		}

		[XmlIgnore]
		public bool Include_Subevents_for_Corrected_TransactionSpecified
		{
			get
			{
				return this.include_Subevents_for_Corrected_TransactionFieldSpecified;
			}
			set
			{
				this.include_Subevents_for_Corrected_TransactionFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subevents_for_Corrected_TransactionSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public bool Include_Subevents_for_Rescinded_Transaction
		{
			get
			{
				return this.include_Subevents_for_Rescinded_TransactionField;
			}
			set
			{
				this.include_Subevents_for_Rescinded_TransactionField = value;
				this.RaisePropertyChanged("Include_Subevents_for_Rescinded_Transaction");
			}
		}

		[XmlIgnore]
		public bool Include_Subevents_for_Rescinded_TransactionSpecified
		{
			get
			{
				return this.include_Subevents_for_Rescinded_TransactionFieldSpecified;
			}
			set
			{
				this.include_Subevents_for_Rescinded_TransactionFieldSpecified = value;
				this.RaisePropertyChanged("Include_Subevents_for_Rescinded_TransactionSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public bool Include_Succession_Profile
		{
			get
			{
				return this.include_Succession_ProfileField;
			}
			set
			{
				this.include_Succession_ProfileField = value;
				this.RaisePropertyChanged("Include_Succession_Profile");
			}
		}

		[XmlIgnore]
		public bool Include_Succession_ProfileSpecified
		{
			get
			{
				return this.include_Succession_ProfileFieldSpecified;
			}
			set
			{
				this.include_Succession_ProfileFieldSpecified = value;
				this.RaisePropertyChanged("Include_Succession_ProfileSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public bool Include_Talent_Assessment
		{
			get
			{
				return this.include_Talent_AssessmentField;
			}
			set
			{
				this.include_Talent_AssessmentField = value;
				this.RaisePropertyChanged("Include_Talent_Assessment");
			}
		}

		[XmlIgnore]
		public bool Include_Talent_AssessmentSpecified
		{
			get
			{
				return this.include_Talent_AssessmentFieldSpecified;
			}
			set
			{
				this.include_Talent_AssessmentFieldSpecified = value;
				this.RaisePropertyChanged("Include_Talent_AssessmentSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public bool Include_Employee_Contract_Data
		{
			get
			{
				return this.include_Employee_Contract_DataField;
			}
			set
			{
				this.include_Employee_Contract_DataField = value;
				this.RaisePropertyChanged("Include_Employee_Contract_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Employee_Contract_DataSpecified
		{
			get
			{
				return this.include_Employee_Contract_DataFieldSpecified;
			}
			set
			{
				this.include_Employee_Contract_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Employee_Contract_DataSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool Include_Collective_Agreement_Data
		{
			get
			{
				return this.include_Collective_Agreement_DataField;
			}
			set
			{
				this.include_Collective_Agreement_DataField = value;
				this.RaisePropertyChanged("Include_Collective_Agreement_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Collective_Agreement_DataSpecified
		{
			get
			{
				return this.include_Collective_Agreement_DataFieldSpecified;
			}
			set
			{
				this.include_Collective_Agreement_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Collective_Agreement_DataSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool Include_Probation_Period_Data
		{
			get
			{
				return this.include_Probation_Period_DataField;
			}
			set
			{
				this.include_Probation_Period_DataField = value;
				this.RaisePropertyChanged("Include_Probation_Period_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Probation_Period_DataSpecified
		{
			get
			{
				return this.include_Probation_Period_DataFieldSpecified;
			}
			set
			{
				this.include_Probation_Period_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Probation_Period_DataSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Include_Extended_Employee_Contract_Details
		{
			get
			{
				return this.include_Extended_Employee_Contract_DetailsField;
			}
			set
			{
				this.include_Extended_Employee_Contract_DetailsField = value;
				this.RaisePropertyChanged("Include_Extended_Employee_Contract_Details");
			}
		}

		[XmlIgnore]
		public bool Include_Extended_Employee_Contract_DetailsSpecified
		{
			get
			{
				return this.include_Extended_Employee_Contract_DetailsFieldSpecified;
			}
			set
			{
				this.include_Extended_Employee_Contract_DetailsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Extended_Employee_Contract_DetailsSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public bool Include_Feedback_Received
		{
			get
			{
				return this.include_Feedback_ReceivedField;
			}
			set
			{
				this.include_Feedback_ReceivedField = value;
				this.RaisePropertyChanged("Include_Feedback_Received");
			}
		}

		[XmlIgnore]
		public bool Include_Feedback_ReceivedSpecified
		{
			get
			{
				return this.include_Feedback_ReceivedFieldSpecified;
			}
			set
			{
				this.include_Feedback_ReceivedFieldSpecified = value;
				this.RaisePropertyChanged("Include_Feedback_ReceivedSpecified");
			}
		}

		[XmlElement(Order = 42)]
		public bool Include_User_Account
		{
			get
			{
				return this.include_User_AccountField;
			}
			set
			{
				this.include_User_AccountField = value;
				this.RaisePropertyChanged("Include_User_Account");
			}
		}

		[XmlIgnore]
		public bool Include_User_AccountSpecified
		{
			get
			{
				return this.include_User_AccountFieldSpecified;
			}
			set
			{
				this.include_User_AccountFieldSpecified = value;
				this.RaisePropertyChanged("Include_User_AccountSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public bool Include_Career
		{
			get
			{
				return this.include_CareerField;
			}
			set
			{
				this.include_CareerField = value;
				this.RaisePropertyChanged("Include_Career");
			}
		}

		[XmlIgnore]
		public bool Include_CareerSpecified
		{
			get
			{
				return this.include_CareerFieldSpecified;
			}
			set
			{
				this.include_CareerFieldSpecified = value;
				this.RaisePropertyChanged("Include_CareerSpecified");
			}
		}

		[XmlElement(Order = 44)]
		public bool Include_Account_Provisioning
		{
			get
			{
				return this.include_Account_ProvisioningField;
			}
			set
			{
				this.include_Account_ProvisioningField = value;
				this.RaisePropertyChanged("Include_Account_Provisioning");
			}
		}

		[XmlIgnore]
		public bool Include_Account_ProvisioningSpecified
		{
			get
			{
				return this.include_Account_ProvisioningFieldSpecified;
			}
			set
			{
				this.include_Account_ProvisioningFieldSpecified = value;
				this.RaisePropertyChanged("Include_Account_ProvisioningSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public bool Include_Background_Check_Data
		{
			get
			{
				return this.include_Background_Check_DataField;
			}
			set
			{
				this.include_Background_Check_DataField = value;
				this.RaisePropertyChanged("Include_Background_Check_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Background_Check_DataSpecified
		{
			get
			{
				return this.include_Background_Check_DataFieldSpecified;
			}
			set
			{
				this.include_Background_Check_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Background_Check_DataSpecified");
			}
		}

		[XmlElement(Order = 46)]
		public bool Include_Contingent_Worker_Tax_Authority_Form_Information
		{
			get
			{
				return this.include_Contingent_Worker_Tax_Authority_Form_InformationField;
			}
			set
			{
				this.include_Contingent_Worker_Tax_Authority_Form_InformationField = value;
				this.RaisePropertyChanged("Include_Contingent_Worker_Tax_Authority_Form_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Contingent_Worker_Tax_Authority_Form_InformationSpecified
		{
			get
			{
				return this.include_Contingent_Worker_Tax_Authority_Form_InformationFieldSpecified;
			}
			set
			{
				this.include_Contingent_Worker_Tax_Authority_Form_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Contingent_Worker_Tax_Authority_Form_InformationSpecified");
			}
		}

		[XmlElement(Order = 47)]
		public bool Exclude_Funds
		{
			get
			{
				return this.exclude_FundsField;
			}
			set
			{
				this.exclude_FundsField = value;
				this.RaisePropertyChanged("Exclude_Funds");
			}
		}

		[XmlIgnore]
		public bool Exclude_FundsSpecified
		{
			get
			{
				return this.exclude_FundsFieldSpecified;
			}
			set
			{
				this.exclude_FundsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_FundsSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public bool Exclude_Fund_Hierarchies
		{
			get
			{
				return this.exclude_Fund_HierarchiesField;
			}
			set
			{
				this.exclude_Fund_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Fund_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Fund_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Fund_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Fund_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Fund_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 49)]
		public bool Exclude_Grants
		{
			get
			{
				return this.exclude_GrantsField;
			}
			set
			{
				this.exclude_GrantsField = value;
				this.RaisePropertyChanged("Exclude_Grants");
			}
		}

		[XmlIgnore]
		public bool Exclude_GrantsSpecified
		{
			get
			{
				return this.exclude_GrantsFieldSpecified;
			}
			set
			{
				this.exclude_GrantsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_GrantsSpecified");
			}
		}

		[XmlElement(Order = 50)]
		public bool Exclude_Grant_Hierarchies
		{
			get
			{
				return this.exclude_Grant_HierarchiesField;
			}
			set
			{
				this.exclude_Grant_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Grant_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Grant_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Grant_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Grant_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Grant_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 51)]
		public bool Exclude_Business_Units
		{
			get
			{
				return this.exclude_Business_UnitsField;
			}
			set
			{
				this.exclude_Business_UnitsField = value;
				this.RaisePropertyChanged("Exclude_Business_Units");
			}
		}

		[XmlIgnore]
		public bool Exclude_Business_UnitsSpecified
		{
			get
			{
				return this.exclude_Business_UnitsFieldSpecified;
			}
			set
			{
				this.exclude_Business_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Business_UnitsSpecified");
			}
		}

		[XmlElement(Order = 52)]
		public bool Exclude_Business_Unit_Hierarchies
		{
			get
			{
				return this.exclude_Business_Unit_HierarchiesField;
			}
			set
			{
				this.exclude_Business_Unit_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Business_Unit_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Business_Unit_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Business_Unit_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Business_Unit_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Business_Unit_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 53)]
		public bool Exclude_Programs
		{
			get
			{
				return this.exclude_ProgramsField;
			}
			set
			{
				this.exclude_ProgramsField = value;
				this.RaisePropertyChanged("Exclude_Programs");
			}
		}

		[XmlIgnore]
		public bool Exclude_ProgramsSpecified
		{
			get
			{
				return this.exclude_ProgramsFieldSpecified;
			}
			set
			{
				this.exclude_ProgramsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_ProgramsSpecified");
			}
		}

		[XmlElement(Order = 54)]
		public bool Exclude_Program_Hierarchies
		{
			get
			{
				return this.exclude_Program_HierarchiesField;
			}
			set
			{
				this.exclude_Program_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Program_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Program_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Program_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Program_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Program_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 55)]
		public bool Exclude_Gifts
		{
			get
			{
				return this.exclude_GiftsField;
			}
			set
			{
				this.exclude_GiftsField = value;
				this.RaisePropertyChanged("Exclude_Gifts");
			}
		}

		[XmlIgnore]
		public bool Exclude_GiftsSpecified
		{
			get
			{
				return this.exclude_GiftsFieldSpecified;
			}
			set
			{
				this.exclude_GiftsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_GiftsSpecified");
			}
		}

		[XmlElement(Order = 56)]
		public bool Exclude_Gift_Hierarchies
		{
			get
			{
				return this.exclude_Gift_HierarchiesField;
			}
			set
			{
				this.exclude_Gift_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Gift_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Gift_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Gift_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Gift_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Gift_HierarchiesSpecified");
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
