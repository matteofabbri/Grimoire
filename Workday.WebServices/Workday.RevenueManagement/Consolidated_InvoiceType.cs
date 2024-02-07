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
	public class Consolidated_InvoiceType : INotifyPropertyChanged
	{
		private Consolidated_InvoiceObjectType consolidated_Invoice_ReferenceField;

		private Consolidated_Invoice_WWS_DataType[] consolidated_Invoice_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Consolidated_InvoiceObjectType Consolidated_Invoice_Reference
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

		[XmlElement("Consolidated_Invoice_Data", Order = 1)]
		public Consolidated_Invoice_WWS_DataType[] Consolidated_Invoice_Data
		{
			get
			{
				return this.consolidated_Invoice_DataField;
			}
			set
			{
				this.consolidated_Invoice_DataField = value;
				this.RaisePropertyChanged("Consolidated_Invoice_Data");
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
