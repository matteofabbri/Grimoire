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
	public class Text_BlockType : INotifyPropertyChanged
	{
		private Text_BlockObjectType text_Block_ReferenceField;

		private Text_Block_DataType[] text_Block_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Text_BlockObjectType Text_Block_Reference
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

		[XmlElement("Text_Block_Data", Order = 1)]
		public Text_Block_DataType[] Text_Block_Data
		{
			get
			{
				return this.text_Block_DataField;
			}
			set
			{
				this.text_Block_DataField = value;
				this.RaisePropertyChanged("Text_Block_Data");
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
