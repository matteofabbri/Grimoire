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
	public class Customer_Credit_Card_Profile_WWS_DataType : INotifyPropertyChanged
	{
		private string merchant_Customer_Profile_IDField;

		private bool primary_CardField;

		private bool primary_CardFieldSpecified;

		private Merchant_AccountObjectType merchant_Account_ReferenceField;

		private Credit_Card_TypeObjectType credit_Card_Type_ReferenceField;

		private string first_NameField;

		private string last_NameField;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private string last_4_Digits_of_Credit_Card_NumberField;

		private string customer_Profile_IDField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Merchant_Customer_Profile_ID
		{
			get
			{
				return this.merchant_Customer_Profile_IDField;
			}
			set
			{
				this.merchant_Customer_Profile_IDField = value;
				this.RaisePropertyChanged("Merchant_Customer_Profile_ID");
			}
		}

		[XmlElement(Order = 1)]
		public bool Primary_Card
		{
			get
			{
				return this.primary_CardField;
			}
			set
			{
				this.primary_CardField = value;
				this.RaisePropertyChanged("Primary_Card");
			}
		}

		[XmlIgnore]
		public bool Primary_CardSpecified
		{
			get
			{
				return this.primary_CardFieldSpecified;
			}
			set
			{
				this.primary_CardFieldSpecified = value;
				this.RaisePropertyChanged("Primary_CardSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public Merchant_AccountObjectType Merchant_Account_Reference
		{
			get
			{
				return this.merchant_Account_ReferenceField;
			}
			set
			{
				this.merchant_Account_ReferenceField = value;
				this.RaisePropertyChanged("Merchant_Account_Reference");
			}
		}

		[XmlElement(Order = 3)]
		public Credit_Card_TypeObjectType Credit_Card_Type_Reference
		{
			get
			{
				return this.credit_Card_Type_ReferenceField;
			}
			set
			{
				this.credit_Card_Type_ReferenceField = value;
				this.RaisePropertyChanged("Credit_Card_Type_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public string First_Name
		{
			get
			{
				return this.first_NameField;
			}
			set
			{
				this.first_NameField = value;
				this.RaisePropertyChanged("First_Name");
			}
		}

		[XmlElement(Order = 5)]
		public string Last_Name
		{
			get
			{
				return this.last_NameField;
			}
			set
			{
				this.last_NameField = value;
				this.RaisePropertyChanged("Last_Name");
			}
		}

		[XmlElement(DataType = "date", Order = 6)]
		public DateTime Expiration_Date
		{
			get
			{
				return this.expiration_DateField;
			}
			set
			{
				this.expiration_DateField = value;
				this.RaisePropertyChanged("Expiration_Date");
			}
		}

		[XmlIgnore]
		public bool Expiration_DateSpecified
		{
			get
			{
				return this.expiration_DateFieldSpecified;
			}
			set
			{
				this.expiration_DateFieldSpecified = value;
				this.RaisePropertyChanged("Expiration_DateSpecified");
			}
		}

		[XmlElement(Order = 7)]
		public string Last_4_Digits_of_Credit_Card_Number
		{
			get
			{
				return this.last_4_Digits_of_Credit_Card_NumberField;
			}
			set
			{
				this.last_4_Digits_of_Credit_Card_NumberField = value;
				this.RaisePropertyChanged("Last_4_Digits_of_Credit_Card_Number");
			}
		}

		[XmlElement(Order = 8)]
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
