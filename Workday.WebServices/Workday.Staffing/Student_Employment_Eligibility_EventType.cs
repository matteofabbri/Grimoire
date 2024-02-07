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
	public class Student_Employment_Eligibility_EventType : INotifyPropertyChanged
	{
		private Student_Employment_Eligibility_EventObjectType student_Employment_Eligibility_Event_ReferenceField;

		private ApplicantObjectType preHire_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private string proposed_Worker_IDField;

		private Action_EventObjectType parent_Event_ReferenceField;

		private Employee_TypeObjectType employee_Type_ReferenceField;

		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private WorkerObjectType manager_ReferenceField;

		private DateTime event_Effective_DateField;

		private bool event_Effective_DateFieldSpecified;

		private decimal total_Scheduled_HoursField;

		private bool total_Scheduled_HoursFieldSpecified;

		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private Position_RestrictionsObjectType position_Restriction_ReferenceField;

		private Position_Details_Sub_DataType[] position_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Employment_Eligibility_EventObjectType Student_Employment_Eligibility_Event_Reference
		{
			get
			{
				return this.student_Employment_Eligibility_Event_ReferenceField;
			}
			set
			{
				this.student_Employment_Eligibility_Event_ReferenceField = value;
				this.RaisePropertyChanged("Student_Employment_Eligibility_Event_Reference");
			}
		}

		[XmlElement("Pre-Hire_Reference", Order = 1)]
		public ApplicantObjectType PreHire_Reference
		{
			get
			{
				return this.preHire_ReferenceField;
			}
			set
			{
				this.preHire_ReferenceField = value;
				this.RaisePropertyChanged("PreHire_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Proposed_Worker_ID
		{
			get
			{
				return this.proposed_Worker_IDField;
			}
			set
			{
				this.proposed_Worker_IDField = value;
				this.RaisePropertyChanged("Proposed_Worker_ID");
			}
		}

		[XmlElement(Order = 4)]
		public Action_EventObjectType Parent_Event_Reference
		{
			get
			{
				return this.parent_Event_ReferenceField;
			}
			set
			{
				this.parent_Event_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Event_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Employee_TypeObjectType Employee_Type_Reference
		{
			get
			{
				return this.employee_Type_ReferenceField;
			}
			set
			{
				this.employee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Event_Effective_Date
		{
			get
			{
				return this.event_Effective_DateField;
			}
			set
			{
				this.event_Effective_DateField = value;
				this.RaisePropertyChanged("Event_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Event_Effective_DateSpecified
		{
			get
			{
				return this.event_Effective_DateFieldSpecified;
			}
			set
			{
				this.event_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Event_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Total_Scheduled_Hours
		{
			get
			{
				return this.total_Scheduled_HoursField;
			}
			set
			{
				this.total_Scheduled_HoursField = value;
				this.RaisePropertyChanged("Total_Scheduled_Hours");
			}
		}

		[XmlIgnore]
		public bool Total_Scheduled_HoursSpecified
		{
			get
			{
				return this.total_Scheduled_HoursFieldSpecified;
			}
			set
			{
				this.total_Scheduled_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Total_Scheduled_HoursSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Job_RequisitionObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Position_RestrictionsObjectType Position_Restriction_Reference
		{
			get
			{
				return this.position_Restriction_ReferenceField;
			}
			set
			{
				this.position_Restriction_ReferenceField = value;
				this.RaisePropertyChanged("Position_Restriction_Reference");
			}
		}

		[XmlElement("Position_Details_Data", Order = 12)]
		public Position_Details_Sub_DataType[] Position_Details_Data
		{
			get
			{
				return this.position_Details_DataField;
			}
			set
			{
				this.position_Details_DataField = value;
				this.RaisePropertyChanged("Position_Details_Data");
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
