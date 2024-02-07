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
	public class Payroll_Timesheet_Total_Hours_Data_WWSType : INotifyPropertyChanged
	{
		private string payroll_Timesheet_Total_Hours_IDField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private PeriodObjectType period_ReferenceField;

		private Payroll_Timesheet_Line_DataType[] payroll_Timesheet_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payroll_Timesheet_Total_Hours_ID
		{
			get
			{
				return this.payroll_Timesheet_Total_Hours_IDField;
			}
			set
			{
				this.payroll_Timesheet_Total_Hours_IDField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Total_Hours_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Locked_in_Workday
		{
			get
			{
				return this.locked_in_WorkdayField;
			}
			set
			{
				this.locked_in_WorkdayField = value;
				this.RaisePropertyChanged("Locked_in_Workday");
			}
		}

		[XmlIgnore]
		public bool Locked_in_WorkdaySpecified
		{
			get
			{
				return this.locked_in_WorkdayFieldSpecified;
			}
			set
			{
				this.locked_in_WorkdayFieldSpecified = value;
				this.RaisePropertyChanged("Locked_in_WorkdaySpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement("Payroll_Timesheet_Line_Replacement_Data", Order = 4)]
		public Payroll_Timesheet_Line_DataType[] Payroll_Timesheet_Line_Replacement_Data
		{
			get
			{
				return this.payroll_Timesheet_Line_Replacement_DataField;
			}
			set
			{
				this.payroll_Timesheet_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Payroll_Timesheet_Line_Replacement_Data");
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
