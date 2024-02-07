using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Inventory
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Inventory_Transaction_DataType : INotifyPropertyChanged
	{
		private Inventory_Transaction_TypeObjectType inventory_Transaction_Type_ReferenceField;

		private DateTime transaction_Date_TimeField;

		private bool transaction_Date_TimeFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private LocationObjectType inventory_Site_ReferenceField;

		private WorkerObjectType created_By_ReferenceField;

		private LocationObjectType location_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private LocationObjectType[] to___From_Inventory_Site_ReferenceField;

		private WorkerObjectType requester_ReferenceField;

		private Purchase_ItemObjectType purchase_Item_ReferenceField;

		private Item_LotObjectType item_Lot_ReferenceField;

		private Item_SerialObjectType[] serial_Number_ReferenceField;

		private decimal transaction_Stocking_QuantityField;

		private bool transaction_Stocking_QuantityFieldSpecified;

		private Unique_IdentifierObjectType unit_of_Measure_CF_ReferenceField;

		private decimal total_Base_Quantity_On_HandField;

		private bool total_Base_Quantity_On_HandFieldSpecified;

		private decimal transaction_Unit_CostField;

		private bool transaction_Unit_CostFieldSpecified;

		private decimal inventory_Transaction_Cost_MarkupField;

		private bool inventory_Transaction_Cost_MarkupFieldSpecified;

		private decimal base_Unit_CostField;

		private bool base_Unit_CostFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal transaction_Base_Currency_Conversion_RateField;

		private bool transaction_Base_Currency_Conversion_RateFieldSpecified;

		private decimal prior_Average_CostField;

		private bool prior_Average_CostFieldSpecified;

		private decimal average_Cost_In_Base_CurrencyField;

		private bool average_Cost_In_Base_CurrencyFieldSpecified;

		private DateTime accounting_Date_for_Inventory_TransactionField;

		private bool accounting_Date_for_Inventory_TransactionFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Inventory_Transaction_TypeObjectType Inventory_Transaction_Type_Reference
		{
			get
			{
				return this.inventory_Transaction_Type_ReferenceField;
			}
			set
			{
				this.inventory_Transaction_Type_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Type_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public DateTime Transaction_Date_Time
		{
			get
			{
				return this.transaction_Date_TimeField;
			}
			set
			{
				this.transaction_Date_TimeField = value;
				this.RaisePropertyChanged("Transaction_Date_Time");
			}
		}

		[XmlIgnore]
		public bool Transaction_Date_TimeSpecified
		{
			get
			{
				return this.transaction_Date_TimeFieldSpecified;
			}
			set
			{
				this.transaction_Date_TimeFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Date_TimeSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public CompanyObjectType Company_Reference
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

		[XmlElement(Order = 3)]
		public LocationObjectType Inventory_Site_Reference
		{
			get
			{
				return this.inventory_Site_ReferenceField;
			}
			set
			{
				this.inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public WorkerObjectType Created_By_Reference
		{
			get
			{
				return this.created_By_ReferenceField;
			}
			set
			{
				this.created_By_ReferenceField = value;
				this.RaisePropertyChanged("Created_By_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement("To___From_Inventory_Site_Reference", Order = 7)]
		public LocationObjectType[] To___From_Inventory_Site_Reference
		{
			get
			{
				return this.to___From_Inventory_Site_ReferenceField;
			}
			set
			{
				this.to___From_Inventory_Site_ReferenceField = value;
				this.RaisePropertyChanged("To___From_Inventory_Site_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public WorkerObjectType Requester_Reference
		{
			get
			{
				return this.requester_ReferenceField;
			}
			set
			{
				this.requester_ReferenceField = value;
				this.RaisePropertyChanged("Requester_Reference");
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

		[XmlElement(Order = 10)]
		public Item_LotObjectType Item_Lot_Reference
		{
			get
			{
				return this.item_Lot_ReferenceField;
			}
			set
			{
				this.item_Lot_ReferenceField = value;
				this.RaisePropertyChanged("Item_Lot_Reference");
			}
		}

		[XmlElement("Serial_Number_Reference", Order = 11)]
		public Item_SerialObjectType[] Serial_Number_Reference
		{
			get
			{
				return this.serial_Number_ReferenceField;
			}
			set
			{
				this.serial_Number_ReferenceField = value;
				this.RaisePropertyChanged("Serial_Number_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Transaction_Stocking_Quantity
		{
			get
			{
				return this.transaction_Stocking_QuantityField;
			}
			set
			{
				this.transaction_Stocking_QuantityField = value;
				this.RaisePropertyChanged("Transaction_Stocking_Quantity");
			}
		}

		[XmlIgnore]
		public bool Transaction_Stocking_QuantitySpecified
		{
			get
			{
				return this.transaction_Stocking_QuantityFieldSpecified;
			}
			set
			{
				this.transaction_Stocking_QuantityFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Stocking_QuantitySpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Unique_IdentifierObjectType Unit_of_Measure_CF_Reference
		{
			get
			{
				return this.unit_of_Measure_CF_ReferenceField;
			}
			set
			{
				this.unit_of_Measure_CF_ReferenceField = value;
				this.RaisePropertyChanged("Unit_of_Measure_CF_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Total_Base_Quantity_On_Hand
		{
			get
			{
				return this.total_Base_Quantity_On_HandField;
			}
			set
			{
				this.total_Base_Quantity_On_HandField = value;
				this.RaisePropertyChanged("Total_Base_Quantity_On_Hand");
			}
		}

		[XmlIgnore]
		public bool Total_Base_Quantity_On_HandSpecified
		{
			get
			{
				return this.total_Base_Quantity_On_HandFieldSpecified;
			}
			set
			{
				this.total_Base_Quantity_On_HandFieldSpecified = value;
				this.RaisePropertyChanged("Total_Base_Quantity_On_HandSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public decimal Transaction_Unit_Cost
		{
			get
			{
				return this.transaction_Unit_CostField;
			}
			set
			{
				this.transaction_Unit_CostField = value;
				this.RaisePropertyChanged("Transaction_Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Transaction_Unit_CostSpecified
		{
			get
			{
				return this.transaction_Unit_CostFieldSpecified;
			}
			set
			{
				this.transaction_Unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Inventory_Transaction_Cost_Markup
		{
			get
			{
				return this.inventory_Transaction_Cost_MarkupField;
			}
			set
			{
				this.inventory_Transaction_Cost_MarkupField = value;
				this.RaisePropertyChanged("Inventory_Transaction_Cost_Markup");
			}
		}

		[XmlIgnore]
		public bool Inventory_Transaction_Cost_MarkupSpecified
		{
			get
			{
				return this.inventory_Transaction_Cost_MarkupFieldSpecified;
			}
			set
			{
				this.inventory_Transaction_Cost_MarkupFieldSpecified = value;
				this.RaisePropertyChanged("Inventory_Transaction_Cost_MarkupSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Base_Unit_Cost
		{
			get
			{
				return this.base_Unit_CostField;
			}
			set
			{
				this.base_Unit_CostField = value;
				this.RaisePropertyChanged("Base_Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Base_Unit_CostSpecified
		{
			get
			{
				return this.base_Unit_CostFieldSpecified;
			}
			set
			{
				this.base_Unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Base_Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public decimal Transaction_Base_Currency_Conversion_Rate
		{
			get
			{
				return this.transaction_Base_Currency_Conversion_RateField;
			}
			set
			{
				this.transaction_Base_Currency_Conversion_RateField = value;
				this.RaisePropertyChanged("Transaction_Base_Currency_Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool Transaction_Base_Currency_Conversion_RateSpecified
		{
			get
			{
				return this.transaction_Base_Currency_Conversion_RateFieldSpecified;
			}
			set
			{
				this.transaction_Base_Currency_Conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Base_Currency_Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Prior_Average_Cost
		{
			get
			{
				return this.prior_Average_CostField;
			}
			set
			{
				this.prior_Average_CostField = value;
				this.RaisePropertyChanged("Prior_Average_Cost");
			}
		}

		[XmlIgnore]
		public bool Prior_Average_CostSpecified
		{
			get
			{
				return this.prior_Average_CostFieldSpecified;
			}
			set
			{
				this.prior_Average_CostFieldSpecified = value;
				this.RaisePropertyChanged("Prior_Average_CostSpecified");
			}
		}

		[XmlElement(Order = 21)]
		public decimal Average_Cost_In_Base_Currency
		{
			get
			{
				return this.average_Cost_In_Base_CurrencyField;
			}
			set
			{
				this.average_Cost_In_Base_CurrencyField = value;
				this.RaisePropertyChanged("Average_Cost_In_Base_Currency");
			}
		}

		[XmlIgnore]
		public bool Average_Cost_In_Base_CurrencySpecified
		{
			get
			{
				return this.average_Cost_In_Base_CurrencyFieldSpecified;
			}
			set
			{
				this.average_Cost_In_Base_CurrencyFieldSpecified = value;
				this.RaisePropertyChanged("Average_Cost_In_Base_CurrencySpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 22)]
		public DateTime Accounting_Date_for_Inventory_Transaction
		{
			get
			{
				return this.accounting_Date_for_Inventory_TransactionField;
			}
			set
			{
				this.accounting_Date_for_Inventory_TransactionField = value;
				this.RaisePropertyChanged("Accounting_Date_for_Inventory_Transaction");
			}
		}

		[XmlIgnore]
		public bool Accounting_Date_for_Inventory_TransactionSpecified
		{
			get
			{
				return this.accounting_Date_for_Inventory_TransactionFieldSpecified;
			}
			set
			{
				this.accounting_Date_for_Inventory_TransactionFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_Date_for_Inventory_TransactionSpecified");
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
