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
	public class Student_Conditional_Assignment_Inheritable_Academic_Progress_DataType : INotifyPropertyChanged
	{
		private Student_Conditional_Assignment_InheritableObjectType requirement_Area_ReferenceField;

		private string requirement_Area_NameField;

		private Student_Academic_Progress_DataType[] student_Academic_Progress_Data_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Conditional_Assignment_InheritableObjectType Requirement_Area_Reference
		{
			get
			{
				return this.requirement_Area_ReferenceField;
			}
			set
			{
				this.requirement_Area_ReferenceField = value;
				this.RaisePropertyChanged("Requirement_Area_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Requirement_Area_Name
		{
			get
			{
				return this.requirement_Area_NameField;
			}
			set
			{
				this.requirement_Area_NameField = value;
				this.RaisePropertyChanged("Requirement_Area_Name");
			}
		}

		[XmlElement("Student_Academic_Progress_Data_Reference", Order = 2)]
		public Student_Academic_Progress_DataType[] Student_Academic_Progress_Data_Reference
		{
			get
			{
				return this.student_Academic_Progress_Data_ReferenceField;
			}
			set
			{
				this.student_Academic_Progress_Data_ReferenceField = value;
				this.RaisePropertyChanged("Student_Academic_Progress_Data_Reference");
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
