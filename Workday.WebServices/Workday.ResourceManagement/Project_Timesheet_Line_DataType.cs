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
	public class Project_Timesheet_Line_DataType : INotifyPropertyChanged
	{
		private Time_Entry_CodeObjectType time_Code_ReferenceField;

		private ActivityObjectType activity_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private decimal percent_CompleteField;

		private bool percent_CompleteFieldSpecified;

		private string memoField;

		private decimal worksheet_Allocation_PercentField;

		private bool worksheet_Allocation_PercentFieldSpecified;

		private Project_Timesheet_Day_DataType[] project_Timesheet_DayField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public ActivityObjectType Activity_Reference
		{
			get
			{
				return this.activity_ReferenceField;
			}
			set
			{
				this.activity_ReferenceField = value;
				this.RaisePropertyChanged("Activity_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 2)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Percent_Complete
		{
			get
			{
				return this.percent_CompleteField;
			}
			set
			{
				this.percent_CompleteField = value;
				this.RaisePropertyChanged("Percent_Complete");
			}
		}

		[XmlIgnore]
		public bool Percent_CompleteSpecified
		{
			get
			{
				return this.percent_CompleteFieldSpecified;
			}
			set
			{
				this.percent_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Percent_CompleteSpecified");
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

		[XmlElement(Order = 5)]
		public decimal Worksheet_Allocation_Percent
		{
			get
			{
				return this.worksheet_Allocation_PercentField;
			}
			set
			{
				this.worksheet_Allocation_PercentField = value;
				this.RaisePropertyChanged("Worksheet_Allocation_Percent");
			}
		}

		[XmlIgnore]
		public bool Worksheet_Allocation_PercentSpecified
		{
			get
			{
				return this.worksheet_Allocation_PercentFieldSpecified;
			}
			set
			{
				this.worksheet_Allocation_PercentFieldSpecified = value;
				this.RaisePropertyChanged("Worksheet_Allocation_PercentSpecified");
			}
		}

		[XmlElement("Project_Timesheet_Day", Order = 6)]
		public Project_Timesheet_Day_DataType[] Project_Timesheet_Day
		{
			get
			{
				return this.project_Timesheet_DayField;
			}
			set
			{
				this.project_Timesheet_DayField = value;
				this.RaisePropertyChanged("Project_Timesheet_Day");
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
