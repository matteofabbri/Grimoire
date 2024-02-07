using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.SettlementServices
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Receiving_Party_Credit_Card_DataType : INotifyPropertyChanged
	{
		private string merchant_Account_IDField;

		private string customer_Profile_IDField;

		private string credit_Card_Authorization_IDField;

		private string merchant_Processing_IDField;

		private bool credit_Card_CreditField;

		private bool credit_Card_CreditFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
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

		[XmlElement(Order = 1)]
		public string Customer_Profile_ID
		{
			get
			{
				return this.customer_Profile_IDField;
			}
			set
			{
				this.customer_Profile_IDField = value;
				this.RaisePropertyChanged("Customer_Profile_ID");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
		public bool Credit_Card_Credit
		{
			get
			{
				return this.credit_Card_CreditField;
			}
			set
			{
				this.credit_Card_CreditField = value;
				this.RaisePropertyChanged("Credit_Card_Credit");
			}
		}

		[XmlIgnore]
		public bool Credit_Card_CreditSpecified
		{
			get
			{
				return this.credit_Card_CreditFieldSpecified;
			}
			set
			{
				this.credit_Card_CreditFieldSpecified = value;
				this.RaisePropertyChanged("Credit_Card_CreditSpecified");
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
