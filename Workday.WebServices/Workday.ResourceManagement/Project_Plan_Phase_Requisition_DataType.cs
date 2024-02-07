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
	public class Project_Plan_Phase_Requisition_DataType : INotifyPropertyChanged
	{
		private Project_Plan_PhaseObjectType project_Plan_Phase_ReferenceField;

		private Project_Plan_Task_Requisition_DataType[] project_Plan_Task_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_Plan_PhaseObjectType Project_Plan_Phase_Reference
		{
			get
			{
				return this.project_Plan_Phase_ReferenceField;
			}
			set
			{
				this.project_Plan_Phase_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Phase_Reference");
			}
		}

		[XmlElement("Project_Plan_Task_Data", Order = 1)]
		public Project_Plan_Task_Requisition_DataType[] Project_Plan_Task_Data
		{
			get
			{
				return this.project_Plan_Task_DataField;
			}
			set
			{
				this.project_Plan_Task_DataField = value;
				this.RaisePropertyChanged("Project_Plan_Task_Data");
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
