using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Candidate_Attachment_ResponseType : INotifyPropertyChanged
	{
		private CandidateObjectType candidate_ReferenceField;

		private Candidate_AttachmentObjectType[] attachment_ReferenceField;

		private Job_Application_Attachment_ResponseType[] job_Application_Attachment_DataField;

		private Attachment_WWS_DataType[] prospect_Resume_Attachment_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CandidateObjectType Candidate_Reference
		{
			get
			{
				return this.candidate_ReferenceField;
			}
			set
			{
				this.candidate_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Reference");
			}
		}

		[XmlElement("Attachment_Reference", Order = 1)]
		public Candidate_AttachmentObjectType[] Attachment_Reference
		{
			get
			{
				return this.attachment_ReferenceField;
			}
			set
			{
				this.attachment_ReferenceField = value;
				this.RaisePropertyChanged("Attachment_Reference");
			}
		}

		[XmlElement("Job_Application_Attachment_Data", Order = 2)]
		public Job_Application_Attachment_ResponseType[] Job_Application_Attachment_Data
		{
			get
			{
				return this.job_Application_Attachment_DataField;
			}
			set
			{
				this.job_Application_Attachment_DataField = value;
				this.RaisePropertyChanged("Job_Application_Attachment_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Resume_Attachments", IsNullable = false)]
		public Attachment_WWS_DataType[] Prospect_Resume_Attachment_Data
		{
			get
			{
				return this.prospect_Resume_Attachment_DataField;
			}
			set
			{
				this.prospect_Resume_Attachment_DataField = value;
				this.RaisePropertyChanged("Prospect_Resume_Attachment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
