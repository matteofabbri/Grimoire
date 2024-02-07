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
	public class Student_Course_Tag_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Course_TagObjectType[] student_Course_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Course_Tag_Reference", Order = 0)]
		public Student_Course_TagObjectType[] Student_Course_Tag_Reference
		{
			get
			{
				return this.student_Course_Tag_ReferenceField;
			}
			set
			{
				this.student_Course_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Tag_Reference");
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
