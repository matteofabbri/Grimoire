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
	public class Payroll_Result_Detail_DataType : INotifyPropertyChanged
	{
		private bool employer_PaidField;

		private bool employer_PaidFieldSpecified;

		private Payroll_CalculationObjectType deduction_ReferenceField;

		private Payroll_Tax_AuthorityObjectType payroll_Tax_Authority_ReferenceField;

		private string work_PSD_CodeField;

		private string resident_PSD_CodeField;

		private string tax_Filing_CodeField;

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

		private QTD_Tax_Filing_Data_for_Periodic_WorkerType qTD_DataField;

		private YTD_Tax_Filing_Data_for_Periodic_WorkerType yTD_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Payroll_Tax_AuthorityObjectType Payroll_Tax_Authority_Reference
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

		[XmlElement(Order = 3)]
		public string Work_PSD_Code
		{
			get
			{
				return this.work_PSD_CodeField;
			}
			set
			{
				this.work_PSD_CodeField = value;
				this.RaisePropertyChanged("Work_PSD_Code");
			}
		}

		[XmlElement(Order = 4)]
		public string Resident_PSD_Code
		{
			get
			{
				return this.resident_PSD_CodeField;
			}
			set
			{
				this.resident_PSD_CodeField = value;
				this.RaisePropertyChanged("Resident_PSD_Code");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public QTD_Tax_Filing_Data_for_Periodic_WorkerType QTD_Data
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

		[XmlElement(Order = 13)]
		public YTD_Tax_Filing_Data_for_Periodic_WorkerType YTD_Data
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
