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
	public class Inventory_Shipment_Data_InboundType : INotifyPropertyChanged
	{
		private string inventory_Ship_List_IDField;

		private LocationObjectType inventory_Site_ReferenceField;

		private Inventory_Pick_ListObjectType inventory_Pick_List_ReferenceField;

		private WorkerObjectType assign_To_Worker_of_Inventory_Shipment_ReferenceField;

		private DateTime target_Fulfillment_DateField;

		private bool target_Fulfillment_DateFieldSpecified;

		private Unique_IdentifierObjectType tracking_ID_ReferenceField;

		private string tracking_IdField;

		private string shipTo_ContactField;

		private Unique_IdentifierObjectType ship_To_Address_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string document_MemoField;

		private Inventory_Shipment_Line_Inbound_DataType[] inventory_Shipment_Line_Data_Inbound_ElementField;

		private Business_Document_Attachment_with_External_Option_DataType[] attachment_ElementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Inventory_Ship_List_ID
		{
			get
			{
				return this.inventory_Ship_List_IDField;
			}
			set
			{
				this.inventory_Ship_List_IDField = value;
				this.RaisePropertyChanged("Inventory_Ship_List_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Inventory_Pick_ListObjectType Inventory_Pick_List_Reference
		{
			get
			{
				return this.inventory_Pick_List_ReferenceField;
			}
			set
			{
				this.inventory_Pick_List_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Pick_List_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public WorkerObjectType Assign_To_Worker_of_Inventory_Shipment_Reference
		{
			get
			{
				return this.assign_To_Worker_of_Inventory_Shipment_ReferenceField;
			}
			set
			{
				this.assign_To_Worker_of_Inventory_Shipment_ReferenceField = value;
				this.RaisePropertyChanged("Assign_To_Worker_of_Inventory_Shipment_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Target_Fulfillment_Date
		{
			get
			{
				return this.target_Fulfillment_DateField;
			}
			set
			{
				this.target_Fulfillment_DateField = value;
				this.RaisePropertyChanged("Target_Fulfillment_Date");
			}
		}

		[XmlIgnore]
		public bool Target_Fulfillment_DateSpecified
		{
			get
			{
				return this.target_Fulfillment_DateFieldSpecified;
			}
			set
			{
				this.target_Fulfillment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Target_Fulfillment_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Unique_IdentifierObjectType Tracking_ID_Reference
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

		[XmlElement(Order = 6)]
		public string Tracking_Id
		{
			get
			{
				return this.tracking_IdField;
			}
			set
			{
				this.tracking_IdField = value;
				this.RaisePropertyChanged("Tracking_Id");
			}
		}

		[XmlElement("Ship-To_Contact", Order = 7)]
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

		[XmlElement(Order = 8)]
		public Unique_IdentifierObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Document_Memo
		{
			get
			{
				return this.document_MemoField;
			}
			set
			{
				this.document_MemoField = value;
				this.RaisePropertyChanged("Document_Memo");
			}
		}

		[XmlElement("Inventory_Shipment_Line_Data_Inbound_Element", Order = 11)]
		public Inventory_Shipment_Line_Inbound_DataType[] Inventory_Shipment_Line_Data_Inbound_Element
		{
			get
			{
				return this.inventory_Shipment_Line_Data_Inbound_ElementField;
			}
			set
			{
				this.inventory_Shipment_Line_Data_Inbound_ElementField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Line_Data_Inbound_Element");
			}
		}

		[XmlElement("Attachment_Element", Order = 12)]
		public Business_Document_Attachment_with_External_Option_DataType[] Attachment_Element
		{
			get
			{
				return this.attachment_ElementField;
			}
			set
			{
				this.attachment_ElementField = value;
				this.RaisePropertyChanged("Attachment_Element");
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
