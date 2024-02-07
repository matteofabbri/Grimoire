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
	public class Payroll_Remittance_Total_DataType : INotifyPropertyChanged
	{
		private string labelField;

		private decimal current_PeriodField;

		private bool current_PeriodFieldSpecified;

		private decimal yTDField;

		private bool yTDFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
				this.RaisePropertyChanged("Label");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Current_Period
		{
			get
			{
				return this.current_PeriodField;
			}
			set
			{
				this.current_PeriodField = value;
				this.RaisePropertyChanged("Current_Period");
			}
		}

		[XmlIgnore]
		public bool Current_PeriodSpecified
		{
			get
			{
				return this.current_PeriodFieldSpecified;
			}
			set
			{
				this.current_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Current_PeriodSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal YTD
		{
			get
			{
				return this.yTDField;
			}
			set
			{
				this.yTDField = value;
				this.RaisePropertyChanged("YTD");
			}
		}

		[XmlIgnore]
		public bool YTDSpecified
		{
			get
			{
				return this.yTDFieldSpecified;
			}
			set
			{
				this.yTDFieldSpecified = value;
				this.RaisePropertyChanged("YTDSpecified");
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
