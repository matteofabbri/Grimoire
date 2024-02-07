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
	public class Inventory_Shipment_Request_CriteriaType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private string inventory_Shipment_IDField;

		private Inventory_Pick_ListObjectType[] inventory_Picking_List_ReferenceField;

		private DateTime order_Date_On_or_AfterField;

		private bool order_Date_On_or_AfterFieldSpecified;

		private DateTime order_Date_On_or_BeforeField;

		private bool order_Date_On_or_BeforeFieldSpecified;

		private DateTime targeted_Fulfillment_Date_On_or_AfterField;

		private bool targeted_Fulfillment_Date_On_or_AfterFieldSpecified;

		private DateTime targeted_Fulfillment_Date_On_or_BeforeField;

		private bool targeted_Fulfillment_Date_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] inventory_Ship_List_Status_ReferenceField;

		private Inventory_Stock_Request_Transaction_TypeObjectType[] order_Type_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType[] inventory_Stock_Request_Type_ReferenceField;

		private LocationObjectType[] inventory_Par_Location_ReferenceField;

		private LocationObjectType[] transfer_to_Inventory_Site_ReferenceField;

		private WorkerObjectType[] requester__Worker__ReferenceField;

		private LocationObjectType[] deliver_To_Location_ReferenceField;

		private WorkerObjectType[] assigned_to_Worker_ReferenceField;

		private Inventory_Stock_Request_OriginObjectType[] inventory_Stock_Request_Origin_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Inventory_Shipment_ID
		{
			get
			{
				return this.inventory_Shipment_IDField;
			}
			set
			{
				this.inventory_Shipment_IDField = value;
				this.RaisePropertyChanged("Inventory_Shipment_ID");
			}
		}

		[XmlElement("Inventory_Picking_List_Reference", Order = 2)]
		public Inventory_Pick_ListObjectType[] Inventory_Picking_List_Reference
		{
			get
			{
				return this.inventory_Picking_List_ReferenceField;
			}
			set
			{
				this.inventory_Picking_List_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Picking_List_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Order_Date_On_or_After
		{
			get
			{
				return this.order_Date_On_or_AfterField;
			}
			set
			{
				this.order_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Order_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_AfterSpecified
		{
			get
			{
				return this.order_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Order_Date_On_or_Before
		{
			get
			{
				return this.order_Date_On_or_BeforeField;
			}
			set
			{
				this.order_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Order_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Order_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.order_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.order_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Order_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Targeted_Fulfillment_Date_On_or_After
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_AfterField;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Targeted_Fulfillment_Date_On_or_AfterSpecified
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Targeted_Fulfillment_Date_On_or_Before
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_BeforeField;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Targeted_Fulfillment_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.targeted_Fulfillment_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.targeted_Fulfillment_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Targeted_Fulfillment_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement("Inventory_Ship_List_Status_Reference", Order = 7)]
		public Document_StatusObjectType[] Inventory_Ship_List_Status_Reference
		{
			get
			{
				return this.inventory_Ship_List_Status_ReferenceField;
			}
			set
			{
				this.inventory_Ship_List_Status_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Ship_List_Status_Reference");
			}
		}

		[XmlElement("Order_Type_Reference", Order = 8)]
		public Inventory_Stock_Request_Transaction_TypeObjectType[] Order_Type_Reference
		{
			get
			{
				return this.order_Type_ReferenceField;
			}
			set
			{
				this.order_Type_ReferenceField = value;
				this.RaisePropertyChanged("Order_Type_Reference");
			}
		}

		[XmlElement("Inventory_Stock_Request_Type_Reference", Order = 9)]
		public Inventory_Stock_Request_TypeObjectType[] Inventory_Stock_Request_Type_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Type_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Type_Reference");
			}
		}

		[XmlElement("Inventory_Par_Location_Reference", Order = 10)]
		public LocationObjectType[] Inventory_Par_Location_Reference
		{
			get
			{
				return this.inventory_Par_Location_ReferenceField;
			}
			set
			{
				this.inventory_Par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Par_Location_Reference");
			}
		}

		[XmlElement("Transfer_to_Inventory_Site_Reference", Order = 11)]
		public LocationObjectType[] Transfer_to_Inventory_Site_Reference
		{
			get
			{
				return this.transfer_to_Inventory_Site_ReferenceField;
			}
			set
			{
				this.transfer_to_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_to_Inventory_Site_Reference");
			}
		}

		[XmlElement("Requester__Worker__Reference", Order = 12)]
		public WorkerObjectType[] Requester__Worker__Reference
		{
			get
			{
				return this.requester__Worker__ReferenceField;
			}
			set
			{
				this.requester__Worker__ReferenceField = value;
				this.RaisePropertyChanged("Requester__Worker__Reference");
			}
		}

		[XmlElement("Deliver_To_Location_Reference", Order = 13)]
		public LocationObjectType[] Deliver_To_Location_Reference
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

		[XmlElement("Assigned_to_Worker_Reference", Order = 14)]
		public WorkerObjectType[] Assigned_to_Worker_Reference
		{
			get
			{
				return this.assigned_to_Worker_ReferenceField;
			}
			set
			{
				this.assigned_to_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Assigned_to_Worker_Reference");
			}
		}

		[XmlElement("Inventory_Stock_Request_Origin_Reference", Order = 15)]
		public Inventory_Stock_Request_OriginObjectType[] Inventory_Stock_Request_Origin_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Origin_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Origin_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Origin_Reference");
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
