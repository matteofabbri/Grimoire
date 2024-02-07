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
	public class Asset_Pooling_Rule_Replacement_DataType : INotifyPropertyChanged
	{
		private string asset_Pooling_Rule_IDField;

		private string asset_Pooling_Rule_OrderField;

		private OrganizationObjectType[] company_ReferenceField;

		private Spend_Category_or_HierarchyObjectType[] spend_Category_or_Hierarchy_ReferenceField;

		private Item_DescriptorObjectType[] items_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal quantity_Greater_ThanField;

		private decimal unit_Cost_Less_ThanField;

		private bool unit_Cost_Less_ThanFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Asset_Pooling_Rule_ID
		{
			get
			{
				return this.asset_Pooling_Rule_IDField;
			}
			set
			{
				this.asset_Pooling_Rule_IDField = value;
				this.RaisePropertyChanged("Asset_Pooling_Rule_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Asset_Pooling_Rule_Order
		{
			get
			{
				return this.asset_Pooling_Rule_OrderField;
			}
			set
			{
				this.asset_Pooling_Rule_OrderField = value;
				this.RaisePropertyChanged("Asset_Pooling_Rule_Order");
			}
		}

		[XmlElement("Company_Reference", Order = 2)]
		public OrganizationObjectType[] Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement("Spend_Category_or_Hierarchy_Reference", Order = 3)]
		public Spend_Category_or_HierarchyObjectType[] Spend_Category_or_Hierarchy_Reference
		{
			get
			{
				return this.spend_Category_or_Hierarchy_ReferenceField;
			}
			set
			{
				this.spend_Category_or_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_or_Hierarchy_Reference");
			}
		}

		[XmlElement("Items_Reference", Order = 4)]
		public Item_DescriptorObjectType[] Items_Reference
		{
			get
			{
				return this.items_ReferenceField;
			}
			set
			{
				this.items_ReferenceField = value;
				this.RaisePropertyChanged("Items_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public CurrencyObjectType Currency_Reference
		{
			get
			{
				return this.currency_ReferenceField;
			}
			set
			{
				this.currency_ReferenceField = value;
				this.RaisePropertyChanged("Currency_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Quantity_Greater_Than
		{
			get
			{
				return this.quantity_Greater_ThanField;
			}
			set
			{
				this.quantity_Greater_ThanField = value;
				this.RaisePropertyChanged("Quantity_Greater_Than");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Unit_Cost_Less_Than
		{
			get
			{
				return this.unit_Cost_Less_ThanField;
			}
			set
			{
				this.unit_Cost_Less_ThanField = value;
				this.RaisePropertyChanged("Unit_Cost_Less_Than");
			}
		}

		[XmlIgnore]
		public bool Unit_Cost_Less_ThanSpecified
		{
			get
			{
				return this.unit_Cost_Less_ThanFieldSpecified;
			}
			set
			{
				this.unit_Cost_Less_ThanFieldSpecified = value;
				this.RaisePropertyChanged("Unit_Cost_Less_ThanSpecified");
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
