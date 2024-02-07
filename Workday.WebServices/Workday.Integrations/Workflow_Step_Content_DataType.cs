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
	public class Workflow_Step_Content_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private Workflow_Step_TypeObjectType workflow_Step_Type_ReferenceField;

		private Referenced_TaskObjectType task_ReferenceField;

		private ChecklistObjectType checklist_ReferenceField;

		private Workflow_Step_Report_Background_Process_Definition_DataType report_Background_Process_Definition_DataField;

		private Workflow_Report_Group_Step_Background_Future_Process_Definition_DataType report_Group_Background_Process_Definition_DataField;

		private Partitioned_Background_ProcessObjectType partitioned_Background_Process_ReferenceField;

		private To_DoObjectType to_Do_ReferenceField;

		private Event_ServiceObjectType event_Service_ReferenceField;

		private Integration_Background_Process_Definition_DataType integration_Background_Process_Definition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Workflow_Step_TypeObjectType Workflow_Step_Type_Reference
		{
			get
			{
				return this.workflow_Step_Type_ReferenceField;
			}
			set
			{
				this.workflow_Step_Type_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_Step_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Referenced_TaskObjectType Task_Reference
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

		[XmlElement(Order = 3)]
		public ChecklistObjectType Checklist_Reference
		{
			get
			{
				return this.checklist_ReferenceField;
			}
			set
			{
				this.checklist_ReferenceField = value;
				this.RaisePropertyChanged("Checklist_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Workflow_Step_Report_Background_Process_Definition_DataType Report_Background_Process_Definition_Data
		{
			get
			{
				return this.report_Background_Process_Definition_DataField;
			}
			set
			{
				this.report_Background_Process_Definition_DataField = value;
				this.RaisePropertyChanged("Report_Background_Process_Definition_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Workflow_Report_Group_Step_Background_Future_Process_Definition_DataType Report_Group_Background_Process_Definition_Data
		{
			get
			{
				return this.report_Group_Background_Process_Definition_DataField;
			}
			set
			{
				this.report_Group_Background_Process_Definition_DataField = value;
				this.RaisePropertyChanged("Report_Group_Background_Process_Definition_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Partitioned_Background_ProcessObjectType Partitioned_Background_Process_Reference
		{
			get
			{
				return this.partitioned_Background_Process_ReferenceField;
			}
			set
			{
				this.partitioned_Background_Process_ReferenceField = value;
				this.RaisePropertyChanged("Partitioned_Background_Process_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public To_DoObjectType To_Do_Reference
		{
			get
			{
				return this.to_Do_ReferenceField;
			}
			set
			{
				this.to_Do_ReferenceField = value;
				this.RaisePropertyChanged("To_Do_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Event_ServiceObjectType Event_Service_Reference
		{
			get
			{
				return this.event_Service_ReferenceField;
			}
			set
			{
				this.event_Service_ReferenceField = value;
				this.RaisePropertyChanged("Event_Service_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Integration_Background_Process_Definition_DataType Integration_Background_Process_Definition_Data
		{
			get
			{
				return this.integration_Background_Process_Definition_DataField;
			}
			set
			{
				this.integration_Background_Process_Definition_DataField = value;
				this.RaisePropertyChanged("Integration_Background_Process_Definition_Data");
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
