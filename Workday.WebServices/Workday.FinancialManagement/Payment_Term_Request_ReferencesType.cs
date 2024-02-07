using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Term_Request_ReferencesType : INotifyPropertyChanged
	{
		private Payment_TermsObjectType[] payment_Term_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Payment_Term_Reference", Order = 0)]
		public Payment_TermsObjectType[] Payment_Term_Reference
		{
			get
			{
				return this.payment_Term_ReferenceField;
			}
			set
			{
				this.payment_Term_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Term_Reference");
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
