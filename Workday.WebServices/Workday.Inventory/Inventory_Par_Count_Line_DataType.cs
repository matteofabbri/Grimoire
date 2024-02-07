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
	public class Inventory_Par_Count_Line_DataType : INotifyPropertyChanged
	{
		private Inventory_Par_Location_LineObjectType par_Location_Line_ReferenceField;

		private Inventory_Par_Count_LineObjectType par_Count_Line_ReferenceField;

		private decimal par_Count_Line_NumberField;

		private bool par_Count_Line_NumberFieldSpecified;

		private Item_DescriptorObjectType item_ReferenceField;

		private Par_Location_BinObjectType par_Location_Bin_ReferenceField;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal count_QuantityField;

		private bool count_QuantityFieldSpecified;

		private decimal request_QuantityField;

		private bool request_QuantityFieldSpecified;

		private bool zero_On_HandField;

		private bool zero_On_HandFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Par_Location_LineObjectType Par_Location_Line_Reference
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
		public Inventory_Par_Count_LineObjectType Par_Count_Line_Reference
		{
			get
			{
				return this.par_Count_Line_ReferenceField;
			}
			set
			{
				this.par_Count_Line_ReferenceField = value;
				this.RaisePropertyChanged("Par_Count_Line_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Par_Count_Line_Number
		{
			get
			{
				return this.par_Count_Line_NumberField;
			}
			set
			{
				this.par_Count_Line_NumberField = value;
				this.RaisePropertyChanged("Par_Count_Line_Number");
			}
		}

		[XmlIgnore]
		public bool Par_Count_Line_NumberSpecified
		{
			get
			{
				return this.par_Count_Line_NumberFieldSpecified;
			}
			set
			{
				this.par_Count_Line_NumberFieldSpecified = value;
				this.RaisePropertyChanged("Par_Count_Line_NumberSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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
		public decimal Count_Quantity
		{
			get
			{
				return this.count_QuantityField;
			}
			set
			{
				this.count_QuantityField = value;
				this.RaisePropertyChanged("Count_Quantity");
			}
		}

		[XmlIgnore]
		public bool Count_QuantitySpecified
		{
			get
			{
				return this.count_QuantityFieldSpecified;
			}
			set
			{
				this.count_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Count_QuantitySpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Request_Quantity
		{
			get
			{
				return this.request_QuantityField;
			}
			set
			{
				this.request_QuantityField = value;
				this.RaisePropertyChanged("Request_Quantity");
			}
		}

		[XmlIgnore]
		public bool Request_QuantitySpecified
		{
			get
			{
				return this.request_QuantityFieldSpecified;
			}
			set
			{
				this.request_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Request_QuantitySpecified");
			}
		}

		[XmlElement(Order = 8)]
		public bool Zero_On_Hand
		{
			get
			{
				return this.zero_On_HandField;
			}
			set
			{
				this.zero_On_HandField = value;
				this.RaisePropertyChanged("Zero_On_Hand");
			}
		}

		[XmlIgnore]
		public bool Zero_On_HandSpecified
		{
			get
			{
				return this.zero_On_HandFieldSpecified;
			}
			set
			{
				this.zero_On_HandFieldSpecified = value;
				this.RaisePropertyChanged("Zero_On_HandSpecified");
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
