using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Notification
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(Notification_DataRootType)), XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Notification_DataType : INotifyPropertyChanged
	{
		private Event_DataType event_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Event_DataType Event_Data
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
