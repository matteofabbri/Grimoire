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
	public class Update_Job_Posting_Business_Process_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private Update_Job_Posting_DataType[] job_Posting_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Job_Posting_Reference", typeof(Job_PostingObjectType), Order = 0), XmlElement("Job_Posting_Reference_Data", typeof(Job_Posting_Reference_DataType), Order = 0)]
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

		[XmlElement("Job_Posting_Data", Order = 1)]
		public Update_Job_Posting_DataType[] Job_Posting_Data
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
