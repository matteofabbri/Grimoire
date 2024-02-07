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
	public class Catalog_Item_Request_CriteriaType : INotifyPropertyChanged
	{
		private string catalog_Item_IdentifierField;

		private object[] itemsField;

		private Supplier_CatalogObjectType[] supplier_Catalogs_for_Catalog_Items_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Catalog_Item_Identifier
		{
			get
			{
				return this.catalog_Item_IdentifierField;
			}
			set
			{
				this.catalog_Item_IdentifierField = value;
				this.RaisePropertyChanged("Catalog_Item_Identifier");
			}
		}

		[XmlElement("Catalog_Item_Supplier_Order_Contract_Reference", typeof(Supplier_ContractObjectType), Order = 1), XmlElement("Company_or_Company_Hierarchy_for_Supplier_Order_Contract_Reference", typeof(OrganizationObjectType), Order = 1), XmlElement("Resource_Provider_for_Supplier_Order_Contract_Reference", typeof(Resource_ProviderObjectType), Order = 1)]
		public object[] Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
				this.RaisePropertyChanged("Items");
			}
		}

		[XmlElement("Supplier_Catalogs_for_Catalog_Items_Reference", Order = 2)]
		public Supplier_CatalogObjectType[] Supplier_Catalogs_for_Catalog_Items_Reference
		{
			get
			{
				return this.supplier_Catalogs_for_Catalog_Items_ReferenceField;
			}
			set
			{
				this.supplier_Catalogs_for_Catalog_Items_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Catalogs_for_Catalog_Items_Reference");
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
