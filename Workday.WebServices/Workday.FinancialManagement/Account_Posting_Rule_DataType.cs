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
	public class Account_Posting_Rule_DataType : INotifyPropertyChanged
	{
		private Account_Posting_Rule_TypeObjectType posting_Rule_Type_ReferenceField;

		private bool enable_Control_Account_WarningField;

		private bool enable_Control_Account_WarningFieldSpecified;

		private Ledger_AccountObjectType default_Ledger_Account_ReferenceField;

		private Accounting_WorktagObjectType[] default_Resulting_Worktag_ReferenceField;

		private Account_Posting_Rule_Condition_ReferenceType[] posting_Rule_Condition_Reference_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Account_Posting_Rule_TypeObjectType Posting_Rule_Type_Reference
		{
			get
			{
				return this.posting_Rule_Type_ReferenceField;
			}
			set
			{
				this.posting_Rule_Type_ReferenceField = value;
				this.RaisePropertyChanged("Posting_Rule_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Enable_Control_Account_Warning
		{
			get
			{
				return this.enable_Control_Account_WarningField;
			}
			set
			{
				this.enable_Control_Account_WarningField = value;
				this.RaisePropertyChanged("Enable_Control_Account_Warning");
			}
		}

		[XmlIgnore]
		public bool Enable_Control_Account_WarningSpecified
		{
			get
			{
				return this.enable_Control_Account_WarningFieldSpecified;
			}
			set
			{
				this.enable_Control_Account_WarningFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Control_Account_WarningSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Ledger_AccountObjectType Default_Ledger_Account_Reference
		{
			get
			{
				return this.default_Ledger_Account_ReferenceField;
			}
			set
			{
				this.default_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Default_Ledger_Account_Reference");
			}
		}

		[XmlElement("Default_Resulting_Worktag_Reference", Order = 3)]
		public Accounting_WorktagObjectType[] Default_Resulting_Worktag_Reference
		{
			get
			{
				return this.default_Resulting_Worktag_ReferenceField;
			}
			set
			{
				this.default_Resulting_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Default_Resulting_Worktag_Reference");
			}
		}

		[XmlElement("Posting_Rule_Condition_Reference_Data", Order = 4)]
		public Account_Posting_Rule_Condition_ReferenceType[] Posting_Rule_Condition_Reference_Data
		{
			get
			{
				return this.posting_Rule_Condition_Reference_DataField;
			}
			set
			{
				this.posting_Rule_Condition_Reference_DataField = value;
				this.RaisePropertyChanged("Posting_Rule_Condition_Reference_Data");
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
