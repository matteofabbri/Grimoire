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
	public class Journal_Source_DataType : INotifyPropertyChanged
	{
		private string journal_Source_IDField;

		private string journal_Source_NameField;

		private bool source_For_Accounting_JournalField;

		private bool source_For_Accounting_JournalFieldSpecified;

		private bool process_Award_CostsField;

		private bool process_Award_CostsFieldSpecified;

		private bool source_For_Ad_Hoc_Bank_TransactionField;

		private bool source_For_Ad_Hoc_Bank_TransactionFieldSpecified;

		private bool enable_Suspense_Processing_for_Web_ServiceField;

		private bool enable_Suspense_Processing_for_Web_ServiceFieldSpecified;

		private decimal suspense_Threshold_PercentField;

		private bool suspense_Threshold_PercentFieldSpecified;

		private bool source_For_Workday_Operational_JournalField;

		private bool source_For_Workday_Operational_JournalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Journal_Source_ID
		{
			get
			{
				return this.journal_Source_IDField;
			}
			set
			{
				this.journal_Source_IDField = value;
				this.RaisePropertyChanged("Journal_Source_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Journal_Source_Name
		{
			get
			{
				return this.journal_Source_NameField;
			}
			set
			{
				this.journal_Source_NameField = value;
				this.RaisePropertyChanged("Journal_Source_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Source_For_Accounting_Journal
		{
			get
			{
				return this.source_For_Accounting_JournalField;
			}
			set
			{
				this.source_For_Accounting_JournalField = value;
				this.RaisePropertyChanged("Source_For_Accounting_Journal");
			}
		}

		[XmlIgnore]
		public bool Source_For_Accounting_JournalSpecified
		{
			get
			{
				return this.source_For_Accounting_JournalFieldSpecified;
			}
			set
			{
				this.source_For_Accounting_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Source_For_Accounting_JournalSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Process_Award_Costs
		{
			get
			{
				return this.process_Award_CostsField;
			}
			set
			{
				this.process_Award_CostsField = value;
				this.RaisePropertyChanged("Process_Award_Costs");
			}
		}

		[XmlIgnore]
		public bool Process_Award_CostsSpecified
		{
			get
			{
				return this.process_Award_CostsFieldSpecified;
			}
			set
			{
				this.process_Award_CostsFieldSpecified = value;
				this.RaisePropertyChanged("Process_Award_CostsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Source_For_Ad_Hoc_Bank_Transaction
		{
			get
			{
				return this.source_For_Ad_Hoc_Bank_TransactionField;
			}
			set
			{
				this.source_For_Ad_Hoc_Bank_TransactionField = value;
				this.RaisePropertyChanged("Source_For_Ad_Hoc_Bank_Transaction");
			}
		}

		[XmlIgnore]
		public bool Source_For_Ad_Hoc_Bank_TransactionSpecified
		{
			get
			{
				return this.source_For_Ad_Hoc_Bank_TransactionFieldSpecified;
			}
			set
			{
				this.source_For_Ad_Hoc_Bank_TransactionFieldSpecified = value;
				this.RaisePropertyChanged("Source_For_Ad_Hoc_Bank_TransactionSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Enable_Suspense_Processing_for_Web_Service
		{
			get
			{
				return this.enable_Suspense_Processing_for_Web_ServiceField;
			}
			set
			{
				this.enable_Suspense_Processing_for_Web_ServiceField = value;
				this.RaisePropertyChanged("Enable_Suspense_Processing_for_Web_Service");
			}
		}

		[XmlIgnore]
		public bool Enable_Suspense_Processing_for_Web_ServiceSpecified
		{
			get
			{
				return this.enable_Suspense_Processing_for_Web_ServiceFieldSpecified;
			}
			set
			{
				this.enable_Suspense_Processing_for_Web_ServiceFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Suspense_Processing_for_Web_ServiceSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Suspense_Threshold_Percent
		{
			get
			{
				return this.suspense_Threshold_PercentField;
			}
			set
			{
				this.suspense_Threshold_PercentField = value;
				this.RaisePropertyChanged("Suspense_Threshold_Percent");
			}
		}

		[XmlIgnore]
		public bool Suspense_Threshold_PercentSpecified
		{
			get
			{
				return this.suspense_Threshold_PercentFieldSpecified;
			}
			set
			{
				this.suspense_Threshold_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Suspense_Threshold_PercentSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Source_For_Workday_Operational_Journal
		{
			get
			{
				return this.source_For_Workday_Operational_JournalField;
			}
			set
			{
				this.source_For_Workday_Operational_JournalField = value;
				this.RaisePropertyChanged("Source_For_Workday_Operational_Journal");
			}
		}

		[XmlIgnore]
		public bool Source_For_Workday_Operational_JournalSpecified
		{
			get
			{
				return this.source_For_Workday_Operational_JournalFieldSpecified;
			}
			set
			{
				this.source_For_Workday_Operational_JournalFieldSpecified = value;
				this.RaisePropertyChanged("Source_For_Workday_Operational_JournalSpecified");
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
