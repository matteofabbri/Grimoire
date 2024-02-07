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
	public class Position_Detail_DataType : INotifyPropertyChanged
	{
		private Position_ElementObjectType position_ReferenceField;

		private Headcount_RestrictionsObjectType headcount_ReferenceField;

		private string position_IDField;

		private string position_TitleField;

		private string business_TitleField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private Event_Classification_SubcategoryObjectType[] end_Employment_Reason_ReferenceField;

		private Position_Worker_TypeObjectType worker_Type_ReferenceField;

		private Position_Time_TypeObjectType position_Time_Type_ReferenceField;

		private bool job_ExemptField;

		private bool job_ExemptFieldSpecified;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private decimal default_Weekly_HoursField;

		private bool default_Weekly_HoursFieldSpecified;

		private FrequencyObjectType working_Time_Frequency_ReferenceField;

		private Working_Time_UnitObjectType working_Time_Unit_ReferenceField;

		private decimal working_Time_ValueField;

		private bool working_Time_ValueFieldSpecified;

		private decimal full_Time_Equivalent_PercentageField;

		private bool full_Time_Equivalent_PercentageFieldSpecified;

		private bool exclude_from_HeadcountField;

		private bool exclude_from_HeadcountFieldSpecified;

		private Pay_Rate_TypeObjectType pay_Rate_Type_ReferenceField;

		private Job_Classification_Summary_DataType[] job_Classification_Summary_DataField;

		private Company_Insider_TypeObjectType[] company_Insider_ReferenceField;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private Work_Hours_ProfileObjectType work_Hours_Profiles_ReferenceField;

		private string federal_Withholding_FEINField;

		private Worker_Compensation_Code_DataType[] worker_Compensation_Code_DataField;

		private Position_Payroll_Reporting_Code_DataType[] position_Payroll_Reporting_Code_DataField;

		private Job_Profile_in_Position_Summary_DataType job_Profile_Summary_DataField;

		private Location_Summary_DataType business_Site_Summary_DataField;

		private Position_Payroll_Interface_Detail_DataType payroll_Interface_Processing_DataField;

		private decimal regular_Paid_Equivalent_HoursField;

		private bool regular_Paid_Equivalent_HoursFieldSpecified;

		private string worker_Hours_Profile_ClassificationField;

		private International_Assignment_DataType international_Assignment_DataField;

		private LocationObjectType work_Space__ReferenceField;

		private Academic_Pay_Setup_DataType academic_Pay_Setup_DataField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private DateTime pay_Through_DateField;

		private bool pay_Through_DateFieldSpecified;

		private Collective_Agreement_Summary_DataType[] collective_Agreement_Summary_DataField;

		private Employee_Probation_Period_Detail_DataType[] employee_Probation_Period_Summary_DataField;

		private WorkerObjectType[] manager_as_of_last_detected_manager_change_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_ElementObjectType Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Headcount_RestrictionsObjectType Headcount_Reference
		{
			get
			{
				return this.headcount_ReferenceField;
			}
			set
			{
				this.headcount_ReferenceField = value;
				this.RaisePropertyChanged("Headcount_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime End_Employment_Date
		{
			get
			{
				return this.end_Employment_DateField;
			}
			set
			{
				this.end_Employment_DateField = value;
				this.RaisePropertyChanged("End_Employment_Date");
			}
		}

		[XmlIgnore]
		public bool End_Employment_DateSpecified
		{
			get
			{
				return this.end_Employment_DateFieldSpecified;
			}
			set
			{
				this.end_Employment_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_Employment_DateSpecified");
			}
		}

		[XmlElement("End_Employment_Reason_Reference", Order = 7)]
		public Event_Classification_SubcategoryObjectType[] End_Employment_Reason_Reference
		{
			get
			{
				return this.end_Employment_Reason_ReferenceField;
			}
			set
			{
				this.end_Employment_Reason_ReferenceField = value;
				this.RaisePropertyChanged("End_Employment_Reason_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Position_Worker_TypeObjectType Worker_Type_Reference
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public bool Job_Exempt
		{
			get
			{
				return this.job_ExemptField;
			}
			set
			{
				this.job_ExemptField = value;
				this.RaisePropertyChanged("Job_Exempt");
			}
		}

		[XmlIgnore]
		public bool Job_ExemptSpecified
		{
			get
			{
				return this.job_ExemptFieldSpecified;
			}
			set
			{
				this.job_ExemptFieldSpecified = value;
				this.RaisePropertyChanged("Job_ExemptSpecified");
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
		public decimal Default_Weekly_Hours
		{
			get
			{
				return this.default_Weekly_HoursField;
			}
			set
			{
				this.default_Weekly_HoursField = value;
				this.RaisePropertyChanged("Default_Weekly_Hours");
			}
		}

		[XmlIgnore]
		public bool Default_Weekly_HoursSpecified
		{
			get
			{
				return this.default_Weekly_HoursFieldSpecified;
			}
			set
			{
				this.default_Weekly_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Default_Weekly_HoursSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public decimal Full_Time_Equivalent_Percentage
		{
			get
			{
				return this.full_Time_Equivalent_PercentageField;
			}
			set
			{
				this.full_Time_Equivalent_PercentageField = value;
				this.RaisePropertyChanged("Full_Time_Equivalent_Percentage");
			}
		}

		[XmlIgnore]
		public bool Full_Time_Equivalent_PercentageSpecified
		{
			get
			{
				return this.full_Time_Equivalent_PercentageFieldSpecified;
			}
			set
			{
				this.full_Time_Equivalent_PercentageFieldSpecified = value;
				this.RaisePropertyChanged("Full_Time_Equivalent_PercentageSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public bool Exclude_from_Headcount
		{
			get
			{
				return this.exclude_from_HeadcountField;
			}
			set
			{
				this.exclude_from_HeadcountField = value;
				this.RaisePropertyChanged("Exclude_from_Headcount");
			}
		}

		[XmlIgnore]
		public bool Exclude_from_HeadcountSpecified
		{
			get
			{
				return this.exclude_from_HeadcountFieldSpecified;
			}
			set
			{
				this.exclude_from_HeadcountFieldSpecified = value;
				this.RaisePropertyChanged("Exclude_from_HeadcountSpecified");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement("Job_Classification_Summary_Data", Order = 19)]
		public Job_Classification_Summary_DataType[] Job_Classification_Summary_Data
		{
			get
			{
				return this.job_Classification_Summary_DataField;
			}
			set
			{
				this.job_Classification_Summary_DataField = value;
				this.RaisePropertyChanged("Job_Classification_Summary_Data");
			}
		}

		[XmlElement("Company_Insider_Reference", Order = 20)]
		public Company_Insider_TypeObjectType[] Company_Insider_Reference
		{
			get
			{
				return this.company_Insider_ReferenceField;
			}
			set
			{
				this.company_Insider_ReferenceField = value;
				this.RaisePropertyChanged("Company_Insider_Reference");
			}
		}

		[XmlElement(Order = 21)]
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

		[XmlElement(Order = 22)]
		public Work_Hours_ProfileObjectType Work_Hours_Profiles_Reference
		{
			get
			{
				return this.work_Hours_Profiles_ReferenceField;
			}
			set
			{
				this.work_Hours_Profiles_ReferenceField = value;
				this.RaisePropertyChanged("Work_Hours_Profiles_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public string Federal_Withholding_FEIN
		{
			get
			{
				return this.federal_Withholding_FEINField;
			}
			set
			{
				this.federal_Withholding_FEINField = value;
				this.RaisePropertyChanged("Federal_Withholding_FEIN");
			}
		}

		[XmlElement("Worker_Compensation_Code_Data", Order = 24)]
		public Worker_Compensation_Code_DataType[] Worker_Compensation_Code_Data
		{
			get
			{
				return this.worker_Compensation_Code_DataField;
			}
			set
			{
				this.worker_Compensation_Code_DataField = value;
				this.RaisePropertyChanged("Worker_Compensation_Code_Data");
			}
		}

		[XmlElement("Position_Payroll_Reporting_Code_Data", Order = 25)]
		public Position_Payroll_Reporting_Code_DataType[] Position_Payroll_Reporting_Code_Data
		{
			get
			{
				return this.position_Payroll_Reporting_Code_DataField;
			}
			set
			{
				this.position_Payroll_Reporting_Code_DataField = value;
				this.RaisePropertyChanged("Position_Payroll_Reporting_Code_Data");
			}
		}

		[XmlElement(Order = 26)]
		public Job_Profile_in_Position_Summary_DataType Job_Profile_Summary_Data
		{
			get
			{
				return this.job_Profile_Summary_DataField;
			}
			set
			{
				this.job_Profile_Summary_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Summary_Data");
			}
		}

		[XmlElement(Order = 27)]
		public Location_Summary_DataType Business_Site_Summary_Data
		{
			get
			{
				return this.business_Site_Summary_DataField;
			}
			set
			{
				this.business_Site_Summary_DataField = value;
				this.RaisePropertyChanged("Business_Site_Summary_Data");
			}
		}

		[XmlElement(Order = 28)]
		public Position_Payroll_Interface_Detail_DataType Payroll_Interface_Processing_Data
		{
			get
			{
				return this.payroll_Interface_Processing_DataField;
			}
			set
			{
				this.payroll_Interface_Processing_DataField = value;
				this.RaisePropertyChanged("Payroll_Interface_Processing_Data");
			}
		}

		[XmlElement(Order = 29)]
		public decimal Regular_Paid_Equivalent_Hours
		{
			get
			{
				return this.regular_Paid_Equivalent_HoursField;
			}
			set
			{
				this.regular_Paid_Equivalent_HoursField = value;
				this.RaisePropertyChanged("Regular_Paid_Equivalent_Hours");
			}
		}

		[XmlIgnore]
		public bool Regular_Paid_Equivalent_HoursSpecified
		{
			get
			{
				return this.regular_Paid_Equivalent_HoursFieldSpecified;
			}
			set
			{
				this.regular_Paid_Equivalent_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Regular_Paid_Equivalent_HoursSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public string Worker_Hours_Profile_Classification
		{
			get
			{
				return this.worker_Hours_Profile_ClassificationField;
			}
			set
			{
				this.worker_Hours_Profile_ClassificationField = value;
				this.RaisePropertyChanged("Worker_Hours_Profile_Classification");
			}
		}

		[XmlElement(Order = 31)]
		public International_Assignment_DataType International_Assignment_Data
		{
			get
			{
				return this.international_Assignment_DataField;
			}
			set
			{
				this.international_Assignment_DataField = value;
				this.RaisePropertyChanged("International_Assignment_Data");
			}
		}

		[XmlElement(Order = 32)]
		public LocationObjectType Work_Space__Reference
		{
			get
			{
				return this.work_Space__ReferenceField;
			}
			set
			{
				this.work_Space__ReferenceField = value;
				this.RaisePropertyChanged("Work_Space__Reference");
			}
		}

		[XmlElement(Order = 33)]
		public Academic_Pay_Setup_DataType Academic_Pay_Setup_Data
		{
			get
			{
				return this.academic_Pay_Setup_DataField;
			}
			set
			{
				this.academic_Pay_Setup_DataField = value;
				this.RaisePropertyChanged("Academic_Pay_Setup_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 34)]
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

		[XmlElement(DataType = "date", Order = 35)]
		public DateTime Pay_Through_Date
		{
			get
			{
				return this.pay_Through_DateField;
			}
			set
			{
				this.pay_Through_DateField = value;
				this.RaisePropertyChanged("Pay_Through_Date");
			}
		}

		[XmlIgnore]
		public bool Pay_Through_DateSpecified
		{
			get
			{
				return this.pay_Through_DateFieldSpecified;
			}
			set
			{
				this.pay_Through_DateFieldSpecified = value;
				this.RaisePropertyChanged("Pay_Through_DateSpecified");
			}
		}

		[XmlElement("Collective_Agreement_Summary_Data", Order = 36)]
		public Collective_Agreement_Summary_DataType[] Collective_Agreement_Summary_Data
		{
			get
			{
				return this.collective_Agreement_Summary_DataField;
			}
			set
			{
				this.collective_Agreement_Summary_DataField = value;
				this.RaisePropertyChanged("Collective_Agreement_Summary_Data");
			}
		}

		[XmlArray(Order = 37), XmlArrayItem("Employee_Probation_Period_Detail_Data", IsNullable = false)]
		public Employee_Probation_Period_Detail_DataType[] Employee_Probation_Period_Summary_Data
		{
			get
			{
				return this.employee_Probation_Period_Summary_DataField;
			}
			set
			{
				this.employee_Probation_Period_Summary_DataField = value;
				this.RaisePropertyChanged("Employee_Probation_Period_Summary_Data");
			}
		}

		[XmlElement("Manager_as_of_last_detected_manager_change_Reference", Order = 38)]
		public WorkerObjectType[] Manager_as_of_last_detected_manager_change_Reference
		{
			get
			{
				return this.manager_as_of_last_detected_manager_change_ReferenceField;
			}
			set
			{
				this.manager_as_of_last_detected_manager_change_ReferenceField = value;
				this.RaisePropertyChanged("Manager_as_of_last_detected_manager_change_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified, DataType = "date")]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
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
