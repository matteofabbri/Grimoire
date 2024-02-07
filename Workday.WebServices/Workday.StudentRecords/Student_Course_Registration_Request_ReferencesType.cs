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
	public class Student_Course_Registration_Request_ReferencesType : INotifyPropertyChanged
	{
		private Student_Course_RegistrationObjectType[] student_Course_Registration_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Course_Registration_Reference", Order = 0)]
		public Student_Course_RegistrationObjectType[] Student_Course_Registration_Reference
		{
			get
			{
				return this.student_Course_Registration_ReferenceField;
			}
			set
			{
				this.student_Course_Registration_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Reference");
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
