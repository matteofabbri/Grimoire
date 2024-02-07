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
	public class Job_Posting_Data_WWSType : INotifyPropertyChanged
	{
		private string job_Posting_IDField;

		private string job_Posting_TitleField;

		private string job_Posting_DescriptionField;

		private Job_Posting_SiteObjectType job_Posting_Site_ReferenceField;

		private string external_Job_PathField;

		private string external_Apply_URLField;

		private Job_Requisition_EnabledObjectType job_Requisition_ReferenceField;

		private string job_Requisition_IDField;

		private Job_Posting_Location_DataType job_Posting_Location_DataField;

		private DateTime job_Posting_Start_DateField;

		private bool job_Posting_Start_DateFieldSpecified;

		private DateTime job_Posting_End_DateField;

		private bool job_Posting_End_DateFieldSpecified;

		private bool primary_PostingField;

		private bool primary_PostingFieldSpecified;

		private decimal forecasted_PayoutField;

		private bool forecasted_PayoutFieldSpecified;

		private CurrencyObjectType forecasted_Payout_Currency_ReferenceField;

		private Job_FamilyObjectType[] job_Family_ReferenceField;

		private Position_Time_TypeObjectType time_Type_ReferenceField;

		private Position_Worker_TypeObjectType job_Type_ReferenceField;

		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Student_Award_SourceObjectType[] student_Award_Source_ReferenceField;

		private UnionObjectType[] union_ReferenceField;

		private Job_PostingObjectType[] similar_Jobs_ReferenceField;

		private Job_Requisition_Restrictions_DataType hiring_Requirement_DataField;

		private Job_Requisition_Definition_DataType job_Requisition_Detail_DataField;

		private Qualifications_from_Position_Restrictions_DataType qualification_DataField;

		private Job_Requisition_Attachment_DataType[] job_Requisition_AttachmentsField;

		private Document_Field_Result_DataType[] document_Field_Result_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_Posting_ID
		{
			get
			{
				return this.job_Posting_IDField;
			}
			set
			{
				this.job_Posting_IDField = value;
				this.RaisePropertyChanged("Job_Posting_ID");
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
		public string Job_Posting_Description
		{
			get
			{
				return this.job_Posting_DescriptionField;
			}
			set
			{
				this.job_Posting_DescriptionField = value;
				this.RaisePropertyChanged("Job_Posting_Description");
			}
		}

		[XmlElement(Order = 3)]
		public Job_Posting_SiteObjectType Job_Posting_Site_Reference
		{
			get
			{
				return this.job_Posting_Site_ReferenceField;
			}
			set
			{
				this.job_Posting_Site_ReferenceField = value;
				this.RaisePropertyChanged("Job_Posting_Site_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string External_Job_Path
		{
			get
			{
				return this.external_Job_PathField;
			}
			set
			{
				this.external_Job_PathField = value;
				this.RaisePropertyChanged("External_Job_Path");
			}
		}

		[XmlElement(Order = 5)]
		public string External_Apply_URL
		{
			get
			{
				return this.external_Apply_URLField;
			}
			set
			{
				this.external_Apply_URLField = value;
				this.RaisePropertyChanged("External_Apply_URL");
			}
		}

		[XmlElement(Order = 6)]
		public Job_Requisition_EnabledObjectType Job_Requisition_Reference
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Job_Posting_Location_DataType Job_Posting_Location_Data
		{
			get
			{
				return this.job_Posting_Location_DataField;
			}
			set
			{
				this.job_Posting_Location_DataField = value;
				this.RaisePropertyChanged("Job_Posting_Location_Data");
			}
		}

		[XmlElement(DataType = "date", Order = 9)]
		public DateTime Job_Posting_Start_Date
		{
			get
			{
				return this.job_Posting_Start_DateField;
			}
			set
			{
				this.job_Posting_Start_DateField = value;
				this.RaisePropertyChanged("Job_Posting_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_Start_DateSpecified
		{
			get
			{
				return this.job_Posting_Start_DateFieldSpecified;
			}
			set
			{
				this.job_Posting_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Job_Posting_End_Date
		{
			get
			{
				return this.job_Posting_End_DateField;
			}
			set
			{
				this.job_Posting_End_DateField = value;
				this.RaisePropertyChanged("Job_Posting_End_Date");
			}
		}

		[XmlIgnore]
		public bool Job_Posting_End_DateSpecified
		{
			get
			{
				return this.job_Posting_End_DateFieldSpecified;
			}
			set
			{
				this.job_Posting_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Job_Posting_End_DateSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public bool Primary_Posting
		{
			get
			{
				return this.primary_PostingField;
			}
			set
			{
				this.primary_PostingField = value;
				this.RaisePropertyChanged("Primary_Posting");
			}
		}

		[XmlIgnore]
		public bool Primary_PostingSpecified
		{
			get
			{
				return this.primary_PostingFieldSpecified;
			}
			set
			{
				this.primary_PostingFieldSpecified = value;
				this.RaisePropertyChanged("Primary_PostingSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Forecasted_Payout
		{
			get
			{
				return this.forecasted_PayoutField;
			}
			set
			{
				this.forecasted_PayoutField = value;
				this.RaisePropertyChanged("Forecasted_Payout");
			}
		}

		[XmlIgnore]
		public bool Forecasted_PayoutSpecified
		{
			get
			{
				return this.forecasted_PayoutFieldSpecified;
			}
			set
			{
				this.forecasted_PayoutFieldSpecified = value;
				this.RaisePropertyChanged("Forecasted_PayoutSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public CurrencyObjectType Forecasted_Payout_Currency_Reference
		{
			get
			{
				return this.forecasted_Payout_Currency_ReferenceField;
			}
			set
			{
				this.forecasted_Payout_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Forecasted_Payout_Currency_Reference");
			}
		}

		[XmlElement("Job_Family_Reference", Order = 14)]
		public Job_FamilyObjectType[] Job_Family_Reference
		{
			get
			{
				return this.job_Family_ReferenceField;
			}
			set
			{
				this.job_Family_ReferenceField = value;
				this.RaisePropertyChanged("Job_Family_Reference");
			}
		}

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
		public Position_Worker_TypeObjectType Job_Type_Reference
		{
			get
			{
				return this.job_Type_ReferenceField;
			}
			set
			{
				this.job_Type_ReferenceField = value;
				this.RaisePropertyChanged("Job_Type_Reference");
			}
		}

		[XmlElement(Order = 17)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Student_Award_Source_Reference", Order = 18)]
		public Student_Award_SourceObjectType[] Student_Award_Source_Reference
		{
			get
			{
				return this.student_Award_Source_ReferenceField;
			}
			set
			{
				this.student_Award_Source_ReferenceField = value;
				this.RaisePropertyChanged("Student_Award_Source_Reference");
			}
		}

		[XmlElement("Union_Reference", Order = 19)]
		public UnionObjectType[] Union_Reference
		{
			get
			{
				return this.union_ReferenceField;
			}
			set
			{
				this.union_ReferenceField = value;
				this.RaisePropertyChanged("Union_Reference");
			}
		}

		[XmlElement("Similar_Jobs_Reference", Order = 20)]
		public Job_PostingObjectType[] Similar_Jobs_Reference
		{
			get
			{
				return this.similar_Jobs_ReferenceField;
			}
			set
			{
				this.similar_Jobs_ReferenceField = value;
				this.RaisePropertyChanged("Similar_Jobs_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Job_Requisition_Restrictions_DataType Hiring_Requirement_Data
		{
			get
			{
				return this.hiring_Requirement_DataField;
			}
			set
			{
				this.hiring_Requirement_DataField = value;
				this.RaisePropertyChanged("Hiring_Requirement_Data");
			}
		}

		[XmlElement(Order = 22)]
		public Job_Requisition_Definition_DataType Job_Requisition_Detail_Data
		{
			get
			{
				return this.job_Requisition_Detail_DataField;
			}
			set
			{
				this.job_Requisition_Detail_DataField = value;
				this.RaisePropertyChanged("Job_Requisition_Detail_Data");
			}
		}

		[XmlElement(Order = 23)]
		public Qualifications_from_Position_Restrictions_DataType Qualification_Data
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

		[XmlArray(Order = 24), XmlArrayItem("Job_Requisition_Attachment_Data", IsNullable = false)]
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

		[XmlElement("Document_Field_Result_Data", Order = 25)]
		public Document_Field_Result_DataType[] Document_Field_Result_Data
		{
			get
			{
				return this.document_Field_Result_DataField;
			}
			set
			{
				this.document_Field_Result_DataField = value;
				this.RaisePropertyChanged("Document_Field_Result_Data");
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
