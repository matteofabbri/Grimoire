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
	public class QTD_Tax_Filing_Data_for_Quarterly_WorkerType : INotifyPropertyChanged
	{
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

		private decimal uncollected_Tip_TaxField;

		private bool uncollected_Tip_TaxFieldSpecified;

		private decimal uncollected_GTLField;

		private bool uncollected_GTLFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public decimal Uncollected_Tip_Tax
		{
			get
			{
				return this.uncollected_Tip_TaxField;
			}
			set
			{
				this.uncollected_Tip_TaxField = value;
				this.RaisePropertyChanged("Uncollected_Tip_Tax");
			}
		}

		[XmlIgnore]
		public bool Uncollected_Tip_TaxSpecified
		{
			get
			{
				return this.uncollected_Tip_TaxFieldSpecified;
			}
			set
			{
				this.uncollected_Tip_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Uncollected_Tip_TaxSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Uncollected_GTL
		{
			get
			{
				return this.uncollected_GTLField;
			}
			set
			{
				this.uncollected_GTLField = value;
				this.RaisePropertyChanged("Uncollected_GTL");
			}
		}

		[XmlIgnore]
		public bool Uncollected_GTLSpecified
		{
			get
			{
				return this.uncollected_GTLFieldSpecified;
			}
			set
			{
				this.uncollected_GTLFieldSpecified = value;
				this.RaisePropertyChanged("Uncollected_GTLSpecified");
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
