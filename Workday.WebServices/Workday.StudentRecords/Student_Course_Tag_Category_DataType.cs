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
	public class Student_Course_Tag_Category_DataType : INotifyPropertyChanged
	{
		private string student_Course_Tag_Category_NameField;

		private Academic_UnitObjectType[] has_Institution_Academic_Unit_DataField;

		private bool private_Course_Tag_CategoryField;

		private bool private_Course_Tag_CategoryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Student_Course_Tag_Category_Name
		{
			get
			{
				return this.student_Course_Tag_Category_NameField;
			}
			set
			{
				this.student_Course_Tag_Category_NameField = value;
				this.RaisePropertyChanged("Student_Course_Tag_Category_Name");
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
		public bool Private_Course_Tag_Category
		{
			get
			{
				return this.private_Course_Tag_CategoryField;
			}
			set
			{
				this.private_Course_Tag_CategoryField = value;
				this.RaisePropertyChanged("Private_Course_Tag_Category");
			}
		}

		[XmlIgnore]
		public bool Private_Course_Tag_CategorySpecified
		{
			get
			{
				return this.private_Course_Tag_CategoryFieldSpecified;
			}
			set
			{
				this.private_Course_Tag_CategoryFieldSpecified = value;
				this.RaisePropertyChanged("Private_Course_Tag_CategorySpecified");
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
