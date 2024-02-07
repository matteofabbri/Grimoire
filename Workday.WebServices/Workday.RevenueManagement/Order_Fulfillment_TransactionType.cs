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
	public class Order_Fulfillment_TransactionType : INotifyPropertyChanged
	{
		private Order_Fulfillment_TransactionObjectType order_Fulfillment_Transaction_ReferenceField;

		private Order_Fulfillment_Transaction_DataType[] order_Fulfillment_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Order_Fulfillment_TransactionObjectType Order_Fulfillment_Transaction_Reference
		{
			get
			{
				return this.order_Fulfillment_Transaction_ReferenceField;
			}
			set
			{
				this.order_Fulfillment_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Order_Fulfillment_Transaction_Reference");
			}
		}

		[XmlElement("Order_Fulfillment_Transaction_Data", Order = 1)]
		public Order_Fulfillment_Transaction_DataType[] Order_Fulfillment_Transaction_Data
		{
			get
			{
				return this.order_Fulfillment_Transaction_DataField;
			}
			set
			{
				this.order_Fulfillment_Transaction_DataField = value;
				this.RaisePropertyChanged("Order_Fulfillment_Transaction_Data");
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
