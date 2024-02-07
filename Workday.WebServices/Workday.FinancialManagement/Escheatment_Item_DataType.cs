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
	public class Escheatment_Item_DataType : INotifyPropertyChanged
	{
		private string idField;

		private bool submitField;

		private bool submitFieldSpecified;

		private CompanyObjectType company_ReferenceField;

		private PaymentObjectType payment_ReferenceField;

		private DateTime escheatment_Item_DateField;

		private bool escheatment_Item_DateFieldSpecified;

		private Payment_CategoryObjectType payment_Category_ReferenceField;

		private Payment_TypeObjectType payment_Type_ReferenceField;

		private PayeeObjectType payee_ReferenceField;

		private DateTime payment_DateField;

		private bool payment_DateFieldSpecified;

		private decimal escheatment_AmountField;

		private bool escheatment_AmountFieldSpecified;

		private CurrencyObjectType currency_ReferenceField;

		private string remit_To_AddressField;

		private DateTime payment_Notification_DateField;

		private bool payment_Notification_DateFieldSpecified;

		private Document_StatusObjectType escheatment_Item_Status_ReferenceField;

		private decimal base_AmountField;

		private bool base_AmountFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
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
		public PaymentObjectType Payment_Reference
		{
			get
			{
				return this.payment_ReferenceField;
			}
			set
			{
				this.payment_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime Escheatment_Item_Date
		{
			get
			{
				return this.escheatment_Item_DateField;
			}
			set
			{
				this.escheatment_Item_DateField = value;
				this.RaisePropertyChanged("Escheatment_Item_Date");
			}
		}

		[XmlIgnore]
		public bool Escheatment_Item_DateSpecified
		{
			get
			{
				return this.escheatment_Item_DateFieldSpecified;
			}
			set
			{
				this.escheatment_Item_DateFieldSpecified = value;
				this.RaisePropertyChanged("Escheatment_Item_DateSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Payment_CategoryObjectType Payment_Category_Reference
		{
			get
			{
				return this.payment_Category_ReferenceField;
			}
			set
			{
				this.payment_Category_ReferenceField = value;
				this.RaisePropertyChanged("Payment_Category_Reference");
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
		public PayeeObjectType Payee_Reference
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

		[XmlElement(DataType = "date", Order = 8)]
		public DateTime Payment_Date
		{
			get
			{
				return this.payment_DateField;
			}
			set
			{
				this.payment_DateField = value;
				this.RaisePropertyChanged("Payment_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_DateSpecified
		{
			get
			{
				return this.payment_DateFieldSpecified;
			}
			set
			{
				this.payment_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_DateSpecified");
			}
		}

		[XmlElement(Order = 9)]
		public decimal Escheatment_Amount
		{
			get
			{
				return this.escheatment_AmountField;
			}
			set
			{
				this.escheatment_AmountField = value;
				this.RaisePropertyChanged("Escheatment_Amount");
			}
		}

		[XmlIgnore]
		public bool Escheatment_AmountSpecified
		{
			get
			{
				return this.escheatment_AmountFieldSpecified;
			}
			set
			{
				this.escheatment_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Escheatment_AmountSpecified");
			}
		}

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
		public string Remit_To_Address
		{
			get
			{
				return this.remit_To_AddressField;
			}
			set
			{
				this.remit_To_AddressField = value;
				this.RaisePropertyChanged("Remit_To_Address");
			}
		}

		[XmlElement(DataType = "date", Order = 12)]
		public DateTime Payment_Notification_Date
		{
			get
			{
				return this.payment_Notification_DateField;
			}
			set
			{
				this.payment_Notification_DateField = value;
				this.RaisePropertyChanged("Payment_Notification_Date");
			}
		}

		[XmlIgnore]
		public bool Payment_Notification_DateSpecified
		{
			get
			{
				return this.payment_Notification_DateFieldSpecified;
			}
			set
			{
				this.payment_Notification_DateFieldSpecified = value;
				this.RaisePropertyChanged("Payment_Notification_DateSpecified");
			}
		}

		[XmlElement(Order = 13)]
		public Document_StatusObjectType Escheatment_Item_Status_Reference
		{
			get
			{
				return this.escheatment_Item_Status_ReferenceField;
			}
			set
			{
				this.escheatment_Item_Status_ReferenceField = value;
				this.RaisePropertyChanged("Escheatment_Item_Status_Reference");
			}
		}

		[XmlElement(Order = 14)]
		public decimal Base_Amount
		{
			get
			{
				return this.base_AmountField;
			}
			set
			{
				this.base_AmountField = value;
				this.RaisePropertyChanged("Base_Amount");
			}
		}

		[XmlIgnore]
		public bool Base_AmountSpecified
		{
			get
			{
				return this.base_AmountFieldSpecified;
			}
			set
			{
				this.base_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Base_AmountSpecified");
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
