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
	public class Recruiting_Prospect_DataType : INotifyPropertyChanged
	{
		private bool prospectField;

		private bool prospectFieldSpecified;

		private bool confidentialField;

		private bool confidentialFieldSpecified;

		private bool referral_Consent_GivenField;

		private bool referral_Consent_GivenFieldSpecified;

		private Management_LevelObjectType level_ReferenceField;

		private Recruiting_Prospect_StatusObjectType prospect_Status_ReferenceField;

		private Recruiting_Prospect_TypeObjectType prospect_Type_ReferenceField;

		private Applicant_SourceObjectType source_ReferenceField;

		private WorkerObjectType referred_By_Worker_ReferenceField;

		private Processmaintained_RoleObjectType added_By_Worker_ReferenceField;

		private Attachment_WWS_DataType[] prospect_Attachment_DataField;

		private Candidate_Resume_DataType resume_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Prospect
		{
			get
			{
				return this.prospectField;
			}
			set
			{
				this.prospectField = value;
				this.RaisePropertyChanged("Prospect");
			}
		}

		[XmlIgnore]
		public bool ProspectSpecified
		{
			get
			{
				return this.prospectFieldSpecified;
			}
			set
			{
				this.prospectFieldSpecified = value;
				this.RaisePropertyChanged("ProspectSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Confidential
		{
			get
			{
				return this.confidentialField;
			}
			set
			{
				this.confidentialField = value;
				this.RaisePropertyChanged("Confidential");
			}
		}

		[XmlIgnore]
		public bool ConfidentialSpecified
		{
			get
			{
				return this.confidentialFieldSpecified;
			}
			set
			{
				this.confidentialFieldSpecified = value;
				this.RaisePropertyChanged("ConfidentialSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Referral_Consent_Given
		{
			get
			{
				return this.referral_Consent_GivenField;
			}
			set
			{
				this.referral_Consent_GivenField = value;
				this.RaisePropertyChanged("Referral_Consent_Given");
			}
		}

		[XmlIgnore]
		public bool Referral_Consent_GivenSpecified
		{
			get
			{
				return this.referral_Consent_GivenFieldSpecified;
			}
			set
			{
				this.referral_Consent_GivenFieldSpecified = value;
				this.RaisePropertyChanged("Referral_Consent_GivenSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Management_LevelObjectType Level_Reference
		{
			get
			{
				return this.level_ReferenceField;
			}
			set
			{
				this.level_ReferenceField = value;
				this.RaisePropertyChanged("Level_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Recruiting_Prospect_StatusObjectType Prospect_Status_Reference
		{
			get
			{
				return this.prospect_Status_ReferenceField;
			}
			set
			{
				this.prospect_Status_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Recruiting_Prospect_TypeObjectType Prospect_Type_Reference
		{
			get
			{
				return this.prospect_Type_ReferenceField;
			}
			set
			{
				this.prospect_Type_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Applicant_SourceObjectType Source_Reference
		{
			get
			{
				return this.source_ReferenceField;
			}
			set
			{
				this.source_ReferenceField = value;
				this.RaisePropertyChanged("Source_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Referred_By_Worker_Reference
		{
			get
			{
				return this.referred_By_Worker_ReferenceField;
			}
			set
			{
				this.referred_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Referred_By_Worker_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Processmaintained_RoleObjectType Added_By_Worker_Reference
		{
			get
			{
				return this.added_By_Worker_ReferenceField;
			}
			set
			{
				this.added_By_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Added_By_Worker_Reference");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Resume_Attachments", IsNullable = false)]
		public Attachment_WWS_DataType[] Prospect_Attachment_Data
		{
			get
			{
				return this.prospect_Attachment_DataField;
			}
			set
			{
				this.prospect_Attachment_DataField = value;
				this.RaisePropertyChanged("Prospect_Attachment_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Candidate_Resume_DataType Resume_Data
		{
			get
			{
				return this.resume_DataField;
			}
			set
			{
				this.resume_DataField = value;
				this.RaisePropertyChanged("Resume_Data");
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
