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
	public class Journal_Entry_DataType : INotifyPropertyChanged
	{
		private Journal_EntryObjectType journal_Entry_ReferenceField;

		private string journal_NumberField;

		private string journal_Sequence_NumberField;

		private Journal_Entry_StatusObjectType journal_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Book_CodeObjectType book_Code_ReferenceField;

		private LedgerObjectType ledger_ReferenceField;

		private Account_SetObjectType display_Account_Set_ReferenceField;

		private Unique_IdentifierObjectType ledger_Period_ReferenceField;

		private DateTime accounting_DateField;

		private bool accounting_DateFieldSpecified;

		private Journal_SourceObjectType journal_Source_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] optional_Balancing_Worktags_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private Operational_TransactionObjectType operational_Transaction_ReferenceField;

		private bool record_QuantityField;

		private bool record_QuantityFieldSpecified;

		private string memoField;

		private string external_Reference_IDField;

		private string document_LinkField;

		private Unique_IdentifierObjectType originated_By_ReferenceField;

		private Unique_IdentifierObjectType[] approved_by_ReferenceField;

		private decimal total_Ledger_DebitsField;

		private bool total_Ledger_DebitsFieldSpecified;

		private decimal total_Ledger_CreditsField;

		private bool total_Ledger_CreditsFieldSpecified;

		private Journal_EntryObjectType reversed_By_Journal_Entry_ReferenceField;

		private Journal_EntryObjectType reverses_Journal_Entry_ReferenceField;

		private DateTime creation_DateField;

		private bool creation_DateFieldSpecified;

		private DateTime last_Updated_DateField;

		private bool last_Updated_DateFieldSpecified;

		private Journal_Entry_Line_DataType[] journal_Entry_Line_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Journal_EntryObjectType Journal_Entry_Reference
		{
			get
			{
				return this.journal_Entry_ReferenceField;
			}
			set
			{
				this.journal_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Entry_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Journal_Entry_StatusObjectType Journal_Status_Reference
		{
			get
			{
				return this.journal_Status_ReferenceField;
			}
			set
			{
				this.journal_Status_ReferenceField = value;
				this.RaisePropertyChanged("Journal_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public LedgerObjectType Ledger_Reference
		{
			get
			{
				return this.ledger_ReferenceField;
			}
			set
			{
				this.ledger_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Unique_IdentifierObjectType Ledger_Period_Reference
		{
			get
			{
				return this.ledger_Period_ReferenceField;
			}
			set
			{
				this.ledger_Period_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Period_Reference");
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

		[XmlIgnore]
		public bool Accounting_DateSpecified
		{
			get
			{
				return this.accounting_DateFieldSpecified;
			}
			set
			{
				this.accounting_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_DateSpecified");
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

		[XmlElement(DataType = "date", Order = 14)]
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

		[XmlElement(Order = 15)]
		public Operational_TransactionObjectType Operational_Transaction_Reference
		{
			get
			{
				return this.operational_Transaction_ReferenceField;
			}
			set
			{
				this.operational_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Operational_Transaction_Reference");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public Unique_IdentifierObjectType Originated_By_Reference
		{
			get
			{
				return this.originated_By_ReferenceField;
			}
			set
			{
				this.originated_By_ReferenceField = value;
				this.RaisePropertyChanged("Originated_By_Reference");
			}
		}

		[XmlElement("Approved_by_Reference", Order = 21)]
		public Unique_IdentifierObjectType[] Approved_by_Reference
		{
			get
			{
				return this.approved_by_ReferenceField;
			}
			set
			{
				this.approved_by_ReferenceField = value;
				this.RaisePropertyChanged("Approved_by_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public decimal Total_Ledger_Debits
		{
			get
			{
				return this.total_Ledger_DebitsField;
			}
			set
			{
				this.total_Ledger_DebitsField = value;
				this.RaisePropertyChanged("Total_Ledger_Debits");
			}
		}

		[XmlIgnore]
		public bool Total_Ledger_DebitsSpecified
		{
			get
			{
				return this.total_Ledger_DebitsFieldSpecified;
			}
			set
			{
				this.total_Ledger_DebitsFieldSpecified = value;
				this.RaisePropertyChanged("Total_Ledger_DebitsSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal Total_Ledger_Credits
		{
			get
			{
				return this.total_Ledger_CreditsField;
			}
			set
			{
				this.total_Ledger_CreditsField = value;
				this.RaisePropertyChanged("Total_Ledger_Credits");
			}
		}

		[XmlIgnore]
		public bool Total_Ledger_CreditsSpecified
		{
			get
			{
				return this.total_Ledger_CreditsFieldSpecified;
			}
			set
			{
				this.total_Ledger_CreditsFieldSpecified = value;
				this.RaisePropertyChanged("Total_Ledger_CreditsSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public Journal_EntryObjectType Reversed_By_Journal_Entry_Reference
		{
			get
			{
				return this.reversed_By_Journal_Entry_ReferenceField;
			}
			set
			{
				this.reversed_By_Journal_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Reversed_By_Journal_Entry_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Journal_EntryObjectType Reverses_Journal_Entry_Reference
		{
			get
			{
				return this.reverses_Journal_Entry_ReferenceField;
			}
			set
			{
				this.reverses_Journal_Entry_ReferenceField = value;
				this.RaisePropertyChanged("Reverses_Journal_Entry_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public DateTime Creation_Date
		{
			get
			{
				return this.creation_DateField;
			}
			set
			{
				this.creation_DateField = value;
				this.RaisePropertyChanged("Creation_Date");
			}
		}

		[XmlIgnore]
		public bool Creation_DateSpecified
		{
			get
			{
				return this.creation_DateFieldSpecified;
			}
			set
			{
				this.creation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Creation_DateSpecified");
			}
		}

		[XmlElement(Order = 27)]
		public DateTime Last_Updated_Date
		{
			get
			{
				return this.last_Updated_DateField;
			}
			set
			{
				this.last_Updated_DateField = value;
				this.RaisePropertyChanged("Last_Updated_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_DateSpecified
		{
			get
			{
				return this.last_Updated_DateFieldSpecified;
			}
			set
			{
				this.last_Updated_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_DateSpecified");
			}
		}

		[XmlElement("Journal_Entry_Line_Data", Order = 28)]
		public Journal_Entry_Line_DataType[] Journal_Entry_Line_Data
		{
			get
			{
				return this.journal_Entry_Line_DataField;
			}
			set
			{
				this.journal_Entry_Line_DataField = value;
				this.RaisePropertyChanged("Journal_Entry_Line_Data");
			}
		}

		[XmlElement("Attachment_Data", Order = 29)]
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
