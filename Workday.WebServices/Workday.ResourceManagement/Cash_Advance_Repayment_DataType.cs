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
	public class Cash_Advance_Repayment_DataType : INotifyPropertyChanged
	{
		private string cash_Advance_Repayment_IDField;

		private bool submitField;

		private bool submitFieldSpecified;

		private Spend_AuthorizationObjectType spend_Authorization_ReferenceField;

		private DateTime repayment_DateField;

		private decimal repayment_AmountField;

		private CurrencyObjectType currency_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private string repayment_ReferenceField;

		private string repayment_MemoField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Cash_Advance_Repayment_ID
		{
			get
			{
				return this.cash_Advance_Repayment_IDField;
			}
			set
			{
				this.cash_Advance_Repayment_IDField = value;
				this.RaisePropertyChanged("Cash_Advance_Repayment_ID");
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
		public Spend_AuthorizationObjectType Spend_Authorization_Reference
		{
			get
			{
				return this.spend_Authorization_ReferenceField;
			}
			set
			{
				this.spend_Authorization_ReferenceField = value;
				this.RaisePropertyChanged("Spend_Authorization_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Repayment_Date
		{
			get
			{
				return this.repayment_DateField;
			}
			set
			{
				this.repayment_DateField = value;
				this.RaisePropertyChanged("Repayment_Date");
			}
		}

		[XmlElement(Order = 4)]
		public decimal Repayment_Amount
		{
			get
			{
				return this.repayment_AmountField;
			}
			set
			{
				this.repayment_AmountField = value;
				this.RaisePropertyChanged("Repayment_Amount");
			}
		}

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
		public string Repayment_Reference
		{
			get
			{
				return this.repayment_ReferenceField;
			}
			set
			{
				this.repayment_ReferenceField = value;
				this.RaisePropertyChanged("Repayment_Reference");
			}
		}

		[XmlElement(Order = 8)]
		public string Repayment_Memo
		{
			get
			{
				return this.repayment_MemoField;
			}
			set
			{
				this.repayment_MemoField = value;
				this.RaisePropertyChanged("Repayment_Memo");
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
