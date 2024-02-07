using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Tax_Applicability_DataType : INotifyPropertyChanged
	{
		private string tax_Applicability_IDField;

		private string tax_Applicability_CodeField;

		private bool taxableField;

		private bool taxableFieldSpecified;

		private bool recoverableField;

		private bool recoverableFieldSpecified;

		private Tax_Recoverability_TypeObjectType tax_Recoverability_ReferenceField;

		private decimal partially_Recoverable_PercentageField;

		private bool partially_Recoverable_PercentageFieldSpecified;

		private bool allocate_Non_Recoverable_TaxField;

		private bool allocate_Non_Recoverable_TaxFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Tax_Applicability_ID
		{
			get
			{
				return this.tax_Applicability_IDField;
			}
			set
			{
				this.tax_Applicability_IDField = value;
				this.RaisePropertyChanged("Tax_Applicability_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Applicability_Code
		{
			get
			{
				return this.tax_Applicability_CodeField;
			}
			set
			{
				this.tax_Applicability_CodeField = value;
				this.RaisePropertyChanged("Tax_Applicability_Code");
			}
		}

		[XmlElement(Order = 2)]
		public bool Taxable
		{
			get
			{
				return this.taxableField;
			}
			set
			{
				this.taxableField = value;
				this.RaisePropertyChanged("Taxable");
			}
		}

		[XmlIgnore]
		public bool TaxableSpecified
		{
			get
			{
				return this.taxableFieldSpecified;
			}
			set
			{
				this.taxableFieldSpecified = value;
				this.RaisePropertyChanged("TaxableSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Recoverable
		{
			get
			{
				return this.recoverableField;
			}
			set
			{
				this.recoverableField = value;
				this.RaisePropertyChanged("Recoverable");
			}
		}

		[XmlIgnore]
		public bool RecoverableSpecified
		{
			get
			{
				return this.recoverableFieldSpecified;
			}
			set
			{
				this.recoverableFieldSpecified = value;
				this.RaisePropertyChanged("RecoverableSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Tax_Recoverability_TypeObjectType Tax_Recoverability_Reference
		{
			get
			{
				return this.tax_Recoverability_ReferenceField;
			}
			set
			{
				this.tax_Recoverability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Recoverability_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Partially_Recoverable_Percentage
		{
			get
			{
				return this.partially_Recoverable_PercentageField;
			}
			set
			{
				this.partially_Recoverable_PercentageField = value;
				this.RaisePropertyChanged("Partially_Recoverable_Percentage");
			}
		}

		[XmlIgnore]
		public bool Partially_Recoverable_PercentageSpecified
		{
			get
			{
				return this.partially_Recoverable_PercentageFieldSpecified;
			}
			set
			{
				this.partially_Recoverable_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Partially_Recoverable_PercentageSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Allocate_Non_Recoverable_Tax
		{
			get
			{
				return this.allocate_Non_Recoverable_TaxField;
			}
			set
			{
				this.allocate_Non_Recoverable_TaxField = value;
				this.RaisePropertyChanged("Allocate_Non_Recoverable_Tax");
			}
		}

		[XmlIgnore]
		public bool Allocate_Non_Recoverable_TaxSpecified
		{
			get
			{
				return this.allocate_Non_Recoverable_TaxFieldSpecified;
			}
			set
			{
				this.allocate_Non_Recoverable_TaxFieldSpecified = value;
				this.RaisePropertyChanged("Allocate_Non_Recoverable_TaxSpecified");
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
