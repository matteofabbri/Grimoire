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
	public class Inventory_Location_Attributes_WWS_Detail_DataType : INotifyPropertyChanged
	{
		private LocationObjectType location_ReferenceField;

		private string inventory_Location_Attributes_Reference_IDField;

		private CompanyObjectType company_ReferenceField;

		private CompanyObjectType[] procurement_Company_ReferenceField;

		private bool inventory_SiteField;

		private bool inventory_SiteFieldSpecified;

		private bool stocking_LocationField;

		private bool stocking_LocationFieldSpecified;

		private bool inventory_Movement_On_HoldField;

		private bool inventory_Movement_On_HoldFieldSpecified;

		private bool include_in_CountField;

		private bool include_in_CountFieldSpecified;

		private Inventory_Location_Usage_TypeObjectType inventory_Location_Usage_Type_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		private decimal fulfillment_Lead_TimeField;

		private bool fulfillment_Lead_TimeFieldSpecified;

		private bool item_Confirmation_RequiredField;

		private bool item_Confirmation_RequiredFieldSpecified;

		private string stocking_Location_Sort_OrderField;

		private Replenishment_OptionObjectType replenishment_Option_ReferenceField;

		private LocationObjectType source_Inventory_Site_ReferenceField;

		private CompanyObjectType source_Requisition_Company_ReferenceField;

		private Replenishment_Document_Status_OptionObjectType[] replenishment_OnOrder_Document_Status_Option_ReferenceField;

		private Replenishment_Document_Status_OptionObjectType[] replenishment_Open_Demand_Document_Status_Option_ReferenceField;

		private bool blind_CountingField;

		private bool blind_CountingFieldSpecified;

		private bool item_Substitutes_AllowedField;

		private bool item_Substitutes_AllowedFieldSpecified;

		private bool reserve_InventoryField;

		private bool reserve_InventoryFieldSpecified;

		private bool reserve_Stock_Requests_Upon_ApprovalField;

		private bool reserve_Stock_Requests_Upon_ApprovalFieldSpecified;

		private bool kill_Stock_Request_LinesField;

		private bool kill_Stock_Request_LinesFieldSpecified;

		private bool kill_Par_Replenishment_LinesField;

		private bool kill_Par_Replenishment_LinesFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Inventory_Location_Attributes_Reference_ID
		{
			get
			{
				return this.inventory_Location_Attributes_Reference_IDField;
			}
			set
			{
				this.inventory_Location_Attributes_Reference_IDField = value;
				this.RaisePropertyChanged("Inventory_Location_Attributes_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Procurement_Company_Reference", Order = 3)]
		public CompanyObjectType[] Procurement_Company_Reference
		{
			get
			{
				return this.procurement_Company_ReferenceField;
			}
			set
			{
				this.procurement_Company_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Company_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Inventory_Site
		{
			get
			{
				return this.inventory_SiteField;
			}
			set
			{
				this.inventory_SiteField = value;
				this.RaisePropertyChanged("Inventory_Site");
			}
		}

		[XmlIgnore]
		public bool Inventory_SiteSpecified
		{
			get
			{
				return this.inventory_SiteFieldSpecified;
			}
			set
			{
				this.inventory_SiteFieldSpecified = value;
				this.RaisePropertyChanged("Inventory_SiteSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Stocking_Location
		{
			get
			{
				return this.stocking_LocationField;
			}
			set
			{
				this.stocking_LocationField = value;
				this.RaisePropertyChanged("Stocking_Location");
			}
		}

		[XmlIgnore]
		public bool Stocking_LocationSpecified
		{
			get
			{
				return this.stocking_LocationFieldSpecified;
			}
			set
			{
				this.stocking_LocationFieldSpecified = value;
				this.RaisePropertyChanged("Stocking_LocationSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Inventory_Movement_On_Hold
		{
			get
			{
				return this.inventory_Movement_On_HoldField;
			}
			set
			{
				this.inventory_Movement_On_HoldField = value;
				this.RaisePropertyChanged("Inventory_Movement_On_Hold");
			}
		}

		[XmlIgnore]
		public bool Inventory_Movement_On_HoldSpecified
		{
			get
			{
				return this.inventory_Movement_On_HoldFieldSpecified;
			}
			set
			{
				this.inventory_Movement_On_HoldFieldSpecified = value;
				this.RaisePropertyChanged("Inventory_Movement_On_HoldSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Include_in_Count
		{
			get
			{
				return this.include_in_CountField;
			}
			set
			{
				this.include_in_CountField = value;
				this.RaisePropertyChanged("Include_in_Count");
			}
		}

		[XmlIgnore]
		public bool Include_in_CountSpecified
		{
			get
			{
				return this.include_in_CountFieldSpecified;
			}
			set
			{
				this.include_in_CountFieldSpecified = value;
				this.RaisePropertyChanged("Include_in_CountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Inventory_Location_Usage_TypeObjectType Inventory_Location_Usage_Type_Reference
		{
			get
			{
				return this.inventory_Location_Usage_Type_ReferenceField;
			}
			set
			{
				this.inventory_Location_Usage_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Usage_Type_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 9)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Fulfillment_Lead_Time
		{
			get
			{
				return this.fulfillment_Lead_TimeField;
			}
			set
			{
				this.fulfillment_Lead_TimeField = value;
				this.RaisePropertyChanged("Fulfillment_Lead_Time");
			}
		}

		[XmlIgnore]
		public bool Fulfillment_Lead_TimeSpecified
		{
			get
			{
				return this.fulfillment_Lead_TimeFieldSpecified;
			}
			set
			{
				this.fulfillment_Lead_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Fulfillment_Lead_TimeSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Item_Confirmation_Required
		{
			get
			{
				return this.item_Confirmation_RequiredField;
			}
			set
			{
				this.item_Confirmation_RequiredField = value;
				this.RaisePropertyChanged("Item_Confirmation_Required");
			}
		}

		[XmlIgnore]
		public bool Item_Confirmation_RequiredSpecified
		{
			get
			{
				return this.item_Confirmation_RequiredFieldSpecified;
			}
			set
			{
				this.item_Confirmation_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Item_Confirmation_RequiredSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public string Stocking_Location_Sort_Order
		{
			get
			{
				return this.stocking_Location_Sort_OrderField;
			}
			set
			{
				this.stocking_Location_Sort_OrderField = value;
				this.RaisePropertyChanged("Stocking_Location_Sort_Order");
			}
		}

		[XmlElement(Order = 13)]
		public Replenishment_OptionObjectType Replenishment_Option_Reference
		{
			get
			{
				return this.replenishment_Option_ReferenceField;
			}
			set
			{
				this.replenishment_Option_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_Option_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public LocationObjectType Source_Inventory_Site_Reference
		{
			get
			{
				return this.source_Inventory_Site_ReferenceField;
			}
			set
			{
				this.source_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Source_Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public CompanyObjectType Source_Requisition_Company_Reference
		{
			get
			{
				return this.source_Requisition_Company_ReferenceField;
			}
			set
			{
				this.source_Requisition_Company_ReferenceField = value;
				this.RaisePropertyChanged("Source_Requisition_Company_Reference");
			}
		}

		[XmlElement("Replenishment_On-Order_Document_Status_Option_Reference", Order = 16)]
		public Replenishment_Document_Status_OptionObjectType[] Replenishment_OnOrder_Document_Status_Option_Reference
		{
			get
			{
				return this.replenishment_OnOrder_Document_Status_Option_ReferenceField;
			}
			set
			{
				this.replenishment_OnOrder_Document_Status_Option_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_OnOrder_Document_Status_Option_Reference");
			}
		}

		[XmlElement("Replenishment_Open_Demand_Document_Status_Option_Reference", Order = 17)]
		public Replenishment_Document_Status_OptionObjectType[] Replenishment_Open_Demand_Document_Status_Option_Reference
		{
			get
			{
				return this.replenishment_Open_Demand_Document_Status_Option_ReferenceField;
			}
			set
			{
				this.replenishment_Open_Demand_Document_Status_Option_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_Open_Demand_Document_Status_Option_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public bool Blind_Counting
		{
			get
			{
				return this.blind_CountingField;
			}
			set
			{
				this.blind_CountingField = value;
				this.RaisePropertyChanged("Blind_Counting");
			}
		}

		[XmlIgnore]
		public bool Blind_CountingSpecified
		{
			get
			{
				return this.blind_CountingFieldSpecified;
			}
			set
			{
				this.blind_CountingFieldSpecified = value;
				this.RaisePropertyChanged("Blind_CountingSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public bool Item_Substitutes_Allowed
		{
			get
			{
				return this.item_Substitutes_AllowedField;
			}
			set
			{
				this.item_Substitutes_AllowedField = value;
				this.RaisePropertyChanged("Item_Substitutes_Allowed");
			}
		}

		[XmlIgnore]
		public bool Item_Substitutes_AllowedSpecified
		{
			get
			{
				return this.item_Substitutes_AllowedFieldSpecified;
			}
			set
			{
				this.item_Substitutes_AllowedFieldSpecified = value;
				this.RaisePropertyChanged("Item_Substitutes_AllowedSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Reserve_Inventory
		{
			get
			{
				return this.reserve_InventoryField;
			}
			set
			{
				this.reserve_InventoryField = value;
				this.RaisePropertyChanged("Reserve_Inventory");
			}
		}

		[XmlIgnore]
		public bool Reserve_InventorySpecified
		{
			get
			{
				return this.reserve_InventoryFieldSpecified;
			}
			set
			{
				this.reserve_InventoryFieldSpecified = value;
				this.RaisePropertyChanged("Reserve_InventorySpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Reserve_Stock_Requests_Upon_Approval
		{
			get
			{
				return this.reserve_Stock_Requests_Upon_ApprovalField;
			}
			set
			{
				this.reserve_Stock_Requests_Upon_ApprovalField = value;
				this.RaisePropertyChanged("Reserve_Stock_Requests_Upon_Approval");
			}
		}

		[XmlIgnore]
		public bool Reserve_Stock_Requests_Upon_ApprovalSpecified
		{
			get
			{
				return this.reserve_Stock_Requests_Upon_ApprovalFieldSpecified;
			}
			set
			{
				this.reserve_Stock_Requests_Upon_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Reserve_Stock_Requests_Upon_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Kill_Stock_Request_Lines
		{
			get
			{
				return this.kill_Stock_Request_LinesField;
			}
			set
			{
				this.kill_Stock_Request_LinesField = value;
				this.RaisePropertyChanged("Kill_Stock_Request_Lines");
			}
		}

		[XmlIgnore]
		public bool Kill_Stock_Request_LinesSpecified
		{
			get
			{
				return this.kill_Stock_Request_LinesFieldSpecified;
			}
			set
			{
				this.kill_Stock_Request_LinesFieldSpecified = value;
				this.RaisePropertyChanged("Kill_Stock_Request_LinesSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Kill_Par_Replenishment_Lines
		{
			get
			{
				return this.kill_Par_Replenishment_LinesField;
			}
			set
			{
				this.kill_Par_Replenishment_LinesField = value;
				this.RaisePropertyChanged("Kill_Par_Replenishment_Lines");
			}
		}

		[XmlIgnore]
		public bool Kill_Par_Replenishment_LinesSpecified
		{
			get
			{
				return this.kill_Par_Replenishment_LinesFieldSpecified;
			}
			set
			{
				this.kill_Par_Replenishment_LinesFieldSpecified = value;
				this.RaisePropertyChanged("Kill_Par_Replenishment_LinesSpecified");
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
