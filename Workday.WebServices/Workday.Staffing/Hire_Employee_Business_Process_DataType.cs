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
	public class Hire_Employee_Business_Process_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Supervisory_OrganizationObjectType organization_ReferenceField;

		private object item1Field;

		private DateTime hire_DateField;

		private bool hire_DateFieldSpecified;

		private Hire_Employee_Event_DataType hire_Employee_Event_DataField;

		private Propose_Compensation_For_Employment_Sub_Business_ProcessType propose_Compensation_for_Hire_Sub_ProcessField;

		private Update_ID_Information_Sub_Business_ProcessType update_ID_Information_Sub_ProcessField;

		private Edit_Government_IDs_Sub_Business_ProcessType edit_Government_IDs_Sub_ProcessField;

		private Edit_Passports_and_Visas_Sub_Business_ProcessType edit_Passports_and_Visas_Sub_ProcessField;

		private Edit_Licenses_Sub_Business_ProcessType edit_License_Sub_ProcessField;

		private Edit_Custom_IDs_Sub_Business_ProcessType edit_Custom_IDs_Sub_ProcessField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Assign_Pay_Group_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Sub_Business_ProcessType review_Payroll_Interface_Sub_ProcessField;

		private Request_One_Time_Payment_Sub_Business_ProcessType request_One_Time_Payment_Sub_ProcessField;

		private OneTime_Payment_for_Referral_Sub_Business_ProcessType request_One_Time_Payment_for_Referral_Sub_ProcessField;

		private Request_Stock_Sub_Business_ProcessType request_Stock_Grant_Sub_ProcessField;

		private Create_Workday_Account_Sub_Business_ProcessType create_Workday_Account_Sub_ProcessField;

		private Assign_Matrix_Organization_Sub_Business_ProcessType assign_Matrix_Organization_Sub_ProcessField;

		private Change_Personal_Information_Sub_Business_ProcessType change_Personal_Information_Sub_ProcessField;

		private Create_Provisioning_Event_Sub_Business_ProcessType create_Provisioning_Event_Sub_ProcessField;

		private Create_Benefit_Life_Event_Sub_Business_ProcessType create_Benefit_Life_Event_Sub_ProcessField;

		private Maintain_Employee_Contracts_Sub_Business_ProcessType maintain_Employee_Contracts_Sub_Business_ProcessField;

		private Edit_Service_Dates_Sub_Business_ProcessType edit_Service_Dates_Sub_ProcessField;

		private Remove_Retiree_Status_Sub_Business_ProcessType remove_Retiree_Status_Sub_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

		private Edit_Background_Check_Sub_Business_ProcessType edit_Background_Check_Sub_ProcessField;

		private Add_Academic_Appointment_Sub_Business_ProcessType add_Academic_Appointment_Sub_ProcessField;

		private Assign_Employee_Collective_Agreement_Sub_Business_ProcessType assign_Employee_Collective_Agreement_Sub_ProcessField;

		private Manage_Probation_Period_Sub_Business_ProcessType manage_Employee_Probation_Period_Sub_Business_ProcessField;

		private Change_Emergency_Contacts_Sub_Business_ProcessType emergency_Contacts_Sub_ProcessField;

		private Onboarding_Setup_Sub_Business_ProcessType onboarding_Setup_Sub_ProcessField;

		private Student_Employment_Eligibility_Sub_Business_ProcessType student_Employment_Eligibility_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Applicant_Data", typeof(Create_Applicant_DataType), Order = 0), XmlElement("Applicant_Reference", typeof(ApplicantObjectType), Order = 0), XmlElement("Former_Worker_Reference", typeof(Former_WorkerObjectType), Order = 0), XmlElement("Student_Reference", typeof(StudentObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public Supervisory_OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Job_Requisition_Reference", typeof(Job_RequisitionObjectType), Order = 2), XmlElement("Position_Reference", typeof(Position_RestrictionsObjectType), Order = 2)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Hire_Date
		{
			get
			{
				return this.hire_DateField;
			}
			set
			{
				this.hire_DateField = value;
				this.RaisePropertyChanged("Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Hire_DateSpecified
		{
			get
			{
				return this.hire_DateFieldSpecified;
			}
			set
			{
				this.hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Hire_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Hire_Employee_Event_DataType Hire_Employee_Event_Data
		{
			get
			{
				return this.hire_Employee_Event_DataField;
			}
			set
			{
				this.hire_Employee_Event_DataField = value;
				this.RaisePropertyChanged("Hire_Employee_Event_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Propose_Compensation_For_Employment_Sub_Business_ProcessType Propose_Compensation_for_Hire_Sub_Process
		{
			get
			{
				return this.propose_Compensation_for_Hire_Sub_ProcessField;
			}
			set
			{
				this.propose_Compensation_for_Hire_Sub_ProcessField = value;
				this.RaisePropertyChanged("Propose_Compensation_for_Hire_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
		public Update_ID_Information_Sub_Business_ProcessType Update_ID_Information_Sub_Process
		{
			get
			{
				return this.update_ID_Information_Sub_ProcessField;
			}
			set
			{
				this.update_ID_Information_Sub_ProcessField = value;
				this.RaisePropertyChanged("Update_ID_Information_Sub_Process");
			}
		}

		[XmlElement(Order = 7)]
		public Edit_Government_IDs_Sub_Business_ProcessType Edit_Government_IDs_Sub_Process
		{
			get
			{
				return this.edit_Government_IDs_Sub_ProcessField;
			}
			set
			{
				this.edit_Government_IDs_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Government_IDs_Sub_Process");
			}
		}

		[XmlElement(Order = 8)]
		public Edit_Passports_and_Visas_Sub_Business_ProcessType Edit_Passports_and_Visas_Sub_Process
		{
			get
			{
				return this.edit_Passports_and_Visas_Sub_ProcessField;
			}
			set
			{
				this.edit_Passports_and_Visas_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Passports_and_Visas_Sub_Process");
			}
		}

		[XmlElement(Order = 9)]
		public Edit_Licenses_Sub_Business_ProcessType Edit_License_Sub_Process
		{
			get
			{
				return this.edit_License_Sub_ProcessField;
			}
			set
			{
				this.edit_License_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_License_Sub_Process");
			}
		}

		[XmlElement(Order = 10)]
		public Edit_Custom_IDs_Sub_Business_ProcessType Edit_Custom_IDs_Sub_Process
		{
			get
			{
				return this.edit_Custom_IDs_Sub_ProcessField;
			}
			set
			{
				this.edit_Custom_IDs_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Custom_IDs_Sub_Process");
			}
		}

		[XmlElement(Order = 11)]
		public Edit_Assign_Position_Organization_Sub_Business_ProcessType Edit_Assign_Organization_Sub_Process
		{
			get
			{
				return this.edit_Assign_Organization_Sub_ProcessField;
			}
			set
			{
				this.edit_Assign_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Assign_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 12)]
		public Assign_Pay_Group_Sub_Business_ProcessType Assign_Pay_Group_Sub_Process
		{
			get
			{
				return this.assign_Pay_Group_Sub_ProcessField;
			}
			set
			{
				this.assign_Pay_Group_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Pay_Group_Sub_Process");
			}
		}

		[XmlElement(Order = 13)]
		public Review_Payroll_Interface_Data_Sub_Business_ProcessType Review_Payroll_Interface_Sub_Process
		{
			get
			{
				return this.review_Payroll_Interface_Sub_ProcessField;
			}
			set
			{
				this.review_Payroll_Interface_Sub_ProcessField = value;
				this.RaisePropertyChanged("Review_Payroll_Interface_Sub_Process");
			}
		}

		[XmlElement(Order = 14)]
		public Request_One_Time_Payment_Sub_Business_ProcessType Request_One_Time_Payment_Sub_Process
		{
			get
			{
				return this.request_One_Time_Payment_Sub_ProcessField;
			}
			set
			{
				this.request_One_Time_Payment_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_One_Time_Payment_Sub_Process");
			}
		}

		[XmlElement(Order = 15)]
		public OneTime_Payment_for_Referral_Sub_Business_ProcessType Request_One_Time_Payment_for_Referral_Sub_Process
		{
			get
			{
				return this.request_One_Time_Payment_for_Referral_Sub_ProcessField;
			}
			set
			{
				this.request_One_Time_Payment_for_Referral_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_One_Time_Payment_for_Referral_Sub_Process");
			}
		}

		[XmlElement(Order = 16)]
		public Request_Stock_Sub_Business_ProcessType Request_Stock_Grant_Sub_Process
		{
			get
			{
				return this.request_Stock_Grant_Sub_ProcessField;
			}
			set
			{
				this.request_Stock_Grant_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Stock_Grant_Sub_Process");
			}
		}

		[XmlElement(Order = 17)]
		public Create_Workday_Account_Sub_Business_ProcessType Create_Workday_Account_Sub_Process
		{
			get
			{
				return this.create_Workday_Account_Sub_ProcessField;
			}
			set
			{
				this.create_Workday_Account_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Workday_Account_Sub_Process");
			}
		}

		[XmlElement(Order = 18)]
		public Assign_Matrix_Organization_Sub_Business_ProcessType Assign_Matrix_Organization_Sub_Process
		{
			get
			{
				return this.assign_Matrix_Organization_Sub_ProcessField;
			}
			set
			{
				this.assign_Matrix_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Matrix_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 19)]
		public Change_Personal_Information_Sub_Business_ProcessType Change_Personal_Information_Sub_Process
		{
			get
			{
				return this.change_Personal_Information_Sub_ProcessField;
			}
			set
			{
				this.change_Personal_Information_Sub_ProcessField = value;
				this.RaisePropertyChanged("Change_Personal_Information_Sub_Process");
			}
		}

		[XmlElement(Order = 20)]
		public Create_Provisioning_Event_Sub_Business_ProcessType Create_Provisioning_Event_Sub_Process
		{
			get
			{
				return this.create_Provisioning_Event_Sub_ProcessField;
			}
			set
			{
				this.create_Provisioning_Event_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Provisioning_Event_Sub_Process");
			}
		}

		[XmlElement(Order = 21)]
		public Create_Benefit_Life_Event_Sub_Business_ProcessType Create_Benefit_Life_Event_Sub_Process
		{
			get
			{
				return this.create_Benefit_Life_Event_Sub_ProcessField;
			}
			set
			{
				this.create_Benefit_Life_Event_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Benefit_Life_Event_Sub_Process");
			}
		}

		[XmlElement(Order = 22)]
		public Maintain_Employee_Contracts_Sub_Business_ProcessType Maintain_Employee_Contracts_Sub_Business_Process
		{
			get
			{
				return this.maintain_Employee_Contracts_Sub_Business_ProcessField;
			}
			set
			{
				this.maintain_Employee_Contracts_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Maintain_Employee_Contracts_Sub_Business_Process");
			}
		}

		[XmlElement(Order = 23)]
		public Edit_Service_Dates_Sub_Business_ProcessType Edit_Service_Dates_Sub_Process
		{
			get
			{
				return this.edit_Service_Dates_Sub_ProcessField;
			}
			set
			{
				this.edit_Service_Dates_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Service_Dates_Sub_Process");
			}
		}

		[XmlElement(Order = 24)]
		public Remove_Retiree_Status_Sub_Business_ProcessType Remove_Retiree_Status_Sub_Process
		{
			get
			{
				return this.remove_Retiree_Status_Sub_ProcessField;
			}
			set
			{
				this.remove_Retiree_Status_Sub_ProcessField = value;
				this.RaisePropertyChanged("Remove_Retiree_Status_Sub_Process");
			}
		}

		[XmlElement(Order = 25)]
		public Check_Position_Budget_Sub_Business_ProcessType Check_Position_Budget_Sub_Process
		{
			get
			{
				return this.check_Position_Budget_Sub_ProcessField;
			}
			set
			{
				this.check_Position_Budget_Sub_ProcessField = value;
				this.RaisePropertyChanged("Check_Position_Budget_Sub_Process");
			}
		}

		[XmlElement(Order = 26)]
		public Assign_Costing_Allocation_Sub_Business_ProcessType Assign_Costing_Allocation_Sub_Process
		{
			get
			{
				return this.assign_Costing_Allocation_Sub_ProcessField;
			}
			set
			{
				this.assign_Costing_Allocation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Costing_Allocation_Sub_Process");
			}
		}

		[XmlElement(Order = 27)]
		public Edit_Background_Check_Sub_Business_ProcessType Edit_Background_Check_Sub_Process
		{
			get
			{
				return this.edit_Background_Check_Sub_ProcessField;
			}
			set
			{
				this.edit_Background_Check_Sub_ProcessField = value;
				this.RaisePropertyChanged("Edit_Background_Check_Sub_Process");
			}
		}

		[XmlElement(Order = 28)]
		public Add_Academic_Appointment_Sub_Business_ProcessType Add_Academic_Appointment_Sub_Process
		{
			get
			{
				return this.add_Academic_Appointment_Sub_ProcessField;
			}
			set
			{
				this.add_Academic_Appointment_Sub_ProcessField = value;
				this.RaisePropertyChanged("Add_Academic_Appointment_Sub_Process");
			}
		}

		[XmlElement(Order = 29)]
		public Assign_Employee_Collective_Agreement_Sub_Business_ProcessType Assign_Employee_Collective_Agreement_Sub_Process
		{
			get
			{
				return this.assign_Employee_Collective_Agreement_Sub_ProcessField;
			}
			set
			{
				this.assign_Employee_Collective_Agreement_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Employee_Collective_Agreement_Sub_Process");
			}
		}

		[XmlElement(Order = 30)]
		public Manage_Probation_Period_Sub_Business_ProcessType Manage_Employee_Probation_Period_Sub_Business_Process
		{
			get
			{
				return this.manage_Employee_Probation_Period_Sub_Business_ProcessField;
			}
			set
			{
				this.manage_Employee_Probation_Period_Sub_Business_ProcessField = value;
				this.RaisePropertyChanged("Manage_Employee_Probation_Period_Sub_Business_Process");
			}
		}

		[XmlElement(Order = 31)]
		public Change_Emergency_Contacts_Sub_Business_ProcessType Emergency_Contacts_Sub_Process
		{
			get
			{
				return this.emergency_Contacts_Sub_ProcessField;
			}
			set
			{
				this.emergency_Contacts_Sub_ProcessField = value;
				this.RaisePropertyChanged("Emergency_Contacts_Sub_Process");
			}
		}

		[XmlElement(Order = 32)]
		public Onboarding_Setup_Sub_Business_ProcessType Onboarding_Setup_Sub_Process
		{
			get
			{
				return this.onboarding_Setup_Sub_ProcessField;
			}
			set
			{
				this.onboarding_Setup_Sub_ProcessField = value;
				this.RaisePropertyChanged("Onboarding_Setup_Sub_Process");
			}
		}

		[XmlElement(Order = 33)]
		public Student_Employment_Eligibility_Sub_Business_ProcessType Student_Employment_Eligibility_Sub_Process
		{
			get
			{
				return this.student_Employment_Eligibility_Sub_ProcessField;
			}
			set
			{
				this.student_Employment_Eligibility_Sub_ProcessField = value;
				this.RaisePropertyChanged("Student_Employment_Eligibility_Sub_Process");
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
