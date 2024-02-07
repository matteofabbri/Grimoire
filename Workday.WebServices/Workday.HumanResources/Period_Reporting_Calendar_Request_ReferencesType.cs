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
	public class Period_Reporting_Calendar_Request_ReferencesType : INotifyPropertyChanged
	{
		private Period_Reporting_CalendarObjectType[] period_Reporting_Calendar_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Period_Reporting_Calendar_Reference", Order = 0)]
		public Period_Reporting_CalendarObjectType[] Period_Reporting_Calendar_Reference
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
