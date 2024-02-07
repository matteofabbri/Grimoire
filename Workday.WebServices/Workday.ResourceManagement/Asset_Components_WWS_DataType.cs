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
	public class Asset_Components_WWS_DataType : INotifyPropertyChanged
	{
		private Business_AssetObjectType component_Asset_ReferenceField;

		private string asset_DescriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal total_CostField;

		private bool total_CostFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Business_AssetObjectType Component_Asset_Reference
		{
			get
			{
				return this.component_Asset_ReferenceField;
			}
			set
			{
				this.component_Asset_ReferenceField = value;
				this.RaisePropertyChanged("Component_Asset_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Asset_Description
		{
			get
			{
				return this.asset_DescriptionField;
			}
			set
			{
				this.asset_DescriptionField = value;
				this.RaisePropertyChanged("Asset_Description");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Total_Cost
		{
			get
			{
				return this.total_CostField;
			}
			set
			{
				this.total_CostField = value;
				this.RaisePropertyChanged("Total_Cost");
			}
		}

		[XmlIgnore]
		public bool Total_CostSpecified
		{
			get
			{
				return this.total_CostFieldSpecified;
			}
			set
			{
				this.total_CostFieldSpecified = value;
				this.RaisePropertyChanged("Total_CostSpecified");
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
