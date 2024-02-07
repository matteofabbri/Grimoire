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
	public class Project_Scenario_Request_CriteriaType : INotifyPropertyChanged
	{
		private Project_Scenario_GroupObjectType[] project_Scenario_Groups_ReferenceField;

		private Project_HierarchyObjectType[] project_Hierarchies_ReferenceField;

		private bool include_Only_Primary_Project_ScenariosField;

		private bool include_Only_Primary_Project_ScenariosFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Scenario_Groups_Reference", Order = 0)]
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

		[XmlElement("Project_Hierarchies_Reference", Order = 1)]
		public Project_HierarchyObjectType[] Project_Hierarchies_Reference
		{
			get
			{
				return this.project_Hierarchies_ReferenceField;
			}
			set
			{
				this.project_Hierarchies_ReferenceField = value;
				this.RaisePropertyChanged("Project_Hierarchies_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Only_Primary_Project_Scenarios
		{
			get
			{
				return this.include_Only_Primary_Project_ScenariosField;
			}
			set
			{
				this.include_Only_Primary_Project_ScenariosField = value;
				this.RaisePropertyChanged("Include_Only_Primary_Project_Scenarios");
			}
		}

		[XmlIgnore]
		public bool Include_Only_Primary_Project_ScenariosSpecified
		{
			get
			{
				return this.include_Only_Primary_Project_ScenariosFieldSpecified;
			}
			set
			{
				this.include_Only_Primary_Project_ScenariosFieldSpecified = value;
				this.RaisePropertyChanged("Include_Only_Primary_Project_ScenariosSpecified");
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
