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
	public class Procurement_Card_Transaction_Verification_Line_DataType : INotifyPropertyChanged
	{
		private string automatic_OrderField;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Purchase_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private Supplier_Contract_LineObjectType supplier_Contract_Line_ReferenceField;

		private Procurement_ItemObjectType item_ReferenceField;

		private string line_Item_DescriptionField;

		private Accounting_CategoryObjectType spend_Category_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private Unit_of_MeasureObjectType unit_of_Measure_ReferenceField;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private decimal conversion_RateField;

		private bool conversion_RateFieldSpecified;

		private decimal credit_Card_AmountField;

		private bool credit_Card_AmountFieldSpecified;

		private decimal converted_AmountField;

		private bool converted_AmountFieldSpecified;

		private CurrencyObjectType credit_Card_Currency_ReferenceField;

		private string memoField;

		private Taggable_TypeObjectType taggable_Type_ReferenceField;

		private Audited_Accounting_WorktagObjectType[] worktag_ReferenceField;

		private Unique_IdentifierObjectType distribution_Method_ReferenceField;

		private Business_Document_Line_Split_DataType[] business_Document_Line_Split_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Automatic_Order
		{
			get
			{
				return this.automatic_OrderField;
			}
			set
			{
				this.automatic_OrderField = value;
				this.RaisePropertyChanged("Automatic_Order");
			}
		}

		[XmlElement(Order = 1)]
		public CompanyObjectType Intercompany_Affiliate_Reference
		{
			get
			{
				return this.intercompany_Affiliate_ReferenceField;
			}
			set
			{
				this.intercompany_Affiliate_ReferenceField = value;
				this.RaisePropertyChanged("Intercompany_Affiliate_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public Purchase_Order_LineObjectType Purchase_Order_Line_Reference
		{
			get
			{
				return this.purchase_Order_Line_ReferenceField;
			}
			set
			{
				this.purchase_Order_Line_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Line_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Supplier_Contract_LineObjectType Supplier_Contract_Line_Reference
		{
			get
			{
				return this.supplier_Contract_Line_ReferenceField;
			}
			set
			{
				this.supplier_Contract_Line_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Line_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Procurement_ItemObjectType Item_Reference
		{
			get
			{
				return this.item_ReferenceField;
			}
			set
			{
				this.item_ReferenceField = value;
				this.RaisePropertyChanged("Item_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public string Line_Item_Description
		{
			get
			{
				return this.line_Item_DescriptionField;
			}
			set
			{
				this.line_Item_DescriptionField = value;
				this.RaisePropertyChanged("Line_Item_Description");
			}
		}

		[XmlElement(Order = 6)]
		public Accounting_CategoryObjectType Spend_Category_Reference
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public decimal Unit_Cost
		{
			get
			{
				return this.unit_CostField;
			}
			set
			{
				this.unit_CostField = value;
				this.RaisePropertyChanged("Unit_Cost");
			}
		}

		[XmlIgnore]
		public bool Unit_CostSpecified
		{
			get
			{
				return this.unit_CostFieldSpecified;
			}
			set
			{
				this.unit_CostFieldSpecified = value;
				this.RaisePropertyChanged("Unit_CostSpecified");
			}
		}

		[XmlElement(Order = 10)]
		public decimal Extended_Amount
		{
			get
			{
				return this.extended_AmountField;
			}
			set
			{
				this.extended_AmountField = value;
				this.RaisePropertyChanged("Extended_Amount");
			}
		}

		[XmlIgnore]
		public bool Extended_AmountSpecified
		{
			get
			{
				return this.extended_AmountFieldSpecified;
			}
			set
			{
				this.extended_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Extended_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public decimal Conversion_Rate
		{
			get
			{
				return this.conversion_RateField;
			}
			set
			{
				this.conversion_RateField = value;
				this.RaisePropertyChanged("Conversion_Rate");
			}
		}

		[XmlIgnore]
		public bool Conversion_RateSpecified
		{
			get
			{
				return this.conversion_RateFieldSpecified;
			}
			set
			{
				this.conversion_RateFieldSpecified = value;
				this.RaisePropertyChanged("Conversion_RateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Credit_Card_Amount
		{
			get
			{
				return this.credit_Card_AmountField;
			}
			set
			{
				this.credit_Card_AmountField = value;
				this.RaisePropertyChanged("Credit_Card_Amount");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_AmountSpecified
		{
			get
			{
				return this.credit_Card_AmountFieldSpecified;
			}
			set
			{
				this.credit_Card_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_AmountSpecified");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Converted_Amount
		{
			get
			{
				return this.converted_AmountField;
			}
			set
			{
				this.converted_AmountField = value;
				this.RaisePropertyChanged("Converted_Amount");
			}
		}

		[XmlIgnore]
		public bool Converted_AmountSpecified
		{
			get
			{
				return this.converted_AmountFieldSpecified;
			}
			set
			{
				this.converted_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Converted_AmountSpecified");
			}
		}

		[XmlElement(Order = 15)]
		public CurrencyObjectType Credit_Card_Currency_Reference
		{
			get
			{
				return this.credit_Card_Currency_ReferenceField;
			}
			set
			{
				this.credit_Card_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Currency_Reference");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
		public Taggable_TypeObjectType Taggable_Type_Reference
		{
			get
			{
				return this.taggable_Type_ReferenceField;
			}
			set
			{
				this.taggable_Type_ReferenceField = value;
				this.RaisePropertyChanged("Taggable_Type_Reference");
			}
		}

		[XmlElement("Worktag_Reference", Order = 18)]
		public Audited_Accounting_WorktagObjectType[] Worktag_Reference
		{
			get
			{
				return this.worktag_ReferenceField;
			}
			set
			{
				this.worktag_ReferenceField = value;
				this.RaisePropertyChanged("Worktag_Reference");
			}
		}

		[XmlElement(Order = 19)]
		public Unique_IdentifierObjectType Distribution_Method_Reference
		{
			get
			{
				return this.distribution_Method_ReferenceField;
			}
			set
			{
				this.distribution_Method_ReferenceField = value;
				this.RaisePropertyChanged("Distribution_Method_Reference");
			}
		}

		[XmlElement("Business_Document_Line_Split_Data", Order = 20)]
		public Business_Document_Line_Split_DataType[] Business_Document_Line_Split_Data
		{
			get
			{
				return this.business_Document_Line_Split_DataField;
			}
			set
			{
				this.business_Document_Line_Split_DataField = value;
				this.RaisePropertyChanged("Business_Document_Line_Split_Data");
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
