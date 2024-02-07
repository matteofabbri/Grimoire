using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Prepaid_Spend_Amortization_Schedule_Request_ReferencesType : INotifyPropertyChanged
	{
		private Prepaid_Spend_Amortization_ScheduleObjectType[] prepaid_Spend_Amortization_Schedule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Prepaid_Spend_Amortization_Schedule_Reference", Order = 0)]
		public Prepaid_Spend_Amortization_ScheduleObjectType[] Prepaid_Spend_Amortization_Schedule_Reference
		{
			get
			{
				return this.prepaid_Spend_Amortization_Schedule_ReferenceField;
			}
			set
			{
				this.prepaid_Spend_Amortization_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Prepaid_Spend_Amortization_Schedule_Reference");
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
