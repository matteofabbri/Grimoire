using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Application_DataType : INotifyPropertyChanged
	{
		private Candidate_Job_Applied_To_DataType[] job_Applied_To_DataField;

		private Attachment_WWS_DataType[] resume_Attachment_DataField;

		private Candidate_Resume_DataType resume_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Job_Applied_To_Data", Order = 0)]
		public Candidate_Job_Applied_To_DataType[] Job_Applied_To_Data
		{
			get
			{
				return this.job_Applied_To_DataField;
			}
			set
			{
				this.job_Applied_To_DataField = value;
				this.RaisePropertyChanged("Job_Applied_To_Data");
			}
		}

		[XmlElement("Resume_Attachment_Data", Order = 1)]
		public Attachment_WWS_DataType[] Resume_Attachment_Data
		{
			get
			{
				return this.resume_Attachment_DataField;
			}
			set
			{
				this.resume_Attachment_DataField = value;
				this.RaisePropertyChanged("Resume_Attachment_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Candidate_Resume_DataType Resume_Data
		{
			get
			{
				return this.resume_DataField;
			}
			set
			{
				this.resume_DataField = value;
				this.RaisePropertyChanged("Resume_Data");
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
