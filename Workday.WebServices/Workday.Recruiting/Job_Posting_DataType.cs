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
	public class Job_Posting_DataType : INotifyPropertyChanged
	{
		private Job_PostingObjectType job_Posting_ReferenceField;

		private Job_Posting_SiteObjectType job_Posting_Site_ReferenceField;

		private bool primary_PostingField;

		private bool primary_PostingFieldSpecified;

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
		public Job_Posting_SiteObjectType Job_Posting_Site_Reference
		{
			get
			{
				return this.job_Posting_Site_ReferenceField;
			}
			set
			{
				this.job_Posting_Site_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Primary_Posting
		{
			get
			{
				return this.primary_PostingField;
			}
			set
			{
				this.primary_PostingField = value;
				this.RaisePropertyChanged("Primary_Posting");
			}
		}

		[XmlIgnore]
		public bool Primary_PostingSpecified
		{
			get
			{
				return this.primary_PostingFieldSpecified;
			}
			set
			{
				this.primary_PostingFieldSpecified = value;
				this.RaisePropertyChanged("Primary_PostingSpecified");
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
