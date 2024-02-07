using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_WWS_DataType : INotifyPropertyChanged
	{
		private Payment_Group_DataType payment_Group_DataField;

		private Unique_IdentifierObjectType settlement_Run_ReferenceField;

		private string payment_StatusField;

		private string payment_MemoField;

		private string payment_Reference_NumberField;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private string amount_as_TextField;

		private decimal discount_TakenField;

		private bool discount_TakenFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string currency_SymbolField;

		private string currency_DescriptionField;

		private decimal check_or_Advice_NumberField;

		private bool check_or_Advice_NumberFieldSpecified;

		private string check_NumberField;

		private bool prenote_FlagField;

		private bool prenote_FlagFieldSpecified;

		private decimal payroll_Payment_Display_OrderField;

		private bool payroll_Payment_Display_OrderFieldSpecified;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CompanyObjectType[] on_Behalf_of_Company_ReferenceField;

		private Mandate_DataType mandate_DataField;

		private Originating_Party_WWS_DataType[] originating_Contact_DataField;

		private Originating_Party_Bank_DataType[] originating_Bank_DataField;

		private On_Behalf_Of_Company_WWS_DataType[] on_Behalf_Of_Company_DataField;

		private PayeeObjectType receiving_Party_ReferenceField;

		private Receiving_Party_WWS_DataType[] receiving_Party_Contact_DataField;

		private Receiving_Party_Bank_DataType[] receiving_Party_Bank_DataField;

		private Receiving_Party_Credit_Card_DataType receiving_Party_Credit_Card_DataField;

		private Remittance_DataType[] remittance_DataField;

		private Payroll_Remittance_DataType[] payroll_Remittance_DataField;

		private Payroll_Result_Country_DataType[] payroll_Result_Country_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_Group_DataType Payment_Group_Data
		{
			get
			{
				return this.payment_Group_DataField;
			}
			set
			{
				this.payment_Group_DataField = value;
				this.RaisePropertyChanged("Payment_Group_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Settlement_Run_Reference
		{
			get
			{
				return this.settlement_Run_ReferenceField;
			}
			set
			{
				this.settlement_Run_ReferenceField = value;
				this.RaisePropertyChanged("Settlement_Run_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Payment_Status
		{
			get
			{
				return this.payment_StatusField;
			}
			set
			{
				this.payment_StatusField = value;
				this.RaisePropertyChanged("Payment_Status");
			}
		}

		[XmlElement(Order = 3)]
		public string Payment_Memo
		{
			get
			{
				return this.payment_MemoField;
			}
			set
			{
				this.payment_MemoField = value;
				this.RaisePropertyChanged("Payment_Memo");
			}
		}

		[XmlElement(Order = 4)]
		public string Payment_Reference_Number
		{
			get
			{
				return this.payment_Reference_NumberField;
			}
			set
			{
				this.payment_Reference_NumberField = value;
				this.RaisePropertyChanged("Payment_Reference_Number");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Payment_Amount
		{
			get
			{
				return this.payment_AmountField;
			}
			set
			{
				this.payment_AmountField = value;
				this.RaisePropertyChanged("Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Payment_AmountSpecified
		{
			get
			{
				return this.payment_AmountFieldSpecified;
			}
			set
			{
				this.payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public string Amount_as_Text
		{
			get
			{
				return this.amount_as_TextField;
			}
			set
			{
				this.amount_as_TextField = value;
				this.RaisePropertyChanged("Amount_as_Text");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Discount_Taken
		{
			get
			{
				return this.discount_TakenField;
			}
			set
			{
				this.discount_TakenField = value;
				this.RaisePropertyChanged("Discount_Taken");
			}
		}

		[XmlIgnore]
		public bool Discount_TakenSpecified
		{
			get
			{
				return this.discount_TakenFieldSpecified;
			}
			set
			{
				this.discount_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Discount_TakenSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public string Currency_Symbol
		{
			get
			{
				return this.currency_SymbolField;
			}
			set
			{
				this.currency_SymbolField = value;
				this.RaisePropertyChanged("Currency_Symbol");
			}
		}

		[XmlElement(Order = 10)]
		public string Currency_Description
		{
			get
			{
				return this.currency_DescriptionField;
			}
			set
			{
				this.currency_DescriptionField = value;
				this.RaisePropertyChanged("Currency_Description");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Check_or_Advice_Number
		{
			get
			{
				return this.check_or_Advice_NumberField;
			}
			set
			{
				this.check_or_Advice_NumberField = value;
				this.RaisePropertyChanged("Check_or_Advice_Number");
			}
		}

		[XmlIgnore]
		public bool Check_or_Advice_NumberSpecified
		{
			get
			{
				return this.check_or_Advice_NumberFieldSpecified;
			}
			set
			{
				this.check_or_Advice_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Check_or_Advice_NumberSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public string Check_Number
		{
			get
			{
				return this.check_NumberField;
			}
			set
			{
				this.check_NumberField = value;
				this.RaisePropertyChanged("Check_Number");
			}
		}

		[XmlElement(Order = 13)]
		public bool Prenote_Flag
		{
			get
			{
				return this.prenote_FlagField;
			}
			set
			{
				this.prenote_FlagField = value;
				this.RaisePropertyChanged("Prenote_Flag");
			}
		}

		[XmlIgnore]
		public bool Prenote_FlagSpecified
		{
			get
			{
				return this.prenote_FlagFieldSpecified;
			}
			set
			{
				this.prenote_FlagFieldSpecified = value;
				this.RaisePropertyChanged("Prenote_FlagSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Payroll_Payment_Display_Order
		{
			get
			{
				return this.payroll_Payment_Display_OrderField;
			}
			set
			{
				this.payroll_Payment_Display_OrderField = value;
				this.RaisePropertyChanged("Payroll_Payment_Display_Order");
			}
		}

		[XmlIgnore]
		public bool Payroll_Payment_Display_OrderSpecified
		{
			get
			{
				return this.payroll_Payment_Display_OrderFieldSpecified;
			}
			set
			{
				this.payroll_Payment_Display_OrderFieldSpecified = value;
				this.RaisePropertyChanged("Payroll_Payment_Display_OrderSpecified");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement("On_Behalf_of_Company_Reference", Order = 18)]
		public CompanyObjectType[] On_Behalf_of_Company_Reference
		{
			get
			{
				return this.on_Behalf_of_Company_ReferenceField;
			}
			set
			{
				this.on_Behalf_of_Company_ReferenceField = value;
				this.RaisePropertyChanged("On_Behalf_of_Company_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Mandate_DataType Mandate_Data
		{
			get
			{
				return this.mandate_DataField;
			}
			set
			{
				this.mandate_DataField = value;
				this.RaisePropertyChanged("Mandate_Data");
			}
		}

		[XmlElement("Originating_Contact_Data", Order = 20)]
		public Originating_Party_WWS_DataType[] Originating_Contact_Data
		{
			get
			{
				return this.originating_Contact_DataField;
			}
			set
			{
				this.originating_Contact_DataField = value;
				this.RaisePropertyChanged("Originating_Contact_Data");
			}
		}

		[XmlElement("Originating_Bank_Data", Order = 21)]
		public Originating_Party_Bank_DataType[] Originating_Bank_Data
		{
			get
			{
				return this.originating_Bank_DataField;
			}
			set
			{
				this.originating_Bank_DataField = value;
				this.RaisePropertyChanged("Originating_Bank_Data");
			}
		}

		[XmlElement("On_Behalf_Of_Company_Data", Order = 22)]
		public On_Behalf_Of_Company_WWS_DataType[] On_Behalf_Of_Company_Data
		{
			get
			{
				return this.on_Behalf_Of_Company_DataField;
			}
			set
			{
				this.on_Behalf_Of_Company_DataField = value;
				this.RaisePropertyChanged("On_Behalf_Of_Company_Data");
			}
		}

		[XmlElement(Order = 23)]
		public PayeeObjectType Receiving_Party_Reference
		{
			get
			{
				return this.receiving_Party_ReferenceField;
			}
			set
			{
				this.receiving_Party_ReferenceField = value;
				this.RaisePropertyChanged("Receiving_Party_Reference");
			}
		}

		[XmlElement("Receiving_Party_Contact_Data", Order = 24)]
		public Receiving_Party_WWS_DataType[] Receiving_Party_Contact_Data
		{
			get
			{
				return this.receiving_Party_Contact_DataField;
			}
			set
			{
				this.receiving_Party_Contact_DataField = value;
				this.RaisePropertyChanged("Receiving_Party_Contact_Data");
			}
		}

		[XmlElement("Receiving_Party_Bank_Data", Order = 25)]
		public Receiving_Party_Bank_DataType[] Receiving_Party_Bank_Data
		{
			get
			{
				return this.receiving_Party_Bank_DataField;
			}
			set
			{
				this.receiving_Party_Bank_DataField = value;
				this.RaisePropertyChanged("Receiving_Party_Bank_Data");
			}
		}

		[XmlElement(Order = 26)]
		public Receiving_Party_Credit_Card_DataType Receiving_Party_Credit_Card_Data
		{
			get
			{
				return this.receiving_Party_Credit_Card_DataField;
			}
			set
			{
				this.receiving_Party_Credit_Card_DataField = value;
				this.RaisePropertyChanged("Receiving_Party_Credit_Card_Data");
			}
		}

		[XmlElement("Remittance_Data", Order = 27)]
		public Remittance_DataType[] Remittance_Data
		{
			get
			{
				return this.remittance_DataField;
			}
			set
			{
				this.remittance_DataField = value;
				this.RaisePropertyChanged("Remittance_Data");
			}
		}

		[XmlElement("Payroll_Remittance_Data", Order = 28)]
		public Payroll_Remittance_DataType[] Payroll_Remittance_Data
		{
			get
			{
				return this.payroll_Remittance_DataField;
			}
			set
			{
				this.payroll_Remittance_DataField = value;
				this.RaisePropertyChanged("Payroll_Remittance_Data");
			}
		}

		[XmlElement("Payroll_Result_Country_Data", Order = 29)]
		public Payroll_Result_Country_DataType[] Payroll_Result_Country_Data
		{
			get
			{
				return this.payroll_Result_Country_DataField;
			}
			set
			{
				this.payroll_Result_Country_DataField = value;
				this.RaisePropertyChanged("Payroll_Result_Country_Data");
			}
		}

		[XmlElement("Integration_Field_Override_Data", Order = 30)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
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
