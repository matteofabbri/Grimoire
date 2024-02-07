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
	public class Purchase_Order_Installment_Replacement_DataType : INotifyPropertyChanged
	{
		private string purchase_Order_Installment_IDField;

		private Purchase_Order_InstallmentObjectType purchase_Order_Installment_ReferenceField;

		private decimal installment_NumberField;

		private bool installment_NumberFieldSpecified;

		private Document_StatusObjectType[] status_ReferenceField;

		private DateTime purchase_Order_DateField;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private bool use_Installment_OverridesField;

		private bool use_Installment_OverridesFieldSpecified;

		private WorkerObjectType buyer_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType purchase_Order_Issue_Option_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private string billTo_ContactField;

		private Unique_IdentifierObjectType billTo_Address_ReferenceField;

		private string shipTo_ContactField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Worker_Credit_CardObjectType procurement_Card_ReferenceField;

		private string memoField;

		private string internal_MemoField;

		private Supplier_Contract_Installment_Line_DataType[] purchase_Order_Installment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Purchase_Order_Installment_ID
		{
			get
			{
				return this.purchase_Order_Installment_IDField;
			}
			set
			{
				this.purchase_Order_Installment_IDField = value;
				this.RaisePropertyChanged("Purchase_Order_Installment_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Purchase_Order_InstallmentObjectType Purchase_Order_Installment_Reference
		{
			get
			{
				return this.purchase_Order_Installment_ReferenceField;
			}
			set
			{
				this.purchase_Order_Installment_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Installment_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Installment_Number
		{
			get
			{
				return this.installment_NumberField;
			}
			set
			{
				this.installment_NumberField = value;
				this.RaisePropertyChanged("Installment_Number");
			}
		}

		[XmlIgnore]
		public bool Installment_NumberSpecified
		{
			get
			{
				return this.installment_NumberFieldSpecified;
			}
			set
			{
				this.installment_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Installment_NumberSpecified");
			}
		}

		[XmlElement("Status_Reference", Order = 3)]
		public Document_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Purchase_Order_Date
		{
			get
			{
				return this.purchase_Order_DateField;
			}
			set
			{
				this.purchase_Order_DateField = value;
				this.RaisePropertyChanged("Purchase_Order_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Use_Installment_Overrides
		{
			get
			{
				return this.use_Installment_OverridesField;
			}
			set
			{
				this.use_Installment_OverridesField = value;
				this.RaisePropertyChanged("Use_Installment_Overrides");
			}
		}

		[XmlIgnore]
		public bool Use_Installment_OverridesSpecified
		{
			get
			{
				return this.use_Installment_OverridesFieldSpecified;
			}
			set
			{
				this.use_Installment_OverridesFieldSpecified = value;
				this.RaisePropertyChanged("Use_Installment_OverridesSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public WorkerObjectType Buyer_Reference
		{
			get
			{
				return this.buyer_ReferenceField;
			}
			set
			{
				this.buyer_ReferenceField = value;
				this.RaisePropertyChanged("Buyer_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Purchase_Order_Issue_OptionObjectType Purchase_Order_Issue_Option_Reference
		{
			get
			{
				return this.purchase_Order_Issue_Option_ReferenceField;
			}
			set
			{
				this.purchase_Order_Issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Issue_Option_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement("Bill-To_Contact", Order = 14)]
		public string BillTo_Contact
		{
			get
			{
				return this.billTo_ContactField;
			}
			set
			{
				this.billTo_ContactField = value;
				this.RaisePropertyChanged("BillTo_Contact");
			}
		}

		[XmlElement("Bill-To_Address_Reference", Order = 15)]
		public Unique_IdentifierObjectType BillTo_Address_Reference
		{
			get
			{
				return this.billTo_Address_ReferenceField;
			}
			set
			{
				this.billTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Address_Reference");
			}
		}

		[XmlElement("Ship-To_Contact", Order = 16)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 17)]
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

		[XmlElement(Order = 18)]
		public Payment_TypeObjectType Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Worker_Credit_CardObjectType Procurement_Card_Reference
		{
			get
			{
				return this.procurement_Card_ReferenceField;
			}
			set
			{
				this.procurement_Card_ReferenceField = value;
				this.RaisePropertyChanged("Procurement_Card_Reference");
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

		[XmlElement(Order = 21)]
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

		[XmlElement("Purchase_Order_Installment_Line_Data", Order = 22)]
		public Supplier_Contract_Installment_Line_DataType[] Purchase_Order_Installment_Line_Data
		{
			get
			{
				return this.purchase_Order_Installment_Line_DataField;
			}
			set
			{
				this.purchase_Order_Installment_Line_DataField = value;
				this.RaisePropertyChanged("Purchase_Order_Installment_Line_Data");
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
