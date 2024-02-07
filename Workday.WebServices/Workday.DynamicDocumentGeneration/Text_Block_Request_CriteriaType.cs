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
	public class Text_Block_Request_CriteriaType : INotifyPropertyChanged
	{
		private Text_Block_CategoryObjectType text_Block_Category_ReferenceField;

		private string text_Block_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Text_Block_CategoryObjectType Text_Block_Category_Reference
		{
			get
			{
				return this.text_Block_Category_ReferenceField;
			}
			set
			{
				this.text_Block_Category_ReferenceField = value;
				this.RaisePropertyChanged("Text_Block_Category_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Text_Block_Name
		{
			get
			{
				return this.text_Block_NameField;
			}
			set
			{
				this.text_Block_NameField = value;
				this.RaisePropertyChanged("Text_Block_Name");
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
