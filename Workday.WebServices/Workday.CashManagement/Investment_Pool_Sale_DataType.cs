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
	public class Investment_Pool_Sale_DataType : INotifyPropertyChanged
	{
		private string idField;

		private DateTime transaction_DateField;

		private Document_StatusObjectType status_ReferenceField;

		private Investment_PoolObjectType investment_Pool_ReferenceField;

		private Unique_IdentifierObjectType investment_Pool_Valuation_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private GiftObjectType gift_ReferenceField;

		private decimal units_to_SellField;

		private bool units_to_SellFieldSpecified;

		private decimal unit_PriceField;

		private bool unit_PriceFieldSpecified;

		private decimal net_Book_ValueField;

		private bool net_Book_ValueFieldSpecified;

		private Unique_IdentifierObjectType unit_Selection_Method_ReferenceField;

		private decimal fair_Market_ValueField;

		private bool fair_Market_ValueFieldSpecified;

		private Investment_Pool_Sale_Line_DataType[] unit_Source_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(DataType = "date", Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Unique_IdentifierObjectType Investment_Pool_Valuation_Reference
		{
			get
			{
				return this.investment_Pool_Valuation_ReferenceField;
			}
			set
			{
				this.investment_Pool_Valuation_ReferenceField = value;
				this.RaisePropertyChanged("Investment_Pool_Valuation_Reference");
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

		[XmlElement(Order = 7)]
		public decimal Units_to_Sell
		{
			get
			{
				return this.units_to_SellField;
			}
			set
			{
				this.units_to_SellField = value;
				this.RaisePropertyChanged("Units_to_Sell");
			}
		}

		[XmlIgnore]
		public bool Units_to_SellSpecified
		{
			get
			{
				return this.units_to_SellFieldSpecified;
			}
			set
			{
				this.units_to_SellFieldSpecified = value;
				this.RaisePropertyChanged("Units_to_SellSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Net_Book_Value
		{
			get
			{
				return this.net_Book_ValueField;
			}
			set
			{
				this.net_Book_ValueField = value;
				this.RaisePropertyChanged("Net_Book_Value");
			}
		}

		[XmlIgnore]
		public bool Net_Book_ValueSpecified
		{
			get
			{
				return this.net_Book_ValueFieldSpecified;
			}
			set
			{
				this.net_Book_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Net_Book_ValueSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public Unique_IdentifierObjectType Unit_Selection_Method_Reference
		{
			get
			{
				return this.unit_Selection_Method_ReferenceField;
			}
			set
			{
				this.unit_Selection_Method_ReferenceField = value;
				this.RaisePropertyChanged("Unit_Selection_Method_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Fair_Market_Value
		{
			get
			{
				return this.fair_Market_ValueField;
			}
			set
			{
				this.fair_Market_ValueField = value;
				this.RaisePropertyChanged("Fair_Market_Value");
			}
		}

		[XmlIgnore]
		public bool Fair_Market_ValueSpecified
		{
			get
			{
				return this.fair_Market_ValueFieldSpecified;
			}
			set
			{
				this.fair_Market_ValueFieldSpecified = value;
				this.RaisePropertyChanged("Fair_Market_ValueSpecified");
			}
		}

		[XmlElement("Unit_Source_Data", Order = 12)]
		public Investment_Pool_Sale_Line_DataType[] Unit_Source_Data
		{
			get
			{
				return this.unit_Source_DataField;
			}
			set
			{
				this.unit_Source_DataField = value;
				this.RaisePropertyChanged("Unit_Source_Data");
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
