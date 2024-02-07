using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Marketing_Activity_Definition_Attachment_DataType : INotifyPropertyChanged
	{
		private Marketing_Activity_Definition_AttachmentObjectType marketing_Activity_Definition_Attachment_ReferenceField;

		private Attachment_WWS_DataType[] attachment_WWS_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Marketing_Activity_Definition_AttachmentObjectType Marketing_Activity_Definition_Attachment_Reference
		{
			get
			{
				return this.marketing_Activity_Definition_Attachment_ReferenceField;
			}
			set
			{
				this.marketing_Activity_Definition_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Marketing_Activity_Definition_Attachment_Reference");
			}
		}

		[XmlElement("Attachment_WWS_Data", Order = 1)]
		public Attachment_WWS_DataType[] Attachment_WWS_Data
		{
			get
			{
				return this.attachment_WWS_DataField;
			}
			set
			{
				this.attachment_WWS_DataField = value;
				this.RaisePropertyChanged("Attachment_WWS_Data");
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
