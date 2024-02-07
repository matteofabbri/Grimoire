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
	public class Journal_Entry_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_ReferenceField;

		private DateTime accounting_From_DateField;

		private bool accounting_From_DateFieldSpecified;

		private DateTime accounting_To_DateField;

		private bool accounting_To_DateFieldSpecified;

		private Journal_SourceObjectType[] journal_Source_ReferenceField;

		private DateTime updated_From_DateField;

		private bool updated_From_DateFieldSpecified;

		private DateTime updated_To_DateField;

		private bool updated_To_DateFieldSpecified;

		private string journal_NumberField;

		private Journal_Entry_StatusObjectType[] status_ReferenceField;

		private Unique_IdentifierObjectType[] originated_by_Person_ReferenceField;

		private Unique_IdentifierObjectType[] approved_by_Person_ReferenceField;

		private Ledger_AccountObjectType[] ledger_Account_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private BookObjectType book_ReferenceField;

		private bool adjustment_JournalField;

		private bool adjustment_JournalFieldSpecified;

		private bool reversed_JournalField;

		private bool reversed_JournalFieldSpecified;

		private bool recurring_JournalField;

		private bool recurring_JournalFieldSpecified;

		private bool intercompany_JournalField;

		private bool intercompany_JournalFieldSpecified;

		private bool threshold_MetField;

		private bool threshold_MetFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Accounting_From_Date
		{
			get
			{
				return this.accounting_From_DateField;
			}
			set
			{
				this.accounting_From_DateField = value;
				this.RaisePropertyChanged("Accounting_From_Date");
			}
		}

		[XmlIgnore]
		public bool Accounting_From_DateSpecified
		{
			get
			{
				return this.accounting_From_DateFieldSpecified;
			}
			set
			{
				this.accounting_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Accounting_To_Date
		{
			get
			{
				return this.accounting_To_DateField;
			}
			set
			{
				this.accounting_To_DateField = value;
				this.RaisePropertyChanged("Accounting_To_Date");
			}
		}

		[XmlIgnore]
		public bool Accounting_To_DateSpecified
		{
			get
			{
				return this.accounting_To_DateFieldSpecified;
			}
			set
			{
				this.accounting_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_To_DateSpecified");
			}
		}

		[XmlElement("Journal_Source_Reference", Order = 3)]
		public Journal_SourceObjectType[] Journal_Source_Reference
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

		[XmlElement(Order = 4)]
		public DateTime Updated_From_Date
		{
			get
			{
				return this.updated_From_DateField;
			}
			set
			{
				this.updated_From_DateField = value;
				this.RaisePropertyChanged("Updated_From_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_From_DateSpecified
		{
			get
			{
				return this.updated_From_DateFieldSpecified;
			}
			set
			{
				this.updated_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_From_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public DateTime Updated_To_Date
		{
			get
			{
				return this.updated_To_DateField;
			}
			set
			{
				this.updated_To_DateField = value;
				this.RaisePropertyChanged("Updated_To_Date");
			}
		}

		[XmlIgnore]
		public bool Updated_To_DateSpecified
		{
			get
			{
				return this.updated_To_DateFieldSpecified;
			}
			set
			{
				this.updated_To_DateFieldSpecified = value;
				this.RaisePropertyChanged("Updated_To_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("Status_Reference", Order = 7)]
		public Journal_Entry_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement("Originated_by_Person_Reference", Order = 8)]
		public Unique_IdentifierObjectType[] Originated_by_Person_Reference
		{
			get
			{
				return this.originated_by_Person_ReferenceField;
			}
			set
			{
				this.originated_by_Person_ReferenceField = value;
				this.RaisePropertyChanged("Originated_by_Person_Reference");
			}
		}

		[XmlElement("Approved_by_Person_Reference", Order = 9)]
		public Unique_IdentifierObjectType[] Approved_by_Person_Reference
		{
			get
			{
				return this.approved_by_Person_ReferenceField;
			}
			set
			{
				this.approved_by_Person_ReferenceField = value;
				this.RaisePropertyChanged("Approved_by_Person_Reference");
			}
		}

		[XmlElement("Ledger_Account_Reference", Order = 10)]
		public Ledger_AccountObjectType[] Ledger_Account_Reference
		{
			get
			{
				return this.ledger_Account_ReferenceField;
			}
			set
			{
				this.ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Ledger_Account_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 11)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public BookObjectType Book_Reference
		{
			get
			{
				return this.book_ReferenceField;
			}
			set
			{
				this.book_ReferenceField = value;
				this.RaisePropertyChanged("Book_Reference");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Reversed_Journal
		{
			get
			{
				return this.reversed_JournalField;
			}
			set
			{
				this.reversed_JournalField = value;
				this.RaisePropertyChanged("Reversed_Journal");
			}
		}

		[XmlIgnore]
		public bool Reversed_JournalSpecified
		{
			get
			{
				return this.reversed_JournalFieldSpecified;
			}
			set
			{
				this.reversed_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Reversed_JournalSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Recurring_Journal
		{
			get
			{
				return this.recurring_JournalField;
			}
			set
			{
				this.recurring_JournalField = value;
				this.RaisePropertyChanged("Recurring_Journal");
			}
		}

		[XmlIgnore]
		public bool Recurring_JournalSpecified
		{
			get
			{
				return this.recurring_JournalFieldSpecified;
			}
			set
			{
				this.recurring_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Recurring_JournalSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Intercompany_Journal
		{
			get
			{
				return this.intercompany_JournalField;
			}
			set
			{
				this.intercompany_JournalField = value;
				this.RaisePropertyChanged("Intercompany_Journal");
			}
		}

		[XmlIgnore]
		public bool Intercompany_JournalSpecified
		{
			get
			{
				return this.intercompany_JournalFieldSpecified;
			}
			set
			{
				this.intercompany_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_JournalSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Threshold_Met
		{
			get
			{
				return this.threshold_MetField;
			}
			set
			{
				this.threshold_MetField = value;
				this.RaisePropertyChanged("Threshold_Met");
			}
		}

		[XmlIgnore]
		public bool Threshold_MetSpecified
		{
			get
			{
				return this.threshold_MetFieldSpecified;
			}
			set
			{
				this.threshold_MetFieldSpecified = value;
				this.RaisePropertyChanged("Threshold_MetSpecified");
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
