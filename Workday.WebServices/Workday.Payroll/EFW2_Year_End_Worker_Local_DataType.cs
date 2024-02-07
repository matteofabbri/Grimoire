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
	public class EFW2_Year_End_Worker_Local_DataType : INotifyPropertyChanged
	{
		private string localityField;

		private string tax_Type_CodeField;

		private decimal local_Taxable_WagesField;

		private bool local_Taxable_WagesFieldSpecified;

		private decimal local_Tax_WithheldField;

		private bool local_Tax_WithheldFieldSpecified;

		private string other_InformationField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Locality
		{
			get
			{
				return this.localityField;
			}
			set
			{
				this.localityField = value;
				this.RaisePropertyChanged("Locality");
			}
		}

		[XmlElement(Order = 1)]
		public string Tax_Type_Code
		{
			get
			{
				return this.tax_Type_CodeField;
			}
			set
			{
				this.tax_Type_CodeField = value;
				this.RaisePropertyChanged("Tax_Type_Code");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Local_Taxable_Wages
		{
			get
			{
				return this.local_Taxable_WagesField;
			}
			set
			{
				this.local_Taxable_WagesField = value;
				this.RaisePropertyChanged("Local_Taxable_Wages");
			}
		}

		[XmlIgnore]
		public bool Local_Taxable_WagesSpecified
		{
			get
			{
				return this.local_Taxable_WagesFieldSpecified;
			}
			set
			{
				this.local_Taxable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("Local_Taxable_WagesSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Local_Tax_Withheld
		{
			get
			{
				return this.local_Tax_WithheldField;
			}
			set
			{
				this.local_Tax_WithheldField = value;
				this.RaisePropertyChanged("Local_Tax_Withheld");
			}
		}

		[XmlIgnore]
		public bool Local_Tax_WithheldSpecified
		{
			get
			{
				return this.local_Tax_WithheldFieldSpecified;
			}
			set
			{
				this.local_Tax_WithheldFieldSpecified = value;
				this.RaisePropertyChanged("Local_Tax_WithheldSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Other_Information
		{
			get
			{
				return this.other_InformationField;
			}
			set
			{
				this.other_InformationField = value;
				this.RaisePropertyChanged("Other_Information");
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
