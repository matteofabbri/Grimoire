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
	public class Student_Recruitment_Prospect_Subedit_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool opt_OutField;

		private bool opt_OutFieldSpecified;

		private Student_Prospect_Person_DataType student_Prospect_Person_DataField;

		private Student_Prospect_Personal_Portfolio_DataType student_Prospect_Personal_Portfolio_DataField;

		private Educational_Institution_Attendance_DataType[] student_Prospect_School_DataField;

		private Student_Prospect_Proxy_DataType[] student_Prospect_Friends_and_Family_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Student_Prospect_Person_DataType Student_Prospect_Person_Data
		{
			get
			{
				return this.student_Prospect_Person_DataField;
			}
			set
			{
				this.student_Prospect_Person_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Person_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Student_Prospect_Personal_Portfolio_DataType Student_Prospect_Personal_Portfolio_Data
		{
			get
			{
				return this.student_Prospect_Personal_Portfolio_DataField;
			}
			set
			{
				this.student_Prospect_Personal_Portfolio_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Personal_Portfolio_Data");
			}
		}

		[XmlElement("Student_Prospect_School_Data", Order = 4)]
		public Educational_Institution_Attendance_DataType[] Student_Prospect_School_Data
		{
			get
			{
				return this.student_Prospect_School_DataField;
			}
			set
			{
				this.student_Prospect_School_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_School_Data");
			}
		}

		[XmlElement("Student_Prospect_Friends_and_Family_Data", Order = 5)]
		public Student_Prospect_Proxy_DataType[] Student_Prospect_Friends_and_Family_Data
		{
			get
			{
				return this.student_Prospect_Friends_and_Family_DataField;
			}
			set
			{
				this.student_Prospect_Friends_and_Family_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Friends_and_Family_Data");
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
