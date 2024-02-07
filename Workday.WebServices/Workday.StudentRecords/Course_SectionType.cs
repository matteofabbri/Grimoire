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
	public class Course_SectionType : INotifyPropertyChanged
	{
		private Course_Section_DefinitionObjectType course_Section_ReferenceField;

		private Course_Section_DataType course_Section_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Course_Section_DefinitionObjectType Course_Section_Reference
		{
			get
			{
				return this.course_Section_ReferenceField;
			}
			set
			{
				this.course_Section_ReferenceField = value;
				this.RaisePropertyChanged("Course_Section_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Course_Section_DataType Course_Section_Data
		{
			get
			{
				return this.course_Section_DataField;
			}
			set
			{
				this.course_Section_DataField = value;
				this.RaisePropertyChanged("Course_Section_Data");
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
