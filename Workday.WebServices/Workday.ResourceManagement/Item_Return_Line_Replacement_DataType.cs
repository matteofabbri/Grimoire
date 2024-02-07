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
	public class Item_Return_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private object itemField;

		private decimal quantity_to_ReturnField;

		private string memoField;

		private Submit_Return_Line_Split_DataType[] return_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Purchase_Order_Line_Reference", typeof(Item_Order_LineObjectType), Order = 0), XmlElement("Supplier_Contract_Line_Reference", typeof(Supplier_Contract_Item_LineObjectType), Order = 0)]
		public object Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Quantity_to_Return
		{
			get
			{
				return this.quantity_to_ReturnField;
			}
			set
			{
				this.quantity_to_ReturnField = value;
				this.RaisePropertyChanged("Quantity_to_Return");
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

		[XmlElement("Return_Line_Split_Data", Order = 3)]
		public Submit_Return_Line_Split_DataType[] Return_Line_Split_Data
		{
			get
			{
				return this.return_Line_Split_DataField;
			}
			set
			{
				this.return_Line_Split_DataField = value;
				this.RaisePropertyChanged("Return_Line_Split_Data");
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
