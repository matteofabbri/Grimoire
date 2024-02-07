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
	public class ReceiptType : INotifyPropertyChanged
	{
		private ReceiptObjectType receipt_ReferenceField;

		private Receipt_DataType[] receipt_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ReceiptObjectType Receipt_Reference
		{
			get
			{
				return this.receipt_ReferenceField;
			}
			set
			{
				this.receipt_ReferenceField = value;
				this.RaisePropertyChanged("Receipt_Reference");
			}
		}

		[XmlElement("Receipt_Data", Order = 1)]
		public Receipt_DataType[] Receipt_Data
		{
			get
			{
				return this.receipt_DataField;
			}
			set
			{
				this.receipt_DataField = value;
				this.RaisePropertyChanged("Receipt_Data");
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
