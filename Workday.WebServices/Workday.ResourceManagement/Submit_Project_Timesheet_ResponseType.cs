using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Project_Timesheet_ResponseType : INotifyPropertyChanged
	{
		private Project_TimesheetObjectType project_Timesheet_ReferenceField;

		private Exception_DataType[][] application_Instance_Related_Exceptions_DataField;

		private string versionField;

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

		[XmlArray(Order = 1), XmlArrayItem("Exceptions_Data", typeof(Exception_DataType[]), IsNullable = false), XmlArrayItem("Exception_Data", typeof(Exception_DataType), IsNullable = false, NestingLevel = 1)]
		public Exception_DataType[][] Application_Instance_Related_Exceptions_Data
		{
			get
			{
				return this.application_Instance_Related_Exceptions_DataField;
			}
			set
			{
				this.application_Instance_Related_Exceptions_DataField = value;
				this.RaisePropertyChanged("Application_Instance_Related_Exceptions_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
