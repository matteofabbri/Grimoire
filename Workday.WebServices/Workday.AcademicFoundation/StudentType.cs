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
	public class StudentType : INotifyPropertyChanged
	{
		private StudentObjectType student_ReferenceField;

		private Student_DataType[] student_DataField;

		private Non_Effective_Dated_Web_Service_Additional_DataType[] student_Additional_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StudentObjectType Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
			}
		}

		[XmlElement("Student_Data", Order = 1)]
		public Student_DataType[] Student_Data
		{
			get
			{
				return this.student_DataField;
			}
			set
			{
				this.student_DataField = value;
				this.RaisePropertyChanged("Student_Data");
			}
		}

		[XmlElement("Student_Additional_Data", Order = 2)]
		public Non_Effective_Dated_Web_Service_Additional_DataType[] Student_Additional_Data
		{
			get
			{
				return this.student_Additional_DataField;
			}
			set
			{
				this.student_Additional_DataField = value;
				this.RaisePropertyChanged("Student_Additional_Data");
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
