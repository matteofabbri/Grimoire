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
	public class Recruiting_Agency_Candidate_Submission_DataType : INotifyPropertyChanged
	{
		private Recruiting_Agency_SiteObjectType agency_ReferenceField;

		private Recruiting_Agency_UserObjectType agency_User_ReferenceField;

		private Job_PostingObjectType job_Posting_ReferenceField;

		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private Candidate_Name_DataType candidate_Name_DataField;

		private Candidate_Contact_DataType candidate_Contact_DataField;

		private Candidate_Social_Media_Account_DataType[] candidate_Social_Media_Account_DataField;

		private Candidate_Resume_DataType candidate_Resume_DataField;

		private Recruiting_Agency_Candidate_Attachment_DataType[] candidate_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Recruiting_Agency_SiteObjectType Agency_Reference
		{
			get
			{
				return this.agency_ReferenceField;
			}
			set
			{
				this.agency_ReferenceField = value;
				this.RaisePropertyChanged("Agency_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Recruiting_Agency_UserObjectType Agency_User_Reference
		{
			get
			{
				return this.agency_User_ReferenceField;
			}
			set
			{
				this.agency_User_ReferenceField = value;
				this.RaisePropertyChanged("Agency_User_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Job_PostingObjectType Job_Posting_Reference
		{
			get
			{
				return this.job_Posting_ReferenceField;
			}
			set
			{
				this.job_Posting_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Job_Requisition_EnabledObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Candidate_Name_DataType Candidate_Name_Data
		{
			get
			{
				return this.candidate_Name_DataField;
			}
			set
			{
				this.candidate_Name_DataField = value;
				this.RaisePropertyChanged("Candidate_Name_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Candidate_Contact_DataType Candidate_Contact_Data
		{
			get
			{
				return this.candidate_Contact_DataField;
			}
			set
			{
				this.candidate_Contact_DataField = value;
				this.RaisePropertyChanged("Candidate_Contact_Data");
			}
		}

		[XmlElement("Candidate_Social_Media_Account_Data", Order = 6)]
		public Candidate_Social_Media_Account_DataType[] Candidate_Social_Media_Account_Data
		{
			get
			{
				return this.candidate_Social_Media_Account_DataField;
			}
			set
			{
				this.candidate_Social_Media_Account_DataField = value;
				this.RaisePropertyChanged("Candidate_Social_Media_Account_Data");
			}
		}

		[XmlElement(Order = 7)]
		public Candidate_Resume_DataType Candidate_Resume_Data
		{
			get
			{
				return this.candidate_Resume_DataField;
			}
			set
			{
				this.candidate_Resume_DataField = value;
				this.RaisePropertyChanged("Candidate_Resume_Data");
			}
		}

		[XmlElement("Candidate_Attachment_Data", Order = 8)]
		public Recruiting_Agency_Candidate_Attachment_DataType[] Candidate_Attachment_Data
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
