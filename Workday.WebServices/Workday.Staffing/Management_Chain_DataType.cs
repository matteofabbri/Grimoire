using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Management_Chain_DataType : INotifyPropertyChanged
	{
		private OrganizationObjectType organization_ReferenceField;

		private WorkerObjectType[] manager_ReferenceField;

		private Worker_Basic_DataType[] managerField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public OrganizationObjectType Organization_Reference
		{
			get
			{
				return this.organization_ReferenceField;
			}
			set
			{
				this.organization_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference");
			}
		}

		[XmlElement("Manager_Reference", Order = 1)]
		public WorkerObjectType[] Manager_Reference
		{
			get
			{
				return this.manager_ReferenceField;
			}
			set
			{
				this.manager_ReferenceField = value;
				this.RaisePropertyChanged("Manager_Reference");
			}
		}

		[XmlElement("Manager", Order = 2)]
		public Worker_Basic_DataType[] Manager
		{
			get
			{
				return this.managerField;
			}
			set
			{
				this.managerField = value;
				this.RaisePropertyChanged("Manager");
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
