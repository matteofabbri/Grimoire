using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_ScheduleType : INotifyPropertyChanged
	{
		private Award_ScheduleObjectType award_Schedule_ReferenceField;

		private Award_Schedule_DataType[] award_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Award_ScheduleObjectType Award_Schedule_Reference
		{
			get
			{
				return this.award_Schedule_ReferenceField;
			}
			set
			{
				this.award_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Award_Schedule_Reference");
			}
		}

		[XmlElement("Award_Schedule_Data", Order = 1)]
		public Award_Schedule_DataType[] Award_Schedule_Data
		{
			get
			{
				return this.award_Schedule_DataField;
			}
			set
			{
				this.award_Schedule_DataField = value;
				this.RaisePropertyChanged("Award_Schedule_Data");
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
