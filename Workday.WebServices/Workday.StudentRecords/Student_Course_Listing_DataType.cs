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
	public class Student_Course_Listing_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_SubjectObjectType course_Subject_ReferenceField;

		private string course_NumberField;

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
		public Course_SubjectObjectType Course_Subject_Reference
		{
			get
			{
				return this.course_Subject_ReferenceField;
			}
			set
			{
				this.course_Subject_ReferenceField = value;
				this.RaisePropertyChanged("Course_Subject_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Course_Number
		{
			get
			{
				return this.course_NumberField;
			}
			set
			{
				this.course_NumberField = value;
				this.RaisePropertyChanged("Course_Number");
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
