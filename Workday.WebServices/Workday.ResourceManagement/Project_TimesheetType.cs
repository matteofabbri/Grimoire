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
	public class Project_TimesheetType : INotifyPropertyChanged
	{
		private Project_TimesheetObjectType project_Timesheet_ReferenceField;

		private Project_Timesheet_DataType[] project_Timesheet_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_TimesheetObjectType Project_Timesheet_Reference
		{
			get
			{
				return this.project_Timesheet_ReferenceField;
			}
			set
			{
				this.project_Timesheet_ReferenceField = value;
				this.RaisePropertyChanged("Project_Timesheet_Reference");
			}
		}

		[XmlElement("Project_Timesheet_Data", Order = 1)]
		public Project_Timesheet_DataType[] Project_Timesheet_Data
		{
			get
			{
				return this.project_Timesheet_DataField;
			}
			set
			{
				this.project_Timesheet_DataField = value;
				this.RaisePropertyChanged("Project_Timesheet_Data");
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
