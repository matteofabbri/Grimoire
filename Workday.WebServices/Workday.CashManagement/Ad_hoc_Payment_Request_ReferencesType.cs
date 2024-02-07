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
	public class Ad_hoc_Payment_Request_ReferencesType : INotifyPropertyChanged
	{
		private Ad_Hoc_PaymentObjectType[] ad_hoc_Payment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Ad_hoc_Payment_Reference", Order = 0)]
		public Ad_Hoc_PaymentObjectType[] Ad_hoc_Payment_Reference
		{
			get
			{
				return this.ad_hoc_Payment_ReferenceField;
			}
			set
			{
				this.ad_hoc_Payment_ReferenceField = value;
				this.RaisePropertyChanged("Ad_hoc_Payment_Reference");
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
