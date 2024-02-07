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
	public class Consolidated_Invoice_Request_ReferencesType : INotifyPropertyChanged
	{
		private Consolidated_InvoiceObjectType[] consolidated_Invoice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Consolidated_Invoice_Reference", Order = 0)]
		public Consolidated_InvoiceObjectType[] Consolidated_Invoice_Reference
		{
			get
			{
				return this.consolidated_Invoice_ReferenceField;
			}
			set
			{
				this.consolidated_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Consolidated_Invoice_Reference");
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
