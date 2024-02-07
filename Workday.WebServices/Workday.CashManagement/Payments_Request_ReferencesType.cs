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
	public class Payments_Request_ReferencesType : INotifyPropertyChanged
	{
		private Reporting_TransactionObjectType[] payment_WWS_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payment_WWS_Reference", Order = 0)]
		public Reporting_TransactionObjectType[] Payment_WWS_Reference
		{
			get
			{
				return this.payment_WWS_ReferenceField;
			}
			set
			{
				this.payment_WWS_ReferenceField = value;
				this.RaisePropertyChanged("Payment_WWS_Reference");
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
