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
	public class Project_TaskType : INotifyPropertyChanged
	{
		private Project_TaskObjectType project_Task_ReferenceField;

		private Project_Task_DataType[] project_Task_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_TaskObjectType Project_Task_Reference
		{
			get
			{
				return this.project_Task_ReferenceField;
			}
			set
			{
				this.project_Task_ReferenceField = value;
				this.RaisePropertyChanged("Project_Task_Reference");
			}
		}

		[XmlElement("Project_Task_Data", Order = 1)]
		public Project_Task_DataType[] Project_Task_Data
		{
			get
			{
				return this.project_Task_DataField;
			}
			set
			{
				this.project_Task_DataField = value;
				this.RaisePropertyChanged("Project_Task_Data");
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
