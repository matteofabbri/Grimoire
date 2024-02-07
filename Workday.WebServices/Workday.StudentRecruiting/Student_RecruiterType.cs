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
	public class Student_RecruiterType : INotifyPropertyChanged
	{
		private Admissions_CounselorObjectType student_Recruiter_ReferenceField;

		private Student_Recruiter_DataType[] student_Recruiter_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Admissions_CounselorObjectType Student_Recruiter_Reference
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

		[XmlElement("Student_Recruiter_Data", Order = 1)]
		public Student_Recruiter_DataType[] Student_Recruiter_Data
		{
			get
			{
				return this.student_Recruiter_DataField;
			}
			set
			{
				this.student_Recruiter_DataField = value;
				this.RaisePropertyChanged("Student_Recruiter_Data");
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
