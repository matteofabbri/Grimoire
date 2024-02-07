using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Ad_hoc_Payment_DataType : INotifyPropertyChanged
	{
		private string ad_hoc_Payment_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Financial_AccountObjectType bank_Account_ReferenceField;

		private object itemField;

		private Tax_Authority_Form_TypeObjectType tax_Authority_Form_Type_ReferenceField;

		private bool iRS_1099_MISC_PayeeField;

		private bool iRS_1099_MISC_PayeeFieldSpecified;

		private Taxpayer_ID_Number_TypeObjectType tIN_Type_ReferenceField;

		private string tax_IDField;

		private CurrencyObjectType currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private decimal currency_Conversion_RateField;

		private bool currency_Conversion_RateFieldSpecified;

		private bool eliminate_Foreign_Exchange_Gain_or_LossField;

		private bool eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified;

		private Tax_OptionObjectType tax_Option_ReferenceField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private DateTime payment_DateField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string memoField;

		private string reference_NumberField;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal other_ChargesField;

		private bool other_ChargesFieldSpecified;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private string addenda_Lines_as_TextField;

		private string external_Reference_as_TextField;

		private Supplier_Invoice_Line_Replacement_DataType[] invoice_Line_Replacement_DataField;

		private Taxable_Code_Application_DataType[] tax_Code_DataField;

		private Address_Information_DataType[] address_DataField;

		private Settlement_Account_WWS_DataType[] bank_DataField;

		private Business_Entity_Alternate_Name_DataType[] payee_Alternate_Name_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ad_hoc_Payment_ID
		{
			get
			{
				return this.ad_hoc_Payment_IDField;
			}
			set
			{
				this.ad_hoc_Payment_IDField = value;
				this.RaisePropertyChanged("Ad_hoc_Payment_ID");
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
		public Financial_AccountObjectType Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
			}
		}

		[XmlElement("Create_new_Ad_hoc_Payee_Name", typeof(string), Order = 4), XmlElement("Payee_Reference", typeof(PayeeObjectType), Order = 4)]
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

		[XmlElement(Order = 5)]
		public Tax_Authority_Form_TypeObjectType Tax_Authority_Form_Type_Reference
		{
			get
			{
				return this.tax_Authority_Form_Type_ReferenceField;
			}
			set
			{
				this.tax_Authority_Form_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Authority_Form_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool IRS_1099_MISC_Payee
		{
			get
			{
				return this.iRS_1099_MISC_PayeeField;
			}
			set
			{
				this.iRS_1099_MISC_PayeeField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Payee");
			}
		}

		[XmlIgnore]
		public bool IRS_1099_MISC_PayeeSpecified
		{
			get
			{
				return this.iRS_1099_MISC_PayeeFieldSpecified;
			}
			set
			{
				this.iRS_1099_MISC_PayeeFieldSpecified = value;
				this.RaisePropertyChanged("IRS_1099_MISC_PayeeSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Taxpayer_ID_Number_TypeObjectType TIN_Type_Reference
		{
			get
			{
				return this.tIN_Type_ReferenceField;
			}
			set
			{
				this.tIN_Type_ReferenceField = value;
				this.RaisePropertyChanged("TIN_Type_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Tax_ID
		{
			get
			{
				return this.tax_IDField;
			}
			set
			{
				this.tax_IDField = value;
				this.RaisePropertyChanged("Tax_ID");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Currency_Conversion_Rate
		{
			get
			{
				return this.currency_Conversion_RateField;
			}
			set
			{
				this.currency_Conversion_RateField = value;
				this.RaisePropertyChanged("Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool Currency_Conversion_RateSpecified
		{
			get
			{
				return this.currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Eliminate_Foreign_Exchange_Gain_or_Loss
		{
			get
			{
				return this.eliminate_Foreign_Exchange_Gain_or_LossField;
			}
			set
			{
				this.eliminate_Foreign_Exchange_Gain_or_LossField = value;
				this.RaisePropertyChanged("Eliminate_Foreign_Exchange_Gain_or_Loss");
			}
		}

		[XmlIgnore]
		public bool Eliminate_Foreign_Exchange_Gain_or_LossSpecified
		{
			get
			{
				return this.eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified;
			}
			set
			{
				this.eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified = value;
				this.RaisePropertyChanged("Eliminate_Foreign_Exchange_Gain_or_LossSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public string Reference_Number
		{
			get
			{
				return this.reference_NumberField;
			}
			set
			{
				this.reference_NumberField = value;
				this.RaisePropertyChanged("Reference_Number");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Control_Total_Amount
		{
			get
			{
				return this.control_Total_AmountField;
			}
			set
			{
				this.control_Total_AmountField = value;
				this.RaisePropertyChanged("Control_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Control_Total_AmountSpecified
		{
			get
			{
				return this.control_Total_AmountFieldSpecified;
			}
			set
			{
				this.control_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Control_Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
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

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
		public Payment_Handling_InstructionObjectType Handling_Code_Reference
		{
			get
			{
				return this.handling_Code_ReferenceField;
			}
			set
			{
				this.handling_Code_ReferenceField = value;
				this.RaisePropertyChanged("Handling_Code_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public string Addenda_Lines_as_Text
		{
			get
			{
				return this.addenda_Lines_as_TextField;
			}
			set
			{
				this.addenda_Lines_as_TextField = value;
				this.RaisePropertyChanged("Addenda_Lines_as_Text");
			}
		}

		[XmlElement(Order = 26)]
		public string External_Reference_as_Text
		{
			get
			{
				return this.external_Reference_as_TextField;
			}
			set
			{
				this.external_Reference_as_TextField = value;
				this.RaisePropertyChanged("External_Reference_as_Text");
			}
		}

		[XmlElement("Invoice_Line_Replacement_Data", Order = 27)]
		public Supplier_Invoice_Line_Replacement_DataType[] Invoice_Line_Replacement_Data
		{
			get
			{
				return this.invoice_Line_Replacement_DataField;
			}
			set
			{
				this.invoice_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Invoice_Line_Replacement_Data");
			}
		}

		[XmlElement("Tax_Code_Data", Order = 28)]
		public Taxable_Code_Application_DataType[] Tax_Code_Data
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

		[XmlElement("Address_Data", Order = 29)]
		public Address_Information_DataType[] Address_Data
		{
			get
			{
				return this.address_DataField;
			}
			set
			{
				this.address_DataField = value;
				this.RaisePropertyChanged("Address_Data");
			}
		}

		[XmlElement("Bank_Data", Order = 30)]
		public Settlement_Account_WWS_DataType[] Bank_Data
		{
			get
			{
				return this.bank_DataField;
			}
			set
			{
				this.bank_DataField = value;
				this.RaisePropertyChanged("Bank_Data");
			}
		}

		[XmlElement("Payee_Alternate_Name_Data", Order = 31)]
		public Business_Entity_Alternate_Name_DataType[] Payee_Alternate_Name_Data
		{
			get
			{
				return this.payee_Alternate_Name_DataField;
			}
			set
			{
				this.payee_Alternate_Name_DataField = value;
				this.RaisePropertyChanged("Payee_Alternate_Name_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 32)]
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
