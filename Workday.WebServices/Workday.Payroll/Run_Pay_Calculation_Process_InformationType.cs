using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Run_Pay_Calculation_Process_InformationType : INotifyPropertyChanged
	{
		private Background_Process_TypeObjectType process_Type_ReferenceField;

		private DateTime scheduled_Start_Date_and_TimeField;

		private bool scheduled_Start_Date_and_TimeFieldSpecified;

		private DateTime actual_Start_Date_and_TimeField;

		private bool actual_Start_Date_and_TimeFieldSpecified;

		private DateTime completed_Date_and_TimeField;

		private bool completed_Date_and_TimeFieldSpecified;

		private InstanceObjectType submitted_By_ReferenceField;

		private string total_Processing_TimeField;

		private Unique_IdentifierObjectType job_Definition_ReferenceField;

		private Unique_IdentifierObjectType job_Mode_ReferenceField;

		private decimal job_SizeField;

		private bool job_SizeFieldSpecified;

		private decimal job_ParametersField;

		private bool job_ParametersFieldSpecified;

		private decimal application_KeysField;

		private bool application_KeysFieldSpecified;

		private Run_Pay_Calculation_Technical_DetailsType[] run_Pay_Calculation_Technical_DetailsField;

		private Run_Pay_Calculation_Step_DetailType[] run_Pay_Calculation_Step_DetailsField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Background_Process_TypeObjectType Process_Type_Reference
		{
			get
			{
				return this.process_Type_ReferenceField;
			}
			set
			{
				this.process_Type_ReferenceField = value;
				this.RaisePropertyChanged("Process_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Scheduled_Start_Date_and_Time
		{
			get
			{
				return this.scheduled_Start_Date_and_TimeField;
			}
			set
			{
				this.scheduled_Start_Date_and_TimeField = value;
				this.RaisePropertyChanged("Scheduled_Start_Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Scheduled_Start_Date_and_TimeSpecified
		{
			get
			{
				return this.scheduled_Start_Date_and_TimeFieldSpecified;
			}
			set
			{
				this.scheduled_Start_Date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Scheduled_Start_Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Actual_Start_Date_and_Time
		{
			get
			{
				return this.actual_Start_Date_and_TimeField;
			}
			set
			{
				this.actual_Start_Date_and_TimeField = value;
				this.RaisePropertyChanged("Actual_Start_Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Actual_Start_Date_and_TimeSpecified
		{
			get
			{
				return this.actual_Start_Date_and_TimeFieldSpecified;
			}
			set
			{
				this.actual_Start_Date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Actual_Start_Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime Completed_Date_and_Time
		{
			get
			{
				return this.completed_Date_and_TimeField;
			}
			set
			{
				this.completed_Date_and_TimeField = value;
				this.RaisePropertyChanged("Completed_Date_and_Time");
			}
		}

		[XmlIgnore]
		public bool Completed_Date_and_TimeSpecified
		{
			get
			{
				return this.completed_Date_and_TimeFieldSpecified;
			}
			set
			{
				this.completed_Date_and_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Completed_Date_and_TimeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public InstanceObjectType Submitted_By_Reference
		{
			get
			{
				return this.submitted_By_ReferenceField;
			}
			set
			{
				this.submitted_By_ReferenceField = value;
				this.RaisePropertyChanged("Submitted_By_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Total_Processing_Time
		{
			get
			{
				return this.total_Processing_TimeField;
			}
			set
			{
				this.total_Processing_TimeField = value;
				this.RaisePropertyChanged("Total_Processing_Time");
			}
		}

		[XmlElement(Order = 6)]
		public Unique_IdentifierObjectType Job_Definition_Reference
		{
			get
			{
				return this.job_Definition_ReferenceField;
			}
			set
			{
				this.job_Definition_ReferenceField = value;
				this.RaisePropertyChanged("Job_Definition_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Unique_IdentifierObjectType Job_Mode_Reference
		{
			get
			{
				return this.job_Mode_ReferenceField;
			}
			set
			{
				this.job_Mode_ReferenceField = value;
				this.RaisePropertyChanged("Job_Mode_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Job_Size
		{
			get
			{
				return this.job_SizeField;
			}
			set
			{
				this.job_SizeField = value;
				this.RaisePropertyChanged("Job_Size");
			}
		}

		[XmlIgnore]
		public bool Job_SizeSpecified
		{
			get
			{
				return this.job_SizeFieldSpecified;
			}
			set
			{
				this.job_SizeFieldSpecified = value;
				this.RaisePropertyChanged("Job_SizeSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Job_Parameters
		{
			get
			{
				return this.job_ParametersField;
			}
			set
			{
				this.job_ParametersField = value;
				this.RaisePropertyChanged("Job_Parameters");
			}
		}

		[XmlIgnore]
		public bool Job_ParametersSpecified
		{
			get
			{
				return this.job_ParametersFieldSpecified;
			}
			set
			{
				this.job_ParametersFieldSpecified = value;
				this.RaisePropertyChanged("Job_ParametersSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Application_Keys
		{
			get
			{
				return this.application_KeysField;
			}
			set
			{
				this.application_KeysField = value;
				this.RaisePropertyChanged("Application_Keys");
			}
		}

		[XmlIgnore]
		public bool Application_KeysSpecified
		{
			get
			{
				return this.application_KeysFieldSpecified;
			}
			set
			{
				this.application_KeysFieldSpecified = value;
				this.RaisePropertyChanged("Application_KeysSpecified");
			}
		}

		[XmlElement("Run_Pay_Calculation_Technical_Details", Order = 11)]
		public Run_Pay_Calculation_Technical_DetailsType[] Run_Pay_Calculation_Technical_Details
		{
			get
			{
				return this.run_Pay_Calculation_Technical_DetailsField;
			}
			set
			{
				this.run_Pay_Calculation_Technical_DetailsField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Technical_Details");
			}
		}

		[XmlArray(Order = 12), XmlArrayItem("Run_Pay_Calculation_Step_Detail", typeof(Run_Pay_Calculation_Step_DetailType), IsNullable = false)]
		public Run_Pay_Calculation_Step_DetailType[] Run_Pay_Calculation_Step_Details
		{
			get
			{
				return this.run_Pay_Calculation_Step_DetailsField;
			}
			set
			{
				this.run_Pay_Calculation_Step_DetailsField = value;
				this.RaisePropertyChanged("Run_Pay_Calculation_Step_Details");
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
