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
	public class Usage_Billing_RateType : INotifyPropertyChanged
	{
		private Usage_Billing_RateObjectType usage_Billing_Rate_ReferenceField;

		private Usage_Billing_Rate_DataType usage_Billing_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Usage_Billing_RateObjectType Usage_Billing_Rate_Reference
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

		[XmlElement(Order = 1)]
		public Usage_Billing_Rate_DataType Usage_Billing_Rate_Data
		{
			get
			{
				return this.usage_Billing_Rate_DataField;
			}
			set
			{
				this.usage_Billing_Rate_DataField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Data");
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
