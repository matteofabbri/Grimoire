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
	public class Catalog_Item_Data_DataType : INotifyPropertyChanged
	{
		private DateTime catalog_Item_Data_Effective_DateField;

		private bool catalog_Item_Data_Effective_DateFieldSpecified;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private bool catalog_Item_Data_isActiveField;

		private bool catalog_Item_Data_isActiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Catalog_Item_Data_Effective_Date
		{
			get
			{
				return this.catalog_Item_Data_Effective_DateField;
			}
			set
			{
				this.catalog_Item_Data_Effective_DateField = value;
				this.RaisePropertyChanged("Catalog_Item_Data_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Catalog_Item_Data_Effective_DateSpecified
		{
			get
			{
				return this.catalog_Item_Data_Effective_DateFieldSpecified;
			}
			set
			{
				this.catalog_Item_Data_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Catalog_Item_Data_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public decimal Unit_Price
		{
			get
			{
				return this.unit_PriceField;
			}
			set
			{
				this.unit_PriceField = value;
				this.RaisePropertyChanged("Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Unit_PriceSpecified
		{
			get
			{
				return this.unit_PriceFieldSpecified;
			}
			set
			{
				this.unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Catalog_Item_Data_isActive
		{
			get
			{
				return this.catalog_Item_Data_isActiveField;
			}
			set
			{
				this.catalog_Item_Data_isActiveField = value;
				this.RaisePropertyChanged("Catalog_Item_Data_isActive");
			}
		}

		[XmlIgnore]
		public bool Catalog_Item_Data_isActiveSpecified
		{
			get
			{
				return this.catalog_Item_Data_isActiveFieldSpecified;
			}
			set
			{
				this.catalog_Item_Data_isActiveFieldSpecified = value;
				this.RaisePropertyChanged("Catalog_Item_Data_isActiveSpecified");
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
