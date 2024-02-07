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
	public class Credit_Card_Authorization_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] credit_Card_Authorization_Request_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Credit_Card_Authorization_Request_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Credit_Card_Authorization_Request_Reference
		{
			get
			{
				return this.credit_Card_Authorization_Request_ReferenceField;
			}
			set
			{
				this.credit_Card_Authorization_Request_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_Request_Reference");
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
