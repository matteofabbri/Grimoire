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
	public class Inventory_Cost_Adjustment_Detail_DataType : INotifyPropertyChanged
	{
		private Purchase_ItemObjectType inventory_Item_ReferenceField;

		private decimal new_Average_Unit_Cost_ReferenceField;

		private bool new_Average_Unit_Cost_ReferenceFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Purchase_ItemObjectType Inventory_Item_Reference
		{
			get
			{
				return this.inventory_Item_ReferenceField;
			}
			set
			{
				this.inventory_Item_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal New_Average_Unit_Cost_Reference
		{
			get
			{
				return this.new_Average_Unit_Cost_ReferenceField;
			}
			set
			{
				this.new_Average_Unit_Cost_ReferenceField = value;
				this.RaisePropertyChanged("New_Average_Unit_Cost_Reference");
			}
		}

		[XmlIgnore]
		public bool New_Average_Unit_Cost_ReferenceSpecified
		{
			get
			{
				return this.new_Average_Unit_Cost_ReferenceFieldSpecified;
			}
			set
			{
				this.new_Average_Unit_Cost_ReferenceFieldSpecified = value;
				this.RaisePropertyChanged("New_Average_Unit_Cost_ReferenceSpecified");
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
