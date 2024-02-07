using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Reporting_CalendarType : INotifyPropertyChanged
	{
		private Period_Reporting_CalendarObjectType period_Reporting_Calendar_ReferenceField;

		private Period_Reporting_Calendar_DataType[] period_Reporting_Calendar_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Reporting_CalendarObjectType Period_Reporting_Calendar_Reference
		{
			get
			{
				return this.period_Reporting_Calendar_ReferenceField;
			}
			set
			{
				this.period_Reporting_Calendar_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reporting_Calendar_Reference");
			}
		}

		[XmlElement("Period_Reporting_Calendar_Data", Order = 1)]
		public Period_Reporting_Calendar_DataType[] Period_Reporting_Calendar_Data
		{
			get
			{
				return this.period_Reporting_Calendar_DataField;
			}
			set
			{
				this.period_Reporting_Calendar_DataField = value;
				this.RaisePropertyChanged("Period_Reporting_Calendar_Data");
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
