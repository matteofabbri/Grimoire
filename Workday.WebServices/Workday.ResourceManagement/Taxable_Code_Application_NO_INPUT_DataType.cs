using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Taxable_Code_Application_NO_INPUT_DataType : INotifyPropertyChanged
	{
		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private decimal taxable_AmountField;

		private bool taxable_AmountFieldSpecified;

		private Tax_Rate_Application_DataType[] tax_Rate_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Taxable_Amount
		{
			get
			{
				return this.taxable_AmountField;
			}
			set
			{
				this.taxable_AmountField = value;
				this.RaisePropertyChanged("Taxable_Amount");
			}
		}

		[XmlIgnore]
		public bool Taxable_AmountSpecified
		{
			get
			{
				return this.taxable_AmountFieldSpecified;
			}
			set
			{
				this.taxable_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Taxable_AmountSpecified");
			}
		}

		[XmlElement("Tax_Rate_Data", Order = 3)]
		public Tax_Rate_Application_DataType[] Tax_Rate_Data
		{
			get
			{
				return this.tax_Rate_DataField;
			}
			set
			{
				this.tax_Rate_DataField = value;
				this.RaisePropertyChanged("Tax_Rate_Data");
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
