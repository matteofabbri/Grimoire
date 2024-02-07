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
	public class Beginning_Balance_Journal_DataType : INotifyPropertyChanged
	{
		private string accounting_Journal_IDField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Currency_Rate_TypeObjectType currency_Rate_Type_ReferenceField;

		private Ledger_Year_ReferenceType ledger_Year_Reference_DataField;

		private string journal_Entry_MemoField;

		private Journal_SourceObjectType journal_Source_ReferenceField;

		private Book_CodeObjectType book_Code_ReferenceField;

		private bool record_QuantityField;

		private bool record_QuantityFieldSpecified;

		private Journal_Entry_Line_DataType[] journal_Entry_Line_Replacement_DataField;

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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Ledger_Year_ReferenceType Ledger_Year_Reference_Data
		{
			get
			{
				return this.ledger_Year_Reference_DataField;
			}
			set
			{
				this.ledger_Year_Reference_DataField = value;
				this.RaisePropertyChanged("Ledger_Year_Reference_Data");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Journal_Entry_Line_Replacement_Data", Order = 9)]
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
