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
	public class Supplier_Invoice_Request_Data_InboundType : INotifyPropertyChanged
	{
		private string supplier_Invoice_Request_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private DateTime invoice_DateField;

		private CompanyObjectType company_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private object itemField;

		private object item1Field;

		private decimal control_Total_AmountField;

		private bool control_Total_AmountFieldSpecified;

		private string supplier_Reference_NumberField;

		private Unique_IdentifierObjectType shipTo_Address_ReferenceField;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_Handling_InstructionObjectType handling_Code_ReferenceField;

		private decimal freight_AmountField;

		private bool freight_AmountFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private string memoField;

		private Supplier_Invoice_Request_Line_Data_InboundType[] supplier_Invoice_Request_Line_DataField;

		private Financials_Attachment_DataType[] attachment_DataField;

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
		public bool Submit
		{
			get
			{
				return this.submitField;
			}
			set
			{
				this.submitField = value;
				this.RaisePropertyChanged("Submit");
			}
		}

		[XmlIgnore]
		public bool SubmitSpecified
		{
			get
			{
				return this.submitFieldSpecified;
			}
			set
			{
				this.submitFieldSpecified = value;
				this.RaisePropertyChanged("SubmitSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
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

		[XmlElement("Contingent_Worker_Reference", typeof(Contingent_WorkerObjectType), Order = 5), XmlElement("Supplier_Reference", typeof(SupplierObjectType), Order = 5)]
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

		[XmlElement("Supplier_Connection_Reference", typeof(Supplier_ConnectionObjectType), Order = 6), XmlElement("Use_Default_Supplier_Connection", typeof(bool), Order = 6)]
		public object Item1
		{
			get
			{
				return this.item1Field;
			}
			set
			{
				this.item1Field = value;
				this.RaisePropertyChanged("Item1");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement("Ship-To_Address_Reference", Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement("Supplier_Invoice_Request_Line_Data", Order = 15)]
		public Supplier_Invoice_Request_Line_Data_InboundType[] Supplier_Invoice_Request_Line_Data
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

		[XmlElement("Attachment_Data", Order = 16)]
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
