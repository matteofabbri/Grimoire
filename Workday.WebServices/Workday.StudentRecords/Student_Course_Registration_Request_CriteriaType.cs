using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Course_Registration_Request_CriteriaType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private string universal_IDField;

		private Student_Course_Registration_Data_LoadObjectType student_Course_Registration_Data_Load_ReferenceField;

		private Course_SectionObjectType[] course_Section_ReferenceField;

		private Academic_PeriodObjectType[] academic_Period_ReferenceField;

		private Registration_Record_StatusObjectType[] registration_Record_Status_ReferenceField;

		private Student_Course_Registration_RecordObjectType[] student_Course_Registration_Record_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Universal_ID
		{
			get
			{
				return this.universal_IDField;
			}
			set
			{
				this.universal_IDField = value;
				this.RaisePropertyChanged("Universal_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Course_Registration_Data_LoadObjectType Student_Course_Registration_Data_Load_Reference
		{
			get
			{
				return this.student_Course_Registration_Data_Load_ReferenceField;
			}
			set
			{
				this.student_Course_Registration_Data_Load_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Data_Load_Reference");
			}
		}

		[XmlElement("Course_Section_Reference", Order = 3)]
		public Course_SectionObjectType[] Course_Section_Reference
		{
			get
			{
				return this.course_Section_ReferenceField;
			}
			set
			{
				this.course_Section_ReferenceField = value;
				this.RaisePropertyChanged("Course_Section_Reference");
			}
		}

		[XmlElement("Academic_Period_Reference", Order = 4)]
		public Academic_PeriodObjectType[] Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement("Registration_Record_Status_Reference", Order = 5)]
		public Registration_Record_StatusObjectType[] Registration_Record_Status_Reference
		{
			get
			{
				return this.registration_Record_Status_ReferenceField;
			}
			set
			{
				this.registration_Record_Status_ReferenceField = value;
				this.RaisePropertyChanged("Registration_Record_Status_Reference");
			}
		}

		[XmlElement("Student_Course_Registration_Record_Reference", Order = 6)]
		public Student_Course_Registration_RecordObjectType[] Student_Course_Registration_Record_Reference
		{
			get
			{
				return this.student_Course_Registration_Record_ReferenceField;
			}
			set
			{
				this.student_Course_Registration_Record_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Record_Reference");
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
