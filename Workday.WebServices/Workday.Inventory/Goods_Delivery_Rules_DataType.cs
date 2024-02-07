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
	public class Goods_Delivery_Rules_DataType : INotifyPropertyChanged
	{
		private string goods_Delivery_Rule_Request_IDField;

		private string goods_Delivery_Rule_OrderField;

		private CompanyObjectType company_ReferenceField;

		private Address_ReferenceObjectType[] shipTo_Address_ReferenceField;

		private LocationObjectType[] deliverTo_Location_ReferenceField;

		private Resource_ProviderObjectType[] supplier_ReferenceField;

		private Spend_CategoryObjectType[] spend_Category_ReferenceField;

		private Item_DescriptorObjectType[] item_ReferenceField;

		private Purchase_Item_GroupObjectType[] purchase_Item_Group_ReferenceField;

		private bool do_Not_Create_DeliveryField;

		private bool do_Not_Create_DeliveryFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Goods_Delivery_Rule_Request_ID
		{
			get
			{
				return this.goods_Delivery_Rule_Request_IDField;
			}
			set
			{
				this.goods_Delivery_Rule_Request_IDField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rule_Request_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Goods_Delivery_Rule_Order
		{
			get
			{
				return this.goods_Delivery_Rule_OrderField;
			}
			set
			{
				this.goods_Delivery_Rule_OrderField = value;
				this.RaisePropertyChanged("Goods_Delivery_Rule_Order");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 3)]
		public Address_ReferenceObjectType[] ShipTo_Address_Reference
		{
			get
			{
				return this.shipTo_Address_ReferenceField;
			}
			set
			{
				this.shipTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Address_Reference");
			}
		}

		[XmlElement("Deliver-To_Location_Reference", Order = 4)]
		public LocationObjectType[] DeliverTo_Location_Reference
		{
			get
			{
				return this.deliverTo_Location_ReferenceField;
			}
			set
			{
				this.deliverTo_Location_ReferenceField = value;
				this.RaisePropertyChanged("DeliverTo_Location_Reference");
			}
		}

		[XmlElement("Supplier_Reference", Order = 5)]
		public Resource_ProviderObjectType[] Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement("Spend_Category_Reference", Order = 6)]
		public Spend_CategoryObjectType[] Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement("Item_Reference", Order = 7)]
		public Item_DescriptorObjectType[] Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement("Purchase_Item_Group_Reference", Order = 8)]
		public Purchase_Item_GroupObjectType[] Purchase_Item_Group_Reference
		{
			get
			{
				return this.purchase_Item_Group_ReferenceField;
			}
			set
			{
				this.purchase_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Group_Reference");
			}
		}

		[XmlElement(Order = 9)]
		public bool Do_Not_Create_Delivery
		{
			get
			{
				return this.do_Not_Create_DeliveryField;
			}
			set
			{
				this.do_Not_Create_DeliveryField = value;
				this.RaisePropertyChanged("Do_Not_Create_Delivery");
			}
		}

		[XmlIgnore]
		public bool Do_Not_Create_DeliverySpecified
		{
			get
			{
				return this.do_Not_Create_DeliveryFieldSpecified;
			}
			set
			{
				this.do_Not_Create_DeliveryFieldSpecified = value;
				this.RaisePropertyChanged("Do_Not_Create_DeliverySpecified");
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
