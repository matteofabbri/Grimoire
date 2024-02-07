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
	public class Course_Section_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_DefinitionObjectType course_ReferenceField;

		private Activity_Offering_StatusObjectType section_Status_ReferenceField;

		private Course_Section_Data_DataType course_Section_Data_DataField;

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
		public Course_DefinitionObjectType Course_Reference
		{
			get
			{
				return this.course_ReferenceField;
			}
			set
			{
				this.course_ReferenceField = value;
				this.RaisePropertyChanged("Course_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Activity_Offering_StatusObjectType Section_Status_Reference
		{
			get
			{
				return this.section_Status_ReferenceField;
			}
			set
			{
				this.section_Status_ReferenceField = value;
				this.RaisePropertyChanged("Section_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Course_Section_Data_DataType Course_Section_Data_Data
		{
			get
			{
				return this.course_Section_Data_DataField;
			}
			set
			{
				this.course_Section_Data_DataField = value;
				this.RaisePropertyChanged("Course_Section_Data_Data");
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
