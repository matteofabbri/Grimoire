using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkdayConnect
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Message_Template_Request_ReferencesType : INotifyPropertyChanged
	{
		private Message_TemplateObjectType[] message_Template_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Message_Template_Reference", Order = 0)]
		public Message_TemplateObjectType[] Message_Template_Reference
		{
			get
			{
				return this.message_Template_ReferenceField;
			}
			set
			{
				this.message_Template_ReferenceField = value;
				this.RaisePropertyChanged("Message_Template_Reference");
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
