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
	public class Project_Scenario_Plan_Task_DataType : INotifyPropertyChanged
	{
		private string plan_Task_IDField;

		private string orderField;

		private Project_PhaseObjectType phase_ReferenceField;

		private Project_TaskObjectType task_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal estimated_EffortField;

		private bool estimated_EffortFieldSpecified;

		private decimal calculated_EffortField;

		private bool calculated_EffortFieldSpecified;

		private Project_Scenario_Assignment_DataType[] assignment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Plan_Task_ID
		{
			get
			{
				return this.plan_Task_IDField;
			}
			set
			{
				this.plan_Task_IDField = value;
				this.RaisePropertyChanged("Plan_Task_ID");
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
		public Project_PhaseObjectType Phase_Reference
		{
			get
			{
				return this.phase_ReferenceField;
			}
			set
			{
				this.phase_ReferenceField = value;
				this.RaisePropertyChanged("Phase_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Project_TaskObjectType Task_Reference
		{
			get
			{
				return this.task_ReferenceField;
			}
			set
			{
				this.task_ReferenceField = value;
				this.RaisePropertyChanged("Task_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Estimated_Effort
		{
			get
			{
				return this.estimated_EffortField;
			}
			set
			{
				this.estimated_EffortField = value;
				this.RaisePropertyChanged("Estimated_Effort");
			}
		}

		[XmlIgnore]
		public bool Estimated_EffortSpecified
		{
			get
			{
				return this.estimated_EffortFieldSpecified;
			}
			set
			{
				this.estimated_EffortFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_EffortSpecified");
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

		[XmlElement("Assignment_Data", Order = 8)]
		public Project_Scenario_Assignment_DataType[] Assignment_Data
		{
			get
			{
				return this.assignment_DataField;
			}
			set
			{
				this.assignment_DataField = value;
				this.RaisePropertyChanged("Assignment_Data");
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
