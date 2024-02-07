using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.WorkforcePlanning
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Headcount_Plan_Entry_Detail_DataType : INotifyPropertyChanged
	{
		private decimal headcount_AmountField;

		private bool headcount_AmountFieldSpecified;

		private decimal fTE_AmountField;

		private bool fTE_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Headcount_Amount
		{
			get
			{
				return this.headcount_AmountField;
			}
			set
			{
				this.headcount_AmountField = value;
				this.RaisePropertyChanged("Headcount_Amount");
			}
		}

		[XmlIgnore]
		public bool Headcount_AmountSpecified
		{
			get
			{
				return this.headcount_AmountFieldSpecified;
			}
			set
			{
				this.headcount_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Headcount_AmountSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal FTE_Amount
		{
			get
			{
				return this.fTE_AmountField;
			}
			set
			{
				this.fTE_AmountField = value;
				this.RaisePropertyChanged("FTE_Amount");
			}
		}

		[XmlIgnore]
		public bool FTE_AmountSpecified
		{
			get
			{
				return this.fTE_AmountFieldSpecified;
			}
			set
			{
				this.fTE_AmountFieldSpecified = value;
				this.RaisePropertyChanged("FTE_AmountSpecified");
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
