using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Recurrence_DataType : INotifyPropertyChanged
	{
		private Schedule_Request_TypeObjectType recurrence_Type_ReferenceField;

		private decimal recurrence_Interval_MultiplierField;

		private bool recurrence_Interval_MultiplierFieldSpecified;

		private bool recurs_Every_WeekdayField;

		private bool recurs_Every_WeekdayFieldSpecified;

		private Day_of_the_WeekObjectType[] day_of_the_Week_ReferenceField;

		private Day_of_the_WeekObjectType first_Day_of_the_Week_ReferenceField;

		private MonthObjectType[] month_ReferenceField;

		private Day_of_the_MonthObjectType[] day_of_the_Month_ReferenceField;

		private Week_of_the_MonthObjectType week_of_the_Month_ReferenceField;

		private DateTime recurrence_Start_DateField;

		private DateTime recurrence_End_DateField;

		private bool recurrence_End_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Schedule_Request_TypeObjectType Recurrence_Type_Reference
		{
			get
			{
				return this.recurrence_Type_ReferenceField;
			}
			set
			{
				this.recurrence_Type_ReferenceField = value;
				this.RaisePropertyChanged("Recurrence_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Recurrence_Interval_Multiplier
		{
			get
			{
				return this.recurrence_Interval_MultiplierField;
			}
			set
			{
				this.recurrence_Interval_MultiplierField = value;
				this.RaisePropertyChanged("Recurrence_Interval_Multiplier");
			}
		}

		[XmlIgnore]
		public bool Recurrence_Interval_MultiplierSpecified
		{
			get
			{
				return this.recurrence_Interval_MultiplierFieldSpecified;
			}
			set
			{
				this.recurrence_Interval_MultiplierFieldSpecified = value;
				this.RaisePropertyChanged("Recurrence_Interval_MultiplierSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Recurs_Every_Weekday
		{
			get
			{
				return this.recurs_Every_WeekdayField;
			}
			set
			{
				this.recurs_Every_WeekdayField = value;
				this.RaisePropertyChanged("Recurs_Every_Weekday");
			}
		}

		[XmlIgnore]
		public bool Recurs_Every_WeekdaySpecified
		{
			get
			{
				return this.recurs_Every_WeekdayFieldSpecified;
			}
			set
			{
				this.recurs_Every_WeekdayFieldSpecified = value;
				this.RaisePropertyChanged("Recurs_Every_WeekdaySpecified");
			}
		}

		[XmlElement("Day_of_the_Week_Reference", Order = 3)]
		public Day_of_the_WeekObjectType[] Day_of_the_Week_Reference
		{
			get
			{
				return this.day_of_the_Week_ReferenceField;
			}
			set
			{
				this.day_of_the_Week_ReferenceField = value;
				this.RaisePropertyChanged("Day_of_the_Week_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Day_of_the_WeekObjectType First_Day_of_the_Week_Reference
		{
			get
			{
				return this.first_Day_of_the_Week_ReferenceField;
			}
			set
			{
				this.first_Day_of_the_Week_ReferenceField = value;
				this.RaisePropertyChanged("First_Day_of_the_Week_Reference");
			}
		}

		[XmlElement("Month_Reference", Order = 5)]
		public MonthObjectType[] Month_Reference
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

		[XmlElement("Day_of_the_Month_Reference", Order = 6)]
		public Day_of_the_MonthObjectType[] Day_of_the_Month_Reference
		{
			get
			{
				return this.day_of_the_Month_ReferenceField;
			}
			set
			{
				this.day_of_the_Month_ReferenceField = value;
				this.RaisePropertyChanged("Day_of_the_Month_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Week_of_the_MonthObjectType Week_of_the_Month_Reference
		{
			get
			{
				return this.week_of_the_Month_ReferenceField;
			}
			set
			{
				this.week_of_the_Month_ReferenceField = value;
				this.RaisePropertyChanged("Week_of_the_Month_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Recurrence_Start_Date
		{
			get
			{
				return this.recurrence_Start_DateField;
			}
			set
			{
				this.recurrence_Start_DateField = value;
				this.RaisePropertyChanged("Recurrence_Start_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Recurrence_End_Date
		{
			get
			{
				return this.recurrence_End_DateField;
			}
			set
			{
				this.recurrence_End_DateField = value;
				this.RaisePropertyChanged("Recurrence_End_Date");
			}
		}

		[XmlIgnore]
		public bool Recurrence_End_DateSpecified
		{
			get
			{
				return this.recurrence_End_DateFieldSpecified;
			}
			set
			{
				this.recurrence_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Recurrence_End_DateSpecified");
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
