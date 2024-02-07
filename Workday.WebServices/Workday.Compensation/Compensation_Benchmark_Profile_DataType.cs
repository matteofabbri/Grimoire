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
	public class Compensation_Benchmark_Profile_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType compensation_Eligibility_Rule_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Benchmark_Job_Composite_DataType[] benchmark_Job_Composite_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Compensation_Eligibility_Rule_Reference
		{
			get
			{
				return this.compensation_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.compensation_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Eligibility_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement("Benchmark_Job_Composite_Replacement_Data", Order = 3)]
		public Benchmark_Job_Composite_DataType[] Benchmark_Job_Composite_Replacement_Data
		{
			get
			{
				return this.benchmark_Job_Composite_Replacement_DataField;
			}
			set
			{
				this.benchmark_Job_Composite_Replacement_DataField = value;
				this.RaisePropertyChanged("Benchmark_Job_Composite_Replacement_Data");
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
