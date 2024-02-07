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
	public class Usage_Billing_Rate_Request_ReferencesType : INotifyPropertyChanged
	{
		private Usage_Billing_RateObjectType[] usage_Billing_Rate_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Usage_Billing_Rate_Reference", Order = 0)]
		public Usage_Billing_RateObjectType[] Usage_Billing_Rate_Reference
		{
			get
			{
				return this.usage_Billing_Rate_ReferenceField;
			}
			set
			{
				this.usage_Billing_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Reference");
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
