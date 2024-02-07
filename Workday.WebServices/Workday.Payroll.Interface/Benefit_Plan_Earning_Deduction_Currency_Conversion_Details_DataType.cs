using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Plan_Earning_Deduction_Currency_Conversion_Details_DataType : INotifyPropertyChanged
	{
		private decimal eE_Cost_Pre_TaxField;

		private bool eE_Cost_Pre_TaxFieldSpecified;

		private decimal eE_Cost_Post_TaxField;

		private bool eE_Cost_Post_TaxFieldSpecified;

		private decimal eR_Cost_Non_TaxableField;

		private bool eR_Cost_Non_TaxableFieldSpecified;

		private decimal eR_Cost_TaxableField;

		private bool eR_Cost_TaxableFieldSpecified;

		private decimal coverage_AmountField;

		private bool coverage_AmountFieldSpecified;

		private decimal dependent_Fair_Market_ValueField;

		private bool dependent_Fair_Market_ValueFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal EE_Cost_Pre_Tax
		{
			get
			{
				return this.eE_Cost_Pre_TaxField;
			}
			set
			{
				this.eE_Cost_Pre_TaxField = value;
				this.RaisePropertyChanged("EE_Cost_Pre_Tax");
			}
		}

		[XmlIgnore]
		public bool EE_Cost_Pre_TaxSpecified
		{
			get
			{
				return this.eE_Cost_Pre_TaxFieldSpecified;
			}
			set
			{
				this.eE_Cost_Pre_TaxFieldSpecified = value;
				this.RaisePropertyChanged("EE_Cost_Pre_TaxSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal EE_Cost_Post_Tax
		{
			get
			{
				return this.eE_Cost_Post_TaxField;
			}
			set
			{
				this.eE_Cost_Post_TaxField = value;
				this.RaisePropertyChanged("EE_Cost_Post_Tax");
			}
		}

		[XmlIgnore]
		public bool EE_Cost_Post_TaxSpecified
		{
			get
			{
				return this.eE_Cost_Post_TaxFieldSpecified;
			}
			set
			{
				this.eE_Cost_Post_TaxFieldSpecified = value;
				this.RaisePropertyChanged("EE_Cost_Post_TaxSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal ER_Cost_Non_Taxable
		{
			get
			{
				return this.eR_Cost_Non_TaxableField;
			}
			set
			{
				this.eR_Cost_Non_TaxableField = value;
				this.RaisePropertyChanged("ER_Cost_Non_Taxable");
			}
		}

		[XmlIgnore]
		public bool ER_Cost_Non_TaxableSpecified
		{
			get
			{
				return this.eR_Cost_Non_TaxableFieldSpecified;
			}
			set
			{
				this.eR_Cost_Non_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("ER_Cost_Non_TaxableSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal ER_Cost_Taxable
		{
			get
			{
				return this.eR_Cost_TaxableField;
			}
			set
			{
				this.eR_Cost_TaxableField = value;
				this.RaisePropertyChanged("ER_Cost_Taxable");
			}
		}

		[XmlIgnore]
		public bool ER_Cost_TaxableSpecified
		{
			get
			{
				return this.eR_Cost_TaxableFieldSpecified;
			}
			set
			{
				this.eR_Cost_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("ER_Cost_TaxableSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Coverage_Amount
		{
			get
			{
				return this.coverage_AmountField;
			}
			set
			{
				this.coverage_AmountField = value;
				this.RaisePropertyChanged("Coverage_Amount");
			}
		}

		[XmlIgnore]
		public bool Coverage_AmountSpecified
		{
			get
			{
				return this.coverage_AmountFieldSpecified;
			}
			set
			{
				this.coverage_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Dependent_Fair_Market_Value
		{
			get
			{
				return this.dependent_Fair_Market_ValueField;
			}
			set
			{
				this.dependent_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Dependent_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Dependent_Fair_Market_ValueSpecified
		{
			get
			{
				return this.dependent_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.dependent_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Dependent_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public CurrencyObjectType Currency_Reference
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

		[XmlElement(Order = 7)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
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
