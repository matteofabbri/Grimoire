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
	public class Update_Job_Posting_DataType : INotifyPropertyChanged
	{
		private DateTime job_Posting_Start_DateField;

		private DateTime job_Posting_End_DateField;

		private bool job_Posting_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Job_Posting_Start_Date
		{
			get
			{
				return this.job_Posting_Start_DateField;
			}
			set
			{
				this.job_Posting_Start_DateField = value;
				this.RaisePropertyChanged("Job_Posting_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Job_Posting_End_Date
		{
			get
			{
				return this.job_Posting_End_DateField;
			}
			set
			{
				this.job_Posting_End_DateField = value;
				this.RaisePropertyChanged("Job_Posting_End_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_End_DateSpecified
		{
			get
			{
				return this.job_Posting_End_DateFieldSpecified;
			}
			set
			{
				this.job_Posting_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_End_DateSpecified");
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
