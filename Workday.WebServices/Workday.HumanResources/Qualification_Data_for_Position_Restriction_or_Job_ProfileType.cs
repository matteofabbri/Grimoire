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
	public class Qualification_Data_for_Position_Restriction_or_Job_ProfileType : INotifyPropertyChanged
	{
		private Responsibility_Qualification_ReplacementType responsibility_Qualification_ReplacementField;

		private Work_Experience_Qualification_ReplacementType work_Experience_Qualification_ReplacementField;

		private Education_Qualification_ReplacementType education_Qualification_ReplacementField;

		private Language_Qualification_ReplacementType language_Qualification_ReplacementField;

		private Competency_Qualification_ReplacementType competency_Qualification_ReplacementField;

		private Certification_Qualification_ReplacementType certification_Qualification_ReplacementField;

		private Training_Qualification_ReplacementType training_Qualification_ReplacementField;

		private Skill_Qualification_ReplacementType skill_Qualification_ReplacementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Responsibility_Qualification_ReplacementType Responsibility_Qualification_Replacement
		{
			get
			{
				return this.responsibility_Qualification_ReplacementField;
			}
			set
			{
				this.responsibility_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Responsibility_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 1)]
		public Work_Experience_Qualification_ReplacementType Work_Experience_Qualification_Replacement
		{
			get
			{
				return this.work_Experience_Qualification_ReplacementField;
			}
			set
			{
				this.work_Experience_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Work_Experience_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 2)]
		public Education_Qualification_ReplacementType Education_Qualification_Replacement
		{
			get
			{
				return this.education_Qualification_ReplacementField;
			}
			set
			{
				this.education_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Education_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 3)]
		public Language_Qualification_ReplacementType Language_Qualification_Replacement
		{
			get
			{
				return this.language_Qualification_ReplacementField;
			}
			set
			{
				this.language_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Language_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 4)]
		public Competency_Qualification_ReplacementType Competency_Qualification_Replacement
		{
			get
			{
				return this.competency_Qualification_ReplacementField;
			}
			set
			{
				this.competency_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Competency_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 5)]
		public Certification_Qualification_ReplacementType Certification_Qualification_Replacement
		{
			get
			{
				return this.certification_Qualification_ReplacementField;
			}
			set
			{
				this.certification_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Certification_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 6)]
		public Training_Qualification_ReplacementType Training_Qualification_Replacement
		{
			get
			{
				return this.training_Qualification_ReplacementField;
			}
			set
			{
				this.training_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Training_Qualification_Replacement");
			}
		}

		[XmlElement(Order = 7)]
		public Skill_Qualification_ReplacementType Skill_Qualification_Replacement
		{
			get
			{
				return this.skill_Qualification_ReplacementField;
			}
			set
			{
				this.skill_Qualification_ReplacementField = value;
				this.RaisePropertyChanged("Skill_Qualification_Replacement");
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
