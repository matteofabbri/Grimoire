using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Job_Applied_To_DataType : INotifyPropertyChanged
	{
		private Job_ApplicationObjectType job_Application_ReferenceField;

		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private DateTime job_Application_DateField;

		private bool job_Application_DateFieldSpecified;

		private Recruiting_Stage__Workday_Owned_ObjectType stage_ReferenceField;

		private Workflow_StepObjectType workflow_Step_ReferenceField;

		private Recruiting_DispositionObjectType disposition_ReferenceField;

		private DateTime status_TimestampField;

		private bool status_TimestampFieldSpecified;

		private Applicant_SourceObjectType source_ReferenceField;

		private WorkerObjectType referred_By_Worker_ReferenceField;

		private Processmaintained_RoleObjectType added_By_Worker_ReferenceField;

		private Application_Personal_Information_DataType itemField;

		private Person_Biographic_and_Demographic_Information_DataType global_Personal_Information_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_ApplicationObjectType Job_Application_Reference
		{
			get
			{
				return this.job_Application_ReferenceField;
			}
			set
			{
				this.job_Application_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_Requisition_EnabledObjectType Job_Requisition_Reference
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

		[XmlElement(Order = 2)]
		public DateTime Job_Application_Date
		{
			get
			{
				return this.job_Application_DateField;
			}
			set
			{
				this.job_Application_DateField = value;
				this.RaisePropertyChanged("Job_Application_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Application_DateSpecified
		{
			get
			{
				return this.job_Application_DateFieldSpecified;
			}
			set
			{
				this.job_Application_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Application_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Recruiting_Stage__Workday_Owned_ObjectType Stage_Reference
		{
			get
			{
				return this.stage_ReferenceField;
			}
			set
			{
				this.stage_ReferenceField = value;
				this.RaisePropertyChanged("Stage_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Workflow_StepObjectType Workflow_Step_Reference
		{
			get
			{
				return this.workflow_Step_ReferenceField;
			}
			set
			{
				this.workflow_Step_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_Step_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Recruiting_DispositionObjectType Disposition_Reference
		{
			get
			{
				return this.disposition_ReferenceField;
			}
			set
			{
				this.disposition_ReferenceField = value;
				this.RaisePropertyChanged("Disposition_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public DateTime Status_Timestamp
		{
			get
			{
				return this.status_TimestampField;
			}
			set
			{
				this.status_TimestampField = value;
				this.RaisePropertyChanged("Status_Timestamp");
			}
		}

		[XmlIgnore]
		public bool Status_TimestampSpecified
		{
			get
			{
				return this.status_TimestampFieldSpecified;
			}
			set
			{
				this.status_TimestampFieldSpecified = value;
				this.RaisePropertyChanged("Status_TimestampSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Applicant_SourceObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Referred_By_Worker_Reference
		{
			get
			{
				return this.referred_By_Worker_ReferenceField;
			}
			set
			{
				this.referred_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Referred_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Processmaintained_RoleObjectType Added_By_Worker_Reference
		{
			get
			{
				return this.added_By_Worker_ReferenceField;
			}
			set
			{
				this.added_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Added_By_Worker_Reference");
			}
		}

		[XmlElement("Personal_Information_Data", Order = 10)]
		public Application_Personal_Information_DataType Item
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

		[XmlElement(Order = 11)]
		public Person_Biographic_and_Demographic_Information_DataType Global_Personal_Information_Data
		{
			get
			{
				return this.global_Personal_Information_DataField;
			}
			set
			{
				this.global_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Global_Personal_Information_Data");
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
