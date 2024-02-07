using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Document_Attachment_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_Document_AttachmentObjectType student_Document_Attachment_ReferenceField;

		private Attachment_WWS_DataType attachment_WWS_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Document_AttachmentObjectType Student_Document_Attachment_Reference
		{
			get
			{
				return this.student_Document_Attachment_ReferenceField;
			}
			set
			{
				this.student_Document_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Document_Attachment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Attachment_WWS_DataType Attachment_WWS_Data
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
