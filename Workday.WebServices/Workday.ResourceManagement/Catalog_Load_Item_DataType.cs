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
	public class Catalog_Load_Item_DataType : INotifyPropertyChanged
	{
		private string catalog_Item_IDField;

		private string item_IdentifierField;

		private string item_NameField;

		private string item_DescriptionField;

		private decimal item_Unit_PriceField;

		private bool item_Unit_PriceFieldSpecified;

		private string item_URLField;

		private object itemField;

		private decimal lead_TimeField;

		private bool lead_TimeFieldSpecified;

		private object item1Field;

		private Catalog_Load_Alternate_Item_IdentifierType[] alternate_Item_IdentifiersField;

		private Purchase_ItemObjectType purchase_Item_ReferenceField;

		private decimal conversion_FactorField;

		private bool conversion_FactorFieldSpecified;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Catalog_Item_ID
		{
			get
			{
				return this.catalog_Item_IDField;
			}
			set
			{
				this.catalog_Item_IDField = value;
				this.RaisePropertyChanged("Catalog_Item_ID");
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
		public decimal Item_Unit_Price
		{
			get
			{
				return this.item_Unit_PriceField;
			}
			set
			{
				this.item_Unit_PriceField = value;
				this.RaisePropertyChanged("Item_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Item_Unit_PriceSpecified
		{
			get
			{
				return this.item_Unit_PriceFieldSpecified;
			}
			set
			{
				this.item_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Item_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement("UN_CEFACT_UOM_Code", typeof(string), Order = 6), XmlElement("Unit_of_Measure_Code_Reference", typeof(Unit_of_MeasureObjectType), Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Lead_Time
		{
			get
			{
				return this.lead_TimeField;
			}
			set
			{
				this.lead_TimeField = value;
				this.RaisePropertyChanged("Lead_Time");
			}
		}

		[XmlIgnore]
		public bool Lead_TimeSpecified
		{
			get
			{
				return this.lead_TimeFieldSpecified;
			}
			set
			{
				this.lead_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Lead_TimeSpecified");
			}
		}

		[XmlElement("Spend_Category_Reference", typeof(Spend_CategoryObjectType), Order = 8), XmlElement("UNSPSC_Code", typeof(decimal), Order = 8)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement("Alternate_Item_Identifiers", Order = 9)]
		public Catalog_Load_Alternate_Item_IdentifierType[] Alternate_Item_Identifiers
		{
			get
			{
				return this.alternate_Item_IdentifiersField;
			}
			set
			{
				this.alternate_Item_IdentifiersField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifiers");
			}
		}

		[XmlElement(Order = 10)]
		public Purchase_ItemObjectType Purchase_Item_Reference
		{
			get
			{
				return this.purchase_Item_ReferenceField;
			}
			set
			{
				this.purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Conversion_Factor
		{
			get
			{
				return this.conversion_FactorField;
			}
			set
			{
				this.conversion_FactorField = value;
				this.RaisePropertyChanged("Conversion_Factor");
			}
		}

		[XmlIgnore]
		public bool Conversion_FactorSpecified
		{
			get
			{
				return this.conversion_FactorFieldSpecified;
			}
			set
			{
				this.conversion_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Conversion_FactorSpecified");
			}
		}

		[XmlElement("Item_Tag_Reference", Order = 12)]
		public Item_TagObjectType[] Item_Tag_Reference
		{
			get
			{
				return this.item_Tag_ReferenceField;
			}
			set
			{
				this.item_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Item_Tag_Reference");
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
