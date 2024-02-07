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
	public class Payroll_ID_Balance_DataType : INotifyPropertyChanged
	{
		private Payroll_ID_Data_DisplayType[] payroll_ID_Detail_DataField;

		private decimal balance_AmountField;

		private bool balance_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payroll_ID_Detail_Data", Order = 0)]
		public Payroll_ID_Data_DisplayType[] Payroll_ID_Detail_Data
		{
			get
			{
				return this.payroll_ID_Detail_DataField;
			}
			set
			{
				this.payroll_ID_Detail_DataField = value;
				this.RaisePropertyChanged("Payroll_ID_Detail_Data");
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
