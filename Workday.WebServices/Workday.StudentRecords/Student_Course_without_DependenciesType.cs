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
	public class Student_Course_without_DependenciesType : INotifyPropertyChanged
	{
		private Course_DefinitionObjectType student_Course_without_Dependencies_ReferenceField;

		private Student_Course_DataType student_Course_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_DefinitionObjectType Student_Course_without_Dependencies_Reference
		{
			get
			{
				return this.student_Course_without_Dependencies_ReferenceField;
			}
			set
			{
				this.student_Course_without_Dependencies_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_without_Dependencies_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Course_DataType Student_Course_Data
		{
			get
			{
				return this.student_Course_DataField;
			}
			set
			{
				this.student_Course_DataField = value;
				this.RaisePropertyChanged("Student_Course_Data");
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
