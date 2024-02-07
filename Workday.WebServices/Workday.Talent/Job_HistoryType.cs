using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_HistoryType : INotifyPropertyChanged
	{
		private Job_HistoryObjectType job_History_ReferenceField;

		private Job_History_Achievement_DataType[] job_History_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_HistoryObjectType Job_History_Reference
		{
			get
			{
				return this.job_History_ReferenceField;
			}
			set
			{
				this.job_History_ReferenceField = value;
				this.RaisePropertyChanged("Job_History_Reference");
			}
		}

		[XmlElement("Job_History_Data", Order = 1)]
		public Job_History_Achievement_DataType[] Job_History_Data
		{
			get
			{
				return this.job_History_DataField;
			}
			set
			{
				this.job_History_DataField = value;
				this.RaisePropertyChanged("Job_History_Data");
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
