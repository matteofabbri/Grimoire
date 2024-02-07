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
	public class Supplier_Invoice_AdjustmentType : INotifyPropertyChanged
	{
		private Supplier_Invoice_AdjustmentObjectType supplier_Invoice_Adjustment_ReferenceField;

		private Supplier_Invoice_Adjustment_DataType[] supplier_Invoice_Adjustment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_Invoice_AdjustmentObjectType Supplier_Invoice_Adjustment_Reference
		{
			get
			{
				return this.supplier_Invoice_Adjustment_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Adjustment_Reference");
			}
		}

		[XmlElement("Supplier_Invoice_Adjustment_Data", Order = 1)]
		public Supplier_Invoice_Adjustment_DataType[] Supplier_Invoice_Adjustment_Data
		{
			get
			{
				return this.supplier_Invoice_Adjustment_DataField;
			}
			set
			{
				this.supplier_Invoice_Adjustment_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Adjustment_Data");
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
