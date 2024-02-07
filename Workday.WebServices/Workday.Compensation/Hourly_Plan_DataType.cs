using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Hourly_Plan_DataType : INotifyPropertyChanged
	{
		private decimal amountField;

		private bool amountFieldSpecified;

		private bool minimum_WageField;

		private bool minimum_WageFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Amount
		{
			get
			{
				return this.amountField;
			}
			set
			{
				this.amountField = value;
				this.RaisePropertyChanged("Amount");
			}
		}

		[XmlIgnore]
		public bool AmountSpecified
		{
			get
			{
				return this.amountFieldSpecified;
			}
			set
			{
				this.amountFieldSpecified = value;
				this.RaisePropertyChanged("AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Minimum_Wage
		{
			get
			{
				return this.minimum_WageField;
			}
			set
			{
				this.minimum_WageField = value;
				this.RaisePropertyChanged("Minimum_Wage");
			}
		}

		[XmlIgnore]
		public bool Minimum_WageSpecified
		{
			get
			{
				return this.minimum_WageFieldSpecified;
			}
			set
			{
				this.minimum_WageFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_WageSpecified");
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
