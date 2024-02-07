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
	public class Inventory_Pick_List_DataType : INotifyPropertyChanged
	{
		private Document_StatusObjectType document_Status_ReferenceField;

		private Inventory_Pick_ListObjectType inventory_Picking_List_ReferenceField;

		private string document_NumberField;

		private LocationObjectType inventory_Site_Location_ReferenceField;

		private Inventory_Stock_RequestObjectType inventory_Stock_Request_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Inventory_Stock_Request_Transaction_TypeObjectType inventory_Stock_Request_Transaction_Type_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType inventory_Stock_Request_Type_ReferenceField;

		private LocationObjectType inventory_Par_Location_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private DateTime fulfillment_DateField;

		private bool fulfillment_DateFieldSpecified;

		private bool has_PriorityField;

		private bool has_PriorityFieldSpecified;

		private WorkerObjectType xMLNAME__Worker__Assigned_ReferenceField;

		private WorkerObjectType xMLNAME__Worker__Created_By_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string shipTo_ContactField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private string memoField;

		private Stock_Request_Lines_for_Inventory_Pick_List_DataType[] stock_Request_Lines_for_Inventory_Pick_List_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public string Document_Number
		{
			get
			{
				return this.document_NumberField;
			}
			set
			{
				this.document_NumberField = value;
				this.RaisePropertyChanged("Document_Number");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Inventory_Site_Location_Reference
		{
			get
			{
				return this.inventory_Site_Location_ReferenceField;
			}
			set
			{
				this.inventory_Site_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Location_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Inventory_Stock_Request_Transaction_TypeObjectType Inventory_Stock_Request_Transaction_Type_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Transaction_Type_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Transaction_Type_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public WorkerObjectType XMLNAME__Worker__Assigned_Reference
		{
			get
			{
				return this.xMLNAME__Worker__Assigned_ReferenceField;
			}
			set
			{
				this.xMLNAME__Worker__Assigned_ReferenceField = value;
				this.RaisePropertyChanged("XMLNAME__Worker__Assigned_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public WorkerObjectType XMLNAME__Worker__Created_By_Reference
		{
			get
			{
				return this.xMLNAME__Worker__Created_By_ReferenceField;
			}
			set
			{
				this.xMLNAME__Worker__Created_By_ReferenceField = value;
				this.RaisePropertyChanged("XMLNAME__Worker__Created_By_Reference");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement("Ship-To_Contact", Order = 15)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement("Stock_Request_Lines_for_Inventory_Pick_List_Data", Order = 18)]
		public Stock_Request_Lines_for_Inventory_Pick_List_DataType[] Stock_Request_Lines_for_Inventory_Pick_List_Data
		{
			get
			{
				return this.stock_Request_Lines_for_Inventory_Pick_List_DataField;
			}
			set
			{
				this.stock_Request_Lines_for_Inventory_Pick_List_DataField = value;
				this.RaisePropertyChanged("Stock_Request_Lines_for_Inventory_Pick_List_Data");
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
