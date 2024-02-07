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
	public class Review_Goal_DataType : INotifyPropertyChanged
	{
		private string goalField;

		private string descriptionField;

		private Talent_TagObjectType[] relates_To_ReferenceField;

		private Goal_CategoryObjectType[] category_ReferenceField;

		private decimal weightField;

		private bool weightFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Organization_GoalObjectType organization_Goal_ReferenceField;

		private Component_CompletionObjectType goal_Completion_Status_ReferenceField;

		private DateTime goal_Completion_DateField;

		private bool goal_Completion_DateFieldSpecified;

		private Review_Goal_Milestone_Detail_DataType[] review_Goal_Milestone_Detail_DataField;

		private Goal_Targets_and_Actuals_Amount_DataType goal_Targets_and_Actuals_Amount_DataField;

		private Goal_Targets_and_Actuals_Percent_DataType goal_Targets_and_Actuals_Percent_DataField;

		private Goal_Targets_and_Actuals_Unit_DataType goal_Targets_and_Actuals_Unit_DataField;

		private Manager_Component_Evaluation_DataType manager_Evaluation_DataField;

		private Employee_Component_Evaluation_DataType employee_Evaluation_DataField;

		private Additional_Manager_Component_Evaluation_DataType[] additional_Manager_Evaluation_DataField;

		private GoalObjectType goal_Base_ReferenceField;

		private bool goal_ArchivedField;

		private bool goal_ArchivedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goal
		{
			get
			{
				return this.goalField;
			}
			set
			{
				this.goalField = value;
				this.RaisePropertyChanged("Goal");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Relates_To_Reference", Order = 2)]
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

		[XmlElement("Category_Reference", Order = 3)]
		public Goal_CategoryObjectType[] Category_Reference
		{
			get
			{
				return this.category_ReferenceField;
			}
			set
			{
				this.category_ReferenceField = value;
				this.RaisePropertyChanged("Category_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Weight
		{
			get
			{
				return this.weightField;
			}
			set
			{
				this.weightField = value;
				this.RaisePropertyChanged("Weight");
			}
		}

		[XmlIgnore]
		public bool WeightSpecified
		{
			get
			{
				return this.weightFieldSpecified;
			}
			set
			{
				this.weightFieldSpecified = value;
				this.RaisePropertyChanged("WeightSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
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
		public Component_CompletionObjectType Goal_Completion_Status_Reference
		{
			get
			{
				return this.goal_Completion_Status_ReferenceField;
			}
			set
			{
				this.goal_Completion_Status_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Completion_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Goal_Completion_Date
		{
			get
			{
				return this.goal_Completion_DateField;
			}
			set
			{
				this.goal_Completion_DateField = value;
				this.RaisePropertyChanged("Goal_Completion_Date");
			}
		}

		[XmlIgnore]
		public bool Goal_Completion_DateSpecified
		{
			get
			{
				return this.goal_Completion_DateFieldSpecified;
			}
			set
			{
				this.goal_Completion_DateFieldSpecified = value;
				this.RaisePropertyChanged("Goal_Completion_DateSpecified");
			}
		}

		[XmlElement("Review_Goal_Milestone_Detail_Data", Order = 9)]
		public Review_Goal_Milestone_Detail_DataType[] Review_Goal_Milestone_Detail_Data
		{
			get
			{
				return this.review_Goal_Milestone_Detail_DataField;
			}
			set
			{
				this.review_Goal_Milestone_Detail_DataField = value;
				this.RaisePropertyChanged("Review_Goal_Milestone_Detail_Data");
			}
		}

		[XmlElement(Order = 10)]
		public Goal_Targets_and_Actuals_Amount_DataType Goal_Targets_and_Actuals_Amount_Data
		{
			get
			{
				return this.goal_Targets_and_Actuals_Amount_DataField;
			}
			set
			{
				this.goal_Targets_and_Actuals_Amount_DataField = value;
				this.RaisePropertyChanged("Goal_Targets_and_Actuals_Amount_Data");
			}
		}

		[XmlElement(Order = 11)]
		public Goal_Targets_and_Actuals_Percent_DataType Goal_Targets_and_Actuals_Percent_Data
		{
			get
			{
				return this.goal_Targets_and_Actuals_Percent_DataField;
			}
			set
			{
				this.goal_Targets_and_Actuals_Percent_DataField = value;
				this.RaisePropertyChanged("Goal_Targets_and_Actuals_Percent_Data");
			}
		}

		[XmlElement(Order = 12)]
		public Goal_Targets_and_Actuals_Unit_DataType Goal_Targets_and_Actuals_Unit_Data
		{
			get
			{
				return this.goal_Targets_and_Actuals_Unit_DataField;
			}
			set
			{
				this.goal_Targets_and_Actuals_Unit_DataField = value;
				this.RaisePropertyChanged("Goal_Targets_and_Actuals_Unit_Data");
			}
		}

		[XmlElement(Order = 13)]
		public Manager_Component_Evaluation_DataType Manager_Evaluation_Data
		{
			get
			{
				return this.manager_Evaluation_DataField;
			}
			set
			{
				this.manager_Evaluation_DataField = value;
				this.RaisePropertyChanged("Manager_Evaluation_Data");
			}
		}

		[XmlElement(Order = 14)]
		public Employee_Component_Evaluation_DataType Employee_Evaluation_Data
		{
			get
			{
				return this.employee_Evaluation_DataField;
			}
			set
			{
				this.employee_Evaluation_DataField = value;
				this.RaisePropertyChanged("Employee_Evaluation_Data");
			}
		}

		[XmlElement("Additional_Manager_Evaluation_Data", Order = 15)]
		public Additional_Manager_Component_Evaluation_DataType[] Additional_Manager_Evaluation_Data
		{
			get
			{
				return this.additional_Manager_Evaluation_DataField;
			}
			set
			{
				this.additional_Manager_Evaluation_DataField = value;
				this.RaisePropertyChanged("Additional_Manager_Evaluation_Data");
			}
		}

		[XmlElement(Order = 16)]
		public GoalObjectType Goal_Base_Reference
		{
			get
			{
				return this.goal_Base_ReferenceField;
			}
			set
			{
				this.goal_Base_ReferenceField = value;
				this.RaisePropertyChanged("Goal_Base_Reference");
			}
		}

		[XmlElement(Order = 17)]
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
