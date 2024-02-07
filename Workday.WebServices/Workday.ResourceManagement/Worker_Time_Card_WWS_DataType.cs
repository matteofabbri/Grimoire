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
	public class Worker_Time_Card_WWS_DataType : INotifyPropertyChanged
	{
		private string worker_Time_Card_IDField;

		private DateTime last_Updated_DateField;

		private bool last_Updated_DateFieldSpecified;

		private bool is_Payroll_TimesheetField;

		private bool is_Payroll_TimesheetFieldSpecified;

		private string worker_Time_Card_StatusField;

		private WorkerObjectType worker_ReferenceField;

		private PeriodObjectType period_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Time_ZoneObjectType time_Zone_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Worker_Time_Card_ID
		{
			get
			{
				return this.worker_Time_Card_IDField;
			}
			set
			{
				this.worker_Time_Card_IDField = value;
				this.RaisePropertyChanged("Worker_Time_Card_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Last_Updated_Date
		{
			get
			{
				return this.last_Updated_DateField;
			}
			set
			{
				this.last_Updated_DateField = value;
				this.RaisePropertyChanged("Last_Updated_Date");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_DateSpecified
		{
			get
			{
				return this.last_Updated_DateFieldSpecified;
			}
			set
			{
				this.last_Updated_DateFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Is_Payroll_Timesheet
		{
			get
			{
				return this.is_Payroll_TimesheetField;
			}
			set
			{
				this.is_Payroll_TimesheetField = value;
				this.RaisePropertyChanged("Is_Payroll_Timesheet");
			}
		}

		[XmlIgnore]
		public bool Is_Payroll_TimesheetSpecified
		{
			get
			{
				return this.is_Payroll_TimesheetFieldSpecified;
			}
			set
			{
				this.is_Payroll_TimesheetFieldSpecified = value;
				this.RaisePropertyChanged("Is_Payroll_TimesheetSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public string Worker_Time_Card_Status
		{
			get
			{
				return this.worker_Time_Card_StatusField;
			}
			set
			{
				this.worker_Time_Card_StatusField = value;
				this.RaisePropertyChanged("Worker_Time_Card_Status");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public PeriodObjectType Period_Reference
		{
			get
			{
				return this.period_ReferenceField;
			}
			set
			{
				this.period_ReferenceField = value;
				this.RaisePropertyChanged("Period_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(Order = 8)]
		public Time_ZoneObjectType Time_Zone_Reference
		{
			get
			{
				return this.time_Zone_ReferenceField;
			}
			set
			{
				this.time_Zone_ReferenceField = value;
				this.RaisePropertyChanged("Time_Zone_Reference");
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
