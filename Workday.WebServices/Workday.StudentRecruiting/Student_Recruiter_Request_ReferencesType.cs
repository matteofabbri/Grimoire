using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiter_Request_ReferencesType : INotifyPropertyChanged
	{
		private Admissions_CounselorObjectType[] student_Recruiter_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Recruiter_Reference", Order = 0)]
		public Admissions_CounselorObjectType[] Student_Recruiter_Reference
		{
			get
			{
				return this.student_Recruiter_ReferenceField;
			}
			set
			{
				this.student_Recruiter_ReferenceField = value;
				this.RaisePropertyChanged("Student_Recruiter_Reference");
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
