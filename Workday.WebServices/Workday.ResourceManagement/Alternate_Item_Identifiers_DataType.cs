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
	public class Alternate_Item_Identifiers_DataType : INotifyPropertyChanged
	{
		private Item_Identifier_TypeObjectType item_Identifier_Type_ReferenceField;

		private string alternate_Item_Identifier_ValueField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private ManufacturerObjectType manufacturer_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Item_Identifier_TypeObjectType Item_Identifier_Type_Reference
		{
			get
			{
				return this.item_Identifier_Type_ReferenceField;
			}
			set
			{
				this.item_Identifier_Type_ReferenceField = value;
				this.RaisePropertyChanged("Item_Identifier_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Alternate_Item_Identifier_Value
		{
			get
			{
				return this.alternate_Item_Identifier_ValueField;
			}
			set
			{
				this.alternate_Item_Identifier_ValueField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifier_Value");
			}
		}

		[XmlElement(Order = 2)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 3)]
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
