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
	public class Student_Course_RegistrationType : INotifyPropertyChanged
	{
		private Student_Course_RegistrationObjectType student_Course_Registration_ReferenceField;

		private Student_Course_Registration_DataType[] student_Course_Registration_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Course_RegistrationObjectType Student_Course_Registration_Reference
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

		[XmlElement("Student_Course_Registration_Data", Order = 1)]
		public Student_Course_Registration_DataType[] Student_Course_Registration_Data
		{
			get
			{
				return this.student_Course_Registration_DataField;
			}
			set
			{
				this.student_Course_Registration_DataField = value;
				this.RaisePropertyChanged("Student_Course_Registration_Data");
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
