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
	public class Inventory_Pick_Locations_WWS_DataType : INotifyPropertyChanged
	{
		private Purchase_ItemObjectType item_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Item_LotObjectType lot_ReferenceField;

		private decimal quantity_PickedField;

		private bool quantity_PickedFieldSpecified;

		private string line_Document_Memo_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Item_LotObjectType Lot_Reference
		{
			get
			{
				return this.lot_ReferenceField;
			}
			set
			{
				this.lot_ReferenceField = value;
				this.RaisePropertyChanged("Lot_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Quantity_Picked
		{
			get
			{
				return this.quantity_PickedField;
			}
			set
			{
				this.quantity_PickedField = value;
				this.RaisePropertyChanged("Quantity_Picked");
			}
		}

		[XmlIgnore]
		public bool Quantity_PickedSpecified
		{
			get
			{
				return this.quantity_PickedFieldSpecified;
			}
			set
			{
				this.quantity_PickedFieldSpecified = value;
				this.RaisePropertyChanged("Quantity_PickedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public string Line_Document_Memo_Reference
		{
			get
			{
				return this.line_Document_Memo_ReferenceField;
			}
			set
			{
				this.line_Document_Memo_ReferenceField = value;
				this.RaisePropertyChanged("Line_Document_Memo_Reference");
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
