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
	public class Candidate_DataType : INotifyPropertyChanged
	{
		private string candidate_IDField;

		private ApplicantObjectType preHire_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private Candidate_Name_DataType name_DataField;

		private Candidate_Contact_DataType contact_DataField;

		private Candidate_Social_Media_Account_DataType[] social_Media_Account_DataField;

		private Candidate_Status_DataType status_DataField;

		private Job_Application_DataType[] job_Application_DataField;

		private Recruiting_Prospect_DataType prospect_DataField;

		private Candidate_Identification_DataType candidate_Identification_DataField;

		private User_LanguageObjectType language_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Candidate_ID
		{
			get
			{
				return this.candidate_IDField;
			}
			set
			{
				this.candidate_IDField = value;
				this.RaisePropertyChanged("Candidate_ID");
			}
		}

		[XmlElement("Pre-Hire_Reference", Order = 1)]
		public ApplicantObjectType PreHire_Reference
		{
			get
			{
				return this.preHire_ReferenceField;
			}
			set
			{
				this.preHire_ReferenceField = value;
				this.RaisePropertyChanged("PreHire_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Candidate_Name_DataType Name_Data
		{
			get
			{
				return this.name_DataField;
			}
			set
			{
				this.name_DataField = value;
				this.RaisePropertyChanged("Name_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Candidate_Contact_DataType Contact_Data
		{
			get
			{
				return this.contact_DataField;
			}
			set
			{
				this.contact_DataField = value;
				this.RaisePropertyChanged("Contact_Data");
			}
		}

		[XmlElement("Social_Media_Account_Data", Order = 5)]
		public Candidate_Social_Media_Account_DataType[] Social_Media_Account_Data
		{
			get
			{
				return this.social_Media_Account_DataField;
			}
			set
			{
				this.social_Media_Account_DataField = value;
				this.RaisePropertyChanged("Social_Media_Account_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Candidate_Status_DataType Status_Data
		{
			get
			{
				return this.status_DataField;
			}
			set
			{
				this.status_DataField = value;
				this.RaisePropertyChanged("Status_Data");
			}
		}

		[XmlElement("Job_Application_Data", Order = 7)]
		public Job_Application_DataType[] Job_Application_Data
		{
			get
			{
				return this.job_Application_DataField;
			}
			set
			{
				this.job_Application_DataField = value;
				this.RaisePropertyChanged("Job_Application_Data");
			}
		}

		[XmlElement(Order = 8)]
		public Recruiting_Prospect_DataType Prospect_Data
		{
			get
			{
				return this.prospect_DataField;
			}
			set
			{
				this.prospect_DataField = value;
				this.RaisePropertyChanged("Prospect_Data");
			}
		}

		[XmlElement(Order = 9)]
		public Candidate_Identification_DataType Candidate_Identification_Data
		{
			get
			{
				return this.candidate_Identification_DataField;
			}
			set
			{
				this.candidate_Identification_DataField = value;
				this.RaisePropertyChanged("Candidate_Identification_Data");
			}
		}

		[XmlElement(Order = 10)]
		public User_LanguageObjectType Language_Reference
		{
			get
			{
				return this.language_ReferenceField;
			}
			set
			{
				this.language_ReferenceField = value;
				this.RaisePropertyChanged("Language_Reference");
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
