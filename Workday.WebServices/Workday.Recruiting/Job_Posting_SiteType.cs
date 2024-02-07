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
	public class Job_Posting_SiteType : INotifyPropertyChanged
	{
		private Job_Posting_SiteObjectType job_Posting_Site_ReferenceField;

		private Job_Posting_Site_Detail_DataType job_Posting_Site_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Job_Posting_Site_Detail_DataType Job_Posting_Site_Data
		{
			get
			{
				return this.job_Posting_Site_DataField;
			}
			set
			{
				this.job_Posting_Site_DataField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Data");
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
