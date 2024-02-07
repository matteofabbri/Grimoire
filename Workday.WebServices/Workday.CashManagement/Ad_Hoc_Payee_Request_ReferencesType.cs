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
	public class Ad_Hoc_Payee_Request_ReferencesType : INotifyPropertyChanged
	{
		private Ad_Hoc_PayeeObjectType[] ad_Hoc_Payee_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Ad_Hoc_Payee_Reference", Order = 0)]
		public Ad_Hoc_PayeeObjectType[] Ad_Hoc_Payee_Reference
		{
			get
			{
				return this.ad_Hoc_Payee_ReferenceField;
			}
			set
			{
				this.ad_Hoc_Payee_ReferenceField = value;
				this.RaisePropertyChanged("Ad_Hoc_Payee_Reference");
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
