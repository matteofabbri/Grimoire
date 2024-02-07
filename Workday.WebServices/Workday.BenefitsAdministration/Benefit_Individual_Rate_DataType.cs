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
	public class Benefit_Individual_Rate_DataType : INotifyPropertyChanged
	{
		private string benefit_Individual_Rate_IDField;

		private decimal employee_Cost_PreTaxField;

		private bool employee_Cost_PreTaxFieldSpecified;

		private decimal employee_PostTax_AmountField;

		private bool employee_PostTax_AmountFieldSpecified;

		private decimal employer_Cost_NonTaxableField;

		private bool employer_Cost_NonTaxableFieldSpecified;

		private decimal employer_Cost_TaxableField;

		private bool employer_Cost_TaxableFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Benefit_Individual_Rate_ID
		{
			get
			{
				return this.benefit_Individual_Rate_IDField;
			}
			set
			{
				this.benefit_Individual_Rate_IDField = value;
				this.RaisePropertyChanged("Benefit_Individual_Rate_ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Employee_Cost_PreTax
		{
			get
			{
				return this.employee_Cost_PreTaxField;
			}
			set
			{
				this.employee_Cost_PreTaxField = value;
				this.RaisePropertyChanged("Employee_Cost_PreTax");
			}
		}

		[XmlIgnore]
		public bool Employee_Cost_PreTaxSpecified
		{
			get
			{
				return this.employee_Cost_PreTaxFieldSpecified;
			}
			set
			{
				this.employee_Cost_PreTaxFieldSpecified = value;
				this.RaisePropertyChanged("Employee_Cost_PreTaxSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Employee_PostTax_Amount
		{
			get
			{
				return this.employee_PostTax_AmountField;
			}
			set
			{
				this.employee_PostTax_AmountField = value;
				this.RaisePropertyChanged("Employee_PostTax_Amount");
			}
		}

		[XmlIgnore]
		public bool Employee_PostTax_AmountSpecified
		{
			get
			{
				return this.employee_PostTax_AmountFieldSpecified;
			}
			set
			{
				this.employee_PostTax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Employee_PostTax_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Employer_Cost_NonTaxable
		{
			get
			{
				return this.employer_Cost_NonTaxableField;
			}
			set
			{
				this.employer_Cost_NonTaxableField = value;
				this.RaisePropertyChanged("Employer_Cost_NonTaxable");
			}
		}

		[XmlIgnore]
		public bool Employer_Cost_NonTaxableSpecified
		{
			get
			{
				return this.employer_Cost_NonTaxableFieldSpecified;
			}
			set
			{
				this.employer_Cost_NonTaxableFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Cost_NonTaxableSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Employer_Cost_Taxable
		{
			get
			{
				return this.employer_Cost_TaxableField;
			}
			set
			{
				this.employer_Cost_TaxableField = value;
				this.RaisePropertyChanged("Employer_Cost_Taxable");
			}
		}

		[XmlIgnore]
		public bool Employer_Cost_TaxableSpecified
		{
			get
			{
				return this.employer_Cost_TaxableFieldSpecified;
			}
			set
			{
				this.employer_Cost_TaxableFieldSpecified = value;
				this.RaisePropertyChanged("Employer_Cost_TaxableSpecified");
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
