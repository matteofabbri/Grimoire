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
	public class MTD_Tax_Remittance_Data_for_Periodic_CompanyType : INotifyPropertyChanged
	{
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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
