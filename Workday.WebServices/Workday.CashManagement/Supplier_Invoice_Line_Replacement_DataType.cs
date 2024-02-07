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
	public class Supplier_Invoice_Line_Replacement_DataType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Line_IDField;

		private string line_OrderField;

		private CompanyObjectType intercompany_Affiliate_ReferenceField;

		private Procurement_ItemObjectType purchase_Item_ReferenceField;

		private string item_DescriptionField;

		private Purchase_Order_LineObjectType purchase_Order_Line_ReferenceField;

		private Supplier_Contract_LineObjectType supplier_Contract_Line_ReferenceField;

		private Customer_Invoice_LineObjectType customer_Invoice_Line_ReferenceField;

		private Spend_CategoryObjectType spend_Category_ReferenceField;

		private Address_ReferenceObjectType ship_To_Address_ReferenceField;

		private WorkerObjectType ship_To_Contact_ReferenceField;

		private Accounting_TreatmentObjectType accounting_Treatment_ReferenceField;

		private bool trackable_ItemField;

		private bool trackable_ItemFieldSpecified;

		private Tax_ApplicabilityObjectType tax_Applicability_ReferenceField;

		private Tax_CodeObjectType tax_Code_ReferenceField;

		private Tax_CodeObjectType withholding_Tax_Code_ReferenceField;

		private decimal quantityField;

		private bool quantityFieldSpecified;

		private decimal unit_CostField;

		private bool unit_CostFieldSpecified;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private decimal retention_AmountField;

		private bool retention_AmountFieldSpecified;

		private decimal payment_AmountField;

		private bool payment_AmountFieldSpecified;

		private DateTime budget_DateField;

		private bool budget_DateFieldSpecified;

		private bool prepaidField;

		private bool prepaidFieldSpecified;

		private string memoField;

		private Accounting_WorktagObjectType[] worktags_ReferenceField;

		private bool billableField;

		private bool billableFieldSpecified;

		private Supplier_Invoice_Line_Split_DataType[] supplier_Invoice_Split_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Line_ID
		{
			get
			{
				return this.supplier_Invoice_Line_IDField;
			}
			set
			{
				this.supplier_Invoice_Line_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Line_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Line_Order
		{
			get
			{
				return this.line_OrderField;
			}
			set
			{
				this.line_OrderField = value;
				this.RaisePropertyChanged("Line_Order");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Procurement_ItemObjectType Purchase_Item_Reference
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

		[XmlElement(Order = 4)]
		public string Item_Description
		{
			get
			{
				return this.item_DescriptionField;
			}
			set
			{
				this.item_DescriptionField = value;
				this.RaisePropertyChanged("Item_Description");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Customer_Invoice_LineObjectType Customer_Invoice_Line_Reference
		{
			get
			{
				return this.customer_Invoice_Line_ReferenceField;
			}
			set
			{
				this.customer_Invoice_Line_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Line_Reference");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public Address_ReferenceObjectType Ship_To_Address_Reference
		{
			get
			{
				return this.ship_To_Address_ReferenceField;
			}
			set
			{
				this.ship_To_Address_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Address_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public WorkerObjectType Ship_To_Contact_Reference
		{
			get
			{
				return this.ship_To_Contact_ReferenceField;
			}
			set
			{
				this.ship_To_Contact_ReferenceField = value;
				this.RaisePropertyChanged("Ship_To_Contact_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Accounting_TreatmentObjectType Accounting_Treatment_Reference
		{
			get
			{
				return this.accounting_Treatment_ReferenceField;
			}
			set
			{
				this.accounting_Treatment_ReferenceField = value;
				this.RaisePropertyChanged("Accounting_Treatment_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public bool Trackable_Item
		{
			get
			{
				return this.trackable_ItemField;
			}
			set
			{
				this.trackable_ItemField = value;
				this.RaisePropertyChanged("Trackable_Item");
			}
		}

		[XmlIgnore]
		public bool Trackable_ItemSpecified
		{
			get
			{
				return this.trackable_ItemFieldSpecified;
			}
			set
			{
				this.trackable_ItemFieldSpecified = value;
				this.RaisePropertyChanged("Trackable_ItemSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Tax_ApplicabilityObjectType Tax_Applicability_Reference
		{
			get
			{
				return this.tax_Applicability_ReferenceField;
			}
			set
			{
				this.tax_Applicability_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Applicability_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public Tax_CodeObjectType Tax_Code_Reference
		{
			get
			{
				return this.tax_Code_ReferenceField;
			}
			set
			{
				this.tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public Tax_CodeObjectType Withholding_Tax_Code_Reference
		{
			get
			{
				return this.withholding_Tax_Code_ReferenceField;
			}
			set
			{
				this.withholding_Tax_Code_ReferenceField = value;
				this.RaisePropertyChanged("Withholding_Tax_Code_Reference");
			}
		}

		[XmlElement(Order = 16)]
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

		[XmlElement(Order = 17)]
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

		[XmlElement(Order = 18)]
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

		[XmlElement(Order = 19)]
		public decimal Retention_Amount
		{
			get
			{
				return this.retention_AmountField;
			}
			set
			{
				this.retention_AmountField = value;
				this.RaisePropertyChanged("Retention_Amount");
			}
		}

		[XmlIgnore]
		public bool Retention_AmountSpecified
		{
			get
			{
				return this.retention_AmountFieldSpecified;
			}
			set
			{
				this.retention_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Retention_AmountSpecified");
			}
		}

		[XmlElement(Order = 20)]
		public decimal Payment_Amount
		{
			get
			{
				return this.payment_AmountField;
			}
			set
			{
				this.payment_AmountField = value;
				this.RaisePropertyChanged("Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Payment_AmountSpecified
		{
			get
			{
				return this.payment_AmountFieldSpecified;
			}
			set
			{
				this.payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Payment_AmountSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 21)]
		public DateTime Budget_Date
		{
			get
			{
				return this.budget_DateField;
			}
			set
			{
				this.budget_DateField = value;
				this.RaisePropertyChanged("Budget_Date");
			}
		}

		[XmlIgnore]
		public bool Budget_DateSpecified
		{
			get
			{
				return this.budget_DateFieldSpecified;
			}
			set
			{
				this.budget_DateFieldSpecified = value;
				this.RaisePropertyChanged("Budget_DateSpecified");
			}
		}

		[XmlElement(Order = 22)]
		public bool Prepaid
		{
			get
			{
				return this.prepaidField;
			}
			set
			{
				this.prepaidField = value;
				this.RaisePropertyChanged("Prepaid");
			}
		}

		[XmlIgnore]
		public bool PrepaidSpecified
		{
			get
			{
				return this.prepaidFieldSpecified;
			}
			set
			{
				this.prepaidFieldSpecified = value;
				this.RaisePropertyChanged("PrepaidSpecified");
			}
		}

		[XmlElement(Order = 23)]
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

		[XmlElement("Worktags_Reference", Order = 24)]
		public Accounting_WorktagObjectType[] Worktags_Reference
		{
			get
			{
				return this.worktags_ReferenceField;
			}
			set
			{
				this.worktags_ReferenceField = value;
				this.RaisePropertyChanged("Worktags_Reference");
			}
		}

		[XmlElement(Order = 25)]
		public bool Billable
		{
			get
			{
				return this.billableField;
			}
			set
			{
				this.billableField = value;
				this.RaisePropertyChanged("Billable");
			}
		}

		[XmlIgnore]
		public bool BillableSpecified
		{
			get
			{
				return this.billableFieldSpecified;
			}
			set
			{
				this.billableFieldSpecified = value;
				this.RaisePropertyChanged("BillableSpecified");
			}
		}

		[XmlElement("Supplier_Invoice_Split_Line_Data", Order = 26)]
		public Supplier_Invoice_Line_Split_DataType[] Supplier_Invoice_Split_Line_Data
		{
			get
			{
				return this.supplier_Invoice_Split_Line_DataField;
			}
			set
			{
				this.supplier_Invoice_Split_Line_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Split_Line_Data");
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
