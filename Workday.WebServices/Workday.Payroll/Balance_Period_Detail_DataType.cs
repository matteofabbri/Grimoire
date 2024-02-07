using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Balance_Period_Detail_DataType : INotifyPropertyChanged
	{
		private Payroll_Worktag_DataType[] worktag_ReferenceField;

		private decimal balance_AmountField;

		private bool balance_AmountFieldSpecified;

		private Currency_Reference_DataType currency_ReferenceField;

		private Payroll_ID_Balance_DataType[] payroll_ID_Balance_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Worktag_Reference", Order = 0)]
		public Payroll_Worktag_DataType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Balance_Amount
		{
			get
			{
				return this.balance_AmountField;
			}
			set
			{
				this.balance_AmountField = value;
				this.RaisePropertyChanged("Balance_Amount");
			}
		}

		[XmlIgnore]
		public bool Balance_AmountSpecified
		{
			get
			{
				return this.balance_AmountFieldSpecified;
			}
			set
			{
				this.balance_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Balance_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Currency_Reference_DataType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement("Payroll_ID_Balance_Data", Order = 3)]
		public Payroll_ID_Balance_DataType[] Payroll_ID_Balance_Data
		{
			get
			{
				return this.payroll_ID_Balance_DataField;
			}
			set
			{
				this.payroll_ID_Balance_DataField = value;
				this.RaisePropertyChanged("Payroll_ID_Balance_Data");
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
