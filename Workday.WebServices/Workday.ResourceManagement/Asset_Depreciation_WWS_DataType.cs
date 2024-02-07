using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Asset_Depreciation_WWS_DataType : INotifyPropertyChanged
	{
		private Depreciation_ProfileObjectType depreciation_Profile_ReferenceField;

		private Depreciation_MethodObjectType depreciation_Method_ReferenceField;

		private Depreciation_Posting_FrequencyObjectType depreciation_Posting_Frequency_ReferenceField;

		private Depreciation_ConventionObjectType depreciation_Convention_ReferenceField;

		private Depreciation_Start_Based_OnObjectType depreciation_Start_Based_On_ReferenceField;

		private Depreciation_Rate_BasisObjectType depreciation_Rate_Basis_ReferenceField;

		private DateTime depreciation_Start_DateField;

		private bool depreciation_Start_DateFieldSpecified;

		private decimal useful_LifeField;

		private bool useful_LifeFieldSpecified;

		private decimal depreciation_PercentField;

		private bool depreciation_PercentFieldSpecified;

		private decimal depreciation_ThresholdField;

		private bool depreciation_ThresholdFieldSpecified;

		private DateTime depreciation_Start_Date_At_RegistrationField;

		private bool depreciation_Start_Date_At_RegistrationFieldSpecified;

		private decimal accumulated_Depreciation_At_RegistrationField;

		private bool accumulated_Depreciation_At_RegistrationFieldSpecified;

		private decimal remaining_Useful_Life_At_RegistrationField;

		private bool remaining_Useful_Life_At_RegistrationFieldSpecified;

		private decimal max_Bonus_Depreciable_BasisField;

		private bool max_Bonus_Depreciable_BasisFieldSpecified;

		private decimal bonus_Depreciation_PercentField;

		private bool bonus_Depreciation_PercentFieldSpecified;

		private decimal historical_Bonus_Depreciation_for_Depreciation_ScheduleField;

		private bool historical_Bonus_Depreciation_for_Depreciation_ScheduleFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Depreciation_ProfileObjectType Depreciation_Profile_Reference
		{
			get
			{
				return this.depreciation_Profile_ReferenceField;
			}
			set
			{
				this.depreciation_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Profile_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Depreciation_MethodObjectType Depreciation_Method_Reference
		{
			get
			{
				return this.depreciation_Method_ReferenceField;
			}
			set
			{
				this.depreciation_Method_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Method_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Depreciation_Posting_FrequencyObjectType Depreciation_Posting_Frequency_Reference
		{
			get
			{
				return this.depreciation_Posting_Frequency_ReferenceField;
			}
			set
			{
				this.depreciation_Posting_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Posting_Frequency_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Depreciation_ConventionObjectType Depreciation_Convention_Reference
		{
			get
			{
				return this.depreciation_Convention_ReferenceField;
			}
			set
			{
				this.depreciation_Convention_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Convention_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Depreciation_Start_Based_OnObjectType Depreciation_Start_Based_On_Reference
		{
			get
			{
				return this.depreciation_Start_Based_On_ReferenceField;
			}
			set
			{
				this.depreciation_Start_Based_On_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Start_Based_On_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Depreciation_Rate_BasisObjectType Depreciation_Rate_Basis_Reference
		{
			get
			{
				return this.depreciation_Rate_Basis_ReferenceField;
			}
			set
			{
				this.depreciation_Rate_Basis_ReferenceField = value;
				this.RaisePropertyChanged("Depreciation_Rate_Basis_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Depreciation_Start_Date
		{
			get
			{
				return this.depreciation_Start_DateField;
			}
			set
			{
				this.depreciation_Start_DateField = value;
				this.RaisePropertyChanged("Depreciation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Start_DateSpecified
		{
			get
			{
				return this.depreciation_Start_DateFieldSpecified;
			}
			set
			{
				this.depreciation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Start_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Useful_Life
		{
			get
			{
				return this.useful_LifeField;
			}
			set
			{
				this.useful_LifeField = value;
				this.RaisePropertyChanged("Useful_Life");
			}
		}

		[XmlIgnore]
		public bool Useful_LifeSpecified
		{
			get
			{
				return this.useful_LifeFieldSpecified;
			}
			set
			{
				this.useful_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Useful_LifeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Depreciation_Percent
		{
			get
			{
				return this.depreciation_PercentField;
			}
			set
			{
				this.depreciation_PercentField = value;
				this.RaisePropertyChanged("Depreciation_Percent");
			}
		}

		[XmlIgnore]
		public bool Depreciation_PercentSpecified
		{
			get
			{
				return this.depreciation_PercentFieldSpecified;
			}
			set
			{
				this.depreciation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_PercentSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Depreciation_Threshold
		{
			get
			{
				return this.depreciation_ThresholdField;
			}
			set
			{
				this.depreciation_ThresholdField = value;
				this.RaisePropertyChanged("Depreciation_Threshold");
			}
		}

		[XmlIgnore]
		public bool Depreciation_ThresholdSpecified
		{
			get
			{
				return this.depreciation_ThresholdFieldSpecified;
			}
			set
			{
				this.depreciation_ThresholdFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_ThresholdSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Depreciation_Start_Date_At_Registration
		{
			get
			{
				return this.depreciation_Start_Date_At_RegistrationField;
			}
			set
			{
				this.depreciation_Start_Date_At_RegistrationField = value;
				this.RaisePropertyChanged("Depreciation_Start_Date_At_Registration");
			}
		}

		[XmlIgnore]
		public bool Depreciation_Start_Date_At_RegistrationSpecified
		{
			get
			{
				return this.depreciation_Start_Date_At_RegistrationFieldSpecified;
			}
			set
			{
				this.depreciation_Start_Date_At_RegistrationFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_Start_Date_At_RegistrationSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Accumulated_Depreciation_At_Registration
		{
			get
			{
				return this.accumulated_Depreciation_At_RegistrationField;
			}
			set
			{
				this.accumulated_Depreciation_At_RegistrationField = value;
				this.RaisePropertyChanged("Accumulated_Depreciation_At_Registration");
			}
		}

		[XmlIgnore]
		public bool Accumulated_Depreciation_At_RegistrationSpecified
		{
			get
			{
				return this.accumulated_Depreciation_At_RegistrationFieldSpecified;
			}
			set
			{
				this.accumulated_Depreciation_At_RegistrationFieldSpecified = value;
				this.RaisePropertyChanged("Accumulated_Depreciation_At_RegistrationSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Remaining_Useful_Life_At_Registration
		{
			get
			{
				return this.remaining_Useful_Life_At_RegistrationField;
			}
			set
			{
				this.remaining_Useful_Life_At_RegistrationField = value;
				this.RaisePropertyChanged("Remaining_Useful_Life_At_Registration");
			}
		}

		[XmlIgnore]
		public bool Remaining_Useful_Life_At_RegistrationSpecified
		{
			get
			{
				return this.remaining_Useful_Life_At_RegistrationFieldSpecified;
			}
			set
			{
				this.remaining_Useful_Life_At_RegistrationFieldSpecified = value;
				this.RaisePropertyChanged("Remaining_Useful_Life_At_RegistrationSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Max_Bonus_Depreciable_Basis
		{
			get
			{
				return this.max_Bonus_Depreciable_BasisField;
			}
			set
			{
				this.max_Bonus_Depreciable_BasisField = value;
				this.RaisePropertyChanged("Max_Bonus_Depreciable_Basis");
			}
		}

		[XmlIgnore]
		public bool Max_Bonus_Depreciable_BasisSpecified
		{
			get
			{
				return this.max_Bonus_Depreciable_BasisFieldSpecified;
			}
			set
			{
				this.max_Bonus_Depreciable_BasisFieldSpecified = value;
				this.RaisePropertyChanged("Max_Bonus_Depreciable_BasisSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Bonus_Depreciation_Percent
		{
			get
			{
				return this.bonus_Depreciation_PercentField;
			}
			set
			{
				this.bonus_Depreciation_PercentField = value;
				this.RaisePropertyChanged("Bonus_Depreciation_Percent");
			}
		}

		[XmlIgnore]
		public bool Bonus_Depreciation_PercentSpecified
		{
			get
			{
				return this.bonus_Depreciation_PercentFieldSpecified;
			}
			set
			{
				this.bonus_Depreciation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Bonus_Depreciation_PercentSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Historical_Bonus_Depreciation_for_Depreciation_Schedule
		{
			get
			{
				return this.historical_Bonus_Depreciation_for_Depreciation_ScheduleField;
			}
			set
			{
				this.historical_Bonus_Depreciation_for_Depreciation_ScheduleField = value;
				this.RaisePropertyChanged("Historical_Bonus_Depreciation_for_Depreciation_Schedule");
			}
		}

		[XmlIgnore]
		public bool Historical_Bonus_Depreciation_for_Depreciation_ScheduleSpecified
		{
			get
			{
				return this.historical_Bonus_Depreciation_for_Depreciation_ScheduleFieldSpecified;
			}
			set
			{
				this.historical_Bonus_Depreciation_for_Depreciation_ScheduleFieldSpecified = value;
				this.RaisePropertyChanged("Historical_Bonus_Depreciation_for_Depreciation_ScheduleSpecified");
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
