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
	public class Service_Request_Line_DataType : INotifyPropertyChanged
	{
		private Service_Requisition_LineObjectType requisition_Service_Line_ReferenceField;

		private string service_Requisition_Line_IDField;

		private Procurement_ItemObjectType item_ReferenceField;

		private string item_IdentifierField;

		private string descriptionField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Requisition_SourceObjectType fulfillment_Source_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private bool rFQ_RequiredField;

		private bool rFQ_RequiredFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool source_This_LineField;

		private bool source_This_LineFieldSpecified;

		private Purchase_Order_LineObjectType[] purchase_Order_Line_ReferenceField;

		private bool mark_Purchase_Order_As_IssuedField;

		private bool mark_Purchase_Order_As_IssuedFieldSpecified;

		private Business_Document_Line_Split_DataType[] service_Requisition_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Service_Requisition_LineObjectType Requisition_Service_Line_Reference
		{
			get
			{
				return this.requisition_Service_Line_ReferenceField;
			}
			set
			{
				this.requisition_Service_Line_ReferenceField = value;
				this.RaisePropertyChanged("Requisition_Service_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Service_Requisition_Line_ID
		{
			get
			{
				return this.service_Requisition_Line_IDField;
			}
			set
			{
				this.service_Requisition_Line_IDField = value;
				this.RaisePropertyChanged("Service_Requisition_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Procurement_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Item_Identifier
		{
			get
			{
				return this.item_IdentifierField;
			}
			set
			{
				this.item_IdentifierField = value;
				this.RaisePropertyChanged("Item_Identifier");
			}
		}

		[XmlElement(Order = 4)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 5)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Requisition_SourceObjectType Fulfillment_Source_Reference
		{
			get
			{
				return this.fulfillment_Source_ReferenceField;
			}
			set
			{
				this.fulfillment_Source_ReferenceField = value;
				this.RaisePropertyChanged("Fulfillment_Source_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Resource_ProviderObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool RFQ_Required
		{
			get
			{
				return this.rFQ_RequiredField;
			}
			set
			{
				this.rFQ_RequiredField = value;
				this.RaisePropertyChanged("RFQ_Required");
			}
		}

		[XmlIgnore]
		public bool RFQ_RequiredSpecified
		{
			get
			{
				return this.rFQ_RequiredFieldSpecified;
			}
			set
			{
				this.rFQ_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("RFQ_RequiredSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
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

		[XmlElement(Order = 14)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Worktags_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Worktags_Reference
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

		[XmlElement(Order = 18)]
		public bool Source_This_Line
		{
			get
			{
				return this.source_This_LineField;
			}
			set
			{
				this.source_This_LineField = value;
				this.RaisePropertyChanged("Source_This_Line");
			}
		}

		[XmlIgnore]
		public bool Source_This_LineSpecified
		{
			get
			{
				return this.source_This_LineFieldSpecified;
			}
			set
			{
				this.source_This_LineFieldSpecified = value;
				this.RaisePropertyChanged("Source_This_LineSpecified");
			}
		}

		[XmlElement("Purchase_Order_Line_Reference", Order = 19)]
		public Purchase_Order_LineObjectType[] Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement(Order = 20)]
		public bool Mark_Purchase_Order_As_Issued
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedField;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedField = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_Issued");
			}
		}

		[XmlIgnore]
		public bool Mark_Purchase_Order_As_IssuedSpecified
		{
			get
			{
				return this.mark_Purchase_Order_As_IssuedFieldSpecified;
			}
			set
			{
				this.mark_Purchase_Order_As_IssuedFieldSpecified = value;
				this.RaisePropertyChanged("Mark_Purchase_Order_As_IssuedSpecified");
			}
		}

		[XmlElement("Service_Requisition_Line_Split_Data", Order = 21)]
		public Business_Document_Line_Split_DataType[] Service_Requisition_Line_Split_Data
		{
			get
			{
				return this.service_Requisition_Line_Split_DataField;
			}
			set
			{
				this.service_Requisition_Line_Split_DataField = value;
				this.RaisePropertyChanged("Service_Requisition_Line_Split_Data");
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
