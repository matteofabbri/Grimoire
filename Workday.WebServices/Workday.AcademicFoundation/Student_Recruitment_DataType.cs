using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruitment_DataType : INotifyPropertyChanged
	{
		private bool activeField;

		private bool activeFieldSpecified;

		private Academic_Curricular_Division_Subedit_DataType[] academic_Unit_DataField;

		private Student_RecruitmentObjectType student_Prospect_Recruitment_ReferenceField;

		private Academic_Period_Subedit_DataType academic_Period_DataField;

		private Student_Prospect_StageObjectType student_Prospect_Stage_ReferenceField;

		private Educational_InterestObjectType[] educational_Interest_ReferenceField;

		private Student_Prospect_SourceObjectType student_Prospect_Source_ReferenceField;

		private Source_DetailObjectType source_Detail_ReferenceField;

		private RegionObjectType[] region_ReferenceField;

		private RegionObjectType[] region_to_Exclude_ReferenceField;

		private Admissions_CounselorObjectType[] student_Recruiter_ReferenceField;

		private Admissions_CounselorObjectType[] student_Recruiter_to_Exclude_ReferenceField;

		private Student_Prospect_TypeObjectType[] student_Prospect_Type_ReferenceField;

		private Student_TagObjectType[] student_Tag_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Student_Preliminary_Award_Subedit_DataType[] student_Preliminary_Award_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		[XmlIgnore]
		public bool ActiveSpecified
		{
			get
			{
				return this.activeFieldSpecified;
			}
			set
			{
				this.activeFieldSpecified = value;
				this.RaisePropertyChanged("ActiveSpecified");
			}
		}

		[XmlElement("Academic_Unit_Data", Order = 1)]
		public Academic_Curricular_Division_Subedit_DataType[] Academic_Unit_Data
		{
			get
			{
				return this.academic_Unit_DataField;
			}
			set
			{
				this.academic_Unit_DataField = value;
				this.RaisePropertyChanged("Academic_Unit_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Student_RecruitmentObjectType Student_Prospect_Recruitment_Reference
		{
			get
			{
				return this.student_Prospect_Recruitment_ReferenceField;
			}
			set
			{
				this.student_Prospect_Recruitment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Recruitment_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Academic_Period_Subedit_DataType Academic_Period_Data
		{
			get
			{
				return this.academic_Period_DataField;
			}
			set
			{
				this.academic_Period_DataField = value;
				this.RaisePropertyChanged("Academic_Period_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Student_Prospect_StageObjectType Student_Prospect_Stage_Reference
		{
			get
			{
				return this.student_Prospect_Stage_ReferenceField;
			}
			set
			{
				this.student_Prospect_Stage_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Stage_Reference");
			}
		}

		[XmlElement("Educational_Interest_Reference", Order = 5)]
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

		[XmlElement(Order = 6)]
		public Student_Prospect_SourceObjectType Student_Prospect_Source_Reference
		{
			get
			{
				return this.student_Prospect_Source_ReferenceField;
			}
			set
			{
				this.student_Prospect_Source_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Source_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Source_DetailObjectType Source_Detail_Reference
		{
			get
			{
				return this.source_Detail_ReferenceField;
			}
			set
			{
				this.source_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Source_Detail_Reference");
			}
		}

		[XmlElement("Region_Reference", Order = 8)]
		public RegionObjectType[] Region_Reference
		{
			get
			{
				return this.region_ReferenceField;
			}
			set
			{
				this.region_ReferenceField = value;
				this.RaisePropertyChanged("Region_Reference");
			}
		}

		[XmlElement("Region_to_Exclude_Reference", Order = 9)]
		public RegionObjectType[] Region_to_Exclude_Reference
		{
			get
			{
				return this.region_to_Exclude_ReferenceField;
			}
			set
			{
				this.region_to_Exclude_ReferenceField = value;
				this.RaisePropertyChanged("Region_to_Exclude_Reference");
			}
		}

		[XmlElement("Student_Recruiter_Reference", Order = 10)]
		public Admissions_CounselorObjectType[] Student_Recruiter_Reference
		{
			get
			{
				return this.student_Recruiter_ReferenceField;
			}
			set
			{
				this.student_Recruiter_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiter_Reference");
			}
		}

		[XmlElement("Student_Recruiter_to_Exclude_Reference", Order = 11)]
		public Admissions_CounselorObjectType[] Student_Recruiter_to_Exclude_Reference
		{
			get
			{
				return this.student_Recruiter_to_Exclude_ReferenceField;
			}
			set
			{
				this.student_Recruiter_to_Exclude_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiter_to_Exclude_Reference");
			}
		}

		[XmlElement("Student_Prospect_Type_Reference", Order = 12)]
		public Student_Prospect_TypeObjectType[] Student_Prospect_Type_Reference
		{
			get
			{
				return this.student_Prospect_Type_ReferenceField;
			}
			set
			{
				this.student_Prospect_Type_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Type_Reference");
			}
		}

		[XmlElement("Student_Tag_Reference", Order = 13)]
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

		[XmlElement(Order = 14)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement("Student_Preliminary_Award_Data", Order = 15)]
		public Student_Preliminary_Award_Subedit_DataType[] Student_Preliminary_Award_Data
		{
			get
			{
				return this.student_Preliminary_Award_DataField;
			}
			set
			{
				this.student_Preliminary_Award_DataField = value;
				this.RaisePropertyChanged("Student_Preliminary_Award_Data");
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
