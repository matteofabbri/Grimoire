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
	public class Project_Plan_DataType : INotifyPropertyChanged
	{
		private string project_IDField;

		private Project_Plan_TemplateObjectType project_Plan_Template_ReferenceField;

		private Project_Plan_Phase_WWS_DataType[] project_Plan_Phase_DataField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_ID
		{
			get
			{
				return this.project_IDField;
			}
			set
			{
				this.project_IDField = value;
				this.RaisePropertyChanged("Project_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Plan_TemplateObjectType Project_Plan_Template_Reference
		{
			get
			{
				return this.project_Plan_Template_ReferenceField;
			}
			set
			{
				this.project_Plan_Template_ReferenceField = value;
				this.RaisePropertyChanged("Project_Plan_Template_Reference");
			}
		}

		[XmlElement("Project_Plan_Phase_Data", Order = 2)]
		public Project_Plan_Phase_WWS_DataType[] Project_Plan_Phase_Data
		{
			get
			{
				return this.project_Plan_Phase_DataField;
			}
			set
			{
				this.project_Plan_Phase_DataField = value;
				this.RaisePropertyChanged("Project_Plan_Phase_Data");
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
