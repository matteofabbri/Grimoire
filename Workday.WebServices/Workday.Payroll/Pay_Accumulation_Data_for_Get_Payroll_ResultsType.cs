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
	public class Pay_Accumulation_Data_for_Get_Payroll_ResultsType : INotifyPropertyChanged
	{
		private Payroll_CalculationObjectType[] pay_Accumulation_ReferenceField;

		private decimal amountField;

		private bool amountFieldSpecified;

		private decimal qTD_AmountField;

		private bool qTD_AmountFieldSpecified;

		private decimal yTD_AmountField;

		private bool yTD_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Pay_Accumulation_Reference", Order = 0)]
		public Payroll_CalculationObjectType[] Pay_Accumulation_Reference
		{
			get
			{
				return this.pay_Accumulation_ReferenceField;
			}
			set
			{
				this.pay_Accumulation_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Accumulation_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal QTD_Amount
		{
			get
			{
				return this.qTD_AmountField;
			}
			set
			{
				this.qTD_AmountField = value;
				this.RaisePropertyChanged("QTD_Amount");
			}
		}

		[XmlIgnore]
		public bool QTD_AmountSpecified
		{
			get
			{
				return this.qTD_AmountFieldSpecified;
			}
			set
			{
				this.qTD_AmountFieldSpecified = value;
				this.RaisePropertyChanged("QTD_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal YTD_Amount
		{
			get
			{
				return this.yTD_AmountField;
			}
			set
			{
				this.yTD_AmountField = value;
				this.RaisePropertyChanged("YTD_Amount");
			}
		}

		[XmlIgnore]
		public bool YTD_AmountSpecified
		{
			get
			{
				return this.yTD_AmountFieldSpecified;
			}
			set
			{
				this.yTD_AmountFieldSpecified = value;
				this.RaisePropertyChanged("YTD_AmountSpecified");
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
