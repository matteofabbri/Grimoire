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
	public class Timesheet_Daily_WWS_DataType : INotifyPropertyChanged
	{
		private DateTime timesheet_Day_DateField;

		private bool timesheet_Day_DateFieldSpecified;

		private Time_Entry_CodeObjectType time_Code_ReferenceField;

		private decimal hours_WorkedField;

		private bool hours_WorkedFieldSpecified;

		private bool billableField;

		private bool billableFieldSpecified;

		private string memoField;

		private Audited_Accounting_WorktagObjectType[] worktags_ReferenceField;

		private ProjectObjectType project_ReferenceField;

		private Project_Plan_TaskObjectType project_Task_ReferenceField;

		private PositionObjectType[] position_ReferenceField;

		private decimal percent_Complete_Proposed_for_Timesheet_DayField;

		private bool percent_Complete_Proposed_for_Timesheet_DayFieldSpecified;

		private Time_In_Time_Out_WWS_DataType[] time_In_Time_Out_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Timesheet_Day_Date
		{
			get
			{
				return this.timesheet_Day_DateField;
			}
			set
			{
				this.timesheet_Day_DateField = value;
				this.RaisePropertyChanged("Timesheet_Day_Date");
			}
		}

		[XmlIgnore]
		public bool Timesheet_Day_DateSpecified
		{
			get
			{
				return this.timesheet_Day_DateFieldSpecified;
			}
			set
			{
				this.timesheet_Day_DateFieldSpecified = value;
				this.RaisePropertyChanged("Timesheet_Day_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Time_Entry_CodeObjectType Time_Code_Reference
		{
			get
			{
				return this.time_Code_ReferenceField;
			}
			set
			{
				this.time_Code_ReferenceField = value;
				this.RaisePropertyChanged("Time_Code_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Hours_Worked
		{
			get
			{
				return this.hours_WorkedField;
			}
			set
			{
				this.hours_WorkedField = value;
				this.RaisePropertyChanged("Hours_Worked");
			}
		}

		[XmlIgnore]
		public bool Hours_WorkedSpecified
		{
			get
			{
				return this.hours_WorkedFieldSpecified;
			}
			set
			{
				this.hours_WorkedFieldSpecified = value;
				this.RaisePropertyChanged("Hours_WorkedSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Billable
		{
			get
			{
				return this.billableField;
			}
			set
			{
				this.billableField = value;
				this.RaisePropertyChanged("Billable");
			}
		}

		[XmlIgnore]
		public bool BillableSpecified
		{
			get
			{
				return this.billableFieldSpecified;
			}
			set
			{
				this.billableFieldSpecified = value;
				this.RaisePropertyChanged("BillableSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Worktags_Reference", Order = 5)]
		public Audited_Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public ProjectObjectType Project_Reference
		{
			get
			{
				return this.project_ReferenceField;
			}
			set
			{
				this.project_ReferenceField = value;
				this.RaisePropertyChanged("Project_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Project_Plan_TaskObjectType Project_Task_Reference
		{
			get
			{
				return this.project_Task_ReferenceField;
			}
			set
			{
				this.project_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Task_Reference");
			}
		}

		[XmlElement("Position_Reference", Order = 8)]
		public PositionObjectType[] Position_Reference
		{
			get
			{
				return this.position_ReferenceField;
			}
			set
			{
				this.position_ReferenceField = value;
				this.RaisePropertyChanged("Position_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Percent_Complete_Proposed_for_Timesheet_Day
		{
			get
			{
				return this.percent_Complete_Proposed_for_Timesheet_DayField;
			}
			set
			{
				this.percent_Complete_Proposed_for_Timesheet_DayField = value;
				this.RaisePropertyChanged("Percent_Complete_Proposed_for_Timesheet_Day");
			}
		}

		[XmlIgnore]
		public bool Percent_Complete_Proposed_for_Timesheet_DaySpecified
		{
			get
			{
				return this.percent_Complete_Proposed_for_Timesheet_DayFieldSpecified;
			}
			set
			{
				this.percent_Complete_Proposed_for_Timesheet_DayFieldSpecified = value;
				this.RaisePropertyChanged("Percent_Complete_Proposed_for_Timesheet_DaySpecified");
			}
		}

		[XmlElement("Time_In_Time_Out_Data", Order = 10)]
		public Time_In_Time_Out_WWS_DataType[] Time_In_Time_Out_Data
		{
			get
			{
				return this.time_In_Time_Out_DataField;
			}
			set
			{
				this.time_In_Time_Out_DataField = value;
				this.RaisePropertyChanged("Time_In_Time_Out_Data");
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
