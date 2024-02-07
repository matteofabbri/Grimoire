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
	public class Account_Set_Mapping_Rule_DataType : INotifyPropertyChanged
	{
		private Ledger_AccountObjectType input_Ledger_Account_ReferenceField;

		private Ledger_AccountObjectType default_Ledger_Account_ReferenceField;

		private Account_Set_Mapping_Rule_Condition_DataType[] account_Set_Mapping_Rule_Condition_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Ledger_AccountObjectType Input_Ledger_Account_Reference
		{
			get
			{
				return this.input_Ledger_Account_ReferenceField;
			}
			set
			{
				this.input_Ledger_Account_ReferenceField = value;
				this.RaisePropertyChanged("Input_Ledger_Account_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Account_Set_Mapping_Rule_Condition_Data", Order = 2)]
		public Account_Set_Mapping_Rule_Condition_DataType[] Account_Set_Mapping_Rule_Condition_Data
		{
			get
			{
				return this.account_Set_Mapping_Rule_Condition_DataField;
			}
			set
			{
				this.account_Set_Mapping_Rule_Condition_DataField = value;
				this.RaisePropertyChanged("Account_Set_Mapping_Rule_Condition_Data");
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
