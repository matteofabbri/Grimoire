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
	public class Percent_Value_DataType : INotifyPropertyChanged
	{
		private decimal percentField;

		private bool percentFieldSpecified;

		private decimal frequency_FactorField;

		private bool frequency_FactorFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Percent
		{
			get
			{
				return this.percentField;
			}
			set
			{
				this.percentField = value;
				this.RaisePropertyChanged("Percent");
			}
		}

		[XmlIgnore]
		public bool PercentSpecified
		{
			get
			{
				return this.percentFieldSpecified;
			}
			set
			{
				this.percentFieldSpecified = value;
				this.RaisePropertyChanged("PercentSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Frequency_Factor
		{
			get
			{
				return this.frequency_FactorField;
			}
			set
			{
				this.frequency_FactorField = value;
				this.RaisePropertyChanged("Frequency_Factor");
			}
		}

		[XmlIgnore]
		public bool Frequency_FactorSpecified
		{
			get
			{
				return this.frequency_FactorFieldSpecified;
			}
			set
			{
				this.frequency_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Frequency_FactorSpecified");
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
