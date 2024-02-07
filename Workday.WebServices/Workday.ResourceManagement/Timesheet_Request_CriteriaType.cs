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
	public class Timesheet_Request_CriteriaType : INotifyPropertyChanged
	{
		private Supervisory_OrganizationObjectType supervisory_Organization_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

		private DateTime start_Date_On_or_AfterField;

		private bool start_Date_On_or_AfterFieldSpecified;

		private DateTime start_Date_On_or_BeforeField;

		private bool start_Date_On_or_BeforeFieldSpecified;

		private DateTime last_Updated_On_or_AfterField;

		private bool last_Updated_On_or_AfterFieldSpecified;

		private DateTime last_Updated_On_or_BeforeField;

		private bool last_Updated_On_or_BeforeFieldSpecified;

		private bool payroll_Timesheets_OnlyField;

		private bool payroll_Timesheets_OnlyFieldSpecified;

		private bool project_Timesheets_OnlyField;

		private bool project_Timesheets_OnlyFieldSpecified;

		private bool time_In_Time_Out_Timesheets_OnlyField;

		private bool time_In_Time_Out_Timesheets_OnlyFieldSpecified;

		private bool multiWorker_Timesheets_OnlyField;

		private bool multiWorker_Timesheets_OnlyFieldSpecified;

		private string worker_Time_Card_Reference_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supervisory_OrganizationObjectType Supervisory_Organization_Reference
		{
			get
			{
				return this.supervisory_Organization_ReferenceField;
			}
			set
			{
				this.supervisory_Organization_ReferenceField = value;
				this.RaisePropertyChanged("Supervisory_Organization_Reference");
			}
		}

		[XmlElement("Worker_Reference", Order = 1)]
		public WorkerObjectType[] Worker_Reference
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

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Start_Date_On_or_After
		{
			get
			{
				return this.start_Date_On_or_AfterField;
			}
			set
			{
				this.start_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Start_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Start_Date_On_or_AfterSpecified
		{
			get
			{
				return this.start_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.start_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Start_Date_On_or_Before
		{
			get
			{
				return this.start_Date_On_or_BeforeField;
			}
			set
			{
				this.start_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Start_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Start_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.start_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.start_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Start_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Last_Updated_On_or_After
		{
			get
			{
				return this.last_Updated_On_or_AfterField;
			}
			set
			{
				this.last_Updated_On_or_AfterField = value;
				this.RaisePropertyChanged("Last_Updated_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_On_or_AfterSpecified
		{
			get
			{
				return this.last_Updated_On_or_AfterFieldSpecified;
			}
			set
			{
				this.last_Updated_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Last_Updated_On_or_Before
		{
			get
			{
				return this.last_Updated_On_or_BeforeField;
			}
			set
			{
				this.last_Updated_On_or_BeforeField = value;
				this.RaisePropertyChanged("Last_Updated_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Last_Updated_On_or_BeforeSpecified
		{
			get
			{
				return this.last_Updated_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.last_Updated_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Last_Updated_On_or_BeforeSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Payroll_Timesheets_Only
		{
			get
			{
				return this.payroll_Timesheets_OnlyField;
			}
			set
			{
				this.payroll_Timesheets_OnlyField = value;
				this.RaisePropertyChanged("Payroll_Timesheets_Only");
			}
		}

		[XmlIgnore]
		public bool Payroll_Timesheets_OnlySpecified
		{
			get
			{
				return this.payroll_Timesheets_OnlyFieldSpecified;
			}
			set
			{
				this.payroll_Timesheets_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Payroll_Timesheets_OnlySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool Project_Timesheets_Only
		{
			get
			{
				return this.project_Timesheets_OnlyField;
			}
			set
			{
				this.project_Timesheets_OnlyField = value;
				this.RaisePropertyChanged("Project_Timesheets_Only");
			}
		}

		[XmlIgnore]
		public bool Project_Timesheets_OnlySpecified
		{
			get
			{
				return this.project_Timesheets_OnlyFieldSpecified;
			}
			set
			{
				this.project_Timesheets_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Project_Timesheets_OnlySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Time_In_Time_Out_Timesheets_Only
		{
			get
			{
				return this.time_In_Time_Out_Timesheets_OnlyField;
			}
			set
			{
				this.time_In_Time_Out_Timesheets_OnlyField = value;
				this.RaisePropertyChanged("Time_In_Time_Out_Timesheets_Only");
			}
		}

		[XmlIgnore]
		public bool Time_In_Time_Out_Timesheets_OnlySpecified
		{
			get
			{
				return this.time_In_Time_Out_Timesheets_OnlyFieldSpecified;
			}
			set
			{
				this.time_In_Time_Out_Timesheets_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Time_In_Time_Out_Timesheets_OnlySpecified");
			}
		}

		[XmlElement("Multi-Worker_Timesheets_Only", Order = 9)]
		public bool MultiWorker_Timesheets_Only
		{
			get
			{
				return this.multiWorker_Timesheets_OnlyField;
			}
			set
			{
				this.multiWorker_Timesheets_OnlyField = value;
				this.RaisePropertyChanged("MultiWorker_Timesheets_Only");
			}
		}

		[XmlIgnore]
		public bool MultiWorker_Timesheets_OnlySpecified
		{
			get
			{
				return this.multiWorker_Timesheets_OnlyFieldSpecified;
			}
			set
			{
				this.multiWorker_Timesheets_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("MultiWorker_Timesheets_OnlySpecified");
			}
		}

		[XmlElement(Order = 10)]
		public string Worker_Time_Card_Reference_ID
		{
			get
			{
				return this.worker_Time_Card_Reference_IDField;
			}
			set
			{
				this.worker_Time_Card_Reference_IDField = value;
				this.RaisePropertyChanged("Worker_Time_Card_Reference_ID");
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
