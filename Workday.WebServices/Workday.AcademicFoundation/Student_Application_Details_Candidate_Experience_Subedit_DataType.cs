using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.AcademicFoundation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Student_Application_Details_Candidate_Experience_Subedit_DataType : INotifyPropertyChanged
	{
		private Candidate_ExperienceObjectType candidate_Experience_ReferenceField;

		private Job_History_CompanyObjectType company_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private string job_TitleField;

		private CountryObjectType country_ReferenceField;

		private Country_RegionObjectType state_Province_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Candidate_ExperienceObjectType Candidate_Experience_Reference
		{
			get
			{
				return this.candidate_Experience_ReferenceField;
			}
			set
			{
				this.candidate_Experience_ReferenceField = value;
				this.RaisePropertyChanged("Candidate_Experience_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Job_History_CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public CountryObjectType Country_Reference
		{
			get
			{
				return this.country_ReferenceField;
			}
			set
			{
				this.country_ReferenceField = value;
				this.RaisePropertyChanged("Country_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Country_RegionObjectType State_Province_Reference
		{
			get
			{
				return this.state_Province_ReferenceField;
			}
			set
			{
				this.state_Province_ReferenceField = value;
				this.RaisePropertyChanged("State_Province_Reference");
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
