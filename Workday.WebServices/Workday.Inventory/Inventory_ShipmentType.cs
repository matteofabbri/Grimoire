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
	public class Inventory_ShipmentType : INotifyPropertyChanged
	{
		private Inventory_Ship_ListObjectType inventory_Shipment_ReferenceField;

		private Inventory_Shipment_DataType[] inventory_Shipment_Data_ElementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Ship_ListObjectType Inventory_Shipment_Reference
		{
			get
			{
				return this.inventory_Shipment_ReferenceField;
			}
			set
			{
				this.inventory_Shipment_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Reference");
			}
		}

		[XmlElement("Inventory_Shipment_Data_Element", Order = 1)]
		public Inventory_Shipment_DataType[] Inventory_Shipment_Data_Element
		{
			get
			{
				return this.inventory_Shipment_Data_ElementField;
			}
			set
			{
				this.inventory_Shipment_Data_ElementField = value;
				this.RaisePropertyChanged("Inventory_Shipment_Data_Element");
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
