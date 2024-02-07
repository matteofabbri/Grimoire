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
	public class Inventory_Par_Location_Line_DataType : INotifyPropertyChanged
	{
		private string par_Location_Line_ReferenceField;

		private Item_DescriptorObjectType item_ReferenceField;

		private Par_Location_BinObjectType par_Location_Bin_ReferenceField;

		private string par_Location_Bin_NameField;

		private Replenishment_OptionObjectType replenishment_Source_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal par_Level_QuantityField;

		private bool require_CountField;

		private bool require_CountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Par_Location_Line_Reference
		{
			get
			{
				return this.par_Location_Line_ReferenceField;
			}
			set
			{
				this.par_Location_Line_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Line_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Item_DescriptorObjectType Item_Reference
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

		[XmlElement(Order = 2)]
		public Par_Location_BinObjectType Par_Location_Bin_Reference
		{
			get
			{
				return this.par_Location_Bin_ReferenceField;
			}
			set
			{
				this.par_Location_Bin_ReferenceField = value;
				this.RaisePropertyChanged("Par_Location_Bin_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public string Par_Location_Bin_Name
		{
			get
			{
				return this.par_Location_Bin_NameField;
			}
			set
			{
				this.par_Location_Bin_NameField = value;
				this.RaisePropertyChanged("Par_Location_Bin_Name");
			}
		}

		[XmlElement(Order = 4)]
		public Replenishment_OptionObjectType Replenishment_Source_Reference
		{
			get
			{
				return this.replenishment_Source_ReferenceField;
			}
			set
			{
				this.replenishment_Source_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_Source_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
		public decimal Par_Level_Quantity
		{
			get
			{
				return this.par_Level_QuantityField;
			}
			set
			{
				this.par_Level_QuantityField = value;
				this.RaisePropertyChanged("Par_Level_Quantity");
			}
		}

		[XmlElement(Order = 7)]
		public bool Require_Count
		{
			get
			{
				return this.require_CountField;
			}
			set
			{
				this.require_CountField = value;
				this.RaisePropertyChanged("Require_Count");
			}
		}

		[XmlIgnore]
		public bool Require_CountSpecified
		{
			get
			{
				return this.require_CountFieldSpecified;
			}
			set
			{
				this.require_CountFieldSpecified = value;
				this.RaisePropertyChanged("Require_CountSpecified");
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
