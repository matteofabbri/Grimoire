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
	public class Edit_Position_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Position_ElementObjectType position_ReferenceField;

		private DateTime effective_DateField;

		private Edit_Position_Event_DataType edit_Position_Event_DataField;

		private Request_Compensation_For_Edit_Position_Sub_Business_ProcessType request_Compensation_Change_Sub_ProcessField;

		private Edit_Assign_Position_Organization_Sub_Business_ProcessType edit_Assign_Organization_Sub_ProcessField;

		private Assign_Pay_Group_Sub_Business_ProcessType assign_Pay_Group_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Sub_Business_ProcessType review_Payroll_Interface_Sub_ProcessField;

		private Assign_Matrix_Organization_Sub_Business_ProcessType assign_Matrix_Organization_Sub_ProcessField;

		private Change_Personal_Information_Sub_Business_ProcessType change_Personal_Information_Sub_ProcessField;

		private Request_Compensation_Default_Sub_Business_ProcessType request_Default_Compensation_Sub_ProcessField;

		private Edit_Service_Dates_Sub_Business_ProcessType edit_Service_Dates_Sub_ProcessField;

		private Remove_Retiree_Status_Sub_Business_ProcessType remove_Retiree_Status_Sub_ProcessField;

		private Maintain_Employee_Contracts_Sub_Business_ProcessType maintain_Employee_Contracts_Sub_Business_ProcessField;

		private Check_Position_Budget_Sub_Business_ProcessType check_Position_Budget_Sub_ProcessField;

		private Update_Academic_Appointment_Sub_ProcessType update_Academic_Appointment_Sub_ProcessField;

		private Assign_Costing_Allocation_Sub_Business_ProcessType assign_Costing_Allocation_Sub_ProcessField;

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
		public Edit_Position_Event_DataType Edit_Position_Event_Data
		{
			get
			{
				return this.edit_Position_Event_DataField;
			}
			set
			{
				this.edit_Position_Event_DataField = value;
				this.RaisePropertyChanged("Edit_Position_Event_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Request_Compensation_For_Edit_Position_Sub_Business_ProcessType Request_Compensation_Change_Sub_Process
		{
			get
			{
				return this.request_Compensation_Change_Sub_ProcessField;
			}
			set
			{
				this.request_Compensation_Change_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Compensation_Change_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Request_Compensation_Default_Sub_Business_ProcessType Request_Default_Compensation_Sub_Process
		{
			get
			{
				return this.request_Default_Compensation_Sub_ProcessField;
			}
			set
			{
				this.request_Default_Compensation_Sub_ProcessField = value;
				this.RaisePropertyChanged("Request_Default_Compensation_Sub_Process");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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
