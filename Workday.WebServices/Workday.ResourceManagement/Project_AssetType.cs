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
	public class Project_AssetType : INotifyPropertyChanged
	{
		private Project_AssetObjectType project_Asset_ReferenceField;

		private Project_Asset_DataType project_Asset_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_AssetObjectType Project_Asset_Reference
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

		[XmlElement(Order = 1)]
		public Project_Asset_DataType Project_Asset_Data
		{
			get
			{
				return this.project_Asset_DataField;
			}
			set
			{
				this.project_Asset_DataField = value;
				this.RaisePropertyChanged("Project_Asset_Data");
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
