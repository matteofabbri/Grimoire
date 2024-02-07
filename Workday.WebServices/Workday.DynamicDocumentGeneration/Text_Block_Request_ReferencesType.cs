using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.DynamicDocumentGeneration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Text_Block_Request_ReferencesType : INotifyPropertyChanged
	{
		private Text_BlockObjectType[] text_Block_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Text_Block_Reference", Order = 0)]
		public Text_BlockObjectType[] Text_Block_Reference
		{
			get
			{
				return this.text_Block_ReferenceField;
			}
			set
			{
				this.text_Block_ReferenceField = value;
				this.RaisePropertyChanged("Text_Block_Reference");
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
