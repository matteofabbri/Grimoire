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
	public class Supplier_Contract_DataType : INotifyPropertyChanged
	{
		private string supplier_Contract_IDField;

		private object itemField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private WorkerObjectType contract_Specialist_ReferenceField;

		private WorkerObjectType buyer_ReferenceField;

		private Supplier_Contract_TypeObjectType contract_Type_ReferenceField;

		private string contract_NameField;

		private string supplier_Reference_NumberField;

		private DateTime contract_Start_DateField;

		private DateTime contract_Signed_DateField;

		private bool contract_Signed_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private decimal total_Contract_AmountField;

		private bool total_Contract_AmountFieldSpecified;

		private decimal original_Contract_AmountField;

		private bool original_Contract_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Payment_TypeObjectType override_Payment_Type_ReferenceField;

		private Worker_Credit_CardObjectType credit_Card_ReferenceField;

		private Renewal_Terms_DataType renewal_Terms_DataField;

		private string contract_OverviewField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private Supplier_CatalogObjectType[] catalog_ReferenceField;

		private decimal catalog_Discount_PercentField;

		private bool catalog_Discount_PercentFieldSpecified;

		private CompanyObjectType company_for_Supplier_Invoice_ReferenceField;

		private SupplierObjectType supplier_for_Supplier_Invoice_ReferenceField;

		private object item1Field;

		private Payment_TermsObjectType supplier_Invoice_Payment_Terms_ReferenceField;

		private Payment_TypeObjectType scheduled_Invoice_Override_Payment_Type_ReferenceField;

		private string supplier_Invoice_Reference_NumberField;

		private CompanyObjectType company_for_Purchase_Order_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType purchase_Order_Issue_Option_ReferenceField;

		private Payment_TermsObjectType purchase_Order_Payment_Terms_ReferenceField;

		private string billTo_Contact_DetailField;

		private Unique_IdentifierObjectType billTo_Address_ReferenceField;

		private string shipTo_Contact_DetailField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal percent_to_RetainField;

		private bool percent_to_RetainFieldSpecified;

		private DateTime estimated_Retention_Release_DateField;

		private bool estimated_Retention_Release_DateFieldSpecified;

		private bool xMLNAME_3rd_Party_RetentionField;

		private bool xMLNAME_3rd_Party_RetentionFieldSpecified;

		private string retention_MemoField;

		private Lease_Supplier_Contract_Details_DataType lease_Details_DataField;

		private Supplier_Contract_Line_Replacement_DataType[] goods_Lines_Replacement_DataField;

		private Supplier_Contract_Service_Line_Replacement_DataType[] service_Lines_Replacement_DataField;

		private MultiSupplier_DataType[] multi_Supplier_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private bool submitField;

		private bool submitFieldSpecified;

		private Note_WWS_DataType[] note_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Contract_ID
		{
			get
			{
				return this.supplier_Contract_IDField;
			}
			set
			{
				this.supplier_Contract_IDField = value;
				this.RaisePropertyChanged("Supplier_Contract_ID");
			}
		}

		[XmlElement("Company_Hierarchy_Reference", typeof(OrganizationObjectType), Order = 1), XmlElement("Company_Reference", typeof(CompanyObjectType), Order = 1)]
		public object Item
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public WorkerObjectType Contract_Specialist_Reference
		{
			get
			{
				return this.contract_Specialist_ReferenceField;
			}
			set
			{
				this.contract_Specialist_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Specialist_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Supplier_Contract_TypeObjectType Contract_Type_Reference
		{
			get
			{
				return this.contract_Type_ReferenceField;
			}
			set
			{
				this.contract_Type_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Contract_Name
		{
			get
			{
				return this.contract_NameField;
			}
			set
			{
				this.contract_NameField = value;
				this.RaisePropertyChanged("Contract_Name");
			}
		}

		[XmlElement(Order = 7)]
		public string Supplier_Reference_Number
		{
			get
			{
				return this.supplier_Reference_NumberField;
			}
			set
			{
				this.supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Reference_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Contract_Start_Date
		{
			get
			{
				return this.contract_Start_DateField;
			}
			set
			{
				this.contract_Start_DateField = value;
				this.RaisePropertyChanged("Contract_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Contract_Signed_Date
		{
			get
			{
				return this.contract_Signed_DateField;
			}
			set
			{
				this.contract_Signed_DateField = value;
				this.RaisePropertyChanged("Contract_Signed_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_Signed_DateSpecified
		{
			get
			{
				return this.contract_Signed_DateFieldSpecified;
			}
			set
			{
				this.contract_Signed_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_Signed_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Total_Contract_Amount
		{
			get
			{
				return this.total_Contract_AmountField;
			}
			set
			{
				this.total_Contract_AmountField = value;
				this.RaisePropertyChanged("Total_Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Contract_AmountSpecified
		{
			get
			{
				return this.total_Contract_AmountFieldSpecified;
			}
			set
			{
				this.total_Contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Contract_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Original_Contract_Amount
		{
			get
			{
				return this.original_Contract_AmountField;
			}
			set
			{
				this.original_Contract_AmountField = value;
				this.RaisePropertyChanged("Original_Contract_Amount");
			}
		}

		[XmlIgnore]
		public bool Original_Contract_AmountSpecified
		{
			get
			{
				return this.original_Contract_AmountFieldSpecified;
			}
			set
			{
				this.original_Contract_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Original_Contract_AmountSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public Tax_CodeObjectType Default_Tax_Code_Reference
		{
			get
			{
				return this.default_Tax_Code_ReferenceField;
			}
			set
			{
				this.default_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Default_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Payment_TypeObjectType Override_Payment_Type_Reference
		{
			get
			{
				return this.override_Payment_Type_ReferenceField;
			}
			set
			{
				this.override_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Override_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Worker_Credit_CardObjectType Credit_Card_Reference
		{
			get
			{
				return this.credit_Card_ReferenceField;
			}
			set
			{
				this.credit_Card_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Renewal_Terms_DataType Renewal_Terms_Data
		{
			get
			{
				return this.renewal_Terms_DataField;
			}
			set
			{
				this.renewal_Terms_DataField = value;
				this.RaisePropertyChanged("Renewal_Terms_Data");
			}
		}

		[XmlElement(Order = 18)]
		public string Contract_Overview
		{
			get
			{
				return this.contract_OverviewField;
			}
			set
			{
				this.contract_OverviewField = value;
				this.RaisePropertyChanged("Contract_Overview");
			}
		}

		[XmlElement(Order = 19)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement("Catalog_Reference", Order = 20)]
		public Supplier_CatalogObjectType[] Catalog_Reference
		{
			get
			{
				return this.catalog_ReferenceField;
			}
			set
			{
				this.catalog_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Catalog_Discount_Percent
		{
			get
			{
				return this.catalog_Discount_PercentField;
			}
			set
			{
				this.catalog_Discount_PercentField = value;
				this.RaisePropertyChanged("Catalog_Discount_Percent");
			}
		}

		[XmlIgnore]
		public bool Catalog_Discount_PercentSpecified
		{
			get
			{
				return this.catalog_Discount_PercentFieldSpecified;
			}
			set
			{
				this.catalog_Discount_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Catalog_Discount_PercentSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public CompanyObjectType Company_for_Supplier_Invoice_Reference
		{
			get
			{
				return this.company_for_Supplier_Invoice_ReferenceField;
			}
			set
			{
				this.company_for_Supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Supplier_Invoice_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public SupplierObjectType Supplier_for_Supplier_Invoice_Reference
		{
			get
			{
				return this.supplier_for_Supplier_Invoice_ReferenceField;
			}
			set
			{
				this.supplier_for_Supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_for_Supplier_Invoice_Reference");
			}
		}

		[XmlElement("Supplier_Connection_for_Supplier_Invoice_Reference", typeof(Supplier_ConnectionObjectType), Order = 24), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 24)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 25)]
		public Payment_TermsObjectType Supplier_Invoice_Payment_Terms_Reference
		{
			get
			{
				return this.supplier_Invoice_Payment_Terms_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Payment_Terms_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Payment_TypeObjectType Scheduled_Invoice_Override_Payment_Type_Reference
		{
			get
			{
				return this.scheduled_Invoice_Override_Payment_Type_ReferenceField;
			}
			set
			{
				this.scheduled_Invoice_Override_Payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Scheduled_Invoice_Override_Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string Supplier_Invoice_Reference_Number
		{
			get
			{
				return this.supplier_Invoice_Reference_NumberField;
			}
			set
			{
				this.supplier_Invoice_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference_Number");
			}
		}

		[XmlElement(Order = 28)]
		public CompanyObjectType Company_for_Purchase_Order_Reference
		{
			get
			{
				return this.company_for_Purchase_Order_ReferenceField;
			}
			set
			{
				this.company_for_Purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Company_for_Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 29)]
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

		[XmlElement(Order = 30)]
		public Payment_TermsObjectType Purchase_Order_Payment_Terms_Reference
		{
			get
			{
				return this.purchase_Order_Payment_Terms_ReferenceField;
			}
			set
			{
				this.purchase_Order_Payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Payment_Terms_Reference");
			}
		}

		[XmlElement("Bill-To_Contact_Detail", Order = 31)]
		public string BillTo_Contact_Detail
		{
			get
			{
				return this.billTo_Contact_DetailField;
			}
			set
			{
				this.billTo_Contact_DetailField = value;
				this.RaisePropertyChanged("BillTo_Contact_Detail");
			}
		}

		[XmlElement("Bill-To_Address_Reference", Order = 32)]
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

		[XmlElement("Ship-To_Contact_Detail", Order = 33)]
		public string ShipTo_Contact_Detail
		{
			get
			{
				return this.shipTo_Contact_DetailField;
			}
			set
			{
				this.shipTo_Contact_DetailField = value;
				this.RaisePropertyChanged("ShipTo_Contact_Detail");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 34)]
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

		[XmlElement(Order = 35)]
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

		[XmlElement(Order = 36)]
		public decimal Percent_to_Retain
		{
			get
			{
				return this.percent_to_RetainField;
			}
			set
			{
				this.percent_to_RetainField = value;
				this.RaisePropertyChanged("Percent_to_Retain");
			}
		}

		[XmlIgnore]
		public bool Percent_to_RetainSpecified
		{
			get
			{
				return this.percent_to_RetainFieldSpecified;
			}
			set
			{
				this.percent_to_RetainFieldSpecified = value;
				this.RaisePropertyChanged("Percent_to_RetainSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 37)]
		public DateTime Estimated_Retention_Release_Date
		{
			get
			{
				return this.estimated_Retention_Release_DateField;
			}
			set
			{
				this.estimated_Retention_Release_DateField = value;
				this.RaisePropertyChanged("Estimated_Retention_Release_Date");
			}
		}

		[XmlIgnore]
		public bool Estimated_Retention_Release_DateSpecified
		{
			get
			{
				return this.estimated_Retention_Release_DateFieldSpecified;
			}
			set
			{
				this.estimated_Retention_Release_DateFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_Retention_Release_DateSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool XMLNAME_3rd_Party_Retention
		{
			get
			{
				return this.xMLNAME_3rd_Party_RetentionField;
			}
			set
			{
				this.xMLNAME_3rd_Party_RetentionField = value;
				this.RaisePropertyChanged("XMLNAME_3rd_Party_Retention");
			}
		}

		[XmlIgnore]
		public bool XMLNAME_3rd_Party_RetentionSpecified
		{
			get
			{
				return this.xMLNAME_3rd_Party_RetentionFieldSpecified;
			}
			set
			{
				this.xMLNAME_3rd_Party_RetentionFieldSpecified = value;
				this.RaisePropertyChanged("XMLNAME_3rd_Party_RetentionSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public string Retention_Memo
		{
			get
			{
				return this.retention_MemoField;
			}
			set
			{
				this.retention_MemoField = value;
				this.RaisePropertyChanged("Retention_Memo");
			}
		}

		[XmlElement(Order = 40)]
		public Lease_Supplier_Contract_Details_DataType Lease_Details_Data
		{
			get
			{
				return this.lease_Details_DataField;
			}
			set
			{
				this.lease_Details_DataField = value;
				this.RaisePropertyChanged("Lease_Details_Data");
			}
		}

		[XmlElement("Goods_Lines_Replacement_Data", Order = 41)]
		public Supplier_Contract_Line_Replacement_DataType[] Goods_Lines_Replacement_Data
		{
			get
			{
				return this.goods_Lines_Replacement_DataField;
			}
			set
			{
				this.goods_Lines_Replacement_DataField = value;
				this.RaisePropertyChanged("Goods_Lines_Replacement_Data");
			}
		}

		[XmlElement("Service_Lines_Replacement_Data", Order = 42)]
		public Supplier_Contract_Service_Line_Replacement_DataType[] Service_Lines_Replacement_Data
		{
			get
			{
				return this.service_Lines_Replacement_DataField;
			}
			set
			{
				this.service_Lines_Replacement_DataField = value;
				this.RaisePropertyChanged("Service_Lines_Replacement_Data");
			}
		}

		[XmlElement("Multi_Supplier_Data", Order = 43)]
		public MultiSupplier_DataType[] Multi_Supplier_Data
		{
			get
			{
				return this.multi_Supplier_DataField;
			}
			set
			{
				this.multi_Supplier_DataField = value;
				this.RaisePropertyChanged("Multi_Supplier_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 44)]
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

		[XmlElement(Order = 45)]
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

		[XmlElement("Note_Data", Order = 46)]
		public Note_WWS_DataType[] Note_Data
		{
			get
			{
				return this.note_DataField;
			}
			set
			{
				this.note_DataField = value;
				this.RaisePropertyChanged("Note_Data");
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
