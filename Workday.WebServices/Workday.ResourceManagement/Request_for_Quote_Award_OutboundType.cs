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
	public class Request_for_Quote_Award_OutboundType : INotifyPropertyChanged
	{
		private Request_for_Quote_AwardObjectType request_for_Quote_Award_ReferenceField;

		private Request_for_Quote_Award_DataType[] request_for_Quote_Award_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Request_for_Quote_AwardObjectType Request_for_Quote_Award_Reference
		{
			get
			{
				return this.request_for_Quote_Award_ReferenceField;
			}
			set
			{
				this.request_for_Quote_Award_ReferenceField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Reference");
			}
		}

		[XmlElement("Request_for_Quote_Award_Data", Order = 1)]
		public Request_for_Quote_Award_DataType[] Request_for_Quote_Award_Data
		{
			get
			{
				return this.request_for_Quote_Award_DataField;
			}
			set
			{
				this.request_for_Quote_Award_DataField = value;
				this.RaisePropertyChanged("Request_for_Quote_Award_Data");
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
