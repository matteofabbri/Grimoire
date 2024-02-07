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
	public class Integration_Event_Reporting_Details_DataType : INotifyPropertyChanged
	{
		private Background_Process_Runtime_StatusObjectType background_Process_Instance_Status_ReferenceField;

		private EventObjectType parent_Event_ReferenceField;

		private Integration_Message_Detail_DataType[] background_Process_Message_DataField;

		private Integration_Repository_DocumentType[] output_Document_DataField;

		private Repository_DocumentObjectType consolidated_Report_ReferenceField;

		private Repository_DocumentObjectType[] log_File_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Process_Runtime_StatusObjectType Background_Process_Instance_Status_Reference
		{
			get
			{
				return this.background_Process_Instance_Status_ReferenceField;
			}
			set
			{
				this.background_Process_Instance_Status_ReferenceField = value;
				this.RaisePropertyChanged("Background_Process_Instance_Status_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Background_Process_Message_Data", Order = 2)]
		public Integration_Message_Detail_DataType[] Background_Process_Message_Data
		{
			get
			{
				return this.background_Process_Message_DataField;
			}
			set
			{
				this.background_Process_Message_DataField = value;
				this.RaisePropertyChanged("Background_Process_Message_Data");
			}
		}

		[XmlElement("Output_Document_Data", Order = 3)]
		public Integration_Repository_DocumentType[] Output_Document_Data
		{
			get
			{
				return this.output_Document_DataField;
			}
			set
			{
				this.output_Document_DataField = value;
				this.RaisePropertyChanged("Output_Document_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Repository_DocumentObjectType Consolidated_Report_Reference
		{
			get
			{
				return this.consolidated_Report_ReferenceField;
			}
			set
			{
				this.consolidated_Report_ReferenceField = value;
				this.RaisePropertyChanged("Consolidated_Report_Reference");
			}
		}

		[XmlElement("Log_File_Reference", Order = 5)]
		public Repository_DocumentObjectType[] Log_File_Reference
		{
			get
			{
				return this.log_File_ReferenceField;
			}
			set
			{
				this.log_File_ReferenceField = value;
				this.RaisePropertyChanged("Log_File_Reference");
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
