using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Details_Candidate_Skills_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_Application_Details_Candidate_Experience_Subedit_DataType[] student_Application_Details_Candidate_Experience_DataField;

		private Student_Application_Details_Certification_Subedit_DataType[] student_Application_Details_Certification_DataField;

		private Student_Application_Details_Recruitable_Language_Subedit_DataType[] student_Application_Details_Recruitable_Language_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Student_Application_Details_Candidate_Experience_Data", Order = 0)]
		public Student_Application_Details_Candidate_Experience_Subedit_DataType[] Student_Application_Details_Candidate_Experience_Data
		{
			get
			{
				return this.student_Application_Details_Candidate_Experience_DataField;
			}
			set
			{
				this.student_Application_Details_Candidate_Experience_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Candidate_Experience_Data");
			}
		}

		[XmlElement("Student_Application_Details_Certification_Data", Order = 1)]
		public Student_Application_Details_Certification_Subedit_DataType[] Student_Application_Details_Certification_Data
		{
			get
			{
				return this.student_Application_Details_Certification_DataField;
			}
			set
			{
				this.student_Application_Details_Certification_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Certification_Data");
			}
		}

		[XmlElement("Student_Application_Details_Recruitable_Language_Data", Order = 2)]
		public Student_Application_Details_Recruitable_Language_Subedit_DataType[] Student_Application_Details_Recruitable_Language_Data
		{
			get
			{
				return this.student_Application_Details_Recruitable_Language_DataField;
			}
			set
			{
				this.student_Application_Details_Recruitable_Language_DataField = value;
				this.RaisePropertyChanged("Student_Application_Details_Recruitable_Language_Data");
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
