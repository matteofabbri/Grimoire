using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Recruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Requisition_Restrictions_DataType : INotifyPropertyChanged
	{
		private DateTime recruiting_Start_DateField;

		private bool recruiting_Start_DateFieldSpecified;

		private DateTime target_Hire_DateField;

		private bool target_Hire_DateFieldSpecified;

		private DateTime target_End_DateField;

		private bool target_End_DateFieldSpecified;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private Worker_TypeObjectType worker_Type_ReferenceField;

		private Position_Worker_TypeObjectType position_Worker_Type_ReferenceField;

		private LocationObjectType primary_Location_ReferenceField;

		private LocationObjectType primary_Job_Posting_Location_ReferenceField;

		private LocationObjectType[] additional_Locations_ReferenceField;

		private LocationObjectType[] additional_Job_Posting_Location_ReferenceField;

		private Position_Time_TypeObjectType time_Type_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private OneTime_Payment_PlanObjectType referral_Payment_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Recruiting_Start_Date
		{
			get
			{
				return this.recruiting_Start_DateField;
			}
			set
			{
				this.recruiting_Start_DateField = value;
				this.RaisePropertyChanged("Recruiting_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Recruiting_Start_DateSpecified
		{
			get
			{
				return this.recruiting_Start_DateFieldSpecified;
			}
			set
			{
				this.recruiting_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Recruiting_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Target_Hire_Date
		{
			get
			{
				return this.target_Hire_DateField;
			}
			set
			{
				this.target_Hire_DateField = value;
				this.RaisePropertyChanged("Target_Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Target_Hire_DateSpecified
		{
			get
			{
				return this.target_Hire_DateFieldSpecified;
			}
			set
			{
				this.target_Hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Target_Hire_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Target_End_Date
		{
			get
			{
				return this.target_End_DateField;
			}
			set
			{
				this.target_End_DateField = value;
				this.RaisePropertyChanged("Target_End_Date");
			}
		}

		[XmlIgnore]
		public bool Target_End_DateSpecified
		{
			get
			{
				return this.target_End_DateFieldSpecified;
			}
			set
			{
				this.target_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Target_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Job_ProfileObjectType Job_Profile_Reference
		{
			get
			{
				return this.job_Profile_ReferenceField;
			}
			set
			{
				this.job_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Job_Profile_Reference");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Position_Worker_TypeObjectType Position_Worker_Type_Reference
		{
			get
			{
				return this.position_Worker_Type_ReferenceField;
			}
			set
			{
				this.position_Worker_Type_ReferenceField = value;
				this.RaisePropertyChanged("Position_Worker_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public LocationObjectType Primary_Location_Reference
		{
			get
			{
				return this.primary_Location_ReferenceField;
			}
			set
			{
				this.primary_Location_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Location_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public LocationObjectType Primary_Job_Posting_Location_Reference
		{
			get
			{
				return this.primary_Job_Posting_Location_ReferenceField;
			}
			set
			{
				this.primary_Job_Posting_Location_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Job_Posting_Location_Reference");
			}
		}

		[XmlElement("Additional_Locations_Reference", Order = 8)]
		public LocationObjectType[] Additional_Locations_Reference
		{
			get
			{
				return this.additional_Locations_ReferenceField;
			}
			set
			{
				this.additional_Locations_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Locations_Reference");
			}
		}

		[XmlElement("Additional_Job_Posting_Location_Reference", Order = 9)]
		public LocationObjectType[] Additional_Job_Posting_Location_Reference
		{
			get
			{
				return this.additional_Job_Posting_Location_ReferenceField;
			}
			set
			{
				this.additional_Job_Posting_Location_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Job_Posting_Location_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Position_Time_TypeObjectType Time_Type_Reference
		{
			get
			{
				return this.time_Type_ReferenceField;
			}
			set
			{
				this.time_Type_ReferenceField = value;
				this.RaisePropertyChanged("Time_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Work_ShiftObjectType Work_Shift_Reference
		{
			get
			{
				return this.work_Shift_ReferenceField;
			}
			set
			{
				this.work_Shift_ReferenceField = value;
				this.RaisePropertyChanged("Work_Shift_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public OneTime_Payment_PlanObjectType Referral_Payment_Plan_Reference
		{
			get
			{
				return this.referral_Payment_Plan_ReferenceField;
			}
			set
			{
				this.referral_Payment_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Referral_Payment_Plan_Reference");
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
