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
	public class Customer_Contract_Amendment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_Contract_AmendmentObjectType[] customer_Contract_Amendment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Contract_Amendment_Reference", Order = 0)]
		public Customer_Contract_AmendmentObjectType[] Customer_Contract_Amendment_Reference
		{
			get
			{
				return this.customer_Contract_Amendment_ReferenceField;
			}
			set
			{
				this.customer_Contract_Amendment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Contract_Amendment_Reference");
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
