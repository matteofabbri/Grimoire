using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Goods_Delivery_Ticket_Request_ReferencesType : INotifyPropertyChanged
	{
		private Goods_DeliveryObjectType[] goods_Delivery_Ticket_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Goods_Delivery_Ticket_Request_Reference", Order = 0)]
		public Goods_DeliveryObjectType[] Goods_Delivery_Ticket_Request_Reference
		{
			get
			{
				return this.goods_Delivery_Ticket_Request_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Ticket_Request_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Request_Reference");
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
