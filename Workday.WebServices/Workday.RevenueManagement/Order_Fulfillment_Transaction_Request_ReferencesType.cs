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
	public class Order_Fulfillment_Transaction_Request_ReferencesType : INotifyPropertyChanged
	{
		private Order_Fulfillment_TransactionObjectType[] order_Fulfillment_Transaction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Order_Fulfillment_Transaction_Reference", Order = 0)]
		public Order_Fulfillment_TransactionObjectType[] Order_Fulfillment_Transaction_Reference
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
