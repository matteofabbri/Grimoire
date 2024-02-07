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
	public class Terminate_Employee_DataType : INotifyPropertyChanged
	{
		private EmployeeObjectType employee_ReferenceField;

		private DateTime termination_DateField;

		private Terminate_Event_DataType terminate_Event_DataField;

		private Request_One_Time_Payment_Sub_Business_ProcessType request_One_Time_Payment_Sub_ProcessField;

		private Review_COBRA_Eligibility_Sub_Business_ProcessType review_COBRA_Eligibility_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType review_Payroll_Interface_Event_Sub_ProcessField;

		private Edit_Service_Dates_Sub_Business_ProcessType edit_Service_Dates_Sub_ProcessField;

		private Add_Retiree_Status_Sub_Business_ProcessType add_Retiree_Status_Sub_ProcessField;

		private Maintain_Employee_Contracts_Sub_Business_ProcessType maintain_Employee_Contracts_Sub_Business_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

		private Create_Job_Requisition_Sub_ProcessType create_Job_Requisition_Sub_ProcessField;

		private End_Academic_Appointment_Sub_Business_ProcessType end_Academic_Appointment_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public EmployeeObjectType Employee_Reference
		{
			get
			{
				return this.employee_ReferenceField;
			}
			set
			{
				this.employee_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Termination_Date
		{
			get
			{
				return this.termination_DateField;
			}
			set
			{
				this.termination_DateField = value;
				this.RaisePropertyChanged("Termination_Date");
			}
		}

		[XmlElement(Order = 2)]
		public Terminate_Event_DataType Terminate_Event_Data
		{
			get
			{
				return this.terminate_Event_DataField;
			}
			set
			{
				this.terminate_Event_DataField = value;
				this.RaisePropertyChanged("Terminate_Event_Data");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Review_COBRA_Eligibility_Sub_Business_ProcessType Review_COBRA_Eligibility_Sub_Process
		{
			get
			{
				return this.review_COBRA_Eligibility_Sub_ProcessField;
			}
			set
			{
				this.review_COBRA_Eligibility_Sub_ProcessField = value;
				this.RaisePropertyChanged("Review_COBRA_Eligibility_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
		public Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType Review_Payroll_Interface_Event_Sub_Process
		{
			get
			{
				return this.review_Payroll_Interface_Event_Sub_ProcessField;
			}
			set
			{
				this.review_Payroll_Interface_Event_Sub_ProcessField = value;
				this.RaisePropertyChanged("Review_Payroll_Interface_Event_Sub_Process");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Add_Retiree_Status_Sub_Business_ProcessType Add_Retiree_Status_Sub_Process
		{
			get
			{
				return this.add_Retiree_Status_Sub_ProcessField;
			}
			set
			{
				this.add_Retiree_Status_Sub_ProcessField = value;
				this.RaisePropertyChanged("Add_Retiree_Status_Sub_Process");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public End_Academic_Appointment_Sub_Business_ProcessType End_Academic_Appointment_Sub_Process
		{
			get
			{
				return this.end_Academic_Appointment_Sub_ProcessField;
			}
			set
			{
				this.end_Academic_Appointment_Sub_ProcessField = value;
				this.RaisePropertyChanged("End_Academic_Appointment_Sub_Process");
			}
		}

		[XmlElement(Order = 13)]
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
