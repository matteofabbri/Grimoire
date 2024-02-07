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
	public class External_Student_Transcript_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Student_External_Transcript_Student_Prospect_DataType[] student_Prospect_DataField;

		private Student_External_Transcripts_Educational_Institution_Subedit_DataType student_External_Transcript_Educational_Institution_DataField;

		private Student_External_Transcript_Summary_DataType student_External_Transcript_Summary_DataField;

		private Student_External_PostSecondary_Transcript_Summary_DataType student_External_Postsecondary_Transcript_Summary_DataField;

		private Student_External_Secondary_Transcript_Summary_DataType student_External_Secondary_Transcript_Summary_DataField;

		private Student_External_Transcript_External_Credential_DataType[] student_External_Transcript_External_Credential_DataField;

		private Student_External_Transcript_Course_History_DataType[] student_External_Transcript_Course_History_DataField;

		private Student_Transcript_Drag_and_Drop_Subedit_DataType[] student_External_Transcript_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Student_Prospect_Data", Order = 1)]
		public Student_External_Transcript_Student_Prospect_DataType[] Student_Prospect_Data
		{
			get
			{
				return this.student_Prospect_DataField;
			}
			set
			{
				this.student_Prospect_DataField = value;
				this.RaisePropertyChanged("Student_Prospect_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Student_External_Transcripts_Educational_Institution_Subedit_DataType Student_External_Transcript_Educational_Institution_Data
		{
			get
			{
				return this.student_External_Transcript_Educational_Institution_DataField;
			}
			set
			{
				this.student_External_Transcript_Educational_Institution_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Educational_Institution_Data");
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
		public Student_External_PostSecondary_Transcript_Summary_DataType Student_External_Postsecondary_Transcript_Summary_Data
		{
			get
			{
				return this.student_External_Postsecondary_Transcript_Summary_DataField;
			}
			set
			{
				this.student_External_Postsecondary_Transcript_Summary_DataField = value;
				this.RaisePropertyChanged("Student_External_Postsecondary_Transcript_Summary_Data");
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

		[XmlElement("Student_External_Transcript_Attachment_Data", Order = 8)]
		public Student_Transcript_Drag_and_Drop_Subedit_DataType[] Student_External_Transcript_Attachment_Data
		{
			get
			{
				return this.student_External_Transcript_Attachment_DataField;
			}
			set
			{
				this.student_External_Transcript_Attachment_DataField = value;
				this.RaisePropertyChanged("Student_External_Transcript_Attachment_Data");
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
