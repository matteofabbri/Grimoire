using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Investment_Pool_Adjustment_DataType : INotifyPropertyChanged
	{
		private DateTime transaction_DateField;

		private string idField;

		private GiftObjectType gift_ReferenceField;

		private decimal units_to_AdjustField;

		private Document_StatusObjectType status_ReferenceField;

		private decimal adjustment_Fair_Market_ValueField;

		private bool adjustment_Fair_Market_ValueFieldSpecified;

		private decimal original_Total_UnitsField;

		private bool original_Total_UnitsFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Investment_PoolObjectType investment_Pool_ReferenceField;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private Investment_Pool_AdjustmentObjectType investment_Pool_Adjustment_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(DataType = "date", Order = 0)]
		public DateTime Transaction_Date
		{
			get
			{
				return this.transaction_DateField;
			}
			set
			{
				this.transaction_DateField = value;
				this.RaisePropertyChanged("Transaction_Date");
			}
		}

		[XmlElement(Order = 1)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 2)]
		public GiftObjectType Gift_Reference
		{
			get
			{
				return this.gift_ReferenceField;
			}
			set
			{
				this.gift_ReferenceField = value;
				this.RaisePropertyChanged("Gift_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Units_to_Adjust
		{
			get
			{
				return this.units_to_AdjustField;
			}
			set
			{
				this.units_to_AdjustField = value;
				this.RaisePropertyChanged("Units_to_Adjust");
			}
		}

		[XmlElement(Order = 4)]
		public Document_StatusObjectType Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Adjustment_Fair_Market_Value
		{
			get
			{
				return this.adjustment_Fair_Market_ValueField;
			}
			set
			{
				this.adjustment_Fair_Market_ValueField = value;
				this.RaisePropertyChanged("Adjustment_Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Adjustment_Fair_Market_ValueSpecified
		{
			get
			{
				return this.adjustment_Fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.adjustment_Fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Adjustment_Fair_Market_ValueSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Original_Total_Units
		{
			get
			{
				return this.original_Total_UnitsField;
			}
			set
			{
				this.original_Total_UnitsField = value;
				this.RaisePropertyChanged("Original_Total_Units");
			}
		}

		[XmlIgnore]
		public bool Original_Total_UnitsSpecified
		{
			get
			{
				return this.original_Total_UnitsFieldSpecified;
			}
			set
			{
				this.original_Total_UnitsFieldSpecified = value;
				this.RaisePropertyChanged("Original_Total_UnitsSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Investment_PoolObjectType Investment_Pool_Reference
		{
			get
			{
				return this.investment_Pool_ReferenceField;
			}
			set
			{
				this.investment_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Investment_Pool_AdjustmentObjectType Investment_Pool_Adjustment_Reference
		{
			get
			{
				return this.investment_Pool_Adjustment_ReferenceField;
			}
			set
			{
				this.investment_Pool_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Adjustment_Reference");
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
