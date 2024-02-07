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
	public class Worker_Status_Detail_DataType : INotifyPropertyChanged
	{
		private bool activeField;

		private bool activeFieldSpecified;

		private DateTime active_Status_DateField;

		private bool active_Status_DateFieldSpecified;

		private DateTime hire_DateField;

		private bool hire_DateFieldSpecified;

		private DateTime original_Hire_DateField;

		private bool original_Hire_DateFieldSpecified;

		private General_Event_SubcategoryObjectType hire_Reason_ReferenceField;

		private DateTime end_Employment_DateField;

		private bool end_Employment_DateFieldSpecified;

		private DateTime continuous_Service_DateField;

		private bool continuous_Service_DateFieldSpecified;

		private DateTime first_Day_of_WorkField;

		private bool first_Day_of_WorkFieldSpecified;

		private DateTime expected_Retirement_DateField;

		private bool expected_Retirement_DateFieldSpecified;

		private DateTime retirement_Eligibility_DateField;

		private bool retirement_Eligibility_DateFieldSpecified;

		private bool retiredField;

		private bool retiredFieldSpecified;

		private DateTime retirement_DateField;

		private bool retirement_DateFieldSpecified;

		private DateTime seniority_DateField;

		private bool seniority_DateFieldSpecified;

		private DateTime severance_DateField;

		private bool severance_DateFieldSpecified;

		private DateTime benefits_Service_DateField;

		private bool benefits_Service_DateFieldSpecified;

		private DateTime company_Service_DateField;

		private bool company_Service_DateFieldSpecified;

		private DateTime time_Off_Service_DateField;

		private bool time_Off_Service_DateFieldSpecified;

		private DateTime vesting_DateField;

		private bool vesting_DateFieldSpecified;

		private DateTime date_Entered_WorkforceField;

		private bool date_Entered_WorkforceFieldSpecified;

		private decimal days_UnemployedField;

		private bool days_UnemployedFieldSpecified;

		private decimal months_Continuous_Prior_EmploymentField;

		private bool months_Continuous_Prior_EmploymentFieldSpecified;

		private bool terminatedField;

		private bool terminatedFieldSpecified;

		private DateTime termination_DateField;

		private bool termination_DateFieldSpecified;

		private DateTime pay_Through_DateField;

		private bool pay_Through_DateFieldSpecified;

		private Termination_SubcategoryObjectType primary_Termination_Reason_ReferenceField;

		private Event_Classification_CategoryObjectType primary_Termination_Category_ReferenceField;

		private bool termination_InvoluntaryField;

		private bool termination_InvoluntaryFieldSpecified;

		private Secondary_Termination_DataType[] secondary_Termination_Reasons_DataField;

		private Local_Termination_ReasonObjectType local_Termination_Reason_ReferenceField;

		private bool not_Eligible_for_HireField;

		private bool not_Eligible_for_HireFieldSpecified;

		private bool regrettable_TerminationField;

		private bool regrettable_TerminationFieldSpecified;

		private bool not_Eligible_for_RehireField;

		private bool not_Eligible_for_RehireFieldSpecified;

		private DateTime termination_Last_Day_of_WorkField;

		private bool termination_Last_Day_of_WorkFieldSpecified;

		private DateTime resignation_DateField;

		private bool resignation_DateFieldSpecified;

		private DateTime last_Date_for_Which_PaidField;

		private bool last_Date_for_Which_PaidFieldSpecified;

		private DateTime expected_Date_of_ReturnField;

		private bool expected_Date_of_ReturnFieldSpecified;

		private bool not_ReturningField;

		private bool not_ReturningFieldSpecified;

		private bool return_UnknownField;

		private bool return_UnknownFieldSpecified;

		private DateTime probation_Start_DateField;

		private bool probation_Start_DateFieldSpecified;

		private DateTime probation_End_DateField;

		private bool probation_End_DateFieldSpecified;

		private Leave_Status_Detail_DataType[] leave_Status_DataField;

		private Leave_Requests_Corrected_Detail_DataType[] leave_Requests_Corrected_DataField;

		private DateTime academic_Tenure_DateField;

		private bool academic_Tenure_DateFieldSpecified;

		private bool rehireField;

		private bool rehireFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		[XmlIgnore]
		public bool ActiveSpecified
		{
			get
			{
				return this.activeFieldSpecified;
			}
			set
			{
				this.activeFieldSpecified = value;
				this.RaisePropertyChanged("ActiveSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Active_Status_Date
		{
			get
			{
				return this.active_Status_DateField;
			}
			set
			{
				this.active_Status_DateField = value;
				this.RaisePropertyChanged("Active_Status_Date");
			}
		}

		[XmlIgnore]
		public bool Active_Status_DateSpecified
		{
			get
			{
				return this.active_Status_DateFieldSpecified;
			}
			set
			{
				this.active_Status_DateFieldSpecified = value;
				this.RaisePropertyChanged("Active_Status_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Hire_Date
		{
			get
			{
				return this.hire_DateField;
			}
			set
			{
				this.hire_DateField = value;
				this.RaisePropertyChanged("Hire_Date");
			}
		}

		[XmlIgnore]
		public bool Hire_DateSpecified
		{
			get
			{
				return this.hire_DateFieldSpecified;
			}
			set
			{
				this.hire_DateFieldSpecified = value;
				this.RaisePropertyChanged("Hire_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
		public General_Event_SubcategoryObjectType Hire_Reason_Reference
		{
			get
			{
				return this.hire_Reason_ReferenceField;
			}
			set
			{
				this.hire_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Hire_Reason_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime First_Day_of_Work
		{
			get
			{
				return this.first_Day_of_WorkField;
			}
			set
			{
				this.first_Day_of_WorkField = value;
				this.RaisePropertyChanged("First_Day_of_Work");
			}
		}

		[XmlIgnore]
		public bool First_Day_of_WorkSpecified
		{
			get
			{
				return this.first_Day_of_WorkFieldSpecified;
			}
			set
			{
				this.first_Day_of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("First_Day_of_WorkSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Expected_Retirement_Date
		{
			get
			{
				return this.expected_Retirement_DateField;
			}
			set
			{
				this.expected_Retirement_DateField = value;
				this.RaisePropertyChanged("Expected_Retirement_Date");
			}
		}

		[XmlIgnore]
		public bool Expected_Retirement_DateSpecified
		{
			get
			{
				return this.expected_Retirement_DateFieldSpecified;
			}
			set
			{
				this.expected_Retirement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Retirement_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Retirement_Eligibility_Date
		{
			get
			{
				return this.retirement_Eligibility_DateField;
			}
			set
			{
				this.retirement_Eligibility_DateField = value;
				this.RaisePropertyChanged("Retirement_Eligibility_Date");
			}
		}

		[XmlIgnore]
		public bool Retirement_Eligibility_DateSpecified
		{
			get
			{
				return this.retirement_Eligibility_DateFieldSpecified;
			}
			set
			{
				this.retirement_Eligibility_DateFieldSpecified = value;
				this.RaisePropertyChanged("Retirement_Eligibility_DateSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Retired
		{
			get
			{
				return this.retiredField;
			}
			set
			{
				this.retiredField = value;
				this.RaisePropertyChanged("Retired");
			}
		}

		[XmlIgnore]
		public bool RetiredSpecified
		{
			get
			{
				return this.retiredFieldSpecified;
			}
			set
			{
				this.retiredFieldSpecified = value;
				this.RaisePropertyChanged("RetiredSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Retirement_Date
		{
			get
			{
				return this.retirement_DateField;
			}
			set
			{
				this.retirement_DateField = value;
				this.RaisePropertyChanged("Retirement_Date");
			}
		}

		[XmlIgnore]
		public bool Retirement_DateSpecified
		{
			get
			{
				return this.retirement_DateFieldSpecified;
			}
			set
			{
				this.retirement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Retirement_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Seniority_Date
		{
			get
			{
				return this.seniority_DateField;
			}
			set
			{
				this.seniority_DateField = value;
				this.RaisePropertyChanged("Seniority_Date");
			}
		}

		[XmlIgnore]
		public bool Seniority_DateSpecified
		{
			get
			{
				return this.seniority_DateFieldSpecified;
			}
			set
			{
				this.seniority_DateFieldSpecified = value;
				this.RaisePropertyChanged("Seniority_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Severance_Date
		{
			get
			{
				return this.severance_DateField;
			}
			set
			{
				this.severance_DateField = value;
				this.RaisePropertyChanged("Severance_Date");
			}
		}

		[XmlIgnore]
		public bool Severance_DateSpecified
		{
			get
			{
				return this.severance_DateFieldSpecified;
			}
			set
			{
				this.severance_DateFieldSpecified = value;
				this.RaisePropertyChanged("Severance_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 14)]
		public DateTime Benefits_Service_Date
		{
			get
			{
				return this.benefits_Service_DateField;
			}
			set
			{
				this.benefits_Service_DateField = value;
				this.RaisePropertyChanged("Benefits_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Benefits_Service_DateSpecified
		{
			get
			{
				return this.benefits_Service_DateFieldSpecified;
			}
			set
			{
				this.benefits_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Benefits_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 15)]
		public DateTime Company_Service_Date
		{
			get
			{
				return this.company_Service_DateField;
			}
			set
			{
				this.company_Service_DateField = value;
				this.RaisePropertyChanged("Company_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Company_Service_DateSpecified
		{
			get
			{
				return this.company_Service_DateFieldSpecified;
			}
			set
			{
				this.company_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Company_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 16)]
		public DateTime Time_Off_Service_Date
		{
			get
			{
				return this.time_Off_Service_DateField;
			}
			set
			{
				this.time_Off_Service_DateField = value;
				this.RaisePropertyChanged("Time_Off_Service_Date");
			}
		}

		[XmlIgnore]
		public bool Time_Off_Service_DateSpecified
		{
			get
			{
				return this.time_Off_Service_DateFieldSpecified;
			}
			set
			{
				this.time_Off_Service_DateFieldSpecified = value;
				this.RaisePropertyChanged("Time_Off_Service_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 17)]
		public DateTime Vesting_Date
		{
			get
			{
				return this.vesting_DateField;
			}
			set
			{
				this.vesting_DateField = value;
				this.RaisePropertyChanged("Vesting_Date");
			}
		}

		[XmlIgnore]
		public bool Vesting_DateSpecified
		{
			get
			{
				return this.vesting_DateFieldSpecified;
			}
			set
			{
				this.vesting_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vesting_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 18)]
		public DateTime Date_Entered_Workforce
		{
			get
			{
				return this.date_Entered_WorkforceField;
			}
			set
			{
				this.date_Entered_WorkforceField = value;
				this.RaisePropertyChanged("Date_Entered_Workforce");
			}
		}

		[XmlIgnore]
		public bool Date_Entered_WorkforceSpecified
		{
			get
			{
				return this.date_Entered_WorkforceFieldSpecified;
			}
			set
			{
				this.date_Entered_WorkforceFieldSpecified = value;
				this.RaisePropertyChanged("Date_Entered_WorkforceSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Days_Unemployed
		{
			get
			{
				return this.days_UnemployedField;
			}
			set
			{
				this.days_UnemployedField = value;
				this.RaisePropertyChanged("Days_Unemployed");
			}
		}

		[XmlIgnore]
		public bool Days_UnemployedSpecified
		{
			get
			{
				return this.days_UnemployedFieldSpecified;
			}
			set
			{
				this.days_UnemployedFieldSpecified = value;
				this.RaisePropertyChanged("Days_UnemployedSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Months_Continuous_Prior_Employment
		{
			get
			{
				return this.months_Continuous_Prior_EmploymentField;
			}
			set
			{
				this.months_Continuous_Prior_EmploymentField = value;
				this.RaisePropertyChanged("Months_Continuous_Prior_Employment");
			}
		}

		[XmlIgnore]
		public bool Months_Continuous_Prior_EmploymentSpecified
		{
			get
			{
				return this.months_Continuous_Prior_EmploymentFieldSpecified;
			}
			set
			{
				this.months_Continuous_Prior_EmploymentFieldSpecified = value;
				this.RaisePropertyChanged("Months_Continuous_Prior_EmploymentSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public bool Terminated
		{
			get
			{
				return this.terminatedField;
			}
			set
			{
				this.terminatedField = value;
				this.RaisePropertyChanged("Terminated");
			}
		}

		[XmlIgnore]
		public bool TerminatedSpecified
		{
			get
			{
				return this.terminatedFieldSpecified;
			}
			set
			{
				this.terminatedFieldSpecified = value;
				this.RaisePropertyChanged("TerminatedSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Termination_Date
		{
			get
			{
				return this.termination_DateField;
			}
			set
			{
				this.termination_DateField = value;
				this.RaisePropertyChanged("Termination_Date");
			}
		}

		[XmlIgnore]
		public bool Termination_DateSpecified
		{
			get
			{
				return this.termination_DateFieldSpecified;
			}
			set
			{
				this.termination_DateFieldSpecified = value;
				this.RaisePropertyChanged("Termination_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 23)]
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

		[XmlElement(Order = 24)]
		public Termination_SubcategoryObjectType Primary_Termination_Reason_Reference
		{
			get
			{
				return this.primary_Termination_Reason_ReferenceField;
			}
			set
			{
				this.primary_Termination_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Termination_Reason_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public Event_Classification_CategoryObjectType Primary_Termination_Category_Reference
		{
			get
			{
				return this.primary_Termination_Category_ReferenceField;
			}
			set
			{
				this.primary_Termination_Category_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Termination_Category_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public bool Termination_Involuntary
		{
			get
			{
				return this.termination_InvoluntaryField;
			}
			set
			{
				this.termination_InvoluntaryField = value;
				this.RaisePropertyChanged("Termination_Involuntary");
			}
		}

		[XmlIgnore]
		public bool Termination_InvoluntarySpecified
		{
			get
			{
				return this.termination_InvoluntaryFieldSpecified;
			}
			set
			{
				this.termination_InvoluntaryFieldSpecified = value;
				this.RaisePropertyChanged("Termination_InvoluntarySpecified");
			}
		}

		[XmlElement("Secondary_Termination_Reasons_Data", Order = 27)]
		public Secondary_Termination_DataType[] Secondary_Termination_Reasons_Data
		{
			get
			{
				return this.secondary_Termination_Reasons_DataField;
			}
			set
			{
				this.secondary_Termination_Reasons_DataField = value;
				this.RaisePropertyChanged("Secondary_Termination_Reasons_Data");
			}
		}

		[XmlElement(Order = 28)]
		public Local_Termination_ReasonObjectType Local_Termination_Reason_Reference
		{
			get
			{
				return this.local_Termination_Reason_ReferenceField;
			}
			set
			{
				this.local_Termination_Reason_ReferenceField = value;
				this.RaisePropertyChanged("Local_Termination_Reason_Reference");
			}
		}

		[XmlElement(Order = 29)]
		public bool Not_Eligible_for_Hire
		{
			get
			{
				return this.not_Eligible_for_HireField;
			}
			set
			{
				this.not_Eligible_for_HireField = value;
				this.RaisePropertyChanged("Not_Eligible_for_Hire");
			}
		}

		[XmlIgnore]
		public bool Not_Eligible_for_HireSpecified
		{
			get
			{
				return this.not_Eligible_for_HireFieldSpecified;
			}
			set
			{
				this.not_Eligible_for_HireFieldSpecified = value;
				this.RaisePropertyChanged("Not_Eligible_for_HireSpecified");
			}
		}

		[XmlElement(Order = 30)]
		public bool Regrettable_Termination
		{
			get
			{
				return this.regrettable_TerminationField;
			}
			set
			{
				this.regrettable_TerminationField = value;
				this.RaisePropertyChanged("Regrettable_Termination");
			}
		}

		[XmlIgnore]
		public bool Regrettable_TerminationSpecified
		{
			get
			{
				return this.regrettable_TerminationFieldSpecified;
			}
			set
			{
				this.regrettable_TerminationFieldSpecified = value;
				this.RaisePropertyChanged("Regrettable_TerminationSpecified");
			}
		}

		[XmlElement(Order = 31)]
		public bool Not_Eligible_for_Rehire
		{
			get
			{
				return this.not_Eligible_for_RehireField;
			}
			set
			{
				this.not_Eligible_for_RehireField = value;
				this.RaisePropertyChanged("Not_Eligible_for_Rehire");
			}
		}

		[XmlIgnore]
		public bool Not_Eligible_for_RehireSpecified
		{
			get
			{
				return this.not_Eligible_for_RehireFieldSpecified;
			}
			set
			{
				this.not_Eligible_for_RehireFieldSpecified = value;
				this.RaisePropertyChanged("Not_Eligible_for_RehireSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 32)]
		public DateTime Termination_Last_Day_of_Work
		{
			get
			{
				return this.termination_Last_Day_of_WorkField;
			}
			set
			{
				this.termination_Last_Day_of_WorkField = value;
				this.RaisePropertyChanged("Termination_Last_Day_of_Work");
			}
		}

		[XmlIgnore]
		public bool Termination_Last_Day_of_WorkSpecified
		{
			get
			{
				return this.termination_Last_Day_of_WorkFieldSpecified;
			}
			set
			{
				this.termination_Last_Day_of_WorkFieldSpecified = value;
				this.RaisePropertyChanged("Termination_Last_Day_of_WorkSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 33)]
		public DateTime Resignation_Date
		{
			get
			{
				return this.resignation_DateField;
			}
			set
			{
				this.resignation_DateField = value;
				this.RaisePropertyChanged("Resignation_Date");
			}
		}

		[XmlIgnore]
		public bool Resignation_DateSpecified
		{
			get
			{
				return this.resignation_DateFieldSpecified;
			}
			set
			{
				this.resignation_DateFieldSpecified = value;
				this.RaisePropertyChanged("Resignation_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 34)]
		public DateTime Last_Date_for_Which_Paid
		{
			get
			{
				return this.last_Date_for_Which_PaidField;
			}
			set
			{
				this.last_Date_for_Which_PaidField = value;
				this.RaisePropertyChanged("Last_Date_for_Which_Paid");
			}
		}

		[XmlIgnore]
		public bool Last_Date_for_Which_PaidSpecified
		{
			get
			{
				return this.last_Date_for_Which_PaidFieldSpecified;
			}
			set
			{
				this.last_Date_for_Which_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Last_Date_for_Which_PaidSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 35)]
		public DateTime Expected_Date_of_Return
		{
			get
			{
				return this.expected_Date_of_ReturnField;
			}
			set
			{
				this.expected_Date_of_ReturnField = value;
				this.RaisePropertyChanged("Expected_Date_of_Return");
			}
		}

		[XmlIgnore]
		public bool Expected_Date_of_ReturnSpecified
		{
			get
			{
				return this.expected_Date_of_ReturnFieldSpecified;
			}
			set
			{
				this.expected_Date_of_ReturnFieldSpecified = value;
				this.RaisePropertyChanged("Expected_Date_of_ReturnSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public bool Not_Returning
		{
			get
			{
				return this.not_ReturningField;
			}
			set
			{
				this.not_ReturningField = value;
				this.RaisePropertyChanged("Not_Returning");
			}
		}

		[XmlIgnore]
		public bool Not_ReturningSpecified
		{
			get
			{
				return this.not_ReturningFieldSpecified;
			}
			set
			{
				this.not_ReturningFieldSpecified = value;
				this.RaisePropertyChanged("Not_ReturningSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public bool Return_Unknown
		{
			get
			{
				return this.return_UnknownField;
			}
			set
			{
				this.return_UnknownField = value;
				this.RaisePropertyChanged("Return_Unknown");
			}
		}

		[XmlIgnore]
		public bool Return_UnknownSpecified
		{
			get
			{
				return this.return_UnknownFieldSpecified;
			}
			set
			{
				this.return_UnknownFieldSpecified = value;
				this.RaisePropertyChanged("Return_UnknownSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 38)]
		public DateTime Probation_Start_Date
		{
			get
			{
				return this.probation_Start_DateField;
			}
			set
			{
				this.probation_Start_DateField = value;
				this.RaisePropertyChanged("Probation_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_Start_DateSpecified
		{
			get
			{
				return this.probation_Start_DateFieldSpecified;
			}
			set
			{
				this.probation_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 39)]
		public DateTime Probation_End_Date
		{
			get
			{
				return this.probation_End_DateField;
			}
			set
			{
				this.probation_End_DateField = value;
				this.RaisePropertyChanged("Probation_End_Date");
			}
		}

		[XmlIgnore]
		public bool Probation_End_DateSpecified
		{
			get
			{
				return this.probation_End_DateFieldSpecified;
			}
			set
			{
				this.probation_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Probation_End_DateSpecified");
			}
		}

		[XmlElement("Leave_Status_Data", Order = 40)]
		public Leave_Status_Detail_DataType[] Leave_Status_Data
		{
			get
			{
				return this.leave_Status_DataField;
			}
			set
			{
				this.leave_Status_DataField = value;
				this.RaisePropertyChanged("Leave_Status_Data");
			}
		}

		[XmlElement("Leave_Requests_Corrected_Data", Order = 41)]
		public Leave_Requests_Corrected_Detail_DataType[] Leave_Requests_Corrected_Data
		{
			get
			{
				return this.leave_Requests_Corrected_DataField;
			}
			set
			{
				this.leave_Requests_Corrected_DataField = value;
				this.RaisePropertyChanged("Leave_Requests_Corrected_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 42)]
		public DateTime Academic_Tenure_Date
		{
			get
			{
				return this.academic_Tenure_DateField;
			}
			set
			{
				this.academic_Tenure_DateField = value;
				this.RaisePropertyChanged("Academic_Tenure_Date");
			}
		}

		[XmlIgnore]
		public bool Academic_Tenure_DateSpecified
		{
			get
			{
				return this.academic_Tenure_DateFieldSpecified;
			}
			set
			{
				this.academic_Tenure_DateFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Tenure_DateSpecified");
			}
		}

		[XmlElement(Order = 43)]
		public bool Rehire
		{
			get
			{
				return this.rehireField;
			}
			set
			{
				this.rehireField = value;
				this.RaisePropertyChanged("Rehire");
			}
		}

		[XmlIgnore]
		public bool RehireSpecified
		{
			get
			{
				return this.rehireFieldSpecified;
			}
			set
			{
				this.rehireFieldSpecified = value;
				this.RaisePropertyChanged("RehireSpecified");
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
