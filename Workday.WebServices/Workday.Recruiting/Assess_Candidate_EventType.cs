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
	public class Assess_Candidate_EventType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType event_ReferenceField;

		private Job_ApplicationObjectType job_Application_ReferenceField;

		private CandidateObjectType candidate_ReferenceField;

		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private Unique_IdentifierObjectType job_Application_Event_ReferenceField;

		private Recruiting_Assessment_DataType candidate_Assessment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public CandidateObjectType Candidate_Reference
		{
			get
			{
				return this.candidate_ReferenceField;
			}
			set
			{
				this.candidate_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Unique_IdentifierObjectType Job_Application_Event_Reference
		{
			get
			{
				return this.job_Application_Event_ReferenceField;
			}
			set
			{
				this.job_Application_Event_ReferenceField = value;
				this.RaisePropertyChanged("Job_Application_Event_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Recruiting_Assessment_DataType Candidate_Assessment_Data
		{
			get
			{
				return this.candidate_Assessment_DataField;
			}
			set
			{
				this.candidate_Assessment_DataField = value;
				this.RaisePropertyChanged("Candidate_Assessment_Data");
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
