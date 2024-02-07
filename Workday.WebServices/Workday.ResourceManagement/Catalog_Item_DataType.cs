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
	public class Catalog_Item_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string item_IdentifierField;

		private string item_NameField;

		private string item_DescriptionField;

		private decimal catalog_Item_current_Unit_PriceField;

		private bool catalog_Item_current_Unit_PriceFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Abstract_Procurement_CatalogObjectType supplier_Catalog_ReferenceField;

		private string item_URLField;

		private Supplier_ContractObjectType supplier_Order_Contract_ReferenceField;

		private bool is_Catalog_Item_currently_ActiveField;

		private bool is_Catalog_Item_currently_ActiveFieldSpecified;

		private Catalog_Item_Data_DataType[] catalog_Item_Data_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Item_Identifier
		{
			get
			{
				return this.item_IdentifierField;
			}
			set
			{
				this.item_IdentifierField = value;
				this.RaisePropertyChanged("Item_Identifier");
			}
		}

		[XmlElement(Order = 2)]
		public string Item_Name
		{
			get
			{
				return this.item_NameField;
			}
			set
			{
				this.item_NameField = value;
				this.RaisePropertyChanged("Item_Name");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Catalog_Item_current_Unit_Price
		{
			get
			{
				return this.catalog_Item_current_Unit_PriceField;
			}
			set
			{
				this.catalog_Item_current_Unit_PriceField = value;
				this.RaisePropertyChanged("Catalog_Item_current_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Catalog_Item_current_Unit_PriceSpecified
		{
			get
			{
				return this.catalog_Item_current_Unit_PriceFieldSpecified;
			}
			set
			{
				this.catalog_Item_current_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Catalog_Item_current_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Spend_CategoryObjectType Spend_Category_Reference
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

		[XmlElement(Order = 7)]
		public Abstract_Procurement_CatalogObjectType Supplier_Catalog_Reference
		{
			get
			{
				return this.supplier_Catalog_ReferenceField;
			}
			set
			{
				this.supplier_Catalog_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Catalog_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Item_URL
		{
			get
			{
				return this.item_URLField;
			}
			set
			{
				this.item_URLField = value;
				this.RaisePropertyChanged("Item_URL");
			}
		}

		[XmlElement(Order = 9)]
		public Supplier_ContractObjectType Supplier_Order_Contract_Reference
		{
			get
			{
				return this.supplier_Order_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Order_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Order_Contract_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Is_Catalog_Item_currently_Active
		{
			get
			{
				return this.is_Catalog_Item_currently_ActiveField;
			}
			set
			{
				this.is_Catalog_Item_currently_ActiveField = value;
				this.RaisePropertyChanged("Is_Catalog_Item_currently_Active");
			}
		}

		[XmlIgnore]
		public bool Is_Catalog_Item_currently_ActiveSpecified
		{
			get
			{
				return this.is_Catalog_Item_currently_ActiveFieldSpecified;
			}
			set
			{
				this.is_Catalog_Item_currently_ActiveFieldSpecified = value;
				this.RaisePropertyChanged("Is_Catalog_Item_currently_ActiveSpecified");
			}
		}

		[XmlElement("Catalog_Item_Data_Data", Order = 11)]
		public Catalog_Item_Data_DataType[] Catalog_Item_Data_Data
		{
			get
			{
				return this.catalog_Item_Data_DataField;
			}
			set
			{
				this.catalog_Item_Data_DataField = value;
				this.RaisePropertyChanged("Catalog_Item_Data_Data");
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
