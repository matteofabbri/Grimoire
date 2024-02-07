using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Profile_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_ReferenceField;

		private bool include_ReferenceFieldSpecified;

		private bool include_Job_Profile_Basic_DataField;

		private bool include_Job_Profile_Basic_DataFieldSpecified;

		private bool include_Job_Classification_DataField;

		private bool include_Job_Classification_DataFieldSpecified;

		private bool include_Job_Profile_Pay_Rate_DataField;

		private bool include_Job_Profile_Pay_Rate_DataFieldSpecified;

		private bool include_Job_Profile_Exempt_DataField;

		private bool include_Job_Profile_Exempt_DataFieldSpecified;

		private bool include_Workers_Compensation_DataField;

		private bool include_Workers_Compensation_DataFieldSpecified;

		private bool include_Responsibility_QualificationsField;

		private bool include_Responsibility_QualificationsFieldSpecified;

		private bool include_Work_Experience_QualificationsField;

		private bool include_Work_Experience_QualificationsFieldSpecified;

		private bool include_Education_QualificationsField;

		private bool include_Education_QualificationsFieldSpecified;

		private bool include_Language_QualificationsField;

		private bool include_Language_QualificationsFieldSpecified;

		private bool include_Competency_QualificationsField;

		private bool include_Competency_QualificationsFieldSpecified;

		private bool include_Certification_QualificationsField;

		private bool include_Certification_QualificationsFieldSpecified;

		private bool include_Certification_Reference_OnlyField;

		private bool include_Certification_Reference_OnlyFieldSpecified;

		private bool include_Training_QualificationsField;

		private bool include_Training_QualificationsFieldSpecified;

		private bool include_Job_Profile_Compensation_DataField;

		private bool include_Job_Profile_Compensation_DataFieldSpecified;

		private bool include_Skill_QualificationsField;

		private bool include_Skill_QualificationsFieldSpecified;

		private bool include_QuestionnairesField;

		private bool include_QuestionnairesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Reference
		{
			get
			{
				return this.include_ReferenceField;
			}
			set
			{
				this.include_ReferenceField = value;
				this.RaisePropertyChanged("Include_Reference");
			}
		}

		[XmlIgnore]
		public bool Include_ReferenceSpecified
		{
			get
			{
				return this.include_ReferenceFieldSpecified;
			}
			set
			{
				this.include_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("Include_ReferenceSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_Job_Profile_Basic_Data
		{
			get
			{
				return this.include_Job_Profile_Basic_DataField;
			}
			set
			{
				this.include_Job_Profile_Basic_DataField = value;
				this.RaisePropertyChanged("Include_Job_Profile_Basic_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Profile_Basic_DataSpecified
		{
			get
			{
				return this.include_Job_Profile_Basic_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Profile_Basic_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Profile_Basic_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Job_Classification_Data
		{
			get
			{
				return this.include_Job_Classification_DataField;
			}
			set
			{
				this.include_Job_Classification_DataField = value;
				this.RaisePropertyChanged("Include_Job_Classification_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Classification_DataSpecified
		{
			get
			{
				return this.include_Job_Classification_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Classification_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Classification_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Job_Profile_Pay_Rate_Data
		{
			get
			{
				return this.include_Job_Profile_Pay_Rate_DataField;
			}
			set
			{
				this.include_Job_Profile_Pay_Rate_DataField = value;
				this.RaisePropertyChanged("Include_Job_Profile_Pay_Rate_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Profile_Pay_Rate_DataSpecified
		{
			get
			{
				return this.include_Job_Profile_Pay_Rate_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Profile_Pay_Rate_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Profile_Pay_Rate_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Job_Profile_Exempt_Data
		{
			get
			{
				return this.include_Job_Profile_Exempt_DataField;
			}
			set
			{
				this.include_Job_Profile_Exempt_DataField = value;
				this.RaisePropertyChanged("Include_Job_Profile_Exempt_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Profile_Exempt_DataSpecified
		{
			get
			{
				return this.include_Job_Profile_Exempt_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Profile_Exempt_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Profile_Exempt_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_Workers_Compensation_Data
		{
			get
			{
				return this.include_Workers_Compensation_DataField;
			}
			set
			{
				this.include_Workers_Compensation_DataField = value;
				this.RaisePropertyChanged("Include_Workers_Compensation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Workers_Compensation_DataSpecified
		{
			get
			{
				return this.include_Workers_Compensation_DataFieldSpecified;
			}
			set
			{
				this.include_Workers_Compensation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Workers_Compensation_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_Responsibility_Qualifications
		{
			get
			{
				return this.include_Responsibility_QualificationsField;
			}
			set
			{
				this.include_Responsibility_QualificationsField = value;
				this.RaisePropertyChanged("Include_Responsibility_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Responsibility_QualificationsSpecified
		{
			get
			{
				return this.include_Responsibility_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Responsibility_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Responsibility_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_Work_Experience_Qualifications
		{
			get
			{
				return this.include_Work_Experience_QualificationsField;
			}
			set
			{
				this.include_Work_Experience_QualificationsField = value;
				this.RaisePropertyChanged("Include_Work_Experience_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Work_Experience_QualificationsSpecified
		{
			get
			{
				return this.include_Work_Experience_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Work_Experience_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Work_Experience_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Education_Qualifications
		{
			get
			{
				return this.include_Education_QualificationsField;
			}
			set
			{
				this.include_Education_QualificationsField = value;
				this.RaisePropertyChanged("Include_Education_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Education_QualificationsSpecified
		{
			get
			{
				return this.include_Education_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Education_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Education_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Include_Language_Qualifications
		{
			get
			{
				return this.include_Language_QualificationsField;
			}
			set
			{
				this.include_Language_QualificationsField = value;
				this.RaisePropertyChanged("Include_Language_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Language_QualificationsSpecified
		{
			get
			{
				return this.include_Language_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Language_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Language_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Include_Competency_Qualifications
		{
			get
			{
				return this.include_Competency_QualificationsField;
			}
			set
			{
				this.include_Competency_QualificationsField = value;
				this.RaisePropertyChanged("Include_Competency_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Competency_QualificationsSpecified
		{
			get
			{
				return this.include_Competency_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Competency_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Competency_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Include_Certification_Qualifications
		{
			get
			{
				return this.include_Certification_QualificationsField;
			}
			set
			{
				this.include_Certification_QualificationsField = value;
				this.RaisePropertyChanged("Include_Certification_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Certification_QualificationsSpecified
		{
			get
			{
				return this.include_Certification_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Certification_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Certification_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Include_Certification_Reference_Only
		{
			get
			{
				return this.include_Certification_Reference_OnlyField;
			}
			set
			{
				this.include_Certification_Reference_OnlyField = value;
				this.RaisePropertyChanged("Include_Certification_Reference_Only");
			}
		}

		[XmlIgnore]
		public bool Include_Certification_Reference_OnlySpecified
		{
			get
			{
				return this.include_Certification_Reference_OnlyFieldSpecified;
			}
			set
			{
				this.include_Certification_Reference_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Include_Certification_Reference_OnlySpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Include_Training_Qualifications
		{
			get
			{
				return this.include_Training_QualificationsField;
			}
			set
			{
				this.include_Training_QualificationsField = value;
				this.RaisePropertyChanged("Include_Training_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Training_QualificationsSpecified
		{
			get
			{
				return this.include_Training_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Training_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Training_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Include_Job_Profile_Compensation_Data
		{
			get
			{
				return this.include_Job_Profile_Compensation_DataField;
			}
			set
			{
				this.include_Job_Profile_Compensation_DataField = value;
				this.RaisePropertyChanged("Include_Job_Profile_Compensation_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Profile_Compensation_DataSpecified
		{
			get
			{
				return this.include_Job_Profile_Compensation_DataFieldSpecified;
			}
			set
			{
				this.include_Job_Profile_Compensation_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Profile_Compensation_DataSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Include_Skill_Qualifications
		{
			get
			{
				return this.include_Skill_QualificationsField;
			}
			set
			{
				this.include_Skill_QualificationsField = value;
				this.RaisePropertyChanged("Include_Skill_Qualifications");
			}
		}

		[XmlIgnore]
		public bool Include_Skill_QualificationsSpecified
		{
			get
			{
				return this.include_Skill_QualificationsFieldSpecified;
			}
			set
			{
				this.include_Skill_QualificationsFieldSpecified = value;
				this.RaisePropertyChanged("Include_Skill_QualificationsSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Include_Questionnaires
		{
			get
			{
				return this.include_QuestionnairesField;
			}
			set
			{
				this.include_QuestionnairesField = value;
				this.RaisePropertyChanged("Include_Questionnaires");
			}
		}

		[XmlIgnore]
		public bool Include_QuestionnairesSpecified
		{
			get
			{
				return this.include_QuestionnairesFieldSpecified;
			}
			set
			{
				this.include_QuestionnairesFieldSpecified = value;
				this.RaisePropertyChanged("Include_QuestionnairesSpecified");
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
