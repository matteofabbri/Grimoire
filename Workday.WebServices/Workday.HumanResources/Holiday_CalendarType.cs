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
	public class Holiday_CalendarType : INotifyPropertyChanged
	{
		private Holiday_CalendarObjectType holiday_Calendar_ReferenceField;

		private Holiday_Calendar_DataType holiday_Calendar_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Holiday_CalendarObjectType Holiday_Calendar_Reference
		{
			get
			{
				return this.holiday_Calendar_ReferenceField;
			}
			set
			{
				this.holiday_Calendar_ReferenceField = value;
				this.RaisePropertyChanged("Holiday_Calendar_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Holiday_Calendar_DataType Holiday_Calendar_Data
		{
			get
			{
				return this.holiday_Calendar_DataField;
			}
			set
			{
				this.holiday_Calendar_DataField = value;
				this.RaisePropertyChanged("Holiday_Calendar_Data");
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
