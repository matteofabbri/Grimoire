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
	public class Customer_Credit_Card_Profile_DataType : INotifyPropertyChanged
	{
		private string merchant_Customer_Profile_IDField;

		private CustomerObjectType customer_ReferenceField;

		private Customer_Subview_for_Customer_Credit_Card_ProfileType customer_InformationField;

		private bool primary_CardField;

		private bool primary_CardFieldSpecified;

		private Merchant_AccountObjectType merchant_Account_ReferenceField;

		private string merchant_Account_IDField;

		private Credit_Card_TypeObjectType credit_Card_Type_ReferenceField;

		private string first_NameField;

		private string last_NameField;

		private DateTime expiration_DateField;

		private bool expiration_DateFieldSpecified;

		private string last_4_Digits_of_Credit_Card_NumberField;

		private string merchant_Processing_IDField;

		private string reply_Reason_CodeField;

		private string reply_Reason_DescriptionField;

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
		public CustomerObjectType Customer_Reference
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

		[XmlElement(Order = 2)]
		public Customer_Subview_for_Customer_Credit_Card_ProfileType Customer_Information
		{
			get
			{
				return this.customer_InformationField;
			}
			set
			{
				this.customer_InformationField = value;
				this.RaisePropertyChanged("Customer_Information");
			}
		}

		[XmlElement(Order = 3)]
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

		[XmlElement(Order = 4)]
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

		[XmlElement(Order = 5)]
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

		[XmlElement(Order = 6)]
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

		[XmlElement(Order = 7)]
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

		[XmlElement(Order = 8)]
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

		[XmlElement(DataType = "date", Order = 9)]
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

		[XmlElement(Order = 10)]
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

		[XmlElement(Order = 11)]
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

		[XmlElement(Order = 12)]
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

		[XmlElement(Order = 13)]
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

		[XmlElement(Order = 14)]
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
