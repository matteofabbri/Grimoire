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
	public class Inventory_Stock_Request_Line_DataType : INotifyPropertyChanged
	{
		private Inventory_Stock_Request_LineObjectType inventory_Stock_Request_Line_ReferenceField;

		private decimal stock_Request_Line_NumberField;

		private bool stock_Request_Line_NumberFieldSpecified;

		private Purchase_ItemObjectType item_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal requested_QuantityField;

		private DateTime fulfillment_DateField;

		private bool fulfillment_DateFieldSpecified;

		private Document_StatusObjectType line_Status_ReferenceField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private string line_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Stock_Request_LineObjectType Inventory_Stock_Request_Line_Reference
		{
			get
			{
				return this.inventory_Stock_Request_Line_ReferenceField;
			}
			set
			{
				this.inventory_Stock_Request_Line_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Stock_Request_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Stock_Request_Line_Number
		{
			get
			{
				return this.stock_Request_Line_NumberField;
			}
			set
			{
				this.stock_Request_Line_NumberField = value;
				this.RaisePropertyChanged("Stock_Request_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Stock_Request_Line_NumberSpecified
		{
			get
			{
				return this.stock_Request_Line_NumberFieldSpecified;
			}
			set
			{
				this.stock_Request_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Stock_Request_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Unit_of_MeasureObjectType Unit_of_Measure_Reference
		{
			get
			{
				return this.unit_of_Measure_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Requested_Quantity
		{
			get
			{
				return this.requested_QuantityField;
			}
			set
			{
				this.requested_QuantityField = value;
				this.RaisePropertyChanged("Requested_Quantity");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Fulfillment_Date
		{
			get
			{
				return this.fulfillment_DateField;
			}
			set
			{
				this.fulfillment_DateField = value;
				this.RaisePropertyChanged("Fulfillment_Date");
			}
		}

		[XmlIgnore]
		public bool Fulfillment_DateSpecified
		{
			get
			{
				return this.fulfillment_DateFieldSpecified;
			}
			set
			{
				this.fulfillment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Fulfillment_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public Document_StatusObjectType Line_Status_Reference
		{
			get
			{
				return this.line_Status_ReferenceField;
			}
			set
			{
				this.line_Status_ReferenceField = value;
				this.RaisePropertyChanged("Line_Status_Reference");
			}
		}

		[XmlElement("Worktags_Reference", Order = 7)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Line_Memo
		{
			get
			{
				return this.line_MemoField;
			}
			set
			{
				this.line_MemoField = value;
				this.RaisePropertyChanged("Line_Memo");
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
