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
	public class Customer_Payment_Remittance_Advice_WWS_DataType : INotifyPropertyChanged
	{
		private Customer_Billable_DocumentObjectType[] customer_Invoice_ReferenceField;

		private decimal amount_to_Pay_in_Invoice_CurrencyField;

		private bool amount_to_Pay_in_Invoice_CurrencyFieldSpecified;

		private decimal amount_to_PayField;

		private bool amount_to_PayFieldSpecified;

		private Billable_EntityObjectType billto_Customer_ReferenceField;

		private Customer_Payment_Remittance_Advice_Details_WWS_DataType[] customer_Payment_Remittance_Advice_Details_Replacement_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Customer_Invoice_Reference", Order = 0)]
		public Customer_Billable_DocumentObjectType[] Customer_Invoice_Reference
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

		[XmlElement(Order = 1)]
		public decimal Amount_to_Pay_in_Invoice_Currency
		{
			get
			{
				return this.amount_to_Pay_in_Invoice_CurrencyField;
			}
			set
			{
				this.amount_to_Pay_in_Invoice_CurrencyField = value;
				this.RaisePropertyChanged("Amount_to_Pay_in_Invoice_Currency");
			}
		}

		[XmlIgnore]
		public bool Amount_to_Pay_in_Invoice_CurrencySpecified
		{
			get
			{
				return this.amount_to_Pay_in_Invoice_CurrencyFieldSpecified;
			}
			set
			{
				this.amount_to_Pay_in_Invoice_CurrencyFieldSpecified = value;
				this.RaisePropertyChanged("Amount_to_Pay_in_Invoice_CurrencySpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Amount_to_Pay
		{
			get
			{
				return this.amount_to_PayField;
			}
			set
			{
				this.amount_to_PayField = value;
				this.RaisePropertyChanged("Amount_to_Pay");
			}
		}

		[XmlIgnore]
		public bool Amount_to_PaySpecified
		{
			get
			{
				return this.amount_to_PayFieldSpecified;
			}
			set
			{
				this.amount_to_PayFieldSpecified = value;
				this.RaisePropertyChanged("Amount_to_PaySpecified");
			}
		}

		[XmlElement("Bill-to_Customer_Reference", Order = 3)]
		public Billable_EntityObjectType Billto_Customer_Reference
		{
			get
			{
				return this.billto_Customer_ReferenceField;
			}
			set
			{
				this.billto_Customer_ReferenceField = value;
				this.RaisePropertyChanged("Billto_Customer_Reference");
			}
		}

		[XmlElement("Customer_Payment_Remittance_Advice_Details_Replacement_Data", Order = 4)]
		public Customer_Payment_Remittance_Advice_Details_WWS_DataType[] Customer_Payment_Remittance_Advice_Details_Replacement_Data
		{
			get
			{
				return this.customer_Payment_Remittance_Advice_Details_Replacement_DataField;
			}
			set
			{
				this.customer_Payment_Remittance_Advice_Details_Replacement_DataField = value;
				this.RaisePropertyChanged("Customer_Payment_Remittance_Advice_Details_Replacement_Data");
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
