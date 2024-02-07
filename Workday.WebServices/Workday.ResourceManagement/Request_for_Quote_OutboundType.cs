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
	public class Request_for_Quote_OutboundType : INotifyPropertyChanged
	{
		private Request_for_QuoteObjectType request_for_Quote_ReferenceField;

		private Request_for_Quote_DataType[] request_for_Quote_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_QuoteObjectType Request_for_Quote_Reference
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

		[XmlElement("Request_for_Quote_Data", Order = 1)]
		public Request_for_Quote_DataType[] Request_for_Quote_Data
		{
			get
			{
				return this.request_for_Quote_DataField;
			}
			set
			{
				this.request_for_Quote_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Data");
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
