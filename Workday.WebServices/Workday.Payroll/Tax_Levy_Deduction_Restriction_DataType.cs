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
	public class Tax_Levy_Deduction_Restriction_DataType : INotifyPropertyChanged
	{
		private string withholding_Order_IDField;

		private bool lock_Tax_ElectionsField;

		private bool lock_Tax_ElectionsFieldSpecified;

		private Tax_Levy_Deduction_for_Baseline_DataType[] baseline_Deduction_Restriction_DataField;

		private Tax_Levy_Deduction_for_Override_DataType[] override_Deduction_Restriction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Withholding_Order_ID
		{
			get
			{
				return this.withholding_Order_IDField;
			}
			set
			{
				this.withholding_Order_IDField = value;
				this.RaisePropertyChanged("Withholding_Order_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Lock_Tax_Elections
		{
			get
			{
				return this.lock_Tax_ElectionsField;
			}
			set
			{
				this.lock_Tax_ElectionsField = value;
				this.RaisePropertyChanged("Lock_Tax_Elections");
			}
		}

		[XmlIgnore]
		public bool Lock_Tax_ElectionsSpecified
		{
			get
			{
				return this.lock_Tax_ElectionsFieldSpecified;
			}
			set
			{
				this.lock_Tax_ElectionsFieldSpecified = value;
				this.RaisePropertyChanged("Lock_Tax_ElectionsSpecified");
			}
		}

		[XmlArray(Order = 2), XmlArrayItem("Baseline_Data", IsNullable = false)]
		public Tax_Levy_Deduction_for_Baseline_DataType[] Baseline_Deduction_Restriction_Data
		{
			get
			{
				return this.baseline_Deduction_Restriction_DataField;
			}
			set
			{
				this.baseline_Deduction_Restriction_DataField = value;
				this.RaisePropertyChanged("Baseline_Deduction_Restriction_Data");
			}
		}

		[XmlArray(Order = 3), XmlArrayItem("Override_Data", IsNullable = false)]
		public Tax_Levy_Deduction_for_Override_DataType[] Override_Deduction_Restriction_Data
		{
			get
			{
				return this.override_Deduction_Restriction_DataField;
			}
			set
			{
				this.override_Deduction_Restriction_DataField = value;
				this.RaisePropertyChanged("Override_Deduction_Restriction_Data");
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
