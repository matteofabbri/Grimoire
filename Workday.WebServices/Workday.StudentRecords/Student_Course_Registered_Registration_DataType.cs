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
	public class Student_Course_Registered_Registration_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Course_ListingObjectType course_Listing_ReferenceField;

		private StudentObjectType student_ReferenceField;

		private decimal unitsField;

		private Student_Grading_BasisObjectType grading_Basis_ReferenceField;

		private Student_Course_Registered_Registration_Record_DataType[] student_Course_Registration_Record_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Academic_PeriodObjectType Academic_Period_Reference
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

		[XmlElement(Order = 2)]
		public Course_ListingObjectType Course_Listing_Reference
		{
			get
			{
				return this.course_Listing_ReferenceField;
			}
			set
			{
				this.course_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Course_Listing_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Units
		{
			get
			{
				return this.unitsField;
			}
			set
			{
				this.unitsField = value;
				this.RaisePropertyChanged("Units");
			}
		}

		[XmlElement(Order = 5)]
		public Student_Grading_BasisObjectType Grading_Basis_Reference
		{
			get
			{
				return this.grading_Basis_ReferenceField;
			}
			set
			{
				this.grading_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Grading_Basis_Reference");
			}
		}

		[XmlElement("Student_Course_Registration_Record_Data", Order = 6)]
		public Student_Course_Registered_Registration_Record_DataType[] Student_Course_Registration_Record_Data
		{
			get
			{
				return this.student_Course_Registration_Record_DataField;
			}
			set
			{
				this.student_Course_Registration_Record_DataField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Record_Data");
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
