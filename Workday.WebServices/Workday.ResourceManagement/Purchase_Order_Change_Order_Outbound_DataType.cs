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
	public class Purchase_Order_Change_Order_Outbound_DataType : INotifyPropertyChanged
	{
		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private string change_Order_Reference_IDField;

		private string document_NumberField;

		private decimal order_VersionField;

		private bool order_VersionFieldSpecified;

		private string change_Order_StatusField;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private bool acknowledgement_ExpectedField;

		private bool acknowledgement_ExpectedFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal other_ChargesField;

		private bool other_ChargesFieldSpecified;

		private Worker_Credit_CardObjectType procurement_Credit_Card_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType override_Payment_Type_ReferenceField;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Shipping_TermsObjectType shipping_Terms_ReferenceField;

		private Shipping_MethodObjectType shipping_Method_ReferenceField;

		private string shipping_InstructionField;

		private Supplier_Contract_BaseObjectType supplier_Contract_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Tax_OptionObjectType tax_Option_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private Purchase_Order_Issue_OptionObjectType issue_Option_ReferenceField;

		private WorkerObjectType buyer_ReferenceField;

		private WorkerObjectType bill_To_Contact_ReferenceField;

		private string bill_To_Contact_DetailField;

		private Bill_To_Address_ReferenceType bill_To_Address_DataField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private string ship_To_Contact_DetailField;

		private Ship_To_Address_ReferenceType ship_To_Address_DataField;

		private string memoField;

		private string internal_MemoField;

		private decimal percent_to_RetainField;

		private bool percent_to_RetainFieldSpecified;

		private DateTime estimated_Retention_Release_DateField;

		private bool estimated_Retention_Release_DateFieldSpecified;

		private bool third_Party_RetentionField;

		private bool third_Party_RetentionFieldSpecified;

		private string retention_MemoField;

		private Prepaid_Amortization_TypeObjectType prepayment_Release_Type_ReferenceField;

		private DateTime expected_Release_DateField;

		private bool expected_Release_DateFieldSpecified;

		private bool use_Prepaid_Posting_Rules_for_Receipt_AccrualsField;

		private bool use_Prepaid_Posting_Rules_for_Receipt_AccrualsFieldSpecified;

		private Change_Order_Item_Order_Line_WWS_DataType[] goods_Line_DataField;

		private Change_Order_Service_Order_Line_WWS_DataType[] service_Line_DataField;

		private Taxable_Code_Application_NO_INPUT_DataType[] tax_Code_DataField;

		private Business_Document_Attachment_with_External_Option_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Change_Order_Reference_ID
		{
			get
			{
				return this.change_Order_Reference_IDField;
			}
			set
			{
				this.change_Order_Reference_IDField = value;
				this.RaisePropertyChanged("Change_Order_Reference_ID");
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
		public decimal Order_Version
		{
			get
			{
				return this.order_VersionField;
			}
			set
			{
				this.order_VersionField = value;
				this.RaisePropertyChanged("Order_Version");
			}
		}

		[XmlIgnore]
		public bool Order_VersionSpecified
		{
			get
			{
				return this.order_VersionFieldSpecified;
			}
			set
			{
				this.order_VersionFieldSpecified = value;
				this.RaisePropertyChanged("Order_VersionSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Change_Order_Status
		{
			get
			{
				return this.change_Order_StatusField;
			}
			set
			{
				this.change_Order_StatusField = value;
				this.RaisePropertyChanged("Change_Order_Status");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(Order = 8)]
		public bool Acknowledgement_Expected
		{
			get
			{
				return this.acknowledgement_ExpectedField;
			}
			set
			{
				this.acknowledgement_ExpectedField = value;
				this.RaisePropertyChanged("Acknowledgement_Expected");
			}
		}

		[XmlIgnore]
		public bool Acknowledgement_ExpectedSpecified
		{
			get
			{
				return this.acknowledgement_ExpectedFieldSpecified;
			}
			set
			{
				this.acknowledgement_ExpectedFieldSpecified = value;
				this.RaisePropertyChanged("Acknowledgement_ExpectedSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Tax_Amount
		{
			get
			{
				return this.tax_AmountField;
			}
			set
			{
				this.tax_AmountField = value;
				this.RaisePropertyChanged("Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Tax_AmountSpecified
		{
			get
			{
				return this.tax_AmountFieldSpecified;
			}
			set
			{
				this.tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public decimal Other_Charges
		{
			get
			{
				return this.other_ChargesField;
			}
			set
			{
				this.other_ChargesField = value;
				this.RaisePropertyChanged("Other_Charges");
			}
		}

		[XmlIgnore]
		public bool Other_ChargesSpecified
		{
			get
			{
				return this.other_ChargesFieldSpecified;
			}
			set
			{
				this.other_ChargesFieldSpecified = value;
				this.RaisePropertyChanged("Other_ChargesSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
		public string Shipping_Instruction
		{
			get
			{
				return this.shipping_InstructionField;
			}
			set
			{
				this.shipping_InstructionField = value;
				this.RaisePropertyChanged("Shipping_Instruction");
			}
		}

		[XmlElement(Order = 19)]
		public Supplier_Contract_BaseObjectType Supplier_Contract_Reference
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

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
		public Tax_OptionObjectType Tax_Option_Reference
		{
			get
			{
				return this.tax_Option_ReferenceField;
			}
			set
			{
				this.tax_Option_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Option_Reference");
			}
		}

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
		public Purchase_Order_Issue_OptionObjectType Issue_Option_Reference
		{
			get
			{
				return this.issue_Option_ReferenceField;
			}
			set
			{
				this.issue_Option_ReferenceField = value;
				this.RaisePropertyChanged("Issue_Option_Reference");
			}
		}

		[XmlElement(Order = 24)]
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

		[XmlElement(Order = 25)]
		public WorkerObjectType Bill_To_Contact_Reference
		{
			get
			{
				return this.bill_To_Contact_ReferenceField;
			}
			set
			{
				this.bill_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Bill_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public string Bill_To_Contact_Detail
		{
			get
			{
				return this.bill_To_Contact_DetailField;
			}
			set
			{
				this.bill_To_Contact_DetailField = value;
				this.RaisePropertyChanged("Bill_To_Contact_Detail");
			}
		}

		[XmlElement(Order = 27)]
		public Bill_To_Address_ReferenceType Bill_To_Address_Data
		{
			get
			{
				return this.bill_To_Address_DataField;
			}
			set
			{
				this.bill_To_Address_DataField = value;
				this.RaisePropertyChanged("Bill_To_Address_Data");
			}
		}

		[XmlElement(Order = 28)]
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

		[XmlElement(Order = 29)]
		public string Ship_To_Contact_Detail
		{
			get
			{
				return this.ship_To_Contact_DetailField;
			}
			set
			{
				this.ship_To_Contact_DetailField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Detail");
			}
		}

		[XmlElement(Order = 30)]
		public Ship_To_Address_ReferenceType Ship_To_Address_Data
		{
			get
			{
				return this.ship_To_Address_DataField;
			}
			set
			{
				this.ship_To_Address_DataField = value;
				this.RaisePropertyChanged("Ship_To_Address_Data");
			}
		}

		[XmlElement(Order = 31)]
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

		[XmlElement(Order = 32)]
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

		[XmlElement(Order = 33)]
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

		[XmlElement(DataType = "date", Order = 34)]
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

		[XmlElement(Order = 35)]
		public bool Third_Party_Retention
		{
			get
			{
				return this.third_Party_RetentionField;
			}
			set
			{
				this.third_Party_RetentionField = value;
				this.RaisePropertyChanged("Third_Party_Retention");
			}
		}

		[XmlIgnore]
		public bool Third_Party_RetentionSpecified
		{
			get
			{
				return this.third_Party_RetentionFieldSpecified;
			}
			set
			{
				this.third_Party_RetentionFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_RetentionSpecified");
			}
		}

		[XmlElement(Order = 36)]
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

		[XmlElement(Order = 37)]
		public Prepaid_Amortization_TypeObjectType Prepayment_Release_Type_Reference
		{
			get
			{
				return this.prepayment_Release_Type_ReferenceField;
			}
			set
			{
				this.prepayment_Release_Type_ReferenceField = value;
				this.RaisePropertyChanged("Prepayment_Release_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 38)]
		public DateTime Expected_Release_Date
		{
			get
			{
				return this.expected_Release_DateField;
			}
			set
			{
				this.expected_Release_DateField = value;
				this.RaisePropertyChanged("Expected_Release_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Release_DateSpecified
		{
			get
			{
				return this.expected_Release_DateFieldSpecified;
			}
			set
			{
				this.expected_Release_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Release_DateSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool Use_Prepaid_Posting_Rules_for_Receipt_Accruals
		{
			get
			{
				return this.use_Prepaid_Posting_Rules_for_Receipt_AccrualsField;
			}
			set
			{
				this.use_Prepaid_Posting_Rules_for_Receipt_AccrualsField = value;
				this.RaisePropertyChanged("Use_Prepaid_Posting_Rules_for_Receipt_Accruals");
			}
		}

		[XmlIgnore]
		public bool Use_Prepaid_Posting_Rules_for_Receipt_AccrualsSpecified
		{
			get
			{
				return this.use_Prepaid_Posting_Rules_for_Receipt_AccrualsFieldSpecified;
			}
			set
			{
				this.use_Prepaid_Posting_Rules_for_Receipt_AccrualsFieldSpecified = value;
				this.RaisePropertyChanged("Use_Prepaid_Posting_Rules_for_Receipt_AccrualsSpecified");
			}
		}

		[XmlElement("Goods_Line_Data", Order = 40)]
		public Change_Order_Item_Order_Line_WWS_DataType[] Goods_Line_Data
		{
			get
			{
				return this.goods_Line_DataField;
			}
			set
			{
				this.goods_Line_DataField = value;
				this.RaisePropertyChanged("Goods_Line_Data");
			}
		}

		[XmlElement("Service_Line_Data", Order = 41)]
		public Change_Order_Service_Order_Line_WWS_DataType[] Service_Line_Data
		{
			get
			{
				return this.service_Line_DataField;
			}
			set
			{
				this.service_Line_DataField = value;
				this.RaisePropertyChanged("Service_Line_Data");
			}
		}

		[XmlElement("Tax_Code_Data", Order = 42)]
		public Taxable_Code_Application_NO_INPUT_DataType[] Tax_Code_Data
		{
			get
			{
				return this.tax_Code_DataField;
			}
			set
			{
				this.tax_Code_DataField = value;
				this.RaisePropertyChanged("Tax_Code_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 43)]
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
