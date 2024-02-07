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
	public class Customer_Invoice_Adjustment_Refund_Subedit_DataType : INotifyPropertyChanged
	{
		private Customer_Invoice_AdjustmentObjectType customer_Invoice_Adjustment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Customer_Invoice_AdjustmentObjectType Customer_Invoice_Adjustment_Reference
		{
			get
			{
				return this.customer_Invoice_Adjustment_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Adjustment_Reference");
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
