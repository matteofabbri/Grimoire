using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Employee_Period_Salary_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Period_Salary_PlanObjectType compensation_Plan_ReferenceField;

		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private Compensation_PeriodObjectType compensation_Period_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal compensation_Period_MultiplierField;

		private bool compensation_Period_MultiplierFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private DateTime assignment_Effective_DateField;

		private bool assignment_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Period_Salary_PlanObjectType Compensation_Plan_Reference
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
		public Compensation_PeriodObjectType Compensation_Period_Reference
		{
			get
			{
				return this.compensation_Period_ReferenceField;
			}
			set
			{
				this.compensation_Period_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Period_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Compensation_Period_Multiplier
		{
			get
			{
				return this.compensation_Period_MultiplierField;
			}
			set
			{
				this.compensation_Period_MultiplierField = value;
				this.RaisePropertyChanged("Compensation_Period_Multiplier");
			}
		}

		[XmlIgnore]
		public bool Compensation_Period_MultiplierSpecified
		{
			get
			{
				return this.compensation_Period_MultiplierFieldSpecified;
			}
			set
			{
				this.compensation_Period_MultiplierFieldSpecified = value;
				this.RaisePropertyChanged("Compensation_Period_MultiplierSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
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
