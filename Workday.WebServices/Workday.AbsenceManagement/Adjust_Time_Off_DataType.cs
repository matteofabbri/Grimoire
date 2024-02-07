using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Adjust_Time_Off_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Adjust_Time_Off_Entry_DataType[] adjust_Time_Off_Entry_DataField;

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

		[XmlElement("Adjust_Time_Off_Entry_Data", Order = 1)]
		public Adjust_Time_Off_Entry_DataType[] Adjust_Time_Off_Entry_Data
		{
			get
			{
				return this.adjust_Time_Off_Entry_DataField;
			}
			set
			{
				this.adjust_Time_Off_Entry_DataField = value;
				this.RaisePropertyChanged("Adjust_Time_Off_Entry_Data");
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
