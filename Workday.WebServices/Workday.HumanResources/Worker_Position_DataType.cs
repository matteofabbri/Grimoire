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
	public class Worker_Position_DataType : INotifyPropertyChanged
	{
		private Position_ReferenceType position_ReferenceField;

		private string position_IDField;

		private string position_TitleField;

		private string business_TitleField;

		private Employee_Type_ReferenceType[] employee_Type_ReferenceField;

		private Position_Time_Type_ReferenceType[] position_Time_Type_ReferenceField;

		private bool job_ExemptField;

		private bool job_ExemptFieldSpecified;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private decimal default_Weekly_HoursField;

		private bool default_Weekly_HoursFieldSpecified;

		private decimal full_Time_Equivalent_PercentageField;

		private bool full_Time_Equivalent_PercentageFieldSpecified;

		private Pay_Rate_Type_ReferenceType[] pay_Rate_Type_ReferenceField;

		private Job_Classification_ReferenceType[] job_Classification_ReferenceField;

		private Company_Insider_Type_ReferenceType[] company_Insider_ReferenceField;

		private Job_Profile_in_Position_Summary_DataType[] job_Profile_Summary_DataField;

		private Organization_Content_DataType[] organization_Content_DataField;

		private Location_Content_DataType[] business_Site_Content_DataField;

		private Payroll_Interface_Processing_DataType[] payroll_Processing_DataField;

		private Supervisor_ReferenceType[] supervisor_ReferenceField;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private Work_Hours_ProfileObjectType work_Hours_Profile_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Position_ReferenceType Position_Reference
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Employee_Type_Reference", Order = 4)]
		public Employee_Type_ReferenceType[] Employee_Type_Reference
		{
			get
			{
				return this.employee_Type_ReferenceField;
			}
			set
			{
				this.employee_Type_ReferenceField = value;
				this.RaisePropertyChanged("Employee_Type_Reference");
			}
		}

		[XmlElement("Position_Time_Type_Reference", Order = 5)]
		public Position_Time_Type_ReferenceType[] Position_Time_Type_Reference
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement("Pay_Rate_Type_Reference", Order = 10)]
		public Pay_Rate_Type_ReferenceType[] Pay_Rate_Type_Reference
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

		[XmlElement("Job_Classification_Reference", Order = 11)]
		public Job_Classification_ReferenceType[] Job_Classification_Reference
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

		[XmlElement("Company_Insider_Reference", Order = 12)]
		public Company_Insider_Type_ReferenceType[] Company_Insider_Reference
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

		[XmlElement("Job_Profile_Summary_Data", Order = 13)]
		public Job_Profile_in_Position_Summary_DataType[] Job_Profile_Summary_Data
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

		[XmlElement("Organization_Content_Data", Order = 14)]
		public Organization_Content_DataType[] Organization_Content_Data
		{
			get
			{
				return this.organization_Content_DataField;
			}
			set
			{
				this.organization_Content_DataField = value;
				this.RaisePropertyChanged("Organization_Content_Data");
			}
		}

		[XmlElement("Business_Site_Content_Data", Order = 15)]
		public Location_Content_DataType[] Business_Site_Content_Data
		{
			get
			{
				return this.business_Site_Content_DataField;
			}
			set
			{
				this.business_Site_Content_DataField = value;
				this.RaisePropertyChanged("Business_Site_Content_Data");
			}
		}

		[XmlElement("Payroll_Processing_Data", Order = 16)]
		public Payroll_Interface_Processing_DataType[] Payroll_Processing_Data
		{
			get
			{
				return this.payroll_Processing_DataField;
			}
			set
			{
				this.payroll_Processing_DataField = value;
				this.RaisePropertyChanged("Payroll_Processing_Data");
			}
		}

		[XmlElement("Supervisor_Reference", Order = 17)]
		public Supervisor_ReferenceType[] Supervisor_Reference
		{
			get
			{
				return this.supervisor_ReferenceField;
			}
			set
			{
				this.supervisor_ReferenceField = value;
				this.RaisePropertyChanged("Supervisor_Reference");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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
