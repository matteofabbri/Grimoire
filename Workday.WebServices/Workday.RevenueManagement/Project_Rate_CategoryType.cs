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
	public class Project_Rate_CategoryType : INotifyPropertyChanged
	{
		private Project_Rate_CategoryObjectType project_Rate_Category_ReferenceField;

		private Project_Rate_Category_DataType project_Rate_Category_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_Rate_CategoryObjectType Project_Rate_Category_Reference
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

		[XmlElement(Order = 1)]
		public Project_Rate_Category_DataType Project_Rate_Category_Data
		{
			get
			{
				return this.project_Rate_Category_DataField;
			}
			set
			{
				this.project_Rate_Category_DataField = value;
				this.RaisePropertyChanged("Project_Rate_Category_Data");
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
