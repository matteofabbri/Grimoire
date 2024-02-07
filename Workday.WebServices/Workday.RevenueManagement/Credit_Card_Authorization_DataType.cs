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
	public class Credit_Card_Authorization_DataType : INotifyPropertyChanged
	{
		private CurrencyObjectType currency_ReferenceField;

		private decimal credit_Card_Authorization_AmountField;

		private bool credit_Card_Authorization_AmountFieldSpecified;

		private string merchant_Account_IDField;

		private string merchant_Customer_ProfileField;

		private string merchant_Processing_IDField;

		private string reply_Reason_CodeField;

		private string reply_Reason_DescriptionField;

		private string credit_Card_Authorization_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public decimal Credit_Card_Authorization_Amount
		{
			get
			{
				return this.credit_Card_Authorization_AmountField;
			}
			set
			{
				this.credit_Card_Authorization_AmountField = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_Amount");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_Authorization_AmountSpecified
		{
			get
			{
				return this.credit_Card_Authorization_AmountFieldSpecified;
			}
			set
			{
				this.credit_Card_Authorization_AmountFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_AmountSpecified");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public string Merchant_Customer_Profile
		{
			get
			{
				return this.merchant_Customer_ProfileField;
			}
			set
			{
				this.merchant_Customer_ProfileField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile");
			}
		}

		[XmlElement(Order = 4)]
		public string Merchant_Processing_ID
		{
			get
			{
				return this.merchant_Processing_IDField;
			}
			set
			{
				this.merchant_Processing_IDField = value;
				this.RaisePropertyChanged("Merchant_Processing_ID");
			}
		}

		[XmlElement(Order = 5)]
		public string Reply_Reason_Code
		{
			get
			{
				return this.reply_Reason_CodeField;
			}
			set
			{
				this.reply_Reason_CodeField = value;
				this.RaisePropertyChanged("Reply_Reason_Code");
			}
		}

		[XmlElement(Order = 6)]
		public string Reply_Reason_Description
		{
			get
			{
				return this.reply_Reason_DescriptionField;
			}
			set
			{
				this.reply_Reason_DescriptionField = value;
				this.RaisePropertyChanged("Reply_Reason_Description");
			}
		}

		[XmlElement(Order = 7)]
		public string Credit_Card_Authorization_ID
		{
			get
			{
				return this.credit_Card_Authorization_IDField;
			}
			set
			{
				this.credit_Card_Authorization_IDField = value;
				this.RaisePropertyChanged("Credit_Card_Authorization_ID");
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
