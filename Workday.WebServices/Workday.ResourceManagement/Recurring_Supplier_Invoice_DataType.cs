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
	public class Recurring_Supplier_Invoice_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Contract_IDField;

		private string contract_NameField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private object itemField;

		private string supplier_Reference_NumberField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private string contract_OverviewField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private bool item1Field;

		private Item1ChoiceType1 item1ElementNameField;

		private Frequency_BehaviorObjectType frequency_Type_ReferenceField;

		private Tax_OptionObjectType tax_Option_ReferenceField;

		private Tax_CodeObjectType default_Tax_Code_ReferenceField;

		private DateTime contract_Start_DateField;

		private DateTime first_Invoice_DateField;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private decimal total_Contract_AmountField;

		private bool total_Contract_AmountFieldSpecified;

		private Supplier_Invoice_Line_Replacement_DataType[] supplier_Invoice_Line_Replacement_DataField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_Override_ReferenceField;

		private DateTime currency_Rate_Date_OverrideField;

		private bool currency_Rate_Date_OverrideFieldSpecified;

		private decimal currency_Rate_Manual_OverrideField;

		private bool currency_Rate_Manual_OverrideFieldSpecified;

		private decimal document_Currency_Conversion_RateField;

		private bool document_Currency_Conversion_RateFieldSpecified;

		private bool rate_OverrideField;

		private bool rate_OverrideFieldSpecified;

		private decimal currency_Rate_Lookup_OverrideField;

		private bool currency_Rate_Lookup_OverrideFieldSpecified;

		private decimal manual_Override_PercentField;

		private bool manual_Override_PercentFieldSpecified;

		private Currency_Rate_TypeObjectType[] default_Rate_Type_ReferenceField;

		private DateTime rate_Basis_DateField;

		private bool rate_Basis_DateFieldSpecified;

		private decimal default_Currency_RateField;

		private bool default_Currency_RateFieldSpecified;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Taxable_Code_Application_DataType[] taxable_Code_DataField;

		private Withholding_Tax_Code_Application_DataType[] withholding_Tax_Code_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Contract_ID
		{
			get
			{
				return this.supplier_Invoice_Contract_IDField;
			}
			set
			{
				this.supplier_Invoice_Contract_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Contract_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Supplier_Connection_Reference", typeof(Supplier_ConnectionObjectType), Order = 3), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlChoiceIdentifier("Item1ElementName"), XmlElement("Fixed_Contract", typeof(bool), Order = 9), XmlElement("Variable_Contract", typeof(bool), Order = 9)]
		public bool Item1
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

		[XmlElement(Order = 10), XmlIgnore]
		public Item1ChoiceType1 Item1ElementName
		{
			get
			{
				return this.item1ElementNameField;
			}
			set
			{
				this.item1ElementNameField = value;
				this.RaisePropertyChanged("Item1ElementName");
			}
		}

		[XmlElement(Order = 11)]
		public Frequency_BehaviorObjectType Frequency_Type_Reference
		{
			get
			{
				return this.frequency_Type_ReferenceField;
			}
			set
			{
				this.frequency_Type_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Type_Reference");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(DataType = "date", Order = 14)]
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

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime First_Invoice_Date
		{
			get
			{
				return this.first_Invoice_DateField;
			}
			set
			{
				this.first_Invoice_DateField = value;
				this.RaisePropertyChanged("First_Invoice_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement("Supplier_Invoice_Line_Replacement_Data", Order = 18)]
		public Supplier_Invoice_Line_Replacement_DataType[] Supplier_Invoice_Line_Replacement_Data
		{
			get
			{
				return this.supplier_Invoice_Line_Replacement_DataField;
			}
			set
			{
				this.supplier_Invoice_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Line_Replacement_Data");
			}
		}

		[XmlElement(Order = 19)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Override_Reference
		{
			get
			{
				return this.currency_Rate_Type_Override_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_Override_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Override_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Currency_Rate_Date_Override
		{
			get
			{
				return this.currency_Rate_Date_OverrideField;
			}
			set
			{
				this.currency_Rate_Date_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Date_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Date_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Date_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Date_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Date_OverrideSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Currency_Rate_Manual_Override
		{
			get
			{
				return this.currency_Rate_Manual_OverrideField;
			}
			set
			{
				this.currency_Rate_Manual_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Manual_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Manual_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Manual_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Manual_OverrideSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Document_Currency_Conversion_Rate
		{
			get
			{
				return this.document_Currency_Conversion_RateField;
			}
			set
			{
				this.document_Currency_Conversion_RateField = value;
				this.RaisePropertyChanged("Document_Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool Document_Currency_Conversion_RateSpecified
		{
			get
			{
				return this.document_Currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.document_Currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("Document_Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public bool Rate_Override
		{
			get
			{
				return this.rate_OverrideField;
			}
			set
			{
				this.rate_OverrideField = value;
				this.RaisePropertyChanged("Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Rate_OverrideSpecified
		{
			get
			{
				return this.rate_OverrideFieldSpecified;
			}
			set
			{
				this.rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal Currency_Rate_Lookup_Override
		{
			get
			{
				return this.currency_Rate_Lookup_OverrideField;
			}
			set
			{
				this.currency_Rate_Lookup_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Lookup_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_Lookup_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_Lookup_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_Lookup_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_Lookup_OverrideSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public decimal Manual_Override_Percent
		{
			get
			{
				return this.manual_Override_PercentField;
			}
			set
			{
				this.manual_Override_PercentField = value;
				this.RaisePropertyChanged("Manual_Override_Percent");
			}
		}

		[XmlIgnore]
		public bool Manual_Override_PercentSpecified
		{
			get
			{
				return this.manual_Override_PercentFieldSpecified;
			}
			set
			{
				this.manual_Override_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Manual_Override_PercentSpecified");
			}
		}

		[XmlElement("Default_Rate_Type_Reference", Order = 26)]
		public Currency_Rate_TypeObjectType[] Default_Rate_Type_Reference
		{
			get
			{
				return this.default_Rate_Type_ReferenceField;
			}
			set
			{
				this.default_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Default_Rate_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 27)]
		public DateTime Rate_Basis_Date
		{
			get
			{
				return this.rate_Basis_DateField;
			}
			set
			{
				this.rate_Basis_DateField = value;
				this.RaisePropertyChanged("Rate_Basis_Date");
			}
		}

		[XmlIgnore]
		public bool Rate_Basis_DateSpecified
		{
			get
			{
				return this.rate_Basis_DateFieldSpecified;
			}
			set
			{
				this.rate_Basis_DateFieldSpecified = value;
				this.RaisePropertyChanged("Rate_Basis_DateSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public decimal Default_Currency_Rate
		{
			get
			{
				return this.default_Currency_RateField;
			}
			set
			{
				this.default_Currency_RateField = value;
				this.RaisePropertyChanged("Default_Currency_Rate");
			}
		}

		[XmlIgnore]
		public bool Default_Currency_RateSpecified
		{
			get
			{
				return this.default_Currency_RateFieldSpecified;
			}
			set
			{
				this.default_Currency_RateFieldSpecified = value;
				this.RaisePropertyChanged("Default_Currency_RateSpecified");
			}
		}

		[XmlElement("Attachment_Data", Order = 29)]
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

		[XmlElement("Taxable_Code_Data", Order = 30)]
		public Taxable_Code_Application_DataType[] Taxable_Code_Data
		{
			get
			{
				return this.taxable_Code_DataField;
			}
			set
			{
				this.taxable_Code_DataField = value;
				this.RaisePropertyChanged("Taxable_Code_Data");
			}
		}

		[XmlElement("Withholding_Tax_Code_Data", Order = 31)]
		public Withholding_Tax_Code_Application_DataType[] Withholding_Tax_Code_Data
		{
			get
			{
				return this.withholding_Tax_Code_DataField;
			}
			set
			{
				this.withholding_Tax_Code_DataField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Data");
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
