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
	public class Project_Plan_Task_PO_DataType : INotifyPropertyChanged
	{
		private Project_Plan_TaskObjectType project_Plan_Task_ReferenceField;

		private Project_Subtask_DataType[] project_Subtask_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_Plan_TaskObjectType Project_Plan_Task_Reference
		{
			get
			{
				return this.project_Plan_Task_ReferenceField;
			}
			set
			{
				this.project_Plan_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Task_Reference");
			}
		}

		[XmlElement("Project_Subtask_Data", Order = 1)]
		public Project_Subtask_DataType[] Project_Subtask_Data
		{
			get
			{
				return this.project_Subtask_DataField;
			}
			set
			{
				this.project_Subtask_DataField = value;
				this.RaisePropertyChanged("Project_Subtask_Data");
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
