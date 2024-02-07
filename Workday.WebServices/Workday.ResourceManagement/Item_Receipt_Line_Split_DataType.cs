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
	public class Item_Receipt_Line_Split_DataType : INotifyPropertyChanged
	{
		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal extended_AmountField;

		private string memoField;

		private Business_Document_Line_SplitObjectType line_Split_Allocated_From_ReferenceField;

		private Item_Receipt_Line_Split_Lot_DataType[] item_Receipt_Line_Split_Lot_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlElement(Order = 2)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
			}
		}

		[XmlElement(Order = 3)]
		public Business_Document_Line_SplitObjectType Line_Split_Allocated_From_Reference
		{
			get
			{
				return this.line_Split_Allocated_From_ReferenceField;
			}
			set
			{
				this.line_Split_Allocated_From_ReferenceField = value;
				this.RaisePropertyChanged("Line_Split_Allocated_From_Reference");
			}
		}

		[XmlElement("Item_Receipt_Line_Split_Lot_Data", Order = 4)]
		public Item_Receipt_Line_Split_Lot_DataType[] Item_Receipt_Line_Split_Lot_Data
		{
			get
			{
				return this.item_Receipt_Line_Split_Lot_DataField;
			}
			set
			{
				this.item_Receipt_Line_Split_Lot_DataField = value;
				this.RaisePropertyChanged("Item_Receipt_Line_Split_Lot_Data");
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
