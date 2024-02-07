using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Work_Schedule_Calendar_DataType : INotifyPropertyChanged
	{
		private string nameField;

		private string schedule_SummaryField;

		private string descriptionField;

		private Condition_RuleObjectType condition_Rule_ReferenceField;

		private Twenty_Four_Hour_TimeObjectType day_Breaker_ReferenceField;

		private Day_Breaker_DividerObjectType day_Breaker_Divides_ReferenceField;

		private Day_of_the_WeekObjectType work_Week_Start_Day_ReferenceField;

		private DateTime biweekly_Calculation_Start_DateField;

		private bool biweekly_Calculation_Start_DateFieldSpecified;

		private DateTime pattern_Start_DateField;

		private bool pattern_Start_DateFieldSpecified;

		private decimal number_of_WeeksField;

		private bool number_of_WeeksFieldSpecified;

		private Work_Schedule_Calendar_Event_DataType[] work_Schedule_Calendar_Event_DataField;

		private Worker_Editing_Options_DataType worker_Edit_Options_DataField;

		private Pattern_Schedule_Event_DataType[] pattern_Schedule_Event_DataField;

		private string idField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Schedule_Summary
		{
			get
			{
				return this.schedule_SummaryField;
			}
			set
			{
				this.schedule_SummaryField = value;
				this.RaisePropertyChanged("Schedule_Summary");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public Condition_RuleObjectType Condition_Rule_Reference
		{
			get
			{
				return this.condition_Rule_ReferenceField;
			}
			set
			{
				this.condition_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Condition_Rule_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Twenty_Four_Hour_TimeObjectType Day_Breaker_Reference
		{
			get
			{
				return this.day_Breaker_ReferenceField;
			}
			set
			{
				this.day_Breaker_ReferenceField = value;
				this.RaisePropertyChanged("Day_Breaker_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Day_Breaker_DividerObjectType Day_Breaker_Divides_Reference
		{
			get
			{
				return this.day_Breaker_Divides_ReferenceField;
			}
			set
			{
				this.day_Breaker_Divides_ReferenceField = value;
				this.RaisePropertyChanged("Day_Breaker_Divides_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Day_of_the_WeekObjectType Work_Week_Start_Day_Reference
		{
			get
			{
				return this.work_Week_Start_Day_ReferenceField;
			}
			set
			{
				this.work_Week_Start_Day_ReferenceField = value;
				this.RaisePropertyChanged("Work_Week_Start_Day_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Biweekly_Calculation_Start_Date
		{
			get
			{
				return this.biweekly_Calculation_Start_DateField;
			}
			set
			{
				this.biweekly_Calculation_Start_DateField = value;
				this.RaisePropertyChanged("Biweekly_Calculation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Biweekly_Calculation_Start_DateSpecified
		{
			get
			{
				return this.biweekly_Calculation_Start_DateFieldSpecified;
			}
			set
			{
				this.biweekly_Calculation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Biweekly_Calculation_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Pattern_Start_Date
		{
			get
			{
				return this.pattern_Start_DateField;
			}
			set
			{
				this.pattern_Start_DateField = value;
				this.RaisePropertyChanged("Pattern_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Pattern_Start_DateSpecified
		{
			get
			{
				return this.pattern_Start_DateFieldSpecified;
			}
			set
			{
				this.pattern_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Pattern_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Number_of_Weeks
		{
			get
			{
				return this.number_of_WeeksField;
			}
			set
			{
				this.number_of_WeeksField = value;
				this.RaisePropertyChanged("Number_of_Weeks");
			}
		}

		[XmlIgnore]
		public bool Number_of_WeeksSpecified
		{
			get
			{
				return this.number_of_WeeksFieldSpecified;
			}
			set
			{
				this.number_of_WeeksFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_WeeksSpecified");
			}
		}

		[XmlElement("Work_Schedule_Calendar_Event_Data", Order = 10)]
		public Work_Schedule_Calendar_Event_DataType[] Work_Schedule_Calendar_Event_Data
		{
			get
			{
				return this.work_Schedule_Calendar_Event_DataField;
			}
			set
			{
				this.work_Schedule_Calendar_Event_DataField = value;
				this.RaisePropertyChanged("Work_Schedule_Calendar_Event_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Worker_Editing_Options_DataType Worker_Edit_Options_Data
		{
			get
			{
				return this.worker_Edit_Options_DataField;
			}
			set
			{
				this.worker_Edit_Options_DataField = value;
				this.RaisePropertyChanged("Worker_Edit_Options_Data");
			}
		}

		[XmlElement("Pattern_Schedule_Event_Data", Order = 12)]
		public Pattern_Schedule_Event_DataType[] Pattern_Schedule_Event_Data
		{
			get
			{
				return this.pattern_Schedule_Event_DataField;
			}
			set
			{
				this.pattern_Schedule_Event_DataField = value;
				this.RaisePropertyChanged("Pattern_Schedule_Event_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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
