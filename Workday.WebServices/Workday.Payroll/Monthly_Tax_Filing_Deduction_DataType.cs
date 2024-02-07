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
	public class Monthly_Tax_Filing_Deduction_DataType : INotifyPropertyChanged
	{
		private Payroll_CalculationObjectType deduction_ReferenceField;

		private Metadata_Payroll_WorktagObjectType[] payroll_Tax_Authority_ReferenceField;

		private string tax_Filing_CodeField;

		private MTD_Tax_Filing_DataType mTD_DataField;

		private YTD_Tax_Filing_DataType yTD_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payroll_CalculationObjectType Deduction_Reference
		{
			get
			{
				return this.deduction_ReferenceField;
			}
			set
			{
				this.deduction_ReferenceField = value;
				this.RaisePropertyChanged("Deduction_Reference");
			}
		}

		[XmlElement("Payroll_Tax_Authority_Reference", Order = 1)]
		public Metadata_Payroll_WorktagObjectType[] Payroll_Tax_Authority_Reference
		{
			get
			{
				return this.payroll_Tax_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Tax_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Tax_Authority_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Tax_Filing_Code
		{
			get
			{
				return this.tax_Filing_CodeField;
			}
			set
			{
				this.tax_Filing_CodeField = value;
				this.RaisePropertyChanged("Tax_Filing_Code");
			}
		}

		[XmlElement(Order = 3)]
		public MTD_Tax_Filing_DataType MTD_Data
		{
			get
			{
				return this.mTD_DataField;
			}
			set
			{
				this.mTD_DataField = value;
				this.RaisePropertyChanged("MTD_Data");
			}
		}

		[XmlElement(Order = 4)]
		public YTD_Tax_Filing_DataType YTD_Data
		{
			get
			{
				return this.yTD_DataField;
			}
			set
			{
				this.yTD_DataField = value;
				this.RaisePropertyChanged("YTD_Data");
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
