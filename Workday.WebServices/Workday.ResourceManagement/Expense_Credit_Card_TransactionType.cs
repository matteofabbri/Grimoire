using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Expense_Credit_Card_TransactionType : INotifyPropertyChanged
	{
		private Credit_Card_TransactionObjectType expense_Credit_Card_Transaction_ReferenceField;

		private Credit_Card_Transaction_DataType expense_Credit_Card_Transaction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Credit_Card_TransactionObjectType Expense_Credit_Card_Transaction_Reference
		{
			get
			{
				return this.expense_Credit_Card_Transaction_ReferenceField;
			}
			set
			{
				this.expense_Credit_Card_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Transaction_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Credit_Card_Transaction_DataType Expense_Credit_Card_Transaction_Data
		{
			get
			{
				return this.expense_Credit_Card_Transaction_DataField;
			}
			set
			{
				this.expense_Credit_Card_Transaction_DataField = value;
				this.RaisePropertyChanged("Expense_Credit_Card_Transaction_Data");
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
