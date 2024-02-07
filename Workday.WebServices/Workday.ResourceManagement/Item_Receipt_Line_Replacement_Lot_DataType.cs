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
	public class Item_Receipt_Line_Replacement_Lot_DataType : INotifyPropertyChanged
	{
		private decimal lot_QuantityField;

		private bool lot_QuantityFieldSpecified;

		private Item_LotObjectType item_Lot_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Lot_Quantity
		{
			get
			{
				return this.lot_QuantityField;
			}
			set
			{
				this.lot_QuantityField = value;
				this.RaisePropertyChanged("Lot_Quantity");
			}
		}

		[XmlIgnore]
		public bool Lot_QuantitySpecified
		{
			get
			{
				return this.lot_QuantityFieldSpecified;
			}
			set
			{
				this.lot_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Lot_QuantitySpecified");
			}
		}

		[XmlElement(Order = 1)]
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
