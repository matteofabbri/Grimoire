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
	public class Replenishment_Policy_DataType : INotifyPropertyChanged
	{
		private Replenishment_TypeObjectType replenishment_Type_ReferenceField;

		private decimal reorder_Point_QuantityField;

		private bool reorder_Point_QuantityFieldSpecified;

		private decimal maximum_QuantityField;

		private bool maximum_QuantityFieldSpecified;

		private decimal economic_Order_QuantityField;

		private bool economic_Order_QuantityFieldSpecified;

		private Unit_of_MeasureObjectType replenishment_Unit_of_Measure_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Replenishment_TypeObjectType Replenishment_Type_Reference
		{
			get
			{
				return this.replenishment_Type_ReferenceField;
			}
			set
			{
				this.replenishment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Reorder_Point_Quantity
		{
			get
			{
				return this.reorder_Point_QuantityField;
			}
			set
			{
				this.reorder_Point_QuantityField = value;
				this.RaisePropertyChanged("Reorder_Point_Quantity");
			}
		}

		[XmlIgnore]
		public bool Reorder_Point_QuantitySpecified
		{
			get
			{
				return this.reorder_Point_QuantityFieldSpecified;
			}
			set
			{
				this.reorder_Point_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Reorder_Point_QuantitySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Maximum_Quantity
		{
			get
			{
				return this.maximum_QuantityField;
			}
			set
			{
				this.maximum_QuantityField = value;
				this.RaisePropertyChanged("Maximum_Quantity");
			}
		}

		[XmlIgnore]
		public bool Maximum_QuantitySpecified
		{
			get
			{
				return this.maximum_QuantityFieldSpecified;
			}
			set
			{
				this.maximum_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Maximum_QuantitySpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Economic_Order_Quantity
		{
			get
			{
				return this.economic_Order_QuantityField;
			}
			set
			{
				this.economic_Order_QuantityField = value;
				this.RaisePropertyChanged("Economic_Order_Quantity");
			}
		}

		[XmlIgnore]
		public bool Economic_Order_QuantitySpecified
		{
			get
			{
				return this.economic_Order_QuantityFieldSpecified;
			}
			set
			{
				this.economic_Order_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Economic_Order_QuantitySpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Unit_of_MeasureObjectType Replenishment_Unit_of_Measure_Reference
		{
			get
			{
				return this.replenishment_Unit_of_Measure_ReferenceField;
			}
			set
			{
				this.replenishment_Unit_of_Measure_ReferenceField = value;
				this.RaisePropertyChanged("Replenishment_Unit_of_Measure_Reference");
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
