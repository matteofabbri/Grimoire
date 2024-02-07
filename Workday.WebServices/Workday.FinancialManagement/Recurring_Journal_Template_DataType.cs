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
	public class Recurring_Journal_Template_DataType : INotifyPropertyChanged
	{
		private string recurring_Journal_Template_IDField;

		private bool round_Ledger_AmountsField;

		private bool round_Ledger_AmountsFieldSpecified;

		private string recurring_Journal_Template_NameField;

		private CurrencyObjectType currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private Account_SetObjectType display_Account_Set_ReferenceField;

		private Ledger_ReferenceType ledger_Reference_DataField;

		private DateTime recurring_Journal_Template_Start_DateField;

		private DateTime recurring_Journal_Template_End_DateField;

		private bool reset_Currency_Rate_at_Journal_GenerationField;

		private bool reset_Currency_Rate_at_Journal_GenerationFieldSpecified;

		private bool automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateField;

		private bool automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateFieldSpecified;

		private object itemField;

		private bool record_QuantityField;

		private bool record_QuantityFieldSpecified;

		private string journal_Entry_MemoField;

		private string document_LinkField;

		private bool create_ReversalField;

		private bool create_ReversalFieldSpecified;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private Journal_SourceObjectType journal_Source_ReferenceField;

		private Book_CodeObjectType book_Code_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] optional_Balancing_Worktags_ReferenceField;

		private Journal_Entry_Line_DataType[] journal_Entry_Line_Replacement_DataField;

		private CompanyObjectType company_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Recurring_Journal_Template_ID
		{
			get
			{
				return this.recurring_Journal_Template_IDField;
			}
			set
			{
				this.recurring_Journal_Template_IDField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Round_Ledger_Amounts
		{
			get
			{
				return this.round_Ledger_AmountsField;
			}
			set
			{
				this.round_Ledger_AmountsField = value;
				this.RaisePropertyChanged("Round_Ledger_Amounts");
			}
		}

		[XmlIgnore]
		public bool Round_Ledger_AmountsSpecified
		{
			get
			{
				return this.round_Ledger_AmountsFieldSpecified;
			}
			set
			{
				this.round_Ledger_AmountsFieldSpecified = value;
				this.RaisePropertyChanged("Round_Ledger_AmountsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Recurring_Journal_Template_Name
		{
			get
			{
				return this.recurring_Journal_Template_NameField;
			}
			set
			{
				this.recurring_Journal_Template_NameField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_Name");
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Ledger_ReferenceType Ledger_Reference_Data
		{
			get
			{
				return this.ledger_Reference_DataField;
			}
			set
			{
				this.ledger_Reference_DataField = value;
				this.RaisePropertyChanged("Ledger_Reference_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Recurring_Journal_Template_Start_Date
		{
			get
			{
				return this.recurring_Journal_Template_Start_DateField;
			}
			set
			{
				this.recurring_Journal_Template_Start_DateField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Recurring_Journal_Template_End_Date
		{
			get
			{
				return this.recurring_Journal_Template_End_DateField;
			}
			set
			{
				this.recurring_Journal_Template_End_DateField = value;
				this.RaisePropertyChanged("Recurring_Journal_Template_End_Date");
			}
		}

		[XmlElement(Order = 9)]
		public bool Reset_Currency_Rate_at_Journal_Generation
		{
			get
			{
				return this.reset_Currency_Rate_at_Journal_GenerationField;
			}
			set
			{
				this.reset_Currency_Rate_at_Journal_GenerationField = value;
				this.RaisePropertyChanged("Reset_Currency_Rate_at_Journal_Generation");
			}
		}

		[XmlIgnore]
		public bool Reset_Currency_Rate_at_Journal_GenerationSpecified
		{
			get
			{
				return this.reset_Currency_Rate_at_Journal_GenerationFieldSpecified;
			}
			set
			{
				this.reset_Currency_Rate_at_Journal_GenerationFieldSpecified = value;
				this.RaisePropertyChanged("Reset_Currency_Rate_at_Journal_GenerationSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Automatically_Submit_Journals_Generated_from_Recurring_Journal_Template
		{
			get
			{
				return this.automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateField;
			}
			set
			{
				this.automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateField = value;
				this.RaisePropertyChanged("Automatically_Submit_Journals_Generated_from_Recurring_Journal_Template");
			}
		}

		[XmlIgnore]
		public bool Automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateSpecified
		{
			get
			{
				return this.automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateFieldSpecified;
			}
			set
			{
				this.automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateFieldSpecified = value;
				this.RaisePropertyChanged("Automatically_Submit_Journals_Generated_from_Recurring_Journal_TemplateSpecified");
			}
		}

		[XmlElement("Generate_Once_Per_Period", typeof(bool), Order = 11), XmlElement("Summary_Schedule_Reference", typeof(Fiscal_Summary_ScheduleObjectType), Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement("Optional_Balancing_Worktags_Reference", Order = 20)]
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

		[XmlElement("Journal_Entry_Line_Replacement_Data", Order = 21)]
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

		[XmlElement(Order = 22)]
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
