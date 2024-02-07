using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Annual_Contribution_DataType : INotifyPropertyChanged
	{
		private decimal annual_Contribution_AmountField;

		private decimal prior_Contribution_AmountField;

		private decimal remaining_PeriodsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Annual_Contribution_Amount
		{
			get
			{
				return this.annual_Contribution_AmountField;
			}
			set
			{
				this.annual_Contribution_AmountField = value;
				this.RaisePropertyChanged("Annual_Contribution_Amount");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Prior_Contribution_Amount
		{
			get
			{
				return this.prior_Contribution_AmountField;
			}
			set
			{
				this.prior_Contribution_AmountField = value;
				this.RaisePropertyChanged("Prior_Contribution_Amount");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Remaining_Periods
		{
			get
			{
				return this.remaining_PeriodsField;
			}
			set
			{
				this.remaining_PeriodsField = value;
				this.RaisePropertyChanged("Remaining_Periods");
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
