using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Event_Record_Process_View_WWSType : INotifyPropertyChanged
	{
		private Action_EventObjectType process_ReferenceField;

		private Workflow_StepType workflow_StepField;

		private Event_Record_ActionObjectType status_ReferenceField;

		private DateTime completed_DateField;

		private bool completed_DateFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Workflow_Process_ParticipantObjectType[] workflow_Process_Participant_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Action_EventObjectType Process_Reference
		{
			get
			{
				return this.process_ReferenceField;
			}
			set
			{
				this.process_ReferenceField = value;
				this.RaisePropertyChanged("Process_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Workflow_StepType Workflow_Step
		{
			get
			{
				return this.workflow_StepField;
			}
			set
			{
				this.workflow_StepField = value;
				this.RaisePropertyChanged("Workflow_Step");
			}
		}

		[XmlElement(Order = 2)]
		public Event_Record_ActionObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Completed_Date
		{
			get
			{
				return this.completed_DateField;
			}
			set
			{
				this.completed_DateField = value;
				this.RaisePropertyChanged("Completed_Date");
			}
		}

		[XmlIgnore]
		public bool Completed_DateSpecified
		{
			get
			{
				return this.completed_DateFieldSpecified;
			}
			set
			{
				this.completed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completed_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement("Workflow_Process_Participant_Reference", Order = 5)]
		public Workflow_Process_ParticipantObjectType[] Workflow_Process_Participant_Reference
		{
			get
			{
				return this.workflow_Process_Participant_ReferenceField;
			}
			set
			{
				this.workflow_Process_Participant_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_Process_Participant_Reference");
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
