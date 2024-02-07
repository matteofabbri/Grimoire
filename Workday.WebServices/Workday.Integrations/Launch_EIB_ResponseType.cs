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
	public class Launch_EIB_ResponseType : INotifyPropertyChanged
	{
		private Exception_DataType[] application_Instance_ExceptionsField;

		private Integration_EventType integration_EventField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false)]
		public Exception_DataType[] Application_Instance_Exceptions
		{
			get
			{
				return this.application_Instance_ExceptionsField;
			}
			set
			{
				this.application_Instance_ExceptionsField = value;
				this.RaisePropertyChanged("Application_Instance_Exceptions");
			}
		}

		[XmlElement(Order = 1)]
		public Integration_EventType Integration_Event
		{
			get
			{
				return this.integration_EventField;
			}
			set
			{
				this.integration_EventField = value;
				this.RaisePropertyChanged("Integration_Event");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
