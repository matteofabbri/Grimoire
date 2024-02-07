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
	public class Expense_Report_WWSType : INotifyPropertyChanged
	{
		private Expense_ReportObjectType expense_Report_ReferenceField;

		private Expense_Report_WWS_Outbound_DataType expense_Report_DataField;

		private Expense_Report_Credit_Card_Transactions_DataType expense_Report_Credit_Card_Transactions_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Expense_ReportObjectType Expense_Report_Reference
		{
			get
			{
				return this.expense_Report_ReferenceField;
			}
			set
			{
				this.expense_Report_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Report_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Expense_Report_WWS_Outbound_DataType Expense_Report_Data
		{
			get
			{
				return this.expense_Report_DataField;
			}
			set
			{
				this.expense_Report_DataField = value;
				this.RaisePropertyChanged("Expense_Report_Data");
			}
		}

		[XmlElement(Order = 2)]
		public Expense_Report_Credit_Card_Transactions_DataType Expense_Report_Credit_Card_Transactions_Data
		{
			get
			{
				return this.expense_Report_Credit_Card_Transactions_DataField;
			}
			set
			{
				this.expense_Report_Credit_Card_Transactions_DataField = value;
				this.RaisePropertyChanged("Expense_Report_Credit_Card_Transactions_Data");
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
