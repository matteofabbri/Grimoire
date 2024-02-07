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
	public class Program_of_Study_Student_Academic_Progress_DataType : INotifyPropertyChanged
	{
		private Program_of_StudyObjectType program_of_Study_ReferenceField;

		private Program_of_Study_Type_CategoryObjectType program_of_Study_Type_Category_ReferenceField;

		private Student_Conditional_Assignment_Inheritable_Academic_Progress_DataType[] requirement_Area_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Program_of_Study_Type_CategoryObjectType Program_of_Study_Type_Category_Reference
		{
			get
			{
				return this.program_of_Study_Type_Category_ReferenceField;
			}
			set
			{
				this.program_of_Study_Type_Category_ReferenceField = value;
				this.RaisePropertyChanged("Program_of_Study_Type_Category_Reference");
			}
		}

		[XmlElement("Requirement_Area_Data", Order = 2)]
		public Student_Conditional_Assignment_Inheritable_Academic_Progress_DataType[] Requirement_Area_Data
		{
			get
			{
				return this.requirement_Area_DataField;
			}
			set
			{
				this.requirement_Area_DataField = value;
				this.RaisePropertyChanged("Requirement_Area_Data");
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
