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
	public class Consolidated_Invoice_Request_CriteriaType : INotifyPropertyChanged
	{
		private Document_StatusObjectType[] document_Status_ReferenceField;

		private Document_Payment_StatusObjectType[] document_Payment_Status_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private CustomerObjectType[] customer_ReferenceField;

		private Payment_TypeObjectType[] payment_Types_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime invoice_Date_On_or_AfterField;

		private bool invoice_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Date_On_or_BeforeField;

		private bool invoice_Date_On_or_BeforeFieldSpecified;

		private DateTime invoice_Due_Date_On_or_AfterField;

		private bool invoice_Due_Date_On_or_AfterFieldSpecified;

		private DateTime invoice_Due_Date_On_or_BeforeField;

		private bool invoice_Due_Date_On_or_BeforeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Document_Status_Reference", Order = 0)]
		public Document_StatusObjectType[] Document_Status_Reference
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

		[XmlElement("Document_Payment_Status_Reference", Order = 1)]
		public Document_Payment_StatusObjectType[] Document_Payment_Status_Reference
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

		[XmlElement("Customer_Reference", Order = 3)]
		public CustomerObjectType[] Customer_Reference
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

		[XmlElement("Payment_Types_Reference", Order = 4)]
		public Payment_TypeObjectType[] Payment_Types_Reference
		{
			get
			{
				return this.payment_Types_ReferenceField;
			}
			set
			{
				this.payment_Types_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Types_Reference");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(DataType = "date", Order = 7)]
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

		[XmlElement(DataType = "date", Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(DataType = "date", Order = 10)]
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
