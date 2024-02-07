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
	public class Job_Profile_DataType : INotifyPropertyChanged
	{
		private string job_CodeField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Job_Profile_Basic_DataType job_Profile_Basic_DataField;

		private Job_Profile_Job_Classification_DataType[] job_Classification_DataField;

		private Job_Profile_Pay_Rate_DataType[] job_Profile_Pay_Rate_DataField;

		private Job_Profile_Exempt_DataType[] job_Profile_Exempt_DataField;

		private Workers_Compensation_Replacement_DataType[] workers_Compensation_Code_Replacement_DataField;

		private Qualification_Data_for_Position_Restriction_or_Job_ProfileType qualification_Replacement_DataField;

		private Document_Field_Result_DataType[] integration_Field_Override_DataField;

		private Job_Profile_Compensation_DataType job_Profile_Compensation_DataField;

		private Job_Profile_Union_Membership_DataType unions_DataField;

		private Job_Profile_Questionnaire_DataType questionnaire_DataField;

		private Job_Profile_Work_Study_DataType work_Study_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Job_Code
		{
			get
			{
				return this.job_CodeField;
			}
			set
			{
				this.job_CodeField = value;
				this.RaisePropertyChanged("Job_Code");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Job_Profile_Basic_DataType Job_Profile_Basic_Data
		{
			get
			{
				return this.job_Profile_Basic_DataField;
			}
			set
			{
				this.job_Profile_Basic_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Basic_Data");
			}
		}

		[XmlElement("Job_Classification_Data", Order = 3)]
		public Job_Profile_Job_Classification_DataType[] Job_Classification_Data
		{
			get
			{
				return this.job_Classification_DataField;
			}
			set
			{
				this.job_Classification_DataField = value;
				this.RaisePropertyChanged("Job_Classification_Data");
			}
		}

		[XmlElement("Job_Profile_Pay_Rate_Data", Order = 4)]
		public Job_Profile_Pay_Rate_DataType[] Job_Profile_Pay_Rate_Data
		{
			get
			{
				return this.job_Profile_Pay_Rate_DataField;
			}
			set
			{
				this.job_Profile_Pay_Rate_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Pay_Rate_Data");
			}
		}

		[XmlElement("Job_Profile_Exempt_Data", Order = 5)]
		public Job_Profile_Exempt_DataType[] Job_Profile_Exempt_Data
		{
			get
			{
				return this.job_Profile_Exempt_DataField;
			}
			set
			{
				this.job_Profile_Exempt_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Exempt_Data");
			}
		}

		[XmlElement("Workers_Compensation_Code_Replacement_Data", Order = 6)]
		public Workers_Compensation_Replacement_DataType[] Workers_Compensation_Code_Replacement_Data
		{
			get
			{
				return this.workers_Compensation_Code_Replacement_DataField;
			}
			set
			{
				this.workers_Compensation_Code_Replacement_DataField = value;
				this.RaisePropertyChanged("Workers_Compensation_Code_Replacement_Data");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 9)]
		public Job_Profile_Compensation_DataType Job_Profile_Compensation_Data
		{
			get
			{
				return this.job_Profile_Compensation_DataField;
			}
			set
			{
				this.job_Profile_Compensation_DataField = value;
				this.RaisePropertyChanged("Job_Profile_Compensation_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Job_Profile_Union_Membership_DataType Unions_Data
		{
			get
			{
				return this.unions_DataField;
			}
			set
			{
				this.unions_DataField = value;
				this.RaisePropertyChanged("Unions_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Job_Profile_Questionnaire_DataType Questionnaire_Data
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

		[XmlElement(Order = 12)]
		public Job_Profile_Work_Study_DataType Work_Study_Data
		{
			get
			{
				return this.work_Study_DataField;
			}
			set
			{
				this.work_Study_DataField = value;
				this.RaisePropertyChanged("Work_Study_Data");
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
