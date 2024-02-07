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
	public class Catalog_Item_Request_ReferencesType : INotifyPropertyChanged
	{
		private Catalog_ItemObjectType[] catalog_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Catalog_Item_Reference", Order = 0)]
		public Catalog_ItemObjectType[] Catalog_Item_Reference
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
