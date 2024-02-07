using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Person_Qualification_DataType : INotifyPropertyChanged
	{
		private Job_HistoryType[] external_Job_HistoryField;

		private Competency_Achievement_Data__v10_Type[] competencyField;

		private Certification_AchievementType[] certificationField;

		private TrainingType[] trainingField;

		private Award_and_ActivityType[] award_and_ActivityField;

		private Professional_Affiliation_SkillType[] organization_MembershipField;

		private EducationType[] educationField;

		private Work_Experience_DataType[] work_ExperienceField;

		private Language_Achievement_DataType[] languageField;

		private Internal_Project_ExperienceType[] internal_Project_ExperienceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("External_Job_History", Order = 0)]
		public Job_HistoryType[] External_Job_History
		{
			get
			{
				return this.external_Job_HistoryField;
			}
			set
			{
				this.external_Job_HistoryField = value;
				this.RaisePropertyChanged("External_Job_History");
			}
		}

		[XmlElement("Competency", Order = 1)]
		public Competency_Achievement_Data__v10_Type[] Competency
		{
			get
			{
				return this.competencyField;
			}
			set
			{
				this.competencyField = value;
				this.RaisePropertyChanged("Competency");
			}
		}

		[XmlElement("Certification", Order = 2)]
		public Certification_AchievementType[] Certification
		{
			get
			{
				return this.certificationField;
			}
			set
			{
				this.certificationField = value;
				this.RaisePropertyChanged("Certification");
			}
		}

		[XmlElement("Training", Order = 3)]
		public TrainingType[] Training
		{
			get
			{
				return this.trainingField;
			}
			set
			{
				this.trainingField = value;
				this.RaisePropertyChanged("Training");
			}
		}

		[XmlElement("Award_and_Activity", Order = 4)]
		public Award_and_ActivityType[] Award_and_Activity
		{
			get
			{
				return this.award_and_ActivityField;
			}
			set
			{
				this.award_and_ActivityField = value;
				this.RaisePropertyChanged("Award_and_Activity");
			}
		}

		[XmlElement("Organization_Membership", Order = 5)]
		public Professional_Affiliation_SkillType[] Organization_Membership
		{
			get
			{
				return this.organization_MembershipField;
			}
			set
			{
				this.organization_MembershipField = value;
				this.RaisePropertyChanged("Organization_Membership");
			}
		}

		[XmlElement("Education", Order = 6)]
		public EducationType[] Education
		{
			get
			{
				return this.educationField;
			}
			set
			{
				this.educationField = value;
				this.RaisePropertyChanged("Education");
			}
		}

		[XmlElement("Work_Experience", Order = 7)]
		public Work_Experience_DataType[] Work_Experience
		{
			get
			{
				return this.work_ExperienceField;
			}
			set
			{
				this.work_ExperienceField = value;
				this.RaisePropertyChanged("Work_Experience");
			}
		}

		[XmlElement("Language", Order = 8)]
		public Language_Achievement_DataType[] Language
		{
			get
			{
				return this.languageField;
			}
			set
			{
				this.languageField = value;
				this.RaisePropertyChanged("Language");
			}
		}

		[XmlElement("Internal_Project_Experience", Order = 9)]
		public Internal_Project_ExperienceType[] Internal_Project_Experience
		{
			get
			{
				return this.internal_Project_ExperienceField;
			}
			set
			{
				this.internal_Project_ExperienceField = value;
				this.RaisePropertyChanged("Internal_Project_Experience");
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
