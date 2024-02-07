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
	public class Web_Service_Data_Source_DataType : INotifyPropertyChanged
	{
		private Web_Service_Operation_Reference_DataType web_Service_Operation_Reference_DataField;

		private Web_Service_API_VersionObjectType version_ReferenceField;

		private string request_XMLField;

		private Launch_Parameter_DataType[] launch_Parameter_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Web_Service_Operation_Reference_DataType Web_Service_Operation_Reference_Data
		{
			get
			{
				return this.web_Service_Operation_Reference_DataField;
			}
			set
			{
				this.web_Service_Operation_Reference_DataField = value;
				this.RaisePropertyChanged("Web_Service_Operation_Reference_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Web_Service_API_VersionObjectType Version_Reference
		{
			get
			{
				return this.version_ReferenceField;
			}
			set
			{
				this.version_ReferenceField = value;
				this.RaisePropertyChanged("Version_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Request_XML
		{
			get
			{
				return this.request_XMLField;
			}
			set
			{
				this.request_XMLField = value;
				this.RaisePropertyChanged("Request_XML");
			}
		}

		[XmlElement("Launch_Parameter_Data", Order = 3)]
		public Launch_Parameter_DataType[] Launch_Parameter_Data
		{
			get
			{
				return this.launch_Parameter_DataField;
			}
			set
			{
				this.launch_Parameter_DataField = value;
				this.RaisePropertyChanged("Launch_Parameter_Data");
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
