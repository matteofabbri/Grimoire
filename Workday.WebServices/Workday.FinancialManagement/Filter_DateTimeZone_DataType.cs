using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Filter_DateTimeZone_DataType : INotifyPropertyChanged
	{
		private DateTime filter_DateTimeField;

		private bool filter_DateTimeFieldSpecified;

		private Time_ZoneObjectType filter_TimeZone_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public DateTime Filter_DateTime
		{
			get
			{
				return this.filter_DateTimeField;
			}
			set
			{
				this.filter_DateTimeField = value;
				this.RaisePropertyChanged("Filter_DateTime");
			}
		}

		[XmlIgnore]
		public bool Filter_DateTimeSpecified
		{
			get
			{
				return this.filter_DateTimeFieldSpecified;
			}
			set
			{
				this.filter_DateTimeFieldSpecified = value;
				this.RaisePropertyChanged("Filter_DateTimeSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Time_ZoneObjectType Filter_TimeZone_Reference
		{
			get
			{
				return this.filter_TimeZone_ReferenceField;
			}
			set
			{
				this.filter_TimeZone_ReferenceField = value;
				this.RaisePropertyChanged("Filter_TimeZone_Reference");
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
