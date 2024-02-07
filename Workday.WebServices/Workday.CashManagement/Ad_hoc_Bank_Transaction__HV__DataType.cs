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
	public class Ad_hoc_Bank_Transaction__HV__DataType : INotifyPropertyChanged
	{
		private string ad_hoc_Bank_Transaction_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private DateTime transaction_DateField;

		private string transaction_MemoField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Financial_AccountObjectType bank_Account_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private decimal currency_Rate_OverrideField;

		private bool currency_Rate_OverrideFieldSpecified;

		private decimal transaction_AmountField;

		private bool itemField;

		private ItemChoiceType3 itemElementNameField;

		private Ad_Hoc_Bank_Transaction_PurposeObjectType ad_hoc_Bank_Transaction_Purpose_ReferenceField;

		private string transaction_IDField;

		private bool include_in_IRS_1099Field;

		private bool include_in_IRS_1099FieldSpecified;

		private Journal_SourceObjectType journal_Source_ReferenceField;

		private string remove_Bank_Account_Worktag_on_OffsetField;

		private string eliminate_FX_Gain_LossField;

		private Ad_hoc_Bank_Transaction_Line__HV__DataType[] transaction_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Ad_hoc_Bank_Transaction_Intercompany_Sub_ProcessType ad_hoc_Bank_Transaction_Intercompany_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Ad_hoc_Bank_Transaction_ID
		{
			get
			{
				return this.ad_hoc_Bank_Transaction_IDField;
			}
			set
			{
				this.ad_hoc_Bank_Transaction_IDField = value;
				this.RaisePropertyChanged("Ad_hoc_Bank_Transaction_ID");
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Transaction_Memo
		{
			get
			{
				return this.transaction_MemoField;
			}
			set
			{
				this.transaction_MemoField = value;
				this.RaisePropertyChanged("Transaction_Memo");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 8)]
		public Currency_Rate_TypeObjectType Currency_Rate_Type_Reference
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Deposit", typeof(bool), Order = 11), XmlElement("Withdrawl", typeof(bool), Order = 11)]
		public bool Item
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

		[XmlElement(Order = 12), XmlIgnore]
		public ItemChoiceType3 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 13)]
		public Ad_Hoc_Bank_Transaction_PurposeObjectType Ad_hoc_Bank_Transaction_Purpose_Reference
		{
			get
			{
				return this.ad_hoc_Bank_Transaction_Purpose_ReferenceField;
			}
			set
			{
				this.ad_hoc_Bank_Transaction_Purpose_ReferenceField = value;
				this.RaisePropertyChanged("Ad_hoc_Bank_Transaction_Purpose_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public string Transaction_ID
		{
			get
			{
				return this.transaction_IDField;
			}
			set
			{
				this.transaction_IDField = value;
				this.RaisePropertyChanged("Transaction_ID");
			}
		}

		[XmlElement(Order = 15)]
		public bool Include_in_IRS_1099
		{
			get
			{
				return this.include_in_IRS_1099Field;
			}
			set
			{
				this.include_in_IRS_1099Field = value;
				this.RaisePropertyChanged("Include_in_IRS_1099");
			}
		}

		[XmlIgnore]
		public bool Include_in_IRS_1099Specified
		{
			get
			{
				return this.include_in_IRS_1099FieldSpecified;
			}
			set
			{
				this.include_in_IRS_1099FieldSpecified = value;
				this.RaisePropertyChanged("Include_in_IRS_1099Specified");
			}
		}

		[XmlElement(Order = 16)]
		public Journal_SourceObjectType Journal_Source_Reference
		{
			get
			{
				return this.journal_Source_ReferenceField;
			}
			set
			{
				this.journal_Source_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Source_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public string Remove_Bank_Account_Worktag_on_Offset
		{
			get
			{
				return this.remove_Bank_Account_Worktag_on_OffsetField;
			}
			set
			{
				this.remove_Bank_Account_Worktag_on_OffsetField = value;
				this.RaisePropertyChanged("Remove_Bank_Account_Worktag_on_Offset");
			}
		}

		[XmlElement(Order = 18)]
		public string Eliminate_FX_Gain_Loss
		{
			get
			{
				return this.eliminate_FX_Gain_LossField;
			}
			set
			{
				this.eliminate_FX_Gain_LossField = value;
				this.RaisePropertyChanged("Eliminate_FX_Gain_Loss");
			}
		}

		[XmlElement("Transaction_Line_Replacement_Data", Order = 19)]
		public Ad_hoc_Bank_Transaction_Line__HV__DataType[] Transaction_Line_Replacement_Data
		{
			get
			{
				return this.transaction_Line_Replacement_DataField;
			}
			set
			{
				this.transaction_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Transaction_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 20)]
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

		[XmlElement(Order = 21)]
		public Ad_hoc_Bank_Transaction_Intercompany_Sub_ProcessType Ad_hoc_Bank_Transaction_Intercompany_Sub_Process
		{
			get
			{
				return this.ad_hoc_Bank_Transaction_Intercompany_Sub_ProcessField;
			}
			set
			{
				this.ad_hoc_Bank_Transaction_Intercompany_Sub_ProcessField = value;
				this.RaisePropertyChanged("Ad_hoc_Bank_Transaction_Intercompany_Sub_Process");
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
