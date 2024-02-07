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
	public class Request_for_Quote_Request_ReferencesType : INotifyPropertyChanged
	{
		private Request_for_QuoteObjectType[] request_for_Quote_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Request_for_Quote_Reference", Order = 0)]
		public Request_for_QuoteObjectType[] Request_for_Quote_Reference
		{
			get
			{
				return this.request_for_Quote_ReferenceField;
			}
			set
			{
				this.request_for_Quote_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Reference");
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
