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
	public class Project_Standard_Cost_Rate_SheetType : INotifyPropertyChanged
	{
		private Project_Standard_Cost_Rate_SheetObjectType project_Standard_Cost_Rate_Sheet_ReferenceField;

		private Project_Standard_Cost_Rate_Sheet_DataType[] project_Standard_Cost_Rate_Sheet_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Project_Standard_Cost_Rate_SheetObjectType Project_Standard_Cost_Rate_Sheet_Reference
		{
			get
			{
				return this.project_Standard_Cost_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.project_Standard_Cost_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Project_Standard_Cost_Rate_Sheet_Reference");
			}
		}

		[XmlElement("Project_Standard_Cost_Rate_Sheet_Data", Order = 1)]
		public Project_Standard_Cost_Rate_Sheet_DataType[] Project_Standard_Cost_Rate_Sheet_Data
		{
			get
			{
				return this.project_Standard_Cost_Rate_Sheet_DataField;
			}
			set
			{
				this.project_Standard_Cost_Rate_Sheet_DataField = value;
				this.RaisePropertyChanged("Project_Standard_Cost_Rate_Sheet_Data");
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
