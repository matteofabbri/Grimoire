using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Bank_Statement_Balance_Type_DataType : INotifyPropertyChanged
	{
		private Bank_Statement_Balance_TypeObjectType bank_Statement_Balance_Type_ReferenceField;

		private string summary_BalanceField;

		private string type_CodeField;

		private string debit_CreditField;

		private string descriptionField;

		private Bank_Statement_Type_CategoryObjectType bank_Statement_Type_Category_ReferenceField;

		private string beginning_BalanceField;

		private string ending_BalanceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Statement_Balance_TypeObjectType Bank_Statement_Balance_Type_Reference
		{
			get
			{
				return this.bank_Statement_Balance_Type_ReferenceField;
			}
			set
			{
				this.bank_Statement_Balance_Type_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Balance_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Summary_Balance
		{
			get
			{
				return this.summary_BalanceField;
			}
			set
			{
				this.summary_BalanceField = value;
				this.RaisePropertyChanged("Summary_Balance");
			}
		}

		[XmlElement(Order = 2)]
		public string Type_Code
		{
			get
			{
				return this.type_CodeField;
			}
			set
			{
				this.type_CodeField = value;
				this.RaisePropertyChanged("Type_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Debit_Credit
		{
			get
			{
				return this.debit_CreditField;
			}
			set
			{
				this.debit_CreditField = value;
				this.RaisePropertyChanged("Debit_Credit");
			}
		}

		[XmlElement(Order = 4)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 5)]
		public Bank_Statement_Type_CategoryObjectType Bank_Statement_Type_Category_Reference
		{
			get
			{
				return this.bank_Statement_Type_Category_ReferenceField;
			}
			set
			{
				this.bank_Statement_Type_Category_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Type_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Beginning_Balance
		{
			get
			{
				return this.beginning_BalanceField;
			}
			set
			{
				this.beginning_BalanceField = value;
				this.RaisePropertyChanged("Beginning_Balance");
			}
		}

		[XmlElement(Order = 7)]
		public string Ending_Balance
		{
			get
			{
				return this.ending_BalanceField;
			}
			set
			{
				this.ending_BalanceField = value;
				this.RaisePropertyChanged("Ending_Balance");
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
