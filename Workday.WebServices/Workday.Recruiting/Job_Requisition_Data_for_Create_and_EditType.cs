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
	public class Job_Requisition_Data_for_Create_and_EditType : INotifyPropertyChanged
	{
		private string job_Requisition_IDField;

		private string job_Posting_TitleField;

		private Recruiting_InstructionObjectType recruiting_Instruction_ReferenceField;

		private string job_Description_SummaryField;

		private string job_DescriptionField;

		private string additional_Job_DescriptionField;

		private string justificationField;

		private Job_Requisition_Attachment_DataType[] job_Requisition_AttachmentsField;

		private DateTime recruiting_Start_DateField;

		private bool recruiting_Start_DateFieldSpecified;

		private DateTime target_Hire_DateField;

		private bool target_Hire_DateFieldSpecified;

		private DateTime target_End_DateField;

		private bool target_End_DateFieldSpecified;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private OneTime_Payment_PlanObjectType referral_Payment_Plan_ReferenceField;

		private Worker_TypeObjectType worker_Type_ReferenceField;

		private Position_Worker_TypeObjectType worker_SubType_ReferenceField;

		private LocationObjectType primary_Location_ReferenceField;

		private LocationObjectType primary_Job_Posting_Location_ReferenceField;

		private LocationObjectType[] additional_Location_ReferenceField;

		private LocationObjectType[] additional_Job_Posting_Location_ReferenceField;

		private Position_Time_TypeObjectType position_Time_Type_ReferenceField;

		private decimal scheduled_Weekly_HoursField;

		private bool scheduled_Weekly_HoursFieldSpecified;

		private Work_ShiftObjectType work_Shift_ReferenceField;

		private bool confidential_Job_RequisitionField;

		private bool confidential_Job_RequisitionFieldSpecified;

		private Evergreen_Job_RequisitionObjectType link_to_Evergreen_Requisition_ReferenceField;

		private Job_Requisition_Questionnaire_DataType questionnaire_DataField;

		private Qualification_Data_for_Position_Restriction_or_Job_ProfileType qualification_Replacement_DataField;

		private Contingent_Worker_Cost_Information_DataType contingent_Worker_Cost_InformationField;

		private WorkerObjectType replacement_for_Worker_ReferenceField;

		private Job_Requisition_Organizations_Data_for_Business_ProcessType organization_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Recruiting_InstructionObjectType Recruiting_Instruction_Reference
		{
			get
			{
				return this.recruiting_Instruction_ReferenceField;
			}
			set
			{
				this.recruiting_Instruction_ReferenceField = value;
				this.RaisePropertyChanged("Recruiting_Instruction_Reference");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Job_Description
		{
			get
			{
				return this.job_DescriptionField;
			}
			set
			{
				this.job_DescriptionField = value;
				this.RaisePropertyChanged("Job_Description");
			}
		}

		[XmlElement(Order = 5)]
		public string Additional_Job_Description
		{
			get
			{
				return this.additional_Job_DescriptionField;
			}
			set
			{
				this.additional_Job_DescriptionField = value;
				this.RaisePropertyChanged("Additional_Job_Description");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlArray(Order = 7), XmlArrayItem("Job_Requisition_Attachment_Data", typeof(Job_Requisition_Attachment_DataType), IsNullable = false)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Worker_Sub-Type_Reference", Order = 14)]
		public Position_Worker_TypeObjectType Worker_SubType_Reference
		{
			get
			{
				return this.worker_SubType_ReferenceField;
			}
			set
			{
				this.worker_SubType_ReferenceField = value;
				this.RaisePropertyChanged("Worker_SubType_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Additional_Location_Reference", Order = 17)]
		public LocationObjectType[] Additional_Location_Reference
		{
			get
			{
				return this.additional_Location_ReferenceField;
			}
			set
			{
				this.additional_Location_ReferenceField = value;
				this.RaisePropertyChanged("Additional_Location_Reference");
			}
		}

		[XmlElement("Additional_Job_Posting_Location_Reference", Order = 18)]
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

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
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
		public bool Confidential_Job_Requisition
		{
			get
			{
				return this.confidential_Job_RequisitionField;
			}
			set
			{
				this.confidential_Job_RequisitionField = value;
				this.RaisePropertyChanged("Confidential_Job_Requisition");
			}
		}

		[XmlIgnore]
		public bool Confidential_Job_RequisitionSpecified
		{
			get
			{
				return this.confidential_Job_RequisitionFieldSpecified;
			}
			set
			{
				this.confidential_Job_RequisitionFieldSpecified = value;
				this.RaisePropertyChanged("Confidential_Job_RequisitionSpecified");
			}
		}

		[XmlElement(Order = 23)]
		public Evergreen_Job_RequisitionObjectType Link_to_Evergreen_Requisition_Reference
		{
			get
			{
				return this.link_to_Evergreen_Requisition_ReferenceField;
			}
			set
			{
				this.link_to_Evergreen_Requisition_ReferenceField = value;
				this.RaisePropertyChanged("Link_to_Evergreen_Requisition_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public Job_Requisition_Questionnaire_DataType Questionnaire_Data
		{
			get
			{
				return this.questionnaire_DataField;
			}
			set
			{
				this.questionnaire_DataField = value;
				this.RaisePropertyChanged("Questionnaire_Data");
			}
		}

		[XmlElement(Order = 25)]
		public Qualification_Data_for_Position_Restriction_or_Job_ProfileType Qualification_Replacement_Data
		{
			get
			{
				return this.qualification_Replacement_DataField;
			}
			set
			{
				this.qualification_Replacement_DataField = value;
				this.RaisePropertyChanged("Qualification_Replacement_Data");
			}
		}

		[XmlElement(Order = 26)]
		public Contingent_Worker_Cost_Information_DataType Contingent_Worker_Cost_Information
		{
			get
			{
				return this.contingent_Worker_Cost_InformationField;
			}
			set
			{
				this.contingent_Worker_Cost_InformationField = value;
				this.RaisePropertyChanged("Contingent_Worker_Cost_Information");
			}
		}

		[XmlElement(Order = 27)]
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

		[XmlElement(Order = 28)]
		public Job_Requisition_Organizations_Data_for_Business_ProcessType Organization_Data
		{
			get
			{
				return this.organization_DataField;
			}
			set
			{
				this.organization_DataField = value;
				this.RaisePropertyChanged("Organization_Data");
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
