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
	public class Payment_Message_WWSType : INotifyPropertyChanged
	{
		private Payment_MessageObjectType payment_Message_ReferenceField;

		private Payment_Message_WWS_DataType[] payment_Message_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Payment_MessageObjectType Payment_Message_Reference
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

		[XmlElement("Payment_Message_Data", Order = 1)]
		public Payment_Message_WWS_DataType[] Payment_Message_Data
		{
			get
			{
				return this.payment_Message_DataField;
			}
			set
			{
				this.payment_Message_DataField = value;
				this.RaisePropertyChanged("Payment_Message_Data");
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
