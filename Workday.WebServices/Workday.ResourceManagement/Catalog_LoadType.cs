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
	public class Catalog_LoadType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType catalog_Load_ReferenceField;

		private Catalog_Load_DataType catalog_Load_DataField;

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

		[XmlElement(Order = 1)]
		public Catalog_Load_DataType Catalog_Load_Data
		{
			get
			{
				return this.catalog_Load_DataField;
			}
			set
			{
				this.catalog_Load_DataField = value;
				this.RaisePropertyChanged("Catalog_Load_Data");
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
