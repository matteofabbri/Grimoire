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
	public class Submit_Grades_for_Registrations_DataType : INotifyPropertyChanged
	{
		private Course_SectionObjectType section_Listing_ReferenceField;

		private Student_Grades_DataType[] student_Grades_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_SectionObjectType Section_Listing_Reference
		{
			get
			{
				return this.section_Listing_ReferenceField;
			}
			set
			{
				this.section_Listing_ReferenceField = value;
				this.RaisePropertyChanged("Section_Listing_Reference");
			}
		}

		[XmlElement("Student_Grades_Data", Order = 1)]
		public Student_Grades_DataType[] Student_Grades_Data
		{
			get
			{
				return this.student_Grades_DataField;
			}
			set
			{
				this.student_Grades_DataField = value;
				this.RaisePropertyChanged("Student_Grades_Data");
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
