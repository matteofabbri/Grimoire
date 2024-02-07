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
	public class Bank_Account_Transfer_DataType : INotifyPropertyChanged
	{
		private string bank_Account_Transfer_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private DateTime dateField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal amountField;

		private bool eliminate_Foreign_Exchange_Gain_or_LossField;

		private bool eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified;

		private string memoField;

		private string transactionField;

		private CompanyObjectType company_ReferenceField;

		private Financial_AccountObjectType from_Account_ReferenceField;

		private CurrencyObjectType from_Account_Currency_ReferenceField;

		private Currency_Rate_TypeObjectType from_Account_Currency_Rate_Type_ReferenceField;

		private decimal from_Account_Currency_Conversion_RateField;

		private bool from_Account_Currency_Conversion_RateFieldSpecified;

		private Balancing_WorktagObjectType from_Account_Balancing_Worktag_ReferenceField;

		private Accounting_WorktagObjectType[] optional_Balancing_Worktags_from_Account_ReferenceField;

		private CompanyObjectType to_Company_ReferenceField;

		private Financial_AccountObjectType to_Account_ReferenceField;

		private CurrencyObjectType to_Account_Currency_ReferenceField;

		private Currency_Rate_TypeObjectType to_Account_Currency_Rate_Type_ReferenceField;

		private decimal to_Account_Currency_Conversion_RateField;

		private bool to_Account_Currency_Conversion_RateFieldSpecified;

		private Balancing_WorktagObjectType to_Account_Balancing_Worktag_ReferenceField;

		private Accounting_WorktagObjectType[] optional_Balancing_Worktags_To_Account_ReferenceField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Bank_Account_Transfer_ID
		{
			get
			{
				return this.bank_Account_Transfer_IDField;
			}
			set
			{
				this.bank_Account_Transfer_IDField = value;
				this.RaisePropertyChanged("Bank_Account_Transfer_ID");
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Date
		{
			get
			{
				return this.dateField;
			}
			set
			{
				this.dateField = value;
				this.RaisePropertyChanged("Date");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public bool Eliminate_Foreign_Exchange_Gain_or_Loss
		{
			get
			{
				return this.eliminate_Foreign_Exchange_Gain_or_LossField;
			}
			set
			{
				this.eliminate_Foreign_Exchange_Gain_or_LossField = value;
				this.RaisePropertyChanged("Eliminate_Foreign_Exchange_Gain_or_Loss");
			}
		}

		[XmlIgnore]
		public bool Eliminate_Foreign_Exchange_Gain_or_LossSpecified
		{
			get
			{
				return this.eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified;
			}
			set
			{
				this.eliminate_Foreign_Exchange_Gain_or_LossFieldSpecified = value;
				this.RaisePropertyChanged("Eliminate_Foreign_Exchange_Gain_or_LossSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Transaction
		{
			get
			{
				return this.transactionField;
			}
			set
			{
				this.transactionField = value;
				this.RaisePropertyChanged("Transaction");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Financial_AccountObjectType From_Account_Reference
		{
			get
			{
				return this.from_Account_ReferenceField;
			}
			set
			{
				this.from_Account_ReferenceField = value;
				this.RaisePropertyChanged("From_Account_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public CurrencyObjectType From_Account_Currency_Reference
		{
			get
			{
				return this.from_Account_Currency_ReferenceField;
			}
			set
			{
				this.from_Account_Currency_ReferenceField = value;
				this.RaisePropertyChanged("From_Account_Currency_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Currency_Rate_TypeObjectType From_Account_Currency_Rate_Type_Reference
		{
			get
			{
				return this.from_Account_Currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.from_Account_Currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("From_Account_Currency_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal From_Account_Currency_Conversion_Rate
		{
			get
			{
				return this.from_Account_Currency_Conversion_RateField;
			}
			set
			{
				this.from_Account_Currency_Conversion_RateField = value;
				this.RaisePropertyChanged("From_Account_Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool From_Account_Currency_Conversion_RateSpecified
		{
			get
			{
				return this.from_Account_Currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.from_Account_Currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("From_Account_Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Balancing_WorktagObjectType From_Account_Balancing_Worktag_Reference
		{
			get
			{
				return this.from_Account_Balancing_Worktag_ReferenceField;
			}
			set
			{
				this.from_Account_Balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("From_Account_Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Optional_Balancing_Worktags_from_Account_Reference", Order = 14)]
		public Accounting_WorktagObjectType[] Optional_Balancing_Worktags_from_Account_Reference
		{
			get
			{
				return this.optional_Balancing_Worktags_from_Account_ReferenceField;
			}
			set
			{
				this.optional_Balancing_Worktags_from_Account_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Balancing_Worktags_from_Account_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public CompanyObjectType To_Company_Reference
		{
			get
			{
				return this.to_Company_ReferenceField;
			}
			set
			{
				this.to_Company_ReferenceField = value;
				this.RaisePropertyChanged("To_Company_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Financial_AccountObjectType To_Account_Reference
		{
			get
			{
				return this.to_Account_ReferenceField;
			}
			set
			{
				this.to_Account_ReferenceField = value;
				this.RaisePropertyChanged("To_Account_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public CurrencyObjectType To_Account_Currency_Reference
		{
			get
			{
				return this.to_Account_Currency_ReferenceField;
			}
			set
			{
				this.to_Account_Currency_ReferenceField = value;
				this.RaisePropertyChanged("To_Account_Currency_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Currency_Rate_TypeObjectType To_Account_Currency_Rate_Type_Reference
		{
			get
			{
				return this.to_Account_Currency_Rate_Type_ReferenceField;
			}
			set
			{
				this.to_Account_Currency_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("To_Account_Currency_Rate_Type_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public decimal To_Account_Currency_Conversion_Rate
		{
			get
			{
				return this.to_Account_Currency_Conversion_RateField;
			}
			set
			{
				this.to_Account_Currency_Conversion_RateField = value;
				this.RaisePropertyChanged("To_Account_Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool To_Account_Currency_Conversion_RateSpecified
		{
			get
			{
				return this.to_Account_Currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.to_Account_Currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("To_Account_Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Balancing_WorktagObjectType To_Account_Balancing_Worktag_Reference
		{
			get
			{
				return this.to_Account_Balancing_Worktag_ReferenceField;
			}
			set
			{
				this.to_Account_Balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("To_Account_Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Optional_Balancing_Worktags_To_Account_Reference", Order = 21)]
		public Accounting_WorktagObjectType[] Optional_Balancing_Worktags_To_Account_Reference
		{
			get
			{
				return this.optional_Balancing_Worktags_To_Account_ReferenceField;
			}
			set
			{
				this.optional_Balancing_Worktags_To_Account_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Balancing_Worktags_To_Account_Reference");
			}
		}

		[XmlElement("Attachment_Data", Order = 22)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
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
