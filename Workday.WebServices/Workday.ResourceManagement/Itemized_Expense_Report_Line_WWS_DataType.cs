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
	public class Itemized_Expense_Report_Line_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime expense_Report_Line_DateField;

		private Item_DescriptorObjectType expense_Item_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal amountField;

		private bool amountFieldSpecified;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal currency_RateField;

		private bool currency_RateFieldSpecified;

		private decimal converted_AmountField;

		private bool converted_AmountFieldSpecified;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private bool receipt_IncludedField;

		private bool receipt_IncludedFieldSpecified;

		private bool personal_ExpenseField;

		private bool personal_ExpenseFieldSpecified;

		private bool billableField;

		private bool billableFieldSpecified;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private string memoField;

		private Expense_Report_Line_Detail_DataType expense_Item_Details_DataField;

		private decimal reimbursement_AmountField;

		private bool reimbursement_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Expense_Report_Line_Date
		{
			get
			{
				return this.expense_Report_Line_DateField;
			}
			set
			{
				this.expense_Report_Line_DateField = value;
				this.RaisePropertyChanged("Expense_Report_Line_Date");
			}
		}

		[XmlElement(Order = 1)]
		public Item_DescriptorObjectType Expense_Item_Reference
		{
			get
			{
				return this.expense_Item_ReferenceField;
			}
			set
			{
				this.expense_Item_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Item_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Total_Amount
		{
			get
			{
				return this.total_AmountField;
			}
			set
			{
				this.total_AmountField = value;
				this.RaisePropertyChanged("Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_AmountSpecified
		{
			get
			{
				return this.total_AmountFieldSpecified;
			}
			set
			{
				this.total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Receipt_Included
		{
			get
			{
				return this.receipt_IncludedField;
			}
			set
			{
				this.receipt_IncludedField = value;
				this.RaisePropertyChanged("Receipt_Included");
			}
		}

		[XmlIgnore]
		public bool Receipt_IncludedSpecified
		{
			get
			{
				return this.receipt_IncludedFieldSpecified;
			}
			set
			{
				this.receipt_IncludedFieldSpecified = value;
				this.RaisePropertyChanged("Receipt_IncludedSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Personal_Expense
		{
			get
			{
				return this.personal_ExpenseField;
			}
			set
			{
				this.personal_ExpenseField = value;
				this.RaisePropertyChanged("Personal_Expense");
			}
		}

		[XmlIgnore]
		public bool Personal_ExpenseSpecified
		{
			get
			{
				return this.personal_ExpenseFieldSpecified;
			}
			set
			{
				this.personal_ExpenseFieldSpecified = value;
				this.RaisePropertyChanged("Personal_ExpenseSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Billable
		{
			get
			{
				return this.billableField;
			}
			set
			{
				this.billableField = value;
				this.RaisePropertyChanged("Billable");
			}
		}

		[XmlIgnore]
		public bool BillableSpecified
		{
			get
			{
				return this.billableFieldSpecified;
			}
			set
			{
				this.billableFieldSpecified = value;
				this.RaisePropertyChanged("BillableSpecified");
			}
		}

		[XmlElement("Worktag_Reference", Order = 14)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public Expense_Report_Line_Detail_DataType Expense_Item_Details_Data
		{
			get
			{
				return this.expense_Item_Details_DataField;
			}
			set
			{
				this.expense_Item_Details_DataField = value;
				this.RaisePropertyChanged("Expense_Item_Details_Data");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Reimbursement_Amount
		{
			get
			{
				return this.reimbursement_AmountField;
			}
			set
			{
				this.reimbursement_AmountField = value;
				this.RaisePropertyChanged("Reimbursement_Amount");
			}
		}

		[XmlIgnore]
		public bool Reimbursement_AmountSpecified
		{
			get
			{
				return this.reimbursement_AmountFieldSpecified;
			}
			set
			{
				this.reimbursement_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Reimbursement_AmountSpecified");
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
