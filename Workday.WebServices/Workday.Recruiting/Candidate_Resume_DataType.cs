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
	public class Candidate_Resume_DataType : INotifyPropertyChanged
	{
		private string summaryField;

		private Candidate_Skill_DataType[] skill_DataField;

		private Candidate_Experience_DataType[] experience_DataField;

		private Candidate_Education_DataType[] education_DataField;

		private Candidate_Language_Skill_DataType[] language_DataField;

		private Candidate_Questionnaire_Response_DataType[] questionnaire_Response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Summary
		{
			get
			{
				return this.summaryField;
			}
			set
			{
				this.summaryField = value;
				this.RaisePropertyChanged("Summary");
			}
		}

		[XmlElement("Skill_Data", Order = 1)]
		public Candidate_Skill_DataType[] Skill_Data
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

		[XmlElement("Experience_Data", Order = 2)]
		public Candidate_Experience_DataType[] Experience_Data
		{
			get
			{
				return this.experience_DataField;
			}
			set
			{
				this.experience_DataField = value;
				this.RaisePropertyChanged("Experience_Data");
			}
		}

		[XmlElement("Education_Data", Order = 3)]
		public Candidate_Education_DataType[] Education_Data
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

		[XmlElement("Language_Data", Order = 4)]
		public Candidate_Language_Skill_DataType[] Language_Data
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

		[XmlElement("Questionnaire_Response_Data", Order = 5)]
		public Candidate_Questionnaire_Response_DataType[] Questionnaire_Response_Data
		{
			get
			{
				return this.questionnaire_Response_DataField;
			}
			set
			{
				this.questionnaire_Response_DataField = value;
				this.RaisePropertyChanged("Questionnaire_Response_Data");
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
