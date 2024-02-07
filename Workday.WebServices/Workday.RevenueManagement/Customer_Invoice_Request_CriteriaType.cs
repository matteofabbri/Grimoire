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
	public class Customer_Invoice_Request_CriteriaType : INotifyPropertyChanged
	{
		private object itemField;

		private CustomerObjectType[] customers_ReferenceField;

		private string invoice_or_Invoice_Adjustment_NumberField;

		private DateTime invoice_Date_On_or_AfterField;

		private bool invoice_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Date_On_or_BeforeField;

		private bool invoice_Date_On_or_BeforeFieldSpecified;

		private DateTime invoice_Due_Date_On_or_AfterField;

		private bool invoice_Due_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Due_Date_On_or_BeforeField;

		private bool invoice_Due_Date_On_or_BeforeFieldSpecified;

		private DateTime accounting_DateField;

		private bool accounting_DateFieldSpecified;

		private WorkerObjectType[] creating_Worker_ReferenceField;

		private WorkerObjectType[] approving_Worker_ReferenceField;

		private CustomerObjectType[] customer_Hierarchy_ReferenceField;

		private Business_Entity_Status_ValueObjectType[] customer_Status_ReferenceField;

		private Document_Payment_StatusObjectType[] payment_Status_ReferenceField;

		private Payment_TypeObjectType[] payment_Type_ReferenceField;

		private bool intercompany_InvoiceField;

		private bool intercompany_InvoiceFieldSpecified;

		private Document_StatusObjectType[] invoice_Status_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Company_Reference", typeof(CompanyObjectType), Order = 0), XmlElement("Event_Reference", typeof(EventObjectType), Order = 0)]
		public object Item
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

		[XmlElement("Customers_Reference", Order = 1)]
		public CustomerObjectType[] Customers_Reference
		{
			get
			{
				return this.customers_ReferenceField;
			}
			set
			{
				this.customers_ReferenceField = value;
				this.RaisePropertyChanged("Customers_Reference");
			}
		}

		[XmlElement(Order = 2)]
		public string Invoice_or_Invoice_Adjustment_Number
		{
			get
			{
				return this.invoice_or_Invoice_Adjustment_NumberField;
			}
			set
			{
				this.invoice_or_Invoice_Adjustment_NumberField = value;
				this.RaisePropertyChanged("Invoice_or_Invoice_Adjustment_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Invoice_Date_On_or_After
		{
			get
			{
				return this.invoice_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Invoice_Date_On_or_Before
		{
			get
			{
				return this.invoice_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Invoice_Due_Date_On_or_After
		{
			get
			{
				return this.invoice_Due_Date_On_or_AfterField;
			}
			set
			{
				this.invoice_Due_Date_On_or_AfterField = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_After");
			}
		}

		[XmlIgnore]
		public bool Invoice_Due_Date_On_or_AfterSpecified
		{
			get
			{
				return this.invoice_Due_Date_On_or_AfterFieldSpecified;
			}
			set
			{
				this.invoice_Due_Date_On_or_AfterFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_AfterSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Invoice_Due_Date_On_or_Before
		{
			get
			{
				return this.invoice_Due_Date_On_or_BeforeField;
			}
			set
			{
				this.invoice_Due_Date_On_or_BeforeField = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_Before");
			}
		}

		[XmlIgnore]
		public bool Invoice_Due_Date_On_or_BeforeSpecified
		{
			get
			{
				return this.invoice_Due_Date_On_or_BeforeFieldSpecified;
			}
			set
			{
				this.invoice_Due_Date_On_or_BeforeFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Due_Date_On_or_BeforeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 7)]
		public DateTime Accounting_Date
		{
			get
			{
				return this.accounting_DateField;
			}
			set
			{
				this.accounting_DateField = value;
				this.RaisePropertyChanged("Accounting_Date");
			}
		}

		[XmlIgnore]
		public bool Accounting_DateSpecified
		{
			get
			{
				return this.accounting_DateFieldSpecified;
			}
			set
			{
				this.accounting_DateFieldSpecified = value;
				this.RaisePropertyChanged("Accounting_DateSpecified");
			}
		}

		[XmlElement("Creating_Worker_Reference", Order = 8)]
		public WorkerObjectType[] Creating_Worker_Reference
		{
			get
			{
				return this.creating_Worker_ReferenceField;
			}
			set
			{
				this.creating_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Creating_Worker_Reference");
			}
		}

		[XmlElement("Approving_Worker_Reference", Order = 9)]
		public WorkerObjectType[] Approving_Worker_Reference
		{
			get
			{
				return this.approving_Worker_ReferenceField;
			}
			set
			{
				this.approving_Worker_ReferenceField = value;
				this.RaisePropertyChanged("Approving_Worker_Reference");
			}
		}

		[XmlElement("Customer_Hierarchy_Reference", Order = 10)]
		public CustomerObjectType[] Customer_Hierarchy_Reference
		{
			get
			{
				return this.customer_Hierarchy_ReferenceField;
			}
			set
			{
				this.customer_Hierarchy_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Hierarchy_Reference");
			}
		}

		[XmlElement("Customer_Status_Reference", Order = 11)]
		public Business_Entity_Status_ValueObjectType[] Customer_Status_Reference
		{
			get
			{
				return this.customer_Status_ReferenceField;
			}
			set
			{
				this.customer_Status_ReferenceField = value;
				this.RaisePropertyChanged("Customer_Status_Reference");
			}
		}

		[XmlElement("Payment_Status_Reference", Order = 12)]
		public Document_Payment_StatusObjectType[] Payment_Status_Reference
		{
			get
			{
				return this.payment_Status_ReferenceField;
			}
			set
			{
				this.payment_Status_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Status_Reference");
			}
		}

		[XmlElement("Payment_Type_Reference", Order = 13)]
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

		[XmlElement(Order = 14)]
		public bool Intercompany_Invoice
		{
			get
			{
				return this.intercompany_InvoiceField;
			}
			set
			{
				this.intercompany_InvoiceField = value;
				this.RaisePropertyChanged("Intercompany_Invoice");
			}
		}

		[XmlIgnore]
		public bool Intercompany_InvoiceSpecified
		{
			get
			{
				return this.intercompany_InvoiceFieldSpecified;
			}
			set
			{
				this.intercompany_InvoiceFieldSpecified = value;
				this.RaisePropertyChanged("Intercompany_InvoiceSpecified");
			}
		}

		[XmlElement("Invoice_Status_Reference", Order = 15)]
		public Document_StatusObjectType[] Invoice_Status_Reference
		{
			get
			{
				return this.invoice_Status_ReferenceField;
			}
			set
			{
				this.invoice_Status_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Status_Reference");
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
