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
	public class Project_Scenario_Group_DataType : INotifyPropertyChanged
	{
		private string project_Scenario_Group_Reference_IDField;

		private string project_Scenario_Group_NameField;

		private Project_HierarchyObjectType project_Hierarchy_ReferenceField;

		private InitiativeObjectType initiative_ReferenceField;

		private Project_ScenarioObjectType primary_Project_Scenario_ReferenceField;

		private Project_ScenarioObjectType[] available_Project_Scenarios_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Scenario_Group_Reference_ID
		{
			get
			{
				return this.project_Scenario_Group_Reference_IDField;
			}
			set
			{
				this.project_Scenario_Group_Reference_IDField = value;
				this.RaisePropertyChanged("Project_Scenario_Group_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Scenario_Group_Name
		{
			get
			{
				return this.project_Scenario_Group_NameField;
			}
			set
			{
				this.project_Scenario_Group_NameField = value;
				this.RaisePropertyChanged("Project_Scenario_Group_Name");
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Project_ScenarioObjectType Primary_Project_Scenario_Reference
		{
			get
			{
				return this.primary_Project_Scenario_ReferenceField;
			}
			set
			{
				this.primary_Project_Scenario_ReferenceField = value;
				this.RaisePropertyChanged("Primary_Project_Scenario_Reference");
			}
		}

		[XmlElement("Available_Project_Scenarios_Reference", Order = 5)]
		public Project_ScenarioObjectType[] Available_Project_Scenarios_Reference
		{
			get
			{
				return this.available_Project_Scenarios_ReferenceField;
			}
			set
			{
				this.available_Project_Scenarios_ReferenceField = value;
				this.RaisePropertyChanged("Available_Project_Scenarios_Reference");
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
