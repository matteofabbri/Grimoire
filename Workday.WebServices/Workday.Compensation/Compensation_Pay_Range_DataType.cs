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
	public class Compensation_Pay_Range_DataType : INotifyPropertyChanged
	{
		private decimal number_of_SegmentsField;

		private bool number_of_SegmentsFieldSpecified;

		private decimal minimumField;

		private bool minimumFieldSpecified;

		private decimal midpointField;

		private bool midpointFieldSpecified;

		private decimal maximumField;

		private bool maximumFieldSpecified;

		private decimal spreadField;

		private bool spreadFieldSpecified;

		private decimal segment_1_TopField;

		private bool segment_1_TopFieldSpecified;

		private decimal segment_2_TopField;

		private bool segment_2_TopFieldSpecified;

		private decimal segment_3_TopField;

		private bool segment_3_TopFieldSpecified;

		private decimal segment_4_TopField;

		private bool segment_4_TopFieldSpecified;

		private decimal segment_5_TopField;

		private bool segment_5_TopFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Salary_Pay_PlanObjectType salary_Plan_ReferenceField;

		private bool allow_OverrideField;

		private bool allow_OverrideFieldSpecified;

		private Compensation_StepType[] compensation_StepField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Number_of_Segments
		{
			get
			{
				return this.number_of_SegmentsField;
			}
			set
			{
				this.number_of_SegmentsField = value;
				this.RaisePropertyChanged("Number_of_Segments");
			}
		}

		[XmlIgnore]
		public bool Number_of_SegmentsSpecified
		{
			get
			{
				return this.number_of_SegmentsFieldSpecified;
			}
			set
			{
				this.number_of_SegmentsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_SegmentsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Minimum
		{
			get
			{
				return this.minimumField;
			}
			set
			{
				this.minimumField = value;
				this.RaisePropertyChanged("Minimum");
			}
		}

		[XmlIgnore]
		public bool MinimumSpecified
		{
			get
			{
				return this.minimumFieldSpecified;
			}
			set
			{
				this.minimumFieldSpecified = value;
				this.RaisePropertyChanged("MinimumSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Midpoint
		{
			get
			{
				return this.midpointField;
			}
			set
			{
				this.midpointField = value;
				this.RaisePropertyChanged("Midpoint");
			}
		}

		[XmlIgnore]
		public bool MidpointSpecified
		{
			get
			{
				return this.midpointFieldSpecified;
			}
			set
			{
				this.midpointFieldSpecified = value;
				this.RaisePropertyChanged("MidpointSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Maximum
		{
			get
			{
				return this.maximumField;
			}
			set
			{
				this.maximumField = value;
				this.RaisePropertyChanged("Maximum");
			}
		}

		[XmlIgnore]
		public bool MaximumSpecified
		{
			get
			{
				return this.maximumFieldSpecified;
			}
			set
			{
				this.maximumFieldSpecified = value;
				this.RaisePropertyChanged("MaximumSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Spread
		{
			get
			{
				return this.spreadField;
			}
			set
			{
				this.spreadField = value;
				this.RaisePropertyChanged("Spread");
			}
		}

		[XmlIgnore]
		public bool SpreadSpecified
		{
			get
			{
				return this.spreadFieldSpecified;
			}
			set
			{
				this.spreadFieldSpecified = value;
				this.RaisePropertyChanged("SpreadSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Segment_1_Top
		{
			get
			{
				return this.segment_1_TopField;
			}
			set
			{
				this.segment_1_TopField = value;
				this.RaisePropertyChanged("Segment_1_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_1_TopSpecified
		{
			get
			{
				return this.segment_1_TopFieldSpecified;
			}
			set
			{
				this.segment_1_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_1_TopSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Segment_2_Top
		{
			get
			{
				return this.segment_2_TopField;
			}
			set
			{
				this.segment_2_TopField = value;
				this.RaisePropertyChanged("Segment_2_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_2_TopSpecified
		{
			get
			{
				return this.segment_2_TopFieldSpecified;
			}
			set
			{
				this.segment_2_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_2_TopSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Segment_3_Top
		{
			get
			{
				return this.segment_3_TopField;
			}
			set
			{
				this.segment_3_TopField = value;
				this.RaisePropertyChanged("Segment_3_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_3_TopSpecified
		{
			get
			{
				return this.segment_3_TopFieldSpecified;
			}
			set
			{
				this.segment_3_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_3_TopSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Segment_4_Top
		{
			get
			{
				return this.segment_4_TopField;
			}
			set
			{
				this.segment_4_TopField = value;
				this.RaisePropertyChanged("Segment_4_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_4_TopSpecified
		{
			get
			{
				return this.segment_4_TopFieldSpecified;
			}
			set
			{
				this.segment_4_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_4_TopSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Segment_5_Top
		{
			get
			{
				return this.segment_5_TopField;
			}
			set
			{
				this.segment_5_TopField = value;
				this.RaisePropertyChanged("Segment_5_Top");
			}
		}

		[XmlIgnore]
		public bool Segment_5_TopSpecified
		{
			get
			{
				return this.segment_5_TopFieldSpecified;
			}
			set
			{
				this.segment_5_TopFieldSpecified = value;
				this.RaisePropertyChanged("Segment_5_TopSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Salary_Pay_PlanObjectType Salary_Plan_Reference
		{
			get
			{
				return this.salary_Plan_ReferenceField;
			}
			set
			{
				this.salary_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Salary_Plan_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public bool Allow_Override
		{
			get
			{
				return this.allow_OverrideField;
			}
			set
			{
				this.allow_OverrideField = value;
				this.RaisePropertyChanged("Allow_Override");
			}
		}

		[XmlIgnore]
		public bool Allow_OverrideSpecified
		{
			get
			{
				return this.allow_OverrideFieldSpecified;
			}
			set
			{
				this.allow_OverrideFieldSpecified = value;
				this.RaisePropertyChanged("Allow_OverrideSpecified");
			}
		}

		[XmlElement("Compensation_Step", Order = 14)]
		public Compensation_StepType[] Compensation_Step
		{
			get
			{
				return this.compensation_StepField;
			}
			set
			{
				this.compensation_StepField = value;
				this.RaisePropertyChanged("Compensation_Step");
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
