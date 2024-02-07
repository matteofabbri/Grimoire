using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Requisition_DataType : INotifyPropertyChanged
	{
		private bool submitField;

		private bool submitFieldSpecified;

		private string requisition_NumberField;

		private Document_StatusObjectType requisition_Document_Status_ReferenceField;

		private DateTime requisition_DateField;

		private CurrencyObjectType requisition_Currency_ReferenceField;

		private Requisition_TypeObjectType requisition_Type_ReferenceField;

		private LocationObjectType par_Location_ReferenceField;

		private WorkerObjectType requisition_Sourcing_Buyer_ReferenceField;

		private LocationObjectType requesting_Inventory_Site_ReferenceField;

		private string originField;

		private CompanyObjectType company_ReferenceField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private string memo_to_SuppliersField;

		private string internal_MemoField;

		private Worker_Credit_CardObjectType procurement_Credit_Card_ReferenceField;

		private bool high_PriorityField;

		private bool high_PriorityFieldSpecified;

		private bool consolidate_Requisition_on_POField;

		private bool consolidate_Requisition_on_POFieldSpecified;

		private bool exclude_Ship_To_Address_When_Consolidating_Requisition_LinesField;

		private bool exclude_Ship_To_Address_When_Consolidating_Requisition_LinesFieldSpecified;

		private Item_Request_Line_DataType[] item_Request_Line_DataField;

		private Service_Request_Line_DataType[] service_Request_Line_DataField;

		private ProjectBased_Requisition_Line_DataType[] deliverables_Line_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] attachment_DataField;

		private Address_Information_DataType[] ad_Hoc_Address_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Requisition_Number
		{
			get
			{
				return this.requisition_NumberField;
			}
			set
			{
				this.requisition_NumberField = value;
				this.RaisePropertyChanged("Requisition_Number");
			}
		}

		[XmlElement(Order = 2)]
		public Document_StatusObjectType Requisition_Document_Status_Reference
		{
			get
			{
				return this.requisition_Document_Status_ReferenceField;
			}
			set
			{
				this.requisition_Document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Document_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Requisition_Date
		{
			get
			{
				return this.requisition_DateField;
			}
			set
			{
				this.requisition_DateField = value;
				this.RaisePropertyChanged("Requisition_Date");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Requisition_Currency_Reference
		{
			get
			{
				return this.requisition_Currency_ReferenceField;
			}
			set
			{
				this.requisition_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Currency_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Requisition_TypeObjectType Requisition_Type_Reference
		{
			get
			{
				return this.requisition_Type_ReferenceField;
			}
			set
			{
				this.requisition_Type_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public LocationObjectType Par_Location_Reference
		{
			get
			{
				return this.par_Location_ReferenceField;
			}
			set
			{
				this.par_Location_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public WorkerObjectType Requisition_Sourcing_Buyer_Reference
		{
			get
			{
				return this.requisition_Sourcing_Buyer_ReferenceField;
			}
			set
			{
				this.requisition_Sourcing_Buyer_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Sourcing_Buyer_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public LocationObjectType Requesting_Inventory_Site_Reference
		{
			get
			{
				return this.requesting_Inventory_Site_ReferenceField;
			}
			set
			{
				this.requesting_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Requesting_Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string Origin
		{
			get
			{
				return this.originField;
			}
			set
			{
				this.originField = value;
				this.RaisePropertyChanged("Origin");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
		public string Memo_to_Suppliers
		{
			get
			{
				return this.memo_to_SuppliersField;
			}
			set
			{
				this.memo_to_SuppliersField = value;
				this.RaisePropertyChanged("Memo_to_Suppliers");
			}
		}

		[XmlElement(Order = 14)]
		public string Internal_Memo
		{
			get
			{
				return this.internal_MemoField;
			}
			set
			{
				this.internal_MemoField = value;
				this.RaisePropertyChanged("Internal_Memo");
			}
		}

		[XmlElement(Order = 15)]
		public Worker_Credit_CardObjectType Procurement_Credit_Card_Reference
		{
			get
			{
				return this.procurement_Credit_Card_ReferenceField;
			}
			set
			{
				this.procurement_Credit_Card_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Credit_Card_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public bool High_Priority
		{
			get
			{
				return this.high_PriorityField;
			}
			set
			{
				this.high_PriorityField = value;
				this.RaisePropertyChanged("High_Priority");
			}
		}

		[XmlIgnore]
		public bool High_PrioritySpecified
		{
			get
			{
				return this.high_PriorityFieldSpecified;
			}
			set
			{
				this.high_PriorityFieldSpecified = value;
				this.RaisePropertyChanged("High_PrioritySpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Consolidate_Requisition_on_PO
		{
			get
			{
				return this.consolidate_Requisition_on_POField;
			}
			set
			{
				this.consolidate_Requisition_on_POField = value;
				this.RaisePropertyChanged("Consolidate_Requisition_on_PO");
			}
		}

		[XmlIgnore]
		public bool Consolidate_Requisition_on_POSpecified
		{
			get
			{
				return this.consolidate_Requisition_on_POFieldSpecified;
			}
			set
			{
				this.consolidate_Requisition_on_POFieldSpecified = value;
				this.RaisePropertyChanged("Consolidate_Requisition_on_POSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public bool Exclude_Ship_To_Address_When_Consolidating_Requisition_Lines
		{
			get
			{
				return this.exclude_Ship_To_Address_When_Consolidating_Requisition_LinesField;
			}
			set
			{
				this.exclude_Ship_To_Address_When_Consolidating_Requisition_LinesField = value;
				this.RaisePropertyChanged("Exclude_Ship_To_Address_When_Consolidating_Requisition_Lines");
			}
		}

		[XmlIgnore]
		public bool Exclude_Ship_To_Address_When_Consolidating_Requisition_LinesSpecified
		{
			get
			{
				return this.exclude_Ship_To_Address_When_Consolidating_Requisition_LinesFieldSpecified;
			}
			set
			{
				this.exclude_Ship_To_Address_When_Consolidating_Requisition_LinesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Ship_To_Address_When_Consolidating_Requisition_LinesSpecified");
			}
		}

		[XmlElement("Item_Request_Line_Data", Order = 19)]
		public Item_Request_Line_DataType[] Item_Request_Line_Data
		{
			get
			{
				return this.item_Request_Line_DataField;
			}
			set
			{
				this.item_Request_Line_DataField = value;
				this.RaisePropertyChanged("Item_Request_Line_Data");
			}
		}

		[XmlElement("Service_Request_Line_Data", Order = 20)]
		public Service_Request_Line_DataType[] Service_Request_Line_Data
		{
			get
			{
				return this.service_Request_Line_DataField;
			}
			set
			{
				this.service_Request_Line_DataField = value;
				this.RaisePropertyChanged("Service_Request_Line_Data");
			}
		}

		[XmlElement("Deliverables_Line_Data", Order = 21)]
		public ProjectBased_Requisition_Line_DataType[] Deliverables_Line_Data
		{
			get
			{
				return this.deliverables_Line_DataField;
			}
			set
			{
				this.deliverables_Line_DataField = value;
				this.RaisePropertyChanged("Deliverables_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 22)]
		public Business_Document_Attachment_with_External_Option_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Ad_Hoc_Address_Replacement_Data", Order = 23)]
		public Address_Information_DataType[] Ad_Hoc_Address_Replacement_Data
		{
			get
			{
				return this.ad_Hoc_Address_Replacement_DataField;
			}
			set
			{
				this.ad_Hoc_Address_Replacement_DataField = value;
				this.RaisePropertyChanged("Ad_Hoc_Address_Replacement_Data");
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
