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
	public class Payroll_Timesheet_Total_Hours_Request_CriteriaType : INotifyPropertyChanged
	{
		private OrganizationObjectType supervisory_Organization_ReferenceField;

		private WorkerObjectType[] worker_ReferenceField;

		private DateTime start_Date_On_or_AfterField;

		private bool start_Date_On_or_AfterFieldSpecified;

		private DateTime start_Date_On_or_BeforeField;

		private bool start_Date_On_or_BeforeFieldSpecified;

		private Document_StatusObjectType[] timesheet_Status_ReferenceField;

		private PeriodObjectType period_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Supervisory_Organization_Reference
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

		[XmlElement("Timesheet_Status_Reference", Order = 4)]
		public Document_StatusObjectType[] Timesheet_Status_Reference
		{
			get
			{
				return this.timesheet_Status_ReferenceField;
			}
			set
			{
				this.timesheet_Status_ReferenceField = value;
				this.RaisePropertyChanged("Timesheet_Status_Reference");
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
