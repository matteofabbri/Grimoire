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
	public class Prospective_Student_DataType : INotifyPropertyChanged
	{
		private bool opt_OutField;

		private bool opt_OutFieldSpecified;

		private Student_Prospect_Person_DataType[] student_Person_DataField;

		private Student_Prospect_Personal_Portfolio_DataType[] student_Personal_Portfolio_DataField;

		private Student_Application_Details_Personal_Information_Subedit_DataType[] student_Personal_Information_DataField;

		private Educational_Institution_Attendance_DataType[] student_School_DataField;

		private Student_Recruitment_DataType[] student_Recruitment_DataField;

		private Student_Application_DataType[] student_Application_DataField;

		private Education_Test_Result__HV__DataType[] education_Test_Result_DataField;

		private Student_External_Transcript_Subedit_DataType[] student_Transcript_DataField;

		private Student_Prospect_Proxy_DataType[] student_Proxy_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Opt_Out
		{
			get
			{
				return this.opt_OutField;
			}
			set
			{
				this.opt_OutField = value;
				this.RaisePropertyChanged("Opt_Out");
			}
		}

		[XmlIgnore]
		public bool Opt_OutSpecified
		{
			get
			{
				return this.opt_OutFieldSpecified;
			}
			set
			{
				this.opt_OutFieldSpecified = value;
				this.RaisePropertyChanged("Opt_OutSpecified");
			}
		}

		[XmlElement("Student_Person_Data", Order = 1)]
		public Student_Prospect_Person_DataType[] Student_Person_Data
		{
			get
			{
				return this.student_Person_DataField;
			}
			set
			{
				this.student_Person_DataField = value;
				this.RaisePropertyChanged("Student_Person_Data");
			}
		}

		[XmlElement("Student_Personal_Portfolio_Data", Order = 2)]
		public Student_Prospect_Personal_Portfolio_DataType[] Student_Personal_Portfolio_Data
		{
			get
			{
				return this.student_Personal_Portfolio_DataField;
			}
			set
			{
				this.student_Personal_Portfolio_DataField = value;
				this.RaisePropertyChanged("Student_Personal_Portfolio_Data");
			}
		}

		[XmlElement("Student_Personal_Information_Data", Order = 3)]
		public Student_Application_Details_Personal_Information_Subedit_DataType[] Student_Personal_Information_Data
		{
			get
			{
				return this.student_Personal_Information_DataField;
			}
			set
			{
				this.student_Personal_Information_DataField = value;
				this.RaisePropertyChanged("Student_Personal_Information_Data");
			}
		}

		[XmlElement("Student_School_Data", Order = 4)]
		public Educational_Institution_Attendance_DataType[] Student_School_Data
		{
			get
			{
				return this.student_School_DataField;
			}
			set
			{
				this.student_School_DataField = value;
				this.RaisePropertyChanged("Student_School_Data");
			}
		}

		[XmlElement("Student_Recruitment_Data", Order = 5)]
		public Student_Recruitment_DataType[] Student_Recruitment_Data
		{
			get
			{
				return this.student_Recruitment_DataField;
			}
			set
			{
				this.student_Recruitment_DataField = value;
				this.RaisePropertyChanged("Student_Recruitment_Data");
			}
		}

		[XmlElement("Student_Application_Data", Order = 6)]
		public Student_Application_DataType[] Student_Application_Data
		{
			get
			{
				return this.student_Application_DataField;
			}
			set
			{
				this.student_Application_DataField = value;
				this.RaisePropertyChanged("Student_Application_Data");
			}
		}

		[XmlElement("Education_Test_Result_Data", Order = 7)]
		public Education_Test_Result__HV__DataType[] Education_Test_Result_Data
		{
			get
			{
				return this.education_Test_Result_DataField;
			}
			set
			{
				this.education_Test_Result_DataField = value;
				this.RaisePropertyChanged("Education_Test_Result_Data");
			}
		}

		[XmlElement("Student_Transcript_Data", Order = 8)]
		public Student_External_Transcript_Subedit_DataType[] Student_Transcript_Data
		{
			get
			{
				return this.student_Transcript_DataField;
			}
			set
			{
				this.student_Transcript_DataField = value;
				this.RaisePropertyChanged("Student_Transcript_Data");
			}
		}

		[XmlElement("Student_Proxy_Data", Order = 9)]
		public Student_Prospect_Proxy_DataType[] Student_Proxy_Data
		{
			get
			{
				return this.student_Proxy_DataField;
			}
			set
			{
				this.student_Proxy_DataField = value;
				this.RaisePropertyChanged("Student_Proxy_Data");
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
