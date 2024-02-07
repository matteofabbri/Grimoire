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
	public class Project_Worker_Role_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_RoleObjectType[] project_Worker_Role_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Worker_Role_Reference", Order = 0)]
		public Project_RoleObjectType[] Project_Worker_Role_Reference
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
