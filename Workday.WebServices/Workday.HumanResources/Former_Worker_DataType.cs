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
	public class Former_Worker_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string former_Worker_IDField;

		private Worker_TypeObjectType worker_Type_ReferenceField;

		private DateTime last_Termination_DateField;

		private bool last_Termination_DateFieldSpecified;

		private DateTime most_Recent_Hire_DateField;

		private bool most_Recent_Hire_DateFieldSpecified;

		private DateTime original_Hire_DateField;

		private bool original_Hire_DateFieldSpecified;

		private DateTime continuous_Service_DateField;

		private bool continuous_Service_DateFieldSpecified;

		private Former_Worker_Personal_Information_DataType personal_Information_DataField;

		private string last_Termination_ReasonField;

		private string managerField;

		private string cost_CenterField;

		private string job_TitleField;

		private string job_CodeField;

		private string job_Profile_TextField;

		private string job_LevelField;

		private string time_TypeField;

		private string locationField;

		private decimal base_PayField;

		private bool base_PayFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private bool eligible_for_RehireField;

		private bool eligible_for_RehireFieldSpecified;

		private string performance_RatingField;

		private Former_Worker_Related_DataType former_Worker_Related_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Former_Worker_ID
		{
			get
			{
				return this.former_Worker_IDField;
			}
			set
			{
				this.former_Worker_IDField = value;
				this.RaisePropertyChanged("Former_Worker_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Worker_TypeObjectType Worker_Type_Reference
		{
			get
			{
				return this.worker_Type_ReferenceField;
			}
			set
			{
				this.worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Last_Termination_Date
		{
			get
			{
				return this.last_Termination_DateField;
			}
			set
			{
				this.last_Termination_DateField = value;
				this.RaisePropertyChanged("Last_Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Termination_DateSpecified
		{
			get
			{
				return this.last_Termination_DateFieldSpecified;
			}
			set
			{
				this.last_Termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Termination_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Most_Recent_Hire_Date
		{
			get
			{
				return this.most_Recent_Hire_DateField;
			}
			set
			{
				this.most_Recent_Hire_DateField = value;
				this.RaisePropertyChanged("Most_Recent_Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Most_Recent_Hire_DateSpecified
		{
			get
			{
				return this.most_Recent_Hire_DateFieldSpecified;
			}
			set
			{
				this.most_Recent_Hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Most_Recent_Hire_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(Order = 7)]
		public Former_Worker_Personal_Information_DataType Personal_Information_Data
		{
			get
			{
				return this.personal_Information_DataField;
			}
			set
			{
				this.personal_Information_DataField = value;
				this.RaisePropertyChanged("Personal_Information_Data");
			}
		}

		[XmlElement(Order = 8)]
		public string Last_Termination_Reason
		{
			get
			{
				return this.last_Termination_ReasonField;
			}
			set
			{
				this.last_Termination_ReasonField = value;
				this.RaisePropertyChanged("Last_Termination_Reason");
			}
		}

		[XmlElement(Order = 9)]
		public string Manager
		{
			get
			{
				return this.managerField;
			}
			set
			{
				this.managerField = value;
				this.RaisePropertyChanged("Manager");
			}
		}

		[XmlElement(Order = 10)]
		public string Cost_Center
		{
			get
			{
				return this.cost_CenterField;
			}
			set
			{
				this.cost_CenterField = value;
				this.RaisePropertyChanged("Cost_Center");
			}
		}

		[XmlElement(Order = 11)]
		public string Job_Title
		{
			get
			{
				return this.job_TitleField;
			}
			set
			{
				this.job_TitleField = value;
				this.RaisePropertyChanged("Job_Title");
			}
		}

		[XmlElement(Order = 12)]
		public string Job_Code
		{
			get
			{
				return this.job_CodeField;
			}
			set
			{
				this.job_CodeField = value;
				this.RaisePropertyChanged("Job_Code");
			}
		}

		[XmlElement(Order = 13)]
		public string Job_Profile_Text
		{
			get
			{
				return this.job_Profile_TextField;
			}
			set
			{
				this.job_Profile_TextField = value;
				this.RaisePropertyChanged("Job_Profile_Text");
			}
		}

		[XmlElement(Order = 14)]
		public string Job_Level
		{
			get
			{
				return this.job_LevelField;
			}
			set
			{
				this.job_LevelField = value;
				this.RaisePropertyChanged("Job_Level");
			}
		}

		[XmlElement(Order = 15)]
		public string Time_Type
		{
			get
			{
				return this.time_TypeField;
			}
			set
			{
				this.time_TypeField = value;
				this.RaisePropertyChanged("Time_Type");
			}
		}

		[XmlElement(Order = 16)]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				this.RaisePropertyChanged("Location");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Base_Pay
		{
			get
			{
				return this.base_PayField;
			}
			set
			{
				this.base_PayField = value;
				this.RaisePropertyChanged("Base_Pay");
			}
		}

		[XmlIgnore]
		public bool Base_PaySpecified
		{
			get
			{
				return this.base_PayFieldSpecified;
			}
			set
			{
				this.base_PayFieldSpecified = value;
				this.RaisePropertyChanged("Base_PaySpecified");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public decimal Scheduled_Weekly_Hours
		{
			get
			{
				return this.scheduled_Weekly_HoursField;
			}
			set
			{
				this.scheduled_Weekly_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Weekly_HoursSpecified
		{
			get
			{
				return this.scheduled_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Eligible_for_Rehire
		{
			get
			{
				return this.eligible_for_RehireField;
			}
			set
			{
				this.eligible_for_RehireField = value;
				this.RaisePropertyChanged("Eligible_for_Rehire");
			}
		}

		[XmlIgnore]
		public bool Eligible_for_RehireSpecified
		{
			get
			{
				return this.eligible_for_RehireFieldSpecified;
			}
			set
			{
				this.eligible_for_RehireFieldSpecified = value;
				this.RaisePropertyChanged("Eligible_for_RehireSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public string Performance_Rating
		{
			get
			{
				return this.performance_RatingField;
			}
			set
			{
				this.performance_RatingField = value;
				this.RaisePropertyChanged("Performance_Rating");
			}
		}

		[XmlElement(Order = 23)]
		public Former_Worker_Related_DataType Former_Worker_Related_Data
		{
			get
			{
				return this.former_Worker_Related_DataField;
			}
			set
			{
				this.former_Worker_Related_DataField = value;
				this.RaisePropertyChanged("Former_Worker_Related_Data");
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
