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
	public class Internal_CatalogType : INotifyPropertyChanged
	{
		private Internal_Service_CatalogObjectType internal_Catalog_ReferenceField;

		private Internal_Catalog_DataType[] internal_Catalog_DataField;

		private Catalog_Item_for_Internal_Catalog_DataType[] catalog_Item_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Internal_Service_CatalogObjectType Internal_Catalog_Reference
		{
			get
			{
				return this.internal_Catalog_ReferenceField;
			}
			set
			{
				this.internal_Catalog_ReferenceField = value;
				this.RaisePropertyChanged("Internal_Catalog_Reference");
			}
		}

		[XmlElement("Internal_Catalog_Data", Order = 1)]
		public Internal_Catalog_DataType[] Internal_Catalog_Data
		{
			get
			{
				return this.internal_Catalog_DataField;
			}
			set
			{
				this.internal_Catalog_DataField = value;
				this.RaisePropertyChanged("Internal_Catalog_Data");
			}
		}

		[XmlElement("Catalog_Item_Data", Order = 2)]
		public Catalog_Item_for_Internal_Catalog_DataType[] Catalog_Item_Data
		{
			get
			{
				return this.catalog_Item_DataField;
			}
			set
			{
				this.catalog_Item_DataField = value;
				this.RaisePropertyChanged("Catalog_Item_Data");
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
