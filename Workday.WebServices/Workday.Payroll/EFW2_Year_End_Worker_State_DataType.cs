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
	public class EFW2_Year_End_Worker_State_DataType : INotifyPropertyChanged
	{
		private string state_EINField;

		private string stateField;

		private string state_FIPS_CodeField;

		private decimal state_Taxable_WagesField;

		private bool state_Taxable_WagesFieldSpecified;

		private decimal state_Tax_WithheldField;

		private bool state_Tax_WithheldFieldSpecified;

		private EFW2_Year_End_Worker_Local_DataType[] eFW2_Year_End_Worker_Local_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string State_EIN
		{
			get
			{
				return this.state_EINField;
			}
			set
			{
				this.state_EINField = value;
				this.RaisePropertyChanged("State_EIN");
			}
		}

		[XmlElement(Order = 1)]
		public string State
		{
			get
			{
				return this.stateField;
			}
			set
			{
				this.stateField = value;
				this.RaisePropertyChanged("State");
			}
		}

		[XmlElement(Order = 2)]
		public string State_FIPS_Code
		{
			get
			{
				return this.state_FIPS_CodeField;
			}
			set
			{
				this.state_FIPS_CodeField = value;
				this.RaisePropertyChanged("State_FIPS_Code");
			}
		}

		[XmlElement(Order = 3)]
		public decimal State_Taxable_Wages
		{
			get
			{
				return this.state_Taxable_WagesField;
			}
			set
			{
				this.state_Taxable_WagesField = value;
				this.RaisePropertyChanged("State_Taxable_Wages");
			}
		}

		[XmlIgnore]
		public bool State_Taxable_WagesSpecified
		{
			get
			{
				return this.state_Taxable_WagesFieldSpecified;
			}
			set
			{
				this.state_Taxable_WagesFieldSpecified = value;
				this.RaisePropertyChanged("State_Taxable_WagesSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal State_Tax_Withheld
		{
			get
			{
				return this.state_Tax_WithheldField;
			}
			set
			{
				this.state_Tax_WithheldField = value;
				this.RaisePropertyChanged("State_Tax_Withheld");
			}
		}

		[XmlIgnore]
		public bool State_Tax_WithheldSpecified
		{
			get
			{
				return this.state_Tax_WithheldFieldSpecified;
			}
			set
			{
				this.state_Tax_WithheldFieldSpecified = value;
				this.RaisePropertyChanged("State_Tax_WithheldSpecified");
			}
		}

		[XmlElement("EFW2_Year_End_Worker_Local_Data", Order = 5)]
		public EFW2_Year_End_Worker_Local_DataType[] EFW2_Year_End_Worker_Local_Data
		{
			get
			{
				return this.eFW2_Year_End_Worker_Local_DataField;
			}
			set
			{
				this.eFW2_Year_End_Worker_Local_DataField = value;
				this.RaisePropertyChanged("EFW2_Year_End_Worker_Local_Data");
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
