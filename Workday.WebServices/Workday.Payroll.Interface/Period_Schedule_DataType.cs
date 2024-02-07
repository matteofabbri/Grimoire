using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Period_Schedule_DataType : INotifyPropertyChanged
	{
		private string period_Schedule_IDField;

		private string period_Schedule_NameField;

		private FrequencyObjectType frequency_ReferenceField;

		private Period_Schedule_UsageObjectType[] usage_ReferenceField;

		private decimal payment_Date_AutoAdjust_SaturdayField;

		private bool payment_Date_AutoAdjust_SaturdayFieldSpecified;

		private decimal payment_Date_AutoAdjust_SundayField;

		private bool payment_Date_AutoAdjust_SundayFieldSpecified;

		private bool allow_Timesheet_ChangesField;

		private bool allow_Timesheet_ChangesFieldSpecified;

		private Period_ScheduleObjectType payroll_Period_Schedule_ReferenceField;

		private Time_Tracking_Eligibility_RuleObjectType[] time_Tracking_Eligibility_Rule_ReferenceField;

		private Period_DataType[] period_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Period_Schedule_ID
		{
			get
			{
				return this.period_Schedule_IDField;
			}
			set
			{
				this.period_Schedule_IDField = value;
				this.RaisePropertyChanged("Period_Schedule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Period_Schedule_Name
		{
			get
			{
				return this.period_Schedule_NameField;
			}
			set
			{
				this.period_Schedule_NameField = value;
				this.RaisePropertyChanged("Period_Schedule_Name");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement("Usage_Reference", Order = 3)]
		public Period_Schedule_UsageObjectType[] Usage_Reference
		{
			get
			{
				return this.usage_ReferenceField;
			}
			set
			{
				this.usage_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Reference");
			}
		}

		[XmlElement("Payment_Date_Auto-Adjust_Saturday", Order = 4)]
		public decimal Payment_Date_AutoAdjust_Saturday
		{
			get
			{
				return this.payment_Date_AutoAdjust_SaturdayField;
			}
			set
			{
				this.payment_Date_AutoAdjust_SaturdayField = value;
				this.RaisePropertyChanged("Payment_Date_AutoAdjust_Saturday");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_AutoAdjust_SaturdaySpecified
		{
			get
			{
				return this.payment_Date_AutoAdjust_SaturdayFieldSpecified;
			}
			set
			{
				this.payment_Date_AutoAdjust_SaturdayFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_AutoAdjust_SaturdaySpecified");
			}
		}

		[XmlElement("Payment_Date_Auto-Adjust_Sunday", Order = 5)]
		public decimal Payment_Date_AutoAdjust_Sunday
		{
			get
			{
				return this.payment_Date_AutoAdjust_SundayField;
			}
			set
			{
				this.payment_Date_AutoAdjust_SundayField = value;
				this.RaisePropertyChanged("Payment_Date_AutoAdjust_Sunday");
			}
		}

		[XmlIgnore]
		public bool Payment_Date_AutoAdjust_SundaySpecified
		{
			get
			{
				return this.payment_Date_AutoAdjust_SundayFieldSpecified;
			}
			set
			{
				this.payment_Date_AutoAdjust_SundayFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Date_AutoAdjust_SundaySpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Allow_Timesheet_Changes
		{
			get
			{
				return this.allow_Timesheet_ChangesField;
			}
			set
			{
				this.allow_Timesheet_ChangesField = value;
				this.RaisePropertyChanged("Allow_Timesheet_Changes");
			}
		}

		[XmlIgnore]
		public bool Allow_Timesheet_ChangesSpecified
		{
			get
			{
				return this.allow_Timesheet_ChangesFieldSpecified;
			}
			set
			{
				this.allow_Timesheet_ChangesFieldSpecified = value;
				this.RaisePropertyChanged("Allow_Timesheet_ChangesSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Period_ScheduleObjectType Payroll_Period_Schedule_Reference
		{
			get
			{
				return this.payroll_Period_Schedule_ReferenceField;
			}
			set
			{
				this.payroll_Period_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Period_Schedule_Reference");
			}
		}

		[XmlElement("Time_Tracking_Eligibility_Rule_Reference", Order = 8)]
		public Time_Tracking_Eligibility_RuleObjectType[] Time_Tracking_Eligibility_Rule_Reference
		{
			get
			{
				return this.time_Tracking_Eligibility_Rule_ReferenceField;
			}
			set
			{
				this.time_Tracking_Eligibility_Rule_ReferenceField = value;
				this.RaisePropertyChanged("Time_Tracking_Eligibility_Rule_Reference");
			}
		}

		[XmlElement("Period_Data", Order = 9)]
		public Period_DataType[] Period_Data
		{
			get
			{
				return this.period_DataField;
			}
			set
			{
				this.period_DataField = value;
				this.RaisePropertyChanged("Period_Data");
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
