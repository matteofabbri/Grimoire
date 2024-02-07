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
	public class Billing_Installment_DataType : INotifyPropertyChanged
	{
		private string billing_Installment_Reference_IDField;

		private Billing_InstallmentObjectType billing_Installment_ReferenceField;

		private Document_StatusObjectType[] status_ReferenceField;

		private DateTime installment_DateField;

		private bool installment_DateFieldSpecified;

		private DateTime due_DateField;

		private bool due_DateFieldSpecified;

		private DateTime from_DateField;

		private bool from_DateFieldSpecified;

		private DateTime to_DateField;

		private bool to_DateFieldSpecified;

		private bool on_HoldField;

		private bool on_HoldFieldSpecified;

		private decimal total_AmountField;

		private bool total_AmountFieldSpecified;

		private Milestone_AbstractObjectType[] milestone_ReferenceField;

		private bool override_Invoice_HeaderField;

		private bool override_Invoice_HeaderFieldSpecified;

		private Payment_TermsObjectType payment_Terms_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string pO_NumberField;

		private Customer_Invoice_TypeObjectType invoice_Type_ReferenceField;

		private string invoice_MemoField;

		private Billing_Installment_Line_DataType[] billing_Installment_Line_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Billing_Installment_Reference_ID
		{
			get
			{
				return this.billing_Installment_Reference_IDField;
			}
			set
			{
				this.billing_Installment_Reference_IDField = value;
				this.RaisePropertyChanged("Billing_Installment_Reference_ID");
			}
		}

		[XmlElement(Order = 1)]
		public Billing_InstallmentObjectType Billing_Installment_Reference
		{
			get
			{
				return this.billing_Installment_ReferenceField;
			}
			set
			{
				this.billing_Installment_ReferenceField = value;
				this.RaisePropertyChanged("Billing_Installment_Reference");
			}
		}

		[XmlElement("Status_Reference", Order = 2)]
		public Document_StatusObjectType[] Status_Reference
		{
			get
			{
				return this.status_ReferenceField;
			}
			set
			{
				this.status_ReferenceField = value;
				this.RaisePropertyChanged("Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Installment_Date
		{
			get
			{
				return this.installment_DateField;
			}
			set
			{
				this.installment_DateField = value;
				this.RaisePropertyChanged("Installment_Date");
			}
		}

		[XmlIgnore]
		public bool Installment_DateSpecified
		{
			get
			{
				return this.installment_DateFieldSpecified;
			}
			set
			{
				this.installment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Installment_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime From_Date
		{
			get
			{
				return this.from_DateField;
			}
			set
			{
				this.from_DateField = value;
				this.RaisePropertyChanged("From_Date");
			}
		}

		[XmlIgnore]
		public bool From_DateSpecified
		{
			get
			{
				return this.from_DateFieldSpecified;
			}
			set
			{
				this.from_DateFieldSpecified = value;
				this.RaisePropertyChanged("From_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime To_Date
		{
			get
			{
				return this.to_DateField;
			}
			set
			{
				this.to_DateField = value;
				this.RaisePropertyChanged("To_Date");
			}
		}

		[XmlIgnore]
		public bool To_DateSpecified
		{
			get
			{
				return this.to_DateFieldSpecified;
			}
			set
			{
				this.to_DateFieldSpecified = value;
				this.RaisePropertyChanged("To_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public bool On_Hold
		{
			get
			{
				return this.on_HoldField;
			}
			set
			{
				this.on_HoldField = value;
				this.RaisePropertyChanged("On_Hold");
			}
		}

		[XmlIgnore]
		public bool On_HoldSpecified
		{
			get
			{
				return this.on_HoldFieldSpecified;
			}
			set
			{
				this.on_HoldFieldSpecified = value;
				this.RaisePropertyChanged("On_HoldSpecified");
			}
		}

		[XmlElement(Order = 8)]
		public decimal Total_Amount
		{
			get
			{
				return this.total_AmountField;
			}
			set
			{
				this.total_AmountField = value;
				this.RaisePropertyChanged("Total_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_AmountSpecified
		{
			get
			{
				return this.total_AmountFieldSpecified;
			}
			set
			{
				this.total_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_AmountSpecified");
			}
		}

		[XmlElement("Milestone_Reference", Order = 9)]
		public Milestone_AbstractObjectType[] Milestone_Reference
		{
			get
			{
				return this.milestone_ReferenceField;
			}
			set
			{
				this.milestone_ReferenceField = value;
				this.RaisePropertyChanged("Milestone_Reference");
			}
		}

		[XmlElement(Order = 10)]
		public bool Override_Invoice_Header
		{
			get
			{
				return this.override_Invoice_HeaderField;
			}
			set
			{
				this.override_Invoice_HeaderField = value;
				this.RaisePropertyChanged("Override_Invoice_Header");
			}
		}

		[XmlIgnore]
		public bool Override_Invoice_HeaderSpecified
		{
			get
			{
				return this.override_Invoice_HeaderFieldSpecified;
			}
			set
			{
				this.override_Invoice_HeaderFieldSpecified = value;
				this.RaisePropertyChanged("Override_Invoice_HeaderSpecified");
			}
		}

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
		public Payment_TypeObjectType Payment_Type_Reference
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

		[XmlElement(Order = 13)]
		public string PO_Number
		{
			get
			{
				return this.pO_NumberField;
			}
			set
			{
				this.pO_NumberField = value;
				this.RaisePropertyChanged("PO_Number");
			}
		}

		[XmlElement(Order = 14)]
		public Customer_Invoice_TypeObjectType Invoice_Type_Reference
		{
			get
			{
				return this.invoice_Type_ReferenceField;
			}
			set
			{
				this.invoice_Type_ReferenceField = value;
				this.RaisePropertyChanged("Invoice_Type_Reference");
			}
		}

		[XmlElement(Order = 15)]
		public string Invoice_Memo
		{
			get
			{
				return this.invoice_MemoField;
			}
			set
			{
				this.invoice_MemoField = value;
				this.RaisePropertyChanged("Invoice_Memo");
			}
		}

		[XmlElement("Billing_Installment_Line_Data", Order = 16)]
		public Billing_Installment_Line_DataType[] Billing_Installment_Line_Data
		{
			get
			{
				return this.billing_Installment_Line_DataField;
			}
			set
			{
				this.billing_Installment_Line_DataField = value;
				this.RaisePropertyChanged("Billing_Installment_Line_Data");
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
