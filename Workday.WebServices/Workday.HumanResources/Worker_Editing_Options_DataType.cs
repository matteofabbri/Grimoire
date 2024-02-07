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
	public class Worker_Editing_Options_DataType : INotifyPropertyChanged
	{
		private bool enable_Worker_Editing_OptionsField;

		private bool enable_Worker_Editing_OptionsFieldSpecified;

		private bool change_Scheduled_and_Non_Scheduled_DaysField;

		private bool change_Scheduled_and_Non_Scheduled_DaysFieldSpecified;

		private bool change_Number_of_Scheduled_DaysField;

		private bool change_Number_of_Scheduled_DaysFieldSpecified;

		private bool enable_Hours_RestrictionsField;

		private bool enable_Hours_RestrictionsFieldSpecified;

		private decimal minimum_Number_of_Hours_per_DayField;

		private bool minimum_Number_of_Hours_per_DayFieldSpecified;

		private decimal maximum_Number_of_Hours_per_DayField;

		private bool maximum_Number_of_Hours_per_DayFieldSpecified;

		private decimal minimum_Number_of_Hours_per_WeekField;

		private bool minimum_Number_of_Hours_per_WeekFieldSpecified;

		private decimal maximum_Number_of_Hours_per_WeekField;

		private bool maximum_Number_of_Hours_per_WeekFieldSpecified;

		private bool change_Daily_Start_and_End_TimesField;

		private bool change_Daily_Start_and_End_TimesFieldSpecified;

		private bool uniform_Start_and_End_TimesField;

		private bool uniform_Start_and_End_TimesFieldSpecified;

		private DateTime flexible_Start_TimeField;

		private bool flexible_Start_TimeFieldSpecified;

		private DateTime flexible_End_TimeField;

		private bool flexible_End_TimeFieldSpecified;

		private bool allow_MealsField;

		private bool allow_MealsFieldSpecified;

		private bool change_Meal_Start_and_End_TimesField;

		private bool change_Meal_Start_and_End_TimesFieldSpecified;

		private decimal minimum_Meal_DurationField;

		private bool minimum_Meal_DurationFieldSpecified;

		private decimal maximum_Meal_DurationField;

		private bool maximum_Meal_DurationFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Enable_Worker_Editing_Options
		{
			get
			{
				return this.enable_Worker_Editing_OptionsField;
			}
			set
			{
				this.enable_Worker_Editing_OptionsField = value;
				this.RaisePropertyChanged("Enable_Worker_Editing_Options");
			}
		}

		[XmlIgnore]
		public bool Enable_Worker_Editing_OptionsSpecified
		{
			get
			{
				return this.enable_Worker_Editing_OptionsFieldSpecified;
			}
			set
			{
				this.enable_Worker_Editing_OptionsFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Worker_Editing_OptionsSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Change_Scheduled_and_Non_Scheduled_Days
		{
			get
			{
				return this.change_Scheduled_and_Non_Scheduled_DaysField;
			}
			set
			{
				this.change_Scheduled_and_Non_Scheduled_DaysField = value;
				this.RaisePropertyChanged("Change_Scheduled_and_Non_Scheduled_Days");
			}
		}

		[XmlIgnore]
		public bool Change_Scheduled_and_Non_Scheduled_DaysSpecified
		{
			get
			{
				return this.change_Scheduled_and_Non_Scheduled_DaysFieldSpecified;
			}
			set
			{
				this.change_Scheduled_and_Non_Scheduled_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Change_Scheduled_and_Non_Scheduled_DaysSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Change_Number_of_Scheduled_Days
		{
			get
			{
				return this.change_Number_of_Scheduled_DaysField;
			}
			set
			{
				this.change_Number_of_Scheduled_DaysField = value;
				this.RaisePropertyChanged("Change_Number_of_Scheduled_Days");
			}
		}

		[XmlIgnore]
		public bool Change_Number_of_Scheduled_DaysSpecified
		{
			get
			{
				return this.change_Number_of_Scheduled_DaysFieldSpecified;
			}
			set
			{
				this.change_Number_of_Scheduled_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Change_Number_of_Scheduled_DaysSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Enable_Hours_Restrictions
		{
			get
			{
				return this.enable_Hours_RestrictionsField;
			}
			set
			{
				this.enable_Hours_RestrictionsField = value;
				this.RaisePropertyChanged("Enable_Hours_Restrictions");
			}
		}

		[XmlIgnore]
		public bool Enable_Hours_RestrictionsSpecified
		{
			get
			{
				return this.enable_Hours_RestrictionsFieldSpecified;
			}
			set
			{
				this.enable_Hours_RestrictionsFieldSpecified = value;
				this.RaisePropertyChanged("Enable_Hours_RestrictionsSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Minimum_Number_of_Hours_per_Day
		{
			get
			{
				return this.minimum_Number_of_Hours_per_DayField;
			}
			set
			{
				this.minimum_Number_of_Hours_per_DayField = value;
				this.RaisePropertyChanged("Minimum_Number_of_Hours_per_Day");
			}
		}

		[XmlIgnore]
		public bool Minimum_Number_of_Hours_per_DaySpecified
		{
			get
			{
				return this.minimum_Number_of_Hours_per_DayFieldSpecified;
			}
			set
			{
				this.minimum_Number_of_Hours_per_DayFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Number_of_Hours_per_DaySpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Maximum_Number_of_Hours_per_Day
		{
			get
			{
				return this.maximum_Number_of_Hours_per_DayField;
			}
			set
			{
				this.maximum_Number_of_Hours_per_DayField = value;
				this.RaisePropertyChanged("Maximum_Number_of_Hours_per_Day");
			}
		}

		[XmlIgnore]
		public bool Maximum_Number_of_Hours_per_DaySpecified
		{
			get
			{
				return this.maximum_Number_of_Hours_per_DayFieldSpecified;
			}
			set
			{
				this.maximum_Number_of_Hours_per_DayFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Number_of_Hours_per_DaySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Minimum_Number_of_Hours_per_Week
		{
			get
			{
				return this.minimum_Number_of_Hours_per_WeekField;
			}
			set
			{
				this.minimum_Number_of_Hours_per_WeekField = value;
				this.RaisePropertyChanged("Minimum_Number_of_Hours_per_Week");
			}
		}

		[XmlIgnore]
		public bool Minimum_Number_of_Hours_per_WeekSpecified
		{
			get
			{
				return this.minimum_Number_of_Hours_per_WeekFieldSpecified;
			}
			set
			{
				this.minimum_Number_of_Hours_per_WeekFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Number_of_Hours_per_WeekSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Maximum_Number_of_Hours_per_Week
		{
			get
			{
				return this.maximum_Number_of_Hours_per_WeekField;
			}
			set
			{
				this.maximum_Number_of_Hours_per_WeekField = value;
				this.RaisePropertyChanged("Maximum_Number_of_Hours_per_Week");
			}
		}

		[XmlIgnore]
		public bool Maximum_Number_of_Hours_per_WeekSpecified
		{
			get
			{
				return this.maximum_Number_of_Hours_per_WeekFieldSpecified;
			}
			set
			{
				this.maximum_Number_of_Hours_per_WeekFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Number_of_Hours_per_WeekSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Change_Daily_Start_and_End_Times
		{
			get
			{
				return this.change_Daily_Start_and_End_TimesField;
			}
			set
			{
				this.change_Daily_Start_and_End_TimesField = value;
				this.RaisePropertyChanged("Change_Daily_Start_and_End_Times");
			}
		}

		[XmlIgnore]
		public bool Change_Daily_Start_and_End_TimesSpecified
		{
			get
			{
				return this.change_Daily_Start_and_End_TimesFieldSpecified;
			}
			set
			{
				this.change_Daily_Start_and_End_TimesFieldSpecified = value;
				this.RaisePropertyChanged("Change_Daily_Start_and_End_TimesSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Uniform_Start_and_End_Times
		{
			get
			{
				return this.uniform_Start_and_End_TimesField;
			}
			set
			{
				this.uniform_Start_and_End_TimesField = value;
				this.RaisePropertyChanged("Uniform_Start_and_End_Times");
			}
		}

		[XmlIgnore]
		public bool Uniform_Start_and_End_TimesSpecified
		{
			get
			{
				return this.uniform_Start_and_End_TimesFieldSpecified;
			}
			set
			{
				this.uniform_Start_and_End_TimesFieldSpecified = value;
				this.RaisePropertyChanged("Uniform_Start_and_End_TimesSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 10)]
		public DateTime Flexible_Start_Time
		{
			get
			{
				return this.flexible_Start_TimeField;
			}
			set
			{
				this.flexible_Start_TimeField = value;
				this.RaisePropertyChanged("Flexible_Start_Time");
			}
		}

		[XmlIgnore]
		public bool Flexible_Start_TimeSpecified
		{
			get
			{
				return this.flexible_Start_TimeFieldSpecified;
			}
			set
			{
				this.flexible_Start_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Flexible_Start_TimeSpecified");
			}
		}

		[XmlElement(DataType = "time", Order = 11)]
		public DateTime Flexible_End_Time
		{
			get
			{
				return this.flexible_End_TimeField;
			}
			set
			{
				this.flexible_End_TimeField = value;
				this.RaisePropertyChanged("Flexible_End_Time");
			}
		}

		[XmlIgnore]
		public bool Flexible_End_TimeSpecified
		{
			get
			{
				return this.flexible_End_TimeFieldSpecified;
			}
			set
			{
				this.flexible_End_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Flexible_End_TimeSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Allow_Meals
		{
			get
			{
				return this.allow_MealsField;
			}
			set
			{
				this.allow_MealsField = value;
				this.RaisePropertyChanged("Allow_Meals");
			}
		}

		[XmlIgnore]
		public bool Allow_MealsSpecified
		{
			get
			{
				return this.allow_MealsFieldSpecified;
			}
			set
			{
				this.allow_MealsFieldSpecified = value;
				this.RaisePropertyChanged("Allow_MealsSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Change_Meal_Start_and_End_Times
		{
			get
			{
				return this.change_Meal_Start_and_End_TimesField;
			}
			set
			{
				this.change_Meal_Start_and_End_TimesField = value;
				this.RaisePropertyChanged("Change_Meal_Start_and_End_Times");
			}
		}

		[XmlIgnore]
		public bool Change_Meal_Start_and_End_TimesSpecified
		{
			get
			{
				return this.change_Meal_Start_and_End_TimesFieldSpecified;
			}
			set
			{
				this.change_Meal_Start_and_End_TimesFieldSpecified = value;
				this.RaisePropertyChanged("Change_Meal_Start_and_End_TimesSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Minimum_Meal_Duration
		{
			get
			{
				return this.minimum_Meal_DurationField;
			}
			set
			{
				this.minimum_Meal_DurationField = value;
				this.RaisePropertyChanged("Minimum_Meal_Duration");
			}
		}

		[XmlIgnore]
		public bool Minimum_Meal_DurationSpecified
		{
			get
			{
				return this.minimum_Meal_DurationFieldSpecified;
			}
			set
			{
				this.minimum_Meal_DurationFieldSpecified = value;
				this.RaisePropertyChanged("Minimum_Meal_DurationSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Maximum_Meal_Duration
		{
			get
			{
				return this.maximum_Meal_DurationField;
			}
			set
			{
				this.maximum_Meal_DurationField = value;
				this.RaisePropertyChanged("Maximum_Meal_Duration");
			}
		}

		[XmlIgnore]
		public bool Maximum_Meal_DurationSpecified
		{
			get
			{
				return this.maximum_Meal_DurationFieldSpecified;
			}
			set
			{
				this.maximum_Meal_DurationFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_Meal_DurationSpecified");
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
