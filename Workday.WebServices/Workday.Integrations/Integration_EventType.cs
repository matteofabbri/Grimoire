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
	public class Integration_EventType : INotifyPropertyChanged
	{
		private Integration_ESB_Invocation__Abstract_ObjectType integration_Event_ReferenceField;

		private Integration_Event_Data_WWSType integration_Event_DataField;

		private Integration_Event_Reporting_Details_DataType background_Process_Instance_DataField;

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
		public Integration_Event_Data_WWSType Integration_Event_Data
		{
			get
			{
				return this.integration_Event_DataField;
			}
			set
			{
				this.integration_Event_DataField = value;
				this.RaisePropertyChanged("Integration_Event_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Integration_Event_Reporting_Details_DataType Background_Process_Instance_Data
		{
			get
			{
				return this.background_Process_Instance_DataField;
			}
			set
			{
				this.background_Process_Instance_DataField = value;
				this.RaisePropertyChanged("Background_Process_Instance_Data");
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
