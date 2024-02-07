using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Journal_Entry_Line__HV__DataType : INotifyPropertyChanged
	{
		private string line_OrderField;

		private CompanyObjectType line_Company_ReferenceField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Ledger_AccountObjectType alternate_Ledger_Account_ReferenceField;

		private decimal debit_AmountField;

		private bool debit_AmountFieldSpecified;

		private decimal credit_AmountField;

		private bool credit_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal currency_RateField;

		private bool currency_RateFieldSpecified;

		private decimal ledger_Debit_AmountField;

		private bool ledger_Debit_AmountFieldSpecified;

		private decimal ledger_Credit_AmountField;

		private bool ledger_Credit_AmountFieldSpecified;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal quantity_2Field;

		private bool quantity_2FieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_2_ReferenceField;

		private string memoField;

		private string external_Reference_IDField;

		private DateTime budget_DateField;

		private bool budget_DateFieldSpecified;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_Affiliate_ReferenceField;

		private bool exclude_from_Spend_ReportField;

		private bool exclude_from_Spend_ReportFieldSpecified;

		private Journal_Line_Tax_Detail_DataType tax_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Line_Company_Reference
		{
			get
			{
				return this.line_Company_ReferenceField;
			}
			set
			{
				this.line_Company_ReferenceField = value;
				this.RaisePropertyChanged("Line_Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_AccountObjectType Ledger_Account_Reference
		{
			get
			{
				return this.ledger_Account_ReferenceField;
			}
			set
			{
				this.ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Ledger_AccountObjectType Alternate_Ledger_Account_Reference
		{
			get
			{
				return this.alternate_Ledger_Account_ReferenceField;
			}
			set
			{
				this.alternate_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Ledger_Account_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Debit_Amount
		{
			get
			{
				return this.debit_AmountField;
			}
			set
			{
				this.debit_AmountField = value;
				this.RaisePropertyChanged("Debit_Amount");
			}
		}

		[XmlIgnore]
		public bool Debit_AmountSpecified
		{
			get
			{
				return this.debit_AmountFieldSpecified;
			}
			set
			{
				this.debit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Debit_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Credit_Amount
		{
			get
			{
				return this.credit_AmountField;
			}
			set
			{
				this.credit_AmountField = value;
				this.RaisePropertyChanged("Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Credit_AmountSpecified
		{
			get
			{
				return this.credit_AmountFieldSpecified;
			}
			set
			{
				this.credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Credit_AmountSpecified");
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
		public decimal Currency_Rate
		{
			get
			{
				return this.currency_RateField;
			}
			set
			{
				this.currency_RateField = value;
				this.RaisePropertyChanged("Currency_Rate");
			}
		}

		[XmlIgnore]
		public bool Currency_RateSpecified
		{
			get
			{
				return this.currency_RateFieldSpecified;
			}
			set
			{
				this.currency_RateFieldSpecified = value;
				this.RaisePropertyChanged("Currency_RateSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Ledger_Debit_Amount
		{
			get
			{
				return this.ledger_Debit_AmountField;
			}
			set
			{
				this.ledger_Debit_AmountField = value;
				this.RaisePropertyChanged("Ledger_Debit_Amount");
			}
		}

		[XmlIgnore]
		public bool Ledger_Debit_AmountSpecified
		{
			get
			{
				return this.ledger_Debit_AmountFieldSpecified;
			}
			set
			{
				this.ledger_Debit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Ledger_Debit_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Ledger_Credit_Amount
		{
			get
			{
				return this.ledger_Credit_AmountField;
			}
			set
			{
				this.ledger_Credit_AmountField = value;
				this.RaisePropertyChanged("Ledger_Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Ledger_Credit_AmountSpecified
		{
			get
			{
				return this.ledger_Credit_AmountFieldSpecified;
			}
			set
			{
				this.ledger_Credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Ledger_Credit_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 11)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Quantity_2
		{
			get
			{
				return this.quantity_2Field;
			}
			set
			{
				this.quantity_2Field = value;
				this.RaisePropertyChanged("Quantity_2");
			}
		}

		[XmlIgnore]
		public bool Quantity_2Specified
		{
			get
			{
				return this.quantity_2FieldSpecified;
			}
			set
			{
				this.quantity_2FieldSpecified = value;
				this.RaisePropertyChanged("Quantity_2Specified");
			}
		}

		[XmlElement(Order = 13)]
		public Unit_of_MeasureObjectType Unit_of_Measure_2_Reference
		{
			get
			{
				return this.unit_of_Measure_2_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_2_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_2_Reference");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public string External_Reference_ID
		{
			get
			{
				return this.external_Reference_IDField;
			}
			set
			{
				this.external_Reference_IDField = value;
				this.RaisePropertyChanged("External_Reference_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Budget_Date
		{
			get
			{
				return this.budget_DateField;
			}
			set
			{
				this.budget_DateField = value;
				this.RaisePropertyChanged("Budget_Date");
			}
		}

		[XmlIgnore]
		public bool Budget_DateSpecified
		{
			get
			{
				return this.budget_DateFieldSpecified;
			}
			set
			{
				this.budget_DateFieldSpecified = value;
				this.RaisePropertyChanged("Budget_DateSpecified");
			}
		}

		[XmlElement("Worktags_Reference", Order = 17)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Balancing_WorktagObjectType Balancing_Worktag_Affiliate_Reference
		{
			get
			{
				return this.balancing_Worktag_Affiliate_ReferenceField;
			}
			set
			{
				this.balancing_Worktag_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Balancing_Worktag_Affiliate_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public bool Exclude_from_Spend_Report
		{
			get
			{
				return this.exclude_from_Spend_ReportField;
			}
			set
			{
				this.exclude_from_Spend_ReportField = value;
				this.RaisePropertyChanged("Exclude_from_Spend_Report");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_Spend_ReportSpecified
		{
			get
			{
				return this.exclude_from_Spend_ReportFieldSpecified;
			}
			set
			{
				this.exclude_from_Spend_ReportFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_Spend_ReportSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Journal_Line_Tax_Detail_DataType Tax_Detail_Data
		{
			get
			{
				return this.tax_Detail_DataField;
			}
			set
			{
				this.tax_Detail_DataField = value;
				this.RaisePropertyChanged("Tax_Detail_Data");
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
