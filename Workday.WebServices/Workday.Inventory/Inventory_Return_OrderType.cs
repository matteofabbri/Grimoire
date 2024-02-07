using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Return_OrderType : INotifyPropertyChanged
	{
		private Inventory_ReturnObjectType inventory_Return_Order_ReferenceField;

		private Inventory_Return_Order_DataType[] inventory_Return_Order_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_ReturnObjectType Inventory_Return_Order_Reference
		{
			get
			{
				return this.inventory_Return_Order_ReferenceField;
			}
			set
			{
				this.inventory_Return_Order_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Reference");
			}
		}

		[XmlElement("Inventory_Return_Order_Data", Order = 1)]
		public Inventory_Return_Order_DataType[] Inventory_Return_Order_Data
		{
			get
			{
				return this.inventory_Return_Order_DataField;
			}
			set
			{
				this.inventory_Return_Order_DataField = value;
				this.RaisePropertyChanged("Inventory_Return_Order_Data");
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
