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
	public class Credit_Card_Transaction_Billing_Currency_Conversion_DataType : INotifyPropertyChanged
	{
		private decimal currency_Exchange_RateField;

		private bool currency_Exchange_RateFieldSpecified;

		private decimal billing_AmountField;

		private bool billing_AmountFieldSpecified;

		private decimal nonPersonal_Billing_AmountField;

		private bool nonPersonal_Billing_AmountFieldSpecified;

		private CurrencyObjectType billing_Currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Currency_Exchange_Rate
		{
			get
			{
				return this.currency_Exchange_RateField;
			}
			set
			{
				this.currency_Exchange_RateField = value;
				this.RaisePropertyChanged("Currency_Exchange_Rate");
			}
		}

		[XmlIgnore]
		public bool Currency_Exchange_RateSpecified
		{
			get
			{
				return this.currency_Exchange_RateFieldSpecified;
			}
			set
			{
				this.currency_Exchange_RateFieldSpecified = value;
				this.RaisePropertyChanged("Currency_Exchange_RateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Billing_Amount
		{
			get
			{
				return this.billing_AmountField;
			}
			set
			{
				this.billing_AmountField = value;
				this.RaisePropertyChanged("Billing_Amount");
			}
		}

		[XmlIgnore]
		public bool Billing_AmountSpecified
		{
			get
			{
				return this.billing_AmountFieldSpecified;
			}
			set
			{
				this.billing_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Billing_AmountSpecified");
			}
		}

		[XmlElement("Non-Personal_Billing_Amount", Order = 2)]
		public decimal NonPersonal_Billing_Amount
		{
			get
			{
				return this.nonPersonal_Billing_AmountField;
			}
			set
			{
				this.nonPersonal_Billing_AmountField = value;
				this.RaisePropertyChanged("NonPersonal_Billing_Amount");
			}
		}

		[XmlIgnore]
		public bool NonPersonal_Billing_AmountSpecified
		{
			get
			{
				return this.nonPersonal_Billing_AmountFieldSpecified;
			}
			set
			{
				this.nonPersonal_Billing_AmountFieldSpecified = value;
				this.RaisePropertyChanged("NonPersonal_Billing_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public CurrencyObjectType Billing_Currency_Reference
		{
			get
			{
				return this.billing_Currency_ReferenceField;
			}
			set
			{
				this.billing_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Currency_Reference");
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
