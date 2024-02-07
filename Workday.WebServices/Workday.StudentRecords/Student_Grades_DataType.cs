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
	public class Student_Grades_DataType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private Student_GradeObjectType student_Grade_ReferenceField;

		private DateTime student_Grade_Due_DateField;

		private bool student_Grade_Due_DateFieldSpecified;

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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Student_Grade_Due_Date
		{
			get
			{
				return this.student_Grade_Due_DateField;
			}
			set
			{
				this.student_Grade_Due_DateField = value;
				this.RaisePropertyChanged("Student_Grade_Due_Date");
			}
		}

		[XmlIgnore]
		public bool Student_Grade_Due_DateSpecified
		{
			get
			{
				return this.student_Grade_Due_DateFieldSpecified;
			}
			set
			{
				this.student_Grade_Due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Student_Grade_Due_DateSpecified");
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
