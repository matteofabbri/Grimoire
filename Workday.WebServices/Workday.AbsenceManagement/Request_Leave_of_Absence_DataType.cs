using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Request_Leave_of_Absence_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Leave_Request_DataType leave_Request_DataField;

		private Review_COBRA_Eligibility_Sub_Business_ProcessType review_COBRA_Eligibility_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType review_Payroll_Interface_Event_Sub_ProcessField;

		private Propose_Compensation_For_Leave_of_Absence_Sub_Business_ProcessType[] propose_Compensation_for_Leave_of_Absence_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

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
		public Leave_Request_DataType Leave_Request_Data
		{
			get
			{
				return this.leave_Request_DataField;
			}
			set
			{
				this.leave_Request_DataField = value;
				this.RaisePropertyChanged("Leave_Request_Data");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Propose_Compensation_for_Leave_of_Absence_Sub_Process", Order = 4)]
		public Propose_Compensation_For_Leave_of_Absence_Sub_Business_ProcessType[] Propose_Compensation_for_Leave_of_Absence_Sub_Process
		{
			get
			{
				return this.propose_Compensation_for_Leave_of_Absence_Sub_ProcessField;
			}
			set
			{
				this.propose_Compensation_for_Leave_of_Absence_Sub_ProcessField = value;
				this.RaisePropertyChanged("Propose_Compensation_for_Leave_of_Absence_Sub_Process");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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
