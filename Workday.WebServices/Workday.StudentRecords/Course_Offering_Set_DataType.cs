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
	public class Course_Offering_Set_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Course_DefinitionObjectType student_Course_ReferenceField;

		private Academic_PeriodObjectType academic_Period_ReferenceField;

		private Course_Section_for_Course_Offering_Set_DataType[] course_Section_for_Course_Offering_Set_DataField;

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
		public Course_DefinitionObjectType Student_Course_Reference
		{
			get
			{
				return this.student_Course_ReferenceField;
			}
			set
			{
				this.student_Course_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Course_Section_for_Course_Offering_Set_Data", Order = 3)]
		public Course_Section_for_Course_Offering_Set_DataType[] Course_Section_for_Course_Offering_Set_Data
		{
			get
			{
				return this.course_Section_for_Course_Offering_Set_DataField;
			}
			set
			{
				this.course_Section_for_Course_Offering_Set_DataField = value;
				this.RaisePropertyChanged("Course_Section_for_Course_Offering_Set_Data");
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
