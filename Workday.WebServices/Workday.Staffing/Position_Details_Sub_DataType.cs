using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Position_Details_Sub_DataType : INotifyPropertyChanged
	{
		private Job_ProfileObjectType job_Profile_ReferenceField;

		private string position_TitleField;

		private string business_TitleField;

		private LocationObjectType location_ReferenceField;

		private LocationObjectType work_Space_ReferenceField;

		private Position_Time_TypeObjectType position_Time_Type_ReferenceField;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private Work_Hours_ProfileObjectType work_Hours_Profile_ReferenceField;

		private decimal default_HoursField;

		private bool default_HoursFieldSpecified;

		private decimal scheduled_HoursField;

		private bool scheduled_HoursFieldSpecified;

		private FrequencyObjectType working_Time_Frequency_ReferenceField;

		private Working_Time_UnitObjectType working_Time_Unit_ReferenceField;

		private decimal working_Time_ValueField;

		private bool working_Time_ValueFieldSpecified;

		private Pay_Rate_TypeObjectType pay_Rate_Type_ReferenceField;

		private Job_ClassificationObjectType[] job_Classification_ReferenceField;

		private Company_Insider_TypeObjectType[] company_Insider_Type_ReferenceField;

		private Academic_Pay_PeriodObjectType annual_Work_Period_ReferenceField;

		private Academic_Pay_PeriodObjectType disbursement_Plan_Period_ReferenceField;

		private Workers_Compensation_CodeObjectType workers__Compensation_Code_Override_ReferenceField;

		private External_IDType[] position_External_ID_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Position_Title
		{
			get
			{
				return this.position_TitleField;
			}
			set
			{
				this.position_TitleField = value;
				this.RaisePropertyChanged("Position_Title");
			}
		}

		[XmlElement(Order = 2)]
		public string Business_Title
		{
			get
			{
				return this.business_TitleField;
			}
			set
			{
				this.business_TitleField = value;
				this.RaisePropertyChanged("Business_Title");
			}
		}

		[XmlElement(Order = 3)]
		public LocationObjectType Location_Reference
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

		[XmlElement(Order = 4)]
		public LocationObjectType Work_Space_Reference
		{
			get
			{
				return this.work_Space_ReferenceField;
			}
			set
			{
				this.work_Space_ReferenceField = value;
				this.RaisePropertyChanged("Work_Space_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Position_Time_TypeObjectType Position_Time_Type_Reference
		{
			get
			{
				return this.position_Time_Type_ReferenceField;
			}
			set
			{
				this.position_Time_Type_ReferenceField = value;
				this.RaisePropertyChanged("Position_Time_Type_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Work_Hours_ProfileObjectType Work_Hours_Profile_Reference
		{
			get
			{
				return this.work_Hours_Profile_ReferenceField;
			}
			set
			{
				this.work_Hours_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Work_Hours_Profile_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Default_Hours
		{
			get
			{
				return this.default_HoursField;
			}
			set
			{
				this.default_HoursField = value;
				this.RaisePropertyChanged("Default_Hours");
			}
		}

		[XmlIgnore]
		public bool Default_HoursSpecified
		{
			get
			{
				return this.default_HoursFieldSpecified;
			}
			set
			{
				this.default_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Default_HoursSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Scheduled_Hours
		{
			get
			{
				return this.scheduled_HoursField;
			}
			set
			{
				this.scheduled_HoursField = value;
				this.RaisePropertyChanged("Scheduled_Hours");
			}
		}

		[XmlIgnore]
		public bool Scheduled_HoursSpecified
		{
			get
			{
				return this.scheduled_HoursFieldSpecified;
			}
			set
			{
				this.scheduled_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_HoursSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public FrequencyObjectType Working_Time_Frequency_Reference
		{
			get
			{
				return this.working_Time_Frequency_ReferenceField;
			}
			set
			{
				this.working_Time_Frequency_ReferenceField = value;
				this.RaisePropertyChanged("Working_Time_Frequency_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Working_Time_UnitObjectType Working_Time_Unit_Reference
		{
			get
			{
				return this.working_Time_Unit_ReferenceField;
			}
			set
			{
				this.working_Time_Unit_ReferenceField = value;
				this.RaisePropertyChanged("Working_Time_Unit_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Working_Time_Value
		{
			get
			{
				return this.working_Time_ValueField;
			}
			set
			{
				this.working_Time_ValueField = value;
				this.RaisePropertyChanged("Working_Time_Value");
			}
		}

		[XmlIgnore]
		public bool Working_Time_ValueSpecified
		{
			get
			{
				return this.working_Time_ValueFieldSpecified;
			}
			set
			{
				this.working_Time_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Working_Time_ValueSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Pay_Rate_TypeObjectType Pay_Rate_Type_Reference
		{
			get
			{
				return this.pay_Rate_Type_ReferenceField;
			}
			set
			{
				this.pay_Rate_Type_ReferenceField = value;
				this.RaisePropertyChanged("Pay_Rate_Type_Reference");
			}
		}

		[XmlElement("Job_Classification_Reference", Order = 14)]
		public Job_ClassificationObjectType[] Job_Classification_Reference
		{
			get
			{
				return this.job_Classification_ReferenceField;
			}
			set
			{
				this.job_Classification_ReferenceField = value;
				this.RaisePropertyChanged("Job_Classification_Reference");
			}
		}

		[XmlElement("Company_Insider_Type_Reference", Order = 15)]
		public Company_Insider_TypeObjectType[] Company_Insider_Type_Reference
		{
			get
			{
				return this.company_Insider_Type_ReferenceField;
			}
			set
			{
				this.company_Insider_Type_ReferenceField = value;
				this.RaisePropertyChanged("Company_Insider_Type_Reference");
			}
		}

		[XmlElement(Order = 16)]
		public Academic_Pay_PeriodObjectType Annual_Work_Period_Reference
		{
			get
			{
				return this.annual_Work_Period_ReferenceField;
			}
			set
			{
				this.annual_Work_Period_ReferenceField = value;
				this.RaisePropertyChanged("Annual_Work_Period_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Academic_Pay_PeriodObjectType Disbursement_Plan_Period_Reference
		{
			get
			{
				return this.disbursement_Plan_Period_ReferenceField;
			}
			set
			{
				this.disbursement_Plan_Period_ReferenceField = value;
				this.RaisePropertyChanged("Disbursement_Plan_Period_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public Workers_Compensation_CodeObjectType Workers__Compensation_Code_Override_Reference
		{
			get
			{
				return this.workers__Compensation_Code_Override_ReferenceField;
			}
			set
			{
				this.workers__Compensation_Code_Override_ReferenceField = value;
				this.RaisePropertyChanged("Workers__Compensation_Code_Override_Reference");
			}
		}

		[XmlArray(Order = 19), XmlArrayItem("External_ID", IsNullable = false)]
		public External_IDType[] Position_External_ID_Data
		{
			get
			{
				return this.position_External_ID_DataField;
			}
			set
			{
				this.position_External_ID_DataField = value;
				this.RaisePropertyChanged("Position_External_ID_Data");
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
