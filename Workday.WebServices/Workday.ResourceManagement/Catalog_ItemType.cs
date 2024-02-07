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
	public class Catalog_ItemType : INotifyPropertyChanged
	{
		private Catalog_ItemObjectType catalog_Item_ReferenceField;

		private Catalog_Item_DataType[] catalog_Item_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Catalog_ItemObjectType Catalog_Item_Reference
		{
			get
			{
				return this.catalog_Item_ReferenceField;
			}
			set
			{
				this.catalog_Item_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Item_Reference");
			}
		}

		[XmlElement("Catalog_Item_Data", Order = 1)]
		public Catalog_Item_DataType[] Catalog_Item_Data
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
