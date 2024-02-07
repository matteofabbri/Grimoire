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
	public class Request_Return_from_Leave_of_Absence_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime first_Day_Back_at_WorkField;

		private bool first_Day_Back_at_WorkFieldSpecified;

		private Leaves_Returning_from_DataType[] leaves_Returning_from_DataField;

		private Edit_Service_Dates_Sub_Business_ProcessType edit_Service_Dates_Sub_ProcessField;

		private Review_Payroll_Interface_Data_Extract_Business_Sub_ProcessType review_Payroll_Interface_Event_Sub_ProcessField;

		private Propose_Compensation_For_Leave_of_Absence_Sub_Business_ProcessType[] propose_Compensation_for_Leave_of_Absence_Sub_ProcessField;

		private Assign_Organization_Roles_Sub_Business_ProcessType assign_Organization_Roles_Sub_ProcessField;

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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime First_Day_Back_at_Work
		{
			get
			{
				return this.first_Day_Back_at_WorkField;
			}
			set
			{
				this.first_Day_Back_at_WorkField = value;
				this.RaisePropertyChanged("First_Day_Back_at_Work");
			}
		}

		[XmlIgnore]
		public bool First_Day_Back_at_WorkSpecified
		{
			get
			{
				return this.first_Day_Back_at_WorkFieldSpecified;
			}
			set
			{
				this.first_Day_Back_at_WorkFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_Back_at_WorkSpecified");
			}
		}

		[XmlElement("Leaves_Returning_from_Data", Order = 2)]
		public Leaves_Returning_from_DataType[] Leaves_Returning_from_Data
		{
			get
			{
				return this.leaves_Returning_from_DataField;
			}
			set
			{
				this.leaves_Returning_from_DataField = value;
				this.RaisePropertyChanged("Leaves_Returning_from_Data");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Propose_Compensation_for_Leave_of_Absence_Sub_Process", Order = 5)]
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

		[XmlElement(Order = 6)]
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
