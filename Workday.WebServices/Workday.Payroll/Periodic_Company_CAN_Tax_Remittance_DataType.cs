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
	public class Periodic_Company_CAN_Tax_Remittance_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Metadata_Payroll_WorktagObjectType payroll_Tax_Authority_ReferenceField;

		private string payroll_Tax_Account_NumberField;

		private Workers_Compensation_CodeObjectType wCB_Classification_Code_ReferenceField;

		private string wCB_Payroll_Report_IdField;

		private string wCB_E_Banking_NumberField;

		private decimal number_Employees_Paid_Last_PeriodField;

		private bool number_Employees_Paid_Last_PeriodFieldSpecified;

		private Periodic_Company_Tax_Filing_Pay_Group_DataType[] pay_Group_DataField;

		private PeriodObjectType[] period_ReferenceField;

		private bool employer_PaidField;

		private bool employer_PaidFieldSpecified;

		private Payroll_CalculationObjectType deduction_ReferenceField;

		private string tax_Filing_CodeField;

		private decimal tax_RateField;

		private bool tax_RateFieldSpecified;

		private decimal wCB_Tax_RateField;

		private bool wCB_Tax_RateFieldSpecified;

		private decimal tax_WithheldField;

		private bool tax_WithheldFieldSpecified;

		private decimal taxable_WagesField;

		private bool taxable_WagesFieldSpecified;

		private decimal subject_WagesField;

		private bool subject_WagesFieldSpecified;

		private decimal exempt_WagesField;

		private bool exempt_WagesFieldSpecified;

		private decimal wCB_Insurable_WagesField;

		private bool wCB_Insurable_WagesFieldSpecified;

		private decimal wCB_Gross_WagesField;

		private bool wCB_Gross_WagesFieldSpecified;

		private decimal wCB_Other_WagesField;

		private bool wCB_Other_WagesFieldSpecified;

		private decimal wCB_Excess_WagesField;

		private bool wCB_Excess_WagesFieldSpecified;

		private MTD_Tax_Remittance_Data_for_Periodic_CompanyType mTD_DataField;

		private QTD_Tax_Remittance_Data_for_Periodic_CompanyType qTD_DataField;

		private YTD_Tax_Remittance_Data_for_Periodic_CompanyType yTD_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Period_End_Date
		{
			get
			{
				return this.period_End_DateField;
			}
			set
			{
				this.period_End_DateField = value;
				this.RaisePropertyChanged("Period_End_Date");
			}
		}

		[XmlIgnore]
		public bool Period_End_DateSpecified
		{
			get
			{
				return this.period_End_DateFieldSpecified;
			}
			set
			{
				this.period_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Period_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Metadata_Payroll_WorktagObjectType Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Payroll_Tax_Account_Number
		{
			get
			{
				return this.payroll_Tax_Account_NumberField;
			}
			set
			{
				this.payroll_Tax_Account_NumberField = value;
				this.RaisePropertyChanged("Payroll_Tax_Account_Number");
			}
		}

		[XmlElement(Order = 6)]
		public Workers_Compensation_CodeObjectType WCB_Classification_Code_Reference
		{
			get
			{
				return this.wCB_Classification_Code_ReferenceField;
			}
			set
			{
				this.wCB_Classification_Code_ReferenceField = value;
				this.RaisePropertyChanged("WCB_Classification_Code_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string WCB_Payroll_Report_Id
		{
			get
			{
				return this.wCB_Payroll_Report_IdField;
			}
			set
			{
				this.wCB_Payroll_Report_IdField = value;
				this.RaisePropertyChanged("WCB_Payroll_Report_Id");
			}
		}

		[XmlElement(Order = 8)]
		public string WCB_E_Banking_Number
		{
			get
			{
				return this.wCB_E_Banking_NumberField;
			}
			set
			{
				this.wCB_E_Banking_NumberField = value;
				this.RaisePropertyChanged("WCB_E_Banking_Number");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Number_Employees_Paid_Last_Period
		{
			get
			{
				return this.number_Employees_Paid_Last_PeriodField;
			}
			set
			{
				this.number_Employees_Paid_Last_PeriodField = value;
				this.RaisePropertyChanged("Number_Employees_Paid_Last_Period");
			}
		}

		[XmlIgnore]
		public bool Number_Employees_Paid_Last_PeriodSpecified
		{
			get
			{
				return this.number_Employees_Paid_Last_PeriodFieldSpecified;
			}
			set
			{
				this.number_Employees_Paid_Last_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Number_Employees_Paid_Last_PeriodSpecified");
			}
		}

		[XmlElement("Pay_Group_Data", Order = 10)]
		public Periodic_Company_Tax_Filing_Pay_Group_DataType[] Pay_Group_Data
		{
			get
			{
				return this.pay_Group_DataField;
			}
			set
			{
				this.pay_Group_DataField = value;
				this.RaisePropertyChanged("Pay_Group_Data");
			}
		}

		[XmlElement("Period_Reference", Order = 11)]
		public PeriodObjectType[] Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public bool Employer_Paid
		{
			get
			{
				return this.employer_PaidField;
			}
			set
			{
				this.employer_PaidField = value;
				this.RaisePropertyChanged("Employer_Paid");
			}
		}

		[XmlIgnore]
		public bool Employer_PaidSpecified
		{
			get
			{
				return this.employer_PaidFieldSpecified;
			}
			set
			{
				this.employer_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Employer_PaidSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Payroll_CalculationObjectType Deduction_Reference
		{
			get
			{
				return this.deduction_ReferenceField;
			}
			set
			{
				this.deduction_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public string Tax_Filing_Code
		{
			get
			{
				return this.tax_Filing_CodeField;
			}
			set
			{
				this.tax_Filing_CodeField = value;
				this.RaisePropertyChanged("Tax_Filing_Code");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public decimal WCB_Tax_Rate
		{
			get
			{
				return this.wCB_Tax_RateField;
			}
			set
			{
				this.wCB_Tax_RateField = value;
				this.RaisePropertyChanged("WCB_Tax_Rate");
			}
		}

		[XmlIgnore]
		public bool WCB_Tax_RateSpecified
		{
			get
			{
				return this.wCB_Tax_RateFieldSpecified;
			}
			set
			{
				this.wCB_Tax_RateFieldSpecified = value;
				this.RaisePropertyChanged("WCB_Tax_RateSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Tax_Withheld
		{
			get
			{
				return this.tax_WithheldField;
			}
			set
			{
				this.tax_WithheldField = value;
				this.RaisePropertyChanged("Tax_Withheld");
			}
		}

		[XmlIgnore]
		public bool Tax_WithheldSpecified
		{
			get
			{
				return this.tax_WithheldFieldSpecified;
			}
			set
			{
				this.tax_WithheldFieldSpecified = value;
				this.RaisePropertyChanged("Tax_WithheldSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Taxable_Wages
		{
			get
			{
				return this.taxable_WagesField;
			}
			set
			{
				this.taxable_WagesField = value;
				this.RaisePropertyChanged("Taxable_Wages");
			}
		}

		[XmlIgnore]
		public bool Taxable_WagesSpecified
		{
			get
			{
				return this.taxable_WagesFieldSpecified;
			}
			set
			{
				this.taxable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Taxable_WagesSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Subject_Wages
		{
			get
			{
				return this.subject_WagesField;
			}
			set
			{
				this.subject_WagesField = value;
				this.RaisePropertyChanged("Subject_Wages");
			}
		}

		[XmlIgnore]
		public bool Subject_WagesSpecified
		{
			get
			{
				return this.subject_WagesFieldSpecified;
			}
			set
			{
				this.subject_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Subject_WagesSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Exempt_Wages
		{
			get
			{
				return this.exempt_WagesField;
			}
			set
			{
				this.exempt_WagesField = value;
				this.RaisePropertyChanged("Exempt_Wages");
			}
		}

		[XmlIgnore]
		public bool Exempt_WagesSpecified
		{
			get
			{
				return this.exempt_WagesFieldSpecified;
			}
			set
			{
				this.exempt_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Exempt_WagesSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal WCB_Insurable_Wages
		{
			get
			{
				return this.wCB_Insurable_WagesField;
			}
			set
			{
				this.wCB_Insurable_WagesField = value;
				this.RaisePropertyChanged("WCB_Insurable_Wages");
			}
		}

		[XmlIgnore]
		public bool WCB_Insurable_WagesSpecified
		{
			get
			{
				return this.wCB_Insurable_WagesFieldSpecified;
			}
			set
			{
				this.wCB_Insurable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("WCB_Insurable_WagesSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public decimal WCB_Gross_Wages
		{
			get
			{
				return this.wCB_Gross_WagesField;
			}
			set
			{
				this.wCB_Gross_WagesField = value;
				this.RaisePropertyChanged("WCB_Gross_Wages");
			}
		}

		[XmlIgnore]
		public bool WCB_Gross_WagesSpecified
		{
			get
			{
				return this.wCB_Gross_WagesFieldSpecified;
			}
			set
			{
				this.wCB_Gross_WagesFieldSpecified = value;
				this.RaisePropertyChanged("WCB_Gross_WagesSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public decimal WCB_Other_Wages
		{
			get
			{
				return this.wCB_Other_WagesField;
			}
			set
			{
				this.wCB_Other_WagesField = value;
				this.RaisePropertyChanged("WCB_Other_Wages");
			}
		}

		[XmlIgnore]
		public bool WCB_Other_WagesSpecified
		{
			get
			{
				return this.wCB_Other_WagesFieldSpecified;
			}
			set
			{
				this.wCB_Other_WagesFieldSpecified = value;
				this.RaisePropertyChanged("WCB_Other_WagesSpecified");
			}
		}

		[XmlElement(Order = 24)]
		public decimal WCB_Excess_Wages
		{
			get
			{
				return this.wCB_Excess_WagesField;
			}
			set
			{
				this.wCB_Excess_WagesField = value;
				this.RaisePropertyChanged("WCB_Excess_Wages");
			}
		}

		[XmlIgnore]
		public bool WCB_Excess_WagesSpecified
		{
			get
			{
				return this.wCB_Excess_WagesFieldSpecified;
			}
			set
			{
				this.wCB_Excess_WagesFieldSpecified = value;
				this.RaisePropertyChanged("WCB_Excess_WagesSpecified");
			}
		}

		[XmlElement(Order = 25)]
		public MTD_Tax_Remittance_Data_for_Periodic_CompanyType MTD_Data
		{
			get
			{
				return this.mTD_DataField;
			}
			set
			{
				this.mTD_DataField = value;
				this.RaisePropertyChanged("MTD_Data");
			}
		}

		[XmlElement(Order = 26)]
		public QTD_Tax_Remittance_Data_for_Periodic_CompanyType QTD_Data
		{
			get
			{
				return this.qTD_DataField;
			}
			set
			{
				this.qTD_DataField = value;
				this.RaisePropertyChanged("QTD_Data");
			}
		}

		[XmlElement(Order = 27)]
		public YTD_Tax_Remittance_Data_for_Periodic_CompanyType YTD_Data
		{
			get
			{
				return this.yTD_DataField;
			}
			set
			{
				this.yTD_DataField = value;
				this.RaisePropertyChanged("YTD_Data");
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
