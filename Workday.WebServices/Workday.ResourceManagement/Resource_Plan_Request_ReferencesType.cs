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
	public class Resource_Plan_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_Resource_PlanObjectType[] resource_Plan_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Resource_Plan_Reference", Order = 0)]
		public Project_Resource_PlanObjectType[] Resource_Plan_Reference
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
