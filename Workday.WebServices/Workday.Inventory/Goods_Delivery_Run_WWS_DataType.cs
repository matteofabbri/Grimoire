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
	public class Goods_Delivery_Run_WWS_DataType : INotifyPropertyChanged
	{
		private string good_Delivery_Run_IDField;

		private Goods_DeliveryObjectType goods_Delivery_Ticket_ReferenceField;

		private bool confirm_DeliveryField;

		private bool confirm_DeliveryFieldSpecified;

		private bool attempt_DeliveryField;

		private bool attempt_DeliveryFieldSpecified;

		private WorkerObjectType received_By_ReferenceField;

		private LocationObjectType deliver_To_ReferenceField;

		private Goods_Delivery_Run_Line_DataType[] goods_Delivery_Run_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Good_Delivery_Run_ID
		{
			get
			{
				return this.good_Delivery_Run_IDField;
			}
			set
			{
				this.good_Delivery_Run_IDField = value;
				this.RaisePropertyChanged("Good_Delivery_Run_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public bool Confirm_Delivery
		{
			get
			{
				return this.confirm_DeliveryField;
			}
			set
			{
				this.confirm_DeliveryField = value;
				this.RaisePropertyChanged("Confirm_Delivery");
			}
		}

		[XmlIgnore]
		public bool Confirm_DeliverySpecified
		{
			get
			{
				return this.confirm_DeliveryFieldSpecified;
			}
			set
			{
				this.confirm_DeliveryFieldSpecified = value;
				this.RaisePropertyChanged("Confirm_DeliverySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Attempt_Delivery
		{
			get
			{
				return this.attempt_DeliveryField;
			}
			set
			{
				this.attempt_DeliveryField = value;
				this.RaisePropertyChanged("Attempt_Delivery");
			}
		}

		[XmlIgnore]
		public bool Attempt_DeliverySpecified
		{
			get
			{
				return this.attempt_DeliveryFieldSpecified;
			}
			set
			{
				this.attempt_DeliveryFieldSpecified = value;
				this.RaisePropertyChanged("Attempt_DeliverySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public WorkerObjectType Received_By_Reference
		{
			get
			{
				return this.received_By_ReferenceField;
			}
			set
			{
				this.received_By_ReferenceField = value;
				this.RaisePropertyChanged("Received_By_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public LocationObjectType Deliver_To_Reference
		{
			get
			{
				return this.deliver_To_ReferenceField;
			}
			set
			{
				this.deliver_To_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Reference");
			}
		}

		[XmlElement("Goods_Delivery_Run_Line_Data", Order = 6)]
		public Goods_Delivery_Run_Line_DataType[] Goods_Delivery_Run_Line_Data
		{
			get
			{
				return this.goods_Delivery_Run_Line_DataField;
			}
			set
			{
				this.goods_Delivery_Run_Line_DataField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_Line_Data");
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
