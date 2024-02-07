using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Company_Procurement_Options_DataType : INotifyPropertyChanged
	{
		private bool consolidate_Requisitions_on_Purchase_OrdersField;

		private bool consolidate_Requisitions_on_Purchase_OrdersFieldSpecified;

		private bool exclude_ShipTo_Address_when_Consolidating_Requisition_LinesField;

		private bool exclude_ShipTo_Address_when_Consolidating_Requisition_LinesFieldSpecified;

		private bool exclude_Purchase_Items_having_Catalog_EntriesField;

		private bool exclude_Purchase_Items_having_Catalog_EntriesFieldSpecified;

		private bool enable_Requisition_Line_DefaultsField;

		private bool enable_Requisition_Line_DefaultsFieldSpecified;

		private Spend_Category_HierarchyObjectType spend_Category_Hierarchy_Root_Node_ReferenceField;

		private Request_for_Quote_Notification_TypeObjectType[] request_for_Quote_Notification_Type_ReferenceField;

		private WorkerObjectType shipTo_Contact_ReferenceField;

		private WorkerObjectType billTo_Contact_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Consolidate_Requisitions_on_Purchase_Orders
		{
			get
			{
				return this.consolidate_Requisitions_on_Purchase_OrdersField;
			}
			set
			{
				this.consolidate_Requisitions_on_Purchase_OrdersField = value;
				this.RaisePropertyChanged("Consolidate_Requisitions_on_Purchase_Orders");
			}
		}

		[XmlIgnore]
		public bool Consolidate_Requisitions_on_Purchase_OrdersSpecified
		{
			get
			{
				return this.consolidate_Requisitions_on_Purchase_OrdersFieldSpecified;
			}
			set
			{
				this.consolidate_Requisitions_on_Purchase_OrdersFieldSpecified = value;
				this.RaisePropertyChanged("Consolidate_Requisitions_on_Purchase_OrdersSpecified");
			}
		}

		[XmlElement("Exclude_Ship-To_Address_when_Consolidating_Requisition_Lines", Order = 1)]
		public bool Exclude_ShipTo_Address_when_Consolidating_Requisition_Lines
		{
			get
			{
				return this.exclude_ShipTo_Address_when_Consolidating_Requisition_LinesField;
			}
			set
			{
				this.exclude_ShipTo_Address_when_Consolidating_Requisition_LinesField = value;
				this.RaisePropertyChanged("Exclude_ShipTo_Address_when_Consolidating_Requisition_Lines");
			}
		}

		[XmlIgnore]
		public bool Exclude_ShipTo_Address_when_Consolidating_Requisition_LinesSpecified
		{
			get
			{
				return this.exclude_ShipTo_Address_when_Consolidating_Requisition_LinesFieldSpecified;
			}
			set
			{
				this.exclude_ShipTo_Address_when_Consolidating_Requisition_LinesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_ShipTo_Address_when_Consolidating_Requisition_LinesSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Exclude_Purchase_Items_having_Catalog_Entries
		{
			get
			{
				return this.exclude_Purchase_Items_having_Catalog_EntriesField;
			}
			set
			{
				this.exclude_Purchase_Items_having_Catalog_EntriesField = value;
				this.RaisePropertyChanged("Exclude_Purchase_Items_having_Catalog_Entries");
			}
		}

		[XmlIgnore]
		public bool Exclude_Purchase_Items_having_Catalog_EntriesSpecified
		{
			get
			{
				return this.exclude_Purchase_Items_having_Catalog_EntriesFieldSpecified;
			}
			set
			{
				this.exclude_Purchase_Items_having_Catalog_EntriesFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_Purchase_Items_having_Catalog_EntriesSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Enable_Requisition_Line_Defaults
		{
			get
			{
				return this.enable_Requisition_Line_DefaultsField;
			}
			set
			{
				this.enable_Requisition_Line_DefaultsField = value;
				this.RaisePropertyChanged("Enable_Requisition_Line_Defaults");
			}
		}

		[XmlIgnore]
		public bool Enable_Requisition_Line_DefaultsSpecified
		{
			get
			{
				return this.enable_Requisition_Line_DefaultsFieldSpecified;
			}
			set
			{
				this.enable_Requisition_Line_DefaultsFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Requisition_Line_DefaultsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Spend_Category_HierarchyObjectType Spend_Category_Hierarchy_Root_Node_Reference
		{
			get
			{
				return this.spend_Category_Hierarchy_Root_Node_ReferenceField;
			}
			set
			{
				this.spend_Category_Hierarchy_Root_Node_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Hierarchy_Root_Node_Reference");
			}
		}

		[XmlElement("Request_for_Quote_Notification_Type_Reference", Order = 5)]
		public Request_for_Quote_Notification_TypeObjectType[] Request_for_Quote_Notification_Type_Reference
		{
			get
			{
				return this.request_for_Quote_Notification_Type_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Notification_Type_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Notification_Type_Reference");
			}
		}

		[XmlElement("Ship-To_Contact_Reference", Order = 6)]
		public WorkerObjectType ShipTo_Contact_Reference
		{
			get
			{
				return this.shipTo_Contact_ReferenceField;
			}
			set
			{
				this.shipTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Contact_Reference");
			}
		}

		[XmlElement("Bill-To_Contact_Reference", Order = 7)]
		public WorkerObjectType BillTo_Contact_Reference
		{
			get
			{
				return this.billTo_Contact_ReferenceField;
			}
			set
			{
				this.billTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Contact_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Shipping_MethodObjectType Shipping_Method_Reference
		{
			get
			{
				return this.shipping_Method_ReferenceField;
			}
			set
			{
				this.shipping_Method_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Method_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Shipping_TermsObjectType Shipping_Terms_Reference
		{
			get
			{
				return this.shipping_Terms_ReferenceField;
			}
			set
			{
				this.shipping_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Shipping_Terms_Reference");
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
