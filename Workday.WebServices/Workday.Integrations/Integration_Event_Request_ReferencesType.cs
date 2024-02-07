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
	public class Integration_Event_Request_ReferencesType : INotifyPropertyChanged
	{
		private Integration_ESB_Invocation__Abstract_ObjectType[] integration_Event_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Integration_Event_Reference", Order = 0)]
		public Integration_ESB_Invocation__Abstract_ObjectType[] Integration_Event_Reference
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
