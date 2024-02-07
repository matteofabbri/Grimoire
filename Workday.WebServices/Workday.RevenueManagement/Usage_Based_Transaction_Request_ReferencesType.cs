using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Usage_Based_Transaction_Request_ReferencesType : INotifyPropertyChanged
	{
		private Usage_Based_TransactionObjectType[] usage_Based_Transaction_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Usage_Based_Transaction_Reference", Order = 0)]
		public Usage_Based_TransactionObjectType[] Usage_Based_Transaction_Reference
		{
			get
			{
				return this.usage_Based_Transaction_ReferenceField;
			}
			set
			{
				this.usage_Based_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Usage_Based_Transaction_Reference");
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
