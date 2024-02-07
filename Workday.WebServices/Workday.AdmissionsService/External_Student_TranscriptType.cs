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
	public class External_Student_TranscriptType : INotifyPropertyChanged
	{
		private Student_External_TranscriptObjectType external_Student_Transcript_ReferenceField;

		private External_Student_Transcript_DataType[] student_External_Transcript_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_TranscriptObjectType External_Student_Transcript_Reference
		{
			get
			{
				return this.external_Student_Transcript_ReferenceField;
			}
			set
			{
				this.external_Student_Transcript_ReferenceField = value;
				this.RaisePropertyChanged("External_Student_Transcript_Reference");
			}
		}

		[XmlElement("Student_External_Transcript_Data", Order = 1)]
		public External_Student_Transcript_DataType[] Student_External_Transcript_Data
		{
			get
			{
				return this.student_External_Transcript_DataField;
			}
			set
			{
				this.student_External_Transcript_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Data");
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
