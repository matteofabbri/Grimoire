using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Qualification_DataType : INotifyPropertyChanged
	{
		private Job_HistoryType[] job_HistoryField;

		private EducationType[] educationField;

		private Work_Experience_DataType[] work_ExperienceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Job_History", Order = 0)]
		public Job_HistoryType[] Job_History
		{
			get
			{
				return this.job_HistoryField;
			}
			set
			{
				this.job_HistoryField = value;
				this.RaisePropertyChanged("Job_History");
			}
		}

		[XmlElement("Education", Order = 1)]
		public EducationType[] Education
		{
			get
			{
				return this.educationField;
			}
			set
			{
				this.educationField = value;
				this.RaisePropertyChanged("Education");
			}
		}

		[XmlElement("Work_Experience", Order = 2)]
		public Work_Experience_DataType[] Work_Experience
		{
			get
			{
				return this.work_ExperienceField;
			}
			set
			{
				this.work_ExperienceField = value;
				this.RaisePropertyChanged("Work_Experience");
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
