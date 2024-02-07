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
	public class Resource_Forecast_Line__HV__DataType : INotifyPropertyChanged
	{
		private Resource_Forecast_LineObjectType resource_Forecast_Line_ReferenceField;

		private string resource_Forecast_Line_IDField;

		private Project_ResourceObjectType project_Resource_ReferenceField;

		private Project_RoleObjectType project_Role_ReferenceField;

		private Project_Plan_TaskObjectType task_ReferenceField;

		private Resource_Forecast_Line_Allocation__HV__DataType[] resource_Forecast_Line_Allocation_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Resource_Forecast_LineObjectType Resource_Forecast_Line_Reference
		{
			get
			{
				return this.resource_Forecast_Line_ReferenceField;
			}
			set
			{
				this.resource_Forecast_Line_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Forecast_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Resource_Forecast_Line_ID
		{
			get
			{
				return this.resource_Forecast_Line_IDField;
			}
			set
			{
				this.resource_Forecast_Line_IDField = value;
				this.RaisePropertyChanged("Resource_Forecast_Line_ID");
			}
		}

		[XmlElement(Order = 2)]
		public Project_ResourceObjectType Project_Resource_Reference
		{
			get
			{
				return this.project_Resource_ReferenceField;
			}
			set
			{
				this.project_Resource_ReferenceField = value;
				this.RaisePropertyChanged("Project_Resource_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Project_RoleObjectType Project_Role_Reference
		{
			get
			{
				return this.project_Role_ReferenceField;
			}
			set
			{
				this.project_Role_ReferenceField = value;
				this.RaisePropertyChanged("Project_Role_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Project_Plan_TaskObjectType Task_Reference
		{
			get
			{
				return this.task_ReferenceField;
			}
			set
			{
				this.task_ReferenceField = value;
				this.RaisePropertyChanged("Task_Reference");
			}
		}

		[XmlElement("Resource_Forecast_Line_Allocation_Data", Order = 5)]
		public Resource_Forecast_Line_Allocation__HV__DataType[] Resource_Forecast_Line_Allocation_Data
		{
			get
			{
				return this.resource_Forecast_Line_Allocation_DataField;
			}
			set
			{
				this.resource_Forecast_Line_Allocation_DataField = value;
				this.RaisePropertyChanged("Resource_Forecast_Line_Allocation_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Delete
		{
			get
			{
				return this.deleteField;
			}
			set
			{
				this.deleteField = value;
				this.RaisePropertyChanged("Delete");
			}
		}

		[XmlIgnore]
		public bool DeleteSpecified
		{
			get
			{
				return this.deleteFieldSpecified;
			}
			set
			{
				this.deleteFieldSpecified = value;
				this.RaisePropertyChanged("DeleteSpecified");
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
