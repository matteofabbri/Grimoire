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
	public class Capture_Goods_Delivery_Run_Outbound_DataType : INotifyPropertyChanged
	{
		private string goods_Delivery_Run_IDField;

		private string goods_Delivery_RunField;

		private Goods_DeliveryObjectType goods_Delivery_ReferenceField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private DateTime created_OnField;

		private bool created_OnFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private WorkerObjectType assigned_To_ReferenceField;

		private Inventory_Stock_Request_OriginObjectType goods_Delivery_Ticket_Origin_ReferenceField;

		private bool attempt_DeliveryField;

		private bool attempt_DeliveryFieldSpecified;

		private bool confirm_DeliveryField;

		private bool confirm_DeliveryFieldSpecified;

		private Capture_Goods_Delivery_Run_Line_Outbound_DataType[] capture_Goods_Delivery_Run_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goods_Delivery_Run_ID
		{
			get
			{
				return this.goods_Delivery_Run_IDField;
			}
			set
			{
				this.goods_Delivery_Run_IDField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Goods_Delivery_Run
		{
			get
			{
				return this.goods_Delivery_RunField;
			}
			set
			{
				this.goods_Delivery_RunField = value;
				this.RaisePropertyChanged("Goods_Delivery_Run");
			}
		}

		[XmlElement(Order = 2)]
		public Goods_DeliveryObjectType Goods_Delivery_Reference
		{
			get
			{
				return this.goods_Delivery_ReferenceField;
			}
			set
			{
				this.goods_Delivery_ReferenceField = value;
				this.RaisePropertyChanged("Goods_Delivery_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Created_On
		{
			get
			{
				return this.created_OnField;
			}
			set
			{
				this.created_OnField = value;
				this.RaisePropertyChanged("Created_On");
			}
		}

		[XmlIgnore]
		public bool Created_OnSpecified
		{
			get
			{
				return this.created_OnFieldSpecified;
			}
			set
			{
				this.created_OnFieldSpecified = value;
				this.RaisePropertyChanged("Created_OnSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public WorkerObjectType Assigned_To_Reference
		{
			get
			{
				return this.assigned_To_ReferenceField;
			}
			set
			{
				this.assigned_To_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_To_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement("Capture_Goods_Delivery_Run_Line_Data", Order = 12)]
		public Capture_Goods_Delivery_Run_Line_Outbound_DataType[] Capture_Goods_Delivery_Run_Line_Data
		{
			get
			{
				return this.capture_Goods_Delivery_Run_Line_DataField;
			}
			set
			{
				this.capture_Goods_Delivery_Run_Line_DataField = value;
				this.RaisePropertyChanged("Capture_Goods_Delivery_Run_Line_Data");
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
