using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Customer_Deposit_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime payment_Deposit_DateField;

		private Financial_AccountObjectType bank_Account_ReferenceField;

		private string deposit_Reference_NumberField;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private Currency_Rate_TypeObjectType[] currency_Rate_Type_ReferenceField;

		private decimal currency_Rate_OverrideField;

		private bool currency_Rate_OverrideFieldSpecified;

		private string electronic_File_InformationField;

		private Customer_PaymentObjectType[] customer_Payment_for_Invoices_ReferenceField;

		private decimal total_Deposit_AmountField;

		private bool total_Deposit_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Payment_Deposit_Date
		{
			get
			{
				return this.payment_Deposit_DateField;
			}
			set
			{
				this.payment_Deposit_DateField = value;
				this.RaisePropertyChanged("Payment_Deposit_Date");
			}
		}

		[XmlElement(Order = 6)]
		public Financial_AccountObjectType Bank_Account_Reference
		{
			get
			{
				return this.bank_Account_ReferenceField;
			}
			set
			{
				this.bank_Account_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Account_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Deposit_Reference_Number
		{
			get
			{
				return this.deposit_Reference_NumberField;
			}
			set
			{
				this.deposit_Reference_NumberField = value;
				this.RaisePropertyChanged("Deposit_Reference_Number");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Control_Total_Amount
		{
			get
			{
				return this.control_Total_AmountField;
			}
			set
			{
				this.control_Total_AmountField = value;
				this.RaisePropertyChanged("Control_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Control_Total_AmountSpecified
		{
			get
			{
				return this.control_Total_AmountFieldSpecified;
			}
			set
			{
				this.control_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Control_Total_AmountSpecified");
			}
		}

		[XmlElement("Currency_Rate_Type_Reference", Order = 9)]
		public Currency_Rate_TypeObjectType[] Currency_Rate_Type_Reference
		{
			get
			{
				return this.currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Currency_Rate_Override
		{
			get
			{
				return this.currency_Rate_OverrideField;
			}
			set
			{
				this.currency_Rate_OverrideField = value;
				this.RaisePropertyChanged("Currency_Rate_Override");
			}
		}

		[XmlIgnore]
		public bool Currency_Rate_OverrideSpecified
		{
			get
			{
				return this.currency_Rate_OverrideFieldSpecified;
			}
			set
			{
				this.currency_Rate_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Rate_OverrideSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public string Electronic_File_Information
		{
			get
			{
				return this.electronic_File_InformationField;
			}
			set
			{
				this.electronic_File_InformationField = value;
				this.RaisePropertyChanged("Electronic_File_Information");
			}
		}

		[XmlElement("Customer_Payment_for_Invoices_Reference", Order = 12)]
		public Customer_PaymentObjectType[] Customer_Payment_for_Invoices_Reference
		{
			get
			{
				return this.customer_Payment_for_Invoices_ReferenceField;
			}
			set
			{
				this.customer_Payment_for_Invoices_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Payment_for_Invoices_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Total_Deposit_Amount
		{
			get
			{
				return this.total_Deposit_AmountField;
			}
			set
			{
				this.total_Deposit_AmountField = value;
				this.RaisePropertyChanged("Total_Deposit_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Deposit_AmountSpecified
		{
			get
			{
				return this.total_Deposit_AmountFieldSpecified;
			}
			set
			{
				this.total_Deposit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Deposit_AmountSpecified");
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
