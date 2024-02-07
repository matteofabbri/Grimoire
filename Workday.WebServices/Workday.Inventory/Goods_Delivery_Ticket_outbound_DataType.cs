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
	public class Goods_Delivery_Ticket_outbound_DataType : INotifyPropertyChanged
	{
		private string goods_Delivery_Ticket_IDField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private Inventory_Stock_Request_OriginObjectType goods_Delivery_Ticket_Origin_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private Goods_Delivery_Line_outbound_DataType[] goods_Delivery_Ticket_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goods_Delivery_Ticket_ID
		{
			get
			{
				return this.goods_Delivery_Ticket_IDField;
			}
			set
			{
				this.goods_Delivery_Ticket_IDField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_ID");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Inventory_Stock_Request_OriginObjectType Goods_Delivery_Ticket_Origin_Reference
		{
			get
			{
				return this.goods_Delivery_Ticket_Origin_ReferenceField;
			}
			set
			{
				this.goods_Delivery_Ticket_Origin_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Origin_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
			}
		}

		[XmlElement("Goods_Delivery_Ticket_Line_Data", Order = 4)]
		public Goods_Delivery_Line_outbound_DataType[] Goods_Delivery_Ticket_Line_Data
		{
			get
			{
				return this.goods_Delivery_Ticket_Line_DataField;
			}
			set
			{
				this.goods_Delivery_Ticket_Line_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Ticket_Line_Data");
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
