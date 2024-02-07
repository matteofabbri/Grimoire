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
	public class Canadian_Record_of_Employment_Insurable_Earnings_By_Period_DataType : INotifyPropertyChanged
	{
		private decimal payroll_ROE_Period_NumberField;

		private decimal eI_Earning_ValueField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Payroll_ROE_Period_Number
		{
			get
			{
				return this.payroll_ROE_Period_NumberField;
			}
			set
			{
				this.payroll_ROE_Period_NumberField = value;
				this.RaisePropertyChanged("Payroll_ROE_Period_Number");
			}
		}

		[XmlElement(Order = 1)]
		public decimal EI_Earning_Value
		{
			get
			{
				return this.eI_Earning_ValueField;
			}
			set
			{
				this.eI_Earning_ValueField = value;
				this.RaisePropertyChanged("EI_Earning_Value");
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
