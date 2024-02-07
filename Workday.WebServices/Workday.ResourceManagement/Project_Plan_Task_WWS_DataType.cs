using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Plan_Task_WWS_DataType : INotifyPropertyChanged
	{
		private string project_Plan_Task_IDField;

		private string orderField;

		private Project_TaskObjectType task_ReferenceField;

		private string custom_Task_NameField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private decimal percent_CompleteField;

		private bool percent_CompleteFieldSpecified;

		private bool milestoneField;

		private bool milestoneFieldSpecified;

		private bool closedField;

		private bool closedFieldSpecified;

		private bool utilizationField;

		private bool utilizationFieldSpecified;

		private string memoField;

		private Financials_Attachment_DataType[] task_Attachment_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Plan_Task_ID
		{
			get
			{
				return this.project_Plan_Task_IDField;
			}
			set
			{
				this.project_Plan_Task_IDField = value;
				this.RaisePropertyChanged("Project_Plan_Task_ID");
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

		[XmlElement(Order = 3)]
		public string Custom_Task_Name
		{
			get
			{
				return this.custom_Task_NameField;
			}
			set
			{
				this.custom_Task_NameField = value;
				this.RaisePropertyChanged("Custom_Task_Name");
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

		[XmlElement(Order = 7)]
		public bool Milestone
		{
			get
			{
				return this.milestoneField;
			}
			set
			{
				this.milestoneField = value;
				this.RaisePropertyChanged("Milestone");
			}
		}

		[XmlIgnore]
		public bool MilestoneSpecified
		{
			get
			{
				return this.milestoneFieldSpecified;
			}
			set
			{
				this.milestoneFieldSpecified = value;
				this.RaisePropertyChanged("MilestoneSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Closed
		{
			get
			{
				return this.closedField;
			}
			set
			{
				this.closedField = value;
				this.RaisePropertyChanged("Closed");
			}
		}

		[XmlIgnore]
		public bool ClosedSpecified
		{
			get
			{
				return this.closedFieldSpecified;
			}
			set
			{
				this.closedFieldSpecified = value;
				this.RaisePropertyChanged("ClosedSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public bool Utilization
		{
			get
			{
				return this.utilizationField;
			}
			set
			{
				this.utilizationField = value;
				this.RaisePropertyChanged("Utilization");
			}
		}

		[XmlIgnore]
		public bool UtilizationSpecified
		{
			get
			{
				return this.utilizationFieldSpecified;
			}
			set
			{
				this.utilizationFieldSpecified = value;
				this.RaisePropertyChanged("UtilizationSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement("Task_Attachment_Data", Order = 11)]
		public Financials_Attachment_DataType[] Task_Attachment_Data
		{
			get
			{
				return this.task_Attachment_DataField;
			}
			set
			{
				this.task_Attachment_DataField = value;
				this.RaisePropertyChanged("Task_Attachment_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
