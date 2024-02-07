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
	public class Job_Posting_Site_DataType : INotifyPropertyChanged
	{
		private string idField;

		private object itemField;

		private DateTime job_Posting_Start_DateField;

		private DateTime job_Posting_End_DateField;

		private bool job_Posting_End_DateFieldSpecified;

		private bool primary_PostingField;

		private bool primary_PostingFieldSpecified;

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

		[XmlElement("Job_Posting_Site_Name", typeof(string), Order = 1), XmlElement("Job_Posting_Site_Reference", typeof(Job_Posting_SiteObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
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
