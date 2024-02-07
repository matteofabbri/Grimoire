using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_Transcript_Student_Prospect_DataType : INotifyPropertyChanged
	{
		private StudentObjectType student_Prospect_ReferenceField;

		private Student_External_Transcript_Student_Prospect_Person_DataType[] student_Prospect_Person_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public StudentObjectType Student_Prospect_Reference
		{
			get
			{
				return this.student_Prospect_ReferenceField;
			}
			set
			{
				this.student_Prospect_ReferenceField = value;
				this.RaisePropertyChanged("Student_Prospect_Reference");
			}
		}

		[XmlElement("Student_Prospect_Person_Data", Order = 1)]
		public Student_External_Transcript_Student_Prospect_Person_DataType[] Student_Prospect_Person_Data
		{
			get
			{
				return this.student_Prospect_Person_DataField;
			}
			set
			{
				this.student_Prospect_Person_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Person_Data");
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
