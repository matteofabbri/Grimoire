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
	public class Petty_Cash_Account_DataType : INotifyPropertyChanged
	{
		private string petty_Cash_Account_IDField;

		private string account_NameField;

		private Financial_PartyObjectType financial_Party_ReferenceField;

		private CurrencyObjectType default_Currency_ReferenceField;

		private CurrencyObjectType[] accepted_Currencies_ReferenceField;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private bool used_by_CashField;

		private bool used_by_CashFieldSpecified;

		private bool used_by_Customer_PaymentsField;

		private bool used_by_Customer_PaymentsFieldSpecified;

		private bool used_by_Expense_PaymentsField;

		private bool used_by_Expense_PaymentsFieldSpecified;

		private bool used_by_PayrollField;

		private bool used_by_PayrollFieldSpecified;

		private bool used_by_Supplier_PaymentsField;

		private bool used_by_Supplier_PaymentsFieldSpecified;

		private bool used_by_Intercompany_PaymentsField;

		private bool used_by_Intercompany_PaymentsFieldSpecified;

		private bool used_by_Ad_hoc_PaymentsField;

		private bool used_by_Ad_hoc_PaymentsFieldSpecified;

		private bool used_by_OffCycle_PayrollField;

		private bool used_by_OffCycle_PayrollFieldSpecified;

		private bool used_by_Prenote_PaymentsField;

		private bool used_by_Prenote_PaymentsFieldSpecified;

		private bool allow_Additional_usageField;

		private bool allow_Additional_usageFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Petty_Cash_Account_ID
		{
			get
			{
				return this.petty_Cash_Account_IDField;
			}
			set
			{
				this.petty_Cash_Account_IDField = value;
				this.RaisePropertyChanged("Petty_Cash_Account_ID");
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Accepted_Currencies_Reference", Order = 4)]
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

		[XmlElement("Payment_Type_Reference", Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public bool Used_by_Payroll
		{
			get
			{
				return this.used_by_PayrollField;
			}
			set
			{
				this.used_by_PayrollField = value;
				this.RaisePropertyChanged("Used_by_Payroll");
			}
		}

		[XmlIgnore]
		public bool Used_by_PayrollSpecified
		{
			get
			{
				return this.used_by_PayrollFieldSpecified;
			}
			set
			{
				this.used_by_PayrollFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_PayrollSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement("Used_by_Off-Cycle_Payroll", Order = 13)]
		public bool Used_by_OffCycle_Payroll
		{
			get
			{
				return this.used_by_OffCycle_PayrollField;
			}
			set
			{
				this.used_by_OffCycle_PayrollField = value;
				this.RaisePropertyChanged("Used_by_OffCycle_Payroll");
			}
		}

		[XmlIgnore]
		public bool Used_by_OffCycle_PayrollSpecified
		{
			get
			{
				return this.used_by_OffCycle_PayrollFieldSpecified;
			}
			set
			{
				this.used_by_OffCycle_PayrollFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_OffCycle_PayrollSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Used_by_Prenote_Payments
		{
			get
			{
				return this.used_by_Prenote_PaymentsField;
			}
			set
			{
				this.used_by_Prenote_PaymentsField = value;
				this.RaisePropertyChanged("Used_by_Prenote_Payments");
			}
		}

		[XmlIgnore]
		public bool Used_by_Prenote_PaymentsSpecified
		{
			get
			{
				return this.used_by_Prenote_PaymentsFieldSpecified;
			}
			set
			{
				this.used_by_Prenote_PaymentsFieldSpecified = value;
				this.RaisePropertyChanged("Used_by_Prenote_PaymentsSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Allow_Additional_usage
		{
			get
			{
				return this.allow_Additional_usageField;
			}
			set
			{
				this.allow_Additional_usageField = value;
				this.RaisePropertyChanged("Allow_Additional_usage");
			}
		}

		[XmlIgnore]
		public bool Allow_Additional_usageSpecified
		{
			get
			{
				return this.allow_Additional_usageFieldSpecified;
			}
			set
			{
				this.allow_Additional_usageFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Additional_usageSpecified");
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
