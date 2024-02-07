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
	public class Worker_Tax_Treaty_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private Calendar_YearObjectType tax_Year_ReferenceField;

		private DateTime treaty_Benefit_Start_DateField;

		private DateTime treaty_Benefit_End_DateField;

		private decimal maximum_Benefit_AmountField;

		private bool maximum_Benefit_AmountFieldSpecified;

		private bool no_Treaty_MaximumField;

		private bool no_Treaty_MaximumFieldSpecified;

		private DateTime treaty_Eligibility_BeginField;

		private bool treaty_Eligibility_BeginFieldSpecified;

		private DateTime treaty_Eligibility_EndField;

		private bool treaty_Eligibility_EndFieldSpecified;

		private Payroll_Income_CodeObjectType income_Code_ReferenceField;

		private Payroll_Income_Code_SubtypeObjectType income_Code_Subtype_ReferenceField;

		private bool eligible_for_Withholding_AllowanceField;

		private bool eligible_for_Withholding_AllowanceFieldSpecified;

		private decimal withholding_RateField;

		private bool withholding_RateFieldSpecified;

		private Payroll_IRS_CountryObjectType tax_Residency_Country_Code_ReferenceField;

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

		[XmlElement(Order = 1)]
		public Calendar_YearObjectType Tax_Year_Reference
		{
			get
			{
				return this.tax_Year_ReferenceField;
			}
			set
			{
				this.tax_Year_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Year_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Treaty_Benefit_Start_Date
		{
			get
			{
				return this.treaty_Benefit_Start_DateField;
			}
			set
			{
				this.treaty_Benefit_Start_DateField = value;
				this.RaisePropertyChanged("Treaty_Benefit_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Treaty_Benefit_End_Date
		{
			get
			{
				return this.treaty_Benefit_End_DateField;
			}
			set
			{
				this.treaty_Benefit_End_DateField = value;
				this.RaisePropertyChanged("Treaty_Benefit_End_Date");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Maximum_Benefit_Amount
		{
			get
			{
				return this.maximum_Benefit_AmountField;
			}
			set
			{
				this.maximum_Benefit_AmountField = value;
				this.RaisePropertyChanged("Maximum_Benefit_Amount");
			}
		}

		[XmlIgnore]
		public bool Maximum_Benefit_AmountSpecified
		{
			get
			{
				return this.maximum_Benefit_AmountFieldSpecified;
			}
			set
			{
				this.maximum_Benefit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Benefit_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool No_Treaty_Maximum
		{
			get
			{
				return this.no_Treaty_MaximumField;
			}
			set
			{
				this.no_Treaty_MaximumField = value;
				this.RaisePropertyChanged("No_Treaty_Maximum");
			}
		}

		[XmlIgnore]
		public bool No_Treaty_MaximumSpecified
		{
			get
			{
				return this.no_Treaty_MaximumFieldSpecified;
			}
			set
			{
				this.no_Treaty_MaximumFieldSpecified = value;
				this.RaisePropertyChanged("No_Treaty_MaximumSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Treaty_Eligibility_Begin
		{
			get
			{
				return this.treaty_Eligibility_BeginField;
			}
			set
			{
				this.treaty_Eligibility_BeginField = value;
				this.RaisePropertyChanged("Treaty_Eligibility_Begin");
			}
		}

		[XmlIgnore]
		public bool Treaty_Eligibility_BeginSpecified
		{
			get
			{
				return this.treaty_Eligibility_BeginFieldSpecified;
			}
			set
			{
				this.treaty_Eligibility_BeginFieldSpecified = value;
				this.RaisePropertyChanged("Treaty_Eligibility_BeginSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Treaty_Eligibility_End
		{
			get
			{
				return this.treaty_Eligibility_EndField;
			}
			set
			{
				this.treaty_Eligibility_EndField = value;
				this.RaisePropertyChanged("Treaty_Eligibility_End");
			}
		}

		[XmlIgnore]
		public bool Treaty_Eligibility_EndSpecified
		{
			get
			{
				return this.treaty_Eligibility_EndFieldSpecified;
			}
			set
			{
				this.treaty_Eligibility_EndFieldSpecified = value;
				this.RaisePropertyChanged("Treaty_Eligibility_EndSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public Payroll_Income_CodeObjectType Income_Code_Reference
		{
			get
			{
				return this.income_Code_ReferenceField;
			}
			set
			{
				this.income_Code_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Payroll_Income_Code_SubtypeObjectType Income_Code_Subtype_Reference
		{
			get
			{
				return this.income_Code_Subtype_ReferenceField;
			}
			set
			{
				this.income_Code_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Income_Code_Subtype_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Eligible_for_Withholding_Allowance
		{
			get
			{
				return this.eligible_for_Withholding_AllowanceField;
			}
			set
			{
				this.eligible_for_Withholding_AllowanceField = value;
				this.RaisePropertyChanged("Eligible_for_Withholding_Allowance");
			}
		}

		[XmlIgnore]
		public bool Eligible_for_Withholding_AllowanceSpecified
		{
			get
			{
				return this.eligible_for_Withholding_AllowanceFieldSpecified;
			}
			set
			{
				this.eligible_for_Withholding_AllowanceFieldSpecified = value;
				this.RaisePropertyChanged("Eligible_for_Withholding_AllowanceSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Withholding_Rate
		{
			get
			{
				return this.withholding_RateField;
			}
			set
			{
				this.withholding_RateField = value;
				this.RaisePropertyChanged("Withholding_Rate");
			}
		}

		[XmlIgnore]
		public bool Withholding_RateSpecified
		{
			get
			{
				return this.withholding_RateFieldSpecified;
			}
			set
			{
				this.withholding_RateFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_RateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public Payroll_IRS_CountryObjectType Tax_Residency_Country_Code_Reference
		{
			get
			{
				return this.tax_Residency_Country_Code_ReferenceField;
			}
			set
			{
				this.tax_Residency_Country_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Residency_Country_Code_Reference");
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
