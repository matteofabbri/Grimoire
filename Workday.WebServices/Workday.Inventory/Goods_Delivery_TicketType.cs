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
	public class Goods_Delivery_TicketType : INotifyPropertyChanged
	{
		private Goods_DeliveryObjectType goods_Delivery_Ticket_ReferenceField;

		private Goods_Delivery_Ticket_outbound_DataType[] goods_Delivery_Ticket_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Goods_DeliveryObjectType Goods_Delivery_Ticket_Reference
		{
			get
			{
				return this.goods_Delivery_Ticket_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Ticket_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Reference");
			}
		}

		[XmlElement("Goods_Delivery_Ticket_Data", Order = 1)]
		public Goods_Delivery_Ticket_outbound_DataType[] Goods_Delivery_Ticket_Data
		{
			get
			{
				return this.goods_Delivery_Ticket_DataField;
			}
			set
			{
				this.goods_Delivery_Ticket_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Data");
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
