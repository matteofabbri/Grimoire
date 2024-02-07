using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicAdvising
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Academic_ProgressType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private Program_of_Study_Student_Academic_Progress_DataType[] program_of_Study_Student_Academic_Progress_DataField;

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

		[XmlElement("Program_of_Study_Student_Academic_Progress_Data", Order = 1)]
		public Program_of_Study_Student_Academic_Progress_DataType[] Program_of_Study_Student_Academic_Progress_Data
		{
			get
			{
				return this.program_of_Study_Student_Academic_Progress_DataField;
			}
			set
			{
				this.program_of_Study_Student_Academic_Progress_DataField = value;
				this.RaisePropertyChanged("Program_of_Study_Student_Academic_Progress_Data");
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
