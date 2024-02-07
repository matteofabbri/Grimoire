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
	public class Student_Articulation_RuleType : INotifyPropertyChanged
	{
		private Student_Articulation_RuleObjectType student_Articulation_Rule_ReferenceField;

		private Student_Articulation_Rule_DataType student_Articulation_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Articulation_RuleObjectType Student_Articulation_Rule_Reference
		{
			get
			{
				return this.student_Articulation_Rule_ReferenceField;
			}
			set
			{
				this.student_Articulation_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Student_Articulation_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Articulation_Rule_DataType Student_Articulation_Rule_Data
		{
			get
			{
				return this.student_Articulation_Rule_DataField;
			}
			set
			{
				this.student_Articulation_Rule_DataField = value;
				this.RaisePropertyChanged("Student_Articulation_Rule_Data");
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
