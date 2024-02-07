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
	public class Edit_Service_Dates_Event_DataType : INotifyPropertyChanged
	{
		private DateTime original_Hire_DateField;

		private bool original_Hire_DateFieldSpecified;

		private DateTime continuous_Service_DateField;

		private bool continuous_Service_DateFieldSpecified;

		private DateTime expected_Retirement_DateField;

		private bool expected_Retirement_DateFieldSpecified;

		private DateTime retirement_Eligibility_DateField;

		private bool retirement_Eligibility_DateFieldSpecified;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private DateTime seniority_DateField;

		private bool seniority_DateFieldSpecified;

		private DateTime severance_DateField;

		private bool severance_DateFieldSpecified;

		private DateTime contract_End_DateField;

		private bool contract_End_DateFieldSpecified;

		private DateTime benefits_Service_DateField;

		private bool benefits_Service_DateFieldSpecified;

		private DateTime company_Service_DateField;

		private bool company_Service_DateFieldSpecified;

		private DateTime time_Off_Service_DateField;

		private bool time_Off_Service_DateFieldSpecified;

		private DateTime vesting_DateField;

		private bool vesting_DateFieldSpecified;

		private DateTime date_Entered_WorkforceField;

		private bool date_Entered_WorkforceFieldSpecified;

		private decimal days_UnemployedField;

		private bool days_UnemployedFieldSpecified;

		private decimal months_Continuous_Prior_EmploymentField;

		private bool months_Continuous_Prior_EmploymentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Original_Hire_Date
		{
			get
			{
				return this.original_Hire_DateField;
			}
			set
			{
				this.original_Hire_DateField = value;
				this.RaisePropertyChanged("Original_Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Hire_DateSpecified
		{
			get
			{
				return this.original_Hire_DateFieldSpecified;
			}
			set
			{
				this.original_Hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Hire_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Continuous_Service_Date
		{
			get
			{
				return this.continuous_Service_DateField;
			}
			set
			{
				this.continuous_Service_DateField = value;
				this.RaisePropertyChanged("Continuous_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Continuous_Service_DateSpecified
		{
			get
			{
				return this.continuous_Service_DateFieldSpecified;
			}
			set
			{
				this.continuous_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Continuous_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Expected_Retirement_Date
		{
			get
			{
				return this.expected_Retirement_DateField;
			}
			set
			{
				this.expected_Retirement_DateField = value;
				this.RaisePropertyChanged("Expected_Retirement_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Retirement_DateSpecified
		{
			get
			{
				return this.expected_Retirement_DateFieldSpecified;
			}
			set
			{
				this.expected_Retirement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Retirement_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Retirement_Eligibility_Date
		{
			get
			{
				return this.retirement_Eligibility_DateField;
			}
			set
			{
				this.retirement_Eligibility_DateField = value;
				this.RaisePropertyChanged("Retirement_Eligibility_Date");
			}
		}

		[XmlIgnore]
		public bool Retirement_Eligibility_DateSpecified
		{
			get
			{
				return this.retirement_Eligibility_DateFieldSpecified;
			}
			set
			{
				this.retirement_Eligibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Retirement_Eligibility_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime End_Employment_Date
		{
			get
			{
				return this.end_Employment_DateField;
			}
			set
			{
				this.end_Employment_DateField = value;
				this.RaisePropertyChanged("End_Employment_Date");
			}
		}

		[XmlIgnore]
		public bool End_Employment_DateSpecified
		{
			get
			{
				return this.end_Employment_DateFieldSpecified;
			}
			set
			{
				this.end_Employment_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Employment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Seniority_Date
		{
			get
			{
				return this.seniority_DateField;
			}
			set
			{
				this.seniority_DateField = value;
				this.RaisePropertyChanged("Seniority_Date");
			}
		}

		[XmlIgnore]
		public bool Seniority_DateSpecified
		{
			get
			{
				return this.seniority_DateFieldSpecified;
			}
			set
			{
				this.seniority_DateFieldSpecified = value;
				this.RaisePropertyChanged("Seniority_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Severance_Date
		{
			get
			{
				return this.severance_DateField;
			}
			set
			{
				this.severance_DateField = value;
				this.RaisePropertyChanged("Severance_Date");
			}
		}

		[XmlIgnore]
		public bool Severance_DateSpecified
		{
			get
			{
				return this.severance_DateFieldSpecified;
			}
			set
			{
				this.severance_DateFieldSpecified = value;
				this.RaisePropertyChanged("Severance_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Contract_End_Date
		{
			get
			{
				return this.contract_End_DateField;
			}
			set
			{
				this.contract_End_DateField = value;
				this.RaisePropertyChanged("Contract_End_Date");
			}
		}

		[XmlIgnore]
		public bool Contract_End_DateSpecified
		{
			get
			{
				return this.contract_End_DateFieldSpecified;
			}
			set
			{
				this.contract_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Contract_End_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Benefits_Service_Date
		{
			get
			{
				return this.benefits_Service_DateField;
			}
			set
			{
				this.benefits_Service_DateField = value;
				this.RaisePropertyChanged("Benefits_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Benefits_Service_DateSpecified
		{
			get
			{
				return this.benefits_Service_DateFieldSpecified;
			}
			set
			{
				this.benefits_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Benefits_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Company_Service_Date
		{
			get
			{
				return this.company_Service_DateField;
			}
			set
			{
				this.company_Service_DateField = value;
				this.RaisePropertyChanged("Company_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Company_Service_DateSpecified
		{
			get
			{
				return this.company_Service_DateFieldSpecified;
			}
			set
			{
				this.company_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Company_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Time_Off_Service_Date
		{
			get
			{
				return this.time_Off_Service_DateField;
			}
			set
			{
				this.time_Off_Service_DateField = value;
				this.RaisePropertyChanged("Time_Off_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Time_Off_Service_DateSpecified
		{
			get
			{
				return this.time_Off_Service_DateFieldSpecified;
			}
			set
			{
				this.time_Off_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Vesting_Date
		{
			get
			{
				return this.vesting_DateField;
			}
			set
			{
				this.vesting_DateField = value;
				this.RaisePropertyChanged("Vesting_Date");
			}
		}

		[XmlIgnore]
		public bool Vesting_DateSpecified
		{
			get
			{
				return this.vesting_DateFieldSpecified;
			}
			set
			{
				this.vesting_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vesting_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Date_Entered_Workforce
		{
			get
			{
				return this.date_Entered_WorkforceField;
			}
			set
			{
				this.date_Entered_WorkforceField = value;
				this.RaisePropertyChanged("Date_Entered_Workforce");
			}
		}

		[XmlIgnore]
		public bool Date_Entered_WorkforceSpecified
		{
			get
			{
				return this.date_Entered_WorkforceFieldSpecified;
			}
			set
			{
				this.date_Entered_WorkforceFieldSpecified = value;
				this.RaisePropertyChanged("Date_Entered_WorkforceSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Days_Unemployed
		{
			get
			{
				return this.days_UnemployedField;
			}
			set
			{
				this.days_UnemployedField = value;
				this.RaisePropertyChanged("Days_Unemployed");
			}
		}

		[XmlIgnore]
		public bool Days_UnemployedSpecified
		{
			get
			{
				return this.days_UnemployedFieldSpecified;
			}
			set
			{
				this.days_UnemployedFieldSpecified = value;
				this.RaisePropertyChanged("Days_UnemployedSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Months_Continuous_Prior_Employment
		{
			get
			{
				return this.months_Continuous_Prior_EmploymentField;
			}
			set
			{
				this.months_Continuous_Prior_EmploymentField = value;
				this.RaisePropertyChanged("Months_Continuous_Prior_Employment");
			}
		}

		[XmlIgnore]
		public bool Months_Continuous_Prior_EmploymentSpecified
		{
			get
			{
				return this.months_Continuous_Prior_EmploymentFieldSpecified;
			}
			set
			{
				this.months_Continuous_Prior_EmploymentFieldSpecified = value;
				this.RaisePropertyChanged("Months_Continuous_Prior_EmploymentSpecified");
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
