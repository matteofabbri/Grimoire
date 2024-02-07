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
	public class Job_PostingType : INotifyPropertyChanged
	{
		private Job_PostingObjectType job_Posting_ReferenceField;

		private Job_Posting_Data_WWSType job_Posting_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_PostingObjectType Job_Posting_Reference
		{
			get
			{
				return this.job_Posting_ReferenceField;
			}
			set
			{
				this.job_Posting_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_Posting_Data_WWSType Job_Posting_Data
		{
			get
			{
				return this.job_Posting_DataField;
			}
			set
			{
				this.job_Posting_DataField = value;
				this.RaisePropertyChanged("Job_Posting_Data");
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
