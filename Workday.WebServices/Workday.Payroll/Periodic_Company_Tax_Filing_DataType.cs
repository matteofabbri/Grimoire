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
	public class Periodic_Company_Tax_Filing_DataType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private bool third_Party_Provides_Sick_Pay_W2Field;

		private bool third_Party_Provides_Sick_Pay_W2FieldSpecified;

		private DateTime period_End_DateField;

		private bool period_End_DateFieldSpecified;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Periodic_Company_Tax_Filing_Pay_Group_DataType[] pay_Group_DataField;

		private PeriodObjectType[] period_ReferenceField;

		private bool third_Party_Sick_PayField;

		private bool third_Party_Sick_PayFieldSpecified;

		private bool employer_PaidField;

		private bool employer_PaidFieldSpecified;

		private Payroll_CalculationObjectType deduction_ReferenceField;

		private Metadata_Payroll_WorktagObjectType payroll_Tax_Authority_ReferenceField;

		private string tax_Filing_CodeField;

		private decimal male_CountField;

		private bool male_CountFieldSpecified;

		private decimal female_CountField;

		private bool female_CountFieldSpecified;

		private decimal unknown_Gender_CountField;

		private bool unknown_Gender_CountFieldSpecified;

		private decimal sUI_RateField;

		private bool sUI_RateFieldSpecified;

		private decimal tax_WithheldField;

		private bool tax_WithheldFieldSpecified;

		private decimal taxable_WagesField;

		private bool taxable_WagesFieldSpecified;

		private decimal subject_WagesField;

		private bool subject_WagesFieldSpecified;

		private decimal gross_WagesField;

		private bool gross_WagesFieldSpecified;

		private decimal tip_WagesField;

		private bool tip_WagesFieldSpecified;

		private QTD_Tax_Filing_Data_for_Periodic_CompanyType qTD_DataField;

		private YTD_Tax_Filing_Data_for_Periodic_CompanyType yTD_DataField;

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

		[XmlElement("Third_Party_Provides_Sick_Pay_W-2", Order = 1)]
		public bool Third_Party_Provides_Sick_Pay_W2
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2Field;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2Field = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Provides_Sick_Pay_W2Specified
		{
			get
			{
				return this.third_Party_Provides_Sick_Pay_W2FieldSpecified;
			}
			set
			{
				this.third_Party_Provides_Sick_Pay_W2FieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Provides_Sick_Pay_W2Specified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement("Pay_Group_Data", Order = 5)]
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

		[XmlElement("Period_Reference", Order = 6)]
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

		[XmlElement(Order = 7)]
		public bool Third_Party_Sick_Pay
		{
			get
			{
				return this.third_Party_Sick_PayField;
			}
			set
			{
				this.third_Party_Sick_PayField = value;
				this.RaisePropertyChanged("Third_Party_Sick_Pay");
			}
		}

		[XmlIgnore]
		public bool Third_Party_Sick_PaySpecified
		{
			get
			{
				return this.third_Party_Sick_PayFieldSpecified;
			}
			set
			{
				this.third_Party_Sick_PayFieldSpecified = value;
				this.RaisePropertyChanged("Third_Party_Sick_PaySpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public decimal Male_Count
		{
			get
			{
				return this.male_CountField;
			}
			set
			{
				this.male_CountField = value;
				this.RaisePropertyChanged("Male_Count");
			}
		}

		[XmlIgnore]
		public bool Male_CountSpecified
		{
			get
			{
				return this.male_CountFieldSpecified;
			}
			set
			{
				this.male_CountFieldSpecified = value;
				this.RaisePropertyChanged("Male_CountSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Female_Count
		{
			get
			{
				return this.female_CountField;
			}
			set
			{
				this.female_CountField = value;
				this.RaisePropertyChanged("Female_Count");
			}
		}

		[XmlIgnore]
		public bool Female_CountSpecified
		{
			get
			{
				return this.female_CountFieldSpecified;
			}
			set
			{
				this.female_CountFieldSpecified = value;
				this.RaisePropertyChanged("Female_CountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Unknown_Gender_Count
		{
			get
			{
				return this.unknown_Gender_CountField;
			}
			set
			{
				this.unknown_Gender_CountField = value;
				this.RaisePropertyChanged("Unknown_Gender_Count");
			}
		}

		[XmlIgnore]
		public bool Unknown_Gender_CountSpecified
		{
			get
			{
				return this.unknown_Gender_CountFieldSpecified;
			}
			set
			{
				this.unknown_Gender_CountFieldSpecified = value;
				this.RaisePropertyChanged("Unknown_Gender_CountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal SUI_Rate
		{
			get
			{
				return this.sUI_RateField;
			}
			set
			{
				this.sUI_RateField = value;
				this.RaisePropertyChanged("SUI_Rate");
			}
		}

		[XmlIgnore]
		public bool SUI_RateSpecified
		{
			get
			{
				return this.sUI_RateFieldSpecified;
			}
			set
			{
				this.sUI_RateFieldSpecified = value;
				this.RaisePropertyChanged("SUI_RateSpecified");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public decimal Gross_Wages
		{
			get
			{
				return this.gross_WagesField;
			}
			set
			{
				this.gross_WagesField = value;
				this.RaisePropertyChanged("Gross_Wages");
			}
		}

		[XmlIgnore]
		public bool Gross_WagesSpecified
		{
			get
			{
				return this.gross_WagesFieldSpecified;
			}
			set
			{
				this.gross_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Gross_WagesSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Tip_Wages
		{
			get
			{
				return this.tip_WagesField;
			}
			set
			{
				this.tip_WagesField = value;
				this.RaisePropertyChanged("Tip_Wages");
			}
		}

		[XmlIgnore]
		public bool Tip_WagesSpecified
		{
			get
			{
				return this.tip_WagesFieldSpecified;
			}
			set
			{
				this.tip_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Tip_WagesSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public QTD_Tax_Filing_Data_for_Periodic_CompanyType QTD_Data
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

		[XmlElement(Order = 22)]
		public YTD_Tax_Filing_Data_for_Periodic_CompanyType YTD_Data
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
