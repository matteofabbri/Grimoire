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
	public class Inventory_Count_Sheet_Line_DataType : INotifyPropertyChanged
	{
		private decimal line_NumberField;

		private bool line_NumberFieldSpecified;

		private LocationObjectType stocking_Location_ReferenceField;

		private Purchase_ItemObjectType item_ReferenceField;

		private string descriptionField;

		private Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] alternate_Item_Identifiers_DataField;

		private Item_TagObjectType[] item_Tag_ReferenceField;

		private Inventory_Count_Sheet_Line_Detail_DataType[] inventory_Count_Sheet_Line_Detail_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal Line_Number
		{
			get
			{
				return this.line_NumberField;
			}
			set
			{
				this.line_NumberField = value;
				this.RaisePropertyChanged("Line_Number");
			}
		}

		[XmlIgnore]
		public bool Line_NumberSpecified
		{
			get
			{
				return this.line_NumberFieldSpecified;
			}
			set
			{
				this.line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public LocationObjectType Stocking_Location_Reference
		{
			get
			{
				return this.stocking_Location_ReferenceField;
			}
			set
			{
				this.stocking_Location_ReferenceField = value;
				this.RaisePropertyChanged("Stocking_Location_Reference");
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
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement("Alternate_Item_Identifiers_Data", Order = 4)]
		public Alternate_Item_Identifiers_for_Inventory_Transaction_DataType[] Alternate_Item_Identifiers_Data
		{
			get
			{
				return this.alternate_Item_Identifiers_DataField;
			}
			set
			{
				this.alternate_Item_Identifiers_DataField = value;
				this.RaisePropertyChanged("Alternate_Item_Identifiers_Data");
			}
		}

		[XmlElement("Item_Tag_Reference", Order = 5)]
		public Item_TagObjectType[] Item_Tag_Reference
		{
			get
			{
				return this.item_Tag_ReferenceField;
			}
			set
			{
				this.item_Tag_ReferenceField = value;
				this.RaisePropertyChanged("Item_Tag_Reference");
			}
		}

		[XmlElement("Inventory_Count_Sheet_Line_Detail_Data", Order = 6)]
		public Inventory_Count_Sheet_Line_Detail_DataType[] Inventory_Count_Sheet_Line_Detail_Data
		{
			get
			{
				return this.inventory_Count_Sheet_Line_Detail_DataField;
			}
			set
			{
				this.inventory_Count_Sheet_Line_Detail_DataField = value;
				this.RaisePropertyChanged("Inventory_Count_Sheet_Line_Detail_Data");
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
