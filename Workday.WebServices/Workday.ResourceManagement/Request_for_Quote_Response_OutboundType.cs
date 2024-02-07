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
	public class Request_for_Quote_Response_OutboundType : INotifyPropertyChanged
	{
		private Request_for_Quote_ResponseObjectType request_for_Quote_Response_ReferenceField;

		private RFQ_Response_DataType[] request_for_Quote_Response_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_ResponseObjectType Request_for_Quote_Response_Reference
		{
			get
			{
				return this.request_for_Quote_Response_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Response_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Response_Reference");
			}
		}

		[XmlElement("Request_for_Quote_Response_Data", Order = 1)]
		public RFQ_Response_DataType[] Request_for_Quote_Response_Data
		{
			get
			{
				return this.request_for_Quote_Response_DataField;
			}
			set
			{
				this.request_for_Quote_Response_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Response_Data");
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
