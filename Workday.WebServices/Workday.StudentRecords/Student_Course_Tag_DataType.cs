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
	public class Student_Course_Tag_DataType : INotifyPropertyChanged
	{
		private string student_Course_Tag_NameField;

		private Academic_UnitObjectType[] has_Institution_Academic_Unit_DataField;

		private Student_Course_Tag_CategoryObjectType student_Course_Tag_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Student_Course_Tag_Name
		{
			get
			{
				return this.student_Course_Tag_NameField;
			}
			set
			{
				this.student_Course_Tag_NameField = value;
				this.RaisePropertyChanged("Student_Course_Tag_Name");
			}
		}

		[XmlArray(Order = 1), XmlArrayItem("Academic_Unit_Reference", IsNullable = false)]
		public Academic_UnitObjectType[] Has_Institution_Academic_Unit_Data
		{
			get
			{
				return this.has_Institution_Academic_Unit_DataField;
			}
			set
			{
				this.has_Institution_Academic_Unit_DataField = value;
				this.RaisePropertyChanged("Has_Institution_Academic_Unit_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Student_Course_Tag_CategoryObjectType Student_Course_Tag_Category_Reference
		{
			get
			{
				return this.student_Course_Tag_Category_ReferenceField;
			}
			set
			{
				this.student_Course_Tag_Category_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Tag_Category_Reference");
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
