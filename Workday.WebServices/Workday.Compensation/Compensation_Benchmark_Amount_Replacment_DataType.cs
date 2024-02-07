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
	public class Compensation_Benchmark_Amount_Replacment_DataType : INotifyPropertyChanged
	{
		private Compensation_Benchmark_PercentileObjectType percentile_ReferenceField;

		private decimal amountField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Benchmark_PercentileObjectType Percentile_Reference
		{
			get
			{
				return this.percentile_ReferenceField;
			}
			set
			{
				this.percentile_ReferenceField = value;
				this.RaisePropertyChanged("Percentile_Reference");
			}
		}

		[XmlElement(Order = 1)]
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
