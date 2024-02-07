using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Entity_Contact_Request_ReferencesType : INotifyPropertyChanged
	{
		private Business_Entity_ContactObjectType[] business_Entity_Contact_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Entity_Contact_Reference", Order = 0)]
		public Business_Entity_ContactObjectType[] Business_Entity_Contact_Reference
		{
			get
			{
				return this.business_Entity_Contact_ReferenceField;
			}
			set
			{
				this.business_Entity_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Business_Entity_Contact_Reference");
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
