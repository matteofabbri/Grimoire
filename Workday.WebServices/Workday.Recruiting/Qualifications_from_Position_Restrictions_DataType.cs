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
	public class Qualifications_from_Position_Restrictions_DataType : INotifyPropertyChanged
	{
		private Competency_Profile_for_JobType[] competency_DataField;

		private Certification_Profile_for_JobType[] certification_DataField;

		private Education_Profile_for_JobType[] education_DataField;

		private Language_Profile_for_JobType[] language_DataField;

		private Responsibility_Profile_for_JobType[] responsibility_DataField;

		private Training_Profile_for_JobType[] training_DataField;

		private Work_Experience_for_JobType[] work_Experience_DataField;

		private Skill_Profile_for_JobType[] skill_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Competency_Data", Order = 0)]
		public Competency_Profile_for_JobType[] Competency_Data
		{
			get
			{
				return this.competency_DataField;
			}
			set
			{
				this.competency_DataField = value;
				this.RaisePropertyChanged("Competency_Data");
			}
		}

		[XmlElement("Certification_Data", Order = 1)]
		public Certification_Profile_for_JobType[] Certification_Data
		{
			get
			{
				return this.certification_DataField;
			}
			set
			{
				this.certification_DataField = value;
				this.RaisePropertyChanged("Certification_Data");
			}
		}

		[XmlElement("Education_Data", Order = 2)]
		public Education_Profile_for_JobType[] Education_Data
		{
			get
			{
				return this.education_DataField;
			}
			set
			{
				this.education_DataField = value;
				this.RaisePropertyChanged("Education_Data");
			}
		}

		[XmlElement("Language_Data", Order = 3)]
		public Language_Profile_for_JobType[] Language_Data
		{
			get
			{
				return this.language_DataField;
			}
			set
			{
				this.language_DataField = value;
				this.RaisePropertyChanged("Language_Data");
			}
		}

		[XmlElement("Responsibility_Data", Order = 4)]
		public Responsibility_Profile_for_JobType[] Responsibility_Data
		{
			get
			{
				return this.responsibility_DataField;
			}
			set
			{
				this.responsibility_DataField = value;
				this.RaisePropertyChanged("Responsibility_Data");
			}
		}

		[XmlElement("Training_Data", Order = 5)]
		public Training_Profile_for_JobType[] Training_Data
		{
			get
			{
				return this.training_DataField;
			}
			set
			{
				this.training_DataField = value;
				this.RaisePropertyChanged("Training_Data");
			}
		}

		[XmlElement("Work_Experience_Data", Order = 6)]
		public Work_Experience_for_JobType[] Work_Experience_Data
		{
			get
			{
				return this.work_Experience_DataField;
			}
			set
			{
				this.work_Experience_DataField = value;
				this.RaisePropertyChanged("Work_Experience_Data");
			}
		}

		[XmlElement("Skill_Data", Order = 7)]
		public Skill_Profile_for_JobType[] Skill_Data
		{
			get
			{
				return this.skill_DataField;
			}
			set
			{
				this.skill_DataField = value;
				this.RaisePropertyChanged("Skill_Data");
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
