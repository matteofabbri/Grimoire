using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Compensation
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Add_Individual_Stock_Grant_DataType : INotifyPropertyChanged
	{
		private string stock_Grant_Reference_IDField;

		private Stock_Grant_TypeObjectType grant_Type_ReferenceField;

		private string grant_IDField;

		private DateTime grant_DateField;

		private bool grant_DateFieldSpecified;

		private Stock_Vesting_ScheduleObjectType vesting_Schedule_ReferenceField;

		private DateTime vest_From_DateField;

		private bool vest_From_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private decimal itemField;

		private ItemChoiceType9 itemElementNameField;

		private CurrencyObjectType grant_Amount_Currency_ReferenceField;

		private decimal grant_PriceField;

		private bool grant_PriceFieldSpecified;

		private CurrencyObjectType grant_Price_Currency_ReferenceField;

		private decimal options_Pricing_FactorField;

		private bool options_Pricing_FactorFieldSpecified;

		private bool board_ApprovedField;

		private bool board_ApprovedFieldSpecified;

		private string commentsField;

		private decimal shares_VestedField;

		private bool shares_VestedFieldSpecified;

		private decimal shares_UnvestedField;

		private bool shares_UnvestedFieldSpecified;

		private decimal long_Term_Cash_Amount_VestedField;

		private bool long_Term_Cash_Amount_VestedFieldSpecified;

		private decimal long_Term_Cash_Amount_UnvestedField;

		private bool long_Term_Cash_Amount_UnvestedFieldSpecified;

		private decimal vesting_PriceField;

		private bool vesting_PriceFieldSpecified;

		private DateTime vested_As_OfField;

		private bool vested_As_OfFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Stock_Grant_Reference_ID
		{
			get
			{
				return this.stock_Grant_Reference_IDField;
			}
			set
			{
				this.stock_Grant_Reference_IDField = value;
				this.RaisePropertyChanged("Stock_Grant_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Stock_Grant_TypeObjectType Grant_Type_Reference
		{
			get
			{
				return this.grant_Type_ReferenceField;
			}
			set
			{
				this.grant_Type_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Grant_ID
		{
			get
			{
				return this.grant_IDField;
			}
			set
			{
				this.grant_IDField = value;
				this.RaisePropertyChanged("Grant_ID");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Grant_Date
		{
			get
			{
				return this.grant_DateField;
			}
			set
			{
				this.grant_DateField = value;
				this.RaisePropertyChanged("Grant_Date");
			}
		}

		[XmlIgnore]
		public bool Grant_DateSpecified
		{
			get
			{
				return this.grant_DateFieldSpecified;
			}
			set
			{
				this.grant_DateFieldSpecified = value;
				this.RaisePropertyChanged("Grant_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public Stock_Vesting_ScheduleObjectType Vesting_Schedule_Reference
		{
			get
			{
				return this.vesting_Schedule_ReferenceField;
			}
			set
			{
				this.vesting_Schedule_ReferenceField = value;
				this.RaisePropertyChanged("Vesting_Schedule_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Vest_From_Date
		{
			get
			{
				return this.vest_From_DateField;
			}
			set
			{
				this.vest_From_DateField = value;
				this.RaisePropertyChanged("Vest_From_Date");
			}
		}

		[XmlIgnore]
		public bool Vest_From_DateSpecified
		{
			get
			{
				return this.vest_From_DateFieldSpecified;
			}
			set
			{
				this.vest_From_DateFieldSpecified = value;
				this.RaisePropertyChanged("Vest_From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Grant_Amount", typeof(decimal), Order = 7), XmlElement("Grant_Percent", typeof(decimal), Order = 7), XmlElement("Shares_Granted", typeof(decimal), Order = 7)]
		public decimal Item
		{
			get
			{
				return this.itemField;
			}
			set
			{
				this.itemField = value;
				this.RaisePropertyChanged("Item");
			}
		}

		[XmlElement(Order = 8), XmlIgnore]
		public ItemChoiceType9 ItemElementName
		{
			get
			{
				return this.itemElementNameField;
			}
			set
			{
				this.itemElementNameField = value;
				this.RaisePropertyChanged("ItemElementName");
			}
		}

		[XmlElement(Order = 9)]
		public CurrencyObjectType Grant_Amount_Currency_Reference
		{
			get
			{
				return this.grant_Amount_Currency_ReferenceField;
			}
			set
			{
				this.grant_Amount_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Amount_Currency_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Grant_Price
		{
			get
			{
				return this.grant_PriceField;
			}
			set
			{
				this.grant_PriceField = value;
				this.RaisePropertyChanged("Grant_Price");
			}
		}

		[XmlIgnore]
		public bool Grant_PriceSpecified
		{
			get
			{
				return this.grant_PriceFieldSpecified;
			}
			set
			{
				this.grant_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Grant_PriceSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public CurrencyObjectType Grant_Price_Currency_Reference
		{
			get
			{
				return this.grant_Price_Currency_ReferenceField;
			}
			set
			{
				this.grant_Price_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Grant_Price_Currency_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Options_Pricing_Factor
		{
			get
			{
				return this.options_Pricing_FactorField;
			}
			set
			{
				this.options_Pricing_FactorField = value;
				this.RaisePropertyChanged("Options_Pricing_Factor");
			}
		}

		[XmlIgnore]
		public bool Options_Pricing_FactorSpecified
		{
			get
			{
				return this.options_Pricing_FactorFieldSpecified;
			}
			set
			{
				this.options_Pricing_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Options_Pricing_FactorSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public bool Board_Approved
		{
			get
			{
				return this.board_ApprovedField;
			}
			set
			{
				this.board_ApprovedField = value;
				this.RaisePropertyChanged("Board_Approved");
			}
		}

		[XmlIgnore]
		public bool Board_ApprovedSpecified
		{
			get
			{
				return this.board_ApprovedFieldSpecified;
			}
			set
			{
				this.board_ApprovedFieldSpecified = value;
				this.RaisePropertyChanged("Board_ApprovedSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public string Comments
		{
			get
			{
				return this.commentsField;
			}
			set
			{
				this.commentsField = value;
				this.RaisePropertyChanged("Comments");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Shares_Vested
		{
			get
			{
				return this.shares_VestedField;
			}
			set
			{
				this.shares_VestedField = value;
				this.RaisePropertyChanged("Shares_Vested");
			}
		}

		[XmlIgnore]
		public bool Shares_VestedSpecified
		{
			get
			{
				return this.shares_VestedFieldSpecified;
			}
			set
			{
				this.shares_VestedFieldSpecified = value;
				this.RaisePropertyChanged("Shares_VestedSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Shares_Unvested
		{
			get
			{
				return this.shares_UnvestedField;
			}
			set
			{
				this.shares_UnvestedField = value;
				this.RaisePropertyChanged("Shares_Unvested");
			}
		}

		[XmlIgnore]
		public bool Shares_UnvestedSpecified
		{
			get
			{
				return this.shares_UnvestedFieldSpecified;
			}
			set
			{
				this.shares_UnvestedFieldSpecified = value;
				this.RaisePropertyChanged("Shares_UnvestedSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Long_Term_Cash_Amount_Vested
		{
			get
			{
				return this.long_Term_Cash_Amount_VestedField;
			}
			set
			{
				this.long_Term_Cash_Amount_VestedField = value;
				this.RaisePropertyChanged("Long_Term_Cash_Amount_Vested");
			}
		}

		[XmlIgnore]
		public bool Long_Term_Cash_Amount_VestedSpecified
		{
			get
			{
				return this.long_Term_Cash_Amount_VestedFieldSpecified;
			}
			set
			{
				this.long_Term_Cash_Amount_VestedFieldSpecified = value;
				this.RaisePropertyChanged("Long_Term_Cash_Amount_VestedSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Long_Term_Cash_Amount_Unvested
		{
			get
			{
				return this.long_Term_Cash_Amount_UnvestedField;
			}
			set
			{
				this.long_Term_Cash_Amount_UnvestedField = value;
				this.RaisePropertyChanged("Long_Term_Cash_Amount_Unvested");
			}
		}

		[XmlIgnore]
		public bool Long_Term_Cash_Amount_UnvestedSpecified
		{
			get
			{
				return this.long_Term_Cash_Amount_UnvestedFieldSpecified;
			}
			set
			{
				this.long_Term_Cash_Amount_UnvestedFieldSpecified = value;
				this.RaisePropertyChanged("Long_Term_Cash_Amount_UnvestedSpecified");
			}
		}

		[XmlElement(Order = 19)]
		public decimal Vesting_Price
		{
			get
			{
				return this.vesting_PriceField;
			}
			set
			{
				this.vesting_PriceField = value;
				this.RaisePropertyChanged("Vesting_Price");
			}
		}

		[XmlIgnore]
		public bool Vesting_PriceSpecified
		{
			get
			{
				return this.vesting_PriceFieldSpecified;
			}
			set
			{
				this.vesting_PriceFieldSpecified = value;
				this.RaisePropertyChanged("Vesting_PriceSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 20)]
		public DateTime Vested_As_Of
		{
			get
			{
				return this.vested_As_OfField;
			}
			set
			{
				this.vested_As_OfField = value;
				this.RaisePropertyChanged("Vested_As_Of");
			}
		}

		[XmlIgnore]
		public bool Vested_As_OfSpecified
		{
			get
			{
				return this.vested_As_OfFieldSpecified;
			}
			set
			{
				this.vested_As_OfFieldSpecified = value;
				this.RaisePropertyChanged("Vested_As_OfSpecified");
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
