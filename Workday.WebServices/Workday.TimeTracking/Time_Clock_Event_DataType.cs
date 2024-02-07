using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.TimeTrackingService
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Time_Clock_Event_DataType : INotifyPropertyChanged
	{
		private string time_Clock_Event_IDField;

		private bool delete_Time_Clock_EventField;

		private bool delete_Time_Clock_EventFieldSpecified;

		private string employee_IDField;

		private string position_IDField;

		private DateTime time_Clock_Event_Date_TimeField;

		private bool time_Clock_Event_Date_TimeFieldSpecified;

		private string time_Entry_CodeField;

		private string project_IDField;

		private string task_IDField;

		private Time_Punch_TypeObjectType clock_Event_Type_ReferenceField;

		private decimal override_RateField;

		private bool override_RateFieldSpecified;

		private string business_UnitField;

		private string cost_CenterField;

		private string custom_Organization_01Field;

		private string custom_Organization_02Field;

		private string custom_Organization_03Field;

		private string custom_Organization_04Field;

		private string custom_Organization_05Field;

		private string custom_Organization_06Field;

		private string custom_Organization_07Field;

		private string custom_Organization_08Field;

		private string custom_Organization_09Field;

		private string custom_Organization_10Field;

		private string custom_Worktag_01Field;

		private string custom_Worktag_02Field;

		private string custom_Worktag_03Field;

		private string custom_Worktag_04Field;

		private string custom_Worktag_05Field;

		private string custom_Worktag_06Field;

		private string custom_Worktag_07Field;

		private string custom_Worktag_08Field;

		private string custom_Worktag_09Field;

		private string custom_Worktag_10Field;

		private string custom_Worktag_11Field;

		private string custom_Worktag_12Field;

		private string custom_Worktag_13Field;

		private string custom_Worktag_14Field;

		private string custom_Worktag_15Field;

		private string fundField;

		private string giftField;

		private string grantField;

		private string job_ProfileField;

		private string locationField;

		private string programField;

		private string regionField;

		private string commentField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Time_Clock_Event_ID
		{
			get
			{
				return this.time_Clock_Event_IDField;
			}
			set
			{
				this.time_Clock_Event_IDField = value;
				this.RaisePropertyChanged("Time_Clock_Event_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Delete_Time_Clock_Event
		{
			get
			{
				return this.delete_Time_Clock_EventField;
			}
			set
			{
				this.delete_Time_Clock_EventField = value;
				this.RaisePropertyChanged("Delete_Time_Clock_Event");
			}
		}

		[XmlIgnore]
		public bool Delete_Time_Clock_EventSpecified
		{
			get
			{
				return this.delete_Time_Clock_EventFieldSpecified;
			}
			set
			{
				this.delete_Time_Clock_EventFieldSpecified = value;
				this.RaisePropertyChanged("Delete_Time_Clock_EventSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public string Employee_ID
		{
			get
			{
				return this.employee_IDField;
			}
			set
			{
				this.employee_IDField = value;
				this.RaisePropertyChanged("Employee_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Position_ID
		{
			get
			{
				return this.position_IDField;
			}
			set
			{
				this.position_IDField = value;
				this.RaisePropertyChanged("Position_ID");
			}
		}

		[XmlElement(Order = 4)]
		public DateTime Time_Clock_Event_Date_Time
		{
			get
			{
				return this.time_Clock_Event_Date_TimeField;
			}
			set
			{
				this.time_Clock_Event_Date_TimeField = value;
				this.RaisePropertyChanged("Time_Clock_Event_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Time_Clock_Event_Date_TimeSpecified
		{
			get
			{
				return this.time_Clock_Event_Date_TimeFieldSpecified;
			}
			set
			{
				this.time_Clock_Event_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Time_Clock_Event_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Time_Entry_Code
		{
			get
			{
				return this.time_Entry_CodeField;
			}
			set
			{
				this.time_Entry_CodeField = value;
				this.RaisePropertyChanged("Time_Entry_Code");
			}
		}

		[XmlElement(Order = 6)]
		public string Project_ID
		{
			get
			{
				return this.project_IDField;
			}
			set
			{
				this.project_IDField = value;
				this.RaisePropertyChanged("Project_ID");
			}
		}

		[XmlElement(Order = 7)]
		public string Task_ID
		{
			get
			{
				return this.task_IDField;
			}
			set
			{
				this.task_IDField = value;
				this.RaisePropertyChanged("Task_ID");
			}
		}

		[XmlElement(Order = 8)]
		public Time_Punch_TypeObjectType Clock_Event_Type_Reference
		{
			get
			{
				return this.clock_Event_Type_ReferenceField;
			}
			set
			{
				this.clock_Event_Type_ReferenceField = value;
				this.RaisePropertyChanged("Clock_Event_Type_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Override_Rate
		{
			get
			{
				return this.override_RateField;
			}
			set
			{
				this.override_RateField = value;
				this.RaisePropertyChanged("Override_Rate");
			}
		}

		[XmlIgnore]
		public bool Override_RateSpecified
		{
			get
			{
				return this.override_RateFieldSpecified;
			}
			set
			{
				this.override_RateFieldSpecified = value;
				this.RaisePropertyChanged("Override_RateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Business_Unit
		{
			get
			{
				return this.business_UnitField;
			}
			set
			{
				this.business_UnitField = value;
				this.RaisePropertyChanged("Business_Unit");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public string Custom_Organization_01
		{
			get
			{
				return this.custom_Organization_01Field;
			}
			set
			{
				this.custom_Organization_01Field = value;
				this.RaisePropertyChanged("Custom_Organization_01");
			}
		}

		[XmlElement(Order = 13)]
		public string Custom_Organization_02
		{
			get
			{
				return this.custom_Organization_02Field;
			}
			set
			{
				this.custom_Organization_02Field = value;
				this.RaisePropertyChanged("Custom_Organization_02");
			}
		}

		[XmlElement(Order = 14)]
		public string Custom_Organization_03
		{
			get
			{
				return this.custom_Organization_03Field;
			}
			set
			{
				this.custom_Organization_03Field = value;
				this.RaisePropertyChanged("Custom_Organization_03");
			}
		}

		[XmlElement(Order = 15)]
		public string Custom_Organization_04
		{
			get
			{
				return this.custom_Organization_04Field;
			}
			set
			{
				this.custom_Organization_04Field = value;
				this.RaisePropertyChanged("Custom_Organization_04");
			}
		}

		[XmlElement(Order = 16)]
		public string Custom_Organization_05
		{
			get
			{
				return this.custom_Organization_05Field;
			}
			set
			{
				this.custom_Organization_05Field = value;
				this.RaisePropertyChanged("Custom_Organization_05");
			}
		}

		[XmlElement(Order = 17)]
		public string Custom_Organization_06
		{
			get
			{
				return this.custom_Organization_06Field;
			}
			set
			{
				this.custom_Organization_06Field = value;
				this.RaisePropertyChanged("Custom_Organization_06");
			}
		}

		[XmlElement(Order = 18)]
		public string Custom_Organization_07
		{
			get
			{
				return this.custom_Organization_07Field;
			}
			set
			{
				this.custom_Organization_07Field = value;
				this.RaisePropertyChanged("Custom_Organization_07");
			}
		}

		[XmlElement(Order = 19)]
		public string Custom_Organization_08
		{
			get
			{
				return this.custom_Organization_08Field;
			}
			set
			{
				this.custom_Organization_08Field = value;
				this.RaisePropertyChanged("Custom_Organization_08");
			}
		}

		[XmlElement(Order = 20)]
		public string Custom_Organization_09
		{
			get
			{
				return this.custom_Organization_09Field;
			}
			set
			{
				this.custom_Organization_09Field = value;
				this.RaisePropertyChanged("Custom_Organization_09");
			}
		}

		[XmlElement(Order = 21)]
		public string Custom_Organization_10
		{
			get
			{
				return this.custom_Organization_10Field;
			}
			set
			{
				this.custom_Organization_10Field = value;
				this.RaisePropertyChanged("Custom_Organization_10");
			}
		}

		[XmlElement(Order = 22)]
		public string Custom_Worktag_01
		{
			get
			{
				return this.custom_Worktag_01Field;
			}
			set
			{
				this.custom_Worktag_01Field = value;
				this.RaisePropertyChanged("Custom_Worktag_01");
			}
		}

		[XmlElement(Order = 23)]
		public string Custom_Worktag_02
		{
			get
			{
				return this.custom_Worktag_02Field;
			}
			set
			{
				this.custom_Worktag_02Field = value;
				this.RaisePropertyChanged("Custom_Worktag_02");
			}
		}

		[XmlElement(Order = 24)]
		public string Custom_Worktag_03
		{
			get
			{
				return this.custom_Worktag_03Field;
			}
			set
			{
				this.custom_Worktag_03Field = value;
				this.RaisePropertyChanged("Custom_Worktag_03");
			}
		}

		[XmlElement(Order = 25)]
		public string Custom_Worktag_04
		{
			get
			{
				return this.custom_Worktag_04Field;
			}
			set
			{
				this.custom_Worktag_04Field = value;
				this.RaisePropertyChanged("Custom_Worktag_04");
			}
		}

		[XmlElement(Order = 26)]
		public string Custom_Worktag_05
		{
			get
			{
				return this.custom_Worktag_05Field;
			}
			set
			{
				this.custom_Worktag_05Field = value;
				this.RaisePropertyChanged("Custom_Worktag_05");
			}
		}

		[XmlElement(Order = 27)]
		public string Custom_Worktag_06
		{
			get
			{
				return this.custom_Worktag_06Field;
			}
			set
			{
				this.custom_Worktag_06Field = value;
				this.RaisePropertyChanged("Custom_Worktag_06");
			}
		}

		[XmlElement(Order = 28)]
		public string Custom_Worktag_07
		{
			get
			{
				return this.custom_Worktag_07Field;
			}
			set
			{
				this.custom_Worktag_07Field = value;
				this.RaisePropertyChanged("Custom_Worktag_07");
			}
		}

		[XmlElement(Order = 29)]
		public string Custom_Worktag_08
		{
			get
			{
				return this.custom_Worktag_08Field;
			}
			set
			{
				this.custom_Worktag_08Field = value;
				this.RaisePropertyChanged("Custom_Worktag_08");
			}
		}

		[XmlElement(Order = 30)]
		public string Custom_Worktag_09
		{
			get
			{
				return this.custom_Worktag_09Field;
			}
			set
			{
				this.custom_Worktag_09Field = value;
				this.RaisePropertyChanged("Custom_Worktag_09");
			}
		}

		[XmlElement(Order = 31)]
		public string Custom_Worktag_10
		{
			get
			{
				return this.custom_Worktag_10Field;
			}
			set
			{
				this.custom_Worktag_10Field = value;
				this.RaisePropertyChanged("Custom_Worktag_10");
			}
		}

		[XmlElement(Order = 32)]
		public string Custom_Worktag_11
		{
			get
			{
				return this.custom_Worktag_11Field;
			}
			set
			{
				this.custom_Worktag_11Field = value;
				this.RaisePropertyChanged("Custom_Worktag_11");
			}
		}

		[XmlElement(Order = 33)]
		public string Custom_Worktag_12
		{
			get
			{
				return this.custom_Worktag_12Field;
			}
			set
			{
				this.custom_Worktag_12Field = value;
				this.RaisePropertyChanged("Custom_Worktag_12");
			}
		}

		[XmlElement(Order = 34)]
		public string Custom_Worktag_13
		{
			get
			{
				return this.custom_Worktag_13Field;
			}
			set
			{
				this.custom_Worktag_13Field = value;
				this.RaisePropertyChanged("Custom_Worktag_13");
			}
		}

		[XmlElement(Order = 35)]
		public string Custom_Worktag_14
		{
			get
			{
				return this.custom_Worktag_14Field;
			}
			set
			{
				this.custom_Worktag_14Field = value;
				this.RaisePropertyChanged("Custom_Worktag_14");
			}
		}

		[XmlElement(Order = 36)]
		public string Custom_Worktag_15
		{
			get
			{
				return this.custom_Worktag_15Field;
			}
			set
			{
				this.custom_Worktag_15Field = value;
				this.RaisePropertyChanged("Custom_Worktag_15");
			}
		}

		[XmlElement(Order = 37)]
		public string Fund
		{
			get
			{
				return this.fundField;
			}
			set
			{
				this.fundField = value;
				this.RaisePropertyChanged("Fund");
			}
		}

		[XmlElement(Order = 38)]
		public string Gift
		{
			get
			{
				return this.giftField;
			}
			set
			{
				this.giftField = value;
				this.RaisePropertyChanged("Gift");
			}
		}

		[XmlElement(Order = 39)]
		public string Grant
		{
			get
			{
				return this.grantField;
			}
			set
			{
				this.grantField = value;
				this.RaisePropertyChanged("Grant");
			}
		}

		[XmlElement(Order = 40)]
		public string Job_Profile
		{
			get
			{
				return this.job_ProfileField;
			}
			set
			{
				this.job_ProfileField = value;
				this.RaisePropertyChanged("Job_Profile");
			}
		}

		[XmlElement(Order = 41)]
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

		[XmlElement(Order = 42)]
		public string Program
		{
			get
			{
				return this.programField;
			}
			set
			{
				this.programField = value;
				this.RaisePropertyChanged("Program");
			}
		}

		[XmlElement(Order = 43)]
		public string Region
		{
			get
			{
				return this.regionField;
			}
			set
			{
				this.regionField = value;
				this.RaisePropertyChanged("Region");
			}
		}

		[XmlElement(Order = 44)]
		public string Comment
		{
			get
			{
				return this.commentField;
			}
			set
			{
				this.commentField = value;
				this.RaisePropertyChanged("Comment");
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
