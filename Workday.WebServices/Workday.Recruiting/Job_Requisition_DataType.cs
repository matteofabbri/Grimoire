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
	public class Job_Requisition_DataType : INotifyPropertyChanged
	{
		private Job_RequisitionObjectType job_Requisition_ReferenceField;

		private string job_Requisition_IDField;

		private Job_Requisition_StatusObjectType job_Requisition_Status_ReferenceField;

		private string job_Posting_TitleField;

		private Recruiting_Instruction_DataType recruiting_Instruction_DataField;

		private bool academic_Tenure_EligibleField;

		private bool academic_Tenure_EligibleFieldSpecified;

		private decimal number_of_OpeningsField;

		private bool number_of_OpeningsFieldSpecified;

		private string job_Description_SummaryField;

		private string justificationField;

		private Job_Requisition_Attachment_DataType[] job_Requisition_AttachmentsField;

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

		private LocationObjectType[] additional_Locations_ReferenceField;

		private Position_Time_TypeObjectType position_Time_Type_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private Qualification_Data_for_Position_Restriction_or_Job_ProfileType qualification_DataField;

		private WorkerObjectType replacement_for_Worker_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Job_RequisitionObjectType Job_Requisition_Reference
		{
			get
			{
				return this.job_Requisition_ReferenceField;
			}
			set
			{
				this.job_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Requisition_ID
		{
			get
			{
				return this.job_Requisition_IDField;
			}
			set
			{
				this.job_Requisition_IDField = value;
				this.RaisePropertyChanged("Job_Requisition_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Job_Requisition_StatusObjectType Job_Requisition_Status_Reference
		{
			get
			{
				return this.job_Requisition_Status_ReferenceField;
			}
			set
			{
				this.job_Requisition_Status_ReferenceField = value;
				this.RaisePropertyChanged("Job_Requisition_Status_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Job_Posting_Title
		{
			get
			{
				return this.job_Posting_TitleField;
			}
			set
			{
				this.job_Posting_TitleField = value;
				this.RaisePropertyChanged("Job_Posting_Title");
			}
		}

		[XmlElement(Order = 4)]
		public Recruiting_Instruction_DataType Recruiting_Instruction_Data
		{
			get
			{
				return this.recruiting_Instruction_DataField;
			}
			set
			{
				this.recruiting_Instruction_DataField = value;
				this.RaisePropertyChanged("Recruiting_Instruction_Data");
			}
		}

		[XmlElement(Order = 5)]
		public bool Academic_Tenure_Eligible
		{
			get
			{
				return this.academic_Tenure_EligibleField;
			}
			set
			{
				this.academic_Tenure_EligibleField = value;
				this.RaisePropertyChanged("Academic_Tenure_Eligible");
			}
		}

		[XmlIgnore]
		public bool Academic_Tenure_EligibleSpecified
		{
			get
			{
				return this.academic_Tenure_EligibleFieldSpecified;
			}
			set
			{
				this.academic_Tenure_EligibleFieldSpecified = value;
				this.RaisePropertyChanged("Academic_Tenure_EligibleSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Number_of_Openings
		{
			get
			{
				return this.number_of_OpeningsField;
			}
			set
			{
				this.number_of_OpeningsField = value;
				this.RaisePropertyChanged("Number_of_Openings");
			}
		}

		[XmlIgnore]
		public bool Number_of_OpeningsSpecified
		{
			get
			{
				return this.number_of_OpeningsFieldSpecified;
			}
			set
			{
				this.number_of_OpeningsFieldSpecified = value;
				this.RaisePropertyChanged("Number_of_OpeningsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Job_Description_Summary
		{
			get
			{
				return this.job_Description_SummaryField;
			}
			set
			{
				this.job_Description_SummaryField = value;
				this.RaisePropertyChanged("Job_Description_Summary");
			}
		}

		[XmlElement(Order = 8)]
		public string Justification
		{
			get
			{
				return this.justificationField;
			}
			set
			{
				this.justificationField = value;
				this.RaisePropertyChanged("Justification");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Job_Requisition_Attachment_Data", IsNullable = false)]
		public Job_Requisition_Attachment_DataType[] Job_Requisition_Attachments
		{
			get
			{
				return this.job_Requisition_AttachmentsField;
			}
			set
			{
				this.job_Requisition_AttachmentsField = value;
				this.RaisePropertyChanged("Job_Requisition_Attachments");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(DataType = "date", Order = 11)]
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

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Additional_Locations_Reference", Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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

		[XmlElement(Order = 21)]
		public Qualification_Data_for_Position_Restriction_or_Job_ProfileType Qualification_Data
		{
			get
			{
				return this.qualification_DataField;
			}
			set
			{
				this.qualification_DataField = value;
				this.RaisePropertyChanged("Qualification_Data");
			}
		}

		[XmlElement(Order = 22)]
		public WorkerObjectType Replacement_for_Worker_Reference
		{
			get
			{
				return this.replacement_for_Worker_ReferenceField;
			}
			set
			{
				this.replacement_for_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Replacement_for_Worker_Reference");
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
