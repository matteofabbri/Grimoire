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
	public class Resource_Plan_for_RequirementsType : INotifyPropertyChanged
	{
		private Project_Resource_PlanObjectType resource_Plan_ReferenceField;

		private Resource_Plan_Requirement_DataType[] resource_Plan_Requirement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement("Resource_Plan_Requirement_Data", Order = 1)]
		public Resource_Plan_Requirement_DataType[] Resource_Plan_Requirement_Data
		{
			get
			{
				return this.resource_Plan_Requirement_DataField;
			}
			set
			{
				this.resource_Plan_Requirement_DataField = value;
				this.RaisePropertyChanged("Resource_Plan_Requirement_Data");
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
