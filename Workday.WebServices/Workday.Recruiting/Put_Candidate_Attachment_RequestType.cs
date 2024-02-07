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
	public class Put_Candidate_Attachment_RequestType : INotifyPropertyChanged
	{
		private CandidateObjectType candidate_ReferenceField;

		private Attachment_WWS_DataType[] prospect_Resume_Attachments_DataField;

		private Candidate_Attachment_DataType candidate_Attachment_DataField;

		private Job_Application_Attachment_DataType[] job_Application_Attachment_DataField;

		private bool add_OnlyField;

		private bool add_OnlyFieldSpecified;

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

		[XmlArray(Order = 1), XmlArrayItem("Resume_Attachments", IsNullable = false)]
		public Attachment_WWS_DataType[] Prospect_Resume_Attachments_Data
		{
			get
			{
				return this.prospect_Resume_Attachments_DataField;
			}
			set
			{
				this.prospect_Resume_Attachments_DataField = value;
				this.RaisePropertyChanged("Prospect_Resume_Attachments_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Candidate_Attachment_DataType Candidate_Attachment_Data
		{
			get
			{
				return this.candidate_Attachment_DataField;
			}
			set
			{
				this.candidate_Attachment_DataField = value;
				this.RaisePropertyChanged("Candidate_Attachment_Data");
			}
		}

		[XmlElement("Job_Application_Attachment_Data", Order = 3)]
		public Job_Application_Attachment_DataType[] Job_Application_Attachment_Data
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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Add_Only
		{
			get
			{
				return this.add_OnlyField;
			}
			set
			{
				this.add_OnlyField = value;
				this.RaisePropertyChanged("Add_Only");
			}
		}

		[XmlIgnore]
		public bool Add_OnlySpecified
		{
			get
			{
				return this.add_OnlyFieldSpecified;
			}
			set
			{
				this.add_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Add_OnlySpecified");
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
