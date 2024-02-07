using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Message_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payment_MessageObjectType[] payment_Message_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payment_Message_Reference", Order = 0)]
		public Payment_MessageObjectType[] Payment_Message_Reference
		{
			get
			{
				return this.payment_Message_ReferenceField;
			}
			set
			{
				this.payment_Message_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Message_Reference");
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
