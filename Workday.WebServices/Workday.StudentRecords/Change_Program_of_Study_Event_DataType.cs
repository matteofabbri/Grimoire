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
	public class Change_Program_of_Study_Event_DataType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private Program_of_StudyObjectType program_of_Study_ReferenceField;

		private Valid_Program_of_Study_Change_DataType valid_Program_of_Study_Change_DataField;

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
		public Program_of_StudyObjectType Program_of_Study_Reference
		{
			get
			{
				return this.program_of_Study_ReferenceField;
			}
			set
			{
				this.program_of_Study_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Valid_Program_of_Study_Change_DataType Valid_Program_of_Study_Change_Data
		{
			get
			{
				return this.valid_Program_of_Study_Change_DataField;
			}
			set
			{
				this.valid_Program_of_Study_Change_DataField = value;
				this.RaisePropertyChanged("Valid_Program_of_Study_Change_Data");
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
