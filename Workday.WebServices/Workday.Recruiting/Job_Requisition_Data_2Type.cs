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
	public class Job_Requisition_Data_2Type : INotifyPropertyChanged
	{
		private Job_Requisition_StatusObjectType job_Requisition_Status_ReferenceField;

		private Job_Requisition_Definition_DataType job_Requisition_Detail_DataField;

		private Job_Requisition_Restrictions_DataType hiring_Requirement_DataField;

		private Job_Requisition_Attachment_DataType[] job_Requisition_AttachmentsField;

		private Qualifications_from_Position_Restrictions_DataType qualification_DataField;

		private Position_GroupObjectType[] position_DataField;

		private Job_Requisition_Questionnaire_DataType questionnaire_ReferenceField;

		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private Organization_Assignments_for_Job_Requisition_DataType[] organization_DataField;

		private Role_Assignment_Effective_DataType[] role_Assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlArray(Order = 3), XmlArrayItem("Job_Requisition_Attachment_Data", IsNullable = false)]
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

		[XmlElement(Order = 4)]
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

		[XmlArray(Order = 5), XmlArrayItem("Position_Reference", typeof(Position_GroupObjectType), IsNullable = false)]
		public Position_GroupObjectType[] Position_Data
		{
			get
			{
				return this.position_DataField;
			}
			set
			{
				this.position_DataField = value;
				this.RaisePropertyChanged("Position_Data");
			}
		}

		[XmlElement(Order = 6)]
		public Job_Requisition_Questionnaire_DataType Questionnaire_Reference
		{
			get
			{
				return this.questionnaire_ReferenceField;
			}
			set
			{
				this.questionnaire_ReferenceField = value;
				this.RaisePropertyChanged("Questionnaire_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement("Integration_Field_Override_Data", Order = 8)]
		public Document_Field_Result_DataType[] Integration_Field_Override_Data
		{
			get
			{
				return this.integration_Field_Override_DataField;
			}
			set
			{
				this.integration_Field_Override_DataField = value;
				this.RaisePropertyChanged("Integration_Field_Override_Data");
			}
		}

		[XmlArray(Order = 9), XmlArrayItem("Organization_Assignments_Data", typeof(Organization_Assignments_for_Job_Requisition_DataType), IsNullable = false)]
		public Organization_Assignments_for_Job_Requisition_DataType[] Organization_Data
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

		[XmlElement("Role_Assignment_Data", Order = 10)]
		public Role_Assignment_Effective_DataType[] Role_Assignment_Data
		{
			get
			{
				return this.role_Assignment_DataField;
			}
			set
			{
				this.role_Assignment_DataField = value;
				this.RaisePropertyChanged("Role_Assignment_Data");
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
