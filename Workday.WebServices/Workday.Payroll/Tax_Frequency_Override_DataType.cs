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
	public class Tax_Frequency_Override_DataType : INotifyPropertyChanged
	{
		private decimal tax_Frequency_ValueField;

		private bool tax_Frequency_ValueFieldSpecified;

		private Time_Unit_for_AnnualizationObjectType tax_Frequency_Period_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Tax_Frequency_Value
		{
			get
			{
				return this.tax_Frequency_ValueField;
			}
			set
			{
				this.tax_Frequency_ValueField = value;
				this.RaisePropertyChanged("Tax_Frequency_Value");
			}
		}

		[XmlIgnore]
		public bool Tax_Frequency_ValueSpecified
		{
			get
			{
				return this.tax_Frequency_ValueFieldSpecified;
			}
			set
			{
				this.tax_Frequency_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Tax_Frequency_ValueSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Time_Unit_for_AnnualizationObjectType Tax_Frequency_Period_Reference
		{
			get
			{
				return this.tax_Frequency_Period_ReferenceField;
			}
			set
			{
				this.tax_Frequency_Period_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Frequency_Period_Reference");
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
