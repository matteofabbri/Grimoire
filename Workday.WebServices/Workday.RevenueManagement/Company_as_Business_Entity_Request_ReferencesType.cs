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
	public class Company_as_Business_Entity_Request_ReferencesType : INotifyPropertyChanged
	{
		private Company_as_Business_EntityObjectType[] company_as_Business_Entity_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_as_Business_Entity_Reference", Order = 0)]
		public Company_as_Business_EntityObjectType[] Company_as_Business_Entity_Reference
		{
			get
			{
				return this.company_as_Business_Entity_ReferenceField;
			}
			set
			{
				this.company_as_Business_Entity_ReferenceField = value;
				this.RaisePropertyChanged("Company_as_Business_Entity_Reference");
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
