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
	public class Supplier_Invoice_Request_OutboundType : INotifyPropertyChanged
	{
		private Supplier_Invoice_RequestObjectType supplier_Invoice_Request_ReferenceField;

		private Supplier_Invoice_Request_Data_OutboundType[] supplier_Invoice_Request_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_Invoice_RequestObjectType Supplier_Invoice_Request_Reference
		{
			get
			{
				return this.supplier_Invoice_Request_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Request_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Reference");
			}
		}

		[XmlElement("Supplier_Invoice_Request_Data", Order = 1)]
		public Supplier_Invoice_Request_Data_OutboundType[] Supplier_Invoice_Request_Data
		{
			get
			{
				return this.supplier_Invoice_Request_DataField;
			}
			set
			{
				this.supplier_Invoice_Request_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Data");
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
