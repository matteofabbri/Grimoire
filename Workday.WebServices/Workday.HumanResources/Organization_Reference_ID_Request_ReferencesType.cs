using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Organization_Reference_ID_Request_ReferencesType : INotifyPropertyChanged
	{
		private OrganizationObjectType[] organization_Reference_ID_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Organization_Reference_ID_Reference", Order = 0)]
		public OrganizationObjectType[] Organization_Reference_ID_Reference
		{
			get
			{
				return this.organization_Reference_ID_ReferenceField;
			}
			set
			{
				this.organization_Reference_ID_ReferenceField = value;
				this.RaisePropertyChanged("Organization_Reference_ID_Reference");
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
