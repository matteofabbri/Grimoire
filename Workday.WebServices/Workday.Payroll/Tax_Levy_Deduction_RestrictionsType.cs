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
	public class Tax_Levy_Deduction_RestrictionsType : INotifyPropertyChanged
	{
		private Tax_LevyObjectType tax_Levy_ReferenceField;

		private Tax_Levy_Deduction_Restriction_DataType[] tax_Levy_Deduction_Restriction_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Tax_LevyObjectType Tax_Levy_Reference
		{
			get
			{
				return this.tax_Levy_ReferenceField;
			}
			set
			{
				this.tax_Levy_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Levy_Reference");
			}
		}

		[XmlElement("Tax_Levy_Deduction_Restriction_Data", Order = 1)]
		public Tax_Levy_Deduction_Restriction_DataType[] Tax_Levy_Deduction_Restriction_Data
		{
			get
			{
				return this.tax_Levy_Deduction_Restriction_DataField;
			}
			set
			{
				this.tax_Levy_Deduction_Restriction_DataField = value;
				this.RaisePropertyChanged("Tax_Levy_Deduction_Restriction_Data");
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
