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
	public class Bank_Statement_Transaction_DataType : INotifyPropertyChanged
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
