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
	public class Student_AccomplishmentType : INotifyPropertyChanged
	{
		private Student_AccomplishmentObjectType student_Accomplishment_ReferenceField;

		private Student_Accomplishment_DataType[] student_Accomplishment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_AccomplishmentObjectType Student_Accomplishment_Reference
		{
			get
			{
				return this.student_Accomplishment_ReferenceField;
			}
			set
			{
				this.student_Accomplishment_ReferenceField = value;
				this.RaisePropertyChanged("Student_Accomplishment_Reference");
			}
		}

		[XmlElement("Student_Accomplishment_Data", Order = 1)]
		public Student_Accomplishment_DataType[] Student_Accomplishment_Data
		{
			get
			{
				return this.student_Accomplishment_DataField;
			}
			set
			{
				this.student_Accomplishment_DataField = value;
				this.RaisePropertyChanged("Student_Accomplishment_Data");
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
