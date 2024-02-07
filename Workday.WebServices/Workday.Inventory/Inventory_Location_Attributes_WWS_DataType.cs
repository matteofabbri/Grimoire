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
	public class Inventory_Location_Attributes_WWS_DataType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Location_Attributes_ReferenceField;

		private Inventory_Location_AttributesObjectType inventory_Location_Attributes_Instance_ReferenceField;

		private Inventory_Location_Attributes_WWS_Detail_DataType[] inventory_Location_Attributes_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Location_Attributes_Reference
		{
			get
			{
				return this.inventory_Location_Attributes_ReferenceField;
			}
			set
			{
				this.inventory_Location_Attributes_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Attributes_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_Location_AttributesObjectType Inventory_Location_Attributes_Instance_Reference
		{
			get
			{
				return this.inventory_Location_Attributes_Instance_ReferenceField;
			}
			set
			{
				this.inventory_Location_Attributes_Instance_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Attributes_Instance_Reference");
			}
		}

		[XmlElement("Inventory_Location_Attributes_Detail_Data", Order = 2)]
		public Inventory_Location_Attributes_WWS_Detail_DataType[] Inventory_Location_Attributes_Detail_Data
		{
			get
			{
				return this.inventory_Location_Attributes_Detail_DataField;
			}
			set
			{
				this.inventory_Location_Attributes_Detail_DataField = value;
				this.RaisePropertyChanged("Inventory_Location_Attributes_Detail_Data");
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
