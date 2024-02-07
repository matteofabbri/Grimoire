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
	public class Tax_Rate_Application_DataType : INotifyPropertyChanged
	{
		private Tax_RateObjectType tax_Rate_ReferenceField;

		private decimal taxable_AmountField;

		private bool taxable_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_RateObjectType Tax_Rate_Reference
		{
			get
			{
				return this.tax_Rate_ReferenceField;
			}
			set
			{
				this.tax_Rate_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Rate_Reference");
			}
		}

		[XmlElement(Order = 1)]
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
