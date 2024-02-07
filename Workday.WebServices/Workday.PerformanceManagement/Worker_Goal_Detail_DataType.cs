using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.PerformanceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Worker_Goal_Detail_DataType : INotifyPropertyChanged
	{
		private GoalObjectType goal_ReferenceField;

		private string goal_Reference_IDField;

		private string nameField;

		private string descriptionField;

		private Talent_TagObjectType[] relates_To_ReferenceField;

		private Goal_CategoryObjectType[] goal_Category_ReferenceField;

		private Organization_GoalObjectType organization_Goal_ReferenceField;

		private decimal goal_WeightField;

		private bool goal_WeightFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Component_CompletionObjectType status_ReferenceField;

		private DateTime completion_DateField;

		private bool completion_DateFieldSpecified;

		private Goal_Comment_DataType[] goal_Comment_DataField;

		private Worker_Goal_Milestone_Detail_DataType[] worker_Goal_Milestone_Detail_DataField;

		private Goal_Targets_and_Actuals_Amount_DataType goal_Amount_DataField;

		private Goal_Targets_and_Actuals_Percent_DataType goal_Percent_DataField;

		private Goal_Targets_and_Actuals_Unit_DataType goal_Unit_DataField;

		private bool goal_ArchivedField;

		private bool goal_ArchivedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public GoalObjectType Goal_Reference
		{
			get
			{
				return this.goal_ReferenceField;
			}
			set
			{
				this.goal_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Goal_Reference_ID
		{
			get
			{
				return this.goal_Reference_IDField;
			}
			set
			{
				this.goal_Reference_IDField = value;
				this.RaisePropertyChanged("Goal_Reference_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 3)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Relates_To_Reference", Order = 4)]
		public Talent_TagObjectType[] Relates_To_Reference
		{
			get
			{
				return this.relates_To_ReferenceField;
			}
			set
			{
				this.relates_To_ReferenceField = value;
				this.RaisePropertyChanged("Relates_To_Reference");
			}
		}

		[XmlElement("Goal_Category_Reference", Order = 5)]
		public Goal_CategoryObjectType[] Goal_Category_Reference
		{
			get
			{
				return this.goal_Category_ReferenceField;
			}
			set
			{
				this.goal_Category_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Organization_GoalObjectType Organization_Goal_Reference
		{
			get
			{
				return this.organization_Goal_ReferenceField;
			}
			set
			{
				this.organization_Goal_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Goal_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Goal_Weight
		{
			get
			{
				return this.goal_WeightField;
			}
			set
			{
				this.goal_WeightField = value;
				this.RaisePropertyChanged("Goal_Weight");
			}
		}

		[XmlIgnore]
		public bool Goal_WeightSpecified
		{
			get
			{
				return this.goal_WeightFieldSpecified;
			}
			set
			{
				this.goal_WeightFieldSpecified = value;
				this.RaisePropertyChanged("Goal_WeightSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Component_CompletionObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 10)]
		public DateTime Completion_Date
		{
			get
			{
				return this.completion_DateField;
			}
			set
			{
				this.completion_DateField = value;
				this.RaisePropertyChanged("Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Completion_DateSpecified
		{
			get
			{
				return this.completion_DateFieldSpecified;
			}
			set
			{
				this.completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Completion_DateSpecified");
			}
		}

		[XmlElement("Goal_Comment_Data", Order = 11)]
		public Goal_Comment_DataType[] Goal_Comment_Data
		{
			get
			{
				return this.goal_Comment_DataField;
			}
			set
			{
				this.goal_Comment_DataField = value;
				this.RaisePropertyChanged("Goal_Comment_Data");
			}
		}

		[XmlElement("Worker_Goal_Milestone_Detail_Data", Order = 12)]
		public Worker_Goal_Milestone_Detail_DataType[] Worker_Goal_Milestone_Detail_Data
		{
			get
			{
				return this.worker_Goal_Milestone_Detail_DataField;
			}
			set
			{
				this.worker_Goal_Milestone_Detail_DataField = value;
				this.RaisePropertyChanged("Worker_Goal_Milestone_Detail_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Goal_Targets_and_Actuals_Amount_DataType Goal_Amount_Data
		{
			get
			{
				return this.goal_Amount_DataField;
			}
			set
			{
				this.goal_Amount_DataField = value;
				this.RaisePropertyChanged("Goal_Amount_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Goal_Targets_and_Actuals_Percent_DataType Goal_Percent_Data
		{
			get
			{
				return this.goal_Percent_DataField;
			}
			set
			{
				this.goal_Percent_DataField = value;
				this.RaisePropertyChanged("Goal_Percent_Data");
			}
		}

		[XmlElement(Order = 15)]
		public Goal_Targets_and_Actuals_Unit_DataType Goal_Unit_Data
		{
			get
			{
				return this.goal_Unit_DataField;
			}
			set
			{
				this.goal_Unit_DataField = value;
				this.RaisePropertyChanged("Goal_Unit_Data");
			}
		}

		[XmlElement(Order = 16)]
		public bool Goal_Archived
		{
			get
			{
				return this.goal_ArchivedField;
			}
			set
			{
				this.goal_ArchivedField = value;
				this.RaisePropertyChanged("Goal_Archived");
			}
		}

		[XmlIgnore]
		public bool Goal_ArchivedSpecified
		{
			get
			{
				return this.goal_ArchivedFieldSpecified;
			}
			set
			{
				this.goal_ArchivedFieldSpecified = value;
				this.RaisePropertyChanged("Goal_ArchivedSpecified");
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
