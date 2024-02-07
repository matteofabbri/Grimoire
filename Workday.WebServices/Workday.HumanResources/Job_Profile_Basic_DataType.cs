using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Profile_Basic_DataType : INotifyPropertyChanged
	{
		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string job_TitleField;

		private bool include_Job_Code_in_NameField;

		private bool include_Job_Code_in_NameFieldSpecified;

		private string job_Profile_Private_TitleField;

		private string job_Profile_SummaryField;

		private string job_DescriptionField;

		private string additional_Job_DescriptionField;

		private bool work_Shift_RequiredField;

		private bool work_Shift_RequiredFieldSpecified;

		private bool public_JobField;

		private bool public_JobFieldSpecified;

		private Management_LevelObjectType management_Level_ReferenceField;

		private Job_CategoryObjectType job_Category_ReferenceField;

		private Job_LevelObjectType job_Level_ReferenceField;

		private Job_Profile_Job_Family_DataType[] job_Family_DataField;

		private Company_Insider_Job_Profile_DataType[] company_Insider_DataField;

		private OneTime_Payment_PlanObjectType referral_Payment_Plan_ReferenceField;

		private bool critical_JobField;

		private bool critical_JobFieldSpecified;

		private Difficulty_to_FillObjectType difficulty_to_Fill_ReferenceField;

		private CountryObjectType[] restrict_to_Country_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string Job_Title
		{
			get
			{
				return this.job_TitleField;
			}
			set
			{
				this.job_TitleField = value;
				this.RaisePropertyChanged("Job_Title");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Job_Code_in_Name
		{
			get
			{
				return this.include_Job_Code_in_NameField;
			}
			set
			{
				this.include_Job_Code_in_NameField = value;
				this.RaisePropertyChanged("Include_Job_Code_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Job_Code_in_NameSpecified
		{
			get
			{
				return this.include_Job_Code_in_NameFieldSpecified;
			}
			set
			{
				this.include_Job_Code_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Job_Code_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Job_Profile_Private_Title
		{
			get
			{
				return this.job_Profile_Private_TitleField;
			}
			set
			{
				this.job_Profile_Private_TitleField = value;
				this.RaisePropertyChanged("Job_Profile_Private_Title");
			}
		}

		[XmlElement(Order = 4)]
		public string Job_Profile_Summary
		{
			get
			{
				return this.job_Profile_SummaryField;
			}
			set
			{
				this.job_Profile_SummaryField = value;
				this.RaisePropertyChanged("Job_Profile_Summary");
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

		[XmlElement(Order = 8)]
		public bool Public_Job
		{
			get
			{
				return this.public_JobField;
			}
			set
			{
				this.public_JobField = value;
				this.RaisePropertyChanged("Public_Job");
			}
		}

		[XmlIgnore]
		public bool Public_JobSpecified
		{
			get
			{
				return this.public_JobFieldSpecified;
			}
			set
			{
				this.public_JobFieldSpecified = value;
				this.RaisePropertyChanged("Public_JobSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Management_LevelObjectType Management_Level_Reference
		{
			get
			{
				return this.management_Level_ReferenceField;
			}
			set
			{
				this.management_Level_ReferenceField = value;
				this.RaisePropertyChanged("Management_Level_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public Job_CategoryObjectType Job_Category_Reference
		{
			get
			{
				return this.job_Category_ReferenceField;
			}
			set
			{
				this.job_Category_ReferenceField = value;
				this.RaisePropertyChanged("Job_Category_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Job_LevelObjectType Job_Level_Reference
		{
			get
			{
				return this.job_Level_ReferenceField;
			}
			set
			{
				this.job_Level_ReferenceField = value;
				this.RaisePropertyChanged("Job_Level_Reference");
			}
		}

		[XmlElement("Job_Family_Data", Order = 12)]
		public Job_Profile_Job_Family_DataType[] Job_Family_Data
		{
			get
			{
				return this.job_Family_DataField;
			}
			set
			{
				this.job_Family_DataField = value;
				this.RaisePropertyChanged("Job_Family_Data");
			}
		}

		[XmlElement("Company_Insider_Data", Order = 13)]
		public Company_Insider_Job_Profile_DataType[] Company_Insider_Data
		{
			get
			{
				return this.company_Insider_DataField;
			}
			set
			{
				this.company_Insider_DataField = value;
				this.RaisePropertyChanged("Company_Insider_Data");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
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

		[XmlElement(Order = 16)]
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

		[XmlElement("Restrict_to_Country_Reference", Order = 17)]
		public CountryObjectType[] Restrict_to_Country_Reference
		{
			get
			{
				return this.restrict_to_Country_ReferenceField;
			}
			set
			{
				this.restrict_to_Country_ReferenceField = value;
				this.RaisePropertyChanged("Restrict_to_Country_Reference");
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
