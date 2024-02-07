using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Integration_Service_Data_WWSType : INotifyPropertyChanged
	{
		private Integration_ServiceObjectType integration_Service_ReferenceField;

		private Integration_Transaction_Log_Configuration_DataType integration_Transaction_Log_Service_DataField;

		private Integration_Sequence_Generator_Configuration_DataType[] integration_Sequence_Generator_Service_DataField;

		private External_FieldObjectType[] integration_Data_Change_Service_DataField;

		private Integration_Field_Override_Configuration_DataType integration_Field_Override_Service_DataField;

		private Integration_Data_Initialization_Override_Configuration_DataType integration_Data_Initialization_Override_Configuration_DataField;

		private Integration_Field_Attributes_Field_Configuration_DataType[] integration_Field_Attributes_Service_DataField;

		private Integration_Delivery_Configuration_DataType integration_Delivery_Configuration_DataField;

		private Integration_Transport_Protocol_Assignment_DataType[] job_Integration_Delivery_Configuration_DataField;

		private Integration_Transformation_Data_WWSType[] job_Integration_Transformation_Configuration_DataField;

		private Integration_Retrieval_Configuration_DataType integration_Retrieval_Configuration_DataField;

		private Job_Integration_Retrieval_Protocol_DataType[] job_Integration_Retrieval_Configuration_DataField;

		private Attachment_Data_WWSType[] integration_Attachment_Service_DataField;

		private Integration_Report_Field_Configuration_DataType[] integration_Report_Service_Configuration_DataField;

		private Integration_Custom_Object_Alias_Configuration_DataType[] integration_Custom_Object_Configuration_DataField;

		private Integration_Connector_Configuration_DataType integration_Connector_Configuration_DataField;

		private Integration_Field_Attributes_Field_Configuration_DataType[] integration_Data_Initialization_Service_DataField;

		private string wIDField;

		private bool enabledField;

		private bool enabledFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Integration_ServiceObjectType Integration_Service_Reference
		{
			get
			{
				return this.integration_Service_ReferenceField;
			}
			set
			{
				this.integration_Service_ReferenceField = value;
				this.RaisePropertyChanged("Integration_Service_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_Transaction_Log_Configuration_DataType Integration_Transaction_Log_Service_Data
		{
			get
			{
				return this.integration_Transaction_Log_Service_DataField;
			}
			set
			{
				this.integration_Transaction_Log_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Transaction_Log_Service_Data");
			}
		}

		[XmlElement("Integration_Sequence_Generator_Service_Data", Order = 2)]
		public Integration_Sequence_Generator_Configuration_DataType[] Integration_Sequence_Generator_Service_Data
		{
			get
			{
				return this.integration_Sequence_Generator_Service_DataField;
			}
			set
			{
				this.integration_Sequence_Generator_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Sequence_Generator_Service_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("External_Field_Reference", IsNullable = false)]
		public External_FieldObjectType[] Integration_Data_Change_Service_Data
		{
			get
			{
				return this.integration_Data_Change_Service_DataField;
			}
			set
			{
				this.integration_Data_Change_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Data_Change_Service_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Integration_Field_Override_Configuration_DataType Integration_Field_Override_Service_Data
		{
			get
			{
				return this.integration_Field_Override_Service_DataField;
			}
			set
			{
				this.integration_Field_Override_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Service_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Integration_Data_Initialization_Override_Configuration_DataType Integration_Data_Initialization_Override_Configuration_Data
		{
			get
			{
				return this.integration_Data_Initialization_Override_Configuration_DataField;
			}
			set
			{
				this.integration_Data_Initialization_Override_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Data_Initialization_Override_Configuration_Data");
			}
		}

		[XmlArray(Order = 6), XmlArrayItem("Integration_Field_Attributes_Field_Configuration_Data", IsNullable = false)]
		public Integration_Field_Attributes_Field_Configuration_DataType[] Integration_Field_Attributes_Service_Data
		{
			get
			{
				return this.integration_Field_Attributes_Service_DataField;
			}
			set
			{
				this.integration_Field_Attributes_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Attributes_Service_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Integration_Delivery_Configuration_DataType Integration_Delivery_Configuration_Data
		{
			get
			{
				return this.integration_Delivery_Configuration_DataField;
			}
			set
			{
				this.integration_Delivery_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Delivery_Configuration_Data");
			}
		}

		[XmlArray(Order = 8), XmlArrayItem("Integration_Transport_Protocol_Assignment_Data", IsNullable = false)]
		public Integration_Transport_Protocol_Assignment_DataType[] Job_Integration_Delivery_Configuration_Data
		{
			get
			{
				return this.job_Integration_Delivery_Configuration_DataField;
			}
			set
			{
				this.job_Integration_Delivery_Configuration_DataField = value;
				this.RaisePropertyChanged("Job_Integration_Delivery_Configuration_Data");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Integration_Transformation_Data", IsNullable = false)]
		public Integration_Transformation_Data_WWSType[] Job_Integration_Transformation_Configuration_Data
		{
			get
			{
				return this.job_Integration_Transformation_Configuration_DataField;
			}
			set
			{
				this.job_Integration_Transformation_Configuration_DataField = value;
				this.RaisePropertyChanged("Job_Integration_Transformation_Configuration_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Integration_Retrieval_Configuration_DataType Integration_Retrieval_Configuration_Data
		{
			get
			{
				return this.integration_Retrieval_Configuration_DataField;
			}
			set
			{
				this.integration_Retrieval_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Retrieval_Configuration_Data");
			}
		}

		[XmlArray(Order = 11), XmlArrayItem("Integration_Data_Source_Data", IsNullable = false)]
		public Job_Integration_Retrieval_Protocol_DataType[] Job_Integration_Retrieval_Configuration_Data
		{
			get
			{
				return this.job_Integration_Retrieval_Configuration_DataField;
			}
			set
			{
				this.job_Integration_Retrieval_Configuration_DataField = value;
				this.RaisePropertyChanged("Job_Integration_Retrieval_Configuration_Data");
			}
		}

		[XmlArray(Order = 12), XmlArrayItem("Attachment_Data", IsNullable = false)]
		public Attachment_Data_WWSType[] Integration_Attachment_Service_Data
		{
			get
			{
				return this.integration_Attachment_Service_DataField;
			}
			set
			{
				this.integration_Attachment_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Attachment_Service_Data");
			}
		}

		[XmlArray(Order = 13), XmlArrayItem("Integration_Report_Field_Configuration_Data", IsNullable = false)]
		public Integration_Report_Field_Configuration_DataType[] Integration_Report_Service_Configuration_Data
		{
			get
			{
				return this.integration_Report_Service_Configuration_DataField;
			}
			set
			{
				this.integration_Report_Service_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Report_Service_Configuration_Data");
			}
		}

		[XmlArray(Order = 14), XmlArrayItem("Integration_Custom_Object_Alias_Configuration_Data", IsNullable = false)]
		public Integration_Custom_Object_Alias_Configuration_DataType[] Integration_Custom_Object_Configuration_Data
		{
			get
			{
				return this.integration_Custom_Object_Configuration_DataField;
			}
			set
			{
				this.integration_Custom_Object_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Custom_Object_Configuration_Data");
			}
		}

		[XmlElement(Order = 15)]
		public Integration_Connector_Configuration_DataType Integration_Connector_Configuration_Data
		{
			get
			{
				return this.integration_Connector_Configuration_DataField;
			}
			set
			{
				this.integration_Connector_Configuration_DataField = value;
				this.RaisePropertyChanged("Integration_Connector_Configuration_Data");
			}
		}

		[XmlArray(Order = 16), XmlArrayItem("Integration_Field_Attributes_Field_Configuration_Data", IsNullable = false)]
		public Integration_Field_Attributes_Field_Configuration_DataType[] Integration_Data_Initialization_Service_Data
		{
			get
			{
				return this.integration_Data_Initialization_Service_DataField;
			}
			set
			{
				this.integration_Data_Initialization_Service_DataField = value;
				this.RaisePropertyChanged("Integration_Data_Initialization_Service_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string WID
		{
			get
			{
				return this.wIDField;
			}
			set
			{
				this.wIDField = value;
				this.RaisePropertyChanged("WID");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Enabled
		{
			get
			{
				return this.enabledField;
			}
			set
			{
				this.enabledField = value;
				this.RaisePropertyChanged("Enabled");
			}
		}

		[XmlIgnore]
		public bool EnabledSpecified
		{
			get
			{
				return this.enabledFieldSpecified;
			}
			set
			{
				this.enabledFieldSpecified = value;
				this.RaisePropertyChanged("EnabledSpecified");
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
