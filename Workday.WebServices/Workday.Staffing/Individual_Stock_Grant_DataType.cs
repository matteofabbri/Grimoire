using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Individual_Stock_Grant_DataType : INotifyPropertyChanged
	{
		private decimal itemField;

		private ItemChoiceType7 itemElementNameField;

		private Stock_Grant_TypeObjectType grant_Type_ReferenceField;

		private CurrencyObjectType grant_Amount_Currency_ReferenceField;

		private decimal option_Pricing_FactorField;

		private bool option_Pricing_FactorFieldSpecified;

		private string commentsField;

		private Stock_Vesting_ScheduleObjectType vesting_Schedule_ReferenceField;

		private string grant_IDField;

		private DateTime grant_DateField;

		private bool grant_DateFieldSpecified;

		private DateTime vest_From_DateField;

		private bool vest_From_DateFieldSpecified;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private decimal grant_PriceField;

		private bool grant_PriceFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private bool board_ApprovedField;

		private bool board_ApprovedFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlChoiceIdentifier("ItemElementName"), XmlElement("Grant_Amount", typeof(decimal), Order = 0), XmlElement("Grant_Percent", typeof(decimal), Order = 0), XmlElement("Shares_Granted", typeof(decimal), Order = 0)]
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

		[XmlElement(Order = 1), XmlIgnore]
		public ItemChoiceType7 ItemElementName
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public decimal Option_Pricing_Factor
		{
			get
			{
				return this.option_Pricing_FactorField;
			}
			set
			{
				this.option_Pricing_FactorField = value;
				this.RaisePropertyChanged("Option_Pricing_Factor");
			}
		}

		[XmlIgnore]
		public bool Option_Pricing_FactorSpecified
		{
			get
			{
				return this.option_Pricing_FactorFieldSpecified;
			}
			set
			{
				this.option_Pricing_FactorFieldSpecified = value;
				this.RaisePropertyChanged("Option_Pricing_FactorSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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
