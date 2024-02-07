using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Bonus_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Bonus_PlanObjectType compensation_Plan_ReferenceField;

		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private decimal individual_Target_AmountField;

		private bool individual_Target_AmountFieldSpecified;

		private decimal default_Target_AmountField;

		private bool default_Target_AmountFieldSpecified;

		private decimal individual_Target_PercentField;

		private bool individual_Target_PercentFieldSpecified;

		private decimal default_Target_PercentField;

		private bool default_Target_PercentFieldSpecified;

		private bool guaranteed_MinimumField;

		private bool guaranteed_MinimumFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal percent_AssignedField;

		private bool percent_AssignedFieldSpecified;

		private DateTime assignment_Effective_DateField;

		private bool assignment_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Bonus_PlanObjectType Compensation_Plan_Reference
		{
			get
			{
				return this.compensation_Plan_ReferenceField;
			}
			set
			{
				this.compensation_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Individual_Target_Amount
		{
			get
			{
				return this.individual_Target_AmountField;
			}
			set
			{
				this.individual_Target_AmountField = value;
				this.RaisePropertyChanged("Individual_Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_AmountSpecified
		{
			get
			{
				return this.individual_Target_AmountFieldSpecified;
			}
			set
			{
				this.individual_Target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Default_Target_Amount
		{
			get
			{
				return this.default_Target_AmountField;
			}
			set
			{
				this.default_Target_AmountField = value;
				this.RaisePropertyChanged("Default_Target_Amount");
			}
		}

		[XmlIgnore]
		public bool Default_Target_AmountSpecified
		{
			get
			{
				return this.default_Target_AmountFieldSpecified;
			}
			set
			{
				this.default_Target_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Default_Target_AmountSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Individual_Target_Percent
		{
			get
			{
				return this.individual_Target_PercentField;
			}
			set
			{
				this.individual_Target_PercentField = value;
				this.RaisePropertyChanged("Individual_Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Individual_Target_PercentSpecified
		{
			get
			{
				return this.individual_Target_PercentFieldSpecified;
			}
			set
			{
				this.individual_Target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Individual_Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Default_Target_Percent
		{
			get
			{
				return this.default_Target_PercentField;
			}
			set
			{
				this.default_Target_PercentField = value;
				this.RaisePropertyChanged("Default_Target_Percent");
			}
		}

		[XmlIgnore]
		public bool Default_Target_PercentSpecified
		{
			get
			{
				return this.default_Target_PercentFieldSpecified;
			}
			set
			{
				this.default_Target_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Default_Target_PercentSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Guaranteed_Minimum
		{
			get
			{
				return this.guaranteed_MinimumField;
			}
			set
			{
				this.guaranteed_MinimumField = value;
				this.RaisePropertyChanged("Guaranteed_Minimum");
			}
		}

		[XmlIgnore]
		public bool Guaranteed_MinimumSpecified
		{
			get
			{
				return this.guaranteed_MinimumFieldSpecified;
			}
			set
			{
				this.guaranteed_MinimumFieldSpecified = value;
				this.RaisePropertyChanged("Guaranteed_MinimumSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Percent_Assigned
		{
			get
			{
				return this.percent_AssignedField;
			}
			set
			{
				this.percent_AssignedField = value;
				this.RaisePropertyChanged("Percent_Assigned");
			}
		}

		[XmlIgnore]
		public bool Percent_AssignedSpecified
		{
			get
			{
				return this.percent_AssignedFieldSpecified;
			}
			set
			{
				this.percent_AssignedFieldSpecified = value;
				this.RaisePropertyChanged("Percent_AssignedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Assignment_Effective_Date
		{
			get
			{
				return this.assignment_Effective_DateField;
			}
			set
			{
				this.assignment_Effective_DateField = value;
				this.RaisePropertyChanged("Assignment_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_Effective_DateSpecified
		{
			get
			{
				return this.assignment_Effective_DateFieldSpecified;
			}
			set
			{
				this.assignment_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_Effective_DateSpecified");
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
