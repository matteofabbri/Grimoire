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
	public class Event_Detail_DataType : INotifyPropertyChanged
	{
		private DateTime creation_DateField;

		private bool creation_DateFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private DateTime completed_DateField;

		private bool completed_DateFieldSpecified;

		private Event_Classification_SubcategoryObjectType event_Category_ReferenceField;

		private Unique_IdentifierObjectType event_State_ReferenceField;

		private Event_TargetObjectType event_Target_ReferenceField;

		private Unique_IdentifierObjectType initiating_Person_ReferenceField;

		private Awaiting_Task_DataType[] awaiting_Task_DataField;

		private Event_WWSType[] subEventField;

		private Event_Record_Process_View_WWSType[] process_History_DataField;

		private Event_Remaining_Process_View_WWSType[] remaining_Process_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Creation_Date
		{
			get
			{
				return this.creation_DateField;
			}
			set
			{
				this.creation_DateField = value;
				this.RaisePropertyChanged("Creation_Date");
			}
		}

		[XmlIgnore]
		public bool Creation_DateSpecified
		{
			get
			{
				return this.creation_DateFieldSpecified;
			}
			set
			{
				this.creation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Creation_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Event_Classification_SubcategoryObjectType Event_Category_Reference
		{
			get
			{
				return this.event_Category_ReferenceField;
			}
			set
			{
				this.event_Category_ReferenceField = value;
				this.RaisePropertyChanged("Event_Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Unique_IdentifierObjectType Event_State_Reference
		{
			get
			{
				return this.event_State_ReferenceField;
			}
			set
			{
				this.event_State_ReferenceField = value;
				this.RaisePropertyChanged("Event_State_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Event_TargetObjectType Event_Target_Reference
		{
			get
			{
				return this.event_Target_ReferenceField;
			}
			set
			{
				this.event_Target_ReferenceField = value;
				this.RaisePropertyChanged("Event_Target_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Initiating_Person_Reference
		{
			get
			{
				return this.initiating_Person_ReferenceField;
			}
			set
			{
				this.initiating_Person_ReferenceField = value;
				this.RaisePropertyChanged("Initiating_Person_Reference");
			}
		}

		[XmlElement("Awaiting_Task_Data", Order = 7)]
		public Awaiting_Task_DataType[] Awaiting_Task_Data
		{
			get
			{
				return this.awaiting_Task_DataField;
			}
			set
			{
				this.awaiting_Task_DataField = value;
				this.RaisePropertyChanged("Awaiting_Task_Data");
			}
		}

		[XmlElement("Sub-Event", Order = 8)]
		public Event_WWSType[] SubEvent
		{
			get
			{
				return this.subEventField;
			}
			set
			{
				this.subEventField = value;
				this.RaisePropertyChanged("SubEvent");
			}
		}

		[XmlElement("Process_History_Data", Order = 9)]
		public Event_Record_Process_View_WWSType[] Process_History_Data
		{
			get
			{
				return this.process_History_DataField;
			}
			set
			{
				this.process_History_DataField = value;
				this.RaisePropertyChanged("Process_History_Data");
			}
		}

		[XmlElement("Remaining_Process_Data", Order = 10)]
		public Event_Remaining_Process_View_WWSType[] Remaining_Process_Data
		{
			get
			{
				return this.remaining_Process_DataField;
			}
			set
			{
				this.remaining_Process_DataField = value;
				this.RaisePropertyChanged("Remaining_Process_Data");
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
