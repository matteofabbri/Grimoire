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
	public class Merit_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private bool subject_to_Statutory_MinimumField;

		private bool subject_to_Statutory_MinimumFieldSpecified;

		private bool allow_Individual_TargetsField;

		private bool allow_Individual_TargetsFieldSpecified;

		private Compensation_MatrixObjectType compensation_Matrix_ReferenceField;

		private bool use_Matrix_As_Reference_OnlyField;

		private bool use_Matrix_As_Reference_OnlyFieldSpecified;

		private Eligibility_Waiting_PeriodObjectType waiting_Period_ReferenceField;

		private bool include_Active_Employees_in_Waiting_PeriodField;

		private bool include_Active_Employees_in_Waiting_PeriodFieldSpecified;

		private Time_Proration_RuleObjectType time_Proration_Rule_ReferenceField;

		private Compensation_Rounding_RuleObjectType rounding_Rule_ReferenceField;

		private bool include_Active_Employees_Assigned_Plan_During_Process_PeriodField;

		private bool include_Active_Employees_Assigned_Plan_During_Process_PeriodFieldSpecified;

		private Merit_Plan_Percent_DataType percent_DataField;

		private Merit_Plan_Amount_DataType amount_DataField;

		private bool hide_TargetField;

		private bool hide_TargetFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Setup_Security_Segment_Reference", Order = 0)]
		public Compensation_Setup_Security_SegmentObjectType[] Setup_Security_Segment_Reference
		{
			get
			{
				return this.setup_Security_Segment_ReferenceField;
			}
			set
			{
				this.setup_Security_Segment_ReferenceField = value;
				this.RaisePropertyChanged("Setup_Security_Segment_Reference");
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

		[XmlElement(Order = 3)]
		public bool Subject_to_Statutory_Minimum
		{
			get
			{
				return this.subject_to_Statutory_MinimumField;
			}
			set
			{
				this.subject_to_Statutory_MinimumField = value;
				this.RaisePropertyChanged("Subject_to_Statutory_Minimum");
			}
		}

		[XmlIgnore]
		public bool Subject_to_Statutory_MinimumSpecified
		{
			get
			{
				return this.subject_to_Statutory_MinimumFieldSpecified;
			}
			set
			{
				this.subject_to_Statutory_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Subject_to_Statutory_MinimumSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Allow_Individual_Targets
		{
			get
			{
				return this.allow_Individual_TargetsField;
			}
			set
			{
				this.allow_Individual_TargetsField = value;
				this.RaisePropertyChanged("Allow_Individual_Targets");
			}
		}

		[XmlIgnore]
		public bool Allow_Individual_TargetsSpecified
		{
			get
			{
				return this.allow_Individual_TargetsFieldSpecified;
			}
			set
			{
				this.allow_Individual_TargetsFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Individual_TargetsSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Compensation_MatrixObjectType Compensation_Matrix_Reference
		{
			get
			{
				return this.compensation_Matrix_ReferenceField;
			}
			set
			{
				this.compensation_Matrix_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Matrix_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Use_Matrix_As_Reference_Only
		{
			get
			{
				return this.use_Matrix_As_Reference_OnlyField;
			}
			set
			{
				this.use_Matrix_As_Reference_OnlyField = value;
				this.RaisePropertyChanged("Use_Matrix_As_Reference_Only");
			}
		}

		[XmlIgnore]
		public bool Use_Matrix_As_Reference_OnlySpecified
		{
			get
			{
				return this.use_Matrix_As_Reference_OnlyFieldSpecified;
			}
			set
			{
				this.use_Matrix_As_Reference_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Use_Matrix_As_Reference_OnlySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Eligibility_Waiting_PeriodObjectType Waiting_Period_Reference
		{
			get
			{
				return this.waiting_Period_ReferenceField;
			}
			set
			{
				this.waiting_Period_ReferenceField = value;
				this.RaisePropertyChanged("Waiting_Period_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Include_Active_Employees_in_Waiting_Period
		{
			get
			{
				return this.include_Active_Employees_in_Waiting_PeriodField;
			}
			set
			{
				this.include_Active_Employees_in_Waiting_PeriodField = value;
				this.RaisePropertyChanged("Include_Active_Employees_in_Waiting_Period");
			}
		}

		[XmlIgnore]
		public bool Include_Active_Employees_in_Waiting_PeriodSpecified
		{
			get
			{
				return this.include_Active_Employees_in_Waiting_PeriodFieldSpecified;
			}
			set
			{
				this.include_Active_Employees_in_Waiting_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Include_Active_Employees_in_Waiting_PeriodSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Time_Proration_RuleObjectType Time_Proration_Rule_Reference
		{
			get
			{
				return this.time_Proration_Rule_ReferenceField;
			}
			set
			{
				this.time_Proration_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Time_Proration_Rule_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Compensation_Rounding_RuleObjectType Rounding_Rule_Reference
		{
			get
			{
				return this.rounding_Rule_ReferenceField;
			}
			set
			{
				this.rounding_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Rounding_Rule_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public bool Include_Active_Employees_Assigned_Plan_During_Process_Period
		{
			get
			{
				return this.include_Active_Employees_Assigned_Plan_During_Process_PeriodField;
			}
			set
			{
				this.include_Active_Employees_Assigned_Plan_During_Process_PeriodField = value;
				this.RaisePropertyChanged("Include_Active_Employees_Assigned_Plan_During_Process_Period");
			}
		}

		[XmlIgnore]
		public bool Include_Active_Employees_Assigned_Plan_During_Process_PeriodSpecified
		{
			get
			{
				return this.include_Active_Employees_Assigned_Plan_During_Process_PeriodFieldSpecified;
			}
			set
			{
				this.include_Active_Employees_Assigned_Plan_During_Process_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Include_Active_Employees_Assigned_Plan_During_Process_PeriodSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public Merit_Plan_Percent_DataType Percent_Data
		{
			get
			{
				return this.percent_DataField;
			}
			set
			{
				this.percent_DataField = value;
				this.RaisePropertyChanged("Percent_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Merit_Plan_Amount_DataType Amount_Data
		{
			get
			{
				return this.amount_DataField;
			}
			set
			{
				this.amount_DataField = value;
				this.RaisePropertyChanged("Amount_Data");
			}
		}

		[XmlElement(Order = 14)]
		public bool Hide_Target
		{
			get
			{
				return this.hide_TargetField;
			}
			set
			{
				this.hide_TargetField = value;
				this.RaisePropertyChanged("Hide_Target");
			}
		}

		[XmlIgnore]
		public bool Hide_TargetSpecified
		{
			get
			{
				return this.hide_TargetFieldSpecified;
			}
			set
			{
				this.hide_TargetFieldSpecified = value;
				this.RaisePropertyChanged("Hide_TargetSpecified");
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
