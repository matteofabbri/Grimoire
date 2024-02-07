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
	public class Bank_Account_DataType : INotifyPropertyChanged
	{
		private string bank_Account_IDField;

		private string account_NameField;

		private Financial_InstitutionObjectType financial_Institution_ReferenceField;

		private Financial_PartyObjectType financial_Party_ReferenceField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private CurrencyObjectType[] accepted_Currencies_ReferenceField;

		private Bank_BranchObjectType bank_Branch_ReferenceField;

		private DateTime bank_Account_Open_DateField;

		private bool bank_Account_Open_DateFieldSpecified;

		private bool account_ClosedField;

		private bool account_ClosedFieldSpecified;

		private DateTime bank_Account_Close_DateField;

		private bool bank_Account_Close_DateFieldSpecified;

		private CountryObjectType country_ReferenceField;

		private string routing_Transit_or_Institution_NumberField;

		private string financial_Account_NumberField;

		private string bank_Identifier_CodeField;

		private string iBANField;

		private Bank_Statement_FormatObjectType bank_Account_Format_ReferenceField;

		private Bank_Statement_Custom_Code_SetObjectType custom_Code_Set_ReferenceField;

		private string branch_NameField;

		private string check_DigitField;

		private string bank_Account_NameField;

		private string roll_NumberField;

		private string fractionField;

		private string formatted_MICRField;

		private decimal target_BalanceField;

		private bool target_BalanceFieldSpecified;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private Check_Print_Layout_AbstractObjectType check_Print_Layout_ReferenceField;

		private bool use_Branch_AddressField;

		private bool use_Branch_AddressFieldSpecified;

		private bool advanced_ModeField;

		private bool advanced_ModeFieldSpecified;

		private Auto_Recon_Initiation_TypeObjectType perform_Automatic_Reconciliation_ReferenceField;

		private Reconciliation_Rule_SetObjectType reconciliation_Rule_Set_ReferenceField;

		private Auto_Recon_Initiation_TypeObjectType perform_Automatic_First_Notice_Reconciliation_ReferenceField;

		private Reconciliation_Rule_SetObjectType first_Notice_Rule_Set_ReferenceField;

		private bool batch_Electronic_PaymentsField;

		private bool batch_Electronic_PaymentsFieldSpecified;

		private bool batch_Electronic_Customer_Payment_DepositsField;

		private bool batch_Electronic_Customer_Payment_DepositsFieldSpecified;

		private bool submit_Reconciled_Statements_AutomaticallyField;

		private bool submit_Reconciled_Statements_AutomaticallyFieldSpecified;

		private bool used_by_CashField;

		private bool used_by_CashFieldSpecified;

		private bool used_by_Customer_PaymentsField;

		private bool used_by_Customer_PaymentsFieldSpecified;

		private bool used_by_Customer_RefundsField;

		private bool used_by_Customer_RefundsFieldSpecified;

		private bool used_by_Expense_PaymentsField;

		private bool used_by_Expense_PaymentsFieldSpecified;

		private bool used_by_Payroll_On_CycleField;

		private bool used_by_Payroll_On_CycleFieldSpecified;

		private bool used_by_Supplier_PaymentsField;

		private bool used_by_Supplier_PaymentsFieldSpecified;

		private bool used_by_Intercompany_PaymentsField;

		private bool used_by_Intercompany_PaymentsFieldSpecified;

		private bool used_by_Ad_hoc_PaymentsField;

		private bool used_by_Ad_hoc_PaymentsFieldSpecified;

		private bool used_By_Payroll_Off_CycleField;

		private bool used_By_Payroll_Off_CycleFieldSpecified;

		private bool used_By_Prenote_PaymentsField;

		private bool used_By_Prenote_PaymentsFieldSpecified;

		private bool used_By_Procurement_Card_PaymentsField;

		private bool used_By_Procurement_Card_PaymentsFieldSpecified;

		private bool used_By_Tax_PaymentsField;

		private bool used_By_Tax_PaymentsFieldSpecified;

		private bool used_by_Cash_AdvancesField;

		private bool used_by_Cash_AdvancesFieldSpecified;

		private bool used_by_Expense_Credit_Card_PaymentsField;

		private bool used_by_Expense_Credit_Card_PaymentsFieldSpecified;

		private decimal last_Check_Number_UsedField;

		private bool last_Check_Number_UsedFieldSpecified;

		private bool enable_Positive_PayField;

		private bool enable_Positive_PayFieldSpecified;

		private bool outsourcedField;

		private bool outsourcedFieldSpecified;

		private Bank_Account_TypeObjectType account_Type_ReferenceField;

		private bool allow_Additional_UsageField;

		private bool allow_Additional_UsageFieldSpecified;

		private bool default_Bank_Statement_Beginning_BalanceField;

		private bool default_Bank_Statement_Beginning_BalanceFieldSpecified;

		private Unique_IdentifierObjectType outsourced_Bank_Provider_ReferenceField;

		private Payment_Integration_DataType[] payment_Integration_DataField;

		private Lockbox_DataType[] lockbox_DataField;

		private Check_Sorting_Setup_DataType check_Sorting_Setup_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bank_Account_ID
		{
			get
			{
				return this.bank_Account_IDField;
			}
			set
			{
				this.bank_Account_IDField = value;
				this.RaisePropertyChanged("Bank_Account_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Account_Name
		{
			get
			{
				return this.account_NameField;
			}
			set
			{
				this.account_NameField = value;
				this.RaisePropertyChanged("Account_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Financial_InstitutionObjectType Financial_Institution_Reference
		{
			get
			{
				return this.financial_Institution_ReferenceField;
			}
			set
			{
				this.financial_Institution_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Institution_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Financial_PartyObjectType Financial_Party_Reference
		{
			get
			{
				return this.financial_Party_ReferenceField;
			}
			set
			{
				this.financial_Party_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Party_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public CurrencyObjectType Default_Currency_Reference
		{
			get
			{
				return this.default_Currency_ReferenceField;
			}
			set
			{
				this.default_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Default_Currency_Reference");
			}
		}

		[XmlElement("Accepted_Currencies_Reference", Order = 5)]
		public CurrencyObjectType[] Accepted_Currencies_Reference
		{
			get
			{
				return this.accepted_Currencies_ReferenceField;
			}
			set
			{
				this.accepted_Currencies_ReferenceField = value;
				this.RaisePropertyChanged("Accepted_Currencies_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Bank_BranchObjectType Bank_Branch_Reference
		{
			get
			{
				return this.bank_Branch_ReferenceField;
			}
			set
			{
				this.bank_Branch_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Branch_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Bank_Account_Open_Date
		{
			get
			{
				return this.bank_Account_Open_DateField;
			}
			set
			{
				this.bank_Account_Open_DateField = value;
				this.RaisePropertyChanged("Bank_Account_Open_Date");
			}
		}

		[XmlIgnore]
		public bool Bank_Account_Open_DateSpecified
		{
			get
			{
				return this.bank_Account_Open_DateFieldSpecified;
			}
			set
			{
				this.bank_Account_Open_DateFieldSpecified = value;
				this.RaisePropertyChanged("Bank_Account_Open_DateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Account_Closed
		{
			get
			{
				return this.account_ClosedField;
			}
			set
			{
				this.account_ClosedField = value;
				this.RaisePropertyChanged("Account_Closed");
			}
		}

		[XmlIgnore]
		public bool Account_ClosedSpecified
		{
			get
			{
				return this.account_ClosedFieldSpecified;
			}
			set
			{
				this.account_ClosedFieldSpecified = value;
				this.RaisePropertyChanged("Account_ClosedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Bank_Account_Close_Date
		{
			get
			{
				return this.bank_Account_Close_DateField;
			}
			set
			{
				this.bank_Account_Close_DateField = value;
				this.RaisePropertyChanged("Bank_Account_Close_Date");
			}
		}

		[XmlIgnore]
		public bool Bank_Account_Close_DateSpecified
		{
			get
			{
				return this.bank_Account_Close_DateFieldSpecified;
			}
			set
			{
				this.bank_Account_Close_DateFieldSpecified = value;
				this.RaisePropertyChanged("Bank_Account_Close_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Routing_Transit_or_Institution_Number
		{
			get
			{
				return this.routing_Transit_or_Institution_NumberField;
			}
			set
			{
				this.routing_Transit_or_Institution_NumberField = value;
				this.RaisePropertyChanged("Routing_Transit_or_Institution_Number");
			}
		}

		[XmlElement(Order = 12)]
		public string Financial_Account_Number
		{
			get
			{
				return this.financial_Account_NumberField;
			}
			set
			{
				this.financial_Account_NumberField = value;
				this.RaisePropertyChanged("Financial_Account_Number");
			}
		}

		[XmlElement(Order = 13)]
		public string Bank_Identifier_Code
		{
			get
			{
				return this.bank_Identifier_CodeField;
			}
			set
			{
				this.bank_Identifier_CodeField = value;
				this.RaisePropertyChanged("Bank_Identifier_Code");
			}
		}

		[XmlElement(Order = 14)]
		public string IBAN
		{
			get
			{
				return this.iBANField;
			}
			set
			{
				this.iBANField = value;
				this.RaisePropertyChanged("IBAN");
			}
		}

		[XmlElement(Order = 15)]
		public Bank_Statement_FormatObjectType Bank_Account_Format_Reference
		{
			get
			{
				return this.bank_Account_Format_ReferenceField;
			}
			set
			{
				this.bank_Account_Format_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Format_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Bank_Statement_Custom_Code_SetObjectType Custom_Code_Set_Reference
		{
			get
			{
				return this.custom_Code_Set_ReferenceField;
			}
			set
			{
				this.custom_Code_Set_ReferenceField = value;
				this.RaisePropertyChanged("Custom_Code_Set_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public string Branch_Name
		{
			get
			{
				return this.branch_NameField;
			}
			set
			{
				this.branch_NameField = value;
				this.RaisePropertyChanged("Branch_Name");
			}
		}

		[XmlElement(Order = 18)]
		public string Check_Digit
		{
			get
			{
				return this.check_DigitField;
			}
			set
			{
				this.check_DigitField = value;
				this.RaisePropertyChanged("Check_Digit");
			}
		}

		[XmlElement(Order = 19)]
		public string Bank_Account_Name
		{
			get
			{
				return this.bank_Account_NameField;
			}
			set
			{
				this.bank_Account_NameField = value;
				this.RaisePropertyChanged("Bank_Account_Name");
			}
		}

		[XmlElement(Order = 20)]
		public string Roll_Number
		{
			get
			{
				return this.roll_NumberField;
			}
			set
			{
				this.roll_NumberField = value;
				this.RaisePropertyChanged("Roll_Number");
			}
		}

		[XmlElement(Order = 21)]
		public string Fraction
		{
			get
			{
				return this.fractionField;
			}
			set
			{
				this.fractionField = value;
				this.RaisePropertyChanged("Fraction");
			}
		}

		[XmlElement(Order = 22)]
		public string Formatted_MICR
		{
			get
			{
				return this.formatted_MICRField;
			}
			set
			{
				this.formatted_MICRField = value;
				this.RaisePropertyChanged("Formatted_MICR");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Target_Balance
		{
			get
			{
				return this.target_BalanceField;
			}
			set
			{
				this.target_BalanceField = value;
				this.RaisePropertyChanged("Target_Balance");
			}
		}

		[XmlIgnore]
		public bool Target_BalanceSpecified
		{
			get
			{
				return this.target_BalanceFieldSpecified;
			}
			set
			{
				this.target_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Target_BalanceSpecified");
			}
		}

		[XmlElement("Payment_Type_Reference", Order = 24)]
		public Payment_TypeObjectType[] Payment_Type_Reference
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

		[XmlElement(Order = 25)]
		public Check_Print_Layout_AbstractObjectType Check_Print_Layout_Reference
		{
			get
			{
				return this.check_Print_Layout_ReferenceField;
			}
			set
			{
				this.check_Print_Layout_ReferenceField = value;
				this.RaisePropertyChanged("Check_Print_Layout_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public bool Use_Branch_Address
		{
			get
			{
				return this.use_Branch_AddressField;
			}
			set
			{
				this.use_Branch_AddressField = value;
				this.RaisePropertyChanged("Use_Branch_Address");
			}
		}

		[XmlIgnore]
		public bool Use_Branch_AddressSpecified
		{
			get
			{
				return this.use_Branch_AddressFieldSpecified;
			}
			set
			{
				this.use_Branch_AddressFieldSpecified = value;
				this.RaisePropertyChanged("Use_Branch_AddressSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public bool Advanced_Mode
		{
			get
			{
				return this.advanced_ModeField;
			}
			set
			{
				this.advanced_ModeField = value;
				this.RaisePropertyChanged("Advanced_Mode");
			}
		}

		[XmlIgnore]
		public bool Advanced_ModeSpecified
		{
			get
			{
				return this.advanced_ModeFieldSpecified;
			}
			set
			{
				this.advanced_ModeFieldSpecified = value;
				this.RaisePropertyChanged("Advanced_ModeSpecified");
			}
		}

		[XmlElement(Order = 28)]
		public Auto_Recon_Initiation_TypeObjectType Perform_Automatic_Reconciliation_Reference
		{
			get
			{
				return this.perform_Automatic_Reconciliation_ReferenceField;
			}
			set
			{
				this.perform_Automatic_Reconciliation_ReferenceField = value;
				this.RaisePropertyChanged("Perform_Automatic_Reconciliation_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public Reconciliation_Rule_SetObjectType Reconciliation_Rule_Set_Reference
		{
			get
			{
				return this.reconciliation_Rule_Set_ReferenceField;
			}
			set
			{
				this.reconciliation_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("Reconciliation_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 30)]
		public Auto_Recon_Initiation_TypeObjectType Perform_Automatic_First_Notice_Reconciliation_Reference
		{
			get
			{
				return this.perform_Automatic_First_Notice_Reconciliation_ReferenceField;
			}
			set
			{
				this.perform_Automatic_First_Notice_Reconciliation_ReferenceField = value;
				this.RaisePropertyChanged("Perform_Automatic_First_Notice_Reconciliation_Reference");
			}
		}

		[XmlElement(Order = 31)]
		public Reconciliation_Rule_SetObjectType First_Notice_Rule_Set_Reference
		{
			get
			{
				return this.first_Notice_Rule_Set_ReferenceField;
			}
			set
			{
				this.first_Notice_Rule_Set_ReferenceField = value;
				this.RaisePropertyChanged("First_Notice_Rule_Set_Reference");
			}
		}

		[XmlElement(Order = 32)]
		public bool Batch_Electronic_Payments
		{
			get
			{
				return this.batch_Electronic_PaymentsField;
			}
			set
			{
				this.batch_Electronic_PaymentsField = value;
				this.RaisePropertyChanged("Batch_Electronic_Payments");
			}
		}

		[XmlIgnore]
		public bool Batch_Electronic_PaymentsSpecified
		{
			get
			{
				return this.batch_Electronic_PaymentsFieldSpecified;
			}
			set
			{
				this.batch_Electronic_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Batch_Electronic_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 33)]
		public bool Batch_Electronic_Customer_Payment_Deposits
		{
			get
			{
				return this.batch_Electronic_Customer_Payment_DepositsField;
			}
			set
			{
				this.batch_Electronic_Customer_Payment_DepositsField = value;
				this.RaisePropertyChanged("Batch_Electronic_Customer_Payment_Deposits");
			}
		}

		[XmlIgnore]
		public bool Batch_Electronic_Customer_Payment_DepositsSpecified
		{
			get
			{
				return this.batch_Electronic_Customer_Payment_DepositsFieldSpecified;
			}
			set
			{
				this.batch_Electronic_Customer_Payment_DepositsFieldSpecified = value;
				this.RaisePropertyChanged("Batch_Electronic_Customer_Payment_DepositsSpecified");
			}
		}

		[XmlElement(Order = 34)]
		public bool Submit_Reconciled_Statements_Automatically
		{
			get
			{
				return this.submit_Reconciled_Statements_AutomaticallyField;
			}
			set
			{
				this.submit_Reconciled_Statements_AutomaticallyField = value;
				this.RaisePropertyChanged("Submit_Reconciled_Statements_Automatically");
			}
		}

		[XmlIgnore]
		public bool Submit_Reconciled_Statements_AutomaticallySpecified
		{
			get
			{
				return this.submit_Reconciled_Statements_AutomaticallyFieldSpecified;
			}
			set
			{
				this.submit_Reconciled_Statements_AutomaticallyFieldSpecified = value;
				this.RaisePropertyChanged("Submit_Reconciled_Statements_AutomaticallySpecified");
			}
		}

		[XmlElement(Order = 35)]
		public bool Used_by_Cash
		{
			get
			{
				return this.used_by_CashField;
			}
			set
			{
				this.used_by_CashField = value;
				this.RaisePropertyChanged("Used_by_Cash");
			}
		}

		[XmlIgnore]
		public bool Used_by_CashSpecified
		{
			get
			{
				return this.used_by_CashFieldSpecified;
			}
			set
			{
				this.used_by_CashFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_CashSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public bool Used_by_Customer_Payments
		{
			get
			{
				return this.used_by_Customer_PaymentsField;
			}
			set
			{
				this.used_by_Customer_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Customer_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Customer_PaymentsSpecified
		{
			get
			{
				return this.used_by_Customer_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Customer_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Customer_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public bool Used_by_Customer_Refunds
		{
			get
			{
				return this.used_by_Customer_RefundsField;
			}
			set
			{
				this.used_by_Customer_RefundsField = value;
				this.RaisePropertyChanged("Used_by_Customer_Refunds");
			}
		}

		[XmlIgnore]
		public bool Used_by_Customer_RefundsSpecified
		{
			get
			{
				return this.used_by_Customer_RefundsFieldSpecified;
			}
			set
			{
				this.used_by_Customer_RefundsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Customer_RefundsSpecified");
			}
		}

		[XmlElement(Order = 38)]
		public bool Used_by_Expense_Payments
		{
			get
			{
				return this.used_by_Expense_PaymentsField;
			}
			set
			{
				this.used_by_Expense_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Expense_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Expense_PaymentsSpecified
		{
			get
			{
				return this.used_by_Expense_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Expense_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Expense_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 39)]
		public bool Used_by_Payroll_On_Cycle
		{
			get
			{
				return this.used_by_Payroll_On_CycleField;
			}
			set
			{
				this.used_by_Payroll_On_CycleField = value;
				this.RaisePropertyChanged("Used_by_Payroll_On_Cycle");
			}
		}

		[XmlIgnore]
		public bool Used_by_Payroll_On_CycleSpecified
		{
			get
			{
				return this.used_by_Payroll_On_CycleFieldSpecified;
			}
			set
			{
				this.used_by_Payroll_On_CycleFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Payroll_On_CycleSpecified");
			}
		}

		[XmlElement(Order = 40)]
		public bool Used_by_Supplier_Payments
		{
			get
			{
				return this.used_by_Supplier_PaymentsField;
			}
			set
			{
				this.used_by_Supplier_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Supplier_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Supplier_PaymentsSpecified
		{
			get
			{
				return this.used_by_Supplier_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Supplier_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Supplier_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 41)]
		public bool Used_by_Intercompany_Payments
		{
			get
			{
				return this.used_by_Intercompany_PaymentsField;
			}
			set
			{
				this.used_by_Intercompany_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Intercompany_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Intercompany_PaymentsSpecified
		{
			get
			{
				return this.used_by_Intercompany_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Intercompany_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Intercompany_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 42)]
		public bool Used_by_Ad_hoc_Payments
		{
			get
			{
				return this.used_by_Ad_hoc_PaymentsField;
			}
			set
			{
				this.used_by_Ad_hoc_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Ad_hoc_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Ad_hoc_PaymentsSpecified
		{
			get
			{
				return this.used_by_Ad_hoc_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Ad_hoc_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Ad_hoc_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public bool Used_By_Payroll_Off_Cycle
		{
			get
			{
				return this.used_By_Payroll_Off_CycleField;
			}
			set
			{
				this.used_By_Payroll_Off_CycleField = value;
				this.RaisePropertyChanged("Used_By_Payroll_Off_Cycle");
			}
		}

		[XmlIgnore]
		public bool Used_By_Payroll_Off_CycleSpecified
		{
			get
			{
				return this.used_By_Payroll_Off_CycleFieldSpecified;
			}
			set
			{
				this.used_By_Payroll_Off_CycleFieldSpecified = value;
				this.RaisePropertyChanged("Used_By_Payroll_Off_CycleSpecified");
			}
		}

		[XmlElement(Order = 44)]
		public bool Used_By_Prenote_Payments
		{
			get
			{
				return this.used_By_Prenote_PaymentsField;
			}
			set
			{
				this.used_By_Prenote_PaymentsField = value;
				this.RaisePropertyChanged("Used_By_Prenote_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_By_Prenote_PaymentsSpecified
		{
			get
			{
				return this.used_By_Prenote_PaymentsFieldSpecified;
			}
			set
			{
				this.used_By_Prenote_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_By_Prenote_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 45)]
		public bool Used_By_Procurement_Card_Payments
		{
			get
			{
				return this.used_By_Procurement_Card_PaymentsField;
			}
			set
			{
				this.used_By_Procurement_Card_PaymentsField = value;
				this.RaisePropertyChanged("Used_By_Procurement_Card_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_By_Procurement_Card_PaymentsSpecified
		{
			get
			{
				return this.used_By_Procurement_Card_PaymentsFieldSpecified;
			}
			set
			{
				this.used_By_Procurement_Card_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_By_Procurement_Card_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 46)]
		public bool Used_By_Tax_Payments
		{
			get
			{
				return this.used_By_Tax_PaymentsField;
			}
			set
			{
				this.used_By_Tax_PaymentsField = value;
				this.RaisePropertyChanged("Used_By_Tax_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_By_Tax_PaymentsSpecified
		{
			get
			{
				return this.used_By_Tax_PaymentsFieldSpecified;
			}
			set
			{
				this.used_By_Tax_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_By_Tax_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 47)]
		public bool Used_by_Cash_Advances
		{
			get
			{
				return this.used_by_Cash_AdvancesField;
			}
			set
			{
				this.used_by_Cash_AdvancesField = value;
				this.RaisePropertyChanged("Used_by_Cash_Advances");
			}
		}

		[XmlIgnore]
		public bool Used_by_Cash_AdvancesSpecified
		{
			get
			{
				return this.used_by_Cash_AdvancesFieldSpecified;
			}
			set
			{
				this.used_by_Cash_AdvancesFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Cash_AdvancesSpecified");
			}
		}

		[XmlElement(Order = 48)]
		public bool Used_by_Expense_Credit_Card_Payments
		{
			get
			{
				return this.used_by_Expense_Credit_Card_PaymentsField;
			}
			set
			{
				this.used_by_Expense_Credit_Card_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Expense_Credit_Card_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Expense_Credit_Card_PaymentsSpecified
		{
			get
			{
				return this.used_by_Expense_Credit_Card_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Expense_Credit_Card_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Expense_Credit_Card_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 49)]
		public decimal Last_Check_Number_Used
		{
			get
			{
				return this.last_Check_Number_UsedField;
			}
			set
			{
				this.last_Check_Number_UsedField = value;
				this.RaisePropertyChanged("Last_Check_Number_Used");
			}
		}

		[XmlIgnore]
		public bool Last_Check_Number_UsedSpecified
		{
			get
			{
				return this.last_Check_Number_UsedFieldSpecified;
			}
			set
			{
				this.last_Check_Number_UsedFieldSpecified = value;
				this.RaisePropertyChanged("Last_Check_Number_UsedSpecified");
			}
		}

		[XmlElement(Order = 50)]
		public bool Enable_Positive_Pay
		{
			get
			{
				return this.enable_Positive_PayField;
			}
			set
			{
				this.enable_Positive_PayField = value;
				this.RaisePropertyChanged("Enable_Positive_Pay");
			}
		}

		[XmlIgnore]
		public bool Enable_Positive_PaySpecified
		{
			get
			{
				return this.enable_Positive_PayFieldSpecified;
			}
			set
			{
				this.enable_Positive_PayFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Positive_PaySpecified");
			}
		}

		[XmlElement(Order = 51)]
		public bool Outsourced
		{
			get
			{
				return this.outsourcedField;
			}
			set
			{
				this.outsourcedField = value;
				this.RaisePropertyChanged("Outsourced");
			}
		}

		[XmlIgnore]
		public bool OutsourcedSpecified
		{
			get
			{
				return this.outsourcedFieldSpecified;
			}
			set
			{
				this.outsourcedFieldSpecified = value;
				this.RaisePropertyChanged("OutsourcedSpecified");
			}
		}

		[XmlElement(Order = 52)]
		public Bank_Account_TypeObjectType Account_Type_Reference
		{
			get
			{
				return this.account_Type_ReferenceField;
			}
			set
			{
				this.account_Type_ReferenceField = value;
				this.RaisePropertyChanged("Account_Type_Reference");
			}
		}

		[XmlElement(Order = 53)]
		public bool Allow_Additional_Usage
		{
			get
			{
				return this.allow_Additional_UsageField;
			}
			set
			{
				this.allow_Additional_UsageField = value;
				this.RaisePropertyChanged("Allow_Additional_Usage");
			}
		}

		[XmlIgnore]
		public bool Allow_Additional_UsageSpecified
		{
			get
			{
				return this.allow_Additional_UsageFieldSpecified;
			}
			set
			{
				this.allow_Additional_UsageFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Additional_UsageSpecified");
			}
		}

		[XmlElement(Order = 54)]
		public bool Default_Bank_Statement_Beginning_Balance
		{
			get
			{
				return this.default_Bank_Statement_Beginning_BalanceField;
			}
			set
			{
				this.default_Bank_Statement_Beginning_BalanceField = value;
				this.RaisePropertyChanged("Default_Bank_Statement_Beginning_Balance");
			}
		}

		[XmlIgnore]
		public bool Default_Bank_Statement_Beginning_BalanceSpecified
		{
			get
			{
				return this.default_Bank_Statement_Beginning_BalanceFieldSpecified;
			}
			set
			{
				this.default_Bank_Statement_Beginning_BalanceFieldSpecified = value;
				this.RaisePropertyChanged("Default_Bank_Statement_Beginning_BalanceSpecified");
			}
		}

		[XmlElement(Order = 55)]
		public Unique_IdentifierObjectType Outsourced_Bank_Provider_Reference
		{
			get
			{
				return this.outsourced_Bank_Provider_ReferenceField;
			}
			set
			{
				this.outsourced_Bank_Provider_ReferenceField = value;
				this.RaisePropertyChanged("Outsourced_Bank_Provider_Reference");
			}
		}

		[XmlElement("Payment_Integration_Data", Order = 56)]
		public Payment_Integration_DataType[] Payment_Integration_Data
		{
			get
			{
				return this.payment_Integration_DataField;
			}
			set
			{
				this.payment_Integration_DataField = value;
				this.RaisePropertyChanged("Payment_Integration_Data");
			}
		}

		[XmlElement("Lockbox_Data", Order = 57)]
		public Lockbox_DataType[] Lockbox_Data
		{
			get
			{
				return this.lockbox_DataField;
			}
			set
			{
				this.lockbox_DataField = value;
				this.RaisePropertyChanged("Lockbox_Data");
			}
		}

		[XmlElement(Order = 58)]
		public Check_Sorting_Setup_DataType Check_Sorting_Setup_Data
		{
			get
			{
				return this.check_Sorting_Setup_DataField;
			}
			set
			{
				this.check_Sorting_Setup_DataField = value;
				this.RaisePropertyChanged("Check_Sorting_Setup_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 59)]
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
