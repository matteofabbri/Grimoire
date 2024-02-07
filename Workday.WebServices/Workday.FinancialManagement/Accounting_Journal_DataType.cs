using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Accounting_Journal_DataType : INotifyPropertyChanged
	{
		private string accounting_Journal_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private bool disable_Optional_Worktag_BalancingField;

		private bool disable_Optional_Worktag_BalancingFieldSpecified;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private string journal_NumberField;

		private string journal_Sequence_NumberField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Ledger_TypeObjectType ledger_Type_ReferenceField;

		private Book_CodeObjectType book_Code_ReferenceField;

		private DateTime accounting_DateField;

		private Journal_SourceObjectType journal_Source_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] optional_Balancing_Worktags_ReferenceField;

		private bool record_QuantityField;

		private bool record_QuantityFieldSpecified;

		private string journal_Entry_MemoField;

		private string external_Reference_IDField;

		private string document_LinkField;

		private Account_SetObjectType display_Account_Set_ReferenceField;

		private bool adjustment_JournalField;

		private bool adjustment_JournalFieldSpecified;

		private bool include_Tax_LinesField;

		private bool include_Tax_LinesFieldSpecified;

		private bool create_ReversalField;

		private bool create_ReversalFieldSpecified;

		private DateTime reversal_DateField;

		private bool reversal_DateFieldSpecified;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private Journal_Entry_Line_DataType[] journal_Entry_Line_Replacement_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Accounting_Journal_Intercompany_Sub_ProcessType accounting_Journal_Intercompany_Sub_ProcessField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Accounting_Journal_ID
		{
			get
			{
				return this.accounting_Journal_IDField;
			}
			set
			{
				this.accounting_Journal_IDField = value;
				this.RaisePropertyChanged("Accounting_Journal_ID");
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
		public bool Disable_Optional_Worktag_Balancing
		{
			get
			{
				return this.disable_Optional_Worktag_BalancingField;
			}
			set
			{
				this.disable_Optional_Worktag_BalancingField = value;
				this.RaisePropertyChanged("Disable_Optional_Worktag_Balancing");
			}
		}

		[XmlIgnore]
		public bool Disable_Optional_Worktag_BalancingSpecified
		{
			get
			{
				return this.disable_Optional_Worktag_BalancingFieldSpecified;
			}
			set
			{
				this.disable_Optional_Worktag_BalancingFieldSpecified = value;
				this.RaisePropertyChanged("Disable_Optional_Worktag_BalancingSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Journal_Number
		{
			get
			{
				return this.journal_NumberField;
			}
			set
			{
				this.journal_NumberField = value;
				this.RaisePropertyChanged("Journal_Number");
			}
		}

		[XmlElement(Order = 5)]
		public string Journal_Sequence_Number
		{
			get
			{
				return this.journal_Sequence_NumberField;
			}
			set
			{
				this.journal_Sequence_NumberField = value;
				this.RaisePropertyChanged("Journal_Sequence_Number");
			}
		}

		[XmlElement(Order = 6)]
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
		public Ledger_TypeObjectType Ledger_Type_Reference
		{
			get
			{
				return this.ledger_Type_ReferenceField;
			}
			set
			{
				this.ledger_Type_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Book_CodeObjectType Book_Code_Reference
		{
			get
			{
				return this.book_Code_ReferenceField;
			}
			set
			{
				this.book_Code_ReferenceField = value;
				this.RaisePropertyChanged("Book_Code_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Accounting_Date
		{
			get
			{
				return this.accounting_DateField;
			}
			set
			{
				this.accounting_DateField = value;
				this.RaisePropertyChanged("Accounting_Date");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Balancing_WorktagObjectType Balancing_Worktag_Reference
		{
			get
			{
				return this.balancing_Worktag_ReferenceField;
			}
			set
			{
				this.balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Optional_Balancing_Worktags_Reference", Order = 13)]
		public Audited_Accounting_WorktagObjectType[] Optional_Balancing_Worktags_Reference
		{
			get
			{
				return this.optional_Balancing_Worktags_ReferenceField;
			}
			set
			{
				this.optional_Balancing_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Balancing_Worktags_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public bool Record_Quantity
		{
			get
			{
				return this.record_QuantityField;
			}
			set
			{
				this.record_QuantityField = value;
				this.RaisePropertyChanged("Record_Quantity");
			}
		}

		[XmlIgnore]
		public bool Record_QuantitySpecified
		{
			get
			{
				return this.record_QuantityFieldSpecified;
			}
			set
			{
				this.record_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Record_QuantitySpecified");
			}
		}

		[XmlElement(Order = 15)]
		public string Journal_Entry_Memo
		{
			get
			{
				return this.journal_Entry_MemoField;
			}
			set
			{
				this.journal_Entry_MemoField = value;
				this.RaisePropertyChanged("Journal_Entry_Memo");
			}
		}

		[XmlElement(Order = 16)]
		public string External_Reference_ID
		{
			get
			{
				return this.external_Reference_IDField;
			}
			set
			{
				this.external_Reference_IDField = value;
				this.RaisePropertyChanged("External_Reference_ID");
			}
		}

		[XmlElement(Order = 17)]
		public string Document_Link
		{
			get
			{
				return this.document_LinkField;
			}
			set
			{
				this.document_LinkField = value;
				this.RaisePropertyChanged("Document_Link");
			}
		}

		[XmlElement(Order = 18)]
		public Account_SetObjectType Display_Account_Set_Reference
		{
			get
			{
				return this.display_Account_Set_ReferenceField;
			}
			set
			{
				this.display_Account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Display_Account_Set_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public bool Adjustment_Journal
		{
			get
			{
				return this.adjustment_JournalField;
			}
			set
			{
				this.adjustment_JournalField = value;
				this.RaisePropertyChanged("Adjustment_Journal");
			}
		}

		[XmlIgnore]
		public bool Adjustment_JournalSpecified
		{
			get
			{
				return this.adjustment_JournalFieldSpecified;
			}
			set
			{
				this.adjustment_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_JournalSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public bool Include_Tax_Lines
		{
			get
			{
				return this.include_Tax_LinesField;
			}
			set
			{
				this.include_Tax_LinesField = value;
				this.RaisePropertyChanged("Include_Tax_Lines");
			}
		}

		[XmlIgnore]
		public bool Include_Tax_LinesSpecified
		{
			get
			{
				return this.include_Tax_LinesFieldSpecified;
			}
			set
			{
				this.include_Tax_LinesFieldSpecified = value;
				this.RaisePropertyChanged("Include_Tax_LinesSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Create_Reversal
		{
			get
			{
				return this.create_ReversalField;
			}
			set
			{
				this.create_ReversalField = value;
				this.RaisePropertyChanged("Create_Reversal");
			}
		}

		[XmlIgnore]
		public bool Create_ReversalSpecified
		{
			get
			{
				return this.create_ReversalFieldSpecified;
			}
			set
			{
				this.create_ReversalFieldSpecified = value;
				this.RaisePropertyChanged("Create_ReversalSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Reversal_Date
		{
			get
			{
				return this.reversal_DateField;
			}
			set
			{
				this.reversal_DateField = value;
				this.RaisePropertyChanged("Reversal_Date");
			}
		}

		[XmlIgnore]
		public bool Reversal_DateSpecified
		{
			get
			{
				return this.reversal_DateFieldSpecified;
			}
			set
			{
				this.reversal_DateFieldSpecified = value;
				this.RaisePropertyChanged("Reversal_DateSpecified");
			}
		}

		[XmlElement(Order = 23)]
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

		[XmlElement(Order = 24)]
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

		[XmlElement("Journal_Entry_Line_Replacement_Data", Order = 25)]
		public Journal_Entry_Line_DataType[] Journal_Entry_Line_Replacement_Data
		{
			get
			{
				return this.journal_Entry_Line_Replacement_DataField;
			}
			set
			{
				this.journal_Entry_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Journal_Entry_Line_Replacement_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 26)]
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

		[XmlElement(Order = 27)]
		public Accounting_Journal_Intercompany_Sub_ProcessType Accounting_Journal_Intercompany_Sub_Process
		{
			get
			{
				return this.accounting_Journal_Intercompany_Sub_ProcessField;
			}
			set
			{
				this.accounting_Journal_Intercompany_Sub_ProcessField = value;
				this.RaisePropertyChanged("Accounting_Journal_Intercompany_Sub_Process");
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
