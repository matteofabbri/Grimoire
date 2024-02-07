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
	public class External_Student_Transcript_Request_CriteriaType : INotifyPropertyChanged
	{
		private Student_External_Transcript_Data_LoadObjectType external_Student_Transcript_Data_Load_ReferenceField;

		private StudentObjectType[] student_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_Transcript_Data_LoadObjectType External_Student_Transcript_Data_Load_Reference
		{
			get
			{
				return this.external_Student_Transcript_Data_Load_ReferenceField;
			}
			set
			{
				this.external_Student_Transcript_Data_Load_ReferenceField = value;
				this.RaisePropertyChanged("External_Student_Transcript_Data_Load_Reference");
			}
		}

		[XmlElement("Student_Reference", Order = 1)]
		public StudentObjectType[] Student_Reference
		{
			get
			{
				return this.student_ReferenceField;
			}
			set
			{
				this.student_ReferenceField = value;
				this.RaisePropertyChanged("Student_Reference");
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
