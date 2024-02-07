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
	public class Supplier_Invoice_ScheduleType : INotifyPropertyChanged
	{
		private Supplier_Invoice_ScheduleObjectType supplier_Invoice_Schedule_ReferenceField;

		private Supplier_Invoice_Schedule_DataType[] supplier_Invoice_Schedule_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Supplier_Invoice_ScheduleObjectType Supplier_Invoice_Schedule_Reference
		{
			get
			{
				return this.supplier_Invoice_Schedule_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Schedule_Reference");
			}
		}

		[XmlElement("Supplier_Invoice_Schedule_Data", Order = 1)]
		public Supplier_Invoice_Schedule_DataType[] Supplier_Invoice_Schedule_Data
		{
			get
			{
				return this.supplier_Invoice_Schedule_DataField;
			}
			set
			{
				this.supplier_Invoice_Schedule_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Schedule_Data");
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
