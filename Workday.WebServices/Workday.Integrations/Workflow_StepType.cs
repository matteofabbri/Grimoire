using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Integrations
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Workflow_StepType : INotifyPropertyChanged
	{
		private Workflow_StepObjectType workflow_Step_ReferenceField;

		private Workflow_Step_Content_DataType[] workflow_Step_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Workflow_StepObjectType Workflow_Step_Reference
		{
			get
			{
				return this.workflow_Step_ReferenceField;
			}
			set
			{
				this.workflow_Step_ReferenceField = value;
				this.RaisePropertyChanged("Workflow_Step_Reference");
			}
		}

		[XmlElement("Workflow_Step_Data", Order = 1)]
		public Workflow_Step_Content_DataType[] Workflow_Step_Data
		{
			get
			{
				return this.workflow_Step_DataField;
			}
			set
			{
				this.workflow_Step_DataField = value;
				this.RaisePropertyChanged("Workflow_Step_Data");
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
