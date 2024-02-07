using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_External_Pay_Group_DataField;

		private bool include_External_Pay_Group_DataFieldSpecified;

		private bool include_Period_Content_DataField;

		private bool include_Period_Content_DataFieldSpecified;

		private bool include_Payee_Personal_InformationField;

		private bool include_Payee_Personal_InformationFieldSpecified;

		private bool exclude_Payee_Detailed_Identification_InformationField;

		private bool exclude_Payee_Detailed_Identification_InformationFieldSpecified;

		private bool include_Payee_Additional_Job_DataField;

		private bool include_Payee_Additional_Job_DataFieldSpecified;

		private bool include_Payee_Employment_InformationField;

		private bool include_Payee_Employment_InformationFieldSpecified;

		private bool include_Payee_Compensation_InformationField;

		private bool include_Payee_Compensation_InformationFieldSpecified;

		private bool exclude_Payee_Detailed_Compensation_InformationField;

		private bool exclude_Payee_Detailed_Compensation_InformationFieldSpecified;

		private bool include_Payee_Compensation_Prorated_AmountField;

		private bool include_Payee_Compensation_Prorated_AmountFieldSpecified;

		private bool include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsField;

		private bool include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsFieldSpecified;

		private bool include_Payee_Organizations_InformationField;

		private bool include_Payee_Organizations_InformationFieldSpecified;

		private bool include_Pay_Group_Assignment_Correct_and_Rescind_InformationField;

		private bool include_Pay_Group_Assignment_Correct_and_Rescind_InformationFieldSpecified;

		private bool exclude_Payee_Organization_Support_Role_DataField;

		private bool exclude_Payee_Organization_Support_Role_DataFieldSpecified;

		private bool exclude_Payee_Location_HierarchiesField;

		private bool exclude_Payee_Location_HierarchiesFieldSpecified;

		private bool exclude_Payee_Cost_CentersField;

		private bool exclude_Payee_Cost_CentersFieldSpecified;

		private bool exclude_Payee_Cost_Center_HierarchiesField;

		private bool exclude_Payee_Cost_Center_HierarchiesFieldSpecified;

		private bool exclude_Payee_CompaniesField;

		private bool exclude_Payee_CompaniesFieldSpecified;

		private bool exclude_Payee_Company_HierarchiesField;

		private bool exclude_Payee_Company_HierarchiesFieldSpecified;

		private bool exclude_Payee_Matrix_OrganizationsField;

		private bool exclude_Payee_Matrix_OrganizationsFieldSpecified;

		private bool exclude_Payee_Pay_GroupsField;

		private bool exclude_Payee_Pay_GroupsFieldSpecified;

		private bool exclude_Payee_RegionsField;

		private bool exclude_Payee_RegionsFieldSpecified;

		private bool exclude_Payee_Region_HierarchiesField;

		private bool exclude_Payee_Region_HierarchiesFieldSpecified;

		private bool exclude_Payee_Supervisory_OrganizationsField;

		private bool exclude_Payee_Supervisory_OrganizationsFieldSpecified;

		private bool exclude_Payee_TeamsField;

		private bool exclude_Payee_TeamsFieldSpecified;

		private bool exclude_Custom_OrganizationsField;

		private bool exclude_Custom_OrganizationsFieldSpecified;

		private bool include_Management_Chain_DataField;

		private bool include_Management_Chain_DataFieldSpecified;

		private bool include_Multiple_Managers_in_Management_Chain_DataField;

		private bool include_Multiple_Managers_in_Management_Chain_DataFieldSpecified;

		private bool include_Payment_Election_DataField;

		private bool include_Payment_Election_DataFieldSpecified;

		private bool include_Payee_Tax_Withholding_DataField;

		private bool include_Payee_Tax_Withholding_DataFieldSpecified;

		private bool include_Pay_Component_Compensation_DataField;

		private bool include_Pay_Component_Compensation_DataFieldSpecified;

		private bool include_Pay_Component_Benefit_Plan_DataField;

		private bool include_Pay_Component_Benefit_Plan_DataFieldSpecified;

		private bool include_Pay_Component_Benefit_Group_Coverage_DataField;

		private bool include_Pay_Component_Benefit_Group_Coverage_DataFieldSpecified;

		private bool include_Pay_Component_Time_Off_DataField;

		private bool include_Pay_Component_Time_Off_DataFieldSpecified;

		private bool include_Pay_Component_Time_Off_Adjustment_DataField;

		private bool include_Pay_Component_Time_Off_Adjustment_DataFieldSpecified;

		private bool include_Pay_Component_Payroll_Input_DataField;

		private bool include_Pay_Component_Payroll_Input_DataFieldSpecified;

		private bool include_Payee_Earnings_and_Deductions_Summary_DataField;

		private bool include_Payee_Earnings_and_Deductions_Summary_DataFieldSpecified;

		private bool include_Pay_Component_Daily_Time_Tracking_Summary_DataField;

		private bool include_Pay_Component_Daily_Time_Tracking_Summary_DataFieldSpecified;

		private bool include_Pay_Component_Period_Time_Tracking_Summary_DataField;

		private bool include_Pay_Component_Period_Time_Tracking_Summary_DataFieldSpecified;

		private bool include_Pay_Component_Time_Tracking_Correction_DataField;

		private bool include_Pay_Component_Time_Tracking_Correction_DataFieldSpecified;

		private bool unrounded_Time_Tracking_Calculated_QuantitiesField;

		private bool unrounded_Time_Tracking_Calculated_QuantitiesFieldSpecified;

		private bool include_Transaction_Log_DataField;

		private bool include_Transaction_Log_DataFieldSpecified;

		private bool include_Payee_Status_DataField;

		private bool include_Payee_Status_DataFieldSpecified;

		private bool include_Payee_Contract_DataField;

		private bool include_Payee_Contract_DataFieldSpecified;

		private bool include_Payee_Collective_Agreement_DataField;

		private bool include_Payee_Collective_Agreement_DataFieldSpecified;

		private bool include_Payee_Probation_Period_DataField;

		private bool include_Payee_Probation_Period_DataFieldSpecified;

		private bool include_Extended_Employee_Contract_DetailsField;

		private bool include_Extended_Employee_Contract_DetailsFieldSpecified;

		private bool include_Payee_Related_PersonsField;

		private bool include_Payee_Related_PersonsFieldSpecified;

		private bool include_Payee_Qualfication_InformationField;

		private bool include_Payee_Qualfication_InformationFieldSpecified;

		private bool include_Costing_Allocation_DataField;

		private bool include_Costing_Allocation_DataFieldSpecified;

		private bool include_User_AccountField;

		private bool include_User_AccountFieldSpecified;

		private bool exclude_Payee_FundsField;

		private bool exclude_Payee_FundsFieldSpecified;

		private bool exclude_Payee_Fund_HierarchiesField;

		private bool exclude_Payee_Fund_HierarchiesFieldSpecified;

		private bool exclude_Payee_GrantsField;

		private bool exclude_Payee_GrantsFieldSpecified;

		private bool exclude_Payee_Grant_HierarchiesField;

		private bool exclude_Payee_Grant_HierarchiesFieldSpecified;

		private bool exclude_Payee_Business_UnitsField;

		private bool exclude_Payee_Business_UnitsFieldSpecified;

		private bool exclude_Payee_Business_Unit_HierarchiesField;

		private bool exclude_Payee_Business_Unit_HierarchiesFieldSpecified;

		private bool exclude_Payee_ProgramsField;

		private bool exclude_Payee_ProgramsFieldSpecified;

		private bool exclude_Payee_Program_HierarchiesField;

		private bool exclude_Payee_Program_HierarchiesFieldSpecified;

		private bool exclude_Payee_GiftsField;

		private bool exclude_Payee_GiftsFieldSpecified;

		private bool exclude_Payee_Gift_HierarchiesField;

		private bool exclude_Payee_Gift_HierarchiesFieldSpecified;

		private bool exclude_Pay_Component_Time_Off_Detail_DataField;

		private bool exclude_Pay_Component_Time_Off_Detail_DataFieldSpecified;

		private bool include_Pay_Component_Time_Off_Entries_Detail_DataField;

		private bool include_Pay_Component_Time_Off_Entries_Detail_DataFieldSpecified;

		private bool include_Pay_Component_Time_Off_Corrected_DataField;

		private bool include_Pay_Component_Time_Off_Corrected_DataFieldSpecified;

		private bool include_Payee_Compensation_FTE_Change_DateField;

		private bool include_Payee_Compensation_FTE_Change_DateFieldSpecified;

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
		public bool Include_External_Pay_Group_Data
		{
			get
			{
				return this.include_External_Pay_Group_DataField;
			}
			set
			{
				this.include_External_Pay_Group_DataField = value;
				this.RaisePropertyChanged("Include_External_Pay_Group_Data");
			}
		}

		[XmlIgnore]
		public bool Include_External_Pay_Group_DataSpecified
		{
			get
			{
				return this.include_External_Pay_Group_DataFieldSpecified;
			}
			set
			{
				this.include_External_Pay_Group_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_External_Pay_Group_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Period_Content_Data
		{
			get
			{
				return this.include_Period_Content_DataField;
			}
			set
			{
				this.include_Period_Content_DataField = value;
				this.RaisePropertyChanged("Include_Period_Content_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Period_Content_DataSpecified
		{
			get
			{
				return this.include_Period_Content_DataFieldSpecified;
			}
			set
			{
				this.include_Period_Content_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Period_Content_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Payee_Personal_Information
		{
			get
			{
				return this.include_Payee_Personal_InformationField;
			}
			set
			{
				this.include_Payee_Personal_InformationField = value;
				this.RaisePropertyChanged("Include_Payee_Personal_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Personal_InformationSpecified
		{
			get
			{
				return this.include_Payee_Personal_InformationFieldSpecified;
			}
			set
			{
				this.include_Payee_Personal_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Personal_InformationSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Exclude_Payee_Detailed_Identification_Information
		{
			get
			{
				return this.exclude_Payee_Detailed_Identification_InformationField;
			}
			set
			{
				this.exclude_Payee_Detailed_Identification_InformationField = value;
				this.RaisePropertyChanged("Exclude_Payee_Detailed_Identification_Information");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Detailed_Identification_InformationSpecified
		{
			get
			{
				return this.exclude_Payee_Detailed_Identification_InformationFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Detailed_Identification_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Detailed_Identification_InformationSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Payee_Additional_Job_Data
		{
			get
			{
				return this.include_Payee_Additional_Job_DataField;
			}
			set
			{
				this.include_Payee_Additional_Job_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Additional_Job_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Additional_Job_DataSpecified
		{
			get
			{
				return this.include_Payee_Additional_Job_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Additional_Job_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Additional_Job_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Payee_Employment_Information
		{
			get
			{
				return this.include_Payee_Employment_InformationField;
			}
			set
			{
				this.include_Payee_Employment_InformationField = value;
				this.RaisePropertyChanged("Include_Payee_Employment_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Employment_InformationSpecified
		{
			get
			{
				return this.include_Payee_Employment_InformationFieldSpecified;
			}
			set
			{
				this.include_Payee_Employment_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Employment_InformationSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_Payee_Compensation_Information
		{
			get
			{
				return this.include_Payee_Compensation_InformationField;
			}
			set
			{
				this.include_Payee_Compensation_InformationField = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Compensation_InformationSpecified
		{
			get
			{
				return this.include_Payee_Compensation_InformationFieldSpecified;
			}
			set
			{
				this.include_Payee_Compensation_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_InformationSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Exclude_Payee_Detailed_Compensation_Information
		{
			get
			{
				return this.exclude_Payee_Detailed_Compensation_InformationField;
			}
			set
			{
				this.exclude_Payee_Detailed_Compensation_InformationField = value;
				this.RaisePropertyChanged("Exclude_Payee_Detailed_Compensation_Information");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Detailed_Compensation_InformationSpecified
		{
			get
			{
				return this.exclude_Payee_Detailed_Compensation_InformationFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Detailed_Compensation_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Detailed_Compensation_InformationSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Include_Payee_Compensation_Prorated_Amount
		{
			get
			{
				return this.include_Payee_Compensation_Prorated_AmountField;
			}
			set
			{
				this.include_Payee_Compensation_Prorated_AmountField = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_Prorated_Amount");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Compensation_Prorated_AmountSpecified
		{
			get
			{
				return this.include_Payee_Compensation_Prorated_AmountFieldSpecified;
			}
			set
			{
				this.include_Payee_Compensation_Prorated_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_Prorated_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Include_Payee_Compensation_One_Time_Payment_Rescind_and_Corrects
		{
			get
			{
				return this.include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsField;
			}
			set
			{
				this.include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsField = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_One_Time_Payment_Rescind_and_Corrects");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsSpecified
		{
			get
			{
				return this.include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsFieldSpecified;
			}
			set
			{
				this.include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_One_Time_Payment_Rescind_and_CorrectsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Include_Payee_Organizations_Information
		{
			get
			{
				return this.include_Payee_Organizations_InformationField;
			}
			set
			{
				this.include_Payee_Organizations_InformationField = value;
				this.RaisePropertyChanged("Include_Payee_Organizations_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Organizations_InformationSpecified
		{
			get
			{
				return this.include_Payee_Organizations_InformationFieldSpecified;
			}
			set
			{
				this.include_Payee_Organizations_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Organizations_InformationSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Include_Pay_Group_Assignment_Correct_and_Rescind_Information
		{
			get
			{
				return this.include_Pay_Group_Assignment_Correct_and_Rescind_InformationField;
			}
			set
			{
				this.include_Pay_Group_Assignment_Correct_and_Rescind_InformationField = value;
				this.RaisePropertyChanged("Include_Pay_Group_Assignment_Correct_and_Rescind_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Group_Assignment_Correct_and_Rescind_InformationSpecified
		{
			get
			{
				return this.include_Pay_Group_Assignment_Correct_and_Rescind_InformationFieldSpecified;
			}
			set
			{
				this.include_Pay_Group_Assignment_Correct_and_Rescind_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Group_Assignment_Correct_and_Rescind_InformationSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Exclude_Payee_Organization_Support_Role_Data
		{
			get
			{
				return this.exclude_Payee_Organization_Support_Role_DataField;
			}
			set
			{
				this.exclude_Payee_Organization_Support_Role_DataField = value;
				this.RaisePropertyChanged("Exclude_Payee_Organization_Support_Role_Data");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Organization_Support_Role_DataSpecified
		{
			get
			{
				return this.exclude_Payee_Organization_Support_Role_DataFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Organization_Support_Role_DataFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Organization_Support_Role_DataSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Exclude_Payee_Location_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Location_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Location_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Location_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Location_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Location_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Location_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Location_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Exclude_Payee_Cost_Centers
		{
			get
			{
				return this.exclude_Payee_Cost_CentersField;
			}
			set
			{
				this.exclude_Payee_Cost_CentersField = value;
				this.RaisePropertyChanged("Exclude_Payee_Cost_Centers");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Cost_CentersSpecified
		{
			get
			{
				return this.exclude_Payee_Cost_CentersFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Cost_CentersFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Cost_CentersSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Exclude_Payee_Cost_Center_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Cost_Center_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Cost_Center_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Cost_Center_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Cost_Center_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Cost_Center_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Cost_Center_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Cost_Center_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Exclude_Payee_Companies
		{
			get
			{
				return this.exclude_Payee_CompaniesField;
			}
			set
			{
				this.exclude_Payee_CompaniesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Companies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_CompaniesSpecified
		{
			get
			{
				return this.exclude_Payee_CompaniesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_CompaniesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_CompaniesSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Exclude_Payee_Company_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Company_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Company_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Company_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Company_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Company_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Company_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Company_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Exclude_Payee_Matrix_Organizations
		{
			get
			{
				return this.exclude_Payee_Matrix_OrganizationsField;
			}
			set
			{
				this.exclude_Payee_Matrix_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Matrix_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Matrix_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Payee_Matrix_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Matrix_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Matrix_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Exclude_Payee_Pay_Groups
		{
			get
			{
				return this.exclude_Payee_Pay_GroupsField;
			}
			set
			{
				this.exclude_Payee_Pay_GroupsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Pay_Groups");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Pay_GroupsSpecified
		{
			get
			{
				return this.exclude_Payee_Pay_GroupsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Pay_GroupsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Pay_GroupsSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Exclude_Payee_Regions
		{
			get
			{
				return this.exclude_Payee_RegionsField;
			}
			set
			{
				this.exclude_Payee_RegionsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Regions");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_RegionsSpecified
		{
			get
			{
				return this.exclude_Payee_RegionsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_RegionsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_RegionsSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Exclude_Payee_Region_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Region_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Region_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Region_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Region_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Region_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Region_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Region_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Exclude_Payee_Supervisory_Organizations
		{
			get
			{
				return this.exclude_Payee_Supervisory_OrganizationsField;
			}
			set
			{
				this.exclude_Payee_Supervisory_OrganizationsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Supervisory_Organizations");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Supervisory_OrganizationsSpecified
		{
			get
			{
				return this.exclude_Payee_Supervisory_OrganizationsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Supervisory_OrganizationsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Supervisory_OrganizationsSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public bool Exclude_Payee_Teams
		{
			get
			{
				return this.exclude_Payee_TeamsField;
			}
			set
			{
				this.exclude_Payee_TeamsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Teams");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_TeamsSpecified
		{
			get
			{
				return this.exclude_Payee_TeamsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_TeamsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_TeamsSpecified");
			}
		}

		[XmlElement(Order = 25)]
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

		[XmlElement(Order = 26)]
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

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
		public bool Include_Payment_Election_Data
		{
			get
			{
				return this.include_Payment_Election_DataField;
			}
			set
			{
				this.include_Payment_Election_DataField = value;
				this.RaisePropertyChanged("Include_Payment_Election_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payment_Election_DataSpecified
		{
			get
			{
				return this.include_Payment_Election_DataFieldSpecified;
			}
			set
			{
				this.include_Payment_Election_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payment_Election_DataSpecified");
			}
		}

		[XmlElement(Order = 29)]
		public bool Include_Payee_Tax_Withholding_Data
		{
			get
			{
				return this.include_Payee_Tax_Withholding_DataField;
			}
			set
			{
				this.include_Payee_Tax_Withholding_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Tax_Withholding_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Tax_Withholding_DataSpecified
		{
			get
			{
				return this.include_Payee_Tax_Withholding_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Tax_Withholding_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Tax_Withholding_DataSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Include_Pay_Component_Compensation_Data
		{
			get
			{
				return this.include_Pay_Component_Compensation_DataField;
			}
			set
			{
				this.include_Pay_Component_Compensation_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Compensation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Compensation_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Compensation_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Compensation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Compensation_DataSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public bool Include_Pay_Component_Benefit_Plan_Data
		{
			get
			{
				return this.include_Pay_Component_Benefit_Plan_DataField;
			}
			set
			{
				this.include_Pay_Component_Benefit_Plan_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Benefit_Plan_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Benefit_Plan_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Benefit_Plan_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Benefit_Plan_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Benefit_Plan_DataSpecified");
			}
		}

		[XmlElement(Order = 32)]
		public bool Include_Pay_Component_Benefit_Group_Coverage_Data
		{
			get
			{
				return this.include_Pay_Component_Benefit_Group_Coverage_DataField;
			}
			set
			{
				this.include_Pay_Component_Benefit_Group_Coverage_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Benefit_Group_Coverage_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Benefit_Group_Coverage_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Benefit_Group_Coverage_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Benefit_Group_Coverage_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Benefit_Group_Coverage_DataSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public bool Include_Pay_Component_Time_Off_Data
		{
			get
			{
				return this.include_Pay_Component_Time_Off_DataField;
			}
			set
			{
				this.include_Pay_Component_Time_Off_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Time_Off_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Time_Off_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Time_Off_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_DataSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public bool Include_Pay_Component_Time_Off_Adjustment_Data
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Adjustment_DataField;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Adjustment_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Adjustment_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Time_Off_Adjustment_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Adjustment_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Adjustment_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Adjustment_DataSpecified");
			}
		}

		[XmlElement(Order = 35)]
		public bool Include_Pay_Component_Payroll_Input_Data
		{
			get
			{
				return this.include_Pay_Component_Payroll_Input_DataField;
			}
			set
			{
				this.include_Pay_Component_Payroll_Input_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Payroll_Input_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Payroll_Input_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Payroll_Input_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Payroll_Input_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Payroll_Input_DataSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public bool Include_Payee_Earnings_and_Deductions_Summary_Data
		{
			get
			{
				return this.include_Payee_Earnings_and_Deductions_Summary_DataField;
			}
			set
			{
				this.include_Payee_Earnings_and_Deductions_Summary_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Earnings_and_Deductions_Summary_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Earnings_and_Deductions_Summary_DataSpecified
		{
			get
			{
				return this.include_Payee_Earnings_and_Deductions_Summary_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Earnings_and_Deductions_Summary_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Earnings_and_Deductions_Summary_DataSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public bool Include_Pay_Component_Daily_Time_Tracking_Summary_Data
		{
			get
			{
				return this.include_Pay_Component_Daily_Time_Tracking_Summary_DataField;
			}
			set
			{
				this.include_Pay_Component_Daily_Time_Tracking_Summary_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Daily_Time_Tracking_Summary_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Daily_Time_Tracking_Summary_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Daily_Time_Tracking_Summary_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Daily_Time_Tracking_Summary_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Daily_Time_Tracking_Summary_DataSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool Include_Pay_Component_Period_Time_Tracking_Summary_Data
		{
			get
			{
				return this.include_Pay_Component_Period_Time_Tracking_Summary_DataField;
			}
			set
			{
				this.include_Pay_Component_Period_Time_Tracking_Summary_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Period_Time_Tracking_Summary_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Period_Time_Tracking_Summary_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Period_Time_Tracking_Summary_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Period_Time_Tracking_Summary_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Period_Time_Tracking_Summary_DataSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool Include_Pay_Component_Time_Tracking_Correction_Data
		{
			get
			{
				return this.include_Pay_Component_Time_Tracking_Correction_DataField;
			}
			set
			{
				this.include_Pay_Component_Time_Tracking_Correction_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Tracking_Correction_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Time_Tracking_Correction_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Time_Tracking_Correction_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Time_Tracking_Correction_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Tracking_Correction_DataSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Unrounded_Time_Tracking_Calculated_Quantities
		{
			get
			{
				return this.unrounded_Time_Tracking_Calculated_QuantitiesField;
			}
			set
			{
				this.unrounded_Time_Tracking_Calculated_QuantitiesField = value;
				this.RaisePropertyChanged("Unrounded_Time_Tracking_Calculated_Quantities");
			}
		}

		[XmlIgnore]
		public bool Unrounded_Time_Tracking_Calculated_QuantitiesSpecified
		{
			get
			{
				return this.unrounded_Time_Tracking_Calculated_QuantitiesFieldSpecified;
			}
			set
			{
				this.unrounded_Time_Tracking_Calculated_QuantitiesFieldSpecified = value;
				this.RaisePropertyChanged("Unrounded_Time_Tracking_Calculated_QuantitiesSpecified");
			}
		}

		[XmlElement(Order = 41)]
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

		[XmlElement(Order = 42)]
		public bool Include_Payee_Status_Data
		{
			get
			{
				return this.include_Payee_Status_DataField;
			}
			set
			{
				this.include_Payee_Status_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Status_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Status_DataSpecified
		{
			get
			{
				return this.include_Payee_Status_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Status_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Status_DataSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public bool Include_Payee_Contract_Data
		{
			get
			{
				return this.include_Payee_Contract_DataField;
			}
			set
			{
				this.include_Payee_Contract_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Contract_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Contract_DataSpecified
		{
			get
			{
				return this.include_Payee_Contract_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Contract_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Contract_DataSpecified");
			}
		}

		[XmlElement(Order = 44)]
		public bool Include_Payee_Collective_Agreement_Data
		{
			get
			{
				return this.include_Payee_Collective_Agreement_DataField;
			}
			set
			{
				this.include_Payee_Collective_Agreement_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Collective_Agreement_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Collective_Agreement_DataSpecified
		{
			get
			{
				return this.include_Payee_Collective_Agreement_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Collective_Agreement_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Collective_Agreement_DataSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public bool Include_Payee_Probation_Period_Data
		{
			get
			{
				return this.include_Payee_Probation_Period_DataField;
			}
			set
			{
				this.include_Payee_Probation_Period_DataField = value;
				this.RaisePropertyChanged("Include_Payee_Probation_Period_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Probation_Period_DataSpecified
		{
			get
			{
				return this.include_Payee_Probation_Period_DataFieldSpecified;
			}
			set
			{
				this.include_Payee_Probation_Period_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Probation_Period_DataSpecified");
			}
		}

		[XmlElement(Order = 46)]
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

		[XmlElement(Order = 47)]
		public bool Include_Payee_Related_Persons
		{
			get
			{
				return this.include_Payee_Related_PersonsField;
			}
			set
			{
				this.include_Payee_Related_PersonsField = value;
				this.RaisePropertyChanged("Include_Payee_Related_Persons");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Related_PersonsSpecified
		{
			get
			{
				return this.include_Payee_Related_PersonsFieldSpecified;
			}
			set
			{
				this.include_Payee_Related_PersonsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Related_PersonsSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public bool Include_Payee_Qualfication_Information
		{
			get
			{
				return this.include_Payee_Qualfication_InformationField;
			}
			set
			{
				this.include_Payee_Qualfication_InformationField = value;
				this.RaisePropertyChanged("Include_Payee_Qualfication_Information");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Qualfication_InformationSpecified
		{
			get
			{
				return this.include_Payee_Qualfication_InformationFieldSpecified;
			}
			set
			{
				this.include_Payee_Qualfication_InformationFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Qualfication_InformationSpecified");
			}
		}

		[XmlElement(Order = 49)]
		public bool Include_Costing_Allocation_Data
		{
			get
			{
				return this.include_Costing_Allocation_DataField;
			}
			set
			{
				this.include_Costing_Allocation_DataField = value;
				this.RaisePropertyChanged("Include_Costing_Allocation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Costing_Allocation_DataSpecified
		{
			get
			{
				return this.include_Costing_Allocation_DataFieldSpecified;
			}
			set
			{
				this.include_Costing_Allocation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Costing_Allocation_DataSpecified");
			}
		}

		[XmlElement(Order = 50)]
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

		[XmlElement(Order = 51)]
		public bool Exclude_Payee_Funds
		{
			get
			{
				return this.exclude_Payee_FundsField;
			}
			set
			{
				this.exclude_Payee_FundsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Funds");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_FundsSpecified
		{
			get
			{
				return this.exclude_Payee_FundsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_FundsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_FundsSpecified");
			}
		}

		[XmlElement(Order = 52)]
		public bool Exclude_Payee_Fund_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Fund_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Fund_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Fund_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Fund_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Fund_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Fund_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Fund_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 53)]
		public bool Exclude_Payee_Grants
		{
			get
			{
				return this.exclude_Payee_GrantsField;
			}
			set
			{
				this.exclude_Payee_GrantsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Grants");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_GrantsSpecified
		{
			get
			{
				return this.exclude_Payee_GrantsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_GrantsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_GrantsSpecified");
			}
		}

		[XmlElement(Order = 54)]
		public bool Exclude_Payee_Grant_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Grant_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Grant_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Grant_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Grant_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Grant_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Grant_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Grant_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 55)]
		public bool Exclude_Payee_Business_Units
		{
			get
			{
				return this.exclude_Payee_Business_UnitsField;
			}
			set
			{
				this.exclude_Payee_Business_UnitsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Business_Units");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Business_UnitsSpecified
		{
			get
			{
				return this.exclude_Payee_Business_UnitsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Business_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Business_UnitsSpecified");
			}
		}

		[XmlElement(Order = 56)]
		public bool Exclude_Payee_Business_Unit_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Business_Unit_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Business_Unit_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Business_Unit_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Business_Unit_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Business_Unit_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Business_Unit_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Business_Unit_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 57)]
		public bool Exclude_Payee_Programs
		{
			get
			{
				return this.exclude_Payee_ProgramsField;
			}
			set
			{
				this.exclude_Payee_ProgramsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Programs");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_ProgramsSpecified
		{
			get
			{
				return this.exclude_Payee_ProgramsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_ProgramsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_ProgramsSpecified");
			}
		}

		[XmlElement(Order = 58)]
		public bool Exclude_Payee_Program_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Program_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Program_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Program_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Program_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Program_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Program_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Program_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 59)]
		public bool Exclude_Payee_Gifts
		{
			get
			{
				return this.exclude_Payee_GiftsField;
			}
			set
			{
				this.exclude_Payee_GiftsField = value;
				this.RaisePropertyChanged("Exclude_Payee_Gifts");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_GiftsSpecified
		{
			get
			{
				return this.exclude_Payee_GiftsFieldSpecified;
			}
			set
			{
				this.exclude_Payee_GiftsFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_GiftsSpecified");
			}
		}

		[XmlElement(Order = 60)]
		public bool Exclude_Payee_Gift_Hierarchies
		{
			get
			{
				return this.exclude_Payee_Gift_HierarchiesField;
			}
			set
			{
				this.exclude_Payee_Gift_HierarchiesField = value;
				this.RaisePropertyChanged("Exclude_Payee_Gift_Hierarchies");
			}
		}

		[XmlIgnore]
		public bool Exclude_Payee_Gift_HierarchiesSpecified
		{
			get
			{
				return this.exclude_Payee_Gift_HierarchiesFieldSpecified;
			}
			set
			{
				this.exclude_Payee_Gift_HierarchiesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Payee_Gift_HierarchiesSpecified");
			}
		}

		[XmlElement(Order = 61)]
		public bool Exclude_Pay_Component_Time_Off_Detail_Data
		{
			get
			{
				return this.exclude_Pay_Component_Time_Off_Detail_DataField;
			}
			set
			{
				this.exclude_Pay_Component_Time_Off_Detail_DataField = value;
				this.RaisePropertyChanged("Exclude_Pay_Component_Time_Off_Detail_Data");
			}
		}

		[XmlIgnore]
		public bool Exclude_Pay_Component_Time_Off_Detail_DataSpecified
		{
			get
			{
				return this.exclude_Pay_Component_Time_Off_Detail_DataFieldSpecified;
			}
			set
			{
				this.exclude_Pay_Component_Time_Off_Detail_DataFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Pay_Component_Time_Off_Detail_DataSpecified");
			}
		}

		[XmlElement(Order = 62)]
		public bool Include_Pay_Component_Time_Off_Entries_Detail_Data
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Entries_Detail_DataField;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Entries_Detail_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Entries_Detail_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Time_Off_Entries_Detail_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Entries_Detail_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Entries_Detail_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Entries_Detail_DataSpecified");
			}
		}

		[XmlElement(Order = 63)]
		public bool Include_Pay_Component_Time_Off_Corrected_Data
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Corrected_DataField;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Corrected_DataField = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Corrected_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Pay_Component_Time_Off_Corrected_DataSpecified
		{
			get
			{
				return this.include_Pay_Component_Time_Off_Corrected_DataFieldSpecified;
			}
			set
			{
				this.include_Pay_Component_Time_Off_Corrected_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Pay_Component_Time_Off_Corrected_DataSpecified");
			}
		}

		[XmlElement(Order = 64)]
		public bool Include_Payee_Compensation_FTE_Change_Date
		{
			get
			{
				return this.include_Payee_Compensation_FTE_Change_DateField;
			}
			set
			{
				this.include_Payee_Compensation_FTE_Change_DateField = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_FTE_Change_Date");
			}
		}

		[XmlIgnore]
		public bool Include_Payee_Compensation_FTE_Change_DateSpecified
		{
			get
			{
				return this.include_Payee_Compensation_FTE_Change_DateFieldSpecified;
			}
			set
			{
				this.include_Payee_Compensation_FTE_Change_DateFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payee_Compensation_FTE_Change_DateSpecified");
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
