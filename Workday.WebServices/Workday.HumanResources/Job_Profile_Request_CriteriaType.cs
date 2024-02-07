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
	public class Job_Profile_Request_CriteriaType : INotifyPropertyChanged
	{
		private Transaction_Log_CriteriaType[] transaction_Log_Criteria_DataField;

		private Unique_IdentifierObjectType event_ReferenceField;

		private Job_Family_BaseObjectType[] job_Family_ReferenceField;

		private Management_LevelObjectType[] management_Level_ReferenceField;

		private Job_LevelObjectType[] job_Level_ReferenceField;

		private Job_CategoryObjectType[] job_Category_ReferenceField;

		private Company_Insider_TypeObjectType[] company_Insider_Type_ReferenceField;

		private Job_ClassificationObjectType[] job_Classification_ReferenceField;

		private Job_Classification_GroupObjectType[] job_Classification_Group_ReferenceField;

		private Workers_Compensation_CodeObjectType[] workers_Compensation_Code_ReferenceField;

		private Work_Hours_ProfileObjectType[] work_Hours_Profile_ReferenceField;

		private External_Field_and_Parameter_Initialization_ProviderObjectType[] field_And_Parameter_Criteria_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Transaction_Log_Criteria_Data", Order = 0)]
		public Transaction_Log_CriteriaType[] Transaction_Log_Criteria_Data
		{
			get
			{
				return this.transaction_Log_Criteria_DataField;
			}
			set
			{
				this.transaction_Log_Criteria_DataField = value;
				this.RaisePropertyChanged("Transaction_Log_Criteria_Data");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Event_Reference
		{
			get
			{
				return this.event_ReferenceField;
			}
			set
			{
				this.event_ReferenceField = value;
				this.RaisePropertyChanged("Event_Reference");
			}
		}

		[XmlElement("Job_Family_Reference", Order = 2)]
		public Job_Family_BaseObjectType[] Job_Family_Reference
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

		[XmlElement("Management_Level_Reference", Order = 3)]
		public Management_LevelObjectType[] Management_Level_Reference
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

		[XmlElement("Job_Level_Reference", Order = 4)]
		public Job_LevelObjectType[] Job_Level_Reference
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

		[XmlElement("Job_Category_Reference", Order = 5)]
		public Job_CategoryObjectType[] Job_Category_Reference
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

		[XmlElement("Company_Insider_Type_Reference", Order = 6)]
		public Company_Insider_TypeObjectType[] Company_Insider_Type_Reference
		{
			get
			{
				return this.company_Insider_Type_ReferenceField;
			}
			set
			{
				this.company_Insider_Type_ReferenceField = value;
				this.RaisePropertyChanged("Company_Insider_Type_Reference");
			}
		}

		[XmlElement("Job_Classification_Reference", Order = 7)]
		public Job_ClassificationObjectType[] Job_Classification_Reference
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

		[XmlElement("Job_Classification_Group_Reference", Order = 8)]
		public Job_Classification_GroupObjectType[] Job_Classification_Group_Reference
		{
			get
			{
				return this.job_Classification_Group_ReferenceField;
			}
			set
			{
				this.job_Classification_Group_ReferenceField = value;
				this.RaisePropertyChanged("Job_Classification_Group_Reference");
			}
		}

		[XmlElement("Workers_Compensation_Code_Reference", Order = 9)]
		public Workers_Compensation_CodeObjectType[] Workers_Compensation_Code_Reference
		{
			get
			{
				return this.workers_Compensation_Code_ReferenceField;
			}
			set
			{
				this.workers_Compensation_Code_ReferenceField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code_Reference");
			}
		}

		[XmlElement("Work_Hours_Profile_Reference", Order = 10)]
		public Work_Hours_ProfileObjectType[] Work_Hours_Profile_Reference
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

		[XmlArray(Order = 11), XmlArrayItem("Provider_Reference", IsNullable = false)]
		public External_Field_and_Parameter_Initialization_ProviderObjectType[] Field_And_Parameter_Criteria_Data
		{
			get
			{
				return this.field_And_Parameter_Criteria_DataField;
			}
			set
			{
				this.field_And_Parameter_Criteria_DataField = value;
				this.RaisePropertyChanged("Field_And_Parameter_Criteria_Data");
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
