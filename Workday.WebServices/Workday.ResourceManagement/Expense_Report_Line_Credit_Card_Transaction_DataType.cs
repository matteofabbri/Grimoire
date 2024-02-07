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
	public class Expense_Report_Line_Credit_Card_Transaction_DataType : INotifyPropertyChanged
	{
		private DateTime expense_Report_Line_DateField;

		private bool expense_Report_Line_DateFieldSpecified;

		private Credit_Card_TransactionObjectType expense_Credit_Card_Transaction_ReferenceField;

		private DateTime posted_DateField;

		private bool posted_DateFieldSpecified;

		private string transaction_NumberField;

		private Credit_CardObjectType expense_Credit_Card_ReferenceField;

		private decimal transaction_AmountField;

		private bool transaction_AmountFieldSpecified;

		private decimal nonPersonal_Transaction_AmountField;

		private bool nonPersonal_Transaction_AmountFieldSpecified;

		private CurrencyObjectType transaction_Currency_ReferenceField;

		private Credit_Card_Transaction_Billing_Currency_Conversion_DataType credit_Card_Transaction_Billing_Currency_Conversion_DataField;

		private string market_CodeField;

		private Corporate_Credit_Card_AccountObjectType corporate_Account_ReferenceField;

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

		[XmlIgnore]
		public bool Expense_Report_Line_DateSpecified
		{
			get
			{
				return this.expense_Report_Line_DateFieldSpecified;
			}
			set
			{
				this.expense_Report_Line_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expense_Report_Line_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Credit_Card_TransactionObjectType Expense_Credit_Card_Transaction_Reference
		{
			get
			{
				return this.expense_Credit_Card_Transaction_ReferenceField;
			}
			set
			{
				this.expense_Credit_Card_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Transaction_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Credit_CardObjectType Expense_Credit_Card_Reference
		{
			get
			{
				return this.expense_Credit_Card_ReferenceField;
			}
			set
			{
				this.expense_Credit_Card_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Transaction_Amount
		{
			get
			{
				return this.transaction_AmountField;
			}
			set
			{
				this.transaction_AmountField = value;
				this.RaisePropertyChanged("Transaction_Amount");
			}
		}

		[XmlIgnore]
		public bool Transaction_AmountSpecified
		{
			get
			{
				return this.transaction_AmountFieldSpecified;
			}
			set
			{
				this.transaction_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_AmountSpecified");
			}
		}

		[XmlElement("Non-Personal_Transaction_Amount", Order = 6)]
		public decimal NonPersonal_Transaction_Amount
		{
			get
			{
				return this.nonPersonal_Transaction_AmountField;
			}
			set
			{
				this.nonPersonal_Transaction_AmountField = value;
				this.RaisePropertyChanged("NonPersonal_Transaction_Amount");
			}
		}

		[XmlIgnore]
		public bool NonPersonal_Transaction_AmountSpecified
		{
			get
			{
				return this.nonPersonal_Transaction_AmountFieldSpecified;
			}
			set
			{
				this.nonPersonal_Transaction_AmountFieldSpecified = value;
				this.RaisePropertyChanged("NonPersonal_Transaction_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public CurrencyObjectType Transaction_Currency_Reference
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

		[XmlElement(Order = 8)]
		public Credit_Card_Transaction_Billing_Currency_Conversion_DataType Credit_Card_Transaction_Billing_Currency_Conversion_Data
		{
			get
			{
				return this.credit_Card_Transaction_Billing_Currency_Conversion_DataField;
			}
			set
			{
				this.credit_Card_Transaction_Billing_Currency_Conversion_DataField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Billing_Currency_Conversion_Data");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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
