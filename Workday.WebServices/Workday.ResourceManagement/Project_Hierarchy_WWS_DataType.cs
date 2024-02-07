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
	public class Project_Hierarchy_WWS_DataType : INotifyPropertyChanged
	{
		private string project_Hierarchy_IDField;

		private string project_Hierarchy_NameField;

		private bool include_Project_Hierarchy_ID_in_NameField;

		private bool include_Project_Hierarchy_ID_in_NameFieldSpecified;

		private bool enable_as_Optional_HierarchyField;

		private bool enable_as_Optional_HierarchyFieldSpecified;

		private Document_StatusObjectType project_Hierarchy_Status_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Project_HierarchyObjectType inactivated_By_Hierarchy_ReferenceField;

		private Organization_SubtypeObjectType organization_Subtype_ReferenceField;

		private Project_HierarchyObjectType parent_ReferenceField;

		private Project_Resource_PlanObjectType project_Resource_Plan_ReferenceField;

		private Project_Scenario_GroupObjectType[] project_Scenario_Groups_ReferenceField;

		private string descriptionField;

		private CurrencyObjectType reporting_Currency_ReferenceField;

		private ProjectObjectType[] included_Projects_ReferenceField;

		private ProjectObjectType[] included_Projects_in_Optional_Hierarchy_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Hierarchy_ID
		{
			get
			{
				return this.project_Hierarchy_IDField;
			}
			set
			{
				this.project_Hierarchy_IDField = value;
				this.RaisePropertyChanged("Project_Hierarchy_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Project_Hierarchy_Name
		{
			get
			{
				return this.project_Hierarchy_NameField;
			}
			set
			{
				this.project_Hierarchy_NameField = value;
				this.RaisePropertyChanged("Project_Hierarchy_Name");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Project_Hierarchy_ID_in_Name
		{
			get
			{
				return this.include_Project_Hierarchy_ID_in_NameField;
			}
			set
			{
				this.include_Project_Hierarchy_ID_in_NameField = value;
				this.RaisePropertyChanged("Include_Project_Hierarchy_ID_in_Name");
			}
		}

		[XmlIgnore]
		public bool Include_Project_Hierarchy_ID_in_NameSpecified
		{
			get
			{
				return this.include_Project_Hierarchy_ID_in_NameFieldSpecified;
			}
			set
			{
				this.include_Project_Hierarchy_ID_in_NameFieldSpecified = value;
				this.RaisePropertyChanged("Include_Project_Hierarchy_ID_in_NameSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Enable_as_Optional_Hierarchy
		{
			get
			{
				return this.enable_as_Optional_HierarchyField;
			}
			set
			{
				this.enable_as_Optional_HierarchyField = value;
				this.RaisePropertyChanged("Enable_as_Optional_Hierarchy");
			}
		}

		[XmlIgnore]
		public bool Enable_as_Optional_HierarchySpecified
		{
			get
			{
				return this.enable_as_Optional_HierarchyFieldSpecified;
			}
			set
			{
				this.enable_as_Optional_HierarchyFieldSpecified = value;
				this.RaisePropertyChanged("Enable_as_Optional_HierarchySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Document_StatusObjectType Project_Hierarchy_Status_Reference
		{
			get
			{
				return this.project_Hierarchy_Status_ReferenceField;
			}
			set
			{
				this.project_Hierarchy_Status_ReferenceField = value;
				this.RaisePropertyChanged("Project_Hierarchy_Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public Project_HierarchyObjectType Inactivated_By_Hierarchy_Reference
		{
			get
			{
				return this.inactivated_By_Hierarchy_ReferenceField;
			}
			set
			{
				this.inactivated_By_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Inactivated_By_Hierarchy_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public Organization_SubtypeObjectType Organization_Subtype_Reference
		{
			get
			{
				return this.organization_Subtype_ReferenceField;
			}
			set
			{
				this.organization_Subtype_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Subtype_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Project_HierarchyObjectType Parent_Reference
		{
			get
			{
				return this.parent_ReferenceField;
			}
			set
			{
				this.parent_ReferenceField = value;
				this.RaisePropertyChanged("Parent_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public Project_Resource_PlanObjectType Project_Resource_Plan_Reference
		{
			get
			{
				return this.project_Resource_Plan_ReferenceField;
			}
			set
			{
				this.project_Resource_Plan_ReferenceField = value;
				this.RaisePropertyChanged("Project_Resource_Plan_Reference");
			}
		}

		[XmlElement("Project_Scenario_Groups_Reference", Order = 10)]
		public Project_Scenario_GroupObjectType[] Project_Scenario_Groups_Reference
		{
			get
			{
				return this.project_Scenario_Groups_ReferenceField;
			}
			set
			{
				this.project_Scenario_Groups_ReferenceField = value;
				this.RaisePropertyChanged("Project_Scenario_Groups_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public CurrencyObjectType Reporting_Currency_Reference
		{
			get
			{
				return this.reporting_Currency_ReferenceField;
			}
			set
			{
				this.reporting_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Reporting_Currency_Reference");
			}
		}

		[XmlElement("Included_Projects_Reference", Order = 13)]
		public ProjectObjectType[] Included_Projects_Reference
		{
			get
			{
				return this.included_Projects_ReferenceField;
			}
			set
			{
				this.included_Projects_ReferenceField = value;
				this.RaisePropertyChanged("Included_Projects_Reference");
			}
		}

		[XmlElement("Included_Projects_in_Optional_Hierarchy_Reference", Order = 14)]
		public ProjectObjectType[] Included_Projects_in_Optional_Hierarchy_Reference
		{
			get
			{
				return this.included_Projects_in_Optional_Hierarchy_ReferenceField;
			}
			set
			{
				this.included_Projects_in_Optional_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Included_Projects_in_Optional_Hierarchy_Reference");
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
