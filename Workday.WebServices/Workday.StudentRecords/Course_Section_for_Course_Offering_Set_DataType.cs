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
	public class Course_Section_for_Course_Offering_Set_DataType : INotifyPropertyChanged
	{
		private Course_Section_DefinitionObjectType student_Course_Section_ReferenceField;

		private Student_Course_Section_Data_for_Course_Section_for_Course_Offering_Set_DataType student_Course_Section_Data_for_Course_Offering_Set_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Student_Course_Section_Data_for_Course_Section_for_Course_Offering_Set_DataType Student_Course_Section_Data_for_Course_Offering_Set_Data
		{
			get
			{
				return this.student_Course_Section_Data_for_Course_Offering_Set_DataField;
			}
			set
			{
				this.student_Course_Section_Data_for_Course_Offering_Set_DataField = value;
				this.RaisePropertyChanged("Student_Course_Section_Data_for_Course_Offering_Set_Data");
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
