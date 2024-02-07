using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Admissions
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Student_External_Post-Secondary_Transcript_Summary_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_External_PostSecondary_Transcript_Summary_DataType : INotifyPropertyChanged
	{
		private Student_External_Transcript_Academic_LevelObjectType student_External_Transcript_Academic_Level_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_Transcript_Academic_LevelObjectType Student_External_Transcript_Academic_Level_Reference
		{
			get
			{
				return this.student_External_Transcript_Academic_Level_ReferenceField;
			}
			set
			{
				this.student_External_Transcript_Academic_Level_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Academic_Level_Reference");
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
