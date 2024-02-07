using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ProfessionalServicesAutomation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Report_Line_DataType : INotifyPropertyChanged
	{
		private DateTime expense_Report_Line_DateField;

		private Expense_Item_ReferenceType[] expense_Item_ReferenceField;

		private decimal quantityField;

		private decimal amountField;

		private Currency_Reference_DataType transaction_Currency_ReferenceField;

		private decimal currency_RateField;

		private bool currency_RateFieldSpecified;

		private decimal converted_AmountField;

		private bool converted_AmountFieldSpecified;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private bool receipt_IncludedField;

		private bool receipt_IncludedFieldSpecified;

		private bool billableField;

		private bool billableFieldSpecified;

		private string expense_Line_DescriptionField;

		private Worktag_for_Business_Document_Line_ReferenceType[] work_Tag_for_Business_Document_Line_ReferenceField;

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

		[XmlElement("Expense_Item_Reference", Order = 1)]
		public Expense_Item_ReferenceType[] Expense_Item_Reference
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

		[XmlElement(Order = 4)]
		public Currency_Reference_DataType Transaction_Currency_Reference
		{
			get
			{
				return this.transaction_Currency_ReferenceField;
			}
			set
			{
				this.transaction_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Currency_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public string Expense_Line_Description
		{
			get
			{
				return this.expense_Line_DescriptionField;
			}
			set
			{
				this.expense_Line_DescriptionField = value;
				this.RaisePropertyChanged("Expense_Line_Description");
			}
		}

		[XmlElement("Work_Tag_for_Business_Document_Line_Reference", Order = 11)]
		public Worktag_for_Business_Document_Line_ReferenceType[] Work_Tag_for_Business_Document_Line_Reference
		{
			get
			{
				return this.work_Tag_for_Business_Document_Line_ReferenceField;
			}
			set
			{
				this.work_Tag_for_Business_Document_Line_ReferenceField = value;
				this.RaisePropertyChanged("Work_Tag_for_Business_Document_Line_Reference");
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
