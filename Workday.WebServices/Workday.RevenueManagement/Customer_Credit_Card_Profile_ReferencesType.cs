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
	public class Customer_Credit_Card_Profile_ReferencesType : INotifyPropertyChanged
	{
		private Customer_Credit_Card_ProfileObjectType[] merchant_Customer_Profile_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Merchant_Customer_Profile_Reference", Order = 0)]
		public Customer_Credit_Card_ProfileObjectType[] Merchant_Customer_Profile_Reference
		{
			get
			{
				return this.merchant_Customer_Profile_ReferenceField;
			}
			set
			{
				this.merchant_Customer_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_Reference");
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
