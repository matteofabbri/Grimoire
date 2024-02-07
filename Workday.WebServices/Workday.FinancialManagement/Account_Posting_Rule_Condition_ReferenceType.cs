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
	public class Account_Posting_Rule_Condition_ReferenceType : INotifyPropertyChanged
	{
		private string orderField;

		private Account_Posting_Rule_Condition_Value_Group_ReferenceType[] posting_Rule_Condition_Value_Group_Reference_DataField;

		private Ledger_AccountObjectType ledger_Account_ReferenceField;

		private Accounting_WorktagObjectType[] resulting_Worktag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement("Posting_Rule_Condition_Value_Group_Reference_Data", Order = 1)]
		public Account_Posting_Rule_Condition_Value_Group_ReferenceType[] Posting_Rule_Condition_Value_Group_Reference_Data
		{
			get
			{
				return this.posting_Rule_Condition_Value_Group_Reference_DataField;
			}
			set
			{
				this.posting_Rule_Condition_Value_Group_Reference_DataField = value;
				this.RaisePropertyChanged("Posting_Rule_Condition_Value_Group_Reference_Data");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Resulting_Worktag_Reference", Order = 3)]
		public Accounting_WorktagObjectType[] Resulting_Worktag_Reference
		{
			get
			{
				return this.resulting_Worktag_ReferenceField;
			}
			set
			{
				this.resulting_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Resulting_Worktag_Reference");
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
