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
	public class Catalog_Item_for_Internal_Catalog_DataType : INotifyPropertyChanged
	{
		private Catalog_ItemObjectType catalog_Item_ReferenceField;

		private string item_IdentifierField;

		private bool currently_ActiveField;

		private bool currently_ActiveFieldSpecified;

		private decimal current_RateField;

		private bool current_RateFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private string item_DescriptionField;

		private decimal lead_TimeField;

		private bool lead_TimeFieldSpecified;

		private string item_URLField;

		private Purchase_ItemObjectType purchase_Item_ReferenceField;

		private Catalog_Item_Data_for_Catalog_DataType[] pricing_HistoryField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Catalog_ItemObjectType Catalog_Item_Reference
		{
			get
			{
				return this.catalog_Item_ReferenceField;
			}
			set
			{
				this.catalog_Item_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Item_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public string Item_Identifier
		{
			get
			{
				return this.item_IdentifierField;
			}
			set
			{
				this.item_IdentifierField = value;
				this.RaisePropertyChanged("Item_Identifier");
			}
		}

		[XmlElement(Order = 2)]
		public bool Currently_Active
		{
			get
			{
				return this.currently_ActiveField;
			}
			set
			{
				this.currently_ActiveField = value;
				this.RaisePropertyChanged("Currently_Active");
			}
		}

		[XmlIgnore]
		public bool Currently_ActiveSpecified
		{
			get
			{
				return this.currently_ActiveFieldSpecified;
			}
			set
			{
				this.currently_ActiveFieldSpecified = value;
				this.RaisePropertyChanged("Currently_ActiveSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Current_Rate
		{
			get
			{
				return this.current_RateField;
			}
			set
			{
				this.current_RateField = value;
				this.RaisePropertyChanged("Current_Rate");
			}
		}

		[XmlIgnore]
		public bool Current_RateSpecified
		{
			get
			{
				return this.current_RateFieldSpecified;
			}
			set
			{
				this.current_RateFieldSpecified = value;
				this.RaisePropertyChanged("Current_RateSpecified");
			}
		}

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
		public Spend_CategoryObjectType Spend_Category_Reference
		{
			get
			{
				return this.spend_Category_ReferenceField;
			}
			set
			{
				this.spend_Category_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Category_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Lead_Time
		{
			get
			{
				return this.lead_TimeField;
			}
			set
			{
				this.lead_TimeField = value;
				this.RaisePropertyChanged("Lead_Time");
			}
		}

		[XmlIgnore]
		public bool Lead_TimeSpecified
		{
			get
			{
				return this.lead_TimeFieldSpecified;
			}
			set
			{
				this.lead_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Lead_TimeSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public string Item_URL
		{
			get
			{
				return this.item_URLField;
			}
			set
			{
				this.item_URLField = value;
				this.RaisePropertyChanged("Item_URL");
			}
		}

		[XmlElement(Order = 9)]
		public Purchase_ItemObjectType Purchase_Item_Reference
		{
			get
			{
				return this.purchase_Item_ReferenceField;
			}
			set
			{
				this.purchase_Item_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Reference");
			}
		}

		[XmlElement("Pricing_History", Order = 10)]
		public Catalog_Item_Data_for_Catalog_DataType[] Pricing_History
		{
			get
			{
				return this.pricing_HistoryField;
			}
			set
			{
				this.pricing_HistoryField = value;
				this.RaisePropertyChanged("Pricing_History");
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
