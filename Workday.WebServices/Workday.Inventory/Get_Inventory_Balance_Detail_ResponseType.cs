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
	public class Get_Inventory_Balance_Detail_ResponseType : INotifyPropertyChanged
	{
		private Purchase_ItemObjectType item_in_Inventory_Location_ReferenceField;

		private string qOH_with_UOMField;

		private Get_Inventory_Balance_Detail_Site_ResponseType[] get_Inventory_Balance_Detail_Site_Response_ElementField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_ItemObjectType Item_in_Inventory_Location_Reference
		{
			get
			{
				return this.item_in_Inventory_Location_ReferenceField;
			}
			set
			{
				this.item_in_Inventory_Location_ReferenceField = value;
				this.RaisePropertyChanged("Item_in_Inventory_Location_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string QOH_with_UOM
		{
			get
			{
				return this.qOH_with_UOMField;
			}
			set
			{
				this.qOH_with_UOMField = value;
				this.RaisePropertyChanged("QOH_with_UOM");
			}
		}

		[XmlElement("Get_Inventory_Balance_Detail_Site_Response_Element", Order = 2)]
		public Get_Inventory_Balance_Detail_Site_ResponseType[] Get_Inventory_Balance_Detail_Site_Response_Element
		{
			get
			{
				return this.get_Inventory_Balance_Detail_Site_Response_ElementField;
			}
			set
			{
				this.get_Inventory_Balance_Detail_Site_Response_ElementField = value;
				this.RaisePropertyChanged("Get_Inventory_Balance_Detail_Site_Response_Element");
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
