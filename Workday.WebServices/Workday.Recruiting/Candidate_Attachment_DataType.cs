using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Candidate_Attachment_DataType : INotifyPropertyChanged
	{
		private Candidate_AttachmentObjectType candidate_Attachment_ReferenceField;

		private Attachment_WWS_DataType attachment_DataField;

		private Document_Category__All_ObjectType document_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Candidate_AttachmentObjectType Candidate_Attachment_Reference
		{
			get
			{
				return this.candidate_Attachment_ReferenceField;
			}
			set
			{
				this.candidate_Attachment_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Attachment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Attachment_WWS_DataType Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Document_Category__All_ObjectType Document_Category_Reference
		{
			get
			{
				return this.document_Category_ReferenceField;
			}
			set
			{
				this.document_Category_ReferenceField = value;
				this.RaisePropertyChanged("Document_Category_Reference");
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
