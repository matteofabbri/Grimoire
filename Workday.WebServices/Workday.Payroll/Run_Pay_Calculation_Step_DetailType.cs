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
	public class Run_Pay_Calculation_Step_DetailType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType job_Step_Runtime_ReferenceField;

		private Unique_IdentifierObjectType status_ReferenceField;

		private DateTime start_Date_TimeField;

		private bool start_Date_TimeFieldSpecified;

		private DateTime end_Date_TimeField;

		private bool end_Date_TimeFieldSpecified;

		private decimal cumulative_Step_Time__min_Field;

		private bool cumulative_Step_Time__min_FieldSpecified;

		private decimal result_CountField;

		private bool result_CountFieldSpecified;

		private decimal partitions_CompletedField;

		private bool partitions_CompletedFieldSpecified;

		private decimal total_PartitionsField;

		private bool total_PartitionsFieldSpecified;

		private decimal runtime_ParametersField;

		private bool runtime_ParametersFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Job_Step_Runtime_Reference
		{
			get
			{
				return this.job_Step_Runtime_ReferenceField;
			}
			set
			{
				this.job_Step_Runtime_ReferenceField = value;
				this.RaisePropertyChanged("Job_Step_Runtime_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Unique_IdentifierObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public DateTime Start_Date_Time
		{
			get
			{
				return this.start_Date_TimeField;
			}
			set
			{
				this.start_Date_TimeField = value;
				this.RaisePropertyChanged("Start_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Start_Date_TimeSpecified
		{
			get
			{
				return this.start_Date_TimeFieldSpecified;
			}
			set
			{
				this.start_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public DateTime End_Date_Time
		{
			get
			{
				return this.end_Date_TimeField;
			}
			set
			{
				this.end_Date_TimeField = value;
				this.RaisePropertyChanged("End_Date_Time");
			}
		}

		[XmlIgnore]
		public bool End_Date_TimeSpecified
		{
			get
			{
				return this.end_Date_TimeFieldSpecified;
			}
			set
			{
				this.end_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("End_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Cumulative_Step_Time__min_
		{
			get
			{
				return this.cumulative_Step_Time__min_Field;
			}
			set
			{
				this.cumulative_Step_Time__min_Field = value;
				this.RaisePropertyChanged("Cumulative_Step_Time__min_");
			}
		}

		[XmlIgnore]
		public bool Cumulative_Step_Time__min_Specified
		{
			get
			{
				return this.cumulative_Step_Time__min_FieldSpecified;
			}
			set
			{
				this.cumulative_Step_Time__min_FieldSpecified = value;
				this.RaisePropertyChanged("Cumulative_Step_Time__min_Specified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Result_Count
		{
			get
			{
				return this.result_CountField;
			}
			set
			{
				this.result_CountField = value;
				this.RaisePropertyChanged("Result_Count");
			}
		}

		[XmlIgnore]
		public bool Result_CountSpecified
		{
			get
			{
				return this.result_CountFieldSpecified;
			}
			set
			{
				this.result_CountFieldSpecified = value;
				this.RaisePropertyChanged("Result_CountSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Partitions_Completed
		{
			get
			{
				return this.partitions_CompletedField;
			}
			set
			{
				this.partitions_CompletedField = value;
				this.RaisePropertyChanged("Partitions_Completed");
			}
		}

		[XmlIgnore]
		public bool Partitions_CompletedSpecified
		{
			get
			{
				return this.partitions_CompletedFieldSpecified;
			}
			set
			{
				this.partitions_CompletedFieldSpecified = value;
				this.RaisePropertyChanged("Partitions_CompletedSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Total_Partitions
		{
			get
			{
				return this.total_PartitionsField;
			}
			set
			{
				this.total_PartitionsField = value;
				this.RaisePropertyChanged("Total_Partitions");
			}
		}

		[XmlIgnore]
		public bool Total_PartitionsSpecified
		{
			get
			{
				return this.total_PartitionsFieldSpecified;
			}
			set
			{
				this.total_PartitionsFieldSpecified = value;
				this.RaisePropertyChanged("Total_PartitionsSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Runtime_Parameters
		{
			get
			{
				return this.runtime_ParametersField;
			}
			set
			{
				this.runtime_ParametersField = value;
				this.RaisePropertyChanged("Runtime_Parameters");
			}
		}

		[XmlIgnore]
		public bool Runtime_ParametersSpecified
		{
			get
			{
				return this.runtime_ParametersFieldSpecified;
			}
			set
			{
				this.runtime_ParametersFieldSpecified = value;
				this.RaisePropertyChanged("Runtime_ParametersSpecified");
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
