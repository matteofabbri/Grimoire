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
	public class Item_LotType : INotifyPropertyChanged
	{
		private Item_LotObjectType item_Lot_ReferenceField;

		private Item_Lot_DataType item_Lot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Item_LotObjectType Item_Lot_Reference
		{
			get
			{
				return this.item_Lot_ReferenceField;
			}
			set
			{
				this.item_Lot_ReferenceField = value;
				this.RaisePropertyChanged("Item_Lot_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Item_Lot_DataType Item_Lot_Data
		{
			get
			{
				return this.item_Lot_DataField;
			}
			set
			{
				this.item_Lot_DataField = value;
				this.RaisePropertyChanged("Item_Lot_Data");
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
