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
	public class Expense_Report_Credit_Card_Transactions_DataType : INotifyPropertyChanged
	{
		private Expense_ReportObjectType expense_Report_ReferenceField;

		private string expense_Report_NumberField;

		private Expense_PayeeObjectType expense_Payee_ReferenceField;

		private Expense_Report_Line_Credit_Card_Transaction_DataType[] expense_Report_Line_Credit_Card_Transaction_DataField;

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
		public string Expense_Report_Number
		{
			get
			{
				return this.expense_Report_NumberField;
			}
			set
			{
				this.expense_Report_NumberField = value;
				this.RaisePropertyChanged("Expense_Report_Number");
			}
		}

		[XmlElement(Order = 2)]
		public Expense_PayeeObjectType Expense_Payee_Reference
		{
			get
			{
				return this.expense_Payee_ReferenceField;
			}
			set
			{
				this.expense_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Expense_Payee_Reference");
			}
		}

		[XmlElement("Expense_Report_Line_Credit_Card_Transaction_Data", Order = 3)]
		public Expense_Report_Line_Credit_Card_Transaction_DataType[] Expense_Report_Line_Credit_Card_Transaction_Data
		{
			get
			{
				return this.expense_Report_Line_Credit_Card_Transaction_DataField;
			}
			set
			{
				this.expense_Report_Line_Credit_Card_Transaction_DataField = value;
				this.RaisePropertyChanged("Expense_Report_Line_Credit_Card_Transaction_Data");
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
