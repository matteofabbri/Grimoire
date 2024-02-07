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
	public class Investment_Pool_Purchase_ValueType : INotifyPropertyChanged
	{
		private string statusField;

		private Unique_IdentifierObjectType investment_Pool_Valuation_ReferenceField;

		private decimal default_Unit_PriceField;

		private bool default_Unit_PriceFieldSpecified;

		private decimal units_PurchasedField;

		private bool units_PurchasedFieldSpecified;

		private decimal total_Amount_PurchasedField;

		private bool total_Amount_PurchasedFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private bool reinvestmentField;

		private bool reinvestmentFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Status
		{
			get
			{
				return this.statusField;
			}
			set
			{
				this.statusField = value;
				this.RaisePropertyChanged("Status");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
		public decimal Default_Unit_Price
		{
			get
			{
				return this.default_Unit_PriceField;
			}
			set
			{
				this.default_Unit_PriceField = value;
				this.RaisePropertyChanged("Default_Unit_Price");
			}
		}

		[XmlIgnore]
		public bool Default_Unit_PriceSpecified
		{
			get
			{
				return this.default_Unit_PriceFieldSpecified;
			}
			set
			{
				this.default_Unit_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Default_Unit_PriceSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal Units_Purchased
		{
			get
			{
				return this.units_PurchasedField;
			}
			set
			{
				this.units_PurchasedField = value;
				this.RaisePropertyChanged("Units_Purchased");
			}
		}

		[XmlIgnore]
		public bool Units_PurchasedSpecified
		{
			get
			{
				return this.units_PurchasedFieldSpecified;
			}
			set
			{
				this.units_PurchasedFieldSpecified = value;
				this.RaisePropertyChanged("Units_PurchasedSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Total_Amount_Purchased
		{
			get
			{
				return this.total_Amount_PurchasedField;
			}
			set
			{
				this.total_Amount_PurchasedField = value;
				this.RaisePropertyChanged("Total_Amount_Purchased");
			}
		}

		[XmlIgnore]
		public bool Total_Amount_PurchasedSpecified
		{
			get
			{
				return this.total_Amount_PurchasedFieldSpecified;
			}
			set
			{
				this.total_Amount_PurchasedFieldSpecified = value;
				this.RaisePropertyChanged("Total_Amount_PurchasedSpecified");
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
		public bool Reinvestment
		{
			get
			{
				return this.reinvestmentField;
			}
			set
			{
				this.reinvestmentField = value;
				this.RaisePropertyChanged("Reinvestment");
			}
		}

		[XmlIgnore]
		public bool ReinvestmentSpecified
		{
			get
			{
				return this.reinvestmentFieldSpecified;
			}
			set
			{
				this.reinvestmentFieldSpecified = value;
				this.RaisePropertyChanged("ReinvestmentSpecified");
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
