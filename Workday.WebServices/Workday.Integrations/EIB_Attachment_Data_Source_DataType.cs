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
	public class EIB_Attachment_Data_Source_DataType : INotifyPropertyChanged
	{
		private bool load_From_AttachmentField;

		private object itemField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Load_From_Attachment
		{
			get
			{
				return this.load_From_AttachmentField;
			}
			set
			{
				this.load_From_AttachmentField = value;
				this.RaisePropertyChanged("Load_From_Attachment");
			}
		}

		[XmlElement("Custom_Object_Reference", typeof(Custom_ObjectObjectType), Order = 1), XmlElement("Web_Service_Operation_Reference", typeof(Web_Service_OperationObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
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
