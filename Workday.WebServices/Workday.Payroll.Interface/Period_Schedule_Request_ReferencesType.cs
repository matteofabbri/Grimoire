using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Schedule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Period_ScheduleObjectType[] period_Schedule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Period_Schedule_Reference", Order = 0)]
		public Period_ScheduleObjectType[] Period_Schedule_Reference
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
