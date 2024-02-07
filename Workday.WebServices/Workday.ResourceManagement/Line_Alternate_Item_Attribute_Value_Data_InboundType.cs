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
	public class Line_Alternate_Item_Attribute_Value_Data_InboundType : INotifyPropertyChanged
	{
		private string external_NameField;

		private string valueField;

		private ManufacturerObjectType manufacturer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string External_Name
		{
			get
			{
				return this.external_NameField;
			}
			set
			{
				this.external_NameField = value;
				this.RaisePropertyChanged("External_Name");
			}
		}

		[XmlElement(Order = 1)]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				this.RaisePropertyChanged("Value");
			}
		}

		[XmlElement(Order = 2)]
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
