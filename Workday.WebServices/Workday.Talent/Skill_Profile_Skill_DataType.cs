using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Skill_Profile_Skill_DataType : INotifyPropertyChanged
	{
		private Certification_Replacement_Data_Without_SpecialtiesType[] certification_DataField;

		private Competency_Qualification_ReplacementType[] competency_DataField;

		private Skill_Qualification_ReplacementType[] skill_DataField;

		private Work_Experience_Qualification_ReplacementType[] work_Experience_DataField;

		private Training_Qualification_ReplacementType[] training_DataField;

		private Language_Qualification_ReplacementType[] language_DataField;

		private Education_Qualification_ReplacementType[] education_DataField;

		private Responsibility_Qualification_ReplacementType[] responsibility_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Certification_Data", Order = 0)]
		public Certification_Replacement_Data_Without_SpecialtiesType[] Certification_Data
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

		[XmlElement("Competency_Data", Order = 1)]
		public Competency_Qualification_ReplacementType[] Competency_Data
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

		[XmlElement("Skill_Data", Order = 2)]
		public Skill_Qualification_ReplacementType[] Skill_Data
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

		[XmlElement("Work_Experience_Data", Order = 3)]
		public Work_Experience_Qualification_ReplacementType[] Work_Experience_Data
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

		[XmlElement("Training_Data", Order = 4)]
		public Training_Qualification_ReplacementType[] Training_Data
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

		[XmlElement("Language_Data", Order = 5)]
		public Language_Qualification_ReplacementType[] Language_Data
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

		[XmlElement("Education_Data", Order = 6)]
		public Education_Qualification_ReplacementType[] Education_Data
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

		[XmlElement("Responsibility_Data", Order = 7)]
		public Responsibility_Qualification_ReplacementType[] Responsibility_Data
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
