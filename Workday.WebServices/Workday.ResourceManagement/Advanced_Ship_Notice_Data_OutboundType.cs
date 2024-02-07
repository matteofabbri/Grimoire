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
	public class Advanced_Ship_Notice_Data_OutboundType : INotifyPropertyChanged
	{
		private string advanced_Ship_Notice_IDField;

		private string document_NumberField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private string cancellation_MemoField;

		private DateTime canceled_On_DateField;

		private bool canceled_On_DateFieldSpecified;

		private DateTime shipment_DateField;

		private bool shipment_DateFieldSpecified;

		private string bill_Of_LadingField;

		private string carrier_Tracking_NumberField;

		private string shipment_ReferenceField;

		private string supplier_Order_ReferenceField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private bool autosubmit_Receipt_for_ApprovalField;

		private bool autosubmit_Receipt_for_ApprovalFieldSpecified;

		private Unique_IdentifierObjectType origin_ReferenceField;

		private string shipment_ContactField;

		private Address_ReferenceObjectType address_ReferenceField;

		private string license_PlateField;

		private decimal bill_of_Lading_QuantityField;

		private bool bill_of_Lading_QuantityFieldSpecified;

		private string memoField;

		private Advanced_Ship_Notice_Line_Data_OutboundType[] advanced_Ship_Notice_Line_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Advanced_Ship_Notice_ID
		{
			get
			{
				return this.advanced_Ship_Notice_IDField;
			}
			set
			{
				this.advanced_Ship_Notice_IDField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 3)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public string Cancellation_Memo
		{
			get
			{
				return this.cancellation_MemoField;
			}
			set
			{
				this.cancellation_MemoField = value;
				this.RaisePropertyChanged("Cancellation_Memo");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Canceled_On_Date
		{
			get
			{
				return this.canceled_On_DateField;
			}
			set
			{
				this.canceled_On_DateField = value;
				this.RaisePropertyChanged("Canceled_On_Date");
			}
		}

		[XmlIgnore]
		public bool Canceled_On_DateSpecified
		{
			get
			{
				return this.canceled_On_DateFieldSpecified;
			}
			set
			{
				this.canceled_On_DateFieldSpecified = value;
				this.RaisePropertyChanged("Canceled_On_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public DateTime Shipment_Date
		{
			get
			{
				return this.shipment_DateField;
			}
			set
			{
				this.shipment_DateField = value;
				this.RaisePropertyChanged("Shipment_Date");
			}
		}

		[XmlIgnore]
		public bool Shipment_DateSpecified
		{
			get
			{
				return this.shipment_DateFieldSpecified;
			}
			set
			{
				this.shipment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Shipment_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Bill_Of_Lading
		{
			get
			{
				return this.bill_Of_LadingField;
			}
			set
			{
				this.bill_Of_LadingField = value;
				this.RaisePropertyChanged("Bill_Of_Lading");
			}
		}

		[XmlElement(Order = 9)]
		public string Carrier_Tracking_Number
		{
			get
			{
				return this.carrier_Tracking_NumberField;
			}
			set
			{
				this.carrier_Tracking_NumberField = value;
				this.RaisePropertyChanged("Carrier_Tracking_Number");
			}
		}

		[XmlElement(Order = 10)]
		public string Shipment_Reference
		{
			get
			{
				return this.shipment_ReferenceField;
			}
			set
			{
				this.shipment_ReferenceField = value;
				this.RaisePropertyChanged("Shipment_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Supplier_Order_Reference
		{
			get
			{
				return this.supplier_Order_ReferenceField;
			}
			set
			{
				this.supplier_Order_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Order_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Purchase_OrderObjectType Purchase_Order_Reference
		{
			get
			{
				return this.purchase_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Reference");
			}
		}

		[XmlElement("Auto-submit_Receipt_for_Approval", Order = 13)]
		public bool Autosubmit_Receipt_for_Approval
		{
			get
			{
				return this.autosubmit_Receipt_for_ApprovalField;
			}
			set
			{
				this.autosubmit_Receipt_for_ApprovalField = value;
				this.RaisePropertyChanged("Autosubmit_Receipt_for_Approval");
			}
		}

		[XmlIgnore]
		public bool Autosubmit_Receipt_for_ApprovalSpecified
		{
			get
			{
				return this.autosubmit_Receipt_for_ApprovalFieldSpecified;
			}
			set
			{
				this.autosubmit_Receipt_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Autosubmit_Receipt_for_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public Unique_IdentifierObjectType Origin_Reference
		{
			get
			{
				return this.origin_ReferenceField;
			}
			set
			{
				this.origin_ReferenceField = value;
				this.RaisePropertyChanged("Origin_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public string Shipment_Contact
		{
			get
			{
				return this.shipment_ContactField;
			}
			set
			{
				this.shipment_ContactField = value;
				this.RaisePropertyChanged("Shipment_Contact");
			}
		}

		[XmlElement(Order = 16)]
		public Address_ReferenceObjectType Address_Reference
		{
			get
			{
				return this.address_ReferenceField;
			}
			set
			{
				this.address_ReferenceField = value;
				this.RaisePropertyChanged("Address_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public string License_Plate
		{
			get
			{
				return this.license_PlateField;
			}
			set
			{
				this.license_PlateField = value;
				this.RaisePropertyChanged("License_Plate");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Bill_of_Lading_Quantity
		{
			get
			{
				return this.bill_of_Lading_QuantityField;
			}
			set
			{
				this.bill_of_Lading_QuantityField = value;
				this.RaisePropertyChanged("Bill_of_Lading_Quantity");
			}
		}

		[XmlIgnore]
		public bool Bill_of_Lading_QuantitySpecified
		{
			get
			{
				return this.bill_of_Lading_QuantityFieldSpecified;
			}
			set
			{
				this.bill_of_Lading_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Bill_of_Lading_QuantitySpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement("Advanced_Ship_Notice_Line_Data", Order = 20)]
		public Advanced_Ship_Notice_Line_Data_OutboundType[] Advanced_Ship_Notice_Line_Data
		{
			get
			{
				return this.advanced_Ship_Notice_Line_DataField;
			}
			set
			{
				this.advanced_Ship_Notice_Line_DataField = value;
				this.RaisePropertyChanged("Advanced_Ship_Notice_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 21)]
		public Financials_Attachment_DataType[] Attachment_Data
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
