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
	public class Supplier_Invoice_Request_ReferencesType : INotifyPropertyChanged
	{
		private Supplier_InvoiceObjectType[] supplier_Invoice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Supplier_Invoice_Reference", Order = 0)]
		public Supplier_InvoiceObjectType[] Supplier_Invoice_Reference
		{
			get
			{
				return this.supplier_Invoice_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference");
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
