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
	public class Holiday_Calendar_Request_ReferencesType : INotifyPropertyChanged
	{
		private Holiday_CalendarObjectType[] holiday_Calendar_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Holiday_Calendar_Request_Reference", Order = 0)]
		public Holiday_CalendarObjectType[] Holiday_Calendar_Request_Reference
		{
			get
			{
				return this.holiday_Calendar_Request_ReferenceField;
			}
			set
			{
				this.holiday_Calendar_Request_ReferenceField = value;
				this.RaisePropertyChanged("Holiday_Calendar_Request_Reference");
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
