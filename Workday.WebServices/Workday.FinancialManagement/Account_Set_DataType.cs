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
	public class Account_Set_DataType : INotifyPropertyChanged
	{
		private string account_Set_IDField;

		private string account_Set_NameField;

		private bool chart_of_AccountsField;

		private bool chart_of_AccountsFieldSpecified;

		private Account_SetObjectType[] account_Set_ReferenceField;

		private Ledger_Account_DataType[] ledger_Account_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Account_Set_ID
		{
			get
			{
				return this.account_Set_IDField;
			}
			set
			{
				this.account_Set_IDField = value;
				this.RaisePropertyChanged("Account_Set_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Account_Set_Name
		{
			get
			{
				return this.account_Set_NameField;
			}
			set
			{
				this.account_Set_NameField = value;
				this.RaisePropertyChanged("Account_Set_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Chart_of_Accounts
		{
			get
			{
				return this.chart_of_AccountsField;
			}
			set
			{
				this.chart_of_AccountsField = value;
				this.RaisePropertyChanged("Chart_of_Accounts");
			}
		}

		[XmlIgnore]
		public bool Chart_of_AccountsSpecified
		{
			get
			{
				return this.chart_of_AccountsFieldSpecified;
			}
			set
			{
				this.chart_of_AccountsFieldSpecified = value;
				this.RaisePropertyChanged("Chart_of_AccountsSpecified");
			}
		}

		[XmlElement("Account_Set_Reference", Order = 3)]
		public Account_SetObjectType[] Account_Set_Reference
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

		[XmlElement("Ledger_Account_Data", Order = 4)]
		public Ledger_Account_DataType[] Ledger_Account_Data
		{
			get
			{
				return this.ledger_Account_DataField;
			}
			set
			{
				this.ledger_Account_DataField = value;
				this.RaisePropertyChanged("Ledger_Account_Data");
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
