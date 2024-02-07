using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Previous_System_Compensation_HistoryType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Previous_System_Compensation_History_DataType[] previous_System_Job_HistoryField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Previous_System_Job_History", Order = 1)]
		public Previous_System_Compensation_History_DataType[] Previous_System_Job_History
		{
			get
			{
				return this.previous_System_Job_HistoryField;
			}
			set
			{
				this.previous_System_Job_HistoryField = value;
				this.RaisePropertyChanged("Previous_System_Job_History");
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
