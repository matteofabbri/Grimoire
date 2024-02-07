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
	public class Course_Section_Relationship_Request_CriteriaType : INotifyPropertyChanged
	{
		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Course_DefinitionObjectType[] courses_ReferenceField;

		private Course_Section_DefinitionObjectType[] course_Sections_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Academic_PeriodObjectType Academic_Period_Reference
		{
			get
			{
				return this.academic_Period_ReferenceField;
			}
			set
			{
				this.academic_Period_ReferenceField = value;
				this.RaisePropertyChanged("Academic_Period_Reference");
			}
		}

		[XmlElement("Courses_Reference", Order = 1)]
		public Course_DefinitionObjectType[] Courses_Reference
		{
			get
			{
				return this.courses_ReferenceField;
			}
			set
			{
				this.courses_ReferenceField = value;
				this.RaisePropertyChanged("Courses_Reference");
			}
		}

		[XmlElement("Course_Sections_Reference", Order = 2)]
		public Course_Section_DefinitionObjectType[] Course_Sections_Reference
		{
			get
			{
				return this.course_Sections_ReferenceField;
			}
			set
			{
				this.course_Sections_ReferenceField = value;
				this.RaisePropertyChanged("Course_Sections_Reference");
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
