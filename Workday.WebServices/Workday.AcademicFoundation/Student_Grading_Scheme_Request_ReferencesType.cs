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
	public class Student_Grading_Scheme_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Grading_SchemeObjectType[] student_Grading_Scheme_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Grading_Scheme_Reference", Order = 0)]
		public Student_Grading_SchemeObjectType[] Student_Grading_Scheme_Reference
		{
			get
			{
				return this.student_Grading_Scheme_ReferenceField;
			}
			set
			{
				this.student_Grading_Scheme_ReferenceField = value;
				this.RaisePropertyChanged("Student_Grading_Scheme_Reference");
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
