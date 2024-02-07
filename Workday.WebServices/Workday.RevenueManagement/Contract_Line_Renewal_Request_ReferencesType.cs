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
	public class Contract_Line_Renewal_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] contract_Line_Renewal_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Contract_Line_Renewal_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Contract_Line_Renewal_Reference
		{
			get
			{
				return this.contract_Line_Renewal_ReferenceField;
			}
			set
			{
				this.contract_Line_Renewal_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Renewal_Reference");
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
