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
	public class Suspense_Account_Rule_DataType : INotifyPropertyChanged
	{
		private string suspense_Account_Rule_IDField;

		private string suspense_Account_Rule_NameField;

		private Account_SetObjectType account_Set_ReferenceField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] required_Worktags_ReferenceField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] optional_Balancing_Worktags_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Suspense_Account_Rule_ID
		{
			get
			{
				return this.suspense_Account_Rule_IDField;
			}
			set
			{
				this.suspense_Account_Rule_IDField = value;
				this.RaisePropertyChanged("Suspense_Account_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Suspense_Account_Rule_Name
		{
			get
			{
				return this.suspense_Account_Rule_NameField;
			}
			set
			{
				this.suspense_Account_Rule_NameField = value;
				this.RaisePropertyChanged("Suspense_Account_Rule_Name");
			}
		}

		[XmlElement(Order = 2)]
		public Account_SetObjectType Account_Set_Reference
		{
			get
			{
				return this.account_Set_ReferenceField;
			}
			set
			{
				this.account_Set_ReferenceField = value;
				this.RaisePropertyChanged("Account_Set_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Ledger_AccountObjectType Ledger_Account_Reference
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

		[XmlElement("Required_Worktags_Reference", Order = 4)]
		public Audited_Accounting_WorktagObjectType[] Required_Worktags_Reference
		{
			get
			{
				return this.required_Worktags_ReferenceField;
			}
			set
			{
				this.required_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Required_Worktags_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("Optional_Balancing_Worktags_Reference", Order = 6)]
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
