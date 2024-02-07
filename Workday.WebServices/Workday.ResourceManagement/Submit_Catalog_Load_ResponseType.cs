using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_Catalog_Load_ResponseType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType catalog_Load_ReferenceField;

		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Abstract_Procurement_CatalogObjectType supplier_Catalog_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private Catalog_Load_Item_DataType[] catalog_Load_Item_Reference_DataField;

		private Catalog_Load_DataType[] catalog_Load_Data_Reference_DataField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Catalog_Load_Reference
		{
			get
			{
				return this.catalog_Load_ReferenceField;
			}
			set
			{
				this.catalog_Load_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Load_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement("Catalog_Load_Item_Reference_Data", Order = 4)]
		public Catalog_Load_Item_DataType[] Catalog_Load_Item_Reference_Data
		{
			get
			{
				return this.catalog_Load_Item_Reference_DataField;
			}
			set
			{
				this.catalog_Load_Item_Reference_DataField = value;
				this.RaisePropertyChanged("Catalog_Load_Item_Reference_Data");
			}
		}

		[XmlElement("Catalog_Load_Data_Reference_Data", Order = 5)]
		public Catalog_Load_DataType[] Catalog_Load_Data_Reference_Data
		{
			get
			{
				return this.catalog_Load_Data_Reference_DataField;
			}
			set
			{
				this.catalog_Load_Data_Reference_DataField = value;
				this.RaisePropertyChanged("Catalog_Load_Data_Reference_Data");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
