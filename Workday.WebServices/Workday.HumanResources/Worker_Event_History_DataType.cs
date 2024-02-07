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
	public class Worker_Event_History_DataType : INotifyPropertyChanged
	{
		private Effective_And_Updated_DateTime_DataType event_Date_Range_DataField;

		private Event_History_DataType[] event_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Effective_And_Updated_DateTime_DataType Event_Date_Range_Data
		{
			get
			{
				return this.event_Date_Range_DataField;
			}
			set
			{
				this.event_Date_Range_DataField = value;
				this.RaisePropertyChanged("Event_Date_Range_Data");
			}
		}

		[XmlElement("Event_Data", Order = 1)]
		public Event_History_DataType[] Event_Data
		{
			get
			{
				return this.event_DataField;
			}
			set
			{
				this.event_DataField = value;
				this.RaisePropertyChanged("Event_Data");
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
