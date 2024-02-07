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
	public class Job_Retrieval_Inbound_Protocol_DataType : INotifyPropertyChanged
	{
		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Attachment_Data_Source_Data", typeof(EIB_Attachment_Data_Source_DataType), Order = 0), XmlElement("Custom_Report_Data_Source_Data", typeof(Report_Background_Future_Process_as_Custom_Report_DataType), Order = 0), XmlElement("External_File_Data_Source", typeof(EIB_External_File_Data_Source_DataType), Order = 0), XmlElement("REST_Endpoint_Data_Source_Data", typeof(REST_Endpoint_Data_Source_DataType), Order = 0), XmlElement("Web_Service_Data_Source_Data", typeof(Web_Service_Data_Source_DataType), Order = 0)]
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
