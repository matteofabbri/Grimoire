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
	public class Project_Worker_RoleType : INotifyPropertyChanged
	{
		private Project_RoleObjectType project_Worker_Role_ReferenceField;

		private Project_Worker_Role_DataType project_Worker_Role_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_RoleObjectType Project_Worker_Role_Reference
		{
			get
			{
				return this.project_Worker_Role_ReferenceField;
			}
			set
			{
				this.project_Worker_Role_ReferenceField = value;
				this.RaisePropertyChanged("Project_Worker_Role_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Project_Worker_Role_DataType Project_Worker_Role_Data
		{
			get
			{
				return this.project_Worker_Role_DataField;
			}
			set
			{
				this.project_Worker_Role_DataField = value;
				this.RaisePropertyChanged("Project_Worker_Role_Data");
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
