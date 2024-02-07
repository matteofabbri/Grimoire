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
	public class Project_Timesheet_DataType : INotifyPropertyChanged
	{
		private string project_Timesheet_IDField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private PeriodObjectType period__ReferenceField;

		private bool timesheet_Type_is_Project_WorksheetField;

		private bool timesheet_Type_is_Project_WorksheetFieldSpecified;

		private Project_Timesheet_Line_DataType[] project_Timesheet_Line_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Timesheet_ID
		{
			get
			{
				return this.project_Timesheet_IDField;
			}
			set
			{
				this.project_Timesheet_IDField = value;
				this.RaisePropertyChanged("Project_Timesheet_ID");
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
		public PeriodObjectType Period__Reference
		{
			get
			{
				return this.period__ReferenceField;
			}
			set
			{
				this.period__ReferenceField = value;
				this.RaisePropertyChanged("Period__Reference");
			}
		}

		[XmlElement(Order = 4)]
		public bool Timesheet_Type_is_Project_Worksheet
		{
			get
			{
				return this.timesheet_Type_is_Project_WorksheetField;
			}
			set
			{
				this.timesheet_Type_is_Project_WorksheetField = value;
				this.RaisePropertyChanged("Timesheet_Type_is_Project_Worksheet");
			}
		}

		[XmlIgnore]
		public bool Timesheet_Type_is_Project_WorksheetSpecified
		{
			get
			{
				return this.timesheet_Type_is_Project_WorksheetFieldSpecified;
			}
			set
			{
				this.timesheet_Type_is_Project_WorksheetFieldSpecified = value;
				this.RaisePropertyChanged("Timesheet_Type_is_Project_WorksheetSpecified");
			}
		}

		[XmlElement("Project_Timesheet_Line_Replacement_Data", Order = 5)]
		public Project_Timesheet_Line_DataType[] Project_Timesheet_Line_Replacement_Data
		{
			get
			{
				return this.project_Timesheet_Line_Replacement_DataField;
			}
			set
			{
				this.project_Timesheet_Line_Replacement_DataField = value;
				this.RaisePropertyChanged("Project_Timesheet_Line_Replacement_Data");
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
