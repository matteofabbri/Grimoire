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
	public class Lifecycle_Status_Update_Rule_DataType : INotifyPropertyChanged
	{
		private string award_Lifecycle_Status_Update_Rule_IDField;

		private string evaluation_OrderField;

		private bool applies_To_Header_StatusField;

		private bool applies_To_Header_StatusFieldSpecified;

		private bool applies_To_Line_StatusField;

		private bool applies_To_Line_StatusFieldSpecified;

		private Award_Lifecycle_StatusObjectType change_To_New_Status_ReferenceField;

		private Award_Lifecycle_StatusObjectType[] unless_Current_Status_ReferenceField;

		private bool based_On_DatesField;

		private bool based_On_DatesFieldSpecified;

		private bool based_On_Award_TasksField;

		private bool based_On_Award_TasksFieldSpecified;

		private decimal number_of_MonthsField;

		private bool number_of_MonthsFieldSpecified;

		private decimal number_of_DaysField;

		private bool number_of_DaysFieldSpecified;

		private bool on_or_Before_DateField;

		private bool on_or_Before_DateFieldSpecified;

		private bool on_or_After_DateField;

		private bool on_or_After_DateFieldSpecified;

		private bool end_DateField;

		private bool end_DateFieldSpecified;

		private bool start_DateField;

		private bool start_DateFieldSpecified;

		private bool relative_To_Award_Schedule_LifeField;

		private bool relative_To_Award_Schedule_LifeFieldSpecified;

		private bool relative_To_Award_Contract_PeriodField;

		private bool relative_To_Award_Contract_PeriodFieldSpecified;

		private bool relative_To_Award_Line_LifeField;

		private bool relative_To_Award_Line_LifeFieldSpecified;

		private Lifecycle_Status_Update_Rule_Award_Task_Criteria_DataType[] lifecycle_Status_Update_Rule_Award_Task_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Lifecycle_Status_Update_Rule_ID
		{
			get
			{
				return this.award_Lifecycle_Status_Update_Rule_IDField;
			}
			set
			{
				this.award_Lifecycle_Status_Update_Rule_IDField = value;
				this.RaisePropertyChanged("Award_Lifecycle_Status_Update_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Evaluation_Order
		{
			get
			{
				return this.evaluation_OrderField;
			}
			set
			{
				this.evaluation_OrderField = value;
				this.RaisePropertyChanged("Evaluation_Order");
			}
		}

		[XmlElement(Order = 2)]
		public bool Applies_To_Header_Status
		{
			get
			{
				return this.applies_To_Header_StatusField;
			}
			set
			{
				this.applies_To_Header_StatusField = value;
				this.RaisePropertyChanged("Applies_To_Header_Status");
			}
		}

		[XmlIgnore]
		public bool Applies_To_Header_StatusSpecified
		{
			get
			{
				return this.applies_To_Header_StatusFieldSpecified;
			}
			set
			{
				this.applies_To_Header_StatusFieldSpecified = value;
				this.RaisePropertyChanged("Applies_To_Header_StatusSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Applies_To_Line_Status
		{
			get
			{
				return this.applies_To_Line_StatusField;
			}
			set
			{
				this.applies_To_Line_StatusField = value;
				this.RaisePropertyChanged("Applies_To_Line_Status");
			}
		}

		[XmlIgnore]
		public bool Applies_To_Line_StatusSpecified
		{
			get
			{
				return this.applies_To_Line_StatusFieldSpecified;
			}
			set
			{
				this.applies_To_Line_StatusFieldSpecified = value;
				this.RaisePropertyChanged("Applies_To_Line_StatusSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Award_Lifecycle_StatusObjectType Change_To_New_Status_Reference
		{
			get
			{
				return this.change_To_New_Status_ReferenceField;
			}
			set
			{
				this.change_To_New_Status_ReferenceField = value;
				this.RaisePropertyChanged("Change_To_New_Status_Reference");
			}
		}

		[XmlElement("Unless_Current_Status_Reference", Order = 5)]
		public Award_Lifecycle_StatusObjectType[] Unless_Current_Status_Reference
		{
			get
			{
				return this.unless_Current_Status_ReferenceField;
			}
			set
			{
				this.unless_Current_Status_ReferenceField = value;
				this.RaisePropertyChanged("Unless_Current_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Based_On_Dates
		{
			get
			{
				return this.based_On_DatesField;
			}
			set
			{
				this.based_On_DatesField = value;
				this.RaisePropertyChanged("Based_On_Dates");
			}
		}

		[XmlIgnore]
		public bool Based_On_DatesSpecified
		{
			get
			{
				return this.based_On_DatesFieldSpecified;
			}
			set
			{
				this.based_On_DatesFieldSpecified = value;
				this.RaisePropertyChanged("Based_On_DatesSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Based_On_Award_Tasks
		{
			get
			{
				return this.based_On_Award_TasksField;
			}
			set
			{
				this.based_On_Award_TasksField = value;
				this.RaisePropertyChanged("Based_On_Award_Tasks");
			}
		}

		[XmlIgnore]
		public bool Based_On_Award_TasksSpecified
		{
			get
			{
				return this.based_On_Award_TasksFieldSpecified;
			}
			set
			{
				this.based_On_Award_TasksFieldSpecified = value;
				this.RaisePropertyChanged("Based_On_Award_TasksSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public bool On_or_Before_Date
		{
			get
			{
				return this.on_or_Before_DateField;
			}
			set
			{
				this.on_or_Before_DateField = value;
				this.RaisePropertyChanged("On_or_Before_Date");
			}
		}

		[XmlIgnore]
		public bool On_or_Before_DateSpecified
		{
			get
			{
				return this.on_or_Before_DateFieldSpecified;
			}
			set
			{
				this.on_or_Before_DateFieldSpecified = value;
				this.RaisePropertyChanged("On_or_Before_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool On_or_After_Date
		{
			get
			{
				return this.on_or_After_DateField;
			}
			set
			{
				this.on_or_After_DateField = value;
				this.RaisePropertyChanged("On_or_After_Date");
			}
		}

		[XmlIgnore]
		public bool On_or_After_DateSpecified
		{
			get
			{
				return this.on_or_After_DateFieldSpecified;
			}
			set
			{
				this.on_or_After_DateFieldSpecified = value;
				this.RaisePropertyChanged("On_or_After_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Relative_To_Award_Schedule_Life
		{
			get
			{
				return this.relative_To_Award_Schedule_LifeField;
			}
			set
			{
				this.relative_To_Award_Schedule_LifeField = value;
				this.RaisePropertyChanged("Relative_To_Award_Schedule_Life");
			}
		}

		[XmlIgnore]
		public bool Relative_To_Award_Schedule_LifeSpecified
		{
			get
			{
				return this.relative_To_Award_Schedule_LifeFieldSpecified;
			}
			set
			{
				this.relative_To_Award_Schedule_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Relative_To_Award_Schedule_LifeSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public bool Relative_To_Award_Contract_Period
		{
			get
			{
				return this.relative_To_Award_Contract_PeriodField;
			}
			set
			{
				this.relative_To_Award_Contract_PeriodField = value;
				this.RaisePropertyChanged("Relative_To_Award_Contract_Period");
			}
		}

		[XmlIgnore]
		public bool Relative_To_Award_Contract_PeriodSpecified
		{
			get
			{
				return this.relative_To_Award_Contract_PeriodFieldSpecified;
			}
			set
			{
				this.relative_To_Award_Contract_PeriodFieldSpecified = value;
				this.RaisePropertyChanged("Relative_To_Award_Contract_PeriodSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public bool Relative_To_Award_Line_Life
		{
			get
			{
				return this.relative_To_Award_Line_LifeField;
			}
			set
			{
				this.relative_To_Award_Line_LifeField = value;
				this.RaisePropertyChanged("Relative_To_Award_Line_Life");
			}
		}

		[XmlIgnore]
		public bool Relative_To_Award_Line_LifeSpecified
		{
			get
			{
				return this.relative_To_Award_Line_LifeFieldSpecified;
			}
			set
			{
				this.relative_To_Award_Line_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Relative_To_Award_Line_LifeSpecified");
			}
		}

		[XmlElement("Lifecycle_Status_Update_Rule_Award_Task_Criteria_Data", Order = 17)]
		public Lifecycle_Status_Update_Rule_Award_Task_Criteria_DataType[] Lifecycle_Status_Update_Rule_Award_Task_Criteria_Data
		{
			get
			{
				return this.lifecycle_Status_Update_Rule_Award_Task_Criteria_DataField;
			}
			set
			{
				this.lifecycle_Status_Update_Rule_Award_Task_Criteria_DataField = value;
				this.RaisePropertyChanged("Lifecycle_Status_Update_Rule_Award_Task_Criteria_Data");
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
