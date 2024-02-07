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
	public class Job_History_Achievement_DataType : INotifyPropertyChanged
	{
		private string job_History_IDField;

		private bool remove_Job_HistoryField;

		private bool remove_Job_HistoryFieldSpecified;

		private string job_TitleField;

		private string companyField;

		private Job_History_CompanyObjectType job_History_Company_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string responsibilities_and_AchievementsField;

		private string locationField;

		private string job_ReferenceField;

		private string contactField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_History_ID
		{
			get
			{
				return this.job_History_IDField;
			}
			set
			{
				this.job_History_IDField = value;
				this.RaisePropertyChanged("Job_History_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Remove_Job_History
		{
			get
			{
				return this.remove_Job_HistoryField;
			}
			set
			{
				this.remove_Job_HistoryField = value;
				this.RaisePropertyChanged("Remove_Job_History");
			}
		}

		[XmlIgnore]
		public bool Remove_Job_HistorySpecified
		{
			get
			{
				return this.remove_Job_HistoryFieldSpecified;
			}
			set
			{
				this.remove_Job_HistoryFieldSpecified = value;
				this.RaisePropertyChanged("Remove_Job_HistorySpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Company
		{
			get
			{
				return this.companyField;
			}
			set
			{
				this.companyField = value;
				this.RaisePropertyChanged("Company");
			}
		}

		[XmlElement(Order = 4)]
		public Job_History_CompanyObjectType Job_History_Company_Reference
		{
			get
			{
				return this.job_History_Company_ReferenceField;
			}
			set
			{
				this.job_History_Company_ReferenceField = value;
				this.RaisePropertyChanged("Job_History_Company_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Responsibilities_and_Achievements
		{
			get
			{
				return this.responsibilities_and_AchievementsField;
			}
			set
			{
				this.responsibilities_and_AchievementsField = value;
				this.RaisePropertyChanged("Responsibilities_and_Achievements");
			}
		}

		[XmlElement(Order = 8)]
		public string Location
		{
			get
			{
				return this.locationField;
			}
			set
			{
				this.locationField = value;
				this.RaisePropertyChanged("Location");
			}
		}

		[XmlElement(Order = 9)]
		public string Job_Reference
		{
			get
			{
				return this.job_ReferenceField;
			}
			set
			{
				this.job_ReferenceField = value;
				this.RaisePropertyChanged("Job_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public string Contact
		{
			get
			{
				return this.contactField;
			}
			set
			{
				this.contactField = value;
				this.RaisePropertyChanged("Contact");
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
