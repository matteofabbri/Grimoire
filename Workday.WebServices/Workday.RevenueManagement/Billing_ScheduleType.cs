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
	public class Billing_ScheduleType : INotifyPropertyChanged
	{
		private Billing_ScheduleObjectType billing_Schedule_ReferenceField;

		private Billing_Schedule_DataType[] billing_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_ScheduleObjectType Billing_Schedule_Reference
		{
			get
			{
				return this.billing_Schedule_ReferenceField;
			}
			set
			{
				this.billing_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Schedule_Reference");
			}
		}

		[XmlElement("Billing_Schedule_Data", Order = 1)]
		public Billing_Schedule_DataType[] Billing_Schedule_Data
		{
			get
			{
				return this.billing_Schedule_DataField;
			}
			set
			{
				this.billing_Schedule_DataField = value;
				this.RaisePropertyChanged("Billing_Schedule_Data");
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
