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
	public class Compensation_Matrix_Entry_Amount_Based_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType compensation_Entry_Target_Rule_ReferenceField;

		private Review_RatingObjectType performance_Evaluation_Rating_ReferenceField;

		private Pay_Range_QuartileObjectType quartile_Placement_ReferenceField;

		private RetentionObjectType retention_ReferenceField;

		private Compa_Ratio_Range_SegmentObjectType compa_Ratio_Range_Segment_ReferenceField;

		private Pay_Range_Segment_TypeObjectType pay_Range_Segment_ReferenceField;

		private PotentialObjectType potential_ReferenceField;

		private decimal minimum_AmountField;

		private bool minimum_AmountFieldSpecified;

		private decimal maximum_AmountField;

		private bool maximum_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Compensation_Entry_Target_Rule_Reference
		{
			get
			{
				return this.compensation_Entry_Target_Rule_ReferenceField;
			}
			set
			{
				this.compensation_Entry_Target_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Entry_Target_Rule_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Review_RatingObjectType Performance_Evaluation_Rating_Reference
		{
			get
			{
				return this.performance_Evaluation_Rating_ReferenceField;
			}
			set
			{
				this.performance_Evaluation_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Performance_Evaluation_Rating_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Pay_Range_QuartileObjectType Quartile_Placement_Reference
		{
			get
			{
				return this.quartile_Placement_ReferenceField;
			}
			set
			{
				this.quartile_Placement_ReferenceField = value;
				this.RaisePropertyChanged("Quartile_Placement_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public RetentionObjectType Retention_Reference
		{
			get
			{
				return this.retention_ReferenceField;
			}
			set
			{
				this.retention_ReferenceField = value;
				this.RaisePropertyChanged("Retention_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Compa_Ratio_Range_SegmentObjectType Compa_Ratio_Range_Segment_Reference
		{
			get
			{
				return this.compa_Ratio_Range_Segment_ReferenceField;
			}
			set
			{
				this.compa_Ratio_Range_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Compa_Ratio_Range_Segment_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Pay_Range_Segment_TypeObjectType Pay_Range_Segment_Reference
		{
			get
			{
				return this.pay_Range_Segment_ReferenceField;
			}
			set
			{
				this.pay_Range_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Range_Segment_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public PotentialObjectType Potential_Reference
		{
			get
			{
				return this.potential_ReferenceField;
			}
			set
			{
				this.potential_ReferenceField = value;
				this.RaisePropertyChanged("Potential_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Minimum_Amount
		{
			get
			{
				return this.minimum_AmountField;
			}
			set
			{
				this.minimum_AmountField = value;
				this.RaisePropertyChanged("Minimum_Amount");
			}
		}

		[XmlIgnore]
		public bool Minimum_AmountSpecified
		{
			get
			{
				return this.minimum_AmountFieldSpecified;
			}
			set
			{
				this.minimum_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_AmountSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Maximum_Amount
		{
			get
			{
				return this.maximum_AmountField;
			}
			set
			{
				this.maximum_AmountField = value;
				this.RaisePropertyChanged("Maximum_Amount");
			}
		}

		[XmlIgnore]
		public bool Maximum_AmountSpecified
		{
			get
			{
				return this.maximum_AmountFieldSpecified;
			}
			set
			{
				this.maximum_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_AmountSpecified");
			}
		}

		[XmlElement(Order = 9)]
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
