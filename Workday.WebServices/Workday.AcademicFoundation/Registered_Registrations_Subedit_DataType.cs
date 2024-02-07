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
	public class Registered_Registrations_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_Course_RegistrationObjectType course_Registration_ReferenceField;

		private Academic_Period_AbstractObjectType academic_Period_ReferenceField;

		private Course_ListingObjectType course_Listing_ReferenceField;

		private decimal unitsField;

		private bool unitsFieldSpecified;

		private Student_Grading_BasisObjectType grading_Basis_ReferenceField;

		private Student_Course_Registration_Record_Subedit_DataType[] student_Course_Registration_Record_Subedit_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Course_RegistrationObjectType Course_Registration_Reference
		{
			get
			{
				return this.course_Registration_ReferenceField;
			}
			set
			{
				this.course_Registration_ReferenceField = value;
				this.RaisePropertyChanged("Course_Registration_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Academic_Period_AbstractObjectType Academic_Period_Reference
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

		[XmlIgnore]
		public bool UnitsSpecified
		{
			get
			{
				return this.unitsFieldSpecified;
			}
			set
			{
				this.unitsFieldSpecified = value;
				this.RaisePropertyChanged("UnitsSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement("Student_Course_Registration_Record_Subedit_Data", Order = 5)]
		public Student_Course_Registration_Record_Subedit_DataType[] Student_Course_Registration_Record_Subedit_Data
		{
			get
			{
				return this.student_Course_Registration_Record_Subedit_DataField;
			}
			set
			{
				this.student_Course_Registration_Record_Subedit_DataField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Record_Subedit_Data");
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
