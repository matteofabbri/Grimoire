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
	public class Consolidated_Invoice_WWS_DataType : INotifyPropertyChanged
	{
		private string consolidated_Invoice_IDField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private Address_ReferenceObjectType billTo_Address_ReferenceField;

		private Business_Entity_ContactObjectType[] billTo_Contact_ReferenceField;

		private string invoice_NumberField;

		private DateTime invoice_DateField;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private Document_Payment_StatusObjectType document_Payment_Status_ReferenceField;

		private Document_StatusObjectType document_Status_ReferenceField;

		private decimal amount_DueField;

		private bool amount_DueFieldSpecified;

		private string memoField;

		private decimal net_Invoice_AmountField;

		private bool net_Invoice_AmountFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private decimal total_Invoice_AmountField;

		private bool total_Invoice_AmountFieldSpecified;

		private decimal withholding_Tax_AmountField;

		private bool withholding_Tax_AmountFieldSpecified;

		private Customer_InvoiceObjectType[] customer_Invoice_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Consolidated_Invoice_ID
		{
			get
			{
				return this.consolidated_Invoice_IDField;
			}
			set
			{
				this.consolidated_Invoice_IDField = value;
				this.RaisePropertyChanged("Consolidated_Invoice_ID");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public Billable_EntityObjectType Customer_Reference
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

		[XmlElement("Bill-To_Address_Reference", Order = 4)]
		public Address_ReferenceObjectType BillTo_Address_Reference
		{
			get
			{
				return this.billTo_Address_ReferenceField;
			}
			set
			{
				this.billTo_Address_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Address_Reference");
			}
		}

		[XmlElement("Bill-To_Contact_Reference", Order = 5)]
		public Business_Entity_ContactObjectType[] BillTo_Contact_Reference
		{
			get
			{
				return this.billTo_Contact_ReferenceField;
			}
			set
			{
				this.billTo_Contact_ReferenceField = value;
				this.RaisePropertyChanged("BillTo_Contact_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public string Invoice_Number
		{
			get
			{
				return this.invoice_NumberField;
			}
			set
			{
				this.invoice_NumberField = value;
				this.RaisePropertyChanged("Invoice_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Invoice_Date
		{
			get
			{
				return this.invoice_DateField;
			}
			set
			{
				this.invoice_DateField = value;
				this.RaisePropertyChanged("Invoice_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Due_Date
		{
			get
			{
				return this.due_DateField;
			}
			set
			{
				this.due_DateField = value;
				this.RaisePropertyChanged("Due_Date");
			}
		}

		[XmlIgnore]
		public bool Due_DateSpecified
		{
			get
			{
				return this.due_DateFieldSpecified;
			}
			set
			{
				this.due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Due_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public Payment_TermsObjectType Payment_Terms_Reference
		{
			get
			{
				return this.payment_Terms_ReferenceField;
			}
			set
			{
				this.payment_Terms_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Terms_Reference");
			}
		}

		[XmlElement("Payment_Type_Reference", Order = 10)]
		public Payment_TypeObjectType[] Payment_Type_Reference
		{
			get
			{
				return this.payment_Type_ReferenceField;
			}
			set
			{
				this.payment_Type_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Type_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public Document_Payment_StatusObjectType Document_Payment_Status_Reference
		{
			get
			{
				return this.document_Payment_Status_ReferenceField;
			}
			set
			{
				this.document_Payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Payment_Status_Reference");
			}
		}

		[XmlElement(Order = 12)]
		public Document_StatusObjectType Document_Status_Reference
		{
			get
			{
				return this.document_Status_ReferenceField;
			}
			set
			{
				this.document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Document_Status_Reference");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Amount_Due
		{
			get
			{
				return this.amount_DueField;
			}
			set
			{
				this.amount_DueField = value;
				this.RaisePropertyChanged("Amount_Due");
			}
		}

		[XmlIgnore]
		public bool Amount_DueSpecified
		{
			get
			{
				return this.amount_DueFieldSpecified;
			}
			set
			{
				this.amount_DueFieldSpecified = value;
				this.RaisePropertyChanged("Amount_DueSpecified");
			}
		}

		[XmlElement(Order = 14)]
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

		[XmlElement(Order = 15)]
		public decimal Net_Invoice_Amount
		{
			get
			{
				return this.net_Invoice_AmountField;
			}
			set
			{
				this.net_Invoice_AmountField = value;
				this.RaisePropertyChanged("Net_Invoice_Amount");
			}
		}

		[XmlIgnore]
		public bool Net_Invoice_AmountSpecified
		{
			get
			{
				return this.net_Invoice_AmountFieldSpecified;
			}
			set
			{
				this.net_Invoice_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Net_Invoice_AmountSpecified");
			}
		}

		[XmlElement(Order = 16)]
		public decimal Tax_Amount
		{
			get
			{
				return this.tax_AmountField;
			}
			set
			{
				this.tax_AmountField = value;
				this.RaisePropertyChanged("Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Tax_AmountSpecified
		{
			get
			{
				return this.tax_AmountFieldSpecified;
			}
			set
			{
				this.tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Tax_AmountSpecified");
			}
		}

		[XmlElement(Order = 17)]
		public decimal Total_Invoice_Amount
		{
			get
			{
				return this.total_Invoice_AmountField;
			}
			set
			{
				this.total_Invoice_AmountField = value;
				this.RaisePropertyChanged("Total_Invoice_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Invoice_AmountSpecified
		{
			get
			{
				return this.total_Invoice_AmountFieldSpecified;
			}
			set
			{
				this.total_Invoice_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Invoice_AmountSpecified");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Withholding_Tax_Amount
		{
			get
			{
				return this.withholding_Tax_AmountField;
			}
			set
			{
				this.withholding_Tax_AmountField = value;
				this.RaisePropertyChanged("Withholding_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Withholding_Tax_AmountSpecified
		{
			get
			{
				return this.withholding_Tax_AmountFieldSpecified;
			}
			set
			{
				this.withholding_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Withholding_Tax_AmountSpecified");
			}
		}

		[XmlElement("Customer_Invoice_Reference", Order = 19)]
		public Customer_InvoiceObjectType[] Customer_Invoice_Reference
		{
			get
			{
				return this.customer_Invoice_ReferenceField;
			}
			set
			{
				this.customer_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Invoice_Reference");
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
