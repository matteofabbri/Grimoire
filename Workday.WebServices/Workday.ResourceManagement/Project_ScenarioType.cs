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
	public class Project_ScenarioType : INotifyPropertyChanged
	{
		private Project_ScenarioObjectType project_Scenario_ReferenceField;

		private Project_Scenario_DataType project_Scenario_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_ScenarioObjectType Project_Scenario_Reference
		{
			get
			{
				return this.project_Scenario_ReferenceField;
			}
			set
			{
				this.project_Scenario_ReferenceField = value;
				this.RaisePropertyChanged("Project_Scenario_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Scenario_DataType Project_Scenario_Data
		{
			get
			{
				return this.project_Scenario_DataField;
			}
			set
			{
				this.project_Scenario_DataField = value;
				this.RaisePropertyChanged("Project_Scenario_Data");
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
