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
	public class Compensation_Matrix_Entry_Percent_Based_DataType : INotifyPropertyChanged
	{
		private Condition_RuleObjectType compensation_Matrix_Entry_Eligibility_Rule_ReferenceField;

		private Review_RatingObjectType performance_Evaluation_Rating_ReferenceField;

		private Pay_Range_QuartileObjectType quartile_Placement_ReferenceField;

		private RetentionObjectType retention_ReferenceField;

		private Compa_Ratio_Range_SegmentObjectType compa_Ratio_Range_Segment_ReferenceField;

		private Pay_Range_Segment_TypeObjectType pay_Range_Segment_ReferenceField;

		private PotentialObjectType potential_ReferenceField;

		private decimal minimum_PercentField;

		private bool minimum_PercentFieldSpecified;

		private decimal maximum_PercentField;

		private bool maximum_PercentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Condition_RuleObjectType Compensation_Matrix_Entry_Eligibility_Rule_Reference
		{
			get
			{
				return this.compensation_Matrix_Entry_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_Entry_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Entry_Eligibility_Rule_Reference");
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
		public decimal Minimum_Percent
		{
			get
			{
				return this.minimum_PercentField;
			}
			set
			{
				this.minimum_PercentField = value;
				this.RaisePropertyChanged("Minimum_Percent");
			}
		}

		[XmlIgnore]
		public bool Minimum_PercentSpecified
		{
			get
			{
				return this.minimum_PercentFieldSpecified;
			}
			set
			{
				this.minimum_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_PercentSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Maximum_Percent
		{
			get
			{
				return this.maximum_PercentField;
			}
			set
			{
				this.maximum_PercentField = value;
				this.RaisePropertyChanged("Maximum_Percent");
			}
		}

		[XmlIgnore]
		public bool Maximum_PercentSpecified
		{
			get
			{
				return this.maximum_PercentFieldSpecified;
			}
			set
			{
				this.maximum_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_PercentSpecified");
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
