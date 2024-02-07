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
	public class Launch_Integration_Event_ResponseType : INotifyPropertyChanged
	{
		private Integration_EventType integration_EventField;

		private Launch_Integration_Event_DataType launch_Integration_Event_DataField;

		private Exception_DataType[] application_Instance_ExceptionsField;

		private bool debug_ModeField;

		private bool debug_ModeFieldSpecified;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Launch_Integration_Event_DataType Launch_Integration_Event_Data
		{
			get
			{
				return this.launch_Integration_Event_DataField;
			}
			set
			{
				this.launch_Integration_Event_DataField = value;
				this.RaisePropertyChanged("Launch_Integration_Event_Data");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false)]
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Debug_Mode
		{
			get
			{
				return this.debug_ModeField;
			}
			set
			{
				this.debug_ModeField = value;
				this.RaisePropertyChanged("Debug_Mode");
			}
		}

		[XmlIgnore]
		public bool Debug_ModeSpecified
		{
			get
			{
				return this.debug_ModeFieldSpecified;
			}
			set
			{
				this.debug_ModeFieldSpecified = value;
				this.RaisePropertyChanged("Debug_ModeSpecified");
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
