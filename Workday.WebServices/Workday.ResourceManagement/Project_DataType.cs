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
	public class Project_DataType : INotifyPropertyChanged
	{
		private string workday_Project_IDField;

		private bool locked_in_WorkdayField;

		private bool locked_in_WorkdayFieldSpecified;

		private Project_HierarchyObjectType project_Hierarchy_ReferenceField;

		private Project_HierarchyObjectType[] optional_Project_Hierarchy_ReferenceField;

		private Document_StatusObjectType[] project_Event_Status_ReferenceField;

		private Project_TemplateObjectType associated_Templates_from_Project_Template_ReferenceField;

		private string project_NameField;

		private bool worktag_OnlyField;

		private bool worktag_OnlyFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Project_StageObjectType project_Status_ReferenceField;

		private bool include_Project_ID_in_NameField;

		private bool include_Project_ID_in_NameFieldSpecified;

		private WorkerObjectType project_Owner_ReferenceField;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Project_Resource_PlanObjectType resource_Plan_ReferenceField;

		private bool billableField;

		private bool billableFieldSpecified;

		private bool capitalField;

		private bool capitalFieldSpecified;

		private string descriptionField;

		private decimal overall_Percent_CompleteField;

		private bool overall_Percent_CompleteFieldSpecified;

		private Risk_LevelObjectType risk_Level_ReferenceField;

		private Work_PriorityObjectType priority_ReferenceField;

		private Importance_RatingObjectType importance_Rating_ReferenceField;

		private Success_RatingObjectType success_Rating_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CustomerObjectType customer_ReferenceField;

		private Project_GroupObjectType project_Group_ReferenceField;

		private string external_Project_Reference_NameField;

		private string problem_StatementField;

		private string objectiveField;

		private string in_ScopeField;

		private string out_of_ScopeField;

		private string measures_of_SuccessField;

		private string project_OverviewField;

		private InitiativeObjectType initiative_ReferenceField;

		private decimal estimated_BudgetField;

		private bool estimated_BudgetFieldSpecified;

		private decimal estimated_RevenueField;

		private bool estimated_RevenueFieldSpecified;

		private decimal realized_RevenueField;

		private bool realized_RevenueFieldSpecified;

		private Related_Worktags_by_Worktag_Type_DataType[] worktags_DataField;

		private Balancing_WorktagObjectType balancing_Worktag_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] optional_Balancing_Worktag_ReferenceField;

		private ProjectObjectType[] project_Dependencies_ReferenceField;

		private Project_AbstractObjectType[] project_Prerequisite_For_ReferenceField;

		private Financials_Attachment_DataType[] project_Attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Workday_Project_ID
		{
			get
			{
				return this.workday_Project_IDField;
			}
			set
			{
				this.workday_Project_IDField = value;
				this.RaisePropertyChanged("Workday_Project_ID");
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
		public Project_HierarchyObjectType Project_Hierarchy_Reference
		{
			get
			{
				return this.project_Hierarchy_ReferenceField;
			}
			set
			{
				this.project_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Project_Hierarchy_Reference");
			}
		}

		[XmlElement("Optional_Project_Hierarchy_Reference", Order = 3)]
		public Project_HierarchyObjectType[] Optional_Project_Hierarchy_Reference
		{
			get
			{
				return this.optional_Project_Hierarchy_ReferenceField;
			}
			set
			{
				this.optional_Project_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Project_Hierarchy_Reference");
			}
		}

		[XmlElement("Project_Event_Status_Reference", Order = 4)]
		public Document_StatusObjectType[] Project_Event_Status_Reference
		{
			get
			{
				return this.project_Event_Status_ReferenceField;
			}
			set
			{
				this.project_Event_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Event_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Project_TemplateObjectType Associated_Templates_from_Project_Template_Reference
		{
			get
			{
				return this.associated_Templates_from_Project_Template_ReferenceField;
			}
			set
			{
				this.associated_Templates_from_Project_Template_ReferenceField = value;
				this.RaisePropertyChanged("Associated_Templates_from_Project_Template_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Project_Name
		{
			get
			{
				return this.project_NameField;
			}
			set
			{
				this.project_NameField = value;
				this.RaisePropertyChanged("Project_Name");
			}
		}

		[XmlElement(Order = 7)]
		public bool Worktag_Only
		{
			get
			{
				return this.worktag_OnlyField;
			}
			set
			{
				this.worktag_OnlyField = value;
				this.RaisePropertyChanged("Worktag_Only");
			}
		}

		[XmlIgnore]
		public bool Worktag_OnlySpecified
		{
			get
			{
				return this.worktag_OnlyFieldSpecified;
			}
			set
			{
				this.worktag_OnlyFieldSpecified = value;
				this.RaisePropertyChanged("Worktag_OnlySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Project_StageObjectType Project_Status_Reference
		{
			get
			{
				return this.project_Status_ReferenceField;
			}
			set
			{
				this.project_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Status_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Include_Project_ID_in_Name
		{
			get
			{
				return this.include_Project_ID_in_NameField;
			}
			set
			{
				this.include_Project_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Project_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Project_ID_in_NameSpecified
		{
			get
			{
				return this.include_Project_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Project_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Project_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public WorkerObjectType Project_Owner_Reference
		{
			get
			{
				return this.project_Owner_ReferenceField;
			}
			set
			{
				this.project_Owner_ReferenceField = value;
				this.RaisePropertyChanged("Project_Owner_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
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

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public Project_Resource_PlanObjectType Resource_Plan_Reference
		{
			get
			{
				return this.resource_Plan_ReferenceField;
			}
			set
			{
				this.resource_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Plan_Reference");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
		public bool Capital
		{
			get
			{
				return this.capitalField;
			}
			set
			{
				this.capitalField = value;
				this.RaisePropertyChanged("Capital");
			}
		}

		[XmlIgnore]
		public bool CapitalSpecified
		{
			get
			{
				return this.capitalFieldSpecified;
			}
			set
			{
				this.capitalFieldSpecified = value;
				this.RaisePropertyChanged("CapitalSpecified");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public decimal Overall_Percent_Complete
		{
			get
			{
				return this.overall_Percent_CompleteField;
			}
			set
			{
				this.overall_Percent_CompleteField = value;
				this.RaisePropertyChanged("Overall_Percent_Complete");
			}
		}

		[XmlIgnore]
		public bool Overall_Percent_CompleteSpecified
		{
			get
			{
				return this.overall_Percent_CompleteFieldSpecified;
			}
			set
			{
				this.overall_Percent_CompleteFieldSpecified = value;
				this.RaisePropertyChanged("Overall_Percent_CompleteSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public Risk_LevelObjectType Risk_Level_Reference
		{
			get
			{
				return this.risk_Level_ReferenceField;
			}
			set
			{
				this.risk_Level_ReferenceField = value;
				this.RaisePropertyChanged("Risk_Level_Reference");
			}
		}

		[XmlElement(Order = 21)]
		public Work_PriorityObjectType Priority_Reference
		{
			get
			{
				return this.priority_ReferenceField;
			}
			set
			{
				this.priority_ReferenceField = value;
				this.RaisePropertyChanged("Priority_Reference");
			}
		}

		[XmlElement(Order = 22)]
		public Importance_RatingObjectType Importance_Rating_Reference
		{
			get
			{
				return this.importance_Rating_ReferenceField;
			}
			set
			{
				this.importance_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Importance_Rating_Reference");
			}
		}

		[XmlElement(Order = 23)]
		public Success_RatingObjectType Success_Rating_Reference
		{
			get
			{
				return this.success_Rating_ReferenceField;
			}
			set
			{
				this.success_Rating_ReferenceField = value;
				this.RaisePropertyChanged("Success_Rating_Reference");
			}
		}

		[XmlElement(Order = 24)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 26)]
		public Project_GroupObjectType Project_Group_Reference
		{
			get
			{
				return this.project_Group_ReferenceField;
			}
			set
			{
				this.project_Group_ReferenceField = value;
				this.RaisePropertyChanged("Project_Group_Reference");
			}
		}

		[XmlElement(Order = 27)]
		public string External_Project_Reference_Name
		{
			get
			{
				return this.external_Project_Reference_NameField;
			}
			set
			{
				this.external_Project_Reference_NameField = value;
				this.RaisePropertyChanged("External_Project_Reference_Name");
			}
		}

		[XmlElement(Order = 28)]
		public string Problem_Statement
		{
			get
			{
				return this.problem_StatementField;
			}
			set
			{
				this.problem_StatementField = value;
				this.RaisePropertyChanged("Problem_Statement");
			}
		}

		[XmlElement(Order = 29)]
		public string Objective
		{
			get
			{
				return this.objectiveField;
			}
			set
			{
				this.objectiveField = value;
				this.RaisePropertyChanged("Objective");
			}
		}

		[XmlElement(Order = 30)]
		public string In_Scope
		{
			get
			{
				return this.in_ScopeField;
			}
			set
			{
				this.in_ScopeField = value;
				this.RaisePropertyChanged("In_Scope");
			}
		}

		[XmlElement(Order = 31)]
		public string Out_of_Scope
		{
			get
			{
				return this.out_of_ScopeField;
			}
			set
			{
				this.out_of_ScopeField = value;
				this.RaisePropertyChanged("Out_of_Scope");
			}
		}

		[XmlElement(Order = 32)]
		public string Measures_of_Success
		{
			get
			{
				return this.measures_of_SuccessField;
			}
			set
			{
				this.measures_of_SuccessField = value;
				this.RaisePropertyChanged("Measures_of_Success");
			}
		}

		[XmlElement(Order = 33)]
		public string Project_Overview
		{
			get
			{
				return this.project_OverviewField;
			}
			set
			{
				this.project_OverviewField = value;
				this.RaisePropertyChanged("Project_Overview");
			}
		}

		[XmlElement(Order = 34)]
		public InitiativeObjectType Initiative_Reference
		{
			get
			{
				return this.initiative_ReferenceField;
			}
			set
			{
				this.initiative_ReferenceField = value;
				this.RaisePropertyChanged("Initiative_Reference");
			}
		}

		[XmlElement(Order = 35)]
		public decimal Estimated_Budget
		{
			get
			{
				return this.estimated_BudgetField;
			}
			set
			{
				this.estimated_BudgetField = value;
				this.RaisePropertyChanged("Estimated_Budget");
			}
		}

		[XmlIgnore]
		public bool Estimated_BudgetSpecified
		{
			get
			{
				return this.estimated_BudgetFieldSpecified;
			}
			set
			{
				this.estimated_BudgetFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_BudgetSpecified");
			}
		}

		[XmlElement(Order = 36)]
		public decimal Estimated_Revenue
		{
			get
			{
				return this.estimated_RevenueField;
			}
			set
			{
				this.estimated_RevenueField = value;
				this.RaisePropertyChanged("Estimated_Revenue");
			}
		}

		[XmlIgnore]
		public bool Estimated_RevenueSpecified
		{
			get
			{
				return this.estimated_RevenueFieldSpecified;
			}
			set
			{
				this.estimated_RevenueFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_RevenueSpecified");
			}
		}

		[XmlElement(Order = 37)]
		public decimal Realized_Revenue
		{
			get
			{
				return this.realized_RevenueField;
			}
			set
			{
				this.realized_RevenueField = value;
				this.RaisePropertyChanged("Realized_Revenue");
			}
		}

		[XmlIgnore]
		public bool Realized_RevenueSpecified
		{
			get
			{
				return this.realized_RevenueFieldSpecified;
			}
			set
			{
				this.realized_RevenueFieldSpecified = value;
				this.RaisePropertyChanged("Realized_RevenueSpecified");
			}
		}

		[XmlArray(Order = 38), XmlArrayItem("Related_Worktags_by_Type_Data", IsNullable = false)]
		public Related_Worktags_by_Worktag_Type_DataType[] Worktags_Data
		{
			get
			{
				return this.worktags_DataField;
			}
			set
			{
				this.worktags_DataField = value;
				this.RaisePropertyChanged("Worktags_Data");
			}
		}

		[XmlElement(Order = 39)]
		public Balancing_WorktagObjectType Balancing_Worktag_Reference
		{
			get
			{
				return this.balancing_Worktag_ReferenceField;
			}
			set
			{
				this.balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Optional_Balancing_Worktag_Reference", Order = 40)]
		public Audited_Accounting_WorktagObjectType[] Optional_Balancing_Worktag_Reference
		{
			get
			{
				return this.optional_Balancing_Worktag_ReferenceField;
			}
			set
			{
				this.optional_Balancing_Worktag_ReferenceField = value;
				this.RaisePropertyChanged("Optional_Balancing_Worktag_Reference");
			}
		}

		[XmlElement("Project_Dependencies_Reference", Order = 41)]
		public ProjectObjectType[] Project_Dependencies_Reference
		{
			get
			{
				return this.project_Dependencies_ReferenceField;
			}
			set
			{
				this.project_Dependencies_ReferenceField = value;
				this.RaisePropertyChanged("Project_Dependencies_Reference");
			}
		}

		[XmlElement("Project_Prerequisite_For_Reference", Order = 42)]
		public Project_AbstractObjectType[] Project_Prerequisite_For_Reference
		{
			get
			{
				return this.project_Prerequisite_For_ReferenceField;
			}
			set
			{
				this.project_Prerequisite_For_ReferenceField = value;
				this.RaisePropertyChanged("Project_Prerequisite_For_Reference");
			}
		}

		[XmlElement("Project_Attachment_Data", Order = 43)]
		public Financials_Attachment_DataType[] Project_Attachment_Data
		{
			get
			{
				return this.project_Attachment_DataField;
			}
			set
			{
				this.project_Attachment_DataField = value;
				this.RaisePropertyChanged("Project_Attachment_Data");
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
