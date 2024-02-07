using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benefit_Rate_Value_Percent_of_Salary_DataType : INotifyPropertyChanged
	{
		private decimal employee_Cost_PercentageField;

		private bool employee_Cost_PercentageFieldSpecified;

		private decimal employee_Cost_Amount_MinField;

		private bool employee_Cost_Amount_MinFieldSpecified;

		private decimal employee_Cost_Amount_MaxField;

		private bool employee_Cost_Amount_MaxFieldSpecified;

		private decimal employee_Cost_Percentage_PostTaxField;

		private bool employee_Cost_Percentage_PostTaxFieldSpecified;

		private decimal employee_Cost_Amount_Min_PostTaxField;

		private bool employee_Cost_Amount_Min_PostTaxFieldSpecified;

		private decimal employee_Cost_Amount_Max_PostTaxField;

		private bool employee_Cost_Amount_Max_PostTaxFieldSpecified;

		private decimal total_Cost_NonTaxableField;

		private bool total_Cost_NonTaxableFieldSpecified;

		private decimal total_Cost_TaxableField;

		private bool total_Cost_TaxableFieldSpecified;

		private decimal flex_Credit_AmountField;

		private bool flex_Credit_AmountFieldSpecified;

		private decimal fair_Market_Value_per_DependentField;

		private bool fair_Market_Value_per_DependentFieldSpecified;

		private Flat_Amount_DataType[] flat_Amount_DataField;

		private Benefits_Calculable_CreditObjectType[] benefit_Credit_ReferenceField;

		private Benefits_Calculable_CreditObjectType[] benefit_Surcharge_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Employee_Cost_Percentage
		{
			get
			{
				return this.employee_Cost_PercentageField;
			}
			set
			{
				this.employee_Cost_PercentageField = value;
				this.RaisePropertyChanged("Employee_Cost_Percentage");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_PercentageSpecified
		{
			get
			{
				return this.employee_Cost_PercentageFieldSpecified;
			}
			set
			{
				this.employee_Cost_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_PercentageSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Employee_Cost_Amount_Min
		{
			get
			{
				return this.employee_Cost_Amount_MinField;
			}
			set
			{
				this.employee_Cost_Amount_MinField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Min");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Amount_MinSpecified
		{
			get
			{
				return this.employee_Cost_Amount_MinFieldSpecified;
			}
			set
			{
				this.employee_Cost_Amount_MinFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_MinSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Employee_Cost_Amount_Max
		{
			get
			{
				return this.employee_Cost_Amount_MaxField;
			}
			set
			{
				this.employee_Cost_Amount_MaxField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Max");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Amount_MaxSpecified
		{
			get
			{
				return this.employee_Cost_Amount_MaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_Amount_MaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_MaxSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Employee_Cost_Percentage_PostTax
		{
			get
			{
				return this.employee_Cost_Percentage_PostTaxField;
			}
			set
			{
				this.employee_Cost_Percentage_PostTaxField = value;
				this.RaisePropertyChanged("Employee_Cost_Percentage_PostTax");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Percentage_PostTaxSpecified
		{
			get
			{
				return this.employee_Cost_Percentage_PostTaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_Percentage_PostTaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Percentage_PostTaxSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Employee_Cost_Amount_Min_PostTax
		{
			get
			{
				return this.employee_Cost_Amount_Min_PostTaxField;
			}
			set
			{
				this.employee_Cost_Amount_Min_PostTaxField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Min_PostTax");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Amount_Min_PostTaxSpecified
		{
			get
			{
				return this.employee_Cost_Amount_Min_PostTaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_Amount_Min_PostTaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Min_PostTaxSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Employee_Cost_Amount_Max_PostTax
		{
			get
			{
				return this.employee_Cost_Amount_Max_PostTaxField;
			}
			set
			{
				this.employee_Cost_Amount_Max_PostTaxField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Max_PostTax");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Amount_Max_PostTaxSpecified
		{
			get
			{
				return this.employee_Cost_Amount_Max_PostTaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_Amount_Max_PostTaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_Max_PostTaxSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Total_Cost_NonTaxable
		{
			get
			{
				return this.total_Cost_NonTaxableField;
			}
			set
			{
				this.total_Cost_NonTaxableField = value;
				this.RaisePropertyChanged("Total_Cost_NonTaxable");
			}
		}

		[XmlIgnore]
		public bool Total_Cost_NonTaxableSpecified
		{
			get
			{
				return this.total_Cost_NonTaxableFieldSpecified;
			}
			set
			{
				this.total_Cost_NonTaxableFieldSpecified = value;
				this.RaisePropertyChanged("Total_Cost_NonTaxableSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Total_Cost_Taxable
		{
			get
			{
				return this.total_Cost_TaxableField;
			}
			set
			{
				this.total_Cost_TaxableField = value;
				this.RaisePropertyChanged("Total_Cost_Taxable");
			}
		}

		[XmlIgnore]
		public bool Total_Cost_TaxableSpecified
		{
			get
			{
				return this.total_Cost_TaxableFieldSpecified;
			}
			set
			{
				this.total_Cost_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("Total_Cost_TaxableSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Flex_Credit_Amount
		{
			get
			{
				return this.flex_Credit_AmountField;
			}
			set
			{
				this.flex_Credit_AmountField = value;
				this.RaisePropertyChanged("Flex_Credit_Amount");
			}
		}

		[XmlIgnore]
		public bool Flex_Credit_AmountSpecified
		{
			get
			{
				return this.flex_Credit_AmountFieldSpecified;
			}
			set
			{
				this.flex_Credit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Flex_Credit_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Fair_Market_Value_per_Dependent
		{
			get
			{
				return this.fair_Market_Value_per_DependentField;
			}
			set
			{
				this.fair_Market_Value_per_DependentField = value;
				this.RaisePropertyChanged("Fair_Market_Value_per_Dependent");
			}
		}

		[XmlIgnore]
		public bool Fair_Market_Value_per_DependentSpecified
		{
			get
			{
				return this.fair_Market_Value_per_DependentFieldSpecified;
			}
			set
			{
				this.fair_Market_Value_per_DependentFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Market_Value_per_DependentSpecified");
			}
		}

		[XmlElement("Flat_Amount_Data", Order = 10)]
		public Flat_Amount_DataType[] Flat_Amount_Data
		{
			get
			{
				return this.flat_Amount_DataField;
			}
			set
			{
				this.flat_Amount_DataField = value;
				this.RaisePropertyChanged("Flat_Amount_Data");
			}
		}

		[XmlElement("Benefit_Credit_Reference", Order = 11)]
		public Benefits_Calculable_CreditObjectType[] Benefit_Credit_Reference
		{
			get
			{
				return this.benefit_Credit_ReferenceField;
			}
			set
			{
				this.benefit_Credit_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Credit_Reference");
			}
		}

		[XmlElement("Benefit_Surcharge_Reference", Order = 12)]
		public Benefits_Calculable_CreditObjectType[] Benefit_Surcharge_Reference
		{
			get
			{
				return this.benefit_Surcharge_ReferenceField;
			}
			set
			{
				this.benefit_Surcharge_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_Surcharge_Reference");
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
