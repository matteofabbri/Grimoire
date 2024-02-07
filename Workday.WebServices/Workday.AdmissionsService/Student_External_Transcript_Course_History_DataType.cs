using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Transcript_Course_History_DataType : INotifyPropertyChanged
	{
		private Student_External_Transcript_Course_RecordObjectType student_External_Transcript_Course_Record_ReferenceField;

		private string idField;

		private DateTime student_External_Transcript_Course_Start_DateField;

		private bool student_External_Transcript_Course_Start_DateFieldSpecified;

		private string course_IDField;

		private string titleField;

		private Educational_Institution_Course_Academic_AreaObjectType academic_Area_ReferenceField;

		private Educational_Institution_Course_DesignationObjectType[] course_Designations_ReferenceField;

		private decimal course_Units_EarnedField;

		private bool course_Units_EarnedFieldSpecified;

		private decimal course_Units_AttemptedField;

		private bool course_Units_AttemptedFieldSpecified;

		private string gradeField;

		private External_Institution_Grading_SchemeObjectType external_Institution_Grading_Scheme_ReferenceField;

		private Student_External_Transcript_Course_Record_LevelObjectType student_Level_ReferenceField;

		private Student_External_Transcript_Course_Repeat_CodeObjectType student_External_Transcript_Course_Repeat_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_Transcript_Course_RecordObjectType Student_External_Transcript_Course_Record_Reference
		{
			get
			{
				return this.student_External_Transcript_Course_Record_ReferenceField;
			}
			set
			{
				this.student_External_Transcript_Course_Record_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Course_Record_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Student_External_Transcript_Course_Start_Date
		{
			get
			{
				return this.student_External_Transcript_Course_Start_DateField;
			}
			set
			{
				this.student_External_Transcript_Course_Start_DateField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Course_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Student_External_Transcript_Course_Start_DateSpecified
		{
			get
			{
				return this.student_External_Transcript_Course_Start_DateFieldSpecified;
			}
			set
			{
				this.student_External_Transcript_Course_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_External_Transcript_Course_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Course_ID
		{
			get
			{
				return this.course_IDField;
			}
			set
			{
				this.course_IDField = value;
				this.RaisePropertyChanged("Course_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Title
		{
			get
			{
				return this.titleField;
			}
			set
			{
				this.titleField = value;
				this.RaisePropertyChanged("Title");
			}
		}

		[XmlElement(Order = 5)]
		public Educational_Institution_Course_Academic_AreaObjectType Academic_Area_Reference
		{
			get
			{
				return this.academic_Area_ReferenceField;
			}
			set
			{
				this.academic_Area_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Area_Reference");
			}
		}

		[XmlElement("Course_Designations_Reference", Order = 6)]
		public Educational_Institution_Course_DesignationObjectType[] Course_Designations_Reference
		{
			get
			{
				return this.course_Designations_ReferenceField;
			}
			set
			{
				this.course_Designations_ReferenceField = value;
				this.RaisePropertyChanged("Course_Designations_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Course_Units_Earned
		{
			get
			{
				return this.course_Units_EarnedField;
			}
			set
			{
				this.course_Units_EarnedField = value;
				this.RaisePropertyChanged("Course_Units_Earned");
			}
		}

		[XmlIgnore]
		public bool Course_Units_EarnedSpecified
		{
			get
			{
				return this.course_Units_EarnedFieldSpecified;
			}
			set
			{
				this.course_Units_EarnedFieldSpecified = value;
				this.RaisePropertyChanged("Course_Units_EarnedSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Course_Units_Attempted
		{
			get
			{
				return this.course_Units_AttemptedField;
			}
			set
			{
				this.course_Units_AttemptedField = value;
				this.RaisePropertyChanged("Course_Units_Attempted");
			}
		}

		[XmlIgnore]
		public bool Course_Units_AttemptedSpecified
		{
			get
			{
				return this.course_Units_AttemptedFieldSpecified;
			}
			set
			{
				this.course_Units_AttemptedFieldSpecified = value;
				this.RaisePropertyChanged("Course_Units_AttemptedSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Grade
		{
			get
			{
				return this.gradeField;
			}
			set
			{
				this.gradeField = value;
				this.RaisePropertyChanged("Grade");
			}
		}

		[XmlElement(Order = 10)]
		public External_Institution_Grading_SchemeObjectType External_Institution_Grading_Scheme_Reference
		{
			get
			{
				return this.external_Institution_Grading_Scheme_ReferenceField;
			}
			set
			{
				this.external_Institution_Grading_Scheme_ReferenceField = value;
				this.RaisePropertyChanged("External_Institution_Grading_Scheme_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Student_External_Transcript_Course_Record_LevelObjectType Student_Level_Reference
		{
			get
			{
				return this.student_Level_ReferenceField;
			}
			set
			{
				this.student_Level_ReferenceField = value;
				this.RaisePropertyChanged("Student_Level_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Student_External_Transcript_Course_Repeat_CodeObjectType Student_External_Transcript_Course_Repeat_Code_Reference
		{
			get
			{
				return this.student_External_Transcript_Course_Repeat_Code_ReferenceField;
			}
			set
			{
				this.student_External_Transcript_Course_Repeat_Code_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Course_Repeat_Code_Reference");
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
