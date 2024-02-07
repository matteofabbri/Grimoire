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
	public class Catalog_Item_Data_for_Catalog_DataType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType catalog_Item_Data_ReferenceField;

		private DateTime effective_DateField;

		private decimal unit_Price_as_of_Effective_DateField;

		private bool unit_Price_as_of_Effective_DateFieldSpecified;

		private bool active_as_of_Effective_DateField;

		private bool active_as_of_Effective_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Catalog_Item_Data_Reference
		{
			get
			{
				return this.catalog_Item_Data_ReferenceField;
			}
			set
			{
				this.catalog_Item_Data_ReferenceField = value;
				this.RaisePropertyChanged("Catalog_Item_Data_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Unit_Price_as_of_Effective_Date
		{
			get
			{
				return this.unit_Price_as_of_Effective_DateField;
			}
			set
			{
				this.unit_Price_as_of_Effective_DateField = value;
				this.RaisePropertyChanged("Unit_Price_as_of_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Unit_Price_as_of_Effective_DateSpecified
		{
			get
			{
				return this.unit_Price_as_of_Effective_DateFieldSpecified;
			}
			set
			{
				this.unit_Price_as_of_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Unit_Price_as_of_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Active_as_of_Effective_Date
		{
			get
			{
				return this.active_as_of_Effective_DateField;
			}
			set
			{
				this.active_as_of_Effective_DateField = value;
				this.RaisePropertyChanged("Active_as_of_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Active_as_of_Effective_DateSpecified
		{
			get
			{
				return this.active_as_of_Effective_DateFieldSpecified;
			}
			set
			{
				this.active_as_of_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Active_as_of_Effective_DateSpecified");
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
