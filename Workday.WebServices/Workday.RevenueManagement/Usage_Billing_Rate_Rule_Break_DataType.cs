using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Usage_Billing_Rate_Rule_Break_DataType : INotifyPropertyChanged
	{
		private Billing_Rate_Rule_BreakObjectType usage_Billing_Rate_Rule_Break_ReferenceField;

		private decimal begin_Break_Range_UnitsField;

		private bool begin_Break_Range_UnitsFieldSpecified;

		private decimal end_Break_Range_UnitsField;

		private bool end_Break_Range_UnitsFieldSpecified;

		private decimal rate_AmountField;

		private bool rate_AmountFieldSpecified;

		private bool max_TierField;

		private bool max_TierFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Billing_Rate_Rule_BreakObjectType Usage_Billing_Rate_Rule_Break_Reference
		{
			get
			{
				return this.usage_Billing_Rate_Rule_Break_ReferenceField;
			}
			set
			{
				this.usage_Billing_Rate_Rule_Break_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Billing_Rate_Rule_Break_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Begin_Break_Range_Units
		{
			get
			{
				return this.begin_Break_Range_UnitsField;
			}
			set
			{
				this.begin_Break_Range_UnitsField = value;
				this.RaisePropertyChanged("Begin_Break_Range_Units");
			}
		}

		[XmlIgnore]
		public bool Begin_Break_Range_UnitsSpecified
		{
			get
			{
				return this.begin_Break_Range_UnitsFieldSpecified;
			}
			set
			{
				this.begin_Break_Range_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Begin_Break_Range_UnitsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal End_Break_Range_Units
		{
			get
			{
				return this.end_Break_Range_UnitsField;
			}
			set
			{
				this.end_Break_Range_UnitsField = value;
				this.RaisePropertyChanged("End_Break_Range_Units");
			}
		}

		[XmlIgnore]
		public bool End_Break_Range_UnitsSpecified
		{
			get
			{
				return this.end_Break_Range_UnitsFieldSpecified;
			}
			set
			{
				this.end_Break_Range_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("End_Break_Range_UnitsSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Rate_Amount
		{
			get
			{
				return this.rate_AmountField;
			}
			set
			{
				this.rate_AmountField = value;
				this.RaisePropertyChanged("Rate_Amount");
			}
		}

		[XmlIgnore]
		public bool Rate_AmountSpecified
		{
			get
			{
				return this.rate_AmountFieldSpecified;
			}
			set
			{
				this.rate_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Rate_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
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
