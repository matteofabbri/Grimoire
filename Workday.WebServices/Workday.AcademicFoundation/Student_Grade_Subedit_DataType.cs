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
	public class Student_Grade_Subedit_DataType : INotifyPropertyChanged
	{
		private string orderField;

		private Student_GradeObjectType student_Grade_ReferenceField;

		private Student_Grade_ElementObjectType student_Grade_Element_ReferenceField;

		private decimal grade_PointsField;

		private bool grade_PointsFieldSpecified;

		private bool earn_CreditsField;

		private bool earn_CreditsFieldSpecified;

		private bool include_in_GPAField;

		private bool include_in_GPAFieldSpecified;

		private bool convert_to_PassField;

		private bool convert_to_PassFieldSpecified;

		private bool repeated_for_Grade_ImprovementField;

		private bool repeated_for_Grade_ImprovementFieldSpecified;

		private string grade_NameField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 1)]
		public Student_GradeObjectType Student_Grade_Reference
		{
			get
			{
				return this.student_Grade_ReferenceField;
			}
			set
			{
				this.student_Grade_ReferenceField = value;
				this.RaisePropertyChanged("Student_Grade_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Grade_ElementObjectType Student_Grade_Element_Reference
		{
			get
			{
				return this.student_Grade_Element_ReferenceField;
			}
			set
			{
				this.student_Grade_Element_ReferenceField = value;
				this.RaisePropertyChanged("Student_Grade_Element_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Grade_Points
		{
			get
			{
				return this.grade_PointsField;
			}
			set
			{
				this.grade_PointsField = value;
				this.RaisePropertyChanged("Grade_Points");
			}
		}

		[XmlIgnore]
		public bool Grade_PointsSpecified
		{
			get
			{
				return this.grade_PointsFieldSpecified;
			}
			set
			{
				this.grade_PointsFieldSpecified = value;
				this.RaisePropertyChanged("Grade_PointsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Earn_Credits
		{
			get
			{
				return this.earn_CreditsField;
			}
			set
			{
				this.earn_CreditsField = value;
				this.RaisePropertyChanged("Earn_Credits");
			}
		}

		[XmlIgnore]
		public bool Earn_CreditsSpecified
		{
			get
			{
				return this.earn_CreditsFieldSpecified;
			}
			set
			{
				this.earn_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Earn_CreditsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_in_GPA
		{
			get
			{
				return this.include_in_GPAField;
			}
			set
			{
				this.include_in_GPAField = value;
				this.RaisePropertyChanged("Include_in_GPA");
			}
		}

		[XmlIgnore]
		public bool Include_in_GPASpecified
		{
			get
			{
				return this.include_in_GPAFieldSpecified;
			}
			set
			{
				this.include_in_GPAFieldSpecified = value;
				this.RaisePropertyChanged("Include_in_GPASpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Convert_to_Pass
		{
			get
			{
				return this.convert_to_PassField;
			}
			set
			{
				this.convert_to_PassField = value;
				this.RaisePropertyChanged("Convert_to_Pass");
			}
		}

		[XmlIgnore]
		public bool Convert_to_PassSpecified
		{
			get
			{
				return this.convert_to_PassFieldSpecified;
			}
			set
			{
				this.convert_to_PassFieldSpecified = value;
				this.RaisePropertyChanged("Convert_to_PassSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Repeated_for_Grade_Improvement
		{
			get
			{
				return this.repeated_for_Grade_ImprovementField;
			}
			set
			{
				this.repeated_for_Grade_ImprovementField = value;
				this.RaisePropertyChanged("Repeated_for_Grade_Improvement");
			}
		}

		[XmlIgnore]
		public bool Repeated_for_Grade_ImprovementSpecified
		{
			get
			{
				return this.repeated_for_Grade_ImprovementFieldSpecified;
			}
			set
			{
				this.repeated_for_Grade_ImprovementFieldSpecified = value;
				this.RaisePropertyChanged("Repeated_for_Grade_ImprovementSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Grade_Name
		{
			get
			{
				return this.grade_NameField;
			}
			set
			{
				this.grade_NameField = value;
				this.RaisePropertyChanged("Grade_Name");
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
