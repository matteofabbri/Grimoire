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
	public class Change_Job_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime effective_DateField;

		private Change_Job_Detail_DataType change_Job_Detail_DataField;

		private Propose_Compensation_For_Position_Sub_Business_ProcessType propose_Compensation_Sub_ProcessField;

		private Request_One_Time_Payment_Sub_Business_ProcessType request_One_Time_Payment_Sub_ProcessField;

		private Request_Stock_Sub_Business_ProcessType request_Stock_Grant_Sub_ProcessField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType change_Organization_Sub_ProcessField;

		private Assign_Pay_Group_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Sub_Business_ProcessType review_Payroll_Interface_Sub_ProcessField;

		private Assign_Matrix_Organization_Sub_Business_ProcessType assign_Matrix_Organization_Sub_ProcessField;

		private Change_Personal_Information_Sub_Business_ProcessType change_Personal_Information_Sub_ProcessField;

		private Maintain_Employee_Contracts_Sub_Business_ProcessType maintain_Employee_Contracts_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		private Assign_Roles_Sub_ProcessType assign_Roles_Sub_ProcessField;

		private Assign_Superior_Organization_Sub_ProcessType assign_Superior_Organization_Sub_ProcessField;

		private Create_Job_Requisition_Sub_ProcessType create_Job_Requisition_Sub_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Switch_Primary_Job_Sub_ProcessType switch_Primary_Job_Sub_ProcessField;

		private Update_Academic_Appointment_Sub_ProcessType update_Academic_Appointment_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

		private Assign_Employee_Collective_Agreement_Sub_Business_ProcessType assign_Employee_Collective_Agreement_Sub_ProcessField;

		private Create_Subordinate_Sub_Business_ProcessType create_Subordinate_Sub_ProcessField;

		private Student_Employment_Eligibility_Sub_Business_ProcessType student_Employment_Eligibility_Sub_ProcessField;

		private Onboarding_Setup_Sub_Business_ProcessType onboarding_Setup_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(Order = 3)]
		public Change_Job_Detail_DataType Change_Job_Detail_Data
		{
			get
			{
				return this.change_Job_Detail_DataField;
			}
			set
			{
				this.change_Job_Detail_DataField = value;
				this.RaisePropertyChanged("Change_Job_Detail_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Propose_Compensation_For_Position_Sub_Business_ProcessType Propose_Compensation_Sub_Process
		{
			get
			{
				return this.propose_Compensation_Sub_ProcessField;
			}
			set
			{
				this.propose_Compensation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Propose_Compensation_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Edit_Assign_Position_Organization_Sub_Business_ProcessType Change_Organization_Sub_Process
		{
			get
			{
				return this.change_Organization_Sub_ProcessField;
			}
			set
			{
				this.change_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Change_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Maintain_Employee_Contracts_Sub_Business_ProcessType Maintain_Employee_Contracts_Sub_Process
		{
			get
			{
				return this.maintain_Employee_Contracts_Sub_ProcessField;
			}
			set
			{
				this.maintain_Employee_Contracts_Sub_ProcessField = value;
				this.RaisePropertyChanged("Maintain_Employee_Contracts_Sub_Process");
			}
		}

		[XmlElement(Order = 13)]
		public Assign_Organization_Roles_Sub_Business_ProcessType Assign_Organization_Roles_Sub_Process
		{
			get
			{
				return this.assign_Organization_Roles_Sub_ProcessField;
			}
			set
			{
				this.assign_Organization_Roles_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Organization_Roles_Sub_Process");
			}
		}

		[XmlElement(Order = 14)]
		public Assign_Roles_Sub_ProcessType Assign_Roles_Sub_Process
		{
			get
			{
				return this.assign_Roles_Sub_ProcessField;
			}
			set
			{
				this.assign_Roles_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Roles_Sub_Process");
			}
		}

		[XmlElement(Order = 15)]
		public Assign_Superior_Organization_Sub_ProcessType Assign_Superior_Organization_Sub_Process
		{
			get
			{
				return this.assign_Superior_Organization_Sub_ProcessField;
			}
			set
			{
				this.assign_Superior_Organization_Sub_ProcessField = value;
				this.RaisePropertyChanged("Assign_Superior_Organization_Sub_Process");
			}
		}

		[XmlElement(Order = 16)]
		public Create_Job_Requisition_Sub_ProcessType Create_Job_Requisition_Sub_Process
		{
			get
			{
				return this.create_Job_Requisition_Sub_ProcessField;
			}
			set
			{
				this.create_Job_Requisition_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Job_Requisition_Sub_Process");
			}
		}

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public Switch_Primary_Job_Sub_ProcessType Switch_Primary_Job_Sub_Process
		{
			get
			{
				return this.switch_Primary_Job_Sub_ProcessField;
			}
			set
			{
				this.switch_Primary_Job_Sub_ProcessField = value;
				this.RaisePropertyChanged("Switch_Primary_Job_Sub_Process");
			}
		}

		[XmlElement(Order = 19)]
		public Update_Academic_Appointment_Sub_ProcessType Update_Academic_Appointment_Sub_Process
		{
			get
			{
				return this.update_Academic_Appointment_Sub_ProcessField;
			}
			set
			{
				this.update_Academic_Appointment_Sub_ProcessField = value;
				this.RaisePropertyChanged("Update_Academic_Appointment_Sub_Process");
			}
		}

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
		public Create_Subordinate_Sub_Business_ProcessType Create_Subordinate_Sub_Process
		{
			get
			{
				return this.create_Subordinate_Sub_ProcessField;
			}
			set
			{
				this.create_Subordinate_Sub_ProcessField = value;
				this.RaisePropertyChanged("Create_Subordinate_Sub_Process");
			}
		}

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
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
