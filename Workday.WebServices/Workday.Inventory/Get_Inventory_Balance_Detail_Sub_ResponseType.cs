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
	public class Get_Inventory_Balance_Detail_Sub_ResponseType : INotifyPropertyChanged
	{
		private LocationObjectType inventory_Balance_Sub_Inventory_Location_ReferenceField;

		private string location_Quantity_with_UOMField;

		private Get_Inventory_Balance_Location_Quantity_Detail_ViewType[] get_Inventory_Balance_Location_Quantity_Detail_View_ElementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Inventory_Balance_Sub_Inventory_Location_Reference
		{
			get
			{
				return this.inventory_Balance_Sub_Inventory_Location_ReferenceField;
			}
			set
			{
				this.inventory_Balance_Sub_Inventory_Location_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Balance_Sub_Inventory_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Location_Quantity_with_UOM
		{
			get
			{
				return this.location_Quantity_with_UOMField;
			}
			set
			{
				this.location_Quantity_with_UOMField = value;
				this.RaisePropertyChanged("Location_Quantity_with_UOM");
			}
		}

		[XmlElement("Get_Inventory_Balance_Location_Quantity_Detail_View_Element", Order = 2)]
		public Get_Inventory_Balance_Location_Quantity_Detail_ViewType[] Get_Inventory_Balance_Location_Quantity_Detail_View_Element
		{
			get
			{
				return this.get_Inventory_Balance_Location_Quantity_Detail_View_ElementField;
			}
			set
			{
				this.get_Inventory_Balance_Location_Quantity_Detail_View_ElementField = value;
				this.RaisePropertyChanged("Get_Inventory_Balance_Location_Quantity_Detail_View_Element");
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
