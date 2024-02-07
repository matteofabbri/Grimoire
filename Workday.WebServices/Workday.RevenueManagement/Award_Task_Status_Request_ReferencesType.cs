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
	public class Award_Task_Status_Request_ReferencesType : INotifyPropertyChanged
	{
		private Award_Task_StatusObjectType[] award_Task_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Award_Task_Status_Reference", Order = 0)]
		public Award_Task_StatusObjectType[] Award_Task_Status_Reference
		{
			get
			{
				return this.award_Task_Status_ReferenceField;
			}
			set
			{
				this.award_Task_Status_ReferenceField = value;
				this.RaisePropertyChanged("Award_Task_Status_Reference");
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
