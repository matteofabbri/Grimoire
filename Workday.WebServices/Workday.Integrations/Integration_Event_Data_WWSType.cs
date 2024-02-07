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
	public class Integration_Event_Data_WWSType : INotifyPropertyChanged
	{
		private Integration_SystemObjectType integration_System_ReferenceField;

		private string process_DescriptionField;

		private DateTime initiated_DateTimeField;

		private bool initiated_DateTimeFieldSpecified;

		private string integration_Response_MessageField;

		private DateTime completed_DateTimeField;

		private bool completed_DateTimeFieldSpecified;

		private IntegratableObjectType[] integration_Event_Member_ReferenceField;

		private System_UserObjectType initiated_By_System_Account_ReferenceField;

		private decimal percent_CompleteField;

		private bool percent_CompleteFieldSpecified;

		private Integration_Runtime_Parameter_DataType[] integration_Runtime_Parameter_DataField;

		private Integration_Service_Generated_Sequence_DataType[] integration_Service_Generated_Sequence_DataField;

		private Integration_Enterprise_Event_Records_DataType[] integration_Enterprise_Event_Records_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Process_Description
		{
			get
			{
				return this.process_DescriptionField;
			}
			set
			{
				this.process_DescriptionField = value;
				this.RaisePropertyChanged("Process_Description");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Initiated_DateTime
		{
			get
			{
				return this.initiated_DateTimeField;
			}
			set
			{
				this.initiated_DateTimeField = value;
				this.RaisePropertyChanged("Initiated_DateTime");
			}
		}

		[XmlIgnore]
		public bool Initiated_DateTimeSpecified
		{
			get
			{
				return this.initiated_DateTimeFieldSpecified;
			}
			set
			{
				this.initiated_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Initiated_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Integration_Response_Message
		{
			get
			{
				return this.integration_Response_MessageField;
			}
			set
			{
				this.integration_Response_MessageField = value;
				this.RaisePropertyChanged("Integration_Response_Message");
			}
		}

		[XmlElement(Order = 4)]
		public DateTime Completed_DateTime
		{
			get
			{
				return this.completed_DateTimeField;
			}
			set
			{
				this.completed_DateTimeField = value;
				this.RaisePropertyChanged("Completed_DateTime");
			}
		}

		[XmlIgnore]
		public bool Completed_DateTimeSpecified
		{
			get
			{
				return this.completed_DateTimeFieldSpecified;
			}
			set
			{
				this.completed_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Completed_DateTimeSpecified");
			}
		}

		[XmlElement("Integration_Event_Member_Reference", Order = 5)]
		public IntegratableObjectType[] Integration_Event_Member_Reference
		{
			get
			{
				return this.integration_Event_Member_ReferenceField;
			}
			set
			{
				this.integration_Event_Member_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Event_Member_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public System_UserObjectType Initiated_By_System_Account_Reference
		{
			get
			{
				return this.initiated_By_System_Account_ReferenceField;
			}
			set
			{
				this.initiated_By_System_Account_ReferenceField = value;
				this.RaisePropertyChanged("Initiated_By_System_Account_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Percent_Complete
		{
			get
			{
				return this.percent_CompleteField;
			}
			set
			{
				this.percent_CompleteField = value;
				this.RaisePropertyChanged("Percent_Complete");
			}
		}

		[XmlIgnore]
		public bool Percent_CompleteSpecified
		{
			get
			{
				return this.percent_CompleteFieldSpecified;
			}
			set
			{
				this.percent_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Percent_CompleteSpecified");
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

		[XmlElement("Integration_Enterprise_Event_Records_Data", Order = 10)]
		public Integration_Enterprise_Event_Records_DataType[] Integration_Enterprise_Event_Records_Data
		{
			get
			{
				return this.integration_Enterprise_Event_Records_DataField;
			}
			set
			{
				this.integration_Enterprise_Event_Records_DataField = value;
				this.RaisePropertyChanged("Integration_Enterprise_Event_Records_Data");
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
