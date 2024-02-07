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
	public class Inventory_Stock_Request_DataType : INotifyPropertyChanged
	{
		private string inventory_Stock_Request_IDField;

		private Inventory_Stock_Request_Transaction_TypeObjectType inventory_Stock_Request_Transaction_Type_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private LocationObjectType transfer_To_Inventory_Site_ReferenceField;

		private Inventory_Stock_Request_TypeObjectType inventory_Stock_Request_Type_ReferenceField;

		private LocationObjectType inventory_Par_Location_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal other_Charges_AmountField;

		private bool other_Charges_AmountFieldSpecified;

		private bool is_High_PriorityField;

		private bool is_High_PriorityFieldSpecified;

		private string shipTo_Contact_ReferenceField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private string memoField;

		private Inventory_Stock_Request_Line_DataType[] inventory_Stock_Request_Line_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] attachment_DataField;

		private Address_Information_DataType[] ad_Hoc_Address_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Inventory_Stock_Request_ID
		{
			get
			{
				return this.inventory_Stock_Request_IDField;
			}
			set
			{
				this.inventory_Stock_Request_IDField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_ID");
			}
		}

		[XmlElement(Order = 1)]
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
		public decimal Freight_Amount
		{
			get
			{
				return this.freight_AmountField;
			}
			set
			{
				this.freight_AmountField = value;
				this.RaisePropertyChanged("Freight_Amount");
			}
		}

		[XmlIgnore]
		public bool Freight_AmountSpecified
		{
			get
			{
				return this.freight_AmountFieldSpecified;
			}
			set
			{
				this.freight_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Freight_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Other_Charges_Amount
		{
			get
			{
				return this.other_Charges_AmountField;
			}
			set
			{
				this.other_Charges_AmountField = value;
				this.RaisePropertyChanged("Other_Charges_Amount");
			}
		}

		[XmlIgnore]
		public bool Other_Charges_AmountSpecified
		{
			get
			{
				return this.other_Charges_AmountFieldSpecified;
			}
			set
			{
				this.other_Charges_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Other_Charges_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Is_High_Priority
		{
			get
			{
				return this.is_High_PriorityField;
			}
			set
			{
				this.is_High_PriorityField = value;
				this.RaisePropertyChanged("Is_High_Priority");
			}
		}

		[XmlIgnore]
		public bool Is_High_PrioritySpecified
		{
			get
			{
				return this.is_High_PriorityFieldSpecified;
			}
			set
			{
				this.is_High_PriorityFieldSpecified = value;
				this.RaisePropertyChanged("Is_High_PrioritySpecified");
			}
		}

		[XmlElement("Ship-To_Contact_Reference", Order = 11)]
		public string ShipTo_Contact_Reference
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

		[XmlElement("Ship-To_Address_Reference", Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Inventory_Stock_Request_Line_Data", Order = 14)]
		public Inventory_Stock_Request_Line_DataType[] Inventory_Stock_Request_Line_Data
		{
			get
			{
				return this.inventory_Stock_Request_Line_DataField;
			}
			set
			{
				this.inventory_Stock_Request_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 15)]
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

		[XmlElement("Ad_Hoc_Address_Replacement_Data", Order = 16)]
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
