using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Task_Template_Due_Date_Offset_DataType : INotifyPropertyChanged
	{
		private string award_Task_Template_Date_Offset_IDField;

		private decimal number_of_MonthsField;

		private bool number_of_MonthsFieldSpecified;

		private decimal number_of_DaysField;

		private bool number_of_DaysFieldSpecified;

		private bool occurs_Before_Anchor_DateField;

		private bool occurs_Before_Anchor_DateFieldSpecified;

		private bool occurs_After_Anchor_DateField;

		private bool occurs_After_Anchor_DateFieldSpecified;

		private bool start_DateField;

		private bool start_DateFieldSpecified;

		private bool end_DateField;

		private bool end_DateFieldSpecified;

		private bool relative_to_Award_Schedule_LifeField;

		private bool relative_to_Award_Schedule_LifeFieldSpecified;

		private bool relative_to_Award_Contract_PeriodField;

		private bool relative_to_Award_Contract_PeriodFieldSpecified;

		private bool relative_to_Award_Schedule_PeriodField;

		private bool relative_to_Award_Schedule_PeriodFieldSpecified;

		private bool relative_to_Posting_IntervalField;

		private bool relative_to_Posting_IntervalFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Task_Template_Date_Offset_ID
		{
			get
			{
				return this.award_Task_Template_Date_Offset_IDField;
			}
			set
			{
				this.award_Task_Template_Date_Offset_IDField = value;
				this.RaisePropertyChanged("Award_Task_Template_Date_Offset_ID");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Number_of_Months
		{
			get
			{
				return this.number_of_MonthsField;
			}
			set
			{
				this.number_of_MonthsField = value;
				this.RaisePropertyChanged("Number_of_Months");
			}
		}

		[XmlIgnore]
		public bool Number_of_MonthsSpecified
		{
			get
			{
				return this.number_of_MonthsFieldSpecified;
			}
			set
			{
				this.number_of_MonthsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_MonthsSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Number_of_Days
		{
			get
			{
				return this.number_of_DaysField;
			}
			set
			{
				this.number_of_DaysField = value;
				this.RaisePropertyChanged("Number_of_Days");
			}
		}

		[XmlIgnore]
		public bool Number_of_DaysSpecified
		{
			get
			{
				return this.number_of_DaysFieldSpecified;
			}
			set
			{
				this.number_of_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_DaysSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Occurs_Before_Anchor_Date
		{
			get
			{
				return this.occurs_Before_Anchor_DateField;
			}
			set
			{
				this.occurs_Before_Anchor_DateField = value;
				this.RaisePropertyChanged("Occurs_Before_Anchor_Date");
			}
		}

		[XmlIgnore]
		public bool Occurs_Before_Anchor_DateSpecified
		{
			get
			{
				return this.occurs_Before_Anchor_DateFieldSpecified;
			}
			set
			{
				this.occurs_Before_Anchor_DateFieldSpecified = value;
				this.RaisePropertyChanged("Occurs_Before_Anchor_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Occurs_After_Anchor_Date
		{
			get
			{
				return this.occurs_After_Anchor_DateField;
			}
			set
			{
				this.occurs_After_Anchor_DateField = value;
				this.RaisePropertyChanged("Occurs_After_Anchor_Date");
			}
		}

		[XmlIgnore]
		public bool Occurs_After_Anchor_DateSpecified
		{
			get
			{
				return this.occurs_After_Anchor_DateFieldSpecified;
			}
			set
			{
				this.occurs_After_Anchor_DateFieldSpecified = value;
				this.RaisePropertyChanged("Occurs_After_Anchor_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Start_Date
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

		[XmlElement(Order = 6)]
		public bool End_Date
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

		[XmlElement(Order = 7)]
		public bool Relative_to_Award_Schedule_Life
		{
			get
			{
				return this.relative_to_Award_Schedule_LifeField;
			}
			set
			{
				this.relative_to_Award_Schedule_LifeField = value;
				this.RaisePropertyChanged("Relative_to_Award_Schedule_Life");
			}
		}

		[XmlIgnore]
		public bool Relative_to_Award_Schedule_LifeSpecified
		{
			get
			{
				return this.relative_to_Award_Schedule_LifeFieldSpecified;
			}
			set
			{
				this.relative_to_Award_Schedule_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Relative_to_Award_Schedule_LifeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Relative_to_Award_Contract_Period
		{
			get
			{
				return this.relative_to_Award_Contract_PeriodField;
			}
			set
			{
				this.relative_to_Award_Contract_PeriodField = value;
				this.RaisePropertyChanged("Relative_to_Award_Contract_Period");
			}
		}

		[XmlIgnore]
		public bool Relative_to_Award_Contract_PeriodSpecified
		{
			get
			{
				return this.relative_to_Award_Contract_PeriodFieldSpecified;
			}
			set
			{
				this.relative_to_Award_Contract_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Relative_to_Award_Contract_PeriodSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Relative_to_Award_Schedule_Period
		{
			get
			{
				return this.relative_to_Award_Schedule_PeriodField;
			}
			set
			{
				this.relative_to_Award_Schedule_PeriodField = value;
				this.RaisePropertyChanged("Relative_to_Award_Schedule_Period");
			}
		}

		[XmlIgnore]
		public bool Relative_to_Award_Schedule_PeriodSpecified
		{
			get
			{
				return this.relative_to_Award_Schedule_PeriodFieldSpecified;
			}
			set
			{
				this.relative_to_Award_Schedule_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Relative_to_Award_Schedule_PeriodSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Relative_to_Posting_Interval
		{
			get
			{
				return this.relative_to_Posting_IntervalField;
			}
			set
			{
				this.relative_to_Posting_IntervalField = value;
				this.RaisePropertyChanged("Relative_to_Posting_Interval");
			}
		}

		[XmlIgnore]
		public bool Relative_to_Posting_IntervalSpecified
		{
			get
			{
				return this.relative_to_Posting_IntervalFieldSpecified;
			}
			set
			{
				this.relative_to_Posting_IntervalFieldSpecified = value;
				this.RaisePropertyChanged("Relative_to_Posting_IntervalSpecified");
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
