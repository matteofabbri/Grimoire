using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payslip_Payment_DataType : INotifyPropertyChanged
	{
		private decimal payroll_Payment_Display_OrderField;

		private bool payroll_Payment_Display_OrderFieldSpecified;

		private Payment_CategoryObjectType payment_Category_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Payment_MethodObjectType payment_Method_ReferenceField;

		private string bank_NameField;

		private Settlement_InstructionObjectType bank_Account_ReferenceField;

		private string account_NumberField;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private CurrencyObjectType payment_Currency_ReferenceField;

		private string amount_as_TextField;

		private decimal amount_in_Pay_Group_CurrencyField;

		private bool amount_in_Pay_Group_CurrencyFieldSpecified;

		private CurrencyObjectType pay_Group_Currency_ReferenceField;

		private string check_NumberField;

		private string payment_Reference_NumberField;

		private string payment_MemoField;

		private CompanyObjectType company_ReferenceField;

		private Originating_Party_WWS_DataType[] originating_Contact_DataField;

		private Originating_Party_Bank_DataType[] originating_Bank_DataField;

		private PayeeObjectType receiving_Party_ReferenceField;

		private Receiving_Party_WWS_DataType[] receiving_Party_Contact_DataField;

		private Receiving_Party_Bank_DataType[] receiving_Party_Bank_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public Payment_CategoryObjectType Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payment_TypeObjectType Payment_Type_Reference
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

		[XmlElement(Order = 3)]
		public Payment_MethodObjectType Payment_Method_Reference
		{
			get
			{
				return this.payment_Method_ReferenceField;
			}
			set
			{
				this.payment_Method_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Method_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string Bank_Name
		{
			get
			{
				return this.bank_NameField;
			}
			set
			{
				this.bank_NameField = value;
				this.RaisePropertyChanged("Bank_Name");
			}
		}

		[XmlElement(Order = 5)]
		public Settlement_InstructionObjectType Bank_Account_Reference
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

		[XmlElement(Order = 6)]
		public string Account_Number
		{
			get
			{
				return this.account_NumberField;
			}
			set
			{
				this.account_NumberField = value;
				this.RaisePropertyChanged("Account_Number");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public CurrencyObjectType Payment_Currency_Reference
		{
			get
			{
				return this.payment_Currency_ReferenceField;
			}
			set
			{
				this.payment_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Currency_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Amount_in_Pay_Group_Currency
		{
			get
			{
				return this.amount_in_Pay_Group_CurrencyField;
			}
			set
			{
				this.amount_in_Pay_Group_CurrencyField = value;
				this.RaisePropertyChanged("Amount_in_Pay_Group_Currency");
			}
		}

		[XmlIgnore]
		public bool Amount_in_Pay_Group_CurrencySpecified
		{
			get
			{
				return this.amount_in_Pay_Group_CurrencyFieldSpecified;
			}
			set
			{
				this.amount_in_Pay_Group_CurrencyFieldSpecified = value;
				this.RaisePropertyChanged("Amount_in_Pay_Group_CurrencySpecified");
			}
		}

		[XmlElement(Order = 11)]
		public CurrencyObjectType Pay_Group_Currency_Reference
		{
			get
			{
				return this.pay_Group_Currency_ReferenceField;
			}
			set
			{
				this.pay_Group_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Group_Currency_Reference");
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement("Originating_Contact_Data", Order = 16)]
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

		[XmlElement("Originating_Bank_Data", Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement("Receiving_Party_Contact_Data", Order = 19)]
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

		[XmlElement("Receiving_Party_Bank_Data", Order = 20)]
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
