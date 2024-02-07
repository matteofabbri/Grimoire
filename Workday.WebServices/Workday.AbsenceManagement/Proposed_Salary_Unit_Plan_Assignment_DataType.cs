using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AbsenceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Proposed_Salary_Unit_Plan_Assignment_DataType : INotifyPropertyChanged
	{
		private Salary_Unit_PlanObjectType unit_Salary_Plan_ReferenceField;

		private decimal per_Unit_AmountField;

		private bool per_Unit_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal default_UnitsField;

		private bool default_UnitsFieldSpecified;

		private FrequencyObjectType frequency_ReferenceField;

		private DateTime actual_End_DateField;

		private bool actual_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Salary_Unit_PlanObjectType Unit_Salary_Plan_Reference
		{
			get
			{
				return this.unit_Salary_Plan_ReferenceField;
			}
			set
			{
				this.unit_Salary_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Salary_Plan_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Per_Unit_Amount
		{
			get
			{
				return this.per_Unit_AmountField;
			}
			set
			{
				this.per_Unit_AmountField = value;
				this.RaisePropertyChanged("Per_Unit_Amount");
			}
		}

		[XmlIgnore]
		public bool Per_Unit_AmountSpecified
		{
			get
			{
				return this.per_Unit_AmountFieldSpecified;
			}
			set
			{
				this.per_Unit_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Per_Unit_AmountSpecified");
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
		public decimal Default_Units
		{
			get
			{
				return this.default_UnitsField;
			}
			set
			{
				this.default_UnitsField = value;
				this.RaisePropertyChanged("Default_Units");
			}
		}

		[XmlIgnore]
		public bool Default_UnitsSpecified
		{
			get
			{
				return this.default_UnitsFieldSpecified;
			}
			set
			{
				this.default_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Default_UnitsSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Actual_End_Date
		{
			get
			{
				return this.actual_End_DateField;
			}
			set
			{
				this.actual_End_DateField = value;
				this.RaisePropertyChanged("Actual_End_Date");
			}
		}

		[XmlIgnore]
		public bool Actual_End_DateSpecified
		{
			get
			{
				return this.actual_End_DateFieldSpecified;
			}
			set
			{
				this.actual_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Actual_End_DateSpecified");
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
