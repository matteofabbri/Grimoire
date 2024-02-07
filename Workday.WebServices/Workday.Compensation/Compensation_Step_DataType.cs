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
	public class Compensation_Step_DataType : INotifyPropertyChanged
	{
		private string compensation_Step_IDField;

		private string sequenceField;

		private string nameField;

		private decimal amountField;

		private decimal intervalField;

		private bool intervalFieldSpecified;

		private Frequency_BehaviorObjectType period_ReferenceField;

		private Condition_RuleObjectType progression_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Compensation_Step_ID
		{
			get
			{
				return this.compensation_Step_IDField;
			}
			set
			{
				this.compensation_Step_IDField = value;
				this.RaisePropertyChanged("Compensation_Step_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sequence
		{
			get
			{
				return this.sequenceField;
			}
			set
			{
				this.sequenceField = value;
				this.RaisePropertyChanged("Sequence");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Interval
		{
			get
			{
				return this.intervalField;
			}
			set
			{
				this.intervalField = value;
				this.RaisePropertyChanged("Interval");
			}
		}

		[XmlIgnore]
		public bool IntervalSpecified
		{
			get
			{
				return this.intervalFieldSpecified;
			}
			set
			{
				this.intervalFieldSpecified = value;
				this.RaisePropertyChanged("IntervalSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Frequency_BehaviorObjectType Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Condition_RuleObjectType Progression_Rule_Reference
		{
			get
			{
				return this.progression_Rule_ReferenceField;
			}
			set
			{
				this.progression_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Progression_Rule_Reference");
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
