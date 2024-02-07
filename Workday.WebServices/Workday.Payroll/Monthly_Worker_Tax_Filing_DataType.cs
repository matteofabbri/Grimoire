using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Monthly_Worker_Tax_Filing_DataType : INotifyPropertyChanged
	{
		private WorkerObjectType worker_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Calendar_YearObjectType calendar_Year_ReferenceField;

		private MonthObjectType month_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal weeks_WorkedField;

		private bool weeks_WorkedFieldSpecified;

		private decimal hours_WorkedField;

		private bool hours_WorkedFieldSpecified;

		private bool seasonal_WorkerField;

		private bool seasonal_WorkerFieldSpecified;

		private bool corporate_OfficerField;

		private bool corporate_OfficerFieldSpecified;

		private Worker_Payroll_Reporting_Code_DataType[] payroll_Reporting_Code_DataField;

		private Monthly_Tax_Filing_Deduction_DataType[] monthly_Deduction_Tax_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Calendar_YearObjectType Calendar_Year_Reference
		{
			get
			{
				return this.calendar_Year_ReferenceField;
			}
			set
			{
				this.calendar_Year_ReferenceField = value;
				this.RaisePropertyChanged("Calendar_Year_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public MonthObjectType Month_Reference
		{
			get
			{
				return this.month_ReferenceField;
			}
			set
			{
				this.month_ReferenceField = value;
				this.RaisePropertyChanged("Month_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Weeks_Worked
		{
			get
			{
				return this.weeks_WorkedField;
			}
			set
			{
				this.weeks_WorkedField = value;
				this.RaisePropertyChanged("Weeks_Worked");
			}
		}

		[XmlIgnore]
		public bool Weeks_WorkedSpecified
		{
			get
			{
				return this.weeks_WorkedFieldSpecified;
			}
			set
			{
				this.weeks_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Weeks_WorkedSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Hours_Worked
		{
			get
			{
				return this.hours_WorkedField;
			}
			set
			{
				this.hours_WorkedField = value;
				this.RaisePropertyChanged("Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Hours_WorkedSpecified
		{
			get
			{
				return this.hours_WorkedFieldSpecified;
			}
			set
			{
				this.hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Hours_WorkedSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Seasonal_Worker
		{
			get
			{
				return this.seasonal_WorkerField;
			}
			set
			{
				this.seasonal_WorkerField = value;
				this.RaisePropertyChanged("Seasonal_Worker");
			}
		}

		[XmlIgnore]
		public bool Seasonal_WorkerSpecified
		{
			get
			{
				return this.seasonal_WorkerFieldSpecified;
			}
			set
			{
				this.seasonal_WorkerFieldSpecified = value;
				this.RaisePropertyChanged("Seasonal_WorkerSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Corporate_Officer
		{
			get
			{
				return this.corporate_OfficerField;
			}
			set
			{
				this.corporate_OfficerField = value;
				this.RaisePropertyChanged("Corporate_Officer");
			}
		}

		[XmlIgnore]
		public bool Corporate_OfficerSpecified
		{
			get
			{
				return this.corporate_OfficerFieldSpecified;
			}
			set
			{
				this.corporate_OfficerFieldSpecified = value;
				this.RaisePropertyChanged("Corporate_OfficerSpecified");
			}
		}

		[XmlElement("Payroll_Reporting_Code_Data", Order = 11)]
		public Worker_Payroll_Reporting_Code_DataType[] Payroll_Reporting_Code_Data
		{
			get
			{
				return this.payroll_Reporting_Code_DataField;
			}
			set
			{
				this.payroll_Reporting_Code_DataField = value;
				this.RaisePropertyChanged("Payroll_Reporting_Code_Data");
			}
		}

		[XmlElement("Monthly_Deduction_Tax_Data", Order = 12)]
		public Monthly_Tax_Filing_Deduction_DataType[] Monthly_Deduction_Tax_Data
		{
			get
			{
				return this.monthly_Deduction_Tax_DataField;
			}
			set
			{
				this.monthly_Deduction_Tax_DataField = value;
				this.RaisePropertyChanged("Monthly_Deduction_Tax_Data");
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
