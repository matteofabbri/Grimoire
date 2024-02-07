using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Document_Remittance_DataType : INotifyPropertyChanged
	{
		private string document_TypeField;

		private string document_IDField;

		private string document_ReferenceField;

		private DateTime document_DateField;

		private bool document_DateFieldSpecified;

		private decimal total_Payable_AmountField;

		private bool total_Payable_AmountFieldSpecified;

		private decimal amount_PaidField;

		private bool amount_PaidFieldSpecified;

		private decimal amount_DueField;

		private bool amount_DueFieldSpecified;

		private decimal discount_TakenField;

		private bool discount_TakenFieldSpecified;

		private decimal tax_AmountField;

		private bool tax_AmountFieldSpecified;

		private WorkerObjectType worker_ReferenceField;

		private Abstract_Credit_Card_TransactionObjectType[] credit_Card_Transaction_ReferenceField;

		private string additional_InfoField;

		private string document_MemoField;

		private decimal withheld_Tax_AmountField;

		private bool withheld_Tax_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Document_Type
		{
			get
			{
				return this.document_TypeField;
			}
			set
			{
				this.document_TypeField = value;
				this.RaisePropertyChanged("Document_Type");
			}
		}

		[XmlElement(Order = 1)]
		public string Document_ID
		{
			get
			{
				return this.document_IDField;
			}
			set
			{
				this.document_IDField = value;
				this.RaisePropertyChanged("Document_ID");
			}
		}

		[XmlElement(Order = 2)]
		public string Document_Reference
		{
			get
			{
				return this.document_ReferenceField;
			}
			set
			{
				this.document_ReferenceField = value;
				this.RaisePropertyChanged("Document_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Document_Date
		{
			get
			{
				return this.document_DateField;
			}
			set
			{
				this.document_DateField = value;
				this.RaisePropertyChanged("Document_Date");
			}
		}

		[XmlIgnore]
		public bool Document_DateSpecified
		{
			get
			{
				return this.document_DateFieldSpecified;
			}
			set
			{
				this.document_DateFieldSpecified = value;
				this.RaisePropertyChanged("Document_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Total_Payable_Amount
		{
			get
			{
				return this.total_Payable_AmountField;
			}
			set
			{
				this.total_Payable_AmountField = value;
				this.RaisePropertyChanged("Total_Payable_Amount");
			}
		}

		[XmlIgnore]
		public bool Total_Payable_AmountSpecified
		{
			get
			{
				return this.total_Payable_AmountFieldSpecified;
			}
			set
			{
				this.total_Payable_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Total_Payable_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public decimal Amount_Paid
		{
			get
			{
				return this.amount_PaidField;
			}
			set
			{
				this.amount_PaidField = value;
				this.RaisePropertyChanged("Amount_Paid");
			}
		}

		[XmlIgnore]
		public bool Amount_PaidSpecified
		{
			get
			{
				return this.amount_PaidFieldSpecified;
			}
			set
			{
				this.amount_PaidFieldSpecified = value;
				this.RaisePropertyChanged("Amount_PaidSpecified");
			}
		}

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public decimal Discount_Taken
		{
			get
			{
				return this.discount_TakenField;
			}
			set
			{
				this.discount_TakenField = value;
				this.RaisePropertyChanged("Discount_Taken");
			}
		}

		[XmlIgnore]
		public bool Discount_TakenSpecified
		{
			get
			{
				return this.discount_TakenFieldSpecified;
			}
			set
			{
				this.discount_TakenFieldSpecified = value;
				this.RaisePropertyChanged("Discount_TakenSpecified");
			}
		}

		[XmlElement(Order = 8)]
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

		[XmlElement(Order = 9)]
		public WorkerObjectType Worker_Reference
		{
			get
			{
				return this.worker_ReferenceField;
			}
			set
			{
				this.worker_ReferenceField = value;
				this.RaisePropertyChanged("Worker_Reference");
			}
		}

		[XmlElement("Credit_Card_Transaction_Reference", Order = 10)]
		public Abstract_Credit_Card_TransactionObjectType[] Credit_Card_Transaction_Reference
		{
			get
			{
				return this.credit_Card_Transaction_ReferenceField;
			}
			set
			{
				this.credit_Card_Transaction_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Transaction_Reference");
			}
		}

		[XmlElement(Order = 11)]
		public string Additional_Info
		{
			get
			{
				return this.additional_InfoField;
			}
			set
			{
				this.additional_InfoField = value;
				this.RaisePropertyChanged("Additional_Info");
			}
		}

		[XmlElement(Order = 12)]
		public string Document_Memo
		{
			get
			{
				return this.document_MemoField;
			}
			set
			{
				this.document_MemoField = value;
				this.RaisePropertyChanged("Document_Memo");
			}
		}

		[XmlElement(Order = 13)]
		public decimal Withheld_Tax_Amount
		{
			get
			{
				return this.withheld_Tax_AmountField;
			}
			set
			{
				this.withheld_Tax_AmountField = value;
				this.RaisePropertyChanged("Withheld_Tax_Amount");
			}
		}

		[XmlIgnore]
		public bool Withheld_Tax_AmountSpecified
		{
			get
			{
				return this.withheld_Tax_AmountFieldSpecified;
			}
			set
			{
				this.withheld_Tax_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Withheld_Tax_AmountSpecified");
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
