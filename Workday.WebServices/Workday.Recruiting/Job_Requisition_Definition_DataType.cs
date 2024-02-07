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
	public class Job_Requisition_Definition_DataType : INotifyPropertyChanged
	{
		private string job_Posting_TitleField;

		private decimal positions_AllocatedField;

		private bool positions_AllocatedFieldSpecified;

		private decimal positions_AvailableField;

		private bool positions_AvailableFieldSpecified;

		private bool academic_Tenure_EligibleField;

		private bool academic_Tenure_EligibleFieldSpecified;

		private string job_Description_SummaryField;

		private string job_DescriptionField;

		private string additional_Job_DescriptionField;

		private string justificationField;

		private Recruiting_Instruction_DataType recruiting_Instruction_DataField;

		private bool available_for_RecruitingField;

		private bool available_for_RecruitingFieldSpecified;

		private WorkerObjectType replacement_for_Worker_ReferenceField;

		private bool confidential_Job_RequisitionField;

		private bool confidential_Job_RequisitionFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public decimal Positions_Allocated
		{
			get
			{
				return this.positions_AllocatedField;
			}
			set
			{
				this.positions_AllocatedField = value;
				this.RaisePropertyChanged("Positions_Allocated");
			}
		}

		[XmlIgnore]
		public bool Positions_AllocatedSpecified
		{
			get
			{
				return this.positions_AllocatedFieldSpecified;
			}
			set
			{
				this.positions_AllocatedFieldSpecified = value;
				this.RaisePropertyChanged("Positions_AllocatedSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Positions_Available
		{
			get
			{
				return this.positions_AvailableField;
			}
			set
			{
				this.positions_AvailableField = value;
				this.RaisePropertyChanged("Positions_Available");
			}
		}

		[XmlIgnore]
		public bool Positions_AvailableSpecified
		{
			get
			{
				return this.positions_AvailableFieldSpecified;
			}
			set
			{
				this.positions_AvailableFieldSpecified = value;
				this.RaisePropertyChanged("Positions_AvailableSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public bool Available_for_Recruiting
		{
			get
			{
				return this.available_for_RecruitingField;
			}
			set
			{
				this.available_for_RecruitingField = value;
				this.RaisePropertyChanged("Available_for_Recruiting");
			}
		}

		[XmlIgnore]
		public bool Available_for_RecruitingSpecified
		{
			get
			{
				return this.available_for_RecruitingFieldSpecified;
			}
			set
			{
				this.available_for_RecruitingFieldSpecified = value;
				this.RaisePropertyChanged("Available_for_RecruitingSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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
