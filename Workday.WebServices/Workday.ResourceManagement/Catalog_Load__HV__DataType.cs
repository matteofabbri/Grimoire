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
	public class Catalog_Load__HV__DataType : INotifyPropertyChanged
	{
		private DateTime effective_DateField;

		private bool effective_DateFieldSpecified;

		private Abstract_Procurement_CatalogObjectType supplier_Catalog_ReferenceField;

		private decimal default_Lead_Time_in_DaysField;

		private bool default_Lead_Time_in_DaysFieldSpecified;

		private Catalog_Load_Item__HV__DataType[] catalog_Load_Item_DataField;

		private string memoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Effective_DateSpecified
		{
			get
			{
				return this.effective_DateFieldSpecified;
			}
			set
			{
				this.effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public Abstract_Procurement_CatalogObjectType Supplier_Catalog_Reference
		{
			get
			{
				return this.supplier_Catalog_ReferenceField;
			}
			set
			{
				this.supplier_Catalog_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Catalog_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Default_Lead_Time_in_Days
		{
			get
			{
				return this.default_Lead_Time_in_DaysField;
			}
			set
			{
				this.default_Lead_Time_in_DaysField = value;
				this.RaisePropertyChanged("Default_Lead_Time_in_Days");
			}
		}

		[XmlIgnore]
		public bool Default_Lead_Time_in_DaysSpecified
		{
			get
			{
				return this.default_Lead_Time_in_DaysFieldSpecified;
			}
			set
			{
				this.default_Lead_Time_in_DaysFieldSpecified = value;
				this.RaisePropertyChanged("Default_Lead_Time_in_DaysSpecified");
			}
		}

		[XmlElement("Catalog_Load_Item_Data", Order = 3)]
		public Catalog_Load_Item__HV__DataType[] Catalog_Load_Item_Data
		{
			get
			{
				return this.catalog_Load_Item_DataField;
			}
			set
			{
				this.catalog_Load_Item_DataField = value;
				this.RaisePropertyChanged("Catalog_Load_Item_Data");
			}
		}

		[XmlElement(Order = 4)]
		public string Memo
		{
			get
			{
				return this.memoField;
			}
			set
			{
				this.memoField = value;
				this.RaisePropertyChanged("Memo");
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
