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
	public class Project_Billing_Rate_Sheet_Request_ReferencesType : INotifyPropertyChanged
	{
		private Project_Billing_Rate_SheetObjectType[] project_Billing_Rate_Sheet_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Project_Billing_Rate_Sheet_Reference", Order = 0)]
		public Project_Billing_Rate_SheetObjectType[] Project_Billing_Rate_Sheet_Reference
		{
			get
			{
				return this.project_Billing_Rate_Sheet_ReferenceField;
			}
			set
			{
				this.project_Billing_Rate_Sheet_ReferenceField = value;
				this.RaisePropertyChanged("Project_Billing_Rate_Sheet_Reference");
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
