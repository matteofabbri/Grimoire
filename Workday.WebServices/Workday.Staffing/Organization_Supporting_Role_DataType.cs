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
	public class Organization_Supporting_Role_DataType : INotifyPropertyChanged
	{
		private Assignable_RoleObjectType organization_Role_ReferenceField;

		private Worker_Organization_Role_Assignment_DataType[] organization_Role_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Assignable_RoleObjectType Organization_Role_Reference
		{
			get
			{
				return this.organization_Role_ReferenceField;
			}
			set
			{
				this.organization_Role_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Role_Reference");
			}
		}

		[XmlElement("Organization_Role_Data", Order = 1)]
		public Worker_Organization_Role_Assignment_DataType[] Organization_Role_Data
		{
			get
			{
				return this.organization_Role_DataField;
			}
			set
			{
				this.organization_Role_DataField = value;
				this.RaisePropertyChanged("Organization_Role_Data");
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
