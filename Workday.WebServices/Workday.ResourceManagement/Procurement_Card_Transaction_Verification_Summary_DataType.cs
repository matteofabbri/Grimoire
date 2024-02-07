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
	public class Procurement_Card_Transaction_Verification_Summary_DataType : INotifyPropertyChanged
	{
		private Credit_Card_TransactionObjectType credit_Card_Transaction_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private string charge_DescriptionField;

		private SupplierObjectType supplier_ReferenceField;

		private Purchase_OrderObjectType purchase_Order_ReferenceField;

		private Supplier_ContractObjectType supplier_Contract_ReferenceField;

		private decimal extended_AmountField;

		private bool extended_AmountFieldSpecified;

		private CurrencyObjectType transaction_Currency_ReferenceField;

		private bool sales_Tax_CollectedField;

		private bool sales_Tax_CollectedFieldSpecified;

		private Financials_Attachment_DataType[] financial_Attachment_DataField;

		private Procurement_Card_Transaction_Verification_Line_DataType[] procurement_Card_Transaction_Verification_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Credit_Card_TransactionObjectType Credit_Card_Transaction_Reference
		{
			get
			{
				return this.credit_Card_Transaction_ReferenceField;
			}
			set
			{
				this.credit_Card_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Reference");
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

		[XmlElement(Order = 2)]
		public string Charge_Description
		{
			get
			{
				return this.charge_DescriptionField;
			}
			set
			{
				this.charge_DescriptionField = value;
				this.RaisePropertyChanged("Charge_Description");
			}
		}

		[XmlElement(Order = 3)]
		public SupplierObjectType Supplier_Reference
		{
			get
			{
				return this.supplier_ReferenceField;
			}
			set
			{
				this.supplier_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Purchase_OrderObjectType Purchase_Order_Reference
		{
			get
			{
				return this.purchase_Order_ReferenceField;
			}
			set
			{
				this.purchase_Order_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Order_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Supplier_ContractObjectType Supplier_Contract_Reference
		{
			get
			{
				return this.supplier_Contract_ReferenceField;
			}
			set
			{
				this.supplier_Contract_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Contract_Reference");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public CurrencyObjectType Transaction_Currency_Reference
		{
			get
			{
				return this.transaction_Currency_ReferenceField;
			}
			set
			{
				this.transaction_Currency_ReferenceField = value;
				this.RaisePropertyChanged("Transaction_Currency_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public bool Sales_Tax_Collected
		{
			get
			{
				return this.sales_Tax_CollectedField;
			}
			set
			{
				this.sales_Tax_CollectedField = value;
				this.RaisePropertyChanged("Sales_Tax_Collected");
			}
		}

		[XmlIgnore]
		public bool Sales_Tax_CollectedSpecified
		{
			get
			{
				return this.sales_Tax_CollectedFieldSpecified;
			}
			set
			{
				this.sales_Tax_CollectedFieldSpecified = value;
				this.RaisePropertyChanged("Sales_Tax_CollectedSpecified");
			}
		}

		[XmlElement("Financial_Attachment_Data", Order = 9)]
		public Financials_Attachment_DataType[] Financial_Attachment_Data
		{
			get
			{
				return this.financial_Attachment_DataField;
			}
			set
			{
				this.financial_Attachment_DataField = value;
				this.RaisePropertyChanged("Financial_Attachment_Data");
			}
		}

		[XmlElement("Procurement_Card_Transaction_Verification_Line_Data", Order = 10)]
		public Procurement_Card_Transaction_Verification_Line_DataType[] Procurement_Card_Transaction_Verification_Line_Data
		{
			get
			{
				return this.procurement_Card_Transaction_Verification_Line_DataField;
			}
			set
			{
				this.procurement_Card_Transaction_Verification_Line_DataField = value;
				this.RaisePropertyChanged("Procurement_Card_Transaction_Verification_Line_Data");
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
