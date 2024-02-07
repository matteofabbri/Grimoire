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
	public class Purchase_Order_Line_for_Issue_Purchase_Order_Outbound_Sub_ViewType : INotifyPropertyChanged
	{
		private bool purchase_Order_Line_CanceledField;

		private bool purchase_Order_Line_CanceledFieldSpecified;

		private string sKUField;

		private string aux_SKUField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private string unit_of_Measure_CodeField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private Spend_CategoryObjectType resource_Category_ReferenceField;

		private Ship_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType ship_ToField;

		private Ship_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType ship_To_ContactField;

		private LocationObjectType deliver_To_Location_ReferenceField;

		private string memoField;

		private string item_DescriptionField;

		private decimal uNSPSC_CodeField;

		private bool uNSPSC_CodeFieldSpecified;

		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private LocationObjectType storage_Location_ReferenceField;

		private Alternate_Item_Identifier_for_PO_issue_DataType[] alternate_Item_IdentifierField;

		private Cart_Line_Extrinsic_Name_and_ValueType[] cart_Line_ExtrinsicField;

		private bool is_AdhocField;

		private bool is_AdhocFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Purchase_Order_Line_Canceled
		{
			get
			{
				return this.purchase_Order_Line_CanceledField;
			}
			set
			{
				this.purchase_Order_Line_CanceledField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Canceled");
			}
		}

		[XmlIgnore]
		public bool Purchase_Order_Line_CanceledSpecified
		{
			get
			{
				return this.purchase_Order_Line_CanceledFieldSpecified;
			}
			set
			{
				this.purchase_Order_Line_CanceledFieldSpecified = value;
				this.RaisePropertyChanged("Purchase_Order_Line_CanceledSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string SKU
		{
			get
			{
				return this.sKUField;
			}
			set
			{
				this.sKUField = value;
				this.RaisePropertyChanged("SKU");
			}
		}

		[XmlElement(Order = 2)]
		public string Aux_SKU
		{
			get
			{
				return this.aux_SKUField;
			}
			set
			{
				this.aux_SKUField = value;
				this.RaisePropertyChanged("Aux_SKU");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public string Unit_of_Measure_Code
		{
			get
			{
				return this.unit_of_Measure_CodeField;
			}
			set
			{
				this.unit_of_Measure_CodeField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Code");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public Spend_CategoryObjectType Resource_Category_Reference
		{
			get
			{
				return this.resource_Category_ReferenceField;
			}
			set
			{
				this.resource_Category_ReferenceField = value;
				this.RaisePropertyChanged("Resource_Category_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public Ship_To_Address_for_Issue_Purchase_Order_Outbound_Sub_ViewType Ship_To
		{
			get
			{
				return this.ship_ToField;
			}
			set
			{
				this.ship_ToField = value;
				this.RaisePropertyChanged("Ship_To");
			}
		}

		[XmlElement(Order = 9)]
		public Ship_To_Contact_Info_for_Issue_Purchase_Order_Outbound_Sub_ViewType Ship_To_Contact
		{
			get
			{
				return this.ship_To_ContactField;
			}
			set
			{
				this.ship_To_ContactField = value;
				this.RaisePropertyChanged("Ship_To_Contact");
			}
		}

		[XmlElement(Order = 10)]
		public LocationObjectType Deliver_To_Location_Reference
		{
			get
			{
				return this.deliver_To_Location_ReferenceField;
			}
			set
			{
				this.deliver_To_Location_ReferenceField = value;
				this.RaisePropertyChanged("Deliver_To_Location_Reference");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 13)]
		public decimal UNSPSC_Code
		{
			get
			{
				return this.uNSPSC_CodeField;
			}
			set
			{
				this.uNSPSC_CodeField = value;
				this.RaisePropertyChanged("UNSPSC_Code");
			}
		}

		[XmlIgnore]
		public bool UNSPSC_CodeSpecified
		{
			get
			{
				return this.uNSPSC_CodeFieldSpecified;
			}
			set
			{
				this.uNSPSC_CodeFieldSpecified = value;
				this.RaisePropertyChanged("UNSPSC_CodeSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public LocationObjectType Storage_Location_Reference
		{
			get
			{
				return this.storage_Location_ReferenceField;
			}
			set
			{
				this.storage_Location_ReferenceField = value;
				this.RaisePropertyChanged("Storage_Location_Reference");
			}
		}

		[XmlElement("Alternate_Item_Identifier", Order = 16)]
		public Alternate_Item_Identifier_for_PO_issue_DataType[] Alternate_Item_Identifier
		{
			get
			{
				return this.alternate_Item_IdentifierField;
			}
			set
			{
				this.alternate_Item_IdentifierField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifier");
			}
		}

		[XmlElement("Cart_Line_Extrinsic", Order = 17)]
		public Cart_Line_Extrinsic_Name_and_ValueType[] Cart_Line_Extrinsic
		{
			get
			{
				return this.cart_Line_ExtrinsicField;
			}
			set
			{
				this.cart_Line_ExtrinsicField = value;
				this.RaisePropertyChanged("Cart_Line_Extrinsic");
			}
		}

		[XmlElement(Order = 18)]
		public bool Is_Adhoc
		{
			get
			{
				return this.is_AdhocField;
			}
			set
			{
				this.is_AdhocField = value;
				this.RaisePropertyChanged("Is_Adhoc");
			}
		}

		[XmlIgnore]
		public bool Is_AdhocSpecified
		{
			get
			{
				return this.is_AdhocFieldSpecified;
			}
			set
			{
				this.is_AdhocFieldSpecified = value;
				this.RaisePropertyChanged("Is_AdhocSpecified");
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
