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
	public class Inventory_Location_Attributes_Request_ReferencesType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Location_ReferenceField;

		private Inventory_Location_AttributesObjectType inventory_Location_Attributes_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Location_Reference
		{
			get
			{
				return this.inventory_Location_ReferenceField;
			}
			set
			{
				this.inventory_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Inventory_Location_AttributesObjectType Inventory_Location_Attributes_Reference
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
