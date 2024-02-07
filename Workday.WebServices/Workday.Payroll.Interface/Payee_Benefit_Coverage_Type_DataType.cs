using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Benefit_Coverage_Type_DataType : INotifyPropertyChanged
	{
		private decimal frequency_Annual_FactorField;

		private bool frequency_Annual_FactorFieldSpecified;

		private Flex_Credit_Details_DataType[] flex_Credit_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Frequency_Annual_Factor
		{
			get
			{
				return this.frequency_Annual_FactorField;
			}
			set
			{
				this.frequency_Annual_FactorField = value;
				this.RaisePropertyChanged("Frequency_Annual_Factor");
			}
		}

		[XmlIgnore]
		public bool Frequency_Annual_FactorSpecified
		{
			get
			{
				return this.frequency_Annual_FactorFieldSpecified;
			}
			set
			{
				this.frequency_Annual_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Frequency_Annual_FactorSpecified");
			}
		}

		[XmlElement("Flex_Credit_Details_Data", Order = 1)]
		public Flex_Credit_Details_DataType[] Flex_Credit_Details_Data
		{
			get
			{
				return this.flex_Credit_Details_DataField;
			}
			set
			{
				this.flex_Credit_Details_DataField = value;
				this.RaisePropertyChanged("Flex_Credit_Details_Data");
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
