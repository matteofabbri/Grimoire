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
	public class Candidate_Request_CriteriaType : INotifyPropertyChanged
	{
		private string first_NameField;

		private string last_NameField;

		private string candidate_Email_AddressField;

		private ApplicantObjectType[] preHire_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

		private Job_Requisition_EnabledObjectType[] job_Requisition_ReferenceField;

		private Recruiting_Stage__Workday_Owned_ObjectType[] recruiting_Stage_ReferenceField;

		private Applicant_SourceObjectType[] applicant_Source_ReferenceField;

		private DateTime applied_FromField;

		private bool applied_FromFieldSpecified;

		private DateTime applied_ThroughField;

		private bool applied_ThroughFieldSpecified;

		private bool internal_Workers_OnlyField;

		private bool internal_Workers_OnlyFieldSpecified;

		private DateTime created_FromField;

		private bool created_FromFieldSpecified;

		private DateTime created_ThroughField;

		private bool created_ThroughFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string First_Name
		{
			get
			{
				return this.first_NameField;
			}
			set
			{
				this.first_NameField = value;
				this.RaisePropertyChanged("First_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Last_Name
		{
			get
			{
				return this.last_NameField;
			}
			set
			{
				this.last_NameField = value;
				this.RaisePropertyChanged("Last_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Candidate_Email_Address
		{
			get
			{
				return this.candidate_Email_AddressField;
			}
			set
			{
				this.candidate_Email_AddressField = value;
				this.RaisePropertyChanged("Candidate_Email_Address");
			}
		}

		[XmlElement("Pre-Hire_Reference", Order = 3)]
		public ApplicantObjectType[] PreHire_Reference
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

		[XmlElement("Worker_Reference", Order = 4)]
		public WorkerObjectType[] Worker_Reference
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

		[XmlElement("Job_Requisition_Reference", Order = 5)]
		public Job_Requisition_EnabledObjectType[] Job_Requisition_Reference
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

		[XmlElement("Recruiting_Stage_Reference", Order = 6)]
		public Recruiting_Stage__Workday_Owned_ObjectType[] Recruiting_Stage_Reference
		{
			get
			{
				return this.recruiting_Stage_ReferenceField;
			}
			set
			{
				this.recruiting_Stage_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Stage_Reference");
			}
		}

		[XmlElement("Applicant_Source_Reference", Order = 7)]
		public Applicant_SourceObjectType[] Applicant_Source_Reference
		{
			get
			{
				return this.applicant_Source_ReferenceField;
			}
			set
			{
				this.applicant_Source_ReferenceField = value;
				this.RaisePropertyChanged("Applicant_Source_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public DateTime Applied_From
		{
			get
			{
				return this.applied_FromField;
			}
			set
			{
				this.applied_FromField = value;
				this.RaisePropertyChanged("Applied_From");
			}
		}

		[XmlIgnore]
		public bool Applied_FromSpecified
		{
			get
			{
				return this.applied_FromFieldSpecified;
			}
			set
			{
				this.applied_FromFieldSpecified = value;
				this.RaisePropertyChanged("Applied_FromSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public DateTime Applied_Through
		{
			get
			{
				return this.applied_ThroughField;
			}
			set
			{
				this.applied_ThroughField = value;
				this.RaisePropertyChanged("Applied_Through");
			}
		}

		[XmlIgnore]
		public bool Applied_ThroughSpecified
		{
			get
			{
				return this.applied_ThroughFieldSpecified;
			}
			set
			{
				this.applied_ThroughFieldSpecified = value;
				this.RaisePropertyChanged("Applied_ThroughSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Internal_Workers_Only
		{
			get
			{
				return this.internal_Workers_OnlyField;
			}
			set
			{
				this.internal_Workers_OnlyField = value;
				this.RaisePropertyChanged("Internal_Workers_Only");
			}
		}

		[XmlIgnore]
		public bool Internal_Workers_OnlySpecified
		{
			get
			{
				return this.internal_Workers_OnlyFieldSpecified;
			}
			set
			{
				this.internal_Workers_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Internal_Workers_OnlySpecified");
			}
		}

		[XmlElement(Order = 11)]
		public DateTime Created_From
		{
			get
			{
				return this.created_FromField;
			}
			set
			{
				this.created_FromField = value;
				this.RaisePropertyChanged("Created_From");
			}
		}

		[XmlIgnore]
		public bool Created_FromSpecified
		{
			get
			{
				return this.created_FromFieldSpecified;
			}
			set
			{
				this.created_FromFieldSpecified = value;
				this.RaisePropertyChanged("Created_FromSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public DateTime Created_Through
		{
			get
			{
				return this.created_ThroughField;
			}
			set
			{
				this.created_ThroughField = value;
				this.RaisePropertyChanged("Created_Through");
			}
		}

		[XmlIgnore]
		public bool Created_ThroughSpecified
		{
			get
			{
				return this.created_ThroughFieldSpecified;
			}
			set
			{
				this.created_ThroughFieldSpecified = value;
				this.RaisePropertyChanged("Created_ThroughSpecified");
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
