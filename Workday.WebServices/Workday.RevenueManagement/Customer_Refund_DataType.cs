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
	public class Customer_Refund_DataType : INotifyPropertyChanged
	{
		private string customer_Refund_Reference_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime customer_Refund_DateField;

		private decimal total_Refund_AmountField;

		private bool total_Refund_AmountFieldSpecified;

		private string memoField;

		private Billable_EntityObjectType payee_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private Customer_Credit_Card_Profile_AbstractObjectType credit_Card_Profile_ReferenceField;

		private Customer_Unapplied_Payment_Refund_Subedit_DataType[] on_Account_PaymentsField;

		private Customer_Invoice_Adjustment_Refund_Subedit_DataType[] invoice_AdjustmentsField;

		private Financials_Attachment_DataType[] attachment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Customer_Refund_Reference_ID
		{
			get
			{
				return this.customer_Refund_Reference_IDField;
			}
			set
			{
				this.customer_Refund_Reference_IDField = value;
				this.RaisePropertyChanged("Customer_Refund_Reference_ID");
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

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Customer_Refund_Date
		{
			get
			{
				return this.customer_Refund_DateField;
			}
			set
			{
				this.customer_Refund_DateField = value;
				this.RaisePropertyChanged("Customer_Refund_Date");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Total_Refund_Amount
		{
			get
			{
				return this.total_Refund_AmountField;
			}
			set
			{
				this.total_Refund_AmountField = value;
				this.RaisePropertyChanged("Total_Refund_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Refund_AmountSpecified
		{
			get
			{
				return this.total_Refund_AmountFieldSpecified;
			}
			set
			{
				this.total_Refund_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Refund_AmountSpecified");
			}
		}

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
		public Billable_EntityObjectType Payee_Reference
		{
			get
			{
				return this.payee_ReferenceField;
			}
			set
			{
				this.payee_ReferenceField = value;
				this.RaisePropertyChanged("Payee_Reference");
			}
		}

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public Customer_Credit_Card_Profile_AbstractObjectType Credit_Card_Profile_Reference
		{
			get
			{
				return this.credit_Card_Profile_ReferenceField;
			}
			set
			{
				this.credit_Card_Profile_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Profile_Reference");
			}
		}

		[XmlElement("On_Account_Payments", Order = 11)]
		public Customer_Unapplied_Payment_Refund_Subedit_DataType[] On_Account_Payments
		{
			get
			{
				return this.on_Account_PaymentsField;
			}
			set
			{
				this.on_Account_PaymentsField = value;
				this.RaisePropertyChanged("On_Account_Payments");
			}
		}

		[XmlElement("Invoice_Adjustments", Order = 12)]
		public Customer_Invoice_Adjustment_Refund_Subedit_DataType[] Invoice_Adjustments
		{
			get
			{
				return this.invoice_AdjustmentsField;
			}
			set
			{
				this.invoice_AdjustmentsField = value;
				this.RaisePropertyChanged("Invoice_Adjustments");
			}
		}

		[XmlElement("Attachment_Data", Order = 13)]
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
