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
	public class Item_Receipt_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private Purchase_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private Supplier_Contract_Item_LineObjectType supplier_Contract_Line_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Delivery_TypeObjectType delivery_Type_ReferenceField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private LocationObjectType deliver_To_ReferenceField;

		private string memoField;

		private Item_Receipt_Line_Split_DataType[] item_Receipt_Line_Split_DataField;

		private Item_Receipt_Line_Replacement_Lot_DataType[] item_Receipt_Line_Replacement_Lot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_Order_LineObjectType Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Supplier_Contract_Item_LineObjectType Supplier_Contract_Line_Reference
		{
			get
			{
				return this.supplier_Contract_Line_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Delivery_TypeObjectType Delivery_Type_Reference
		{
			get
			{
				return this.delivery_Type_ReferenceField;
			}
			set
			{
				this.delivery_Type_ReferenceField = value;
				this.RaisePropertyChanged("Delivery_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public LocationObjectType Deliver_To_Reference
		{
			get
			{
				return this.deliver_To_ReferenceField;
			}
			set
			{
				this.deliver_To_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Reference");
			}
		}

		[XmlElement(Order = 7)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement("Item_Receipt_Line_Split_Data", Order = 8)]
		public Item_Receipt_Line_Split_DataType[] Item_Receipt_Line_Split_Data
		{
			get
			{
				return this.item_Receipt_Line_Split_DataField;
			}
			set
			{
				this.item_Receipt_Line_Split_DataField = value;
				this.RaisePropertyChanged("Item_Receipt_Line_Split_Data");
			}
		}

		[XmlElement("Item_Receipt_Line_Replacement_Lot_Data", Order = 9)]
		public Item_Receipt_Line_Replacement_Lot_DataType[] Item_Receipt_Line_Replacement_Lot_Data
		{
			get
			{
				return this.item_Receipt_Line_Replacement_Lot_DataField;
			}
			set
			{
				this.item_Receipt_Line_Replacement_Lot_DataField = value;
				this.RaisePropertyChanged("Item_Receipt_Line_Replacement_Lot_Data");
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
