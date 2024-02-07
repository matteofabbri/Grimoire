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
	public class Student_External_Transcript_Subedit_DataType : INotifyPropertyChanged
	{
		private Student_External_TranscriptObjectType student_External_Transcript_ReferenceField;

		private string idField;

		private Student_External_Transcripts_Educational_Institution_Subedit_DataType student_External_Transcript_Educational_Institution_Subedit_DataField;

		private Student_External_Transcript_Summary_DataType student_External_Transcript_Summary_DataField;

		private Student_External_PostSecondary_Transcript_Summary_DataType student_External_Post_Secondary_Transcript_Summary_DataField;

		private Student_External_Secondary_Transcript_Summary_DataType student_External_Secondary_Transcript_Summary_DataField;

		private Student_External_Transcript_External_Credential_DataType[] student_External_Transcript_External_Credential_DataField;

		private Student_External_Transcript_Course_History_DataType[] student_External_Transcript_Course_History_DataField;

		private Student_Transcript_Drag_and_Drop_Subedit_DataType[] student_External_Transcript_Drag_and_Drop_Subedit_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Student_External_TranscriptObjectType Student_External_Transcript_Reference
		{
			get
			{
				return this.student_External_Transcript_ReferenceField;
			}
			set
			{
				this.student_External_Transcript_ReferenceField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 2)]
		public Student_External_Transcripts_Educational_Institution_Subedit_DataType Student_External_Transcript_Educational_Institution_Subedit_Data
		{
			get
			{
				return this.student_External_Transcript_Educational_Institution_Subedit_DataField;
			}
			set
			{
				this.student_External_Transcript_Educational_Institution_Subedit_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Educational_Institution_Subedit_Data");
			}
		}

		[XmlElement(Order = 3)]
		public Student_External_Transcript_Summary_DataType Student_External_Transcript_Summary_Data
		{
			get
			{
				return this.student_External_Transcript_Summary_DataField;
			}
			set
			{
				this.student_External_Transcript_Summary_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Summary_Data");
			}
		}

		[XmlElement(Order = 4)]
		public Student_External_PostSecondary_Transcript_Summary_DataType Student_External_Post_Secondary_Transcript_Summary_Data
		{
			get
			{
				return this.student_External_Post_Secondary_Transcript_Summary_DataField;
			}
			set
			{
				this.student_External_Post_Secondary_Transcript_Summary_DataField = value;
				this.RaisePropertyChanged("Student_External_Post_Secondary_Transcript_Summary_Data");
			}
		}

		[XmlElement(Order = 5)]
		public Student_External_Secondary_Transcript_Summary_DataType Student_External_Secondary_Transcript_Summary_Data
		{
			get
			{
				return this.student_External_Secondary_Transcript_Summary_DataField;
			}
			set
			{
				this.student_External_Secondary_Transcript_Summary_DataField = value;
				this.RaisePropertyChanged("Student_External_Secondary_Transcript_Summary_Data");
			}
		}

		[XmlElement("Student_External_Transcript_External_Credential_Data", Order = 6)]
		public Student_External_Transcript_External_Credential_DataType[] Student_External_Transcript_External_Credential_Data
		{
			get
			{
				return this.student_External_Transcript_External_Credential_DataField;
			}
			set
			{
				this.student_External_Transcript_External_Credential_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_External_Credential_Data");
			}
		}

		[XmlElement("Student_External_Transcript_Course_History_Data", Order = 7)]
		public Student_External_Transcript_Course_History_DataType[] Student_External_Transcript_Course_History_Data
		{
			get
			{
				return this.student_External_Transcript_Course_History_DataField;
			}
			set
			{
				this.student_External_Transcript_Course_History_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Course_History_Data");
			}
		}

		[XmlElement("Student_External_Transcript_Drag_and_Drop_Subedit_Data", Order = 8)]
		public Student_Transcript_Drag_and_Drop_Subedit_DataType[] Student_External_Transcript_Drag_and_Drop_Subedit_Data
		{
			get
			{
				return this.student_External_Transcript_Drag_and_Drop_Subedit_DataField;
			}
			set
			{
				this.student_External_Transcript_Drag_and_Drop_Subedit_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Drag_and_Drop_Subedit_Data");
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
