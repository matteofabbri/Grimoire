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
	public class Bank_Statement_Transaction_Type_DataType : INotifyPropertyChanged
	{
		private Bank_Statement_Transaction_TypeObjectType bank_Statement_Transaction_Type_ReferenceField;

		private string type_CodeField;

		private string debit_CreditField;

		private string descriptionField;

		private Bank_Statement_Type_CategoryObjectType bank_Statement_Type_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bank_Statement_Transaction_TypeObjectType Bank_Statement_Transaction_Type_Reference
		{
			get
			{
				return this.bank_Statement_Transaction_Type_ReferenceField;
			}
			set
			{
				this.bank_Statement_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Bank_Statement_Transaction_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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
