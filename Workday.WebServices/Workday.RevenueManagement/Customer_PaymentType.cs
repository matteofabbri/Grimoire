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
	public class Customer_PaymentType : INotifyPropertyChanged
	{
		private Customer_PaymentObjectType customer_Payment_ReferenceField;

		private Customer_Payment_for_Invoices_WWS_DataType customer_Payment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_PaymentObjectType Customer_Payment_Reference
		{
			get
			{
				return this.customer_Payment_ReferenceField;
			}
			set
			{
				this.customer_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Payment_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Payment_for_Invoices_WWS_DataType Customer_Payment_Data
		{
			get
			{
				return this.customer_Payment_DataField;
			}
			set
			{
				this.customer_Payment_DataField = value;
				this.RaisePropertyChanged("Customer_Payment_Data");
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
