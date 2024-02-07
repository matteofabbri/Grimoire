using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.BenefitsAdministration
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class As_Of_Date_DataType : INotifyPropertyChanged
	{
		private decimal specific_MonthField;

		private bool specific_MonthFieldSpecified;

		private decimal specific_DayField;

		private bool specific_DayFieldSpecified;

		private bool of_Prior_Plan_YearField;

		private bool of_Prior_Plan_YearFieldSpecified;

		private Benefit_As_Of_RuleObjectType benefit_As_Of_Rule_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Specific_Month
		{
			get
			{
				return this.specific_MonthField;
			}
			set
			{
				this.specific_MonthField = value;
				this.RaisePropertyChanged("Specific_Month");
			}
		}

		[XmlIgnore]
		public bool Specific_MonthSpecified
		{
			get
			{
				return this.specific_MonthFieldSpecified;
			}
			set
			{
				this.specific_MonthFieldSpecified = value;
				this.RaisePropertyChanged("Specific_MonthSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Specific_Day
		{
			get
			{
				return this.specific_DayField;
			}
			set
			{
				this.specific_DayField = value;
				this.RaisePropertyChanged("Specific_Day");
			}
		}

		[XmlIgnore]
		public bool Specific_DaySpecified
		{
			get
			{
				return this.specific_DayFieldSpecified;
			}
			set
			{
				this.specific_DayFieldSpecified = value;
				this.RaisePropertyChanged("Specific_DaySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Of_Prior_Plan_Year
		{
			get
			{
				return this.of_Prior_Plan_YearField;
			}
			set
			{
				this.of_Prior_Plan_YearField = value;
				this.RaisePropertyChanged("Of_Prior_Plan_Year");
			}
		}

		[XmlIgnore]
		public bool Of_Prior_Plan_YearSpecified
		{
			get
			{
				return this.of_Prior_Plan_YearFieldSpecified;
			}
			set
			{
				this.of_Prior_Plan_YearFieldSpecified = value;
				this.RaisePropertyChanged("Of_Prior_Plan_YearSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Benefit_As_Of_RuleObjectType Benefit_As_Of_Rule_Reference
		{
			get
			{
				return this.benefit_As_Of_Rule_ReferenceField;
			}
			set
			{
				this.benefit_As_Of_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Benefit_As_Of_Rule_Reference");
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
