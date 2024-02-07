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
	public class Background_Check_EventType : INotifyPropertyChanged
	{
		private Background_Check_EventObjectType event_ReferenceField;

		private bool recruiting_Sub_ProcessField;

		private bool recruiting_Sub_ProcessFieldSpecified;

		private WorkerObjectType requester_ReferenceField;

		private RoleObjectType recipient_ReferenceField;

		private Job_Requisition_EnabledObjectType requisition_ReferenceField;

		private DateTime submission_DateField;

		private bool submission_DateFieldSpecified;

		private Background_Check_Overall_Status_DataType background_Check_Status_DataField;

		private Unique_IdentifierObjectType workflow_State_ReferenceField;

		private Package_Reference_DataType[] package_Reference_DataField;

		private Test_Reference_DataType[] test_Reference_DataField;

		private Document_Field_Result_DataType[] document_Field_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Check_EventObjectType Event_Reference
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
		public bool Recruiting_Sub_Process
		{
			get
			{
				return this.recruiting_Sub_ProcessField;
			}
			set
			{
				this.recruiting_Sub_ProcessField = value;
				this.RaisePropertyChanged("Recruiting_Sub_Process");
			}
		}

		[XmlIgnore]
		public bool Recruiting_Sub_ProcessSpecified
		{
			get
			{
				return this.recruiting_Sub_ProcessFieldSpecified;
			}
			set
			{
				this.recruiting_Sub_ProcessFieldSpecified = value;
				this.RaisePropertyChanged("Recruiting_Sub_ProcessSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public RoleObjectType Recipient_Reference
		{
			get
			{
				return this.recipient_ReferenceField;
			}
			set
			{
				this.recipient_ReferenceField = value;
				this.RaisePropertyChanged("Recipient_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Job_Requisition_EnabledObjectType Requisition_Reference
		{
			get
			{
				return this.requisition_ReferenceField;
			}
			set
			{
				this.requisition_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Submission_Date
		{
			get
			{
				return this.submission_DateField;
			}
			set
			{
				this.submission_DateField = value;
				this.RaisePropertyChanged("Submission_Date");
			}
		}

		[XmlIgnore]
		public bool Submission_DateSpecified
		{
			get
			{
				return this.submission_DateFieldSpecified;
			}
			set
			{
				this.submission_DateFieldSpecified = value;
				this.RaisePropertyChanged("Submission_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Background_Check_Overall_Status_DataType Background_Check_Status_Data
		{
			get
			{
				return this.background_Check_Status_DataField;
			}
			set
			{
				this.background_Check_Status_DataField = value;
				this.RaisePropertyChanged("Background_Check_Status_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Workflow_State_Reference
		{
			get
			{
				return this.workflow_State_ReferenceField;
			}
			set
			{
				this.workflow_State_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_State_Reference");
			}
		}

		[XmlElement("Package_Reference_Data", Order = 8)]
		public Package_Reference_DataType[] Package_Reference_Data
		{
			get
			{
				return this.package_Reference_DataField;
			}
			set
			{
				this.package_Reference_DataField = value;
				this.RaisePropertyChanged("Package_Reference_Data");
			}
		}

		[XmlElement("Test_Reference_Data", Order = 9)]
		public Test_Reference_DataType[] Test_Reference_Data
		{
			get
			{
				return this.test_Reference_DataField;
			}
			set
			{
				this.test_Reference_DataField = value;
				this.RaisePropertyChanged("Test_Reference_Data");
			}
		}

		[XmlElement("Document_Field_Result_Data", Order = 10)]
		public Document_Field_Result_DataType[] Document_Field_Result_Data
		{
			get
			{
				return this.document_Field_Result_DataField;
			}
			set
			{
				this.document_Field_Result_DataField = value;
				this.RaisePropertyChanged("Document_Field_Result_Data");
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
