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
	public class Project_Worker_Role_DataType : INotifyPropertyChanged
	{
		private string project_Worker_Role_IDField;

		private string nameField;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Project_Resource_Requirement_Parameter_DataType[] project_Resource_Requirement_Parameter_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Project_Worker_Role_ID
		{
			get
			{
				return this.project_Worker_Role_IDField;
			}
			set
			{
				this.project_Worker_Role_IDField = value;
				this.RaisePropertyChanged("Project_Worker_Role_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement("Project_Resource_Requirement_Parameter_Data", Order = 4)]
		public Project_Resource_Requirement_Parameter_DataType[] Project_Resource_Requirement_Parameter_Data
		{
			get
			{
				return this.project_Resource_Requirement_Parameter_DataField;
			}
			set
			{
				this.project_Resource_Requirement_Parameter_DataField = value;
				this.RaisePropertyChanged("Project_Resource_Requirement_Parameter_Data");
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
