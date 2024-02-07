using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(TypeName = "Inventory_Put-Away_DataType", Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_PutAway_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Site_ReferenceField;

		private object itemField;

		private Inventory_Return_Order_Line_Data_for_Put_AwayType[] inventory_Return_Line_DataField;

		private Inventory_Shipment_Line_Data_for_Put_AwayType[] shipment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement("Inventory_Return_Reference", typeof(Inventory_ReturnObjectType), Order = 1), XmlElement("Receipt_Reference", typeof(ReceiptObjectType), Order = 1), XmlElement("Shipment_Reference", typeof(Inventory_Ship_ListObjectType), Order = 1)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement("Inventory_Return_Line_Data", Order = 2)]
		public Inventory_Return_Order_Line_Data_for_Put_AwayType[] Inventory_Return_Line_Data
		{
			get
			{
				return this.inventory_Return_Line_DataField;
			}
			set
			{
				this.inventory_Return_Line_DataField = value;
				this.RaisePropertyChanged("Inventory_Return_Line_Data");
			}
		}

		[XmlElement("Shipment_Line_Data", Order = 3)]
		public Inventory_Shipment_Line_Data_for_Put_AwayType[] Shipment_Line_Data
		{
			get
			{
				return this.shipment_Line_DataField;
			}
			set
			{
				this.shipment_Line_DataField = value;
				this.RaisePropertyChanged("Shipment_Line_Data");
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
