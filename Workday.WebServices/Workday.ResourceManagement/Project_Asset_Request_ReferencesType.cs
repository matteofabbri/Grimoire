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
	public class Project_Asset_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_AssetObjectType[] project_Asset_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Asset_Reference", Order = 0)]
		public Project_AssetObjectType[] Project_Asset_Reference
		{
			get
			{
				return this.project_Asset_ReferenceField;
			}
			set
			{
				this.project_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Project_Asset_Reference");
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
