using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Scenario_Assignment_DataType : INotifyPropertyChanged
	{
		private string assignment_IDField;

		private string orderField;

		private Job_ProfileObjectType job_Profile_ReferenceField;

		private WorkerObjectType worker_ReferenceField;

		private bool to_Be_HiredField;

		private bool to_Be_HiredFieldSpecified;

		private DateTime assignment_Start_DateField;

		private bool assignment_Start_DateFieldSpecified;

		private DateTime assignment_End_DateField;

		private bool assignment_End_DateFieldSpecified;

		private decimal calculated_EffortField;

		private bool calculated_EffortFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Assignment_ID
		{
			get
			{
				return this.assignment_IDField;
			}
			set
			{
				this.assignment_IDField = value;
				this.RaisePropertyChanged("Assignment_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool To_Be_Hired
		{
			get
			{
				return this.to_Be_HiredField;
			}
			set
			{
				this.to_Be_HiredField = value;
				this.RaisePropertyChanged("To_Be_Hired");
			}
		}

		[XmlIgnore]
		public bool To_Be_HiredSpecified
		{
			get
			{
				return this.to_Be_HiredFieldSpecified;
			}
			set
			{
				this.to_Be_HiredFieldSpecified = value;
				this.RaisePropertyChanged("To_Be_HiredSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Assignment_Start_Date
		{
			get
			{
				return this.assignment_Start_DateField;
			}
			set
			{
				this.assignment_Start_DateField = value;
				this.RaisePropertyChanged("Assignment_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_Start_DateSpecified
		{
			get
			{
				return this.assignment_Start_DateFieldSpecified;
			}
			set
			{
				this.assignment_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Assignment_End_Date
		{
			get
			{
				return this.assignment_End_DateField;
			}
			set
			{
				this.assignment_End_DateField = value;
				this.RaisePropertyChanged("Assignment_End_Date");
			}
		}

		[XmlIgnore]
		public bool Assignment_End_DateSpecified
		{
			get
			{
				return this.assignment_End_DateFieldSpecified;
			}
			set
			{
				this.assignment_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Assignment_End_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Calculated_Effort
		{
			get
			{
				return this.calculated_EffortField;
			}
			set
			{
				this.calculated_EffortField = value;
				this.RaisePropertyChanged("Calculated_Effort");
			}
		}

		[XmlIgnore]
		public bool Calculated_EffortSpecified
		{
			get
			{
				return this.calculated_EffortFieldSpecified;
			}
			set
			{
				this.calculated_EffortFieldSpecified = value;
				this.RaisePropertyChanged("Calculated_EffortSpecified");
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
