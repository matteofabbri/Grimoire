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
	public class Position_Details_DataType : INotifyPropertyChanged
	{
		private string position_IDField;

		private string job_Posting_TitleField;

		private bool academic_Tenure_EligibleField;

		private bool academic_Tenure_EligibleFieldSpecified;

		private string job_Description_SummaryField;

		private string job_DescriptionField;

		private Worker_EventObjectType[] position_Status_ReferenceField;

		private bool available_For_HireField;

		private bool available_For_HireFieldSpecified;

		private bool available_for_RecruitingField;

		private bool available_for_RecruitingFieldSpecified;

		private bool hiring_FreezeField;

		private bool hiring_FreezeFieldSpecified;

		private bool work_Shift_RequiredField;

		private bool work_Shift_RequiredFieldSpecified;

		private bool available_for_OverlapField;

		private bool available_for_OverlapFieldSpecified;

		private DateTime earliest_Overlap_DateField;

		private bool earliest_Overlap_DateFieldSpecified;

		private bool critical_JobField;

		private bool critical_JobFieldSpecified;

		private Difficulty_to_FillObjectType difficulty_to_Fill_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Position_Status_Reference", Order = 5)]
		public Worker_EventObjectType[] Position_Status_Reference
		{
			get
			{
				return this.position_Status_ReferenceField;
			}
			set
			{
				this.position_Status_ReferenceField = value;
				this.RaisePropertyChanged("Position_Status_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public bool Available_For_Hire
		{
			get
			{
				return this.available_For_HireField;
			}
			set
			{
				this.available_For_HireField = value;
				this.RaisePropertyChanged("Available_For_Hire");
			}
		}

		[XmlIgnore]
		public bool Available_For_HireSpecified
		{
			get
			{
				return this.available_For_HireFieldSpecified;
			}
			set
			{
				this.available_For_HireFieldSpecified = value;
				this.RaisePropertyChanged("Available_For_HireSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public bool Hiring_Freeze
		{
			get
			{
				return this.hiring_FreezeField;
			}
			set
			{
				this.hiring_FreezeField = value;
				this.RaisePropertyChanged("Hiring_Freeze");
			}
		}

		[XmlIgnore]
		public bool Hiring_FreezeSpecified
		{
			get
			{
				return this.hiring_FreezeFieldSpecified;
			}
			set
			{
				this.hiring_FreezeFieldSpecified = value;
				this.RaisePropertyChanged("Hiring_FreezeSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Work_Shift_Required
		{
			get
			{
				return this.work_Shift_RequiredField;
			}
			set
			{
				this.work_Shift_RequiredField = value;
				this.RaisePropertyChanged("Work_Shift_Required");
			}
		}

		[XmlIgnore]
		public bool Work_Shift_RequiredSpecified
		{
			get
			{
				return this.work_Shift_RequiredFieldSpecified;
			}
			set
			{
				this.work_Shift_RequiredFieldSpecified = value;
				this.RaisePropertyChanged("Work_Shift_RequiredSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public bool Available_for_Overlap
		{
			get
			{
				return this.available_for_OverlapField;
			}
			set
			{
				this.available_for_OverlapField = value;
				this.RaisePropertyChanged("Available_for_Overlap");
			}
		}

		[XmlIgnore]
		public bool Available_for_OverlapSpecified
		{
			get
			{
				return this.available_for_OverlapFieldSpecified;
			}
			set
			{
				this.available_for_OverlapFieldSpecified = value;
				this.RaisePropertyChanged("Available_for_OverlapSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 11)]
		public DateTime Earliest_Overlap_Date
		{
			get
			{
				return this.earliest_Overlap_DateField;
			}
			set
			{
				this.earliest_Overlap_DateField = value;
				this.RaisePropertyChanged("Earliest_Overlap_Date");
			}
		}

		[XmlIgnore]
		public bool Earliest_Overlap_DateSpecified
		{
			get
			{
				return this.earliest_Overlap_DateFieldSpecified;
			}
			set
			{
				this.earliest_Overlap_DateFieldSpecified = value;
				this.RaisePropertyChanged("Earliest_Overlap_DateSpecified");
			}
		}

		[XmlElement(Order = 12)]
		public bool Critical_Job
		{
			get
			{
				return this.critical_JobField;
			}
			set
			{
				this.critical_JobField = value;
				this.RaisePropertyChanged("Critical_Job");
			}
		}

		[XmlIgnore]
		public bool Critical_JobSpecified
		{
			get
			{
				return this.critical_JobFieldSpecified;
			}
			set
			{
				this.critical_JobFieldSpecified = value;
				this.RaisePropertyChanged("Critical_JobSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Difficulty_to_FillObjectType Difficulty_to_Fill_Reference
		{
			get
			{
				return this.difficulty_to_Fill_ReferenceField;
			}
			set
			{
				this.difficulty_to_Fill_ReferenceField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Reference");
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
