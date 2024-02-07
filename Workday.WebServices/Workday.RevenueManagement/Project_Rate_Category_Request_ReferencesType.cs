using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Project_Rate_Category_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_Rate_CategoryObjectType[] project_Rate_Category_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Rate_Category_Reference", Order = 0)]
		public Project_Rate_CategoryObjectType[] Project_Rate_Category_Reference
		{
			get
			{
				return this.project_Rate_Category_ReferenceField;
			}
			set
			{
				this.project_Rate_Category_ReferenceField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Reference");
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
