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
	public class Student_Transcript_Drag_and_Drop_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_External_Transcript_AttachmentObjectType student_Transcript_Attachment_ReferenceField;

		private Attachment_WWS_DataType[] attachmentsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_Transcript_AttachmentObjectType Student_Transcript_Attachment_Reference
		{
			get
			{
				return this.student_Transcript_Attachment_ReferenceField;
			}
			set
			{
				this.student_Transcript_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Transcript_Attachment_Reference");
			}
		}

		[XmlElement("Attachments", Order = 1)]
		public Attachment_WWS_DataType[] Attachments
		{
			get
			{
				return this.attachmentsField;
			}
			set
			{
				this.attachmentsField = value;
				this.RaisePropertyChanged("Attachments");
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
