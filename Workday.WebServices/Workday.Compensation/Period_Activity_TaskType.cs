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
	public class Period_Activity_TaskType : INotifyPropertyChanged
	{
		private Period_Activity_TaskObjectType period_Activity_Task_ReferenceField;

		private Period_Activity_Task_DataType[] period_Activity_Task_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Activity_TaskObjectType Period_Activity_Task_Reference
		{
			get
			{
				return this.period_Activity_Task_ReferenceField;
			}
			set
			{
				this.period_Activity_Task_ReferenceField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Reference");
			}
		}

		[XmlElement("Period_Activity_Task_Data", Order = 1)]
		public Period_Activity_Task_DataType[] Period_Activity_Task_Data
		{
			get
			{
				return this.period_Activity_Task_DataField;
			}
			set
			{
				this.period_Activity_Task_DataField = value;
				this.RaisePropertyChanged("Period_Activity_Task_Data");
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
