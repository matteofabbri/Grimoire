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
	public class Project_Phase_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_PhaseObjectType[] project_Phase_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Phase_Reference", Order = 0)]
		public Project_PhaseObjectType[] Project_Phase_Reference
		{
			get
			{
				return this.project_Phase_ReferenceField;
			}
			set
			{
				this.project_Phase_ReferenceField = value;
				this.RaisePropertyChanged("Project_Phase_Reference");
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
