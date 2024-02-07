using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_ScheduleType : INotifyPropertyChanged
	{
		private Period_ScheduleObjectType period_Schedule_ReferenceField;

		private Period_Schedule_DataType period_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_ScheduleObjectType Period_Schedule_Reference
		{
			get
			{
				return this.period_Schedule_ReferenceField;
			}
			set
			{
				this.period_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Period_Schedule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Period_Schedule_DataType Period_Schedule_Data
		{
			get
			{
				return this.period_Schedule_DataField;
			}
			set
			{
				this.period_Schedule_DataField = value;
				this.RaisePropertyChanged("Period_Schedule_Data");
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
