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
	public class Internal_Catalog_Request_ReferencesType : INotifyPropertyChanged
	{
		private Internal_Service_CatalogObjectType[] internal_Catalog_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Internal_Catalog_Reference", Order = 0)]
		public Internal_Service_CatalogObjectType[] Internal_Catalog_Reference
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
