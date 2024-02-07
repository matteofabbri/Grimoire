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
	public class Supplier_Invoice_Request_Data_OutboundType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Request_IDField;

		private string invoice_Request_NumberField;

		private Document_StatusObjectType invoice_Request_Document_Status_ReferenceField;

		private DateTime invoice_DateField;

		private bool invoice_DateFieldSpecified;

		private DateTime canceled_On_DateField;

		private bool canceled_On_DateFieldSpecified;

		private WorkerObjectType requester_ReferenceField;

		private CompanyObjectType company_ReferenceField;

		private Resource_ProviderObjectType supplier_ReferenceField;

		private Supplier_ConnectionObjectType supplier_Connection_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private string supplier_Reference_NumberField;

		private decimal invoice_Request_Total_AmountField;

		private bool invoice_Request_Total_AmountFieldSpecified;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private string memoField;

		private Supplier_InvoiceObjectType supplier_Invoice_ReferenceField;

		private Financials_Attachment_DataType[] attachment_DataField;

		private Supplier_Invoice_Request_Line_Data_OutboundType[] supplier_Invoice_Request_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Supplier_Invoice_Request_ID
		{
			get
			{
				return this.supplier_Invoice_Request_IDField;
			}
			set
			{
				this.supplier_Invoice_Request_IDField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Invoice_Request_Number
		{
			get
			{
				return this.invoice_Request_NumberField;
			}
			set
			{
				this.invoice_Request_NumberField = value;
				this.RaisePropertyChanged("Invoice_Request_Number");
			}
		}

		[XmlElement(Order = 2)]
		public Document_StatusObjectType Invoice_Request_Document_Status_Reference
		{
			get
			{
				return this.invoice_Request_Document_Status_ReferenceField;
			}
			set
			{
				this.invoice_Request_Document_Status_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Request_Document_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
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

		[XmlIgnore]
		public bool Invoice_DateSpecified
		{
			get
			{
				return this.invoice_DateFieldSpecified;
			}
			set
			{
				this.invoice_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Canceled_On_Date
		{
			get
			{
				return this.canceled_On_DateField;
			}
			set
			{
				this.canceled_On_DateField = value;
				this.RaisePropertyChanged("Canceled_On_Date");
			}
		}

		[XmlIgnore]
		public bool Canceled_On_DateSpecified
		{
			get
			{
				return this.canceled_On_DateFieldSpecified;
			}
			set
			{
				this.canceled_On_DateFieldSpecified = value;
				this.RaisePropertyChanged("Canceled_On_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public Resource_ProviderObjectType Supplier_Reference
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

		[XmlElement(Order = 8)]
		public Supplier_ConnectionObjectType Supplier_Connection_Reference
		{
			get
			{
				return this.supplier_Connection_ReferenceField;
			}
			set
			{
				this.supplier_Connection_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Connection_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public decimal Control_Total_Amount
		{
			get
			{
				return this.control_Total_AmountField;
			}
			set
			{
				this.control_Total_AmountField = value;
				this.RaisePropertyChanged("Control_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Control_Total_AmountSpecified
		{
			get
			{
				return this.control_Total_AmountFieldSpecified;
			}
			set
			{
				this.control_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Control_Total_AmountSpecified");
			}
		}

		[XmlElement(Order = 11)]
		public string Supplier_Reference_Number
		{
			get
			{
				return this.supplier_Reference_NumberField;
			}
			set
			{
				this.supplier_Reference_NumberField = value;
				this.RaisePropertyChanged("Supplier_Reference_Number");
			}
		}

		[XmlElement(Order = 12)]
		public decimal Invoice_Request_Total_Amount
		{
			get
			{
				return this.invoice_Request_Total_AmountField;
			}
			set
			{
				this.invoice_Request_Total_AmountField = value;
				this.RaisePropertyChanged("Invoice_Request_Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Invoice_Request_Total_AmountSpecified
		{
			get
			{
				return this.invoice_Request_Total_AmountFieldSpecified;
			}
			set
			{
				this.invoice_Request_Total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Request_Total_AmountSpecified");
			}
		}

		[XmlElement("Ship-To_Address_Reference", Order = 13)]
		public Unique_IdentifierObjectType ShipTo_Address_Reference
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

		[XmlElement(Order = 14)]
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

		[XmlElement(DataType = "date", Order = 15)]
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
		public Payment_Handling_InstructionObjectType Handling_Code_Reference
		{
			get
			{
				return this.handling_Code_ReferenceField;
			}
			set
			{
				this.handling_Code_ReferenceField = value;
				this.RaisePropertyChanged("Handling_Code_Reference");
			}
		}

		[XmlElement(Order = 18)]
		public decimal Freight_Amount
		{
			get
			{
				return this.freight_AmountField;
			}
			set
			{
				this.freight_AmountField = value;
				this.RaisePropertyChanged("Freight_Amount");
			}
		}

		[XmlIgnore]
		public bool Freight_AmountSpecified
		{
			get
			{
				return this.freight_AmountFieldSpecified;
			}
			set
			{
				this.freight_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Freight_AmountSpecified");
			}
		}

		[XmlElement(Order = 19)]
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

		[XmlElement(Order = 20)]
		public Supplier_InvoiceObjectType Supplier_Invoice_Reference
		{
			get
			{
				return this.supplier_Invoice_ReferenceField;
			}
			set
			{
				this.supplier_Invoice_ReferenceField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Reference");
			}
		}

		[XmlElement("Attachment_Data", Order = 21)]
		public Financials_Attachment_DataType[] Attachment_Data
		{
			get
			{
				return this.attachment_DataField;
			}
			set
			{
				this.attachment_DataField = value;
				this.RaisePropertyChanged("Attachment_Data");
			}
		}

		[XmlElement("Supplier_Invoice_Request_Line_Data", Order = 22)]
		public Supplier_Invoice_Request_Line_Data_OutboundType[] Supplier_Invoice_Request_Line_Data
		{
			get
			{
				return this.supplier_Invoice_Request_Line_DataField;
			}
			set
			{
				this.supplier_Invoice_Request_Line_DataField = value;
				this.RaisePropertyChanged("Supplier_Invoice_Request_Line_Data");
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
