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
	public class Student_Educational_InstitutionType : INotifyPropertyChanged
	{
		private Educational_InstitutionObjectType educational_Institution_ReferenceField;

		private Student_Educational_Institution_DataType[] student_Educational_Institution_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Educational_InstitutionObjectType Educational_Institution_Reference
		{
			get
			{
				return this.educational_Institution_ReferenceField;
			}
			set
			{
				this.educational_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Educational_Institution_Reference");
			}
		}

		[XmlElement("Student_Educational_Institution_Data", Order = 1)]
		public Student_Educational_Institution_DataType[] Student_Educational_Institution_Data
		{
			get
			{
				return this.student_Educational_Institution_DataField;
			}
			set
			{
				this.student_Educational_Institution_DataField = value;
				this.RaisePropertyChanged("Student_Educational_Institution_Data");
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
