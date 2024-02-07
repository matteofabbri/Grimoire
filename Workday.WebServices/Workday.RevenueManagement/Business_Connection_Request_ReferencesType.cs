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
	public class Business_Connection_Request_ReferencesType : INotifyPropertyChanged
	{
		private Customer_Business_ConnectionObjectType[] business_Connection_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Business_Connection_Reference", Order = 0)]
		public Customer_Business_ConnectionObjectType[] Business_Connection_Reference
		{
			get
			{
				return this.business_Connection_ReferenceField;
			}
			set
			{
				this.business_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Business_Connection_Reference");
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
