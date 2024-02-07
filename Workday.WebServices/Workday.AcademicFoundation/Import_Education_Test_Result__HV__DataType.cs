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
	public class Import_Education_Test_Result__HV__DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool opt_OutField;

		private bool opt_OutFieldSpecified;

		private Student_Prospect_Person_DataType[] student_Person_DataField;

		private Student_Prospect_Personal_Portfolio_DataType[] student_Personal_Portfolio_DataField;

		private Educational_Institution_Attendance_DataType[] student_School_DataField;

		private Education_Test_Result__HV__DataType[] student_Education_Test_Result_DataField;

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

		[XmlElement("Student_Person_Data", Order = 2)]
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

		[XmlElement("Student_Personal_Portfolio_Data", Order = 3)]
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

		[XmlElement("Student_Education_Test_Result_Data", Order = 5)]
		public Education_Test_Result__HV__DataType[] Student_Education_Test_Result_Data
		{
			get
			{
				return this.student_Education_Test_Result_DataField;
			}
			set
			{
				this.student_Education_Test_Result_DataField = value;
				this.RaisePropertyChanged("Student_Education_Test_Result_Data");
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
