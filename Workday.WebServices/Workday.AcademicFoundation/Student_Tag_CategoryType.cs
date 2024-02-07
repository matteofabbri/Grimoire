using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Tag_CategoryType : INotifyPropertyChanged
	{
		private Student_Tag_CategoryObjectType student_Tag_Category_ReferenceField;

		private Student_Tag_Category_DataType[] student_Tag_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Tag_CategoryObjectType Student_Tag_Category_Reference
		{
			get
			{
				return this.student_Tag_Category_ReferenceField;
			}
			set
			{
				this.student_Tag_Category_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tag_Category_Reference");
			}
		}

		[XmlElement("Student_Tag_Category_Data", Order = 1)]
		public Student_Tag_Category_DataType[] Student_Tag_Category_Data
		{
			get
			{
				return this.student_Tag_Category_DataField;
			}
			set
			{
				this.student_Tag_Category_DataField = value;
				this.RaisePropertyChanged("Student_Tag_Category_Data");
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
