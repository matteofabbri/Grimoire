using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Put_Project_Standard_Cost_Rate_Sheet_ResponseType : INotifyPropertyChanged
	{
		private Project_Standard_Cost_Rate_SheetObjectType project_Standard_Cost_Rate_Sheet_ReferenceField;

		private string versionField;

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

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
