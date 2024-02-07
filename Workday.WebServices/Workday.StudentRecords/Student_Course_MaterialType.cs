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
	public class Student_Course_MaterialType : INotifyPropertyChanged
	{
		private Student_Course_MaterialObjectType student_Course_Material_ReferenceField;

		private Student_Course_Material_DataType[] student_Course_Material_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_Course_MaterialObjectType Student_Course_Material_Reference
		{
			get
			{
				return this.student_Course_Material_ReferenceField;
			}
			set
			{
				this.student_Course_Material_ReferenceField = value;
				this.RaisePropertyChanged("Student_Course_Material_Reference");
			}
		}

		[XmlElement("Student_Course_Material_Data", Order = 1)]
		public Student_Course_Material_DataType[] Student_Course_Material_Data
		{
			get
			{
				return this.student_Course_Material_DataField;
			}
			set
			{
				this.student_Course_Material_DataField = value;
				this.RaisePropertyChanged("Student_Course_Material_Data");
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
