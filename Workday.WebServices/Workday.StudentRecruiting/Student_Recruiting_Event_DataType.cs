using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.StudentRecruiting
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Recruiting_Event_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string event_NameField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Time_ZoneObjectType time_Zone_ReferenceField;

		private string descriptionField;

		private Admissions_CounselorObjectType event_Owner_ReferenceField;

		private Student_Recruiting_CampaignObjectType campaign_ReferenceField;

		private Student_Recruiting_Event_LocationObjectType location_ReferenceField;

		private Student_Recruiting_Event_TypeObjectType event_Type_ReferenceField;

		private Admissions_CounselorObjectType[] staff_Recruiter_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal budgetField;

		private bool budgetFieldSpecified;

		private decimal planned_AttendanceField;

		private bool planned_AttendanceFieldSpecified;

		private bool private_EventField;

		private bool private_EventFieldSpecified;

		private Academic_ContactObjectType host_Contact_ReferenceField;

		private Student_Recruiting_Event_LocationObjectType host_Location_ReferenceField;

		private Engagement_Criteria_DataType engagement_Criteria_DataField;

		private Student_Recruiting_Event_Engagement_DataType[] student_Recruiting_Event_Engagement_DataField;

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
		public string Event_Name
		{
			get
			{
				return this.event_NameField;
			}
			set
			{
				this.event_NameField = value;
				this.RaisePropertyChanged("Event_Name");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Start_Date
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

		[XmlElement(Order = 3)]
		public DateTime End_Date
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

		[XmlElement(Order = 4)]
		public Time_ZoneObjectType Time_Zone_Reference
		{
			get
			{
				return this.time_Zone_ReferenceField;
			}
			set
			{
				this.time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Time_Zone_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Admissions_CounselorObjectType Event_Owner_Reference
		{
			get
			{
				return this.event_Owner_ReferenceField;
			}
			set
			{
				this.event_Owner_ReferenceField = value;
				this.RaisePropertyChanged("Event_Owner_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Student_Recruiting_CampaignObjectType Campaign_Reference
		{
			get
			{
				return this.campaign_ReferenceField;
			}
			set
			{
				this.campaign_ReferenceField = value;
				this.RaisePropertyChanged("Campaign_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Student_Recruiting_Event_LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Student_Recruiting_Event_TypeObjectType Event_Type_Reference
		{
			get
			{
				return this.event_Type_ReferenceField;
			}
			set
			{
				this.event_Type_ReferenceField = value;
				this.RaisePropertyChanged("Event_Type_Reference");
			}
		}

		[XmlElement("Staff_Recruiter_Reference", Order = 10)]
		public Admissions_CounselorObjectType[] Staff_Recruiter_Reference
		{
			get
			{
				return this.staff_Recruiter_ReferenceField;
			}
			set
			{
				this.staff_Recruiter_ReferenceField = value;
				this.RaisePropertyChanged("Staff_Recruiter_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public decimal Budget
		{
			get
			{
				return this.budgetField;
			}
			set
			{
				this.budgetField = value;
				this.RaisePropertyChanged("Budget");
			}
		}

		[XmlIgnore]
		public bool BudgetSpecified
		{
			get
			{
				return this.budgetFieldSpecified;
			}
			set
			{
				this.budgetFieldSpecified = value;
				this.RaisePropertyChanged("BudgetSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Planned_Attendance
		{
			get
			{
				return this.planned_AttendanceField;
			}
			set
			{
				this.planned_AttendanceField = value;
				this.RaisePropertyChanged("Planned_Attendance");
			}
		}

		[XmlIgnore]
		public bool Planned_AttendanceSpecified
		{
			get
			{
				return this.planned_AttendanceFieldSpecified;
			}
			set
			{
				this.planned_AttendanceFieldSpecified = value;
				this.RaisePropertyChanged("Planned_AttendanceSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public bool Private_Event
		{
			get
			{
				return this.private_EventField;
			}
			set
			{
				this.private_EventField = value;
				this.RaisePropertyChanged("Private_Event");
			}
		}

		[XmlIgnore]
		public bool Private_EventSpecified
		{
			get
			{
				return this.private_EventFieldSpecified;
			}
			set
			{
				this.private_EventFieldSpecified = value;
				this.RaisePropertyChanged("Private_EventSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public Academic_ContactObjectType Host_Contact_Reference
		{
			get
			{
				return this.host_Contact_ReferenceField;
			}
			set
			{
				this.host_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Host_Contact_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Student_Recruiting_Event_LocationObjectType Host_Location_Reference
		{
			get
			{
				return this.host_Location_ReferenceField;
			}
			set
			{
				this.host_Location_ReferenceField = value;
				this.RaisePropertyChanged("Host_Location_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Engagement_Criteria_DataType Engagement_Criteria_Data
		{
			get
			{
				return this.engagement_Criteria_DataField;
			}
			set
			{
				this.engagement_Criteria_DataField = value;
				this.RaisePropertyChanged("Engagement_Criteria_Data");
			}
		}

		[XmlElement("Student_Recruiting_Event_Engagement_Data", Order = 18)]
		public Student_Recruiting_Event_Engagement_DataType[] Student_Recruiting_Event_Engagement_Data
		{
			get
			{
				return this.student_Recruiting_Event_Engagement_DataField;
			}
			set
			{
				this.student_Recruiting_Event_Engagement_DataField = value;
				this.RaisePropertyChanged("Student_Recruiting_Event_Engagement_Data");
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
