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
	public class Student_Competency_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Competency_Manual_AssignmentObjectType[] student_Competency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Competency_Reference", Order = 0)]
		public Student_Competency_Manual_AssignmentObjectType[] Student_Competency_Reference
		{
			get
			{
				return this.student_Competency_ReferenceField;
			}
			set
			{
				this.student_Competency_ReferenceField = value;
				this.RaisePropertyChanged("Student_Competency_Reference");
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
