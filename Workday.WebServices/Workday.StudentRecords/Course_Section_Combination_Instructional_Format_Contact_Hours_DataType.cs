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
	public class Course_Section_Combination_Instructional_Format_Contact_Hours_DataType : INotifyPropertyChanged
	{
		private Instructional_FormatObjectType section_Combination_Instructional_Format_ReferenceField;

		private decimal course_Section_Instructional_Format_Contact_HoursField;

		private bool course_Section_Instructional_Format_Contact_HoursFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Instructional_FormatObjectType Section_Combination_Instructional_Format_Reference
		{
			get
			{
				return this.section_Combination_Instructional_Format_ReferenceField;
			}
			set
			{
				this.section_Combination_Instructional_Format_ReferenceField = value;
				this.RaisePropertyChanged("Section_Combination_Instructional_Format_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Course_Section_Instructional_Format_Contact_Hours
		{
			get
			{
				return this.course_Section_Instructional_Format_Contact_HoursField;
			}
			set
			{
				this.course_Section_Instructional_Format_Contact_HoursField = value;
				this.RaisePropertyChanged("Course_Section_Instructional_Format_Contact_Hours");
			}
		}

		[XmlIgnore]
		public bool Course_Section_Instructional_Format_Contact_HoursSpecified
		{
			get
			{
				return this.course_Section_Instructional_Format_Contact_HoursFieldSpecified;
			}
			set
			{
				this.course_Section_Instructional_Format_Contact_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Course_Section_Instructional_Format_Contact_HoursSpecified");
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
