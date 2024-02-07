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
	public class Message_TemplateType : INotifyPropertyChanged
	{
		private Message_TemplateObjectType message_Template_ReferenceField;

		private Message_Template_DataType[] message_Template_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Message_TemplateObjectType Message_Template_Reference
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

		[XmlElement("Message_Template_Data", Order = 1)]
		public Message_Template_DataType[] Message_Template_Data
		{
			get
			{
				return this.message_Template_DataField;
			}
			set
			{
				this.message_Template_DataField = value;
				this.RaisePropertyChanged("Message_Template_Data");
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
