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
	public class Usage_Billing_Rate_Rule_Type_Group_DataType : INotifyPropertyChanged
	{
		private Billing_Rate_Rule_TypeObjectType usage_Billing_Rate_Rule_Type_ReferenceField;

		private Usage_Billing_Rate_Rule_DataType[] usage_Billing_Rate_Rule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_Rate_Rule_TypeObjectType Usage_Billing_Rate_Rule_Type_Reference
		{
			get
			{
				return this.usage_Billing_Rate_Rule_Type_ReferenceField;
			}
			set
			{
				this.usage_Billing_Rate_Rule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Rule_Type_Reference");
			}
		}

		[XmlElement("Usage_Billing_Rate_Rule_Data", Order = 1)]
		public Usage_Billing_Rate_Rule_DataType[] Usage_Billing_Rate_Rule_Data
		{
			get
			{
				return this.usage_Billing_Rate_Rule_DataField;
			}
			set
			{
				this.usage_Billing_Rate_Rule_DataField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Rule_Data");
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
