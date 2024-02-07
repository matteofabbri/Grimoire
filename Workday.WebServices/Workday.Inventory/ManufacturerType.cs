using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class ManufacturerType : INotifyPropertyChanged
	{
		private ManufacturerObjectType manufacturer_ReferenceField;

		private Manufacturer_DataType manufacturer_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public ManufacturerObjectType Manufacturer_Reference
		{
			get
			{
				return this.manufacturer_ReferenceField;
			}
			set
			{
				this.manufacturer_ReferenceField = value;
				this.RaisePropertyChanged("Manufacturer_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Manufacturer_DataType Manufacturer_Data
		{
			get
			{
				return this.manufacturer_DataField;
			}
			set
			{
				this.manufacturer_DataField = value;
				this.RaisePropertyChanged("Manufacturer_Data");
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
