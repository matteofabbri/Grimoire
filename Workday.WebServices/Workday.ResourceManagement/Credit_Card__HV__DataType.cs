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
	public class Credit_Card__HV__DataType : INotifyPropertyChanged
	{
		private Worker_Credit_CardObjectType expense_Credit_Card_ReferenceField;

		private string expense_Credit_Card_IDField;

		private Corporate_Credit_Card_AccountObjectType corporate_Credit_Card_Account_ReferenceField;

		private object itemField;

		private string credit_Card_DescriptionField;

		private string last_4_Digits_of_Credit_Card_NumberField;

		private DateTime credit_Card_Expiration_DateField;

		private bool credit_Card_Expiration_DateFieldSpecified;

		private decimal monthly_LimitField;

		private bool monthly_LimitFieldSpecified;

		private decimal transaction_LimitField;

		private bool transaction_LimitFieldSpecified;

		private CurrencyObjectType billing_Currency_ReferenceField;

		private bool cash_Access_AllowedField;

		private bool cash_Access_AllowedFieldSpecified;

		private DateTime cancel_DateField;

		private bool cancel_DateFieldSpecified;

		private string cardmember_Embossed_NameField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private string expense_Credit_Card_TokenField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Worker_Credit_CardObjectType Expense_Credit_Card_Reference
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

		[XmlElement(Order = 1)]
		public string Expense_Credit_Card_ID
		{
			get
			{
				return this.expense_Credit_Card_IDField;
			}
			set
			{
				this.expense_Credit_Card_IDField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Corporate_Credit_Card_AccountObjectType Corporate_Credit_Card_Account_Reference
		{
			get
			{
				return this.corporate_Credit_Card_Account_ReferenceField;
			}
			set
			{
				this.corporate_Credit_Card_Account_ReferenceField = value;
				this.RaisePropertyChanged("Corporate_Credit_Card_Account_Reference");
			}
		}

		[XmlElement("Employee_ID", typeof(string), Order = 3), XmlElement("Employee_Reference", typeof(EmployeeObjectType), Order = 3)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 4)]
		public string Credit_Card_Description
		{
			get
			{
				return this.credit_Card_DescriptionField;
			}
			set
			{
				this.credit_Card_DescriptionField = value;
				this.RaisePropertyChanged("Credit_Card_Description");
			}
		}

		[XmlElement(Order = 5)]
		public string Last_4_Digits_of_Credit_Card_Number
		{
			get
			{
				return this.last_4_Digits_of_Credit_Card_NumberField;
			}
			set
			{
				this.last_4_Digits_of_Credit_Card_NumberField = value;
				this.RaisePropertyChanged("Last_4_Digits_of_Credit_Card_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Credit_Card_Expiration_Date
		{
			get
			{
				return this.credit_Card_Expiration_DateField;
			}
			set
			{
				this.credit_Card_Expiration_DateField = value;
				this.RaisePropertyChanged("Credit_Card_Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_Expiration_DateSpecified
		{
			get
			{
				return this.credit_Card_Expiration_DateFieldSpecified;
			}
			set
			{
				this.credit_Card_Expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Monthly_Limit
		{
			get
			{
				return this.monthly_LimitField;
			}
			set
			{
				this.monthly_LimitField = value;
				this.RaisePropertyChanged("Monthly_Limit");
			}
		}

		[XmlIgnore]
		public bool Monthly_LimitSpecified
		{
			get
			{
				return this.monthly_LimitFieldSpecified;
			}
			set
			{
				this.monthly_LimitFieldSpecified = value;
				this.RaisePropertyChanged("Monthly_LimitSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Transaction_Limit
		{
			get
			{
				return this.transaction_LimitField;
			}
			set
			{
				this.transaction_LimitField = value;
				this.RaisePropertyChanged("Transaction_Limit");
			}
		}

		[XmlIgnore]
		public bool Transaction_LimitSpecified
		{
			get
			{
				return this.transaction_LimitFieldSpecified;
			}
			set
			{
				this.transaction_LimitFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_LimitSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public CurrencyObjectType Billing_Currency_Reference
		{
			get
			{
				return this.billing_Currency_ReferenceField;
			}
			set
			{
				this.billing_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Currency_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Cash_Access_Allowed
		{
			get
			{
				return this.cash_Access_AllowedField;
			}
			set
			{
				this.cash_Access_AllowedField = value;
				this.RaisePropertyChanged("Cash_Access_Allowed");
			}
		}

		[XmlIgnore]
		public bool Cash_Access_AllowedSpecified
		{
			get
			{
				return this.cash_Access_AllowedFieldSpecified;
			}
			set
			{
				this.cash_Access_AllowedFieldSpecified = value;
				this.RaisePropertyChanged("Cash_Access_AllowedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Cancel_Date
		{
			get
			{
				return this.cancel_DateField;
			}
			set
			{
				this.cancel_DateField = value;
				this.RaisePropertyChanged("Cancel_Date");
			}
		}

		[XmlIgnore]
		public bool Cancel_DateSpecified
		{
			get
			{
				return this.cancel_DateFieldSpecified;
			}
			set
			{
				this.cancel_DateFieldSpecified = value;
				this.RaisePropertyChanged("Cancel_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public string Cardmember_Embossed_Name
		{
			get
			{
				return this.cardmember_Embossed_NameField;
			}
			set
			{
				this.cardmember_Embossed_NameField = value;
				this.RaisePropertyChanged("Cardmember_Embossed_Name");
			}
		}

		[XmlElement(Order = 13)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public string Expense_Credit_Card_Token
		{
			get
			{
				return this.expense_Credit_Card_TokenField;
			}
			set
			{
				this.expense_Credit_Card_TokenField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Token");
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
