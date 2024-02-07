using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Notification
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Event_DataType : INotifyPropertyChanged
	{
		private Transaction_LogObjectType event_ReferenceField;

		private string event_NameField;

		private string notification_TriggerField;

		private DateTime event_Completion_DateField;

		private DateTime event_Effective_DateField;

		private bool event_Effective_DateFieldSpecified;

		private string tenant_NameField;

		private string system_IDField;

		private Event_TargetObjectType[] transaction_Target_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Transaction_LogObjectType Event_Reference
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
		public string Event_Name
		{
			get
			{
				return this.event_NameField;
			}
			set
			{
				this.event_NameField = value;
				this.RaisePropertyChanged("Event_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Notification_Trigger
		{
			get
			{
				return this.notification_TriggerField;
			}
			set
			{
				this.notification_TriggerField = value;
				this.RaisePropertyChanged("Notification_Trigger");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Event_Completion_Date
		{
			get
			{
				return this.event_Completion_DateField;
			}
			set
			{
				this.event_Completion_DateField = value;
				this.RaisePropertyChanged("Event_Completion_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(Order = 5)]
		public string Tenant_Name
		{
			get
			{
				return this.tenant_NameField;
			}
			set
			{
				this.tenant_NameField = value;
				this.RaisePropertyChanged("Tenant_Name");
			}
		}

		[XmlElement(Order = 6)]
		public string System_ID
		{
			get
			{
				return this.system_IDField;
			}
			set
			{
				this.system_IDField = value;
				this.RaisePropertyChanged("System_ID");
			}
		}

		[XmlElement("Transaction_Target_Reference", Order = 7)]
		public Event_TargetObjectType[] Transaction_Target_Reference
		{
			get
			{
				return this.transaction_Target_ReferenceField;
			}
			set
			{
				this.transaction_Target_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Target_Reference");
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
