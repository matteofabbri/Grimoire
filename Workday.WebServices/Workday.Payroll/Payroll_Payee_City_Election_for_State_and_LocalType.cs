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
	public class Payroll_Payee_City_Election_for_State_and_LocalType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Tax_Address_TypeObjectType tax_Address_Type_ReferenceField;

		private Payroll_Local_AuthorityObjectType payroll_Local_City_Authority_ReferenceField;

		private decimal exemptionsField;

		private bool exemptionsFieldSpecified;

		private Payroll_Constant_PercentObjectType withholding_Percent_ReferenceField;

		private decimal previous_Employer_Deducted_AmountField;

		private bool previous_Employer_Deducted_AmountFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private bool nonresident_AlienField;

		private bool nonresident_AlienFieldSpecified;

		private decimal low_Income_ThresholdField;

		private bool low_Income_ThresholdFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private Payroll_Constant_TextObjectType exempt_Reason_ReferenceField;

		private bool inactivate_State_TaxField;

		private bool inactivate_State_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_Address_TypeObjectType Tax_Address_Type_Reference
		{
			get
			{
				return this.tax_Address_Type_ReferenceField;
			}
			set
			{
				this.tax_Address_Type_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Address_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Payroll_Local_AuthorityObjectType Payroll_Local_City_Authority_Reference
		{
			get
			{
				return this.payroll_Local_City_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_City_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_City_Authority_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Exemptions
		{
			get
			{
				return this.exemptionsField;
			}
			set
			{
				this.exemptionsField = value;
				this.RaisePropertyChanged("Exemptions");
			}
		}

		[XmlIgnore]
		public bool ExemptionsSpecified
		{
			get
			{
				return this.exemptionsFieldSpecified;
			}
			set
			{
				this.exemptionsFieldSpecified = value;
				this.RaisePropertyChanged("ExemptionsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Constant_PercentObjectType Withholding_Percent_Reference
		{
			get
			{
				return this.withholding_Percent_ReferenceField;
			}
			set
			{
				this.withholding_Percent_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Percent_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Previous_Employer_Deducted_Amount
		{
			get
			{
				return this.previous_Employer_Deducted_AmountField;
			}
			set
			{
				this.previous_Employer_Deducted_AmountField = value;
				this.RaisePropertyChanged("Previous_Employer_Deducted_Amount");
			}
		}

		[XmlIgnore]
		public bool Previous_Employer_Deducted_AmountSpecified
		{
			get
			{
				return this.previous_Employer_Deducted_AmountFieldSpecified;
			}
			set
			{
				this.previous_Employer_Deducted_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Previous_Employer_Deducted_AmountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Additional_Amount
		{
			get
			{
				return this.additional_AmountField;
			}
			set
			{
				this.additional_AmountField = value;
				this.RaisePropertyChanged("Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Additional_AmountSpecified
		{
			get
			{
				return this.additional_AmountFieldSpecified;
			}
			set
			{
				this.additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Nonresident_Alien
		{
			get
			{
				return this.nonresident_AlienField;
			}
			set
			{
				this.nonresident_AlienField = value;
				this.RaisePropertyChanged("Nonresident_Alien");
			}
		}

		[XmlIgnore]
		public bool Nonresident_AlienSpecified
		{
			get
			{
				return this.nonresident_AlienFieldSpecified;
			}
			set
			{
				this.nonresident_AlienFieldSpecified = value;
				this.RaisePropertyChanged("Nonresident_AlienSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Low_Income_Threshold
		{
			get
			{
				return this.low_Income_ThresholdField;
			}
			set
			{
				this.low_Income_ThresholdField = value;
				this.RaisePropertyChanged("Low_Income_Threshold");
			}
		}

		[XmlIgnore]
		public bool Low_Income_ThresholdSpecified
		{
			get
			{
				return this.low_Income_ThresholdFieldSpecified;
			}
			set
			{
				this.low_Income_ThresholdFieldSpecified = value;
				this.RaisePropertyChanged("Low_Income_ThresholdSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Exempt
		{
			get
			{
				return this.exemptField;
			}
			set
			{
				this.exemptField = value;
				this.RaisePropertyChanged("Exempt");
			}
		}

		[XmlIgnore]
		public bool ExemptSpecified
		{
			get
			{
				return this.exemptFieldSpecified;
			}
			set
			{
				this.exemptFieldSpecified = value;
				this.RaisePropertyChanged("ExemptSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Payroll_Constant_TextObjectType Exempt_Reason_Reference
		{
			get
			{
				return this.exempt_Reason_ReferenceField;
			}
			set
			{
				this.exempt_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Exempt_Reason_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool Inactivate_State_Tax
		{
			get
			{
				return this.inactivate_State_TaxField;
			}
			set
			{
				this.inactivate_State_TaxField = value;
				this.RaisePropertyChanged("Inactivate_State_Tax");
			}
		}

		[XmlIgnore]
		public bool Inactivate_State_TaxSpecified
		{
			get
			{
				return this.inactivate_State_TaxFieldSpecified;
			}
			set
			{
				this.inactivate_State_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Inactivate_State_TaxSpecified");
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
