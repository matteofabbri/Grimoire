using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Job_Profile_in_Position_Summary_DataType : INotifyPropertyChanged
	{
		private Job_ProfileObjectType job_Profile_ReferenceField;

		private bool job_ExemptField;

		private bool job_ExemptFieldSpecified;

		private Management_LevelObjectType management_Level_ReferenceField;

		private Job_CategoryObjectType job_Category_ReferenceField;

		private Job_Family_BaseObjectType[] job_Family_ReferenceField;

		private string job_Profile_NameField;

		private bool work_Shift_RequiredField;

		private bool work_Shift_RequiredFieldSpecified;

		private bool critical_JobField;

		private bool critical_JobFieldSpecified;

		private Difficulty_to_FillObjectType difficulty_to_Fill_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Job_Family_Reference", Order = 4)]
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

		[XmlElement(Order = 5)]
		public string Job_Profile_Name
		{
			get
			{
				return this.job_Profile_NameField;
			}
			set
			{
				this.job_Profile_NameField = value;
				this.RaisePropertyChanged("Job_Profile_Name");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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
