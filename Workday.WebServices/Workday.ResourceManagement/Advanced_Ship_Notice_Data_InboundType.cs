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
	public class Advanced_Ship_Notice_Data_InboundType : INotifyPropertyChanged
	{
		private string advanced_Ship_Notice_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool auto_Submit_Receipt_for_ApprovalField;

		private bool auto_Submit_Receipt_for_ApprovalFieldSpecified;

		private string bill_Of_LadingField;

		private string carrier_Tracking_NumberField;

		private Unique_IdentifierObjectType origin_ReferenceField;

		private string shipment_ContactField;

		private string shipment_ReferenceField;

		private string supplier_Order_ReferenceField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private string memoField;

		private string license_PlateField;

		private decimal bill_of_Lading_QuantityField;

		private bool bill_of_Lading_QuantityFieldSpecified;

		private DateTime shipment_DateField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private string itemField;

		private ItemChoiceType8 itemElementNameField;

		private Advanced_Ship_Notice_Line_Data_InboundType[] advanced_Ship_Notice_Line_DataField;

		private Financials_Attachment_DataType[] business_Document_Attachment_DataField;

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

		[XmlElement(Order = 2)]
		public bool Auto_Submit_Receipt_for_Approval
		{
			get
			{
				return this.auto_Submit_Receipt_for_ApprovalField;
			}
			set
			{
				this.auto_Submit_Receipt_for_ApprovalField = value;
				this.RaisePropertyChanged("Auto_Submit_Receipt_for_Approval");
			}
		}

		[XmlIgnore]
		public bool Auto_Submit_Receipt_for_ApprovalSpecified
		{
			get
			{
				return this.auto_Submit_Receipt_for_ApprovalFieldSpecified;
			}
			set
			{
				this.auto_Submit_Receipt_for_ApprovalFieldSpecified = value;
				this.RaisePropertyChanged("Auto_Submit_Receipt_for_ApprovalSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 14)]
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

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Ship-To_Address_Customer_Account_Number", typeof(string), Order = 15), XmlElement("Ship-To_Address_Global_Location_Number", typeof(string), Order = 15)]
		public string Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 16), XmlIgnore]
		public ItemChoiceType8 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement("Advanced_Ship_Notice_Line_Data", Order = 17)]
		public Advanced_Ship_Notice_Line_Data_InboundType[] Advanced_Ship_Notice_Line_Data
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

		[XmlElement("Business_Document_Attachment_Data", Order = 18)]
		public Financials_Attachment_DataType[] Business_Document_Attachment_Data
		{
			get
			{
				return this.business_Document_Attachment_DataField;
			}
			set
			{
				this.business_Document_Attachment_DataField = value;
				this.RaisePropertyChanged("Business_Document_Attachment_Data");
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
