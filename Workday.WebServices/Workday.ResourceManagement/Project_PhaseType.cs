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
	public class Project_PhaseType : INotifyPropertyChanged
	{
		private Project_PhaseObjectType project_Phase_ReferenceField;

		private Project_Phase_DataType[] project_Phase_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_PhaseObjectType Project_Phase_Reference
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

		[XmlElement("Project_Phase_Data", Order = 1)]
		public Project_Phase_DataType[] Project_Phase_Data
		{
			get
			{
				return this.project_Phase_DataField;
			}
			set
			{
				this.project_Phase_DataField = value;
				this.RaisePropertyChanged("Project_Phase_Data");
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
