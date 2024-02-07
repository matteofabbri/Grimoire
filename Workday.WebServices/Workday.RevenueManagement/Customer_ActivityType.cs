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
	public class Customer_ActivityType : INotifyPropertyChanged
	{
		private Reporting_TransactionObjectType reporting_Transaction_ReferenceField;

		private DateTime transaction_DateField;

		private bool transaction_DateFieldSpecified;

		private string transaction_TypeField;

		private string transaction_NumberField;

		private string sequence_NumberField;

		private DateTime invoice_Document_Due_DateField;

		private bool invoice_Document_Due_DateFieldSpecified;

		private decimal transaction_AdditionsField;

		private bool transaction_AdditionsFieldSpecified;

		private decimal transaction_SubtractionsField;

		private bool transaction_SubtractionsFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private Billable_EntityObjectType customer_ReferenceField;

		private OpportunityObjectType opportunity_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Reporting_TransactionObjectType Reporting_Transaction_Reference
		{
			get
			{
				return this.reporting_Transaction_ReferenceField;
			}
			set
			{
				this.reporting_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Reporting_Transaction_Reference");
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
		public string Transaction_Type
		{
			get
			{
				return this.transaction_TypeField;
			}
			set
			{
				this.transaction_TypeField = value;
				this.RaisePropertyChanged("Transaction_Type");
			}
		}

		[XmlElement(Order = 3)]
		public string Transaction_Number
		{
			get
			{
				return this.transaction_NumberField;
			}
			set
			{
				this.transaction_NumberField = value;
				this.RaisePropertyChanged("Transaction_Number");
			}
		}

		[XmlElement(Order = 4)]
		public string Sequence_Number
		{
			get
			{
				return this.sequence_NumberField;
			}
			set
			{
				this.sequence_NumberField = value;
				this.RaisePropertyChanged("Sequence_Number");
			}
		}

		[XmlElement(DataType = "date", Order = 5)]
		public DateTime Invoice_Document_Due_Date
		{
			get
			{
				return this.invoice_Document_Due_DateField;
			}
			set
			{
				this.invoice_Document_Due_DateField = value;
				this.RaisePropertyChanged("Invoice_Document_Due_Date");
			}
		}

		[XmlIgnore]
		public bool Invoice_Document_Due_DateSpecified
		{
			get
			{
				return this.invoice_Document_Due_DateFieldSpecified;
			}
			set
			{
				this.invoice_Document_Due_DateFieldSpecified = value;
				this.RaisePropertyChanged("Invoice_Document_Due_DateSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public decimal Transaction_Additions
		{
			get
			{
				return this.transaction_AdditionsField;
			}
			set
			{
				this.transaction_AdditionsField = value;
				this.RaisePropertyChanged("Transaction_Additions");
			}
		}

		[XmlIgnore]
		public bool Transaction_AdditionsSpecified
		{
			get
			{
				return this.transaction_AdditionsFieldSpecified;
			}
			set
			{
				this.transaction_AdditionsFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_AdditionsSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public decimal Transaction_Subtractions
		{
			get
			{
				return this.transaction_SubtractionsField;
			}
			set
			{
				this.transaction_SubtractionsField = value;
				this.RaisePropertyChanged("Transaction_Subtractions");
			}
		}

		[XmlIgnore]
		public bool Transaction_SubtractionsSpecified
		{
			get
			{
				return this.transaction_SubtractionsFieldSpecified;
			}
			set
			{
				this.transaction_SubtractionsFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_SubtractionsSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
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

		[XmlElement(Order = 10)]
		public OpportunityObjectType Opportunity_Reference
		{
			get
			{
				return this.opportunity_ReferenceField;
			}
			set
			{
				this.opportunity_ReferenceField = value;
				this.RaisePropertyChanged("Opportunity_Reference");
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
