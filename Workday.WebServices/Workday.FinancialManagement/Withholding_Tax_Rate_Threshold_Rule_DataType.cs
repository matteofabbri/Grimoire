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
	public class Withholding_Tax_Rate_Threshold_Rule_DataType : INotifyPropertyChanged
	{
		private decimal transaction_Threshold_AmountField;

		private bool transaction_Threshold_AmountFieldSpecified;

		private Logical_OperatorObjectType threshold_Combination_ReferenceField;

		private decimal rate_Threshold_AmountField;

		private bool rate_Threshold_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Transaction_Threshold_Amount
		{
			get
			{
				return this.transaction_Threshold_AmountField;
			}
			set
			{
				this.transaction_Threshold_AmountField = value;
				this.RaisePropertyChanged("Transaction_Threshold_Amount");
			}
		}

		[XmlIgnore]
		public bool Transaction_Threshold_AmountSpecified
		{
			get
			{
				return this.transaction_Threshold_AmountFieldSpecified;
			}
			set
			{
				this.transaction_Threshold_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Threshold_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Logical_OperatorObjectType Threshold_Combination_Reference
		{
			get
			{
				return this.threshold_Combination_ReferenceField;
			}
			set
			{
				this.threshold_Combination_ReferenceField = value;
				this.RaisePropertyChanged("Threshold_Combination_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Rate_Threshold_Amount
		{
			get
			{
				return this.rate_Threshold_AmountField;
			}
			set
			{
				this.rate_Threshold_AmountField = value;
				this.RaisePropertyChanged("Rate_Threshold_Amount");
			}
		}

		[XmlIgnore]
		public bool Rate_Threshold_AmountSpecified
		{
			get
			{
				return this.rate_Threshold_AmountFieldSpecified;
			}
			set
			{
				this.rate_Threshold_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Rate_Threshold_AmountSpecified");
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
