using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ExternalIntegrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(Launch_Integration_Event_DataRootType)), XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Launch_Integration_Event_DataType : INotifyPropertyChanged
	{
		private Integration_ESB_Invocation__Abstract_ObjectType integration_Event_ReferenceField;

		private Integration_SystemObjectType integration_System_ReferenceField;

		private string document_IDField;

		private string event_Initialization_Document_IDField;

		private Integration_TemplateObjectType integration_Template_ReferenceField;

		private DateTime sent_OnField;

		private bool sent_OnFieldSpecified;

		private System_UserObjectType system_User_ReferenceField;

		private Integration_Event__Abstract_ObjectType resend_from_Integration_Event_ReferenceField;

		private Integration_Runtime_Parameter_DataType[] integration_Runtime_Parameter_DataField;

		private Integration_Service_Generated_Sequence_DataType[] integration_Service_Generated_Sequence_DataField;

		private EventObjectType parent_Event_ReferenceField;

		private Integration_OwnerObjectType integration_Owner_ReferenceField;

		private bool wIN_IntegrationField;

		private bool wIN_IntegrationFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_ESB_Invocation__Abstract_ObjectType Integration_Event_Reference
		{
			get
			{
				return this.integration_Event_ReferenceField;
			}
			set
			{
				this.integration_Event_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Event_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_SystemObjectType Integration_System_Reference
		{
			get
			{
				return this.integration_System_ReferenceField;
			}
			set
			{
				this.integration_System_ReferenceField = value;
				this.RaisePropertyChanged("Integration_System_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Document_ID
		{
			get
			{
				return this.document_IDField;
			}
			set
			{
				this.document_IDField = value;
				this.RaisePropertyChanged("Document_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Event_Initialization_Document_ID
		{
			get
			{
				return this.event_Initialization_Document_IDField;
			}
			set
			{
				this.event_Initialization_Document_IDField = value;
				this.RaisePropertyChanged("Event_Initialization_Document_ID");
			}
		}

		[XmlElement(Order = 4)]
		public Integration_TemplateObjectType Integration_Template_Reference
		{
			get
			{
				return this.integration_Template_ReferenceField;
			}
			set
			{
				this.integration_Template_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Template_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Sent_On
		{
			get
			{
				return this.sent_OnField;
			}
			set
			{
				this.sent_OnField = value;
				this.RaisePropertyChanged("Sent_On");
			}
		}

		[XmlIgnore]
		public bool Sent_OnSpecified
		{
			get
			{
				return this.sent_OnFieldSpecified;
			}
			set
			{
				this.sent_OnFieldSpecified = value;
				this.RaisePropertyChanged("Sent_OnSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public System_UserObjectType System_User_Reference
		{
			get
			{
				return this.system_User_ReferenceField;
			}
			set
			{
				this.system_User_ReferenceField = value;
				this.RaisePropertyChanged("System_User_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Integration_Event__Abstract_ObjectType Resend_from_Integration_Event_Reference
		{
			get
			{
				return this.resend_from_Integration_Event_ReferenceField;
			}
			set
			{
				this.resend_from_Integration_Event_ReferenceField = value;
				this.RaisePropertyChanged("Resend_from_Integration_Event_Reference");
			}
		}

		[XmlElement("Integration_Runtime_Parameter_Data", Order = 8)]
		public Integration_Runtime_Parameter_DataType[] Integration_Runtime_Parameter_Data
		{
			get
			{
				return this.integration_Runtime_Parameter_DataField;
			}
			set
			{
				this.integration_Runtime_Parameter_DataField = value;
				this.RaisePropertyChanged("Integration_Runtime_Parameter_Data");
			}
		}

		[XmlElement("Integration_Service_Generated_Sequence_Data", Order = 9)]
		public Integration_Service_Generated_Sequence_DataType[] Integration_Service_Generated_Sequence_Data
		{
			get
			{
				return this.integration_Service_Generated_Sequence_DataField;
			}
			set
			{
				this.integration_Service_Generated_Sequence_DataField = value;
				this.RaisePropertyChanged("Integration_Service_Generated_Sequence_Data");
			}
		}

		[XmlElement(Order = 10)]
		public EventObjectType Parent_Event_Reference
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

		[XmlElement(Order = 11)]
		public Integration_OwnerObjectType Integration_Owner_Reference
		{
			get
			{
				return this.integration_Owner_ReferenceField;
			}
			set
			{
				this.integration_Owner_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Owner_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool WIN_Integration
		{
			get
			{
				return this.wIN_IntegrationField;
			}
			set
			{
				this.wIN_IntegrationField = value;
				this.RaisePropertyChanged("WIN_Integration");
			}
		}

		[XmlIgnore]
		public bool WIN_IntegrationSpecified
		{
			get
			{
				return this.wIN_IntegrationFieldSpecified;
			}
			set
			{
				this.wIN_IntegrationFieldSpecified = value;
				this.RaisePropertyChanged("WIN_IntegrationSpecified");
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
