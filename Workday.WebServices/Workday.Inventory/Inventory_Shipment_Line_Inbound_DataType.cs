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
	public class Inventory_Shipment_Line_Inbound_DataType : INotifyPropertyChanged
	{
		private Inventory_Pick_List_LineObjectType pick_List_Line_ReferenceField;

		private string business_Document_Line_MemoField;

		private Ship_Item_Serial_Line_DataType[] ship_Item_Serial_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Pick_List_LineObjectType Pick_List_Line_Reference
		{
			get
			{
				return this.pick_List_Line_ReferenceField;
			}
			set
			{
				this.pick_List_Line_ReferenceField = value;
				this.RaisePropertyChanged("Pick_List_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Business_Document_Line_Memo
		{
			get
			{
				return this.business_Document_Line_MemoField;
			}
			set
			{
				this.business_Document_Line_MemoField = value;
				this.RaisePropertyChanged("Business_Document_Line_Memo");
			}
		}

		[XmlElement("Ship_Item_Serial_Line_Data", Order = 2)]
		public Ship_Item_Serial_Line_DataType[] Ship_Item_Serial_Line_Data
		{
			get
			{
				return this.ship_Item_Serial_Line_DataField;
			}
			set
			{
				this.ship_Item_Serial_Line_DataField = value;
				this.RaisePropertyChanged("Ship_Item_Serial_Line_Data");
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
