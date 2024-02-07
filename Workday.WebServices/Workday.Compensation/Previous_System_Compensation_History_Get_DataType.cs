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
	public class Previous_System_Compensation_History_Get_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Previous_System_Compensation_HistoryType[] previous_System_Compensation_History_DataField;

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

		[XmlElement("Previous_System_Compensation_History_Data", Order = 1)]
		public Previous_System_Compensation_HistoryType[] Previous_System_Compensation_History_Data
		{
			get
			{
				return this.previous_System_Compensation_History_DataField;
			}
			set
			{
				this.previous_System_Compensation_History_DataField = value;
				this.RaisePropertyChanged("Previous_System_Compensation_History_Data");
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
