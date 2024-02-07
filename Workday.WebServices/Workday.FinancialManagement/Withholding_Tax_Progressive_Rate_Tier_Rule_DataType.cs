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
	public class Withholding_Tax_Progressive_Rate_Tier_Rule_DataType : INotifyPropertyChanged
	{
		private decimal minimum_Threshold_AmountField;

		private bool minimum_Threshold_AmountFieldSpecified;

		private decimal maximum_Threshold_AmountField;

		private bool maximum_Threshold_AmountFieldSpecified;

		private bool max_TierField;

		private bool max_TierFieldSpecified;

		private decimal tax_RateField;

		private bool tax_RateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Minimum_Threshold_Amount
		{
			get
			{
				return this.minimum_Threshold_AmountField;
			}
			set
			{
				this.minimum_Threshold_AmountField = value;
				this.RaisePropertyChanged("Minimum_Threshold_Amount");
			}
		}

		[XmlIgnore]
		public bool Minimum_Threshold_AmountSpecified
		{
			get
			{
				return this.minimum_Threshold_AmountFieldSpecified;
			}
			set
			{
				this.minimum_Threshold_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Threshold_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Maximum_Threshold_Amount
		{
			get
			{
				return this.maximum_Threshold_AmountField;
			}
			set
			{
				this.maximum_Threshold_AmountField = value;
				this.RaisePropertyChanged("Maximum_Threshold_Amount");
			}
		}

		[XmlIgnore]
		public bool Maximum_Threshold_AmountSpecified
		{
			get
			{
				return this.maximum_Threshold_AmountFieldSpecified;
			}
			set
			{
				this.maximum_Threshold_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Threshold_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Max_Tier
		{
			get
			{
				return this.max_TierField;
			}
			set
			{
				this.max_TierField = value;
				this.RaisePropertyChanged("Max_Tier");
			}
		}

		[XmlIgnore]
		public bool Max_TierSpecified
		{
			get
			{
				return this.max_TierFieldSpecified;
			}
			set
			{
				this.max_TierFieldSpecified = value;
				this.RaisePropertyChanged("Max_TierSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Tax_Rate
		{
			get
			{
				return this.tax_RateField;
			}
			set
			{
				this.tax_RateField = value;
				this.RaisePropertyChanged("Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool Tax_RateSpecified
		{
			get
			{
				return this.tax_RateFieldSpecified;
			}
			set
			{
				this.tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("Tax_RateSpecified");
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
