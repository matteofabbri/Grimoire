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
	public class Awaiting_Task_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType task_ReferenceField;

		private CommentObjectType[] comment_ReferenceField;

		private Event_Record_ActionObjectType task_Status_ReferenceField;

		private DateTime assignment_DateField;

		private bool assignment_DateFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Unique_IdentifierObjectType[] awaiting_Person_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Task_Reference
		{
			get
			{
				return this.task_ReferenceField;
			}
			set
			{
				this.task_ReferenceField = value;
				this.RaisePropertyChanged("Task_Reference");
			}
		}

		[XmlElement("Comment_Reference", Order = 1)]
		public CommentObjectType[] Comment_Reference
		{
			get
			{
				return this.comment_ReferenceField;
			}
			set
			{
				this.comment_ReferenceField = value;
				this.RaisePropertyChanged("Comment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Event_Record_ActionObjectType Task_Status_Reference
		{
			get
			{
				return this.task_Status_ReferenceField;
			}
			set
			{
				this.task_Status_ReferenceField = value;
				this.RaisePropertyChanged("Task_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Assignment_Date
		{
			get
			{
				return this.assignment_DateField;
			}
			set
			{
				this.assignment_DateField = value;
				this.RaisePropertyChanged("Assignment_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_DateSpecified
		{
			get
			{
				return this.assignment_DateFieldSpecified;
			}
			set
			{
				this.assignment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_DateSpecified");
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

		[XmlElement("Awaiting_Person_Reference", Order = 5)]
		public Unique_IdentifierObjectType[] Awaiting_Person_Reference
		{
			get
			{
				return this.awaiting_Person_ReferenceField;
			}
			set
			{
				this.awaiting_Person_ReferenceField = value;
				this.RaisePropertyChanged("Awaiting_Person_Reference");
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
