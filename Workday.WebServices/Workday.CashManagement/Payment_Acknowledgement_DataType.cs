using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.CashManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payment_Acknowledgement_DataType : INotifyPropertyChanged
	{
		private string payment_Processing_IDField;

		private string payment_Message_Batch_IDField;

		private string original_Payment_IDField;

		private string additional_Reconciliation_IDField;

		private string merchant_Account_IDField;

		private Payment_Acknowledgement_StatusObjectType payment_Status_ReferenceField;

		private DateTime payment_Value_DateField;

		private bool payment_Value_DateFieldSpecified;

		private string status_Reason_CodeField;

		private string status_Reason_Code_DescriptionField;

		private string reason_CodeField;

		private string reason_Code_DescriptionField;

		private decimal original_Payment_AmountField;

		private bool original_Payment_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private DateTime original_Payment_DateField;

		private bool original_Payment_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Payment_Processing_ID
		{
			get
			{
				return this.payment_Processing_IDField;
			}
			set
			{
				this.payment_Processing_IDField = value;
				this.RaisePropertyChanged("Payment_Processing_ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Payment_Message_Batch_ID
		{
			get
			{
				return this.payment_Message_Batch_IDField;
			}
			set
			{
				this.payment_Message_Batch_IDField = value;
				this.RaisePropertyChanged("Payment_Message_Batch_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Original_Payment_ID
		{
			get
			{
				return this.original_Payment_IDField;
			}
			set
			{
				this.original_Payment_IDField = value;
				this.RaisePropertyChanged("Original_Payment_ID");
			}
		}

		[XmlElement(Order = 3)]
		public string Additional_Reconciliation_ID
		{
			get
			{
				return this.additional_Reconciliation_IDField;
			}
			set
			{
				this.additional_Reconciliation_IDField = value;
				this.RaisePropertyChanged("Additional_Reconciliation_ID");
			}
		}

		[XmlElement(Order = 4)]
		public string Merchant_Account_ID
		{
			get
			{
				return this.merchant_Account_IDField;
			}
			set
			{
				this.merchant_Account_IDField = value;
				this.RaisePropertyChanged("Merchant_Account_ID");
			}
		}

		[XmlElement(Order = 5)]
		public Payment_Acknowledgement_StatusObjectType Payment_Status_Reference
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

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Payment_Value_Date
		{
			get
			{
				return this.payment_Value_DateField;
			}
			set
			{
				this.payment_Value_DateField = value;
				this.RaisePropertyChanged("Payment_Value_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Value_DateSpecified
		{
			get
			{
				return this.payment_Value_DateFieldSpecified;
			}
			set
			{
				this.payment_Value_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Value_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Status_Reason_Code
		{
			get
			{
				return this.status_Reason_CodeField;
			}
			set
			{
				this.status_Reason_CodeField = value;
				this.RaisePropertyChanged("Status_Reason_Code");
			}
		}

		[XmlElement(Order = 8)]
		public string Status_Reason_Code_Description
		{
			get
			{
				return this.status_Reason_Code_DescriptionField;
			}
			set
			{
				this.status_Reason_Code_DescriptionField = value;
				this.RaisePropertyChanged("Status_Reason_Code_Description");
			}
		}

		[XmlElement(Order = 9)]
		public string Reason_Code
		{
			get
			{
				return this.reason_CodeField;
			}
			set
			{
				this.reason_CodeField = value;
				this.RaisePropertyChanged("Reason_Code");
			}
		}

		[XmlElement(Order = 10)]
		public string Reason_Code_Description
		{
			get
			{
				return this.reason_Code_DescriptionField;
			}
			set
			{
				this.reason_Code_DescriptionField = value;
				this.RaisePropertyChanged("Reason_Code_Description");
			}
		}

		[XmlElement(Order = 11)]
		public decimal Original_Payment_Amount
		{
			get
			{
				return this.original_Payment_AmountField;
			}
			set
			{
				this.original_Payment_AmountField = value;
				this.RaisePropertyChanged("Original_Payment_Amount");
			}
		}

		[XmlIgnore]
		public bool Original_Payment_AmountSpecified
		{
			get
			{
				return this.original_Payment_AmountFieldSpecified;
			}
			set
			{
				this.original_Payment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Original_Payment_AmountSpecified");
			}
		}

		[XmlElement(Order = 12)]
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

		[XmlElement(DataType = "date", Order = 13)]
		public DateTime Original_Payment_Date
		{
			get
			{
				return this.original_Payment_DateField;
			}
			set
			{
				this.original_Payment_DateField = value;
				this.RaisePropertyChanged("Original_Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Original_Payment_DateSpecified
		{
			get
			{
				return this.original_Payment_DateFieldSpecified;
			}
			set
			{
				this.original_Payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Original_Payment_DateSpecified");
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
