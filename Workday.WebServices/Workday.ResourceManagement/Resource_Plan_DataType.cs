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
	public class Resource_Plan_DataType : INotifyPropertyChanged
	{
		private string resource_Plan_IDField;

		private Project_Resource_Plan_TemplateObjectType resource_Plan_Template_ReferenceField;

		private object itemField;

		private Project_Resource_Plan_Detail_WWS_DataType[] project_Resource_Plan_Detail_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Resource_Plan_ID
		{
			get
			{
				return this.resource_Plan_IDField;
			}
			set
			{
				this.resource_Plan_IDField = value;
				this.RaisePropertyChanged("Resource_Plan_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Resource_Plan_TemplateObjectType Resource_Plan_Template_Reference
		{
			get
			{
				return this.resource_Plan_Template_ReferenceField;
			}
			set
			{
				this.resource_Plan_Template_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Plan_Template_Reference");
			}
		}

		[XmlElement("Project_Hierarchy_Reference", typeof(Project_HierarchyObjectType), Order = 2), XmlElement("Project_Reference", typeof(Project_AbstractObjectType), Order = 2)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Project_Resource_Plan_Detail_Data", Order = 3)]
		public Project_Resource_Plan_Detail_WWS_DataType[] Project_Resource_Plan_Detail_Data
		{
			get
			{
				return this.project_Resource_Plan_Detail_DataField;
			}
			set
			{
				this.project_Resource_Plan_Detail_DataField = value;
				this.RaisePropertyChanged("Project_Resource_Plan_Detail_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace_All
		{
			get
			{
				return this.replace_AllField;
			}
			set
			{
				this.replace_AllField = value;
				this.RaisePropertyChanged("Replace_All");
			}
		}

		[XmlIgnore]
		public bool Replace_AllSpecified
		{
			get
			{
				return this.replace_AllFieldSpecified;
			}
			set
			{
				this.replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Replace_AllSpecified");
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
