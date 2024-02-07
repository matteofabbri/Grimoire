using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.StudentRecords
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Grades_for_Registrations_ResponseType : INotifyPropertyChanged
	{
		private Course_SectionObjectType section_Listing_ReferenceField;

		private Course_Section_DefinitionObjectType student_Course_Section_ReferenceField;

		private string versionField;

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

		[XmlElement(Order = 1)]
		public Course_Section_DefinitionObjectType Student_Course_Section_Reference
		{
			get
			{
				return this.student_Course_Section_ReferenceField;
			}
			set
			{
				this.student_Course_Section_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Section_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
