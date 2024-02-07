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
	public class Project_Scenario_DataType : INotifyPropertyChanged
	{
		private string project_Scenario_Reference_IDField;

		private Document_StatusObjectType project_Scenario_Status_ReferenceField;

		private string project_Scenario_NameField;

		private Project_Scenario_GroupObjectType project_Scenario_Group_ReferenceField;

		private DateTime start_DateField;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private Unit_of_TimeObjectType time_Unit_for_Effort_ReferenceField;

		private string descriptionField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal spendField;

		private bool spendFieldSpecified;

		private decimal manual_BudgetField;

		private bool manual_BudgetFieldSpecified;

		private decimal revenue_SavingsField;

		private bool revenue_SavingsFieldSpecified;

		private Project_Scenario_Plan_Task_DataType[] plan_Task_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Scenario_Reference_ID
		{
			get
			{
				return this.project_Scenario_Reference_IDField;
			}
			set
			{
				this.project_Scenario_Reference_IDField = value;
				this.RaisePropertyChanged("Project_Scenario_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Project_Scenario_Status_Reference
		{
			get
			{
				return this.project_Scenario_Status_ReferenceField;
			}
			set
			{
				this.project_Scenario_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Scenario_Status_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Project_Scenario_Name
		{
			get
			{
				return this.project_Scenario_NameField;
			}
			set
			{
				this.project_Scenario_NameField = value;
				this.RaisePropertyChanged("Project_Scenario_Name");
			}
		}

		[XmlElement(Order = 3)]
		public Project_Scenario_GroupObjectType Project_Scenario_Group_Reference
		{
			get
			{
				return this.project_Scenario_Group_ReferenceField;
			}
			set
			{
				this.project_Scenario_Group_ReferenceField = value;
				this.RaisePropertyChanged("Project_Scenario_Group_Reference");
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
		public Unit_of_TimeObjectType Time_Unit_for_Effort_Reference
		{
			get
			{
				return this.time_Unit_for_Effort_ReferenceField;
			}
			set
			{
				this.time_Unit_for_Effort_ReferenceField = value;
				this.RaisePropertyChanged("Time_Unit_for_Effort_Reference");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Spend
		{
			get
			{
				return this.spendField;
			}
			set
			{
				this.spendField = value;
				this.RaisePropertyChanged("Spend");
			}
		}

		[XmlIgnore]
		public bool SpendSpecified
		{
			get
			{
				return this.spendFieldSpecified;
			}
			set
			{
				this.spendFieldSpecified = value;
				this.RaisePropertyChanged("SpendSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Manual_Budget
		{
			get
			{
				return this.manual_BudgetField;
			}
			set
			{
				this.manual_BudgetField = value;
				this.RaisePropertyChanged("Manual_Budget");
			}
		}

		[XmlIgnore]
		public bool Manual_BudgetSpecified
		{
			get
			{
				return this.manual_BudgetFieldSpecified;
			}
			set
			{
				this.manual_BudgetFieldSpecified = value;
				this.RaisePropertyChanged("Manual_BudgetSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Revenue_Savings
		{
			get
			{
				return this.revenue_SavingsField;
			}
			set
			{
				this.revenue_SavingsField = value;
				this.RaisePropertyChanged("Revenue_Savings");
			}
		}

		[XmlIgnore]
		public bool Revenue_SavingsSpecified
		{
			get
			{
				return this.revenue_SavingsFieldSpecified;
			}
			set
			{
				this.revenue_SavingsFieldSpecified = value;
				this.RaisePropertyChanged("Revenue_SavingsSpecified");
			}
		}

		[XmlElement("Plan_Task_Data", Order = 12)]
		public Project_Scenario_Plan_Task_DataType[] Plan_Task_Data
		{
			get
			{
				return this.plan_Task_DataField;
			}
			set
			{
				this.plan_Task_DataField = value;
				this.RaisePropertyChanged("Plan_Task_Data");
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
