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
	public class Award_Schedule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Award_ScheduleObjectType[] award_Schedule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Award_Schedule_Reference", Order = 0)]
		public Award_ScheduleObjectType[] Award_Schedule_Reference
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
