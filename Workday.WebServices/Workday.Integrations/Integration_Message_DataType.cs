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
	public class Integration_Message_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private string message_SummaryField;

		private string message_DetailField;

		private Background_Process_Message_Severity_LevelObjectType severity_Level_ReferenceField;

		private InstanceObjectType[] message_Target_ReferenceField;

		private Integration_Attachment_DataType[] integration_Attachment_DataField;

		private Integration_Repository_Document_DataType[] repository_Document_DataField;

		private bool enqueue_Notification_MessageField;

		private bool enqueue_Notification_MessageFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Integration_Event_Reference", typeof(Integration_ESB_Invocation__Abstract_ObjectType), Order = 0), XmlElement("Integration_System_Reference", typeof(Integration_System__Audited_ObjectType), Order = 0)]
		public object Item
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

		[XmlElement(Order = 1)]
		public string Message_Summary
		{
			get
			{
				return this.message_SummaryField;
			}
			set
			{
				this.message_SummaryField = value;
				this.RaisePropertyChanged("Message_Summary");
			}
		}

		[XmlElement(Order = 2)]
		public string Message_Detail
		{
			get
			{
				return this.message_DetailField;
			}
			set
			{
				this.message_DetailField = value;
				this.RaisePropertyChanged("Message_Detail");
			}
		}

		[XmlElement(Order = 3)]
		public Background_Process_Message_Severity_LevelObjectType Severity_Level_Reference
		{
			get
			{
				return this.severity_Level_ReferenceField;
			}
			set
			{
				this.severity_Level_ReferenceField = value;
				this.RaisePropertyChanged("Severity_Level_Reference");
			}
		}

		[XmlElement("Message_Target_Reference", Order = 4)]
		public InstanceObjectType[] Message_Target_Reference
		{
			get
			{
				return this.message_Target_ReferenceField;
			}
			set
			{
				this.message_Target_ReferenceField = value;
				this.RaisePropertyChanged("Message_Target_Reference");
			}
		}

		[XmlElement("Integration_Attachment_Data", Order = 5)]
		public Integration_Attachment_DataType[] Integration_Attachment_Data
		{
			get
			{
				return this.integration_Attachment_DataField;
			}
			set
			{
				this.integration_Attachment_DataField = value;
				this.RaisePropertyChanged("Integration_Attachment_Data");
			}
		}

		[XmlElement("Repository_Document_Data", Order = 6)]
		public Integration_Repository_Document_DataType[] Repository_Document_Data
		{
			get
			{
				return this.repository_Document_DataField;
			}
			set
			{
				this.repository_Document_DataField = value;
				this.RaisePropertyChanged("Repository_Document_Data");
			}
		}

		[XmlElement(Order = 7)]
		public bool Enqueue_Notification_Message
		{
			get
			{
				return this.enqueue_Notification_MessageField;
			}
			set
			{
				this.enqueue_Notification_MessageField = value;
				this.RaisePropertyChanged("Enqueue_Notification_Message");
			}
		}

		[XmlIgnore]
		public bool Enqueue_Notification_MessageSpecified
		{
			get
			{
				return this.enqueue_Notification_MessageFieldSpecified;
			}
			set
			{
				this.enqueue_Notification_MessageFieldSpecified = value;
				this.RaisePropertyChanged("Enqueue_Notification_MessageSpecified");
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
