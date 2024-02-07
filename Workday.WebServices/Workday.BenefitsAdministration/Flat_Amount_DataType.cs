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
	public class Flat_Amount_DataType : INotifyPropertyChanged
	{
		private decimal employee_Cost_AmountField;

		private bool employee_Cost_AmountFieldSpecified;

		private decimal employee_Cost_Amount_PostTaxField;

		private bool employee_Cost_Amount_PostTaxFieldSpecified;

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
