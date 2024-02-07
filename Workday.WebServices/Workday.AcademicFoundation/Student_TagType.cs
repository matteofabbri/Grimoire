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
	public class Student_TagType : INotifyPropertyChanged
	{
		private Student_TagObjectType student_Tag_ReferenceField;

		private Student_Tag_DataType[] student_Tag_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_TagObjectType Student_Tag_Reference
		{
			get
			{
				return this.student_Tag_ReferenceField;
			}
			set
			{
				this.student_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Student_Tag_Reference");
			}
		}

		[XmlElement("Student_Tag_Data", Order = 1)]
		public Student_Tag_DataType[] Student_Tag_Data
		{
			get
			{
				return this.student_Tag_DataField;
			}
			set
			{
				this.student_Tag_DataField = value;
				this.RaisePropertyChanged("Student_Tag_Data");
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
