using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Payroll_Federal_W-4_Tax_Election_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Federal_W4_Tax_Election_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private DateTime effective_as_ofField;

		private CompanyObjectType company_ReferenceField;

		private Payroll_Withholding_StatusObjectType marital_Status_ReferenceField;

		private decimal number_of_AllowancesField;

		private bool number_of_AllowancesFieldSpecified;

		private decimal additional_AmountField;

		private bool additional_AmountFieldSpecified;

		private bool exemptField;

		private bool exemptFieldSpecified;

		private bool nonresident_AlienField;

		private bool nonresident_AlienFieldSpecified;

		private bool exempt_from_NRA_Additional_AmountField;

		private bool exempt_from_NRA_Additional_AmountFieldSpecified;

		private bool lock_In_LetterField;

		private bool lock_In_LetterFieldSpecified;

		private bool no_Wage_No_TaxField;

		private bool no_Wage_No_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_as_of
		{
			get
			{
				return this.effective_as_ofField;
			}
			set
			{
				this.effective_as_ofField = value;
				this.RaisePropertyChanged("Effective_as_of");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Payroll_Withholding_StatusObjectType Marital_Status_Reference
		{
			get
			{
				return this.marital_Status_ReferenceField;
			}
			set
			{
				this.marital_Status_ReferenceField = value;
				this.RaisePropertyChanged("Marital_Status_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Number_of_Allowances
		{
			get
			{
				return this.number_of_AllowancesField;
			}
			set
			{
				this.number_of_AllowancesField = value;
				this.RaisePropertyChanged("Number_of_Allowances");
			}
		}

		[XmlIgnore]
		public bool Number_of_AllowancesSpecified
		{
			get
			{
				return this.number_of_AllowancesFieldSpecified;
			}
			set
			{
				this.number_of_AllowancesFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_AllowancesSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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
		public bool Exempt_from_NRA_Additional_Amount
		{
			get
			{
				return this.exempt_from_NRA_Additional_AmountField;
			}
			set
			{
				this.exempt_from_NRA_Additional_AmountField = value;
				this.RaisePropertyChanged("Exempt_from_NRA_Additional_Amount");
			}
		}

		[XmlIgnore]
		public bool Exempt_from_NRA_Additional_AmountSpecified
		{
			get
			{
				return this.exempt_from_NRA_Additional_AmountFieldSpecified;
			}
			set
			{
				this.exempt_from_NRA_Additional_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_from_NRA_Additional_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Lock_In_Letter
		{
			get
			{
				return this.lock_In_LetterField;
			}
			set
			{
				this.lock_In_LetterField = value;
				this.RaisePropertyChanged("Lock_In_Letter");
			}
		}

		[XmlIgnore]
		public bool Lock_In_LetterSpecified
		{
			get
			{
				return this.lock_In_LetterFieldSpecified;
			}
			set
			{
				this.lock_In_LetterFieldSpecified = value;
				this.RaisePropertyChanged("Lock_In_LetterSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool No_Wage_No_Tax
		{
			get
			{
				return this.no_Wage_No_TaxField;
			}
			set
			{
				this.no_Wage_No_TaxField = value;
				this.RaisePropertyChanged("No_Wage_No_Tax");
			}
		}

		[XmlIgnore]
		public bool No_Wage_No_TaxSpecified
		{
			get
			{
				return this.no_Wage_No_TaxFieldSpecified;
			}
			set
			{
				this.no_Wage_No_TaxFieldSpecified = value;
				this.RaisePropertyChanged("No_Wage_No_TaxSpecified");
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
