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
	public class Bonus_Plan_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private Compensation_Setup_Security_SegmentObjectType[] setup_Security_Segment_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private bool allow_Individual_TargetsField;

		private bool allow_Individual_TargetsFieldSpecified;

		private Eligibility_Waiting_PeriodObjectType waiting_Period_ReferenceField;

		private Time_Proration_RuleObjectType time_Proration_Rule_ReferenceField;

		private bool include_Active_Employees_in_Waiting_PeriodField;

		private bool include_Active_Employees_in_Waiting_PeriodFieldSpecified;

		private Compensation_Rounding_RuleObjectType rounding_Rule_ReferenceField;

		private Default_ScorecardObjectType company_Performance_Scorecard_ReferenceField;

		private Default_ScorecardObjectType bonus_Modifier_ReferenceField;

		private bool include_Active_Employees_Assigned_Plan_During_Process_PeriodField;

		private bool include_Active_Employees_Assigned_Plan_During_Process_PeriodFieldSpecified;

		private object itemField;

		private Compensation_Tranche_Replacement_DataType[] compensation_Tranche_Replacement_DataField;

		private object item1Field;

		private bool hide_TargetField;

		private bool hide_TargetFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Pay_EarningObjectType Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement("Setup_Security_Segment_Reference", Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Default_ScorecardObjectType Company_Performance_Scorecard_Reference
		{
			get
			{
				return this.company_Performance_Scorecard_ReferenceField;
			}
			set
			{
				this.company_Performance_Scorecard_ReferenceField = value;
				this.RaisePropertyChanged("Company_Performance_Scorecard_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Default_ScorecardObjectType Bonus_Modifier_Reference
		{
			get
			{
				return this.bonus_Modifier_ReferenceField;
			}
			set
			{
				this.bonus_Modifier_ReferenceField = value;
				this.RaisePropertyChanged("Bonus_Modifier_Reference");
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

		[XmlElement("Performance_Factors_Data", typeof(Performance_Factors_DataType), Order = 12), XmlElement("Performance_Matrix_Data", typeof(Performance_Matrix_DataType), Order = 12)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Compensation_Tranche_Replacement_Data", Order = 13)]
		public Compensation_Tranche_Replacement_DataType[] Compensation_Tranche_Replacement_Data
		{
			get
			{
				return this.compensation_Tranche_Replacement_DataField;
			}
			set
			{
				this.compensation_Tranche_Replacement_DataField = value;
				this.RaisePropertyChanged("Compensation_Tranche_Replacement_Data");
			}
		}

		[XmlElement("Amount_Data", typeof(Bonus_Plan_Amount_DataType), Order = 14), XmlElement("Percent_Data", typeof(Bonus_Plan_Percent_DataType), Order = 14)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 15)]
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
