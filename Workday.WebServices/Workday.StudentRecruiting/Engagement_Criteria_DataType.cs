using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Engagement_Criteria_DataType : INotifyPropertyChanged
	{
		private Academic_Curricular_DivisionObjectType[] recruitment_Academic_Unit_ReferenceField;

		private Academic_LevelObjectType[] academic_Level_ReferenceField;

		private Student_Prospect_StageObjectType[] prospect_Stage_ReferenceField;

		private Educational_InstitutionObjectType[] educational_Institution_ReferenceField;

		private Educational_InterestObjectType[] educational_Interest_ReferenceField;

		private Student_TagObjectType[] student_Tag_ReferenceField;

		private DateTime anticipated_Start_After_DateField;

		private bool anticipated_Start_After_DateFieldSpecified;

		private DateTime anticipated_Start_Before_DateField;

		private bool anticipated_Start_Before_DateFieldSpecified;

		private RegionObjectType[] recruiting_Region_ReferenceField;

		private Country_RegionObjectType[] state_ReferenceField;

		private string zip_CodeField;

		private Student_Eligibility_RuleObjectType[] admissions_Eligibility_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Recruitment_Academic_Unit_Reference", Order = 0)]
		public Academic_Curricular_DivisionObjectType[] Recruitment_Academic_Unit_Reference
		{
			get
			{
				return this.recruitment_Academic_Unit_ReferenceField;
			}
			set
			{
				this.recruitment_Academic_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Recruitment_Academic_Unit_Reference");
			}
		}

		[XmlElement("Academic_Level_Reference", Order = 1)]
		public Academic_LevelObjectType[] Academic_Level_Reference
		{
			get
			{
				return this.academic_Level_ReferenceField;
			}
			set
			{
				this.academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Level_Reference");
			}
		}

		[XmlElement("Prospect_Stage_Reference", Order = 2)]
		public Student_Prospect_StageObjectType[] Prospect_Stage_Reference
		{
			get
			{
				return this.prospect_Stage_ReferenceField;
			}
			set
			{
				this.prospect_Stage_ReferenceField = value;
				this.RaisePropertyChanged("Prospect_Stage_Reference");
			}
		}

		[XmlElement("Educational_Institution_Reference", Order = 3)]
		public Educational_InstitutionObjectType[] Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
			}
		}

		[XmlElement("Educational_Interest_Reference", Order = 4)]
		public Educational_InterestObjectType[] Educational_Interest_Reference
		{
			get
			{
				return this.educational_Interest_ReferenceField;
			}
			set
			{
				this.educational_Interest_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Interest_Reference");
			}
		}

		[XmlElement("Student_Tag_Reference", Order = 5)]
		public Student_TagObjectType[] Student_Tag_Reference
		{
			get
			{
				return this.student_Tag_ReferenceField;
			}
			set
			{
				this.student_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tag_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Anticipated_Start_After_Date
		{
			get
			{
				return this.anticipated_Start_After_DateField;
			}
			set
			{
				this.anticipated_Start_After_DateField = value;
				this.RaisePropertyChanged("Anticipated_Start_After_Date");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Start_After_DateSpecified
		{
			get
			{
				return this.anticipated_Start_After_DateFieldSpecified;
			}
			set
			{
				this.anticipated_Start_After_DateFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Start_After_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Anticipated_Start_Before_Date
		{
			get
			{
				return this.anticipated_Start_Before_DateField;
			}
			set
			{
				this.anticipated_Start_Before_DateField = value;
				this.RaisePropertyChanged("Anticipated_Start_Before_Date");
			}
		}

		[XmlIgnore]
		public bool Anticipated_Start_Before_DateSpecified
		{
			get
			{
				return this.anticipated_Start_Before_DateFieldSpecified;
			}
			set
			{
				this.anticipated_Start_Before_DateFieldSpecified = value;
				this.RaisePropertyChanged("Anticipated_Start_Before_DateSpecified");
			}
		}

		[XmlElement("Recruiting_Region_Reference", Order = 8)]
		public RegionObjectType[] Recruiting_Region_Reference
		{
			get
			{
				return this.recruiting_Region_ReferenceField;
			}
			set
			{
				this.recruiting_Region_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Region_Reference");
			}
		}

		[XmlElement("State_Reference", Order = 9)]
		public Country_RegionObjectType[] State_Reference
		{
			get
			{
				return this.state_ReferenceField;
			}
			set
			{
				this.state_ReferenceField = value;
				this.RaisePropertyChanged("State_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Zip_Code
		{
			get
			{
				return this.zip_CodeField;
			}
			set
			{
				this.zip_CodeField = value;
				this.RaisePropertyChanged("Zip_Code");
			}
		}

		[XmlElement("Admissions_Eligibility_Rule_Reference", Order = 11)]
		public Student_Eligibility_RuleObjectType[] Admissions_Eligibility_Rule_Reference
		{
			get
			{
				return this.admissions_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.admissions_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Admissions_Eligibility_Rule_Reference");
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
