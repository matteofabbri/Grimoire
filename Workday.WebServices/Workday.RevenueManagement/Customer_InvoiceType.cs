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
	public class Customer_InvoiceType : INotifyPropertyChanged
	{
		private Customer_InvoiceObjectType customer_Invoice_ReferenceField;

		private Customer_Invoice_WWS_DataType customer_Invoice_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_InvoiceObjectType Customer_Invoice_Reference
		{
			get
			{
				return this.customer_Invoice_ReferenceField;
			}
			set
			{
				this.customer_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Customer_Invoice_WWS_DataType Customer_Invoice_Data
		{
			get
			{
				return this.customer_Invoice_DataField;
			}
			set
			{
				this.customer_Invoice_DataField = value;
				this.RaisePropertyChanged("Customer_Invoice_Data");
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
