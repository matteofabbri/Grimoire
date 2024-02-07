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
	public class Project_Plan_Phase_WWS_DataType : INotifyPropertyChanged
	{
		private string project_Plan_Phase_IDField;

		private string orderField;

		private Project_PhaseObjectType phase_ReferenceField;

		private Project_Plan_Task_WWS_DataType[] project_Plan_Task_DataField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Plan_Phase_ID
		{
			get
			{
				return this.project_Plan_Phase_IDField;
			}
			set
			{
				this.project_Plan_Phase_IDField = value;
				this.RaisePropertyChanged("Project_Plan_Phase_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Order
		{
			get
			{
				return this.orderField;
			}
			set
			{
				this.orderField = value;
				this.RaisePropertyChanged("Order");
			}
		}

		[XmlElement(Order = 2)]
		public Project_PhaseObjectType Phase_Reference
		{
			get
			{
				return this.phase_ReferenceField;
			}
			set
			{
				this.phase_ReferenceField = value;
				this.RaisePropertyChanged("Phase_Reference");
			}
		}

		[XmlElement("Project_Plan_Task_Data", Order = 3)]
		public Project_Plan_Task_WWS_DataType[] Project_Plan_Task_Data
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
