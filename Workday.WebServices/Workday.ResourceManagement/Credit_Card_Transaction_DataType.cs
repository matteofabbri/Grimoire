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
	public class Credit_Card_Transaction_DataType : INotifyPropertyChanged
	{
		private string transaction_NumberField;

		private Credit_Card_Transaction_FileObjectType[] expense_Credit_Card_Transaction_File_ReferenceField;

		private DateTime transaction_DateField;

		private DateTime billing_DateField;

		private DateTime posted_DateField;

		private bool posted_DateFieldSpecified;

		private Merchant_CodeObjectType merchant_Code_ReferenceField;

		private string merchant_CodeField;

		private string merchant_Tax_IDField;

		private Merchant_CodeObjectType mIS_Industry_Code_ReferenceField;

		private string mIS_Industry_CodeField;

		private string market_CodeField;

		private string supplier_Reference_NumberField;

		private string dUNS_Number_for_SupplierField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private bool sales_Taxes_CollectedField;

		private bool sales_Taxes_CollectedFieldSpecified;

		private CurrencyObjectType source_Currency_ReferenceField;

		private decimal currency_Exchange_RateField;

		private bool currency_Exchange_RateFieldSpecified;

		private decimal converted_AmountField;

		private bool converted_AmountFieldSpecified;

		private decimal converted_Tax_AmountField;

		private bool converted_Tax_AmountFieldSpecified;

		private CurrencyObjectType converted_Currency_ReferenceField;

		private decimal euro_Billed_AmountField;

		private bool euro_Billed_AmountFieldSpecified;

		private decimal euro_Billed_Tax_AmountField;

		private bool euro_Billed_Tax_AmountFieldSpecified;

		private string transaction_Type_CodeField;

		private Credit_Card_Transaction_TypeObjectType transaction_Type_ReferenceField;

		private string financial_Category_CodeField;

		private string charge_Description_Line_1Field;

		private string charge_Description_Line_2Field;

		private Cost_CenterObjectType cost_Center_ReferenceField;

		private string purchase_Order_NumberField;

		private string release_NumberField;

		private string expense_Credit_Card_TokenField;

		private Corporate_Credit_Card_AccountObjectType corporate_Account_ReferenceField;

		private string employee_IDField;

		private string cardholder_NameField;

		private string account_NumberField;

		private string charge_DescriptionField;

		private decimal number_of_Days_or_NightsField;

		private bool number_of_Days_or_NightsFieldSpecified;

		private string credit_Card_Merchant_NameField;

		private string credit_Card_Merchant_LocationField;

		private DateTime arrival_DateField;

		private bool arrival_DateFieldSpecified;

		private DateTime departure_DateField;

		private bool departure_DateFieldSpecified;

		private string reference_NumberField;

		private string participant_NameField;

		private decimal daily_RateField;

		private bool daily_RateFieldSpecified;

		private bool domesticField;

		private bool domesticFieldSpecified;

		private string ticket_NumberField;

		private string class_of_ServiceField;

		private string air_RoutingField;

		private string air_Carrier_CodeField;

		private string origination_CityField;

		private string origination_StateField;

		private string origination_CountryField;

		private string destination_CityField;

		private string destination_StateField;

		private string destination_CountryField;

		private Class_of_ServiceObjectType class_of_Service_ReferenceField;

		private Expense_StatusObjectType credit_Card_Transaction_Status_ReferenceField;

		private CC_Transaction_LineType[] credit_Card_Transaction_Line_DataField;

		private Credit_Card_Transaction_Name_Match_DataType[] name_Match_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Transaction_Number
		{
			get
			{
				return this.transaction_NumberField;
			}
			set
			{
				this.transaction_NumberField = value;
				this.RaisePropertyChanged("Transaction_Number");
			}
		}

		[XmlElement("Expense_Credit_Card_Transaction_File_Reference", Order = 1)]
		public Credit_Card_Transaction_FileObjectType[] Expense_Credit_Card_Transaction_File_Reference
		{
			get
			{
				return this.expense_Credit_Card_Transaction_File_ReferenceField;
			}
			set
			{
				this.expense_Credit_Card_Transaction_File_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Transaction_File_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Billing_Date
		{
			get
			{
				return this.billing_DateField;
			}
			set
			{
				this.billing_DateField = value;
				this.RaisePropertyChanged("Billing_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Posted_Date
		{
			get
			{
				return this.posted_DateField;
			}
			set
			{
				this.posted_DateField = value;
				this.RaisePropertyChanged("Posted_Date");
			}
		}

		[XmlIgnore]
		public bool Posted_DateSpecified
		{
			get
			{
				return this.posted_DateFieldSpecified;
			}
			set
			{
				this.posted_DateFieldSpecified = value;
				this.RaisePropertyChanged("Posted_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Merchant_CodeObjectType Merchant_Code_Reference
		{
			get
			{
				return this.merchant_Code_ReferenceField;
			}
			set
			{
				this.merchant_Code_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Code_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Merchant_Code
		{
			get
			{
				return this.merchant_CodeField;
			}
			set
			{
				this.merchant_CodeField = value;
				this.RaisePropertyChanged("Merchant_Code");
			}
		}

		[XmlElement(Order = 7)]
		public string Merchant_Tax_ID
		{
			get
			{
				return this.merchant_Tax_IDField;
			}
			set
			{
				this.merchant_Tax_IDField = value;
				this.RaisePropertyChanged("Merchant_Tax_ID");
			}
		}

		[XmlElement(Order = 8)]
		public Merchant_CodeObjectType MIS_Industry_Code_Reference
		{
			get
			{
				return this.mIS_Industry_Code_ReferenceField;
			}
			set
			{
				this.mIS_Industry_Code_ReferenceField = value;
				this.RaisePropertyChanged("MIS_Industry_Code_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public string MIS_Industry_Code
		{
			get
			{
				return this.mIS_Industry_CodeField;
			}
			set
			{
				this.mIS_Industry_CodeField = value;
				this.RaisePropertyChanged("MIS_Industry_Code");
			}
		}

		[XmlElement(Order = 10)]
		public string Market_Code
		{
			get
			{
				return this.market_CodeField;
			}
			set
			{
				this.market_CodeField = value;
				this.RaisePropertyChanged("Market_Code");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public string DUNS_Number_for_Supplier
		{
			get
			{
				return this.dUNS_Number_for_SupplierField;
			}
			set
			{
				this.dUNS_Number_for_SupplierField = value;
				this.RaisePropertyChanged("DUNS_Number_for_Supplier");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public bool Sales_Taxes_Collected
		{
			get
			{
				return this.sales_Taxes_CollectedField;
			}
			set
			{
				this.sales_Taxes_CollectedField = value;
				this.RaisePropertyChanged("Sales_Taxes_Collected");
			}
		}

		[XmlIgnore]
		public bool Sales_Taxes_CollectedSpecified
		{
			get
			{
				return this.sales_Taxes_CollectedFieldSpecified;
			}
			set
			{
				this.sales_Taxes_CollectedFieldSpecified = value;
				this.RaisePropertyChanged("Sales_Taxes_CollectedSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public CurrencyObjectType Source_Currency_Reference
		{
			get
			{
				return this.source_Currency_ReferenceField;
			}
			set
			{
				this.source_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Source_Currency_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Currency_Exchange_Rate
		{
			get
			{
				return this.currency_Exchange_RateField;
			}
			set
			{
				this.currency_Exchange_RateField = value;
				this.RaisePropertyChanged("Currency_Exchange_Rate");
			}
		}

		[XmlIgnore]
		public bool Currency_Exchange_RateSpecified
		{
			get
			{
				return this.currency_Exchange_RateFieldSpecified;
			}
			set
			{
				this.currency_Exchange_RateFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Exchange_RateSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Converted_Amount
		{
			get
			{
				return this.converted_AmountField;
			}
			set
			{
				this.converted_AmountField = value;
				this.RaisePropertyChanged("Converted_Amount");
			}
		}

		[XmlIgnore]
		public bool Converted_AmountSpecified
		{
			get
			{
				return this.converted_AmountFieldSpecified;
			}
			set
			{
				this.converted_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Converted_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Converted_Tax_Amount
		{
			get
			{
				return this.converted_Tax_AmountField;
			}
			set
			{
				this.converted_Tax_AmountField = value;
				this.RaisePropertyChanged("Converted_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Converted_Tax_AmountSpecified
		{
			get
			{
				return this.converted_Tax_AmountFieldSpecified;
			}
			set
			{
				this.converted_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Converted_Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public CurrencyObjectType Converted_Currency_Reference
		{
			get
			{
				return this.converted_Currency_ReferenceField;
			}
			set
			{
				this.converted_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Converted_Currency_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Euro_Billed_Amount
		{
			get
			{
				return this.euro_Billed_AmountField;
			}
			set
			{
				this.euro_Billed_AmountField = value;
				this.RaisePropertyChanged("Euro_Billed_Amount");
			}
		}

		[XmlIgnore]
		public bool Euro_Billed_AmountSpecified
		{
			get
			{
				return this.euro_Billed_AmountFieldSpecified;
			}
			set
			{
				this.euro_Billed_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Euro_Billed_AmountSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Euro_Billed_Tax_Amount
		{
			get
			{
				return this.euro_Billed_Tax_AmountField;
			}
			set
			{
				this.euro_Billed_Tax_AmountField = value;
				this.RaisePropertyChanged("Euro_Billed_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Euro_Billed_Tax_AmountSpecified
		{
			get
			{
				return this.euro_Billed_Tax_AmountFieldSpecified;
			}
			set
			{
				this.euro_Billed_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Euro_Billed_Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public string Transaction_Type_Code
		{
			get
			{
				return this.transaction_Type_CodeField;
			}
			set
			{
				this.transaction_Type_CodeField = value;
				this.RaisePropertyChanged("Transaction_Type_Code");
			}
		}

		[XmlElement(Order = 24)]
		public Credit_Card_Transaction_TypeObjectType Transaction_Type_Reference
		{
			get
			{
				return this.transaction_Type_ReferenceField;
			}
			set
			{
				this.transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Type_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public string Financial_Category_Code
		{
			get
			{
				return this.financial_Category_CodeField;
			}
			set
			{
				this.financial_Category_CodeField = value;
				this.RaisePropertyChanged("Financial_Category_Code");
			}
		}

		[XmlElement(Order = 26)]
		public string Charge_Description_Line_1
		{
			get
			{
				return this.charge_Description_Line_1Field;
			}
			set
			{
				this.charge_Description_Line_1Field = value;
				this.RaisePropertyChanged("Charge_Description_Line_1");
			}
		}

		[XmlElement(Order = 27)]
		public string Charge_Description_Line_2
		{
			get
			{
				return this.charge_Description_Line_2Field;
			}
			set
			{
				this.charge_Description_Line_2Field = value;
				this.RaisePropertyChanged("Charge_Description_Line_2");
			}
		}

		[XmlElement(Order = 28)]
		public Cost_CenterObjectType Cost_Center_Reference
		{
			get
			{
				return this.cost_Center_ReferenceField;
			}
			set
			{
				this.cost_Center_ReferenceField = value;
				this.RaisePropertyChanged("Cost_Center_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public string Purchase_Order_Number
		{
			get
			{
				return this.purchase_Order_NumberField;
			}
			set
			{
				this.purchase_Order_NumberField = value;
				this.RaisePropertyChanged("Purchase_Order_Number");
			}
		}

		[XmlElement(Order = 30)]
		public string Release_Number
		{
			get
			{
				return this.release_NumberField;
			}
			set
			{
				this.release_NumberField = value;
				this.RaisePropertyChanged("Release_Number");
			}
		}

		[XmlElement(Order = 31)]
		public string Expense_Credit_Card_Token
		{
			get
			{
				return this.expense_Credit_Card_TokenField;
			}
			set
			{
				this.expense_Credit_Card_TokenField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Token");
			}
		}

		[XmlElement(Order = 32)]
		public Corporate_Credit_Card_AccountObjectType Corporate_Account_Reference
		{
			get
			{
				return this.corporate_Account_ReferenceField;
			}
			set
			{
				this.corporate_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Account_Reference");
			}
		}

		[XmlElement(Order = 33)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 34)]
		public string Cardholder_Name
		{
			get
			{
				return this.cardholder_NameField;
			}
			set
			{
				this.cardholder_NameField = value;
				this.RaisePropertyChanged("Cardholder_Name");
			}
		}

		[XmlElement(Order = 35)]
		public string Account_Number
		{
			get
			{
				return this.account_NumberField;
			}
			set
			{
				this.account_NumberField = value;
				this.RaisePropertyChanged("Account_Number");
			}
		}

		[XmlElement(Order = 36)]
		public string Charge_Description
		{
			get
			{
				return this.charge_DescriptionField;
			}
			set
			{
				this.charge_DescriptionField = value;
				this.RaisePropertyChanged("Charge_Description");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Number_of_Days_or_Nights
		{
			get
			{
				return this.number_of_Days_or_NightsField;
			}
			set
			{
				this.number_of_Days_or_NightsField = value;
				this.RaisePropertyChanged("Number_of_Days_or_Nights");
			}
		}

		[XmlIgnore]
		public bool Number_of_Days_or_NightsSpecified
		{
			get
			{
				return this.number_of_Days_or_NightsFieldSpecified;
			}
			set
			{
				this.number_of_Days_or_NightsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_Days_or_NightsSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public string Credit_Card_Merchant_Name
		{
			get
			{
				return this.credit_Card_Merchant_NameField;
			}
			set
			{
				this.credit_Card_Merchant_NameField = value;
				this.RaisePropertyChanged("Credit_Card_Merchant_Name");
			}
		}

		[XmlElement(Order = 39)]
		public string Credit_Card_Merchant_Location
		{
			get
			{
				return this.credit_Card_Merchant_LocationField;
			}
			set
			{
				this.credit_Card_Merchant_LocationField = value;
				this.RaisePropertyChanged("Credit_Card_Merchant_Location");
			}
		}

		[XmlElement(DataType = "date", Order = 40)]
		public DateTime Arrival_Date
		{
			get
			{
				return this.arrival_DateField;
			}
			set
			{
				this.arrival_DateField = value;
				this.RaisePropertyChanged("Arrival_Date");
			}
		}

		[XmlIgnore]
		public bool Arrival_DateSpecified
		{
			get
			{
				return this.arrival_DateFieldSpecified;
			}
			set
			{
				this.arrival_DateFieldSpecified = value;
				this.RaisePropertyChanged("Arrival_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 41)]
		public DateTime Departure_Date
		{
			get
			{
				return this.departure_DateField;
			}
			set
			{
				this.departure_DateField = value;
				this.RaisePropertyChanged("Departure_Date");
			}
		}

		[XmlIgnore]
		public bool Departure_DateSpecified
		{
			get
			{
				return this.departure_DateFieldSpecified;
			}
			set
			{
				this.departure_DateFieldSpecified = value;
				this.RaisePropertyChanged("Departure_DateSpecified");
			}
		}

		[XmlElement(Order = 42)]
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

		[XmlElement(Order = 43)]
		public string Participant_Name
		{
			get
			{
				return this.participant_NameField;
			}
			set
			{
				this.participant_NameField = value;
				this.RaisePropertyChanged("Participant_Name");
			}
		}

		[XmlElement(Order = 44)]
		public decimal Daily_Rate
		{
			get
			{
				return this.daily_RateField;
			}
			set
			{
				this.daily_RateField = value;
				this.RaisePropertyChanged("Daily_Rate");
			}
		}

		[XmlIgnore]
		public bool Daily_RateSpecified
		{
			get
			{
				return this.daily_RateFieldSpecified;
			}
			set
			{
				this.daily_RateFieldSpecified = value;
				this.RaisePropertyChanged("Daily_RateSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public bool Domestic
		{
			get
			{
				return this.domesticField;
			}
			set
			{
				this.domesticField = value;
				this.RaisePropertyChanged("Domestic");
			}
		}

		[XmlIgnore]
		public bool DomesticSpecified
		{
			get
			{
				return this.domesticFieldSpecified;
			}
			set
			{
				this.domesticFieldSpecified = value;
				this.RaisePropertyChanged("DomesticSpecified");
			}
		}

		[XmlElement(Order = 46)]
		public string Ticket_Number
		{
			get
			{
				return this.ticket_NumberField;
			}
			set
			{
				this.ticket_NumberField = value;
				this.RaisePropertyChanged("Ticket_Number");
			}
		}

		[XmlElement(Order = 47)]
		public string Class_of_Service
		{
			get
			{
				return this.class_of_ServiceField;
			}
			set
			{
				this.class_of_ServiceField = value;
				this.RaisePropertyChanged("Class_of_Service");
			}
		}

		[XmlElement(Order = 48)]
		public string Air_Routing
		{
			get
			{
				return this.air_RoutingField;
			}
			set
			{
				this.air_RoutingField = value;
				this.RaisePropertyChanged("Air_Routing");
			}
		}

		[XmlElement(Order = 49)]
		public string Air_Carrier_Code
		{
			get
			{
				return this.air_Carrier_CodeField;
			}
			set
			{
				this.air_Carrier_CodeField = value;
				this.RaisePropertyChanged("Air_Carrier_Code");
			}
		}

		[XmlElement(Order = 50)]
		public string Origination_City
		{
			get
			{
				return this.origination_CityField;
			}
			set
			{
				this.origination_CityField = value;
				this.RaisePropertyChanged("Origination_City");
			}
		}

		[XmlElement(Order = 51)]
		public string Origination_State
		{
			get
			{
				return this.origination_StateField;
			}
			set
			{
				this.origination_StateField = value;
				this.RaisePropertyChanged("Origination_State");
			}
		}

		[XmlElement(Order = 52)]
		public string Origination_Country
		{
			get
			{
				return this.origination_CountryField;
			}
			set
			{
				this.origination_CountryField = value;
				this.RaisePropertyChanged("Origination_Country");
			}
		}

		[XmlElement(Order = 53)]
		public string Destination_City
		{
			get
			{
				return this.destination_CityField;
			}
			set
			{
				this.destination_CityField = value;
				this.RaisePropertyChanged("Destination_City");
			}
		}

		[XmlElement(Order = 54)]
		public string Destination_State
		{
			get
			{
				return this.destination_StateField;
			}
			set
			{
				this.destination_StateField = value;
				this.RaisePropertyChanged("Destination_State");
			}
		}

		[XmlElement(Order = 55)]
		public string Destination_Country
		{
			get
			{
				return this.destination_CountryField;
			}
			set
			{
				this.destination_CountryField = value;
				this.RaisePropertyChanged("Destination_Country");
			}
		}

		[XmlElement(Order = 56)]
		public Class_of_ServiceObjectType Class_of_Service_Reference
		{
			get
			{
				return this.class_of_Service_ReferenceField;
			}
			set
			{
				this.class_of_Service_ReferenceField = value;
				this.RaisePropertyChanged("Class_of_Service_Reference");
			}
		}

		[XmlElement(Order = 57)]
		public Expense_StatusObjectType Credit_Card_Transaction_Status_Reference
		{
			get
			{
				return this.credit_Card_Transaction_Status_ReferenceField;
			}
			set
			{
				this.credit_Card_Transaction_Status_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Status_Reference");
			}
		}

		[XmlElement("Credit_Card_Transaction_Line_Data", Order = 58)]
		public CC_Transaction_LineType[] Credit_Card_Transaction_Line_Data
		{
			get
			{
				return this.credit_Card_Transaction_Line_DataField;
			}
			set
			{
				this.credit_Card_Transaction_Line_DataField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Line_Data");
			}
		}

		[XmlElement("Name_Match_Data", Order = 59)]
		public Credit_Card_Transaction_Name_Match_DataType[] Name_Match_Data
		{
			get
			{
				return this.name_Match_DataField;
			}
			set
			{
				this.name_Match_DataField = value;
				this.RaisePropertyChanged("Name_Match_Data");
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
