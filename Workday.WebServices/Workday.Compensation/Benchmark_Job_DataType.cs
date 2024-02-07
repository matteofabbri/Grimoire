using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Benchmark_Job_DataType : INotifyPropertyChanged
	{
		private string benchmark_Job_IDField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private string nameField;

		private DateTime survey_DateField;

		private bool survey_DateFieldSpecified;

		private string descriptionField;

		private Job_ProfileObjectType[] job_Profile_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private FrequencyObjectType frequency_ReferenceField;

		private Benchmark_Job_Composite_DataType[] benchmark_Job_Composite_Replacement_DataField;

		private Compensation_Benchmark_Profile_DataType[] benchmark_Profile_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Benchmark_Job_ID
		{
			get
			{
				return this.benchmark_Job_IDField;
			}
			set
			{
				this.benchmark_Job_IDField = value;
				this.RaisePropertyChanged("Benchmark_Job_ID");
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

		[XmlElement(Order = 3)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Survey_Date
		{
			get
			{
				return this.survey_DateField;
			}
			set
			{
				this.survey_DateField = value;
				this.RaisePropertyChanged("Survey_Date");
			}
		}

		[XmlIgnore]
		public bool Survey_DateSpecified
		{
			get
			{
				return this.survey_DateFieldSpecified;
			}
			set
			{
				this.survey_DateFieldSpecified = value;
				this.RaisePropertyChanged("Survey_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Job_Profile_Reference", Order = 6)]
		public Job_ProfileObjectType[] Job_Profile_Reference
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

		[XmlElement(Order = 7)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public FrequencyObjectType Frequency_Reference
		{
			get
			{
				return this.frequency_ReferenceField;
			}
			set
			{
				this.frequency_ReferenceField = value;
				this.RaisePropertyChanged("Frequency_Reference");
			}
		}

		[XmlElement("Benchmark_Job_Composite_Replacement_Data", Order = 9)]
		public Benchmark_Job_Composite_DataType[] Benchmark_Job_Composite_Replacement_Data
		{
			get
			{
				return this.benchmark_Job_Composite_Replacement_DataField;
			}
			set
			{
				this.benchmark_Job_Composite_Replacement_DataField = value;
				this.RaisePropertyChanged("Benchmark_Job_Composite_Replacement_Data");
			}
		}

		[XmlElement("Benchmark_Profile_Data", Order = 10)]
		public Compensation_Benchmark_Profile_DataType[] Benchmark_Profile_Data
		{
			get
			{
				return this.benchmark_Profile_DataField;
			}
			set
			{
				this.benchmark_Profile_DataField = value;
				this.RaisePropertyChanged("Benchmark_Profile_Data");
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
