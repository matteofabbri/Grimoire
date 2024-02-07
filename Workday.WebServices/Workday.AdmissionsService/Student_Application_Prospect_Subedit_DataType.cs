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
	public class Student_Application_Prospect_Subedit_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string student_IDField;

		private Student_Applicant_Person_DataType[] student_Prospect_Person_DataField;

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
		public string Student_ID
		{
			get
			{
				return this.student_IDField;
			}
			set
			{
				this.student_IDField = value;
				this.RaisePropertyChanged("Student_ID");
			}
		}

		[XmlElement("Student_Prospect_Person_Data", Order = 2)]
		public Student_Applicant_Person_DataType[] Student_Prospect_Person_Data
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

		[XmlElement("Student_Prospect_Friends_and_Family_Data", Order = 3)]
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
