using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Usage_Based_Transaction_DataType : INotifyPropertyChanged
	{
		private string usage_Based_Transaction_IDField;

		private bool submit_for_ReviewField;

		private bool submit_for_ReviewFieldSpecified;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Customer_Contract_LineObjectType contract_Line_ReferenceField;

		private CustomerObjectType customer_ReferenceField;

		private Sales_ItemObjectType sales_Item_ReferenceField;

		private DateTime revenue_Start_DateField;

		private bool revenue_Start_DateFieldSpecified;

		private DateTime revenue_End_DateField;

		private bool revenue_End_DateFieldSpecified;

		private string descriptionField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal rateField;

		private bool rateFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] default_Worktags_ReferenceField;

		private CustomerObjectType shipTo_Customer_ReferenceField;

		private Address_ReferenceObjectType shipTo_Address_ReferenceField;

		private Address_Information_DataType[] shipTo_Address_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Usage_Based_Transaction_ID
		{
			get
			{
				return this.usage_Based_Transaction_IDField;
			}
			set
			{
				this.usage_Based_Transaction_IDField = value;
				this.RaisePropertyChanged("Usage_Based_Transaction_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Submit_for_Review
		{
			get
			{
				return this.submit_for_ReviewField;
			}
			set
			{
				this.submit_for_ReviewField = value;
				this.RaisePropertyChanged("Submit_for_Review");
			}
		}

		[XmlIgnore]
		public bool Submit_for_ReviewSpecified
		{
			get
			{
				return this.submit_for_ReviewFieldSpecified;
			}
			set
			{
				this.submit_for_ReviewFieldSpecified = value;
				this.RaisePropertyChanged("Submit_for_ReviewSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlIgnore]
		public bool Transaction_DateSpecified
		{
			get
			{
				return this.transaction_DateFieldSpecified;
			}
			set
			{
				this.transaction_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public Customer_Contract_LineObjectType Contract_Line_Reference
		{
			get
			{
				return this.contract_Line_ReferenceField;
			}
			set
			{
				this.contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public CustomerObjectType Customer_Reference
		{
			get
			{
				return this.customer_ReferenceField;
			}
			set
			{
				this.customer_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Sales_ItemObjectType Sales_Item_Reference
		{
			get
			{
				return this.sales_Item_ReferenceField;
			}
			set
			{
				this.sales_Item_ReferenceField = value;
				this.RaisePropertyChanged("Sales_Item_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Revenue_Start_Date
		{
			get
			{
				return this.revenue_Start_DateField;
			}
			set
			{
				this.revenue_Start_DateField = value;
				this.RaisePropertyChanged("Revenue_Start_Date");
			}
		}

		[XmlIgnore]
		public bool Revenue_Start_DateSpecified
		{
			get
			{
				return this.revenue_Start_DateFieldSpecified;
			}
			set
			{
				this.revenue_Start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Revenue_Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Revenue_End_Date
		{
			get
			{
				return this.revenue_End_DateField;
			}
			set
			{
				this.revenue_End_DateField = value;
				this.RaisePropertyChanged("Revenue_End_Date");
			}
		}

		[XmlIgnore]
		public bool Revenue_End_DateSpecified
		{
			get
			{
				return this.revenue_End_DateFieldSpecified;
			}
			set
			{
				this.revenue_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Revenue_End_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Quantity
		{
			get
			{
				return this.quantityField;
			}
			set
			{
				this.quantityField = value;
				this.RaisePropertyChanged("Quantity");
			}
		}

		[XmlIgnore]
		public bool QuantitySpecified
		{
			get
			{
				return this.quantityFieldSpecified;
			}
			set
			{
				this.quantityFieldSpecified = value;
				this.RaisePropertyChanged("QuantitySpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public decimal Rate
		{
			get
			{
				return this.rateField;
			}
			set
			{
				this.rateField = value;
				this.RaisePropertyChanged("Rate");
			}
		}

		[XmlIgnore]
		public bool RateSpecified
		{
			get
			{
				return this.rateFieldSpecified;
			}
			set
			{
				this.rateFieldSpecified = value;
				this.RaisePropertyChanged("RateSpecified");
			}
		}

		[XmlElement(Order = 13)]
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

		[XmlElement("Default_Worktags_Reference", Order = 14)]
		public Audited_Accounting_WorktagObjectType[] Default_Worktags_Reference
		{
			get
			{
				return this.default_Worktags_ReferenceField;
			}
			set
			{
				this.default_Worktags_ReferenceField = value;
				this.RaisePropertyChanged("Default_Worktags_Reference");
			}
		}

		[XmlElement("Ship-To_Customer_Reference", Order = 15)]
		public CustomerObjectType ShipTo_Customer_Reference
		{
			get
			{
				return this.shipTo_Customer_ReferenceField;
			}
			set
			{
				this.shipTo_Customer_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Customer_Reference");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 16)]
		public Address_ReferenceObjectType ShipTo_Address_Reference
		{
			get
			{
				return this.shipTo_Address_ReferenceField;
			}
			set
			{
				this.shipTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("ShipTo_Address_Reference");
			}
		}

		[XmlArray("Ship-To_Address_Data", Order = 17), XmlArrayItem("Ship-To_Address_Data", typeof(Address_Information_DataType), IsNullable = false)]
		public Address_Information_DataType[] ShipTo_Address_Data
		{
			get
			{
				return this.shipTo_Address_DataField;
			}
			set
			{
				this.shipTo_Address_DataField = value;
				this.RaisePropertyChanged("ShipTo_Address_Data");
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
