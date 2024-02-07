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
	public class Benefit_Rate_Value_Flat_DataType : INotifyPropertyChanged
	{
		private decimal employee_Cost_AmountField;

		private bool employee_Cost_AmountFieldSpecified;

		private decimal employee_Cost_Amount_MinField;

		private bool employee_Cost_Amount_MinFieldSpecified;

		private decimal employee_Cost_Amount_MaxField;

		private bool employee_Cost_Amount_MaxFieldSpecified;

		private decimal employee_Cost_Amount_PostTaxField;

		private bool employee_Cost_Amount_PostTaxFieldSpecified;

		private decimal employee_Cost_Amount_Min_PostTaxField;

		private bool employee_Cost_Amount_Min_PostTaxFieldSpecified;

		private decimal employee_Cost_Amount_Max_PostTaxField;

		private bool employee_Cost_Amount_Max_PostTaxFieldSpecified;

		private decimal employer_Contribution_AmountField;

		private bool employer_Contribution_AmountFieldSpecified;

		private decimal employer_Contribution_Amount_TaxableField;

		private bool employer_Contribution_Amount_TaxableFieldSpecified;

		private decimal flex_Credit_AmountField;

		private bool flex_Credit_AmountFieldSpecified;

		private decimal fair_Market_Value_per_DependentField;

		private bool fair_Market_Value_per_DependentFieldSpecified;

		private Benefits_Calculable_CreditObjectType[] benefit_Credit_ReferenceField;

		private Benefits_Calculable_CreditObjectType[] benefit_Surcharge_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Employee_Cost_Amount
		{
			get
			{
				return this.employee_Cost_AmountField;
			}
			set
			{
				this.employee_Cost_AmountField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_AmountSpecified
		{
			get
			{
				return this.employee_Cost_AmountFieldSpecified;
			}
			set
			{
				this.employee_Cost_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_AmountSpecified");
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
		public decimal Employee_Cost_Amount_PostTax
		{
			get
			{
				return this.employee_Cost_Amount_PostTaxField;
			}
			set
			{
				this.employee_Cost_Amount_PostTaxField = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_PostTax");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_Amount_PostTaxSpecified
		{
			get
			{
				return this.employee_Cost_Amount_PostTaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_Amount_PostTaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_Amount_PostTaxSpecified");
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
		public decimal Employer_Contribution_Amount
		{
			get
			{
				return this.employer_Contribution_AmountField;
			}
			set
			{
				this.employer_Contribution_AmountField = value;
				this.RaisePropertyChanged("Employer_Contribution_Amount");
			}
		}

		[XmlIgnore]
		public bool Employer_Contribution_AmountSpecified
		{
			get
			{
				return this.employer_Contribution_AmountFieldSpecified;
			}
			set
			{
				this.employer_Contribution_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Contribution_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Employer_Contribution_Amount_Taxable
		{
			get
			{
				return this.employer_Contribution_Amount_TaxableField;
			}
			set
			{
				this.employer_Contribution_Amount_TaxableField = value;
				this.RaisePropertyChanged("Employer_Contribution_Amount_Taxable");
			}
		}

		[XmlIgnore]
		public bool Employer_Contribution_Amount_TaxableSpecified
		{
			get
			{
				return this.employer_Contribution_Amount_TaxableFieldSpecified;
			}
			set
			{
				this.employer_Contribution_Amount_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Contribution_Amount_TaxableSpecified");
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

		[XmlElement("Benefit_Credit_Reference", Order = 10)]
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

		[XmlElement("Benefit_Surcharge_Reference", Order = 11)]
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
