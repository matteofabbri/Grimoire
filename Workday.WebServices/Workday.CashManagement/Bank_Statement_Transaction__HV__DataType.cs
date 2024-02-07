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
	public class Bank_Statement_Transaction__HV__DataType : INotifyPropertyChanged
	{
		private Bank_Statement_Transaction_Type_ReferenceType bank_Statement_Transaction_Type_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private decimal amountField;

		private bool amountFieldSpecified;

		private string bank_Reference_NumberField;

		private string customer_Reference_NumberField;

		private string textField;

		private Funds_Availability_DataType[] funds_Availability_DataField;

		private string alternate_Transaction_Type_CodeField;

		private decimal originating_Currency_AmountField;

		private bool originating_Currency_AmountFieldSpecified;

		private string originating_CurrencyField;

		private decimal currency_Exchange_RateField;

		private bool currency_Exchange_RateFieldSpecified;

		private bool debitField;

		private bool debitFieldSpecified;

		private DateTime value_DateField;

		private bool value_DateFieldSpecified;

		private bool reversal_IndicatorField;

		private bool reversal_IndicatorFieldSpecified;

		private string additional_Reference_Field_1Field;

		private string additional_Reference_Field_2Field;

		private string additional_Reference_Field_3Field;

		private string additional_Reference_Field_4Field;

		private string additional_Reference_Field_5Field;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Statement_Transaction_Type_ReferenceType Bank_Statement_Transaction_Type_Reference
		{
			get
			{
				return this.bank_Statement_Transaction_Type_ReferenceField;
			}
			set
			{
				this.bank_Statement_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Transaction_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Bank_Reference_Number
		{
			get
			{
				return this.bank_Reference_NumberField;
			}
			set
			{
				this.bank_Reference_NumberField = value;
				this.RaisePropertyChanged("Bank_Reference_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Customer_Reference_Number
		{
			get
			{
				return this.customer_Reference_NumberField;
			}
			set
			{
				this.customer_Reference_NumberField = value;
				this.RaisePropertyChanged("Customer_Reference_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Text
		{
			get
			{
				return this.textField;
			}
			set
			{
				this.textField = value;
				this.RaisePropertyChanged("Text");
			}
		}

		[XmlElement("Funds_Availability_Data", Order = 6)]
		public Funds_Availability_DataType[] Funds_Availability_Data
		{
			get
			{
				return this.funds_Availability_DataField;
			}
			set
			{
				this.funds_Availability_DataField = value;
				this.RaisePropertyChanged("Funds_Availability_Data");
			}
		}

		[XmlElement(Order = 7)]
		public string Alternate_Transaction_Type_Code
		{
			get
			{
				return this.alternate_Transaction_Type_CodeField;
			}
			set
			{
				this.alternate_Transaction_Type_CodeField = value;
				this.RaisePropertyChanged("Alternate_Transaction_Type_Code");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Originating_Currency_Amount
		{
			get
			{
				return this.originating_Currency_AmountField;
			}
			set
			{
				this.originating_Currency_AmountField = value;
				this.RaisePropertyChanged("Originating_Currency_Amount");
			}
		}

		[XmlIgnore]
		public bool Originating_Currency_AmountSpecified
		{
			get
			{
				return this.originating_Currency_AmountFieldSpecified;
			}
			set
			{
				this.originating_Currency_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Originating_Currency_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Originating_Currency
		{
			get
			{
				return this.originating_CurrencyField;
			}
			set
			{
				this.originating_CurrencyField = value;
				this.RaisePropertyChanged("Originating_Currency");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public bool Debit
		{
			get
			{
				return this.debitField;
			}
			set
			{
				this.debitField = value;
				this.RaisePropertyChanged("Debit");
			}
		}

		[XmlIgnore]
		public bool DebitSpecified
		{
			get
			{
				return this.debitFieldSpecified;
			}
			set
			{
				this.debitFieldSpecified = value;
				this.RaisePropertyChanged("DebitSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Value_Date
		{
			get
			{
				return this.value_DateField;
			}
			set
			{
				this.value_DateField = value;
				this.RaisePropertyChanged("Value_Date");
			}
		}

		[XmlIgnore]
		public bool Value_DateSpecified
		{
			get
			{
				return this.value_DateFieldSpecified;
			}
			set
			{
				this.value_DateFieldSpecified = value;
				this.RaisePropertyChanged("Value_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Reversal_Indicator
		{
			get
			{
				return this.reversal_IndicatorField;
			}
			set
			{
				this.reversal_IndicatorField = value;
				this.RaisePropertyChanged("Reversal_Indicator");
			}
		}

		[XmlIgnore]
		public bool Reversal_IndicatorSpecified
		{
			get
			{
				return this.reversal_IndicatorFieldSpecified;
			}
			set
			{
				this.reversal_IndicatorFieldSpecified = value;
				this.RaisePropertyChanged("Reversal_IndicatorSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public string Additional_Reference_Field_1
		{
			get
			{
				return this.additional_Reference_Field_1Field;
			}
			set
			{
				this.additional_Reference_Field_1Field = value;
				this.RaisePropertyChanged("Additional_Reference_Field_1");
			}
		}

		[XmlElement(Order = 15)]
		public string Additional_Reference_Field_2
		{
			get
			{
				return this.additional_Reference_Field_2Field;
			}
			set
			{
				this.additional_Reference_Field_2Field = value;
				this.RaisePropertyChanged("Additional_Reference_Field_2");
			}
		}

		[XmlElement(Order = 16)]
		public string Additional_Reference_Field_3
		{
			get
			{
				return this.additional_Reference_Field_3Field;
			}
			set
			{
				this.additional_Reference_Field_3Field = value;
				this.RaisePropertyChanged("Additional_Reference_Field_3");
			}
		}

		[XmlElement(Order = 17)]
		public string Additional_Reference_Field_4
		{
			get
			{
				return this.additional_Reference_Field_4Field;
			}
			set
			{
				this.additional_Reference_Field_4Field = value;
				this.RaisePropertyChanged("Additional_Reference_Field_4");
			}
		}

		[XmlElement(Order = 18)]
		public string Additional_Reference_Field_5
		{
			get
			{
				return this.additional_Reference_Field_5Field;
			}
			set
			{
				this.additional_Reference_Field_5Field = value;
				this.RaisePropertyChanged("Additional_Reference_Field_5");
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
