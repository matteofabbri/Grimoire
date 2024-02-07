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
	public class Student_Application_Admission_ResponseType : INotifyPropertyChanged
	{
		private Student_ApplicationObjectType student_Application_Admission_Response_ReferenceField;

		private Student_Application_Admission_Response_DataType student_Application_Admission_Response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_ApplicationObjectType Student_Application_Admission_Response_Reference
		{
			get
			{
				return this.student_Application_Admission_Response_ReferenceField;
			}
			set
			{
				this.student_Application_Admission_Response_ReferenceField = value;
				this.RaisePropertyChanged("Student_Application_Admission_Response_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Student_Application_Admission_Response_DataType Student_Application_Admission_Response_Data
		{
			get
			{
				return this.student_Application_Admission_Response_DataField;
			}
			set
			{
				this.student_Application_Admission_Response_DataField = value;
				this.RaisePropertyChanged("Student_Application_Admission_Response_Data");
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
