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
	public class Inventory_Shipment_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private Inventory_Stock_RequestObjectType inventory_Stock_Request_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType inventory_Stock_Request_Type_ReferenceField;

		private Inventory_Stock_Request_Transaction_TypeObjectType order_Type_ReferenceField;

		private LocationObjectType transfer_To_Inventory_Site_ReferenceField;

		private WorkerObjectType assigned_to_Worker_ReferenceField;

		private Inventory_Stock_Request_OriginObjectType inventory_Stock_Request_Origin_ReferenceField;

		private Inventory_Pick_ListObjectType inventory_Picking_List_ReferenceField;

		private WorkerObjectType creator__Worker__ReferenceField;

		private LocationObjectType inventory_Par_Location_ReferenceField;

		private WorkerObjectType requester__Worker__ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private DateTime fulfillment_DateField;

		private bool fulfillment_DateFieldSpecified;

		private bool has_PriorityField;

		private bool has_PriorityFieldSpecified;

		private Unique_IdentifierObjectType[] tracking_ID_ReferenceField;

		private string shipTo_ContactField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private string memoField;

		private Inventory_Shipment_List_Line_DataType[] inventory_Shipment_Line_Data_ElementField;

		private Business_Document_Attachment_with_External_Option_DataType[] business_Document_Attachment_ElementField;

		private CompanyObjectType company_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Inventory_Stock_RequestObjectType Inventory_Stock_Request_Reference
		{
			get
			{
				return this.inventory_Stock_Request_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Inventory_Stock_Request_TypeObjectType Inventory_Stock_Request_Type_Reference
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

		[XmlElement(Order = 5)]
		public Inventory_Stock_Request_Transaction_TypeObjectType Order_Type_Reference
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

		[XmlElement(Order = 6)]
		public LocationObjectType Transfer_To_Inventory_Site_Reference
		{
			get
			{
				return this.transfer_To_Inventory_Site_ReferenceField;
			}
			set
			{
				this.transfer_To_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Transfer_To_Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Assigned_to_Worker_Reference
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

		[XmlElement(Order = 8)]
		public Inventory_Stock_Request_OriginObjectType Inventory_Stock_Request_Origin_Reference
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

		[XmlElement(Order = 9)]
		public Inventory_Pick_ListObjectType Inventory_Picking_List_Reference
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

		[XmlElement(Order = 10)]
		public WorkerObjectType Creator__Worker__Reference
		{
			get
			{
				return this.creator__Worker__ReferenceField;
			}
			set
			{
				this.creator__Worker__ReferenceField = value;
				this.RaisePropertyChanged("Creator__Worker__Reference");
			}
		}

		[XmlElement(Order = 11)]
		public LocationObjectType Inventory_Par_Location_Reference
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

		[XmlElement(Order = 12)]
		public WorkerObjectType Requester__Worker__Reference
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

		[XmlElement(Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlIgnore]
		public bool Document_DateSpecified
		{
			get
			{
				return this.document_DateFieldSpecified;
			}
			set
			{
				this.document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Document_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Fulfillment_Date
		{
			get
			{
				return this.fulfillment_DateField;
			}
			set
			{
				this.fulfillment_DateField = value;
				this.RaisePropertyChanged("Fulfillment_Date");
			}
		}

		[XmlIgnore]
		public bool Fulfillment_DateSpecified
		{
			get
			{
				return this.fulfillment_DateFieldSpecified;
			}
			set
			{
				this.fulfillment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Fulfillment_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Has_Priority
		{
			get
			{
				return this.has_PriorityField;
			}
			set
			{
				this.has_PriorityField = value;
				this.RaisePropertyChanged("Has_Priority");
			}
		}

		[XmlIgnore]
		public bool Has_PrioritySpecified
		{
			get
			{
				return this.has_PriorityFieldSpecified;
			}
			set
			{
				this.has_PriorityFieldSpecified = value;
				this.RaisePropertyChanged("Has_PrioritySpecified");
			}
		}

		[XmlElement("Tracking_ID_Reference", Order = 17)]
		public Unique_IdentifierObjectType[] Tracking_ID_Reference
		{
			get
			{
				return this.tracking_ID_ReferenceField;
			}
			set
			{
				this.tracking_ID_ReferenceField = value;
				this.RaisePropertyChanged("Tracking_ID_Reference");
			}
		}

		[XmlElement("Ship-To_Contact", Order = 18)]
		public string ShipTo_Contact
		{
			get
			{
				return this.shipTo_ContactField;
			}
			set
			{
				this.shipTo_ContactField = value;
				this.RaisePropertyChanged("ShipTo_Contact");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 19)]
		public Unique_IdentifierObjectType ShipTo_Address_Reference
		{
			get
			{
				return this.shipTo_Address_ReferenceField;
			}
			set
			{
				this.shipTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Address_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Inventory_Shipment_Line_Data_Element", Order = 21)]
		public Inventory_Shipment_List_Line_DataType[] Inventory_Shipment_Line_Data_Element
		{
			get
			{
				return this.inventory_Shipment_Line_Data_ElementField;
			}
			set
			{
				this.inventory_Shipment_Line_Data_ElementField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Line_Data_Element");
			}
		}

		[XmlElement("Business_Document_Attachment_Element", Order = 22)]
		public Business_Document_Attachment_with_External_Option_DataType[] Business_Document_Attachment_Element
		{
			get
			{
				return this.business_Document_Attachment_ElementField;
			}
			set
			{
				this.business_Document_Attachment_ElementField = value;
				this.RaisePropertyChanged("Business_Document_Attachment_Element");
			}
		}

		[XmlElement(Order = 23)]
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
