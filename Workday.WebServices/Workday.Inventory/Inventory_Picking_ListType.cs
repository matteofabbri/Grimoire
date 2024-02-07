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
	public class Inventory_Picking_ListType : INotifyPropertyChanged
	{
		private Inventory_Pick_ListObjectType inventory_Picking_List_ReferenceField;

		private Inventory_Pick_List_DataType[] inventory_Pick_List_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Pick_ListObjectType Inventory_Picking_List_Reference
		{
			get
			{
				return this.inventory_Picking_List_ReferenceField;
			}
			set
			{
				this.inventory_Picking_List_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Picking_List_Reference");
			}
		}

		[XmlElement("Inventory_Pick_List_Data", Order = 1)]
		public Inventory_Pick_List_DataType[] Inventory_Pick_List_Data
		{
			get
			{
				return this.inventory_Pick_List_DataField;
			}
			set
			{
				this.inventory_Pick_List_DataField = value;
				this.RaisePropertyChanged("Inventory_Pick_List_Data");
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
