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
	public class Project_Task_Resource_Line_DataType : INotifyPropertyChanged
	{
		private string project_Task_Resource_IDField;

		private Project_Plan_TaskObjectType project_Plan_Task_ReferenceField;

		private Project_Resource_Plan_DetailObjectType project_Resource_Plan_Detail_ReferenceField;

		private Project_ResourceObjectType[] project_Resource_ReferenceField;

		private DateTime resource_Start_DateField;

		private bool resource_Start_DateFieldSpecified;

		private DateTime resource_End_DateField;

		private bool resource_End_DateFieldSpecified;

		private decimal percent_AllocationField;

		private bool percent_AllocationFieldSpecified;

		private decimal estimated_HoursField;

		private bool estimated_HoursFieldSpecified;

		private string memoField;

		private bool deleteField;

		private bool deleteFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Task_Resource_ID
		{
			get
			{
				return this.project_Task_Resource_IDField;
			}
			set
			{
				this.project_Task_Resource_IDField = value;
				this.RaisePropertyChanged("Project_Task_Resource_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public Project_Resource_Plan_DetailObjectType Project_Resource_Plan_Detail_Reference
		{
			get
			{
				return this.project_Resource_Plan_Detail_ReferenceField;
			}
			set
			{
				this.project_Resource_Plan_Detail_ReferenceField = value;
				this.RaisePropertyChanged("Project_Resource_Plan_Detail_Reference");
			}
		}

		[XmlElement("Project_Resource_Reference", Order = 3)]
		public Project_ResourceObjectType[] Project_Resource_Reference
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

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Resource_Start_Date
		{
			get
			{
				return this.resource_Start_DateField;
			}
			set
			{
				this.resource_Start_DateField = value;
				this.RaisePropertyChanged("Resource_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Resource_Start_DateSpecified
		{
			get
			{
				return this.resource_Start_DateFieldSpecified;
			}
			set
			{
				this.resource_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Resource_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Resource_End_Date
		{
			get
			{
				return this.resource_End_DateField;
			}
			set
			{
				this.resource_End_DateField = value;
				this.RaisePropertyChanged("Resource_End_Date");
			}
		}

		[XmlIgnore]
		public bool Resource_End_DateSpecified
		{
			get
			{
				return this.resource_End_DateFieldSpecified;
			}
			set
			{
				this.resource_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Resource_End_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Percent_Allocation
		{
			get
			{
				return this.percent_AllocationField;
			}
			set
			{
				this.percent_AllocationField = value;
				this.RaisePropertyChanged("Percent_Allocation");
			}
		}

		[XmlIgnore]
		public bool Percent_AllocationSpecified
		{
			get
			{
				return this.percent_AllocationFieldSpecified;
			}
			set
			{
				this.percent_AllocationFieldSpecified = value;
				this.RaisePropertyChanged("Percent_AllocationSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Estimated_Hours
		{
			get
			{
				return this.estimated_HoursField;
			}
			set
			{
				this.estimated_HoursField = value;
				this.RaisePropertyChanged("Estimated_Hours");
			}
		}

		[XmlIgnore]
		public bool Estimated_HoursSpecified
		{
			get
			{
				return this.estimated_HoursFieldSpecified;
			}
			set
			{
				this.estimated_HoursFieldSpecified = value;
				this.RaisePropertyChanged("Estimated_HoursSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
